using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserAG;


namespace GA
{
    class GeneticAlgorithm
    {
        //Количество параметров
        int CountParam;

        //Количество особей
        int CountInd;

        //Целевая функция
        string func;

        //вариация параметров
        double Xmin, Xmax;

        //Размер турнира
        public int tournament;

        //длина гена
        int GenLen;

        //Дополнительные операторы
        public bool[] operators;

        //Целочисленное кодирование
        public bool intcode;

        //Максималье количество итераций
        public int MaxIter;

        //Вероятность мутации, инверсии, скрещивания
        public double Pm, Pi, Pc;

        //Уплотнение сетки: количество бит и итераций
        public int Ubit, UIter;

        //ВРандом
        private static Random rand = new Random();

        public System.Windows.Forms.ProgressBar a;

        public GeneticAlgorithm(int LG, int I, double xmax, double xmin, string Func)
        {
            operators = new bool[3];
            Parser parser = new Parser();
            this.CountParam = Convert.ToInt32(parser.CheckParse(Func));
            this.CountInd = I;
            this.func = Func;
            this.Xmax = xmax;
            this.Xmin = xmin;
            this.GenLen = LG;
        }

        /// <summary>
        /// Инициализация популяции
        /// </summary>
        /// <returns>Популяция случайных особей</returns>
        private Population InitPopulation()
        {
            if (intcode)
            {
                Population p = new Population(this.CountInd, this.CountParam, this.GenLen, this.Xmin, this.Xmax, this.func);
                return p;
            }
            else
            {
                Population p = new Population(this.CountInd, this.CountParam, this.Xmin, this.Xmax, this.func);
                return p;
            }
        }

        /// <summary>
        /// Поиск минимального элемента в целочисленном массиве
        /// </summary>
        /// <param name="a">массив</param>
        /// <returns>Возвращает минимальное значение</returns>
        private int Min(int[] a)
        {
            int min = a[0];
            for(int i=1; i<a.Length; i++)
            {
                if (min > a[i]) min = a[i];
            }
            return min;
        }
        
        /// <summary>
        /// Селекция
        /// </summary>
        /// <param name="input">Популяция</param>
        /// <returns>Возвращает отобранные особи</returns>
        private Population Selection (Population input)
        {
            Population Result = new Population();
            int[] numberInd = new int[tournament];
            while (Result.GetCountInd()<CountInd)
            {
                //Выбор номеров особей для турнира
                for(int i=0; i<tournament; i++)
                {
                    numberInd[i] = GeneticAlgorithm.rand.Next(CountInd);
                }

                Result.add(input.individuals[Min(numberInd)]);
            }

            return Result;
        }

        /// <summary>
        /// Метод меняет местами 2 целочисленные переменные
        /// </summary>
        /// <param name="a">1-я переменная</param>
        /// <param name="b">2-я переменная</param>
        private void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        /// <summary>
        /// Метод меняет местами 2 вещественные переменные
        /// </summary>
        /// <param name="a">1-я переменная</param>
        /// <param name="b">2-я переменная</param>
        private void Swap(ref double a, ref double b)
        {
            double c;
            c = a;
            a = b;
            b = c;
        }

        /// <summary>
        /// Скрещивание при целочисленном кодировании
        /// </summary>
        /// <param name="Input">Популяция</param>
        /// <returns>Возвращает популяцию потомков</returns>
        private Population CrossoverINT (Population Input)
        {
            int numBit, numGen, numInd1=0, numInd2=0;
            Population Result = new Population();
            while(Result.GetCountInd()<CountInd)
            {
                //Генерация бита, с которого начнется одноточечное скрещивание
                numBit = GeneticAlgorithm.rand.Next(GenLen);
                numGen = GeneticAlgorithm.rand.Next(CountParam);
                do
                {
                    //генерация номеров особей, который будут скрещиваться
                    numInd1 = GeneticAlgorithm.rand.Next(CountInd);
                    numInd2 = GeneticAlgorithm.rand.Next(CountInd);
                } while (numInd1 == numInd2);

               //если особи скрещиваются
                if (GeneticAlgorithm.rand.NextDouble() < Pc)
                {
                    Result.add(new Individual(CountParam, Input.individuals[numInd1]));
                    Result.add(new Individual(CountParam, Input.individuals[numInd2]));

                    for (int i = numBit; i < GenLen; i++)
                    {
                        Swap(ref Result.individuals[Result.GetCountInd()-1].chromosome[numGen].code[numBit], ref Result.individuals[Result.GetCountInd() - 2].chromosome[numGen].code[numBit]);
                    }

                    for (int i = numGen + 1; i < CountParam; i++)
                    {
                        for (int j = 0; j < GenLen; j++)
                        {
                            Swap(ref Result.individuals[Result.GetCountInd() - 1].chromosome[i].code[j], ref Result.individuals[Result.GetCountInd() - 2].chromosome[i].code[j]);
                        }
                    }

                    Result.individuals[Result.GetCountInd() - 1].CalcFitness();
                    Result.individuals[Result.GetCountInd() - 2].CalcFitness();
                }
                
                //Если особи не скрещиваются
                else
                {
                    Result.add(new Individual(CountParam, Input.individuals[numInd1]));
                    Result.add(new Individual(CountParam, Input.individuals[numInd2]));
                }

              }

            return Result;

            }


        /// <summary>
        /// Скрещивание при вещественном кодировании
        /// </summary>
        /// <param name="Input">Популяция</param>
        /// <returns>Возвращает популяцию потомков</returns>
        private Population CrossoverREAL(Population Input)
        {
            int numGen, numInd1 = 0, numInd2 = 0;
            Population Result = new Population();
            while (Result.GetCountInd() < CountInd)
            {
                //Генерация гена, с которого начнется одноточечное скрещивание
                numGen = GeneticAlgorithm.rand.Next(CountParam);
                do
                {
                    //генерация номеров особей, который будут скрещиваться
                    numInd1 = GeneticAlgorithm.rand.Next(CountInd);
                    numInd2 = GeneticAlgorithm.rand.Next(CountInd);
                } while (numInd1 == numInd2);

                //если особи скрещиваются
                if (GeneticAlgorithm.rand.NextDouble() < Pc)
                {
                    Result.add(new Individual(CountParam, Input.individuals[numInd1]));
                    Result.add(new Individual(CountParam, Input.individuals[numInd2]));

                    for (int i = numGen; i < CountParam; i++)
                    {
                        
                         Swap(ref Result.individuals[Result.GetCountInd() - 1].chromosome[i].Value, ref Result.individuals[Result.GetCountInd() - 2].chromosome[i].Value);
                        
                    }

                    Result.individuals[Result.GetCountInd() - 1].CalcFitness();
                    Result.individuals[Result.GetCountInd() - 2].CalcFitness();
                }

                //Если особи не скрещиваются
                else
                {
                    Result.add(new Individual(CountParam, Input.individuals[numInd1]));
                    Result.add(new Individual(CountParam, Input.individuals[numInd2]));
                }

            }

            return Result;

        }

        /// <summary>
        /// Операор мутации
        /// </summary>
        /// <param name="Input">Исходная популяция</param>
        /// <returns>Мутирующая популяция</returns>
        private Population Mutation(Population Input)
        {
            //мутация при целочисленном кодировании
            if (intcode)
            {
                for (int i = 0; i < CountInd; i++)
                {
                    for (int j = 0; j < CountParam; j++)
                    {
                        for (int k = 0; k < GenLen; k++)
                        {
                            if (GeneticAlgorithm.rand.NextDouble() < Pm)
                            {
                                if (Input.individuals[i].chromosome[j].code[k] == 0)
                                    Input.individuals[i].chromosome[j].code[k] = 1;
                                else
                                    Input.individuals[i].chromosome[j].code[k] = 0;
                                
                            }
                        }
                    }
                    Input.individuals[i].CalcFitness();
                }
                return Input;
            }

            //инверсия при вещественном кодировании
            else
            {
                
                for (int i = 0; i < CountInd; i++)
                {
                    for (int j = 0; j < CountParam; j++)
                    {
                        if (GeneticAlgorithm.rand.NextDouble() < Pm)
                        {
                            Input.individuals[i].chromosome[j].Value += (2 * GeneticAlgorithm.rand.NextDouble() - 1);   
                        }
                    }
                    Input.individuals[i].CalcFitness();
                }
                return Input;

            }
        }

        /// <summary>
        /// Оператор инверсии
        /// </summary>
        /// <param name="Input">Популяция</param>
        /// <returns>Возвращает новую популяцию</returns>
        private Population Inverse(Population Input)
        {
            //инверсия при целочисленном кодировании
            if (intcode)
            {
                int NumBit, NumGen;
                for (int i = 0; i < CountInd; i++)
                {
                    if (GeneticAlgorithm.rand.NextDouble() < Pi)
                    {
                        NumBit = GeneticAlgorithm.rand.Next(GenLen);
                        NumGen = GeneticAlgorithm.rand.Next(CountParam);
                        if (Input.individuals[i].chromosome[NumGen].code[NumBit] == 0)
                            Input.individuals[i].chromosome[NumGen].code[NumBit] = 1;
                        else
                            Input.individuals[i].chromosome[NumGen].code[NumBit] = 0;
                        Input.individuals[i].CalcFitness();
                    }
                }
                return Input;
            }

            //инверсия при вещественном кодировании
            else
            {
                int NumGen;
                for (int i = 0; i < CountInd; i++)
                {
                    if (GeneticAlgorithm.rand.NextDouble() < Pi)
                    {
                        NumGen = GeneticAlgorithm.rand.Next(CountParam);
                        Input.individuals[i].chromosome[NumGen].Value += (2 * GeneticAlgorithm.rand.NextDouble() - 1);
                        Input.individuals[i].CalcFitness();
                    }
                }
                return Input;

            }
        }

