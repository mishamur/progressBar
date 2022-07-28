using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mishakotovProgressBar
{
    /// <summary>
    /// класс отрисовки прогресса в консоли
    /// </summary>
    public class RenderConsole : RenderPersent
    {
        
        protected int progressWidth;
        protected int currentTextSize;
        protected int previousTextSize;


        public RenderConsole(int max) :base(max)
        {
            this.progressWidth = 30;
            Console.CursorVisible = false;
            currentTextSize = 0;
        }

       
        public override void Draw()
        {
            StringBuilder result = CalculateProgress().Append($" {position} | {max}"); ;
            Console.Write(new string('\b', currentTextSize));
            Console.Write(result.ToString());
            currentTextSize = result.Length; //говнокод
        }

        /// <summary>
        /// обработка выходной строки
        /// </summary>
        protected virtual StringBuilder CalculateProgress()
        {
           
            double scale = Math.Round((double)this.progressWidth / max, 8, MidpointRounding.ToNegativeInfinity);
            int progress = (int)Math.Round(Position * scale);
            StringBuilder result = new StringBuilder("[")
                .Append(new String('#', progress) + new String(' ', progressWidth - progress))
                .Append($"]");
            
            return result;
        }
       
    }
}
