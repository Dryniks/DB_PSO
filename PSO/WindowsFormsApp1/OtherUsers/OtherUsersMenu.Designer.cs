﻿namespace PSO_DB.OtherUsers
{
    partial class OtherUsersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherUsersMenu));
            this.TeamButton = new System.Windows.Forms.Button();
            this.MyUniformButton = new System.Windows.Forms.Button();
            this.TaskButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeamButton
            // 
            this.TeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TeamButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamButton.ForeColor = System.Drawing.Color.White;
            this.TeamButton.Location = new System.Drawing.Point(12, 12);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Size = new System.Drawing.Size(278, 53);
            this.TeamButton.TabIndex = 13;
            this.TeamButton.Text = "Моя команда";
            this.TeamButton.UseVisualStyleBackColor = false;
            this.TeamButton.Click += new System.EventHandler(this.TeamButtonClick);
            // 
            // MyUniformButton
            // 
            this.MyUniformButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MyUniformButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyUniformButton.ForeColor = System.Drawing.Color.White;
            this.MyUniformButton.Location = new System.Drawing.Point(12, 77);
            this.MyUniformButton.Name = "MyUniformButton";
            this.MyUniformButton.Size = new System.Drawing.Size(278, 53);
            this.MyUniformButton.TabIndex = 12;
            this.MyUniformButton.Text = "Моё обмундирование";
            this.MyUniformButton.UseVisualStyleBackColor = false;
            this.MyUniformButton.Click += new System.EventHandler(this.MyUniformButtonClick);
            // 
            // TaskButton
            // 
            this.TaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TaskButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskButton.ForeColor = System.Drawing.Color.White;
            this.TaskButton.Location = new System.Drawing.Point(12, 146);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(278, 53);
            this.TaskButton.TabIndex = 14;
            this.TaskButton.Text = "Информация о текущих дел";
            this.TaskButton.UseVisualStyleBackColor = false;
            this.TaskButton.Click += new System.EventHandler(this.TaskButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(12, 214);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(278, 53);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // OtherUsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 279);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.TeamButton);
            this.Controls.Add(this.MyUniformButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OtherUsersMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OtherUsersMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TeamButton;
        private System.Windows.Forms.Button MyUniformButton;
        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.Button ExitButton;
    }
}