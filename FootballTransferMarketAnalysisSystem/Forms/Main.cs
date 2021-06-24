using DotNetClips.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetClips.Forms
{
    public partial class Main : Form
    {
        #region Instance Fields

        ClipsBasicController ClipsController;
        Process ClipsProcess;
        string ClipsFilePath;
        string ClipsSoftwarePath;

        #endregion

        #region Static Fields

        #endregion

        #region Constructor

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons Events

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (var Control in Controls)
            {
                switch (Control)
                {
                    case ComboBox CB:
                        CB.SelectedIndex = -1;
                        break;
                    case NumericUpDown NUD:
                        NUD.Value = NUD.Minimum;
                        break;
                    case TextBox TB:
                        TB.Clear();
                        break;
                    default:
                        break;
                }
            }

            File.Delete("System.clp");
            File.Delete("Clips.bat");
        }

        private async void ResultButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            var DataModel = new DataModel
            {
                MaxAge = (int)AgeBox.SelectedValue,
                PlayStyle = (string)StyleBox.SelectedValue,
                MaxPotential = (int)PotentialBox.Value,
                Position = (string)PositionBox.SelectedValue,
                MaxMarketValue = (long)ValueBox.Value,
                PreferredFoot = (string)FootBox.SelectedValue
            };

            ToggleLoading();

            var BatchFilePath = await ClipsController.EnsureClipsBatchFileCreated(ClipsFilePath, DataModel);
            string Output = null;

            using (ClipsProcess = new Process())
            {
                var ClipsArgs = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    FileName = ClipsSoftwarePath,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    Arguments = $"-f2 \"{BatchFilePath}\""
                };

                ClipsProcess.StartInfo = ClipsArgs;

                await Task.Run(async () =>
                {
                    ClipsProcess.Start();
                    Output = await ClipsProcess.StandardOutput.ReadToEndAsync();
                    ClipsProcess.WaitForExit();
                });
            }

            ToggleLoading();

            try
            {
                var ResultList = new PlayerList(ParseData(Output));
                ResultList.ShowDialog();
                ResultList.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var OFD = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "(CLP File)|*.clp",
                Multiselect = false,
                Title = "Select CLIPS File"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                ClipsFilePath = OFD.FileName;
            }

            OFD.Dispose();
        }

        private void LocateClipsButton_Click(object sender, EventArgs e)
        {
            var OFD = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "(EXE File)|*.exe",
                Multiselect = false,
                Title = "Locate CLIPS Software"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                ClipsSoftwarePath = OFD.FileName;
            }

            OFD.Dispose();
        }

        #endregion

        #region Form Events

        private void Main_Load(object sender, EventArgs e)
        {
            ClipsController = new ClipsBasicController((int)DataCountBox.Minimum);

            AgeBox.DataSource = DataController.GetAgeDataSource();
            FootBox.DataSource = DataController.GetPreferredFootDataSource();
            PositionBox.DataSource = DataController.GetPlayerPositionsDataSource();
            StyleBox.DataSource = DataController.GetPlayStyleDataSource();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            ClipsSoftwarePath = LocateCLIPS();

            if (!string.IsNullOrEmpty(ClipsSoftwarePath))
            {
                MessageBox.Show("CLIPS located successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClipsFilePath = LocateCLIPSFile();

            if (!string.IsNullOrEmpty(ClipsFilePath))
            {
                MessageBox.Show("CLP file located successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.Delete("System.clp");
                File.Delete("Clips.bat");
            }
            catch
            {
            }
        }

        #endregion

        #region Menu Strip Events

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Tools

        public bool ValidateFields()
        {
            foreach (Control Control in Controls)
            {
                switch (Control)
                {
                    case ComboBox CB:
                        if (CB.SelectedIndex == -1)
                        {
                            MessageBox.Show("You must fill all the available options!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        break;
                    case NumericUpDown NUD:
                        if (NUD.Value == 0)
                        {
                            MessageBox.Show("Zero is not a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        break;
                    case TextBox TB:
                        if (!TB.Multiline && !File.Exists(TB.Text))
                        {
                            MessageBox.Show("Enter a valid path for CLIPS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        break;
                }
            }

            if (string.IsNullOrEmpty(ClipsFilePath))
            {
                MessageBox.Show("You must locate the CLP file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(ClipsSoftwarePath))
            {
                MessageBox.Show("You must locate the CLIPS software!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void ToggleLoading()
        {
            LoadingSpinner.Visible = !LoadingSpinner.Visible;

            foreach (Control Control in Controls)
            {
                if (Control.GetType() == typeof(PictureBox))
                {
                    continue;
                }

                Control.Enabled = !Control.Enabled;
            }
        }

        public string LocateCLIPS()
        {
            string ClipsPath;

            if (Environment.Is64BitOperatingSystem)
            {
                string ClipsPath1 = @"C:\Program Files\CLIPS 6.4\CLIPSDOS.exe";
                string ClipsPath2 = @"C:\Program Files (x86)\CLIPS 6.4\CLIPSDOS.exe";

                if (File.Exists(ClipsPath1))
                {
                    ClipsPath = ClipsPath1;
                }
                else if (File.Exists(ClipsPath2))
                {
                    ClipsPath = ClipsPath2;
                }
                else
                {
                    ClipsPath = null;
                }
            }
            else
            {
                string ClipsPath1 = @"C:\Program Files\CLIPS 6.4\CLIPSDOS.exe";

                if (File.Exists(ClipsPath1))
                {
                    ClipsPath = ClipsPath1;
                }
                else
                {
                    ClipsPath = null;
                }
            }

            return ClipsPath;
        }

        public string LocateCLIPSFile()
        {
            var Files = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"UserSystem.clp");

            if (Files.Count() > 0)
            {
                return Files[0];
            }
            else
            {
                return null;
            }
        }

        public List<PlayerViewModel> ParseData(string Data)
        {
            var PlayersText = Data.Trim().Split('/');
            var Players = new List<PlayerViewModel>();

            //if (PlayersText.Count() > 0)
            //{
            //    if (PlayersText[0].Contains('!'))
            //    {
            //        PlayersText[0] = PlayersText[0].Remove(PlayersText[0].IndexOf('%'), PlayersText[0].LastIndexOf('*') + 1).Trim();
            //    }
            //}

            foreach (var Player in PlayersText)
            {
                var PlayerSegments = Player.Split('#');

                if (PlayerSegments.Count() < 6)
                {
                    continue;
                }

                Players.Add(new PlayerViewModel { Name = PlayerSegments[0], Age = int.Parse(PlayerSegments[1]), Nationality = PlayerSegments[2], Club = PlayerSegments[3], Potential = int.Parse(PlayerSegments[4]), Value = int.Parse(PlayerSegments[5]) });
            }

            return Players;
        }

        #endregion

        private void DataCountBox_ValueChanged(object sender, EventArgs e)
        {
            if (ClipsController != null)
            {
                ClipsController.DataCount = (int)DataCountBox.Value;
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            var Random = new Random();

            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case NumericUpDown NUD:
                        NUD.Value = Random.Next(1, (int)NUD.Maximum);
                        break;
                    case ComboBox CB:
                        CB.SelectedIndex = Random.Next(0, CB.Items.Count - 1);
                        break;
                    default:
                        break;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
            about.Dispose();
        }
    }
}