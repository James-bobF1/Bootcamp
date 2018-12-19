namespace Bootcamp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nTraiders = new System.Windows.Forms.NumericUpDown();
            this.lguildSize = new System.Windows.Forms.Label();
            this.cbtraiderEquials = new System.Windows.Forms.CheckBox();
            this.naltruist = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ncheater = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ndodger = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nrandomTraider = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nvindictive = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nquirky = new System.Windows.Forms.NumericUpDown();
            this.bcalculateBestTraider = new System.Windows.Forms.Button();
            this.nYears = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nTraiders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naltruist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncheater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndodger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrandomTraider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvindictive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nquirky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYears)).BeginInit();
            this.SuspendLayout();
            // 
            // nTraiders
            // 
            this.nTraiders.Location = new System.Drawing.Point(129, 10);
            this.nTraiders.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nTraiders.Name = "nTraiders";
            this.nTraiders.Size = new System.Drawing.Size(55, 20);
            this.nTraiders.TabIndex = 0;
            this.nTraiders.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nTraiders.ValueChanged += new System.EventHandler(this.nTraiders_ValueChanged);
            // 
            // lguildSize
            // 
            this.lguildSize.AutoSize = true;
            this.lguildSize.Location = new System.Drawing.Point(24, 11);
            this.lguildSize.Name = "lguildSize";
            this.lguildSize.Size = new System.Drawing.Size(61, 13);
            this.lguildSize.TabIndex = 1;
            this.lguildSize.Text = "Торговцев";
            // 
            // cbtraiderEquials
            // 
            this.cbtraiderEquials.AutoSize = true;
            this.cbtraiderEquials.Location = new System.Drawing.Point(248, 10);
            this.cbtraiderEquials.Name = "cbtraiderEquials";
            this.cbtraiderEquials.Size = new System.Drawing.Size(249, 17);
            this.cbtraiderEquials.TabIndex = 2;
            this.cbtraiderEquials.Text = "Случайное распределение по типу торговца";
            this.cbtraiderEquials.UseVisualStyleBackColor = true;
            this.cbtraiderEquials.CheckedChanged += new System.EventHandler(this.cbtraiderEquials_CheckedChanged);
            // 
            // naltruist
            // 
            this.naltruist.Location = new System.Drawing.Point(129, 45);
            this.naltruist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.naltruist.Name = "naltruist";
            this.naltruist.Size = new System.Drawing.Size(55, 20);
            this.naltruist.TabIndex = 3;
            this.naltruist.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.naltruist.ValueChanged += new System.EventHandler(this.anyTraiders_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Альтруистов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кидал";
            // 
            // ncheater
            // 
            this.ncheater.Location = new System.Drawing.Point(129, 71);
            this.ncheater.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncheater.Name = "ncheater";
            this.ncheater.Size = new System.Drawing.Size(55, 20);
            this.ncheater.TabIndex = 5;
            this.ncheater.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncheater.ValueChanged += new System.EventHandler(this.anyTraiders_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Хитрецов";
            // 
            // ndodger
            // 
            this.ndodger.Location = new System.Drawing.Point(129, 97);
            this.ndodger.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndodger.Name = "ndodger";
            this.ndodger.Size = new System.Drawing.Size(55, 20);
            this.ndodger.TabIndex = 7;
            this.ndodger.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ndodger.ValueChanged += new System.EventHandler(this.anyTraiders_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Непредсказуемых";
            // 
            // nrandomTraider
            // 
            this.nrandomTraider.Location = new System.Drawing.Point(129, 122);
            this.nrandomTraider.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nrandomTraider.Name = "nrandomTraider";
            this.nrandomTraider.Size = new System.Drawing.Size(55, 20);
            this.nrandomTraider.TabIndex = 9;
            this.nrandomTraider.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrandomTraider.ValueChanged += new System.EventHandler(this.anyTraiders_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Злопамятных";
            // 
            // nvindictive
            // 
            this.nvindictive.Location = new System.Drawing.Point(129, 148);
            this.nvindictive.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nvindictive.Name = "nvindictive";
            this.nvindictive.Size = new System.Drawing.Size(55, 20);
            this.nvindictive.TabIndex = 11;
            this.nvindictive.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nvindictive.ValueChanged += new System.EventHandler(this.anyTraiders_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ушлых";
            // 
            // nquirky
            // 
            this.nquirky.Location = new System.Drawing.Point(129, 174);
            this.nquirky.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nquirky.Name = "nquirky";
            this.nquirky.Size = new System.Drawing.Size(55, 20);
            this.nquirky.TabIndex = 13;
            this.nquirky.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nquirky.ValueChanged += new System.EventHandler(this.anyTraiders_ValueChanged);
            // 
            // bcalculateBestTraider
            // 
            this.bcalculateBestTraider.Location = new System.Drawing.Point(525, 10);
            this.bcalculateBestTraider.Name = "bcalculateBestTraider";
            this.bcalculateBestTraider.Size = new System.Drawing.Size(133, 20);
            this.bcalculateBestTraider.TabIndex = 17;
            this.bcalculateBestTraider.Text = "запустить Модуляцию";
            this.bcalculateBestTraider.UseVisualStyleBackColor = true;
            this.bcalculateBestTraider.Click += new System.EventHandler(this.bcalculateBestTraider_Click);
            // 
            // nYears
            // 
            this.nYears.Location = new System.Drawing.Point(129, 226);
            this.nYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nYears.Name = "nYears";
            this.nYears.Size = new System.Drawing.Size(55, 20);
            this.nYears.TabIndex = 18;
            this.nYears.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Число лет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nYears);
            this.Controls.Add(this.bcalculateBestTraider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nquirky);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nvindictive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nrandomTraider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ndodger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ncheater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naltruist);
            this.Controls.Add(this.cbtraiderEquials);
            this.Controls.Add(this.lguildSize);
            this.Controls.Add(this.nTraiders);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nTraiders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naltruist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncheater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndodger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrandomTraider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvindictive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nquirky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nTraiders;
        private System.Windows.Forms.Label lguildSize;
        private System.Windows.Forms.CheckBox cbtraiderEquials;
        private System.Windows.Forms.NumericUpDown naltruist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ncheater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ndodger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nrandomTraider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nvindictive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nquirky;
        private System.Windows.Forms.Button bcalculateBestTraider;
        private System.Windows.Forms.NumericUpDown nYears;
        private System.Windows.Forms.Label label8;
    }
}

