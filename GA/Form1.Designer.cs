namespace GA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FitnessFunction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimumX = new System.Windows.Forms.TextBox();
            this.MaximumX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CountIndividuals = new System.Windows.Forms.NumericUpDown();
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pmutation = new System.Windows.Forms.NumericUpDown();
            this.Pcrossover = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Pinverse = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxPopul = new System.Windows.Forms.CheckBox();
            this.checkBoxINTCODE = new System.Windows.Forms.CheckBox();
            this.checkBoxRossen = new System.Windows.Forms.CheckBox();
            this.RealCode = new System.Windows.Forms.RadioButton();
            this.IntCode = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Tournament = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.maxIter = new System.Windows.Forms.NumericUpDown();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GenLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountIndividuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pmutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcrossover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pinverse)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tournament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIter)).BeginInit();
            this.SuspendLayout();
            // 
            // FitnessFunction
            // 
            this.FitnessFunction.Location = new System.Drawing.Point(16, 47);
            this.FitnessFunction.Name = "FitnessFunction";
            this.FitnessFunction.Size = new System.Drawing.Size(980, 26);
            this.FitnessFunction.TabIndex = 0;
            this.FitnessFunction.Text = "x0^2+x1^2";
            this.FitnessFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Целевая функция:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1071, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поисковый Интевал:";
            // 
            // MinimumX
            // 
            this.MinimumX.Location = new System.Drawing.Point(1003, 47);
            this.MinimumX.Name = "MinimumX";
            this.MinimumX.Size = new System.Drawing.Size(132, 26);
            this.MinimumX.TabIndex = 3;
            this.MinimumX.Text = "-10";
            this.MinimumX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaximumX
            // 
            this.MaximumX.Location = new System.Drawing.Point(1161, 47);
            this.MaximumX.Name = "MaximumX";
            this.MaximumX.Size = new System.Drawing.Size(133, 26);
            this.MaximumX.TabIndex = 4;
            this.MaximumX.Text = "10";
            this.MaximumX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Длина генов:";
            // 
            // GenLength
            // 
            this.GenLength.Location = new System.Drawing.Point(258, 102);
            this.GenLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.GenLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenLength.Name = "GenLength";
            this.GenLength.Size = new System.Drawing.Size(57, 26);
            this.GenLength.TabIndex = 7;
            this.GenLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество особей:";
            // 
            // CountIndividuals
            // 
            this.CountIndividuals.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CountIndividuals.Location = new System.Drawing.Point(258, 134);
            this.CountIndividuals.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CountIndividuals.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CountIndividuals.Name = "CountIndividuals";
            this.CountIndividuals.Size = new System.Drawing.Size(57, 26);
            this.CountIndividuals.TabIndex = 9;
            this.CountIndividuals.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(12, 368);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(419, 471);
            this.Answer.TabIndex = 10;
            this.Answer.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 74);
            this.button1.TabIndex = 11;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вероятность мутации:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вероятность скрещивания:";
            // 
            // Pmutation
            // 
            this.Pmutation.Location = new System.Drawing.Point(258, 167);
            this.Pmutation.Name = "Pmutation";
            this.Pmutation.Size = new System.Drawing.Size(57, 26);
            this.Pmutation.TabIndex = 14;
            // 
            // Pcrossover
            // 
            this.Pcrossover.Location = new System.Drawing.Point(258, 199);
            this.Pcrossover.Name = "Pcrossover";
            this.Pcrossover.Size = new System.Drawing.Size(57, 26);
            this.Pcrossover.TabIndex = 15;
            this.Pcrossover.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Вероятность инверсии:";
            // 
            // Pinverse
            // 
            this.Pinverse.Location = new System.Drawing.Point(258, 231);
            this.Pinverse.Name = "Pinverse";
            this.Pinverse.Size = new System.Drawing.Size(57, 26);
            this.Pinverse.TabIndex = 17;
            this.Pinverse.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkBoxPopul);
            this.groupBox1.Controls.Add(this.checkBoxINTCODE);
            this.groupBox1.Controls.Add(this.checkBoxRossen);
            this.groupBox1.Controls.Add(this.RealCode);
            this.groupBox1.Controls.Add(this.IntCode);
            this.groupBox1.Location = new System.Drawing.Point(430, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 227);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "итераций";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(369, 169);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 26);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "бит каждые";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 170);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Дополнительные операторы:";
            // 
            // checkBoxPopul
            // 
            this.checkBoxPopul.AutoSize = true;
            this.checkBoxPopul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxPopul.Location = new System.Drawing.Point(7, 201);
            this.checkBoxPopul.Name = "checkBoxPopul";
            this.checkBoxPopul.Size = new System.Drawing.Size(221, 24);
            this.checkBoxPopul.TabIndex = 4;
            this.checkBoxPopul.Text = "Популяционный всплеск";
            this.checkBoxPopul.UseVisualStyleBackColor = true;
            // 
            // checkBoxINTCODE
            // 
            this.checkBoxINTCODE.AutoSize = true;
            this.checkBoxINTCODE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxINTCODE.Location = new System.Drawing.Point(7, 171);
            this.checkBoxINTCODE.Name = "checkBoxINTCODE";
            this.checkBoxINTCODE.Size = new System.Drawing.Size(196, 24);
            this.checkBoxINTCODE.TabIndex = 3;
            this.checkBoxINTCODE.Text = "Уплотнение сетки на";
            this.checkBoxINTCODE.UseVisualStyleBackColor = true;
            // 
            // checkBoxRossen
            // 
            this.checkBoxRossen.AutoSize = true;
            this.checkBoxRossen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRossen.Location = new System.Drawing.Point(7, 141);
            this.checkBoxRossen.Name = "checkBoxRossen";
            this.checkBoxRossen.Size = new System.Drawing.Size(179, 24);
            this.checkBoxRossen.TabIndex = 2;
            this.checkBoxRossen.Text = "Метод Розенброка";
            this.checkBoxRossen.UseVisualStyleBackColor = true;
            // 
            // RealCode
            // 
            this.RealCode.AutoSize = true;
            this.RealCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RealCode.Location = new System.Drawing.Point(7, 65);
            this.RealCode.Name = "RealCode";
            this.RealCode.Size = new System.Drawing.Size(251, 24);
            this.RealCode.TabIndex = 1;
            this.RealCode.Text = "Вещественное кодирование";
            this.RealCode.UseVisualStyleBackColor = true;
            // 
            // IntCode
            // 
            this.IntCode.AutoSize = true;
            this.IntCode.Checked = true;
            this.IntCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntCode.Location = new System.Drawing.Point(7, 34);
            this.IntCode.Name = "IntCode";
            this.IntCode.Size = new System.Drawing.Size(259, 24);
            this.IntCode.TabIndex = 0;
            this.IntCode.TabStop = true;
            this.IntCode.Text = "Целочисленное кодирование";
            this.IntCode.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1161, 184);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 64);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Размер турнира:";
            // 
            // Tournament
            // 
            this.Tournament.Location = new System.Drawing.Point(258, 263);
            this.Tournament.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Tournament.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Tournament.Name = "Tournament";
            this.Tournament.Size = new System.Drawing.Size(57, 26);
            this.Tournament.TabIndex = 21;
            this.Tournament.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Максимум итераций ГА:";
            // 
            // maxIter
            // 
            this.maxIter.Location = new System.Drawing.Point(258, 295);
            this.maxIter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxIter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIter.Name = "maxIter";
            this.maxIter.Size = new System.Drawing.Size(57, 26);
            this.maxIter.TabIndex = 23;
            this.maxIter.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsEnableHZoom = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(437, 368);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(857, 469);
            this.zedGraphControl1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1003, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 64);
            this.button2.TabIndex = 25;
            this.button2.Text = "Построить график";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1003, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 57);
            this.progressBar1.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1161, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 74);
            this.button3.TabIndex = 27;
            this.button3.Text = "Сохранить в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 851);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.maxIter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Tournament);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pinverse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Pcrossover);
            this.Controls.Add(this.Pmutation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.CountIndividuals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaximumX);
            this.Controls.Add(this.MinimumX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FitnessFunction);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генетические Алгоритмы";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GenLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountIndividuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pmutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcrossover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pinverse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tournament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FitnessFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinimumX;
        private System.Windows.Forms.TextBox MaximumX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown GenLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CountIndividuals;
        private System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Pmutation;
        private System.Windows.Forms.NumericUpDown Pcrossover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Pinverse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RealCode;
        private System.Windows.Forms.RadioButton IntCode;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Tournament;
        private System.Windows.Forms.CheckBox checkBoxPopul;
        private System.Windows.Forms.CheckBox checkBoxINTCODE;
        private System.Windows.Forms.CheckBox checkBoxRossen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown maxIter;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
    }
}

