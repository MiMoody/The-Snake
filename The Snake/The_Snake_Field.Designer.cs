namespace The_Snake
{
    partial class The_Snake_Field
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
            this.components = new System.ComponentModel.Container();
            this.playField = new System.Windows.Forms.PictureBox();
            this.updateField = new System.Windows.Forms.Timer(this.components);
            this.forScore = new System.Windows.Forms.Label();
            this.labscore = new System.Windows.Forms.Label();
            this.labSpace = new System.Windows.Forms.Label();
            this.labESC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playField)).BeginInit();
            this.SuspendLayout();
            // 
            // playField
            // 
            this.playField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playField.Location = new System.Drawing.Point(3, 49);
            this.playField.Name = "playField";
            this.playField.Size = new System.Drawing.Size(510, 510);
            this.playField.TabIndex = 0;
            this.playField.TabStop = false;
            // 
            // updateField
            // 
            this.updateField.Enabled = true;
            this.updateField.Interval = 150;
            this.updateField.Tick += new System.EventHandler(this.updateField_Tick);
            // 
            // forScore
            // 
            this.forScore.AutoSize = true;
            this.forScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forScore.ForeColor = System.Drawing.Color.Black;
            this.forScore.Location = new System.Drawing.Point(484, 22);
            this.forScore.Name = "forScore";
            this.forScore.Size = new System.Drawing.Size(15, 15);
            this.forScore.TabIndex = 8;
            this.forScore.Text = "0";
            // 
            // labscore
            // 
            this.labscore.AutoSize = true;
            this.labscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labscore.ForeColor = System.Drawing.Color.Black;
            this.labscore.Location = new System.Drawing.Point(421, 22);
            this.labscore.Name = "labscore";
            this.labscore.Size = new System.Drawing.Size(51, 15);
            this.labscore.TabIndex = 7;
            this.labscore.Text = "Очки =";
            // 
            // labSpace
            // 
            this.labSpace.AutoSize = true;
            this.labSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSpace.ForeColor = System.Drawing.Color.Black;
            this.labSpace.Location = new System.Drawing.Point(187, 19);
            this.labSpace.Name = "labSpace";
            this.labSpace.Size = new System.Drawing.Size(224, 15);
            this.labSpace.TabIndex = 6;
            this.labSpace.Text = "Нажмите Space для пуска/паузы";
            // 
            // labESC
            // 
            this.labESC.AutoSize = true;
            this.labESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labESC.ForeColor = System.Drawing.Color.Black;
            this.labESC.Location = new System.Drawing.Point(4, 19);
            this.labESC.Name = "labESC";
            this.labESC.Size = new System.Drawing.Size(181, 15);
            this.labESC.TabIndex = 5;
            this.labESC.Text = "Нажмите ESC для выхода";
            // 
            // The_Snake_Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(518, 562);
            this.Controls.Add(this.forScore);
            this.Controls.Add(this.labscore);
            this.Controls.Add(this.labSpace);
            this.Controls.Add(this.labESC);
            this.Controls.Add(this.playField);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "The_Snake_Field";
            this.Text = "The Snake";
            this.Load += new System.EventHandler(this.The_Snake_Field_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.The_Snake_Field_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playField;
        private System.Windows.Forms.Timer updateField;
        private System.Windows.Forms.Label forScore;
        private System.Windows.Forms.Label labscore;
        private System.Windows.Forms.Label labSpace;
        private System.Windows.Forms.Label labESC;
    }
}