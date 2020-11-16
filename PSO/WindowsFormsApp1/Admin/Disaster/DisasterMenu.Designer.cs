namespace WindowsFormsApp1.Admin.Disaster
{
    partial class DisasterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisasterMenu));
            this.DeleteDisasterButton = new System.Windows.Forms.Button();
            this.AddDisasterButton = new System.Windows.Forms.Button();
            this.EditDisasterButton = new System.Windows.Forms.Button();
            this.ListInfo = new System.Windows.Forms.ListView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteDisasterButton
            // 
            this.DeleteDisasterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteDisasterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDisasterButton.ForeColor = System.Drawing.Color.White;
            this.DeleteDisasterButton.Location = new System.Drawing.Point(736, 188);
            this.DeleteDisasterButton.Name = "DeleteDisasterButton";
            this.DeleteDisasterButton.Size = new System.Drawing.Size(162, 69);
            this.DeleteDisasterButton.TabIndex = 12;
            this.DeleteDisasterButton.Text = "Удалить катастрофу";
            this.DeleteDisasterButton.UseVisualStyleBackColor = false;
            this.DeleteDisasterButton.Click += new System.EventHandler(this.DeleteDisasterButtonClick);
            // 
            // AddDisasterButton
            // 
            this.AddDisasterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddDisasterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDisasterButton.ForeColor = System.Drawing.Color.White;
            this.AddDisasterButton.Location = new System.Drawing.Point(736, 11);
            this.AddDisasterButton.Name = "AddDisasterButton";
            this.AddDisasterButton.Size = new System.Drawing.Size(162, 70);
            this.AddDisasterButton.TabIndex = 11;
            this.AddDisasterButton.Text = "Добавить катастрофу";
            this.AddDisasterButton.UseVisualStyleBackColor = false;
            this.AddDisasterButton.Click += new System.EventHandler(this.AddDisasterButtonClick);
            // 
            // EditDisasterButton
            // 
            this.EditDisasterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditDisasterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDisasterButton.ForeColor = System.Drawing.Color.White;
            this.EditDisasterButton.Location = new System.Drawing.Point(736, 96);
            this.EditDisasterButton.Name = "EditDisasterButton";
            this.EditDisasterButton.Size = new System.Drawing.Size(162, 77);
            this.EditDisasterButton.TabIndex = 10;
            this.EditDisasterButton.Text = "Редактировать катастрофу";
            this.EditDisasterButton.UseVisualStyleBackColor = false;
            this.EditDisasterButton.Click += new System.EventHandler(this.EditDisasterButtonClick);
            // 
            // ListInfo
            // 
            this.ListInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ListInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListInfo.ForeColor = System.Drawing.Color.White;
            this.ListInfo.HideSelection = false;
            this.ListInfo.Location = new System.Drawing.Point(12, 12);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(707, 333);
            this.ListInfo.TabIndex = 13;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(736, 275);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(162, 69);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // DisasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 352);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.DeleteDisasterButton);
            this.Controls.Add(this.AddDisasterButton);
            this.Controls.Add(this.EditDisasterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisasterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню катастроф";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisasterMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteDisasterButton;
        private System.Windows.Forms.Button AddDisasterButton;
        private System.Windows.Forms.Button EditDisasterButton;
        private System.Windows.Forms.ListView ListInfo;
        private System.Windows.Forms.Button BackButton;
    }
}