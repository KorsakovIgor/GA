using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    //Ген
    class Gene
    {
        //Двоичная последовательность
        public int[] code;

        public bool INT;

        //Значение параметра при вещественном кодировании
        public double Value;

        //Длина гена
        int Length;

        //Минимальное и максимальное значение параметра
        public double Max, Min;

        /// <summary>
        /// Конструктор для целочисленного кодирования
        /// </summary>
        /// <param name="Parameter">Кодируемый параметр</param>
        /// <param name="length">Длина гена</param>
        /// <param name="Xmin">Минимальное значение параметра</param>
        /// <param name="Xmax">Максимальное значение параметра</param>
        public Gene(double Parameter, int length, double Xmin, double Xmax)
        {
            INT = true;
            Max = Xmax; Min = Xmin;
            Length = length;
            int g;

            g = (int)((Parameter - Xmin) * (Math.Pow(2, length) - 1) / (Xmax - Xmin));
            code = new int[length];

            for(int i=0; i<length; i++)
            {
                code[length - 1 - i] = g - (int)(g / 2)*2;
                g = (int)(g / 2);
            }
        }

        /// <summary>
        /// Конструктор для вещественного кодирования
        /// </summary>
        /// <param name="parameter">Кодируемый параметр</param>
        public Gene(double parameter)
        {
            INT = false;
            Value = parameter;
        }

        /// <summary>
        /// Вычисление параметра
        /// </summary>
        /// <returns>Возвращает значение декодированного парамера</returns>
        public double GetValue()
        {
            if (INT)
            {
                int g = 0;
                for (int i = 0; i < Length; i++)
                {
                    g += (int)(code[Length - 1 - i] * Math.Pow(2, i));
                }

                double r;
                r = (g * (Max - Min) / (Math.Pow(2, Length) - 1)) + Min;

                return r;
            }
            else
            {
                return Value;
            }
        }

        /// <summary>
        /// Подсчет количества генов
        /// </summary>
        /// <returns>Возвращает количество генов</returns>
        public int GetLength()
        {
            return this.Length;
        }
    }
}
