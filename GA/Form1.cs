using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;


namespace GA
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        double[] best;
        double[] Mid;
        string RESULT;

        private void InitializeGA (GeneticAlgorithm ga)
        {
            ga.Pm = Convert.ToDouble(Pmutation.Value) / 100;
            ga.Pi = Convert.ToDouble(Pinverse.Value) / 100;
            ga.Pc = Convert.ToDouble(Pcrossover.Value) / 100;
            ga.tournament = Convert.ToInt32(Tournament.Value);
            ga.MaxIter = Convert.ToInt32(maxIter.Value);
            ga.intcode = IntCode.Checked;
            ga.operators[0] = checkBoxRossen.Checked;
            ga.operators[1] = checkBoxINTCODE.Checked;
            ga.operators[2] = checkBoxPopul.Checked;
            ga.Ubit = Convert.ToInt32(numericUpDown1.Value);
            ga.UIter = Convert.ToInt32(numericUpDown2.Value);
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = ga.MaxIter;
            progressBar1.Step = 1;
            ga.a = progressBar1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RESULT = "";
                GeneticAlgorithm ga = new GeneticAlgorithm(Convert.ToInt32(GenLength.Value), Convert.ToInt32(CountIndividuals.Value), Convert.ToDouble(MinimumX.Text), Convert.ToDouble(MaximumX.Text), FitnessFunction.Text);
                InitializeGA(ga);

                if ((ga.operators[1] == true) && (ga.intcode == false))
                {
                    MessageBox.Show("Уплотнение сетки возможно только при целочисленном кодировании", "Ошибка входных данных", MessageBoxButtons.OK);
                }
                else
                {
                    RESULT = ga.Start(out best, out Mid);
                    Answer.Text = RESULT;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверный формат входных данных", "Ошибка входных данных", MessageBoxButtons.OK);
            }
            catch(Exception)
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Получим панель для рисования
                GraphPane pane = zedGraphControl1.GraphPane;

                pane.XAxis.Scale.MajorStep = 5.0;
                pane.XAxis.Scale.MinorStep = 1.0;

                //Подпись осей и графика
                pane.Title.Text = "График зависимости значений фитнесс функции от числа итераций";
                pane.XAxis.Title.Text = "Итерация";
                pane.YAxis.Title.Text = "Значение фитнесс функции";

                // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
                pane.CurveList.Clear();

                // Создадим список точек для кривой f1(x)
                PointPairList f1_list = new PointPairList();

                // Создадим список точек для кривой f2(x)
                PointPairList f2_list = new PointPairList();

                double xmin = 0;
                double xmax = Convert.ToDouble(maxIter.Value);

                // !!!
                // Заполним массив точек для кривой f1(x)
                for (double x = xmin; x <= xmax; x++)
                {
                    f1_list.Add(x, best[(int)x]);
                }

                // !!!
                // Заполним массив точек для кривой f2(x)
                // Интервал и шаги по X могут не совпадать на разных кривых
                for (double x = xmin; x <= xmax; x++)
                {
                    f2_list.Add(x, Mid[(int)x]);
                }

                // !!!
                // Создадим кривую 
                // которая будет рисоваться голубым цветом (Color.Blue),
                // Опорные точки выделяться не будут (SymbolType.None)
                LineItem f1_curve = pane.AddCurve("Лучшая Особье", f1_list, Color.Blue, SymbolType.None);

                // !!!
                // Создадим кривую 
                // которая будет рисоваться красным цветом (Color.Red),
                // Опорные точки будут выделяться плюсиками (SymbolType.Plus)
                LineItem f2_curve = pane.AddCurve("Среднее По Популяции", f2_list, Color.Red, SymbolType.None);

                // !!!
                // Устанавливаем интересующий нас интервал по оси X
                pane.XAxis.Scale.Min = xmin;
                pane.XAxis.Scale.Max = xmax;

                // Вызываем метод AxisChange (), чтобы обновить данные об осях.
                // В противном случае на рисунке будет показана только часть графика,
                // которая умещается в интервалы по осям, установленные по умолчанию
                zedGraphControl1.AxisChange();

                // Обновляем график
                zedGraphControl1.Invalidate();
            }
            catch(Exception)
            {
                MessageBox.Show("Невозможно построить график\nНет значений", "Ошибка", MessageBoxButtons.OK);
            }    
    }

        private void File()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = "c:\\";
                sfd.Filter = "Текстовый файл (*.txt)|*.txt";
                sfd.FilterIndex = 1;

                sfd.FileName = "GaResult";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(sfd.OpenFile());
                    file.Write(RESULT);
                    file.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка сохранения", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.File();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Сохранить результаты?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.File();
            }
        }
    }
}
