using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    //Популяция
    class Population
    {
        //Список особей
        public List<Individual> individuals;

        //Количество особей
        int _CountInd;

        /// <summary>
        /// Конструктор для целочисленного кодирования
        /// </summary>
        /// <param name="CountInd">Количество особей</param>
        /// <param name="CountParam">Количество параметров</param>
        /// <param name="length">Длина гена</param>
        /// <param name="Xmin">Минимальное значение варьируемого параметра</param>
        /// <param name="Xmax">Максимальное значение варьируемого параметра</param>
        /// <param name="func">Целевая функция</param>
        public Population(int CountInd, int CountParam, int length, double Xmin, double Xmax, string func)
        {
            individuals = new List<Individual>();
            _CountInd = CountInd;
            for (int i=0; i<CountInd; i++)
            {
                individuals.Add(new Individual(CountParam, length, Xmin, Xmax, func));
            }
        }

        /// <summary>
        /// Конструктор вещественного кодирования
        /// </summary>
        /// <param name="CountInd">Количестов особей</param>
        /// <param name="CountParam">Количество параметров</param>
        /// <param name="Xmin">Минимальное значение варьируемого параметра</param>
        /// <param name="Xmax">Максимальное значение варьируемого параметра</param>
        /// <param name="func">Фитнесс функция</param>
        public Population(int CountInd, int CountParam, double Xmin, double Xmax, string func)
        {
            _CountInd = CountInd;
            individuals = new List<Individual>();
            for (int i = 0; i < CountInd; i++)
            {
                individuals.Add(new Individual(CountParam, Xmin, Xmax, func));
            }
        }

        /// <summary>
        /// Инициализация пустой популяции
        /// </summary>
        public Population()
        {
            _CountInd = 0;
            individuals = new List<Individual>();
            
        }

        /// <summary>
        /// Добавление особи в популяцию
        /// </summary>
        /// <param name="a">Особь</param>
        public void add(Individual a)
        {
            individuals.Add(a);
            _CountInd++;
        }

        public int GetCountInd()
        {
            return _CountInd;
        }

        /// <summary>
        /// Вычисление среднего значения фитнесс функции особей популяции
        /// </summary>
        /// <returns>Возвращает среднее значение фитнесс функции особей популяции</returns>
        public double Middle()
        {
            double result = 0;
            for (int i=0; i<_CountInd; i++)
            {
                result += individuals[i].fitness;
            }

            return result / _CountInd;
        }

    }
}