        /// <summary>
        /// Сортировка популяции по возрастанию фитнесс функции особей
        /// </summary>
        /// <param name="p">Популяция</param>
        /// <returns>Возвращает отсортированную популяцию</returns>
        public Population SortInd(Population p)
        {
            Individual c;
            for (int i = 0; i < (CountInd - 1); i++)
            {
                for (int j = (i + 1); j < CountInd; j++)
                {
                    if (p.individuals[j].fitness < p.individuals[i].fitness)
                    {
                        c = p.individuals[j];
                        p.individuals[j] = p.individuals[i];
                        p.individuals[i] = c;
                    }
                }
            }

            return p;
        }

        public string Answer(int k, Population p)
        {
            string result = "";
            result += "Итерация: " + k.ToString() + Environment.NewLine;
            for (int i = 0; i < CountParam; i++)
            {
                result += p.individuals[0].chromosome[i].GetValue().ToString() + Environment.NewLine;
            }

            result += "Значение функции: " + p.individuals[0].fitness.ToString() + Environment.NewLine + Environment.NewLine;
            return result;

        }

        /// <summary>
        /// Уплотнение сетки целочисленного кодирования
        /// </summary>
        /// <param name="p">Исходная популяция</param>
        /// <returns>Возвращает новую популяцию</returns>
        private Population MeshSeal(Population Input)
        {
            Population Result = new Population();
            this.GenLen = this.GenLen + this.Ubit;
            double value;

            for(int i=0; i<CountInd; i++)
            {
                Result.add(Input.individuals[i]);
                for(int j=0; j<CountParam; j++)
                {
                    value = Result.individuals[i].chromosome[j].GetValue();
                    Result.individuals[i].chromosome[j] = new Gene(value, GenLen, Xmin, Xmax);
                    value = value = Result.individuals[i].chromosome[j].GetValue();
                }
            }
            return Result;

        }

        /// <summary>
        /// Оператор популяционного всплеска
        /// </summary>
        /// <param name="Input">Исходная популяция</param>
        /// <returns>Возвращает популяцию после популяционного всплеска</returns>
        Population PopulationOutbreak(Population Input)
        {
            Population Result = new Population();
            for (int i = 0; i < (int)(CountInd / 2); i++)
            {
                Result.add(Input.individuals[i]);
            }

            for (int i= (int)(CountInd / 2); i<CountInd; i++)
            {
                if(intcode)
                {
                    Result.add(new Individual(CountParam, GenLen, Xmin, Xmax, func));
                }
                else
                {
                    Result.add(new Individual(CountParam, Xmin, Xmax, func));
                }
            }

            return Result;
        }

        /// <summary>
        /// Генетический алгоритм
        /// </summary>
        /// <param name="Best">Массив лучших фитнесс функций на каждой итерации</param>
        /// <param name="Mid">Массив средних сзначений фитнесс функций на каждой итерации</param>
        /// <returns>Возвращает строку лучших особей на каждой итерации</returns>
        public string Start(out double[] Best, out double[] Mid)
        {
            Best = new double[MaxIter + 1];
            Mid = new double[MaxIter + 1];

            int Outbreak = 0;
            string result = "";
            Population p = new Population();
            int k = 1;

            //Инициализация популяции
            p = InitPopulation();
            //Сортировка популяции
            p = SortInd(p);

            result += "Исходные данные:" + Environment.NewLine;
            for (int i = 0; i < CountParam; i++)
            {
                result += p.individuals[0].chromosome[i].GetValue().ToString() + Environment.NewLine;
            }
            result += "Значение функции: " + p.individuals[0].fitness.ToString() + Environment.NewLine + Environment.NewLine;

            Best[0] = p.individuals[0].fitness;
            Mid[0] = p.Middle();

           //Начало Алгоритма
            while (true)
            {
                a.PerformStep();
                //Селекция
                p = Selection(p);

                //Скрещивание
                if (intcode)
                {
                    p = CrossoverINT(p);
                }
                else
                {
                    p = CrossoverREAL(p);
                }

                //Инверсия
                p = Inverse(p);

                //Мутация
                p = Mutation(p);

                //Сотрировка
                p=SortInd(p);

                result += Answer(k, p);
                Best[k] = p.individuals[0].fitness;
                Mid[k] = p.Middle();

                
                //КОП
                if (k == MaxIter) break;

                //Уплотнение сетки
                if ((k%UIter==0)&&operators[1])
                {  
                    p = MeshSeal(p);
                    result += "Уплотнение сетки. Длина гена: " + (GenLen).ToString() + Environment.NewLine;
                }
                

                if (Best[k]==Best[k-1]) Outbreak++;

                //Популяционный всплеск
                if((Outbreak==5)&&operators[2])
                {
                    result += "Популяционный всплеск" + Environment.NewLine;
                    p = PopulationOutbreak(p);
                    Outbreak = 0;
                }

                
                k++;
            }
            
            //Метод Розенброка
            if(operators[0])
            {
                result += "Начало метода Розенброка:" + Environment.NewLine;
                Martixx.Vector X = p.individuals[0].GetVector();
                Rossenbroke.Rossenbroke Res = new Rossenbroke.Rossenbroke(func, X);
                Res.Run();
                result += Res.Result();
            }

            return result;
        }


   }
}

