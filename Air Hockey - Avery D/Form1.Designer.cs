﻿namespace Air_Hockey___Avery_D
{
    partial class Form1
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.blub = new System.Windows.Forms.Timer(this.components);
            this.speedBoost1 = new System.Windows.Forms.Timer(this.components);
            this.speedBoost2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.AutoSize = true;
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.Location = new System.Drawing.Point(252, 9);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(164, 29);
            this.p1ScoreLabel.TabIndex = 0;
            this.p1ScoreLabel.Text = "p1ScoreLabel";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.AutoSize = true;
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.Location = new System.Drawing.Point(492, 9);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(164, 29);
            this.p2ScoreLabel.TabIndex = 1;
            this.p2ScoreLabel.Text = "p2ScoreLabel";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(12, 196);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(758, 63);
            this.winLabel.TabIndex = 2;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resetButton.Enabled = false;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resetButton.FlatAppearance.BorderSize = 3;
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(283, 361);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(213, 54);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Play Again?";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // blub
            // 
            this.blub.Enabled = true;
            this.blub.Interval = 8000;
            this.blub.Tick += new System.EventHandler(this.blub_Tick);
            // 
            // speedBoost1
            // 
            this.speedBoost1.Interval = 4000;
            this.speedBoost1.Tick += new System.EventHandler(this.speedBoost1_Tick);
            // 
            // speedBoost2
            // 
            this.speedBoost2.Interval = 4000;
            this.speedBoost2.Tick += new System.EventHandler(this.speedBoost2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Air Hockey";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer blub;
        private System.Windows.Forms.Timer speedBoost1;
        private System.Windows.Forms.Timer speedBoost2;
    }
}

