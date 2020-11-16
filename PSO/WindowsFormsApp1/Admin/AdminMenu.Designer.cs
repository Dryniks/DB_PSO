namespace PSO_DB.Admin
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.DepartmentButton = new System.Windows.Forms.Button();
            this.ProfessionButton = new System.Windows.Forms.Button();
            this.DisasterButton = new System.Windows.Forms.Button();
            this.MissingPeopleButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartmentButton
            // 
            this.DepartmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DepartmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentButton.ForeColor = System.Drawing.Color.White;
            this.DepartmentButton.Location = new System.Drawing.Point(12, 136);
            this.DepartmentButton.Name = "DepartmentButton";
            this.DepartmentButton.Size = new System.Drawing.Size(278, 53);
            this.DepartmentButton.TabIndex = 13;
            this.DepartmentButton.Text = "Департаменты";
            this.DepartmentButton.UseCompatibleTextRendering = true;
            this.DepartmentButton.UseVisualStyleBackColor = false;
            this.DepartmentButton.Click += new System.EventHandler(this.DepartmentButtonClick);
            // 
            // ProfessionButton
            // 
            this.ProfessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ProfessionButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionButton.ForeColor = System.Drawing.Color.White;
            this.ProfessionButton.Location = new System.Drawing.Point(12, 201);
            this.ProfessionButton.Name = "ProfessionButton";
            this.ProfessionButton.Size = new System.Drawing.Size(278, 53);
            this.ProfessionButton.TabIndex = 12;
            this.ProfessionButton.Text = "Профессии";
            this.ProfessionButton.UseVisualStyleBackColor = false;
            this.ProfessionButton.Click += new System.EventHandler(this.ProfessionButtonClick);
            // 
            // DisasterButton
            // 
            this.DisasterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DisasterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisasterButton.ForeColor = System.Drawing.Color.White;
            this.DisasterButton.Location = new System.Drawing.Point(12, 12);
            this.DisasterButton.Name = "DisasterButton";
            this.DisasterButton.Size = new System.Drawing.Size(278, 53);
            this.DisasterButton.TabIndex = 11;
            this.DisasterButton.Text = "Катастрофы";
            this.DisasterButton.UseVisualStyleBackColor = false;
            this.DisasterButton.Click += new System.EventHandler(this.DisasterButtonClick);
            // 
            // MissingPeopleButton
            // 
            this.MissingPeopleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MissingPeopleButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MissingPeopleButton.ForeColor = System.Drawing.Color.White;
            this.MissingPeopleButton.Location = new System.Drawing.Point(12, 77);
            this.MissingPeopleButton.Name = "MissingPeopleButton";
            this.MissingPeopleButton.Size = new System.Drawing.Size(278, 53);
            this.MissingPeopleButton.TabIndex = 10;
            this.MissingPeopleButton.Text = "Пропавшие люди";
            this.MissingPeopleButton.UseVisualStyleBackColor = false;
            this.MissingPeopleButton.Click += new System.EventHandler(this.MissingPeopleButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(12, 262);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(278, 53);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 327);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DepartmentButton);
            this.Controls.Add(this.ProfessionButton);
            this.Controls.Add(this.DisasterButton);
            this.Controls.Add(this.MissingPeopleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню админа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DepartmentButton;
        private System.Windows.Forms.Button ProfessionButton;
        private System.Windows.Forms.Button DisasterButton;
        private System.Windows.Forms.Button MissingPeopleButton;
        private System.Windows.Forms.Button ExitButton;
    }
}