namespace lab3_CV
{
    partial class Task1
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
            this.imageContainer = new System.Windows.Forms.PictureBox();
            this.imageLoadingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // imageContainer
            // 
            this.imageContainer.Location = new System.Drawing.Point(1, 33);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(798, 414);
            this.imageContainer.TabIndex = 0;
            this.imageContainer.TabStop = false;
            this.imageContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageContainer_MouseDown);
            this.imageContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageContainer_MouseMove);
            this.imageContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageContainer_MouseUp);
            // 
            // imageLoadingButton
            // 
            this.imageLoadingButton.Location = new System.Drawing.Point(697, 4);
            this.imageLoadingButton.Name = "imageLoadingButton";
            this.imageLoadingButton.Size = new System.Drawing.Size(91, 23);
            this.imageLoadingButton.TabIndex = 1;
            this.imageLoadingButton.Text = "LoadImage";
            this.imageLoadingButton.UseVisualStyleBackColor = true;
            this.imageLoadingButton.Click += new System.EventHandler(this.imageLoadingButton_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageLoadingButton);
            this.Controls.Add(this.imageContainer);
            this.Name = "Task1";
            this.Text = "task1";
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageContainer;
        private System.Windows.Forms.Button imageLoadingButton;
    }
}

