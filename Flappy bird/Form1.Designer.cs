﻿
namespace Flappy_bird
{
    partial class Game_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Form));
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.Game_Title = new System.Windows.Forms.PictureBox();
            this.Start_button = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.Ground_pic = new System.Windows.Forms.PictureBox();
            this.Bot_pipe_pic = new System.Windows.Forms.PictureBox();
            this.Top_pipe_pic = new System.Windows.Forms.PictureBox();
            this.guide_pic = new System.Windows.Forms.PictureBox();
            this.Game_over_img = new System.Windows.Forms.PictureBox();
            this.HighScore_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot_pipe_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_pipe_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guide_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_over_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // game_timer
            // 
            this.game_timer.Interval = 15;
            this.game_timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Game_Title
            // 
            this.Game_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Game_Title.BackColor = System.Drawing.Color.Transparent;
            this.Game_Title.Image = global::Flappy_bird.Properties.Resources.title;
            this.Game_Title.Location = new System.Drawing.Point(213, 92);
            this.Game_Title.Margin = new System.Windows.Forms.Padding(1);
            this.Game_Title.Name = "Game_Title";
            this.Game_Title.Size = new System.Drawing.Size(259, 90);
            this.Game_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Game_Title.TabIndex = 7;
            this.Game_Title.TabStop = false;
            // 
            // Start_button
            // 
            this.Start_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Start_button.BackColor = System.Drawing.Color.Transparent;
            this.Start_button.Image = global::Flappy_bird.Properties.Resources.start_button;
            this.Start_button.Location = new System.Drawing.Point(150, 412);
            this.Start_button.Margin = new System.Windows.Forms.Padding(1);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(384, 88);
            this.Start_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start_button.TabIndex = 5;
            this.Start_button.TabStop = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.Transparent;
            this.score_lbl.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.ForeColor = System.Drawing.Color.Black;
            this.score_lbl.Image = global::Flappy_bird.Properties.Resources.ground;
            this.score_lbl.Location = new System.Drawing.Point(310, 605);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(52, 60);
            this.score_lbl.TabIndex = 4;
            this.score_lbl.Text = "0";
            // 
            // Ground_pic
            // 
            this.Ground_pic.Image = global::Flappy_bird.Properties.Resources.ground;
            this.Ground_pic.Location = new System.Drawing.Point(0, 582);
            this.Ground_pic.Name = "Ground_pic";
            this.Ground_pic.Size = new System.Drawing.Size(682, 92);
            this.Ground_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground_pic.TabIndex = 3;
            this.Ground_pic.TabStop = false;
            // 
            // Bot_pipe_pic
            // 
            this.Bot_pipe_pic.BackColor = System.Drawing.Color.Transparent;
            this.Bot_pipe_pic.Image = global::Flappy_bird.Properties.Resources.pipe;
            this.Bot_pipe_pic.Location = new System.Drawing.Point(582, 359);
            this.Bot_pipe_pic.Name = "Bot_pipe_pic";
            this.Bot_pipe_pic.Size = new System.Drawing.Size(100, 226);
            this.Bot_pipe_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bot_pipe_pic.TabIndex = 2;
            this.Bot_pipe_pic.TabStop = false;
            this.Bot_pipe_pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.Bot_pipe_pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // Top_pipe_pic
            // 
            this.Top_pipe_pic.BackColor = System.Drawing.Color.Transparent;
            this.Top_pipe_pic.Image = global::Flappy_bird.Properties.Resources.pipedown;
            this.Top_pipe_pic.Location = new System.Drawing.Point(582, 0);
            this.Top_pipe_pic.Name = "Top_pipe_pic";
            this.Top_pipe_pic.Size = new System.Drawing.Size(100, 218);
            this.Top_pipe_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top_pipe_pic.TabIndex = 1;
            this.Top_pipe_pic.TabStop = false;
            this.Top_pipe_pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.Top_pipe_pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // guide_pic
            // 
            this.guide_pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guide_pic.BackColor = System.Drawing.Color.Transparent;
            this.guide_pic.Image = ((System.Drawing.Image)(resources.GetObject("guide_pic.Image")));
            this.guide_pic.Location = new System.Drawing.Point(310, 241);
            this.guide_pic.Margin = new System.Windows.Forms.Padding(1);
            this.guide_pic.Name = "guide_pic";
            this.guide_pic.Size = new System.Drawing.Size(52, 64);
            this.guide_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guide_pic.TabIndex = 0;
            this.guide_pic.TabStop = false;
            this.guide_pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.guide_pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // Game_over_img
            // 
            this.Game_over_img.BackColor = System.Drawing.Color.Transparent;
            this.Game_over_img.Image = global::Flappy_bird.Properties.Resources.game_over;
            this.Game_over_img.Location = new System.Drawing.Point(150, 94);
            this.Game_over_img.Name = "Game_over_img";
            this.Game_over_img.Size = new System.Drawing.Size(384, 88);
            this.Game_over_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Game_over_img.TabIndex = 3;
            this.Game_over_img.TabStop = false;
            // 
            // HighScore_lbl
            // 
            this.HighScore_lbl.AutoSize = true;
            this.HighScore_lbl.BackColor = System.Drawing.Color.Transparent;
            this.HighScore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore_lbl.Location = new System.Drawing.Point(85, 268);
            this.HighScore_lbl.Name = "HighScore_lbl";
            this.HighScore_lbl.Size = new System.Drawing.Size(124, 25);
            this.HighScore_lbl.TabIndex = 1;
            this.HighScore_lbl.Text = "HighScore: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappy_bird.Properties.Resources.Forest_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 674);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_down);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_mouse_up);
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources.Forest_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(682, 674);
            this.Controls.Add(this.guide_pic);
            this.Controls.Add(this.HighScore_lbl);
            this.Controls.Add(this.Game_over_img);
            this.Controls.Add(this.Game_Title);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.Ground_pic);
            this.Controls.Add(this.Bot_pipe_pic);
            this.Controls.Add(this.Top_pipe_pic);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Game_Form";
            this.Text = "TerraFlap";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Game_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot_pipe_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_pipe_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guide_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_over_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox guide_pic;
        private System.Windows.Forms.PictureBox Top_pipe_pic;
        private System.Windows.Forms.PictureBox Bot_pipe_pic;
        private System.Windows.Forms.PictureBox Ground_pic;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.PictureBox Start_button;
        private System.Windows.Forms.PictureBox Game_Title;
        private System.Windows.Forms.Label HighScore_lbl;
        private System.Windows.Forms.PictureBox Game_over_img;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

