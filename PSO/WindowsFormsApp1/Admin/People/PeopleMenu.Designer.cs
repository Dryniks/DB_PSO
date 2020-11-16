namespace WindowsFormsApp1.Admin.People
{
    partial class PeopleMenu
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
            this.DeletePeopleButton = new System.Windows.Forms.Button();
            this.AddPeopeButton = new System.Windows.Forms.Button();
            this.EditPeopleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(736, 275);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(162, 69);
            this.BackButton.TabIndex = 19;
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
            this.ListInfo.Size = new System.Drawing.Size(707, 333);
            this.ListInfo.TabIndex = 18;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // DeletePeopleButton
            // 
            this.DeletePeopleButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePeopleButton.Location = new System.Drawing.Point(736, 188);
            this.DeletePeopleButton.Name = "DeletePeopleButton";
            this.DeletePeopleButton.Size = new System.Drawing.Size(162, 69);
            this.DeletePeopleButton.TabIndex = 17;
            this.DeletePeopleButton.Text = "Удалить человека";
            this.DeletePeopleButton.UseVisualStyleBackColor = true;
            this.DeletePeopleButton.Click += new System.EventHandler(this.DeleteMissingPeopleButtonClick);
            // 
            // AddPeopeButton
            // 
            this.AddPeopeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPeopeButton.Location = new System.Drawing.Point(736, 11);
            this.AddPeopeButton.Name = "AddPeopeButton";
            this.AddPeopeButton.Size = new System.Drawing.Size(162, 70);
            this.AddPeopeButton.TabIndex = 16;
            this.AddPeopeButton.Text = "Добавить  человека";
            this.AddPeopeButton.UseVisualStyleBackColor = true;
            this.AddPeopeButton.Click += new System.EventHandler(this.AddMissingPeopleButtonClick);
            // 
            // EditPeopleButton
            // 
            this.EditPeopleButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPeopleButton.Location = new System.Drawing.Point(736, 96);
            this.EditPeopleButton.Name = "EditPeopleButton";
            this.EditPeopleButton.Size = new System.Drawing.Size(162, 77);
            this.EditPeopleButton.TabIndex = 15;
            this.EditPeopleButton.Text = "Редактировать человека";
            this.EditPeopleButton.UseVisualStyleBackColor = true;
            this.EditPeopleButton.Click += new System.EventHandler(this.EditMissingPeopleButtonClick);
            // 
            // PeopleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 350);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.DeletePeopleButton);
            this.Controls.Add(this.AddPeopeButton);
            this.Controls.Add(this.EditPeopleButton);
            this.Name = "PeopleMenu";
            this.Text = "Меню пропавших людей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PeopleMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ListInfo;
        private System.Windows.Forms.Button DeletePeopleButton;
        private System.Windows.Forms.Button AddPeopeButton;
        private System.Windows.Forms.Button EditPeopleButton;
    }
}