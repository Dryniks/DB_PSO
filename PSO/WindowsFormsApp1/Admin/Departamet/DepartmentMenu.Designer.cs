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
            this.BackButton = new System.Windows.Forms.Button();
            this.ListInfo = new System.Windows.Forms.ListView();
            this.DeleteDepartmentButton = new System.Windows.Forms.Button();
            this.AddDepatrmetnButton = new System.Windows.Forms.Button();
            this.EditDepartmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(901, 277);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(162, 69);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // ListInfo
            // 
            this.ListInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListInfo.HideSelection = false;
            this.ListInfo.Location = new System.Drawing.Point(12, 12);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(871, 333);
            this.ListInfo.TabIndex = 23;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // DeleteDepartmentButton
            // 
            this.DeleteDepartmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDepartmentButton.Location = new System.Drawing.Point(901, 190);
            this.DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            this.DeleteDepartmentButton.Size = new System.Drawing.Size(162, 69);
            this.DeleteDepartmentButton.TabIndex = 22;
            this.DeleteDepartmentButton.Text = "Удалить департамент";
            this.DeleteDepartmentButton.UseVisualStyleBackColor = true;
            this.DeleteDepartmentButton.Click += new System.EventHandler(this.DeleteDepartmentButtonClick);
            // 
            // AddDepatrmetnButton
            // 
            this.AddDepatrmetnButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepatrmetnButton.Location = new System.Drawing.Point(901, 13);
            this.AddDepatrmetnButton.Name = "AddDepatrmetnButton";
            this.AddDepatrmetnButton.Size = new System.Drawing.Size(162, 70);
            this.AddDepatrmetnButton.TabIndex = 21;
            this.AddDepatrmetnButton.Text = "Добавить депаратмент  ";
            this.AddDepatrmetnButton.UseVisualStyleBackColor = true;
            this.AddDepatrmetnButton.Click += new System.EventHandler(this.AddDepartmentButtonClick);
            // 
            // EditDepartmentButton
            // 
            this.EditDepartmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDepartmentButton.Location = new System.Drawing.Point(901, 98);
            this.EditDepartmentButton.Name = "EditDepartmentButton";
            this.EditDepartmentButton.Size = new System.Drawing.Size(162, 77);
            this.EditDepartmentButton.TabIndex = 20;
            this.EditDepartmentButton.Text = "Редактировать департамент";
            this.EditDepartmentButton.UseVisualStyleBackColor = true;
            this.EditDepartmentButton.Click += new System.EventHandler(this.EditDepartmentButtonClick);
            // 
            // DepatmentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.DeleteDepartmentButton);
            this.Controls.Add(this.AddDepatrmetnButton);
            this.Controls.Add(this.EditDepartmentButton);
            this.Name = "DepatmentMenu";
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