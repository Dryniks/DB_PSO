namespace WindowsFormsApp1.Admin.Profession
{
    partial class ProfessionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessionMenu));
            this.BackButton = new System.Windows.Forms.Button();
            this.ListInfo = new System.Windows.Forms.ListView();
            this.DeleteProfessionButton = new System.Windows.Forms.Button();
            this.AddProfessionButton = new System.Windows.Forms.Button();
            this.EditProfessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(736, 275);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(162, 69);
            this.BackButton.TabIndex = 19;
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
            this.ListInfo.Size = new System.Drawing.Size(707, 333);
            this.ListInfo.TabIndex = 18;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // DeleteProfessionButton
            // 
            this.DeleteProfessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteProfessionButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProfessionButton.ForeColor = System.Drawing.Color.White;
            this.DeleteProfessionButton.Location = new System.Drawing.Point(736, 188);
            this.DeleteProfessionButton.Name = "DeleteProfessionButton";
            this.DeleteProfessionButton.Size = new System.Drawing.Size(162, 69);
            this.DeleteProfessionButton.TabIndex = 17;
            this.DeleteProfessionButton.Text = "Удалить профессию";
            this.DeleteProfessionButton.UseVisualStyleBackColor = false;
            this.DeleteProfessionButton.Click += new System.EventHandler(this.DeleteEquipmentButtonClick);
            // 
            // AddProfessionButton
            // 
            this.AddProfessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddProfessionButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProfessionButton.ForeColor = System.Drawing.Color.White;
            this.AddProfessionButton.Location = new System.Drawing.Point(736, 11);
            this.AddProfessionButton.Name = "AddProfessionButton";
            this.AddProfessionButton.Size = new System.Drawing.Size(162, 70);
            this.AddProfessionButton.TabIndex = 16;
            this.AddProfessionButton.Text = "Добавить профессию";
            this.AddProfessionButton.UseVisualStyleBackColor = false;
            this.AddProfessionButton.Click += new System.EventHandler(this.AddEquipmentButtonClick);
            // 
            // EditProfessionButton
            // 
            this.EditProfessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditProfessionButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProfessionButton.ForeColor = System.Drawing.Color.White;
            this.EditProfessionButton.Location = new System.Drawing.Point(736, 96);
            this.EditProfessionButton.Name = "EditProfessionButton";
            this.EditProfessionButton.Size = new System.Drawing.Size(162, 77);
            this.EditProfessionButton.TabIndex = 15;
            this.EditProfessionButton.Text = "Редактировать профессию";
            this.EditProfessionButton.UseVisualStyleBackColor = false;
            this.EditProfessionButton.Click += new System.EventHandler(this.EditEquipmentButtonClick);
            // 
            // ProfessionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 355);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.DeleteProfessionButton);
            this.Controls.Add(this.AddProfessionButton);
            this.Controls.Add(this.EditProfessionButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfessionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню оборудования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfessionMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ListInfo;
        private System.Windows.Forms.Button DeleteProfessionButton;
        private System.Windows.Forms.Button AddProfessionButton;
        private System.Windows.Forms.Button EditProfessionButton;
    }
}