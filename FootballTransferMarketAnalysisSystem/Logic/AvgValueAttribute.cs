using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetClips.Logic
{
    public class AvgValueAttribute : Attribute
    {
        public int Value { get; set; }

        public AvgValueAttribute()
        {
        }
    }
}
