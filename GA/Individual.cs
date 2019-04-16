using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Martixx;
using ParserAG;

namespace GA
{
    //Особь
    class Individual
    {
        //Количество параметров
        private int _count;

        //Список генов - хромосома
        public List<Gene> chromosome;

        //Случайная величина
        static Random rand = new Random();

        public string Func;

        //Приспособленность
        public double fitness;

        /// <summary>
        /// Конструктор для целочисленного кодирования
        /// </summary>
        /// <param name="count">Количество параметров</param>
        /// <param name="length">Длина гена</param>
        /// <param name="Xmax">Маскимальное значение вариации параметров</param>
        /// <param name="Xmin">Минимальное значение вариации параметров</param>
        /// <param name="func">Целевая функция</param>
        public Individual(int count, int length, double Xmin, double Xmax, string func)
        {
            chromosome = new List<Gene>();
            _count = count;
            this.Func = func;
            for(int i=0; i<count; i++)
            {
                chromosome.Add(new Gene(Individual.rand.NextDouble() * (Xmax - Xmin) + Xmin, length, Xmin, Xmax));
            }

            Parser parser = new Parser();
            double[] x = new double[this._count];
            for (int i = 0; i < this._count; i++)
            {
                x[i] = chromosome[i].GetValue();
            }
            Vector X = new Vector(x);
            this.fitness = Convert.ToDouble(parser.Parse(func, X.ch));
        }

        /// <summary>
        /// Конструктор для вещественного кодирования
        /// </summary>
        /// <param name="count">Количество параметров</param>
        /// <param name="Xmin">Минимальное значение варьируемого параметра</param>
        /// <param name="Xmax">Максимальное значение варьируемого параметра</param>
        /// <param name="func">Фитнесс функция</param>
        public Individual(int count, double Xmin, double Xmax, string func)
        {
            chromosome = new List<Gene>();
            _count = count;
            this.Func = func;
            for (int i = 0; i < count; i++)
            {
                chromosome.Add(new Gene(Individual.rand.NextDouble() * (Xmax - Xmin) + Xmin));
            }

            Parser parser = new Parser();
            double[] x = new double[this._count];
            for (int i = 0; i < this._count; i++)
            {
                x[i] = chromosome[i].GetValue();
            }
            Vector X = new Vector(x);
            this.fitness = Convert.ToDouble(parser.Parse(func, X.ch));
        }

        /// <summary>
        /// Копирование особи
        /// </summary>
        /// <param name="count">Количество параметров</param>
        /// <param name="Ind">Копируемая особь</param>
        public Individual(int count, Individual Ind)
        {
            chromosome = new List<Gene>();
            _count = count;
            fitness = Ind.fitness;
            Func = Ind.Func;

            if (Ind.chromosome[0].INT)
            {
                for (int i = 0; i < _count; i++)
                {
                    chromosome.Add(new Gene(Ind.chromosome[i].GetValue(), Ind.chromosome[i].GetLength(), Ind.chromosome[i].Min, Ind.chromosome[i].Max));
                }
            }
            else
            {
                for (int i = 0; i < _count; i++)
                {
                    chromosome.Add(new Gene(Ind.chromosome[i].GetValue()));
                }
            }
        }

        /// <summary>
        /// Вычисление вектора значений параметров особи
        /// </summary>
        /// <returns>DВозвращает вектор значений</returns>
        public Vector GetVector()
        {
            double[] x = new double[this._count];
            for (int i = 0; i < this._count; i++)
            {
                x[i] = chromosome[i].GetValue();
            }
            Vector X = new Vector(x);
            return X;
        }

        /// <summary>
        /// Расчет фитнесс функции
        /// </summary>
        public void CalcFitness()
        {
            Parser parser = new Parser();
            /*double[] x=new double[this._count];
            for(int i=0; i<this._count; i++)
            {
                x[i]=chromosome[i].GetValue();
            }
            Vector X = new Vector(x);*/

            this.fitness = Convert.ToDouble(parser.Parse(this.Func, this.GetVector().ch));
        }

    }
}
