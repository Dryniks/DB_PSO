namespace WindowsFormsApp1.Admin.People
{
    partial class People
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
            this.DateOfBirthField = new System.Windows.Forms.DateTimePicker();
            this.DateOfBitrhText = new System.Windows.Forms.Label();
            this.MiddleNameField = new System.Windows.Forms.TextBox();
            this.MiddleNameText = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.FamilyField = new System.Windows.Forms.TextBox();
            this.FamilyText = new System.Windows.Forms.Label();
            this.DateOfLossField = new System.Windows.Forms.DateTimePicker();
            this.DateOfLossText = new System.Windows.Forms.Label();
            this.SpecialSignField = new System.Windows.Forms.TextBox();
            this.SpecialSignText = new System.Windows.Forms.Label();
            this.LastLocationField = new System.Windows.Forms.TextBox();
            this.LastLocationText = new System.Windows.Forms.Label();
            this.EditMissingPeopleButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddMissingPeopleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateOfBirthField
            // 
            this.DateOfBirthField.CustomFormat = "dd.MM.yyyy";
            this.DateOfBirthField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.DateOfBirthField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirthField.Location = new System.Drawing.Point(282, 168);
            this.DateOfBirthField.Name = "DateOfBirthField";
            this.DateOfBirthField.Size = new System.Drawing.Size(323, 29);
            this.DateOfBirthField.TabIndex = 48;
            this.DateOfBirthField.Value = new System.DateTime(2020, 11, 10, 0, 3, 52, 0);
            this.DateOfBirthField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // DateOfBitrhText
            // 
            this.DateOfBitrhText.AutoSize = true;
            this.DateOfBitrhText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBitrhText.Location = new System.Drawing.Point(11, 175);
            this.DateOfBitrhText.Name = "DateOfBitrhText";
            this.DateOfBitrhText.Size = new System.Drawing.Size(141, 22);
            this.DateOfBitrhText.TabIndex = 47;
            this.DateOfBitrhText.Text = "Дата рождения";
            // 
            // MiddleNameField
            // 
            this.MiddleNameField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameField.Location = new System.Drawing.Point(282, 118);
            this.MiddleNameField.MaxLength = 50;
            this.MiddleNameField.Name = "MiddleNameField";
            this.MiddleNameField.Size = new System.Drawing.Size(323, 29);
            this.MiddleNameField.TabIndex = 46;
            this.MiddleNameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // MiddleNameText
            // 
            this.MiddleNameText.AutoSize = true;
            this.MiddleNameText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameText.Location = new System.Drawing.Point(11, 125);
            this.MiddleNameText.Name = "MiddleNameText";
            this.MiddleNameText.Size = new System.Drawing.Size(92, 22);
            this.MiddleNameText.TabIndex = 45;
            this.MiddleNameText.Text = "Отчество";
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(282, 64);
            this.NameField.MaxLength = 50;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(323, 29);
            this.NameField.TabIndex = 44;
            this.NameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(10, 71);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(47, 22);
            this.NameText.TabIndex = 43;
            this.NameText.Text = "Имя";
            // 
            // FamilyField
            // 
            this.FamilyField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamilyField.Location = new System.Drawing.Point(282, 12);
            this.FamilyField.MaxLength = 50;
            this.FamilyField.Name = "FamilyField";
            this.FamilyField.Size = new System.Drawing.Size(323, 29);
            this.FamilyField.TabIndex = 42;
            this.FamilyField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // FamilyText
            // 
            this.FamilyText.AutoSize = true;
            this.FamilyText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamilyText.Location = new System.Drawing.Point(11, 19);
            this.FamilyText.Name = "FamilyText";
            this.FamilyText.Size = new System.Drawing.Size(93, 22);
            this.FamilyText.TabIndex = 41;
            this.FamilyText.Text = "Фамилия";
            // 
            // DateOfLossField
            // 
            this.DateOfLossField.CustomFormat = "dd.MM.yyyy";
            this.DateOfLossField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.DateOfLossField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfLossField.Location = new System.Drawing.Point(282, 322);
            this.DateOfLossField.Name = "DateOfLossField";
            this.DateOfLossField.Size = new System.Drawing.Size(323, 29);
            this.DateOfLossField.TabIndex = 54;
            this.DateOfLossField.Value = new System.DateTime(2020, 11, 10, 0, 3, 52, 0);
            this.DateOfLossField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // DateOfLossText
            // 
            this.DateOfLossText.AutoSize = true;
            this.DateOfLossText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfLossText.Location = new System.Drawing.Point(11, 329);
            this.DateOfLossText.Name = "DateOfLossText";
            this.DateOfLossText.Size = new System.Drawing.Size(133, 22);
            this.DateOfLossText.TabIndex = 53;
            this.DateOfLossText.Text = "Дата пропажи";
            // 
            // SpecialSignField
            // 
            this.SpecialSignField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialSignField.Location = new System.Drawing.Point(282, 272);
            this.SpecialSignField.MaxLength = 50;
            this.SpecialSignField.Name = "SpecialSignField";
            this.SpecialSignField.Size = new System.Drawing.Size(323, 29);
            this.SpecialSignField.TabIndex = 52;
            this.SpecialSignField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastLocaleAndSpecialSignKeyPress);
            // 
            // SpecialSignText
            // 
            this.SpecialSignText.AutoSize = true;
            this.SpecialSignText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialSignText.Location = new System.Drawing.Point(11, 279);
            this.SpecialSignText.Name = "SpecialSignText";
            this.SpecialSignText.Size = new System.Drawing.Size(97, 22);
            this.SpecialSignText.TabIndex = 51;
            this.SpecialSignText.Text = "Описание";
            // 
            // LastLocationField
            // 
            this.LastLocationField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastLocationField.Location = new System.Drawing.Point(282, 218);
            this.LastLocationField.MaxLength = 50;
            this.LastLocationField.Name = "LastLocationField";
            this.LastLocationField.Size = new System.Drawing.Size(323, 29);
            this.LastLocationField.TabIndex = 50;
            this.LastLocationField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastLocaleAndSpecialSignKeyPress);
            // 
            // LastLocationText
            // 
            this.LastLocationText.AutoSize = true;
            this.LastLocationText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastLocationText.Location = new System.Drawing.Point(10, 225);
            this.LastLocationText.Name = "LastLocationText";
            this.LastLocationText.Size = new System.Drawing.Size(252, 22);
            this.LastLocationText.TabIndex = 49;
            this.LastLocationText.Text = "Последнее местоположение";
            // 
            // EditMissingPeopleButton
            // 
            this.EditMissingPeopleButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditMissingPeopleButton.Location = new System.Drawing.Point(12, 385);
            this.EditMissingPeopleButton.Name = "EditMissingPeopleButton";
            this.EditMissingPeopleButton.Size = new System.Drawing.Size(211, 53);
            this.EditMissingPeopleButton.TabIndex = 57;
            this.EditMissingPeopleButton.Text = "Редактировать";
            this.EditMissingPeopleButton.UseVisualStyleBackColor = true;
            this.EditMissingPeopleButton.Click += new System.EventHandler(this.EditMissingPeopleButtonClick);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(394, 385);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(211, 53);
            this.BackButton.TabIndex = 56;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // AddMissingPeopleButton
            // 
            this.AddMissingPeopleButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMissingPeopleButton.Location = new System.Drawing.Point(12, 385);
            this.AddMissingPeopleButton.Name = "AddMissingPeopleButton";
            this.AddMissingPeopleButton.Size = new System.Drawing.Size(211, 53);
            this.AddMissingPeopleButton.TabIndex = 55;
            this.AddMissingPeopleButton.Text = "Добавить";
            this.AddMissingPeopleButton.UseVisualStyleBackColor = true;
            this.AddMissingPeopleButton.Click += new System.EventHandler(this.AddMissingPeopleButtonClick);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.EditMissingPeopleButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddMissingPeopleButton);
            this.Controls.Add(this.DateOfLossField);
            this.Controls.Add(this.DateOfLossText);
            this.Controls.Add(this.SpecialSignField);
            this.Controls.Add(this.SpecialSignText);
            this.Controls.Add(this.LastLocationField);
            this.Controls.Add(this.LastLocationText);
            this.Controls.Add(this.DateOfBirthField);
            this.Controls.Add(this.DateOfBitrhText);
            this.Controls.Add(this.MiddleNameField);
            this.Controls.Add(this.MiddleNameText);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.FamilyField);
            this.Controls.Add(this.FamilyText);
            this.Name = "People";
            this.Text = "People";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PeopleFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateOfBirthField;
        private System.Windows.Forms.Label DateOfBitrhText;
        private System.Windows.Forms.TextBox MiddleNameField;
        private System.Windows.Forms.Label MiddleNameText;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.TextBox FamilyField;
        private System.Windows.Forms.Label FamilyText;
        private System.Windows.Forms.DateTimePicker DateOfLossField;
        private System.Windows.Forms.Label DateOfLossText;
        private System.Windows.Forms.TextBox SpecialSignField;
        private System.Windows.Forms.Label SpecialSignText;
        private System.Windows.Forms.TextBox LastLocationField;
        private System.Windows.Forms.Label LastLocationText;
        private System.Windows.Forms.Button EditMissingPeopleButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddMissingPeopleButton;
    }
}