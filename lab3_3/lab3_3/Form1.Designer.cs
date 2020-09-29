namespace lab3_3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Brezenheim = new System.Windows.Forms.Button();
            this.button_VU = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // button_Brezenheim
            // 
            this.button_Brezenheim.Enabled = false;
            this.button_Brezenheim.Location = new System.Drawing.Point(648, 12);
            this.button_Brezenheim.Name = "button_Brezenheim";
            this.button_Brezenheim.Size = new System.Drawing.Size(123, 23);
            this.button_Brezenheim.TabIndex = 1;
            this.button_Brezenheim.Text = "Брезенхейм";
            this.button_Brezenheim.UseVisualStyleBackColor = true;
            this.button_Brezenheim.Click += new System.EventHandler(this.Change_Method);
            // 
            // button_VU
            // 
            this.button_VU.Location = new System.Drawing.Point(648, 73);
            this.button_VU.Name = "button_VU";
            this.button_VU.Size = new System.Drawing.Size(123, 23);
            this.button_VU.TabIndex = 2;
            this.button_VU.Text = "ВУ";
            this.button_VU.UseVisualStyleBackColor = true;
            this.button_VU.Click += new System.EventHandler(this.Change_Method);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_VU);
            this.Controls.Add(this.button_Brezenheim);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Brezenheim;
        private System.Windows.Forms.Button button_VU;
        private System.Windows.Forms.Button button1;
    }
}

