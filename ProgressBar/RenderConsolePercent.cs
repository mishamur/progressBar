using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mishakotovProgressBar
{
    public sealed class RenderConsolePercent : RenderConsole
    {

        public RenderConsolePercent(int max) : base(max)
        {

        }
        public override void Draw()
        {
            StringBuilder result = CalculateProgress().Append($" {this.GetPercent()}%"); ;
            Console.Write(new string('\b', currentTextSize));
            Console.Write(result.ToString());
            currentTextSize = result.Length;
        }
    
    }
}
