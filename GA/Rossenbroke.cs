using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Martixx;
using Lab3AG;
using ParserAG;

namespace Rossenbroke
{
    public class Rossenbroke
    {
        
        public int _iter;
        public Vector ResultVector;
        public List<Vector> Position;

        double _eps;
        Vector _X0;
        string _func;
        int _count;

        public Rossenbroke(string func, Vector X0)
        {
            Parser parser = new Parser();

            this._eps = 10e-5;

            this._func = func;
            this._count = Convert.ToInt32(parser.CheckParse(this._func));

            _X0 = new Vector(X0.ch.Count);
            _X0.NullInit();
            _X0 += X0;

            double[] ch = new double[_count];
        }


        public void Run()
        {
            Position = new List<Vector>();


            Vector[] A = new Vector[this._count];
            Vector[] B = new Vector[this._count];
            Vector[] d = new Vector[this._count];


            Vector[] P = new Vector[this._count];
            for (int i = 0; i < this._count; i++)
            {
                P[i] = new Vector(this._count);
                P[i].NullInit();
                P[i].ch[i] = 1;
            }

            int iter = 0;
            Lab3 lab3;
            do
            {
                Vector curX = _X0;
                Position.Add(_X0);

                Vector alpha = new Vector(this._count); alpha.NullInit();

                Vector tempX = curX;

                for (int i = 0; i < this._count; i++)
                {

                    lab3 = null;
                    lab3 = new Lab3();
                    alpha.ch[i] = lab3.Start(this._func, tempX, P[i], _eps);
                    tempX = lab3.Point(tempX, alpha.ch[i]);
                    Position.Add(tempX);
                }

                curX = tempX;

                if (alpha.Norm() <= this._eps) break;
                else
                {
                    for (int i = 0; i < this._count; i++)
                    {
                        if (Math.Abs(alpha.ch[i]) <= this._eps) A[i] = P[i];
                        else
                        {
                            Vector tempV = new Vector(this._count);
                            tempV.NullInit();

                            for (int k = i; k < this._count; k++)
                            {
                                tempV += alpha.ch[k] * P[k];
                            }
                            A[i] = tempV;
                        }



                        if (i == 0) B[i] = A[i];
                        else
                        {
                            Vector tempV = new Vector(this._count); tempV.NullInit();
                            for (int k = 0; k < i; k++)
                            {
                                tempV += (A[i] * d[k]) * d[k];
                            }
                            B[i] = A[i] - tempV;
                        }

                        d[i] = B[i];
                        d[i].Normilize();

                        P[i] = d[i];
                    }

                    _X0 = curX;

                    iter++; if (iter >= 30) break;
                }
            } while (true);

            ResultVector = this._X0;
            _count = iter;
            
        }

        public string Result()
        {
            string Result;

            Result = "";

            Result += "Минимум в точке: " + ResultVector.printVector() + "\r\n";
            Result += "Количество итераций: " + _count + "\r\n\r\n";


            return Result;
        }
    }
}