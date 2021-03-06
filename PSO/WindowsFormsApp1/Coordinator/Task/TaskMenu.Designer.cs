﻿namespace WindowsFormsApp1.Coordinator.Task
{
    partial class TaskMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskMenu));
            this.DisasterButton = new System.Windows.Forms.Button();
            this.MissingPeopleButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisasterButton
            // 
            this.DisasterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DisasterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisasterButton.ForeColor = System.Drawing.Color.White;
            this.DisasterButton.Location = new System.Drawing.Point(12, 83);
            this.DisasterButton.Name = "DisasterButton";
            this.DisasterButton.Size = new System.Drawing.Size(211, 53);
            this.DisasterButton.TabIndex = 20;
            this.DisasterButton.Text = "Катастрофы";
            this.DisasterButton.UseVisualStyleBackColor = false;
            this.DisasterButton.Click += new System.EventHandler(this.DisasterButtonClick);
            // 
            // MissingPeopleButton
            // 
            this.MissingPeopleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MissingPeopleButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MissingPeopleButton.ForeColor = System.Drawing.Color.White;
            this.MissingPeopleButton.Location = new System.Drawing.Point(12, 12);
            this.MissingPeopleButton.Name = "MissingPeopleButton";
            this.MissingPeopleButton.Size = new System.Drawing.Size(211, 53);
            this.MissingPeopleButton.TabIndex = 19;
            this.MissingPeopleButton.Text = "Пропавшие люди";
            this.MissingPeopleButton.UseVisualStyleBackColor = false;
            this.MissingPeopleButton.Click += new System.EventHandler(this.MissingPeopleButtonClick);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(12, 156);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(211, 53);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // TaskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(234, 219);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DisasterButton);
            this.Controls.Add(this.MissingPeopleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню заданий";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisasterButton;
        private System.Windows.Forms.Button MissingPeopleButton;
        private System.Windows.Forms.Button BackButton;
    }
}