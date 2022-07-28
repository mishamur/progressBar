using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mishakotovProgressBar
{
    public class RenderPersent : RenderBase
    {
        public RenderPersent(int max) :base(max)
        {

        }
        public int GetPercent()
        {
            return position * 100 / max;
        }
    }
}
