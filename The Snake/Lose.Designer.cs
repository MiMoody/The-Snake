namespace The_Snake
{
    partial class Lose
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.forReccord = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.finishGan = new The_Snake.RoundButton();
            this.continueGam = new The_Snake.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = " Вы проиграли!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Попробовать еще раз?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваш счёт = ";
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(237, 117);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 23);
            this.score.TabIndex = 3;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forReccord
            // 
            this.forReccord.AutoSize = true;
            this.forReccord.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forReccord.ForeColor = System.Drawing.Color.Black;
            this.forReccord.Location = new System.Drawing.Point(99, 159);
            this.forReccord.Name = "forReccord";
            this.forReccord.Size = new System.Drawing.Size(133, 29);
            this.forReccord.TabIndex = 8;
            this.forReccord.Text = "Рекорд = ";
            // 
            // record
            // 
            this.record.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record.Location = new System.Drawing.Point(237, 165);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(100, 23);
            this.record.TabIndex = 9;
            this.record.Text = "0";
            this.record.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finishGan
            // 
            this.finishGan.BackColor = System.Drawing.Color.Gainsboro;
            this.finishGan.BackColor2 = System.Drawing.Color.Silver;
            this.finishGan.ButtonBorderColor = System.Drawing.Color.Black;
            this.finishGan.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.finishGan.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.finishGan.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.finishGan.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.finishGan.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.finishGan.ButtonPressedForeColor = System.Drawing.Color.White;
            this.finishGan.ButtonRoundRadius = 30;
            this.finishGan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishGan.Location = new System.Drawing.Point(242, 295);
            this.finishGan.Name = "finishGan";
            this.finishGan.Size = new System.Drawing.Size(127, 52);
            this.finishGan.TabIndex = 7;
            this.finishGan.Text = "Нет, я сдался";
            this.finishGan.Click += new System.EventHandler(this.finishGan_Click);
            // 
            // continueGam
            // 
            this.continueGam.BackColor = System.Drawing.Color.Gainsboro;
            this.continueGam.BackColor2 = System.Drawing.Color.Silver;
            this.continueGam.ButtonBorderColor = System.Drawing.Color.Black;
            this.continueGam.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.continueGam.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.continueGam.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.continueGam.ButtonPressedColor = System.Drawing.Color.LightGray;
            this.continueGam.ButtonPressedColor2 = System.Drawing.Color.LightGray;
            this.continueGam.ButtonPressedForeColor = System.Drawing.Color.White;
            this.continueGam.ButtonRoundRadius = 30;
            this.continueGam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueGam.Location = new System.Drawing.Point(54, 295);
            this.continueGam.Name = "continueGam";
            this.continueGam.Size = new System.Drawing.Size(127, 52);
            this.continueGam.TabIndex = 6;
            this.continueGam.Text = "Конечно!";
            this.continueGam.Click += new System.EventHandler(this.continueGam_Click);
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(445, 395);
            this.Controls.Add(this.record);
            this.Controls.Add(this.forReccord);
            this.Controls.Add(this.finishGan);
            this.Controls.Add(this.continueGam);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Lose";
            this.Text = "Вы проиграли!";
            this.Load += new System.EventHandler(this.Lose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label score;
        private RoundButton continueGam;
        private RoundButton finishGan;
        private System.Windows.Forms.Label forReccord;
        private System.Windows.Forms.Label record;
    }
}