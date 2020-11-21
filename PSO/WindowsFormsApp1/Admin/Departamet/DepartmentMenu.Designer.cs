namespace WindowsFormsApp1.Admin.Departamet
{
    partial class DepatmentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepatmentMenu));
            this.BackButton = new System.Windows.Forms.Button();
            this.ListInfo = new System.Windows.Forms.ListView();
            this.DeleteDepartmentButton = new System.Windows.Forms.Button();
            this.AddDepatrmetnButton = new System.Windows.Forms.Button();
            this.EditDepartmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(1196, 279);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(162, 69);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // ListInfo
            // 
            this.ListInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ListInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListInfo.ForeColor = System.Drawing.Color.White;
            this.ListInfo.HideSelection = false;
            this.ListInfo.Location = new System.Drawing.Point(12, 12);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(1178, 333);
            this.ListInfo.TabIndex = 23;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // DeleteDepartmentButton
            // 
            this.DeleteDepartmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteDepartmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDepartmentButton.ForeColor = System.Drawing.Color.White;
            this.DeleteDepartmentButton.Location = new System.Drawing.Point(1196, 192);
            this.DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            this.DeleteDepartmentButton.Size = new System.Drawing.Size(162, 69);
            this.DeleteDepartmentButton.TabIndex = 22;
            this.DeleteDepartmentButton.Text = "Удалить департамент";
            this.DeleteDepartmentButton.UseVisualStyleBackColor = false;
            this.DeleteDepartmentButton.Click += new System.EventHandler(this.DeleteDepartmentButtonClick);
            // 
            // AddDepatrmetnButton
            // 
            this.AddDepatrmetnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddDepatrmetnButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepatrmetnButton.ForeColor = System.Drawing.Color.White;
            this.AddDepatrmetnButton.Location = new System.Drawing.Point(1196, 15);
            this.AddDepatrmetnButton.Name = "AddDepatrmetnButton";
            this.AddDepatrmetnButton.Size = new System.Drawing.Size(162, 70);
            this.AddDepatrmetnButton.TabIndex = 21;
            this.AddDepatrmetnButton.Text = "Добавить депаратмент  ";
            this.AddDepatrmetnButton.UseVisualStyleBackColor = false;
            this.AddDepatrmetnButton.Click += new System.EventHandler(this.AddDepartmentButtonClick);
            // 
            // EditDepartmentButton
            // 
            this.EditDepartmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditDepartmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDepartmentButton.ForeColor = System.Drawing.Color.White;
            this.EditDepartmentButton.Location = new System.Drawing.Point(1196, 100);
            this.EditDepartmentButton.Name = "EditDepartmentButton";
            this.EditDepartmentButton.Size = new System.Drawing.Size(162, 77);
            this.EditDepartmentButton.TabIndex = 20;
            this.EditDepartmentButton.Text = "Редактировать департамент";
            this.EditDepartmentButton.UseVisualStyleBackColor = false;
            this.EditDepartmentButton.Click += new System.EventHandler(this.EditDepartmentButtonClick);
            // 
            // DepatmentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 356);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.DeleteDepartmentButton);
            this.Controls.Add(this.AddDepatrmetnButton);
            this.Controls.Add(this.EditDepartmentButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepatmentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Департаменты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ListInfo;
        private System.Windows.Forms.Button DeleteDepartmentButton;
        private System.Windows.Forms.Button AddDepatrmetnButton;
        private System.Windows.Forms.Button EditDepartmentButton;
    }
}