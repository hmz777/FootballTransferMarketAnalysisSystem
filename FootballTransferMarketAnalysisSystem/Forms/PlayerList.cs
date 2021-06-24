using DotNetClips.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetClips.Forms
{
    public partial class PlayerList : Form
    {
        private readonly List<PlayerViewModel> playerViewModels;

        public PlayerList(List<PlayerViewModel> playerViewModels)
        {
            InitializeComponent();

            this.playerViewModels = playerViewModels;
        }

        private void PlayerList_Load(object sender, EventArgs e)
        {
            PList.DataSource = playerViewModels;
            CountLabel.Text = playerViewModels.Count.ToString();
        }
    }
}
