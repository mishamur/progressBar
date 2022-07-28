using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mishakotovProgressBar
{
    /// <summary>
    /// Базовый класс отрисовки прогресса
    /// </summary>
    public abstract class RenderBase
    {
        protected int max;
        protected int position;
        public int Position 
        { 
            get
            {
                return position; 
            }
            set
            {
                if(value >= 0 && value <= max)
                {
                    position = value;
                }
                else
                {
                    position = 0;
                }
            }
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="max">максимальное кол-во элементов</param>
        public RenderBase(int max)
        {
            if(max <= 0)
            {
                this.max = 1;
            }
            else
            {
                this.max = max;
            }
            
            this.Position = 0;
        }

        /// <summary>
        /// Имитирует процесс отрисовки
        /// </summary>
        public virtual void Imitation()
        {
            while(position <= max)
            {
                this.Draw();
                position++;
                Thread.Sleep(20);
            }
            
        }

        public virtual void Draw() { }

    }
}
