namespace DM_lab5
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.pnlN = new System.Windows.Forms.Panel();
            this.lblN = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.gbTableTrue = new System.Windows.Forms.GroupBox();
            this.dgvTableTrue = new System.Windows.Forms.DataGridView();
            this.pnlTitle.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.pnlN.SuspendLayout();
            this.gbTableTrue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSize = true;
            this.pnlTitle.Controls.Add(this.label4);
            this.pnlTitle.Controls.Add(this.label3);
            this.pnlTitle.Controls.Add(this.label2);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(5, 5);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(575, 56);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(575, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "по дисцеплине: \"Дискретная математика\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "на тему: \"Функции булевой алгебры, таблицы истенности\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выполнил: студент группы ИТс-112 Власов Илья";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.gbTableTrue);
            this.gbMain.Controls.Add(this.gbInput);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(5, 61);
            this.gbMain.Margin = new System.Windows.Forms.Padding(7);
            this.gbMain.Name = "gbMain";
            this.gbMain.Padding = new System.Windows.Forms.Padding(7);
            this.gbMain.Size = new System.Drawing.Size(575, 375);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Выполнение:";
            // 
            // gbInput
            // 
            this.gbInput.AutoSize = true;
            this.gbInput.Controls.Add(this.pnlN);
            this.gbInput.Controls.Add(this.lblFunction);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInput.Location = new System.Drawing.Point(7, 20);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(561, 60);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Исходные данные:";
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFunction.Location = new System.Drawing.Point(3, 16);
            this.lblFunction.Margin = new System.Windows.Forms.Padding(10);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Padding = new System.Windows.Forms.Padding(3);
            this.lblFunction.Size = new System.Drawing.Size(265, 19);
            this.lblFunction.TabIndex = 0;
            this.lblFunction.Text = "Исходная функция: (A˅B)( ¬B˅C)<>(A↔C)<>(B→¬C)";
            // 
            // pnlN
            // 
            this.pnlN.Controls.Add(this.tbN);
            this.pnlN.Controls.Add(this.btnCalculate);
            this.pnlN.Controls.Add(this.lblN);
            this.pnlN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlN.Location = new System.Drawing.Point(3, 35);
            this.pnlN.Name = "pnlN";
            this.pnlN.Size = new System.Drawing.Size(555, 22);
            this.pnlN.TabIndex = 1;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblN.Location = new System.Drawing.Point(0, 0);
            this.lblN.Name = "lblN";
            this.lblN.Padding = new System.Windows.Forms.Padding(3);
            this.lblN.Size = new System.Drawing.Size(215, 19);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Введите кол-во переменных в функции:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCalculate.Location = new System.Drawing.Point(480, 0);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Padding = new System.Windows.Forms.Padding(1);
            this.btnCalculate.Size = new System.Drawing.Size(75, 22);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Расчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbN
            // 
            this.tbN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbN.Location = new System.Drawing.Point(215, 0);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(265, 20);
            this.tbN.TabIndex = 4;
            // 
            // gbTableTrue
            // 
            this.gbTableTrue.Controls.Add(this.dgvTableTrue);
            this.gbTableTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTableTrue.Location = new System.Drawing.Point(7, 80);
            this.gbTableTrue.Name = "gbTableTrue";
            this.gbTableTrue.Size = new System.Drawing.Size(561, 288);
            this.gbTableTrue.TabIndex = 1;
            this.gbTableTrue.TabStop = false;
            this.gbTableTrue.Text = "Таблица истенности:";
            // 
            // dgvTableTrue
            // 
            this.dgvTableTrue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableTrue.Location = new System.Drawing.Point(3, 16);
            this.dgvTableTrue.Name = "dgvTableTrue";
            this.dgvTableTrue.RowHeadersVisible = false;
            this.dgvTableTrue.Size = new System.Drawing.Size(555, 269);
            this.dgvTableTrue.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 441);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.pnlTitle);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Лабораторная работа №5";
            this.pnlTitle.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.pnlN.ResumeLayout(false);
            this.pnlN.PerformLayout();
            this.gbTableTrue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Panel pnlN;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.GroupBox gbTableTrue;
        private System.Windows.Forms.DataGridView dgvTableTrue;
    }
}

