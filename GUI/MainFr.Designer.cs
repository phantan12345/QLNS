﻿namespace GUI
{
    partial class MainFr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_baohiem = new System.Windows.Forms.Button();
            this.btn_bangcong = new System.Windows.Forms.Button();
            this.btn_luong = new System.Windows.Forms.Button();
            this.btn_ttcn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_option = new System.Windows.Forms.Label();
            this.panel_Show = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_baohiem);
            this.panel1.Controls.Add(this.btn_bangcong);
            this.panel1.Controls.Add(this.btn_luong);
            this.panel1.Controls.Add(this.btn_ttcn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 692);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 567);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_baohiem
            // 
            this.btn_baohiem.Location = new System.Drawing.Point(0, 480);
            this.btn_baohiem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_baohiem.Name = "btn_baohiem";
            this.btn_baohiem.Size = new System.Drawing.Size(243, 77);
            this.btn_baohiem.TabIndex = 4;
            this.btn_baohiem.Text = "Bảo hiểm";
            this.btn_baohiem.UseVisualStyleBackColor = true;
            // 
            // btn_bangcong
            // 
            this.btn_bangcong.Location = new System.Drawing.Point(0, 394);
            this.btn_bangcong.Margin = new System.Windows.Forms.Padding(5);
            this.btn_bangcong.Name = "btn_bangcong";
            this.btn_bangcong.Size = new System.Drawing.Size(243, 77);
            this.btn_bangcong.TabIndex = 3;
            this.btn_bangcong.Text = "Bảng công";
            this.btn_bangcong.UseVisualStyleBackColor = true;
            // 
            // btn_luong
            // 
            this.btn_luong.Location = new System.Drawing.Point(0, 308);
            this.btn_luong.Margin = new System.Windows.Forms.Padding(5);
            this.btn_luong.Name = "btn_luong";
            this.btn_luong.Size = new System.Drawing.Size(243, 77);
            this.btn_luong.TabIndex = 2;
            this.btn_luong.Text = "Lương";
            this.btn_luong.UseVisualStyleBackColor = true;
            this.btn_luong.Click += new System.EventHandler(this.btn_luong_Click);
            // 
            // btn_ttcn
            // 
            this.btn_ttcn.Location = new System.Drawing.Point(0, 222);
            this.btn_ttcn.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ttcn.Name = "btn_ttcn";
            this.btn_ttcn.Size = new System.Drawing.Size(243, 77);
            this.btn_ttcn.TabIndex = 1;
            this.btn_ttcn.Text = "Thông tin cá nhân";
            this.btn_ttcn.UseVisualStyleBackColor = true;
            this.btn_ttcn.Click += new System.EventHandler(this.btn_ttcn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.hr;
            this.pictureBox1.InitialImage = global::GUI.Properties.Resources.hr;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.lb_option);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 65);
            this.panel2.TabIndex = 1;
            // 
            // lb_option
            // 
            this.lb_option.AutoSize = true;
            this.lb_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_option.ForeColor = System.Drawing.Color.Black;
            this.lb_option.Location = new System.Drawing.Point(529, 9);
            this.lb_option.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_option.Name = "lb_option";
            this.lb_option.Size = new System.Drawing.Size(112, 36);
            this.lb_option.TabIndex = 0;
            this.lb_option.Text = "ADMIN";
            // 
            // panel_Show
            // 
            this.panel_Show.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Show.Location = new System.Drawing.Point(243, 65);
            this.panel_Show.Margin = new System.Windows.Forms.Padding(5);
            this.panel_Show.Name = "panel_Show";
            this.panel_Show.Size = new System.Drawing.Size(1090, 627);
            this.panel_Show.TabIndex = 0;
            // 
            // MainFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.panel_Show);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_baohiem;
        private System.Windows.Forms.Button btn_bangcong;
        private System.Windows.Forms.Button btn_luong;
        private System.Windows.Forms.Button btn_ttcn;
        private System.Windows.Forms.Label lb_option;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Show;
    }
}