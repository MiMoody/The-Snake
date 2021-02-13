namespace The_Snake
{
    partial class mainMenu
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
            this.Exit = new The_Snake.RoundButton();
            this.normalMode = new The_Snake.RoundButton();
            this.freeMode = new The_Snake.RoundButton();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gainsboro;
            this.Exit.BackColor2 = System.Drawing.Color.Silver;
            this.Exit.ButtonBorderColor = System.Drawing.Color.Black;
            this.Exit.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Exit.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Exit.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Exit.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Exit.ButtonRoundRadius = 30;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(114, 245);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(166, 71);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // normalMode
            // 
            this.normalMode.BackColor = System.Drawing.Color.Gainsboro;
            this.normalMode.BackColor2 = System.Drawing.Color.Silver;
            this.normalMode.ButtonBorderColor = System.Drawing.Color.Black;
            this.normalMode.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.normalMode.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.normalMode.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.normalMode.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.normalMode.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.normalMode.ButtonPressedForeColor = System.Drawing.Color.White;
            this.normalMode.ButtonRoundRadius = 30;
            this.normalMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.normalMode.Location = new System.Drawing.Point(114, 49);
            this.normalMode.Name = "normalMode";
            this.normalMode.Size = new System.Drawing.Size(166, 74);
            this.normalMode.TabIndex = 0;
            this.normalMode.Text = "Нормальный режим";
            this.normalMode.Click += new System.EventHandler(this.normalMode_Click_1);
            // 
            // freeMode
            // 
            this.freeMode.BackColor = System.Drawing.Color.Gainsboro;
            this.freeMode.BackColor2 = System.Drawing.Color.Silver;
            this.freeMode.ButtonBorderColor = System.Drawing.Color.Black;
            this.freeMode.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.freeMode.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.freeMode.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.freeMode.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.freeMode.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.freeMode.ButtonPressedForeColor = System.Drawing.Color.White;
            this.freeMode.ButtonRoundRadius = 30;
            this.freeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.freeMode.Location = new System.Drawing.Point(114, 148);
            this.freeMode.Name = "freeMode";
            this.freeMode.Size = new System.Drawing.Size(166, 74);
            this.freeMode.TabIndex = 2;
            this.freeMode.Text = "Свободный режим";
            this.freeMode.Click += new System.EventHandler(this.freeMode_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(389, 371);
            this.Controls.Add(this.freeMode);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.normalMode);
            this.Name = "mainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton normalMode;
        private RoundButton Exit;
        private RoundButton freeMode;
    }
}

