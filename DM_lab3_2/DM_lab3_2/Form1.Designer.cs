namespace DM_lab3_2
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
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnGenerateB = new System.Windows.Forms.Button();
            this.btnGenerateA = new System.Windows.Forms.Button();
            this.tbSizeB = new System.Windows.Forms.TextBox();
            this.tbSizeA = new System.Windows.Forms.TextBox();
            this.lblSizeB = new System.Windows.Forms.Label();
            this.lblSizeA = new System.Windows.Forms.Label();
            this.gbSetView = new System.Windows.Forms.GroupBox();
            this.lblSetB = new System.Windows.Forms.Label();
            this.lblSetA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvArray = new System.Windows.Forms.DataGridView();
            this.gbInput.SuspendLayout();
            this.gbSetView.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnGenerateB);
            this.gbInput.Controls.Add(this.btnGenerateA);
            this.gbInput.Controls.Add(this.tbSizeB);
            this.gbInput.Controls.Add(this.tbSizeA);
            this.gbInput.Controls.Add(this.lblSizeB);
            this.gbInput.Controls.Add(this.lblSizeA);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInput.Location = new System.Drawing.Point(0, 0);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(467, 88);
            this.gbInput.TabIndex = 6;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Исходные данные";
            // 
            // btnGenerateB
            // 
            this.btnGenerateB.Location = new System.Drawing.Point(250, 52);
            this.btnGenerateB.Name = "btnGenerateB";
            this.btnGenerateB.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateB.TabIndex = 11;
            this.btnGenerateB.Text = "Создать";
            this.btnGenerateB.UseVisualStyleBackColor = true;
            this.btnGenerateB.Click += new System.EventHandler(this.btnGenerateB_Click);
            // 
            // btnGenerateA
            // 
            this.btnGenerateA.Location = new System.Drawing.Point(250, 25);
            this.btnGenerateA.Name = "btnGenerateA";
            this.btnGenerateA.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateA.TabIndex = 10;
            this.btnGenerateA.Text = "Создать";
            this.btnGenerateA.UseVisualStyleBackColor = true;
            this.btnGenerateA.Click += new System.EventHandler(this.btnGenerateA_Click);
            // 
            // tbSizeB
            // 
            this.tbSizeB.Location = new System.Drawing.Point(144, 54);
            this.tbSizeB.Name = "tbSizeB";
            this.tbSizeB.Size = new System.Drawing.Size(100, 20);
            this.tbSizeB.TabIndex = 9;
            // 
            // tbSizeA
            // 
            this.tbSizeA.Location = new System.Drawing.Point(144, 28);
            this.tbSizeA.Name = "tbSizeA";
            this.tbSizeA.Size = new System.Drawing.Size(100, 20);
            this.tbSizeA.TabIndex = 8;
            // 
            // lblSizeB
            // 
            this.lblSizeB.AutoSize = true;
            this.lblSizeB.Location = new System.Drawing.Point(6, 57);
            this.lblSizeB.Name = "lblSizeB";
            this.lblSizeB.Size = new System.Drawing.Size(132, 13);
            this.lblSizeB.TabIndex = 7;
            this.lblSizeB.Text = "Размер 2-го множества:";
            // 
            // lblSizeA
            // 
            this.lblSizeA.AutoSize = true;
            this.lblSizeA.Location = new System.Drawing.Point(6, 31);
            this.lblSizeA.Name = "lblSizeA";
            this.lblSizeA.Size = new System.Drawing.Size(132, 13);
            this.lblSizeA.TabIndex = 6;
            this.lblSizeA.Text = "Размер 1-го множества:";
            // 
            // gbSetView
            // 
            this.gbSetView.Controls.Add(this.lblSetB);
            this.gbSetView.Controls.Add(this.lblSetA);
            this.gbSetView.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSetView.Location = new System.Drawing.Point(0, 88);
            this.gbSetView.Name = "gbSetView";
            this.gbSetView.Size = new System.Drawing.Size(467, 63);
            this.gbSetView.TabIndex = 7;
            this.gbSetView.TabStop = false;
            this.gbSetView.Text = "Сформированные множества";
            // 
            // lblSetB
            // 
            this.lblSetB.AutoSize = true;
            this.lblSetB.Location = new System.Drawing.Point(9, 37);
            this.lblSetB.Name = "lblSetB";
            this.lblSetB.Size = new System.Drawing.Size(78, 13);
            this.lblSetB.TabIndex = 1;
            this.lblSetB.Text = "Множество В:";
            // 
            // lblSetA
            // 
            this.lblSetA.AutoSize = true;
            this.lblSetA.Location = new System.Drawing.Point(9, 20);
            this.lblSetA.Name = "lblSetA";
            this.lblSetA.Size = new System.Drawing.Size(78, 13);
            this.lblSetA.TabIndex = 0;
            this.lblSetA.Text = "Множество А:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAction);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 43);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Текущее действие:";
            // 
            // cbAction
            // 
            this.cbAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(3, 16);
            this.cbAction.Margin = new System.Windows.Forms.Padding(5);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(461, 21);
            this.cbAction.TabIndex = 9;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvArray);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 275);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица бинарных отношений:";
            // 
            // dgvArray
            // 
            this.dgvArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArray.Location = new System.Drawing.Point(3, 16);
            this.dgvArray.Name = "dgvArray";
            this.dgvArray.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvArray.Size = new System.Drawing.Size(461, 256);
            this.dgvArray.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbSetView);
            this.Controls.Add(this.gbInput);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3 | Автор: Власов Илья";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbSetView.ResumeLayout(false);
            this.gbSetView.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btnGenerateB;
        private System.Windows.Forms.Button btnGenerateA;
        private System.Windows.Forms.TextBox tbSizeB;
        private System.Windows.Forms.TextBox tbSizeA;
        private System.Windows.Forms.Label lblSizeB;
        private System.Windows.Forms.Label lblSizeA;
        private System.Windows.Forms.GroupBox gbSetView;
        private System.Windows.Forms.Label lblSetB;
        private System.Windows.Forms.Label lblSetA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArray;
    }
}

