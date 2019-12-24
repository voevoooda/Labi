namespace Lab4
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
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.labelRead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(12, 12);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(851, 58);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "СЧИТАТЬ";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(851, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Введите слово";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 108);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(332, 74);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "НАЙТИ";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 188);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(851, 284);
            this.listBox.TabIndex = 4;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(399, 150);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(73, 20);
            this.labelFind.TabIndex = 5;
            this.labelFind.Text = "labelFind";
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Location = new System.Drawing.Point(561, 150);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(81, 20);
            this.labelRead.TabIndex = 6;
            this.labelRead.Text = "labelRead";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Время поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время чтения:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(681, 144);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(167, 26);
            this.textBoxLength.TabIndex = 9;
            this.textBoxLength.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Расстояние";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonRead);
            this.Name = "Form1";
            this.Text = "Толпаров Натан ИУ5-31Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label3;
    }
}

