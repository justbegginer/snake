﻿namespace zmeyka
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
            this.text = new System.Windows.Forms.Label();
            this.GameArea = new System.Windows.Forms.PictureBox();
            this.TimerWork = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(384, 30);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(35, 13);
            this.text.TabIndex = 0;
            this.text.Text = "label1";
            // 
            // GameArea
            // 
            this.GameArea.BackColor = System.Drawing.Color.Maroon;
            this.GameArea.Location = new System.Drawing.Point(12, 46);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(776, 392);
            this.GameArea.TabIndex = 1;
            this.GameArea.TabStop = false;
            this.GameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint);
            // 
            // TimerWork
            // 
            this.TimerWork.Enabled = true;
            this.TimerWork.Tick += new System.EventHandler(this.WorkTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameArea);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown0);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox GameArea;
        private System.Windows.Forms.Timer TimerWork;
    }
}

