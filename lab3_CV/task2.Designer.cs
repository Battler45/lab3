namespace lab3_CV
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageLoadingButton = new System.Windows.Forms.Button();
            this.imageContainer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLoadingButton
            // 
            this.imageLoadingButton.Location = new System.Drawing.Point(633, 26);
            this.imageLoadingButton.Name = "imageLoadingButton";
            this.imageLoadingButton.Size = new System.Drawing.Size(144, 23);
            this.imageLoadingButton.TabIndex = 0;
            this.imageLoadingButton.Text = "Выберите изображение";
            this.imageLoadingButton.UseVisualStyleBackColor = true;
            this.imageLoadingButton.Click += new System.EventHandler(this.imageLoadingButton_Click);
            // 
            // imageContainer
            // 
            this.imageContainer.Location = new System.Drawing.Point(13, 13);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(775, 425);
            this.imageContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageContainer.TabIndex = 1;
            this.imageContainer.TabStop = false;
            this.imageContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageContainer_MouseClick);
            this.imageContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageContainer_MouseMove);
            this.imageContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageContainer_MouseDown);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageLoadingButton);
            this.Controls.Add(this.imageContainer);
            this.Name = "Task2";
            this.Text = "task2";
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imageLoadingButton;
        private System.Windows.Forms.PictureBox imageContainer;
    }
}