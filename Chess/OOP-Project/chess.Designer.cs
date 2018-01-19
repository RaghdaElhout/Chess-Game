namespace OOP_Project
{
    partial class chess
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
            this.New_Game = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Game
            // 
            this.New_Game.BackColor = System.Drawing.Color.Silver;
            this.New_Game.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Game.Location = new System.Drawing.Point(600, 144);
            this.New_Game.Name = "New_Game";
            this.New_Game.Size = new System.Drawing.Size(217, 44);
            this.New_Game.TabIndex = 1;
            this.New_Game.Text = "New Game";
            this.New_Game.UseVisualStyleBackColor = false;
            this.New_Game.Click += new System.EventHandler(this.New_Game_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_Project.Properties.Resources.hd_wallpaper_chessboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1304, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.New_Game);
            this.DoubleBuffered = true;
            this.Name = "chess";
            this.Text = "chess";
            this.Load += new System.EventHandler(this.chess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_Game;
        private System.Windows.Forms.Button button1;
    }
}