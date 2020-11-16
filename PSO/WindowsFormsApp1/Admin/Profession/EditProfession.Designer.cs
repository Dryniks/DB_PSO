namespace WindowsFormsApp1.Admin.Profession
{
    partial class EditProfession
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
            this.TypeEqupmentField = new System.Windows.Forms.ComboBox();
            this.DescriptionEqupmentField = new System.Windows.Forms.TextBox();
            this.DescriptionEqupmentText = new System.Windows.Forms.Label();
            this.TypeEquipmentText = new System.Windows.Forms.Label();
            this.NameEquipmentField = new System.Windows.Forms.TextBox();
            this.NameEquipmentText = new System.Windows.Forms.Label();
            this.ProfessionField = new System.Windows.Forms.TextBox();
            this.ProfessionText = new System.Windows.Forms.Label();
            this.EditProfessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(561, 204);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(160, 52);
            this.BackButton.TabIndex = 88;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // TypeEqupmentField
            // 
            this.TypeEqupmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.TypeEqupmentField.FormattingEnabled = true;
            this.TypeEqupmentField.Location = new System.Drawing.Point(283, 99);
            this.TypeEqupmentField.Name = "TypeEqupmentField";
            this.TypeEqupmentField.Size = new System.Drawing.Size(490, 29);
            this.TypeEqupmentField.TabIndex = 86;
            this.TypeEqupmentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // DescriptionEqupmentField
            // 
            this.DescriptionEqupmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionEqupmentField.Location = new System.Drawing.Point(283, 145);
            this.DescriptionEqupmentField.MaxLength = 50;
            this.DescriptionEqupmentField.Name = "DescriptionEqupmentField";
            this.DescriptionEqupmentField.Size = new System.Drawing.Size(490, 29);
            this.DescriptionEqupmentField.TabIndex = 85;
            this.DescriptionEqupmentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // DescriptionEqupmentText
            // 
            this.DescriptionEqupmentText.AutoSize = true;
            this.DescriptionEqupmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionEqupmentText.Location = new System.Drawing.Point(11, 152);
            this.DescriptionEqupmentText.Name = "DescriptionEqupmentText";
            this.DescriptionEqupmentText.Size = new System.Drawing.Size(222, 22);
            this.DescriptionEqupmentText.TabIndex = 84;
            this.DescriptionEqupmentText.Text = "Описание оборудования";
            // 
            // TypeEquipmentText
            // 
            this.TypeEquipmentText.AutoSize = true;
            this.TypeEquipmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeEquipmentText.Location = new System.Drawing.Point(13, 106);
            this.TypeEquipmentText.Name = "TypeEquipmentText";
            this.TypeEquipmentText.Size = new System.Drawing.Size(170, 22);
            this.TypeEquipmentText.TabIndex = 83;
            this.TypeEquipmentText.Text = "Тип оборудования";
            // 
            // NameEquipmentField
            // 
            this.NameEquipmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEquipmentField.Location = new System.Drawing.Point(283, 53);
            this.NameEquipmentField.MaxLength = 50;
            this.NameEquipmentField.Name = "NameEquipmentField";
            this.NameEquipmentField.Size = new System.Drawing.Size(490, 29);
            this.NameEquipmentField.TabIndex = 82;
            // 
            // NameEquipmentText
            // 
            this.NameEquipmentText.AutoSize = true;
            this.NameEquipmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEquipmentText.Location = new System.Drawing.Point(13, 60);
            this.NameEquipmentText.Name = "NameEquipmentText";
            this.NameEquipmentText.Size = new System.Drawing.Size(218, 22);
            this.NameEquipmentText.TabIndex = 81;
            this.NameEquipmentText.Text = "Название оборудования";
            // 
            // ProfessionField
            // 
            this.ProfessionField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionField.Location = new System.Drawing.Point(283, 9);
            this.ProfessionField.MaxLength = 50;
            this.ProfessionField.Name = "ProfessionField";
            this.ProfessionField.Size = new System.Drawing.Size(490, 29);
            this.ProfessionField.TabIndex = 80;
            this.ProfessionField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // ProfessionText
            // 
            this.ProfessionText.AutoSize = true;
            this.ProfessionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionText.Location = new System.Drawing.Point(12, 16);
            this.ProfessionText.Name = "ProfessionText";
            this.ProfessionText.Size = new System.Drawing.Size(105, 22);
            this.ProfessionText.TabIndex = 79;
            this.ProfessionText.Text = "Профессия";
            // 
            // EditProfessionButton
            // 
            this.EditProfessionButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProfessionButton.Location = new System.Drawing.Point(44, 204);
            this.EditProfessionButton.Name = "EditProfessionButton";
            this.EditProfessionButton.Size = new System.Drawing.Size(160, 52);
            this.EditProfessionButton.TabIndex = 77;
            this.EditProfessionButton.Text = "Редактировать";
            this.EditProfessionButton.UseVisualStyleBackColor = true;
            this.EditProfessionButton.Click += new System.EventHandler(this.EditProfessionButtonClick);
            // 
            // EditProfession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TypeEqupmentField);
            this.Controls.Add(this.DescriptionEqupmentField);
            this.Controls.Add(this.DescriptionEqupmentText);
            this.Controls.Add(this.TypeEquipmentText);
            this.Controls.Add(this.NameEquipmentField);
            this.Controls.Add(this.NameEquipmentText);
            this.Controls.Add(this.ProfessionField);
            this.Controls.Add(this.ProfessionText);
            this.Controls.Add(this.EditProfessionButton);
            this.Name = "EditProfession";
            this.Text = "Редактировать оборудование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditProfessionFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox TypeEqupmentField;
        private System.Windows.Forms.TextBox DescriptionEqupmentField;
        private System.Windows.Forms.Label DescriptionEqupmentText;
        private System.Windows.Forms.Label TypeEquipmentText;
        private System.Windows.Forms.TextBox NameEquipmentField;
        private System.Windows.Forms.Label NameEquipmentText;
        private System.Windows.Forms.TextBox ProfessionField;
        private System.Windows.Forms.Label ProfessionText;
        private System.Windows.Forms.Button EditProfessionButton;
    }
}