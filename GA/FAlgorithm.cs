using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParserAG;
using Martixx;

namespace GA
{
    public class FAlgorithm
    {
        public ProgressBar progress;

        /// <summary>
        /// Взаимная привлекательность светлячков при нулевом расстоянии
        /// </summary>
        double beta0;

        /// <summary>
        /// Коэффициет поглощения света средой
        /// </summary>
        double gamma;

        /// <summary>
        /// Свободный параметр радномизации
        /// </summary>
        double alpha;

        static Random rand = new Random();

        public double maximum, minimum;
        int CountParam;
        public string func;
        Parser parser = new Parser();

        /// <summary>
        /// Размер популяции
        /// </summary>
        int CountP;

        /// <summary>
        /// Количество итераций алгоритма
        /// </summary>
        int MaxIter;

        List<Vector> population;

        public FAlgorithm(int MaxIt, double B0, double G, double Al, int Pop, string f)
        {
            this.CountP = Pop;
            this.beta0 = B0;
            this.MaxIter = MaxIt;
            this.alpha = Al;
            this.gamma = G;
            CountParam = Convert.ToInt32(parser.CheckParse(func));
        }

        /// <summary>
        /// Инициализация популяция
        /// </summary>
        void InitPopulation()
        {
            population = new List<Vector>();
            for (int i = 0; i < CountP; i++)
            {
                double[] v = new double[CountParam];
                for (int j = 0; j < CountParam; j++)
                {
                    v[j] = minimum + FAlgorithm.rand.NextDouble() * (maximum - minimum);
                }
                population.Add(new Vector(v));
            }
        }

        double Distance(Vector v1, Vector v2)
        {
            double sum = 0;
            for (int i = 0; i < CountParam; i++)
            {
                sum += (v1.ch[i] - v2.ch[i]) * (v1.ch[i] - v2.ch[i]);
            }
            return Math.Sqrt(sum);
        }

        /// <summary>
        /// Перемещение Светлячков
        /// </summary>
        void FireflyMove()
        {
            for (int i = 0; i < CountP; i++)
            {
                for (int j = 0; j < CountP; j++)
                {
                    if (Convert.ToDouble(parser.Parse(func, population[i].ch)) > Convert.ToDouble(parser.Parse(func, population[j].ch)))
                    {
                        double beta = beta0 / (1 + gamma * Math.Pow(Distance(population[i], population[j]), 2));
                        double U = -1 + FAlgorithm.rand.NextDouble() * 2;

                        for (int k = 0; k < CountParam; k++)
                        {
                            population[i].ch[k] = beta * (population[i].ch[k] - population[j].ch[k]) + alpha * U;
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Расчет по алгоритму светлячков
        /// </summary>
        /// <param name="P"></param>
        /// <returns></returns>
        public string Calculate()
        {
            InitPopulation();
            for (int i = 0; i < MaxIter; i++)
            {
                FireflyMove();
                progress.PerformStep();
            }

            string res = Convert.ToDouble(parser.Parse(func, population[0].ch)).ToString();
            for (int i = 1; i < CountP - 1; i++)
            {
                if (Convert.ToDouble(parser.Parse(func, population[i].ch)) < Convert.ToDouble(parser.Parse(func, population[i + 1].ch)))
                {
                    res = Convert.ToDouble(parser.Parse(func, population[i].ch)).ToString();
                }
            }

            return res;
        }
    }
}
