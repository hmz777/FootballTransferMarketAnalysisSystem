using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetClips.Logic
{
    public interface IClipsController
    {       
        void InitController();
        void SendParameters();
        void GetResult();
    }
}
