namespace WindowsFormsApp1.Coordinator.Task
{
    partial class MissingPeople
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
            this.NoFoundMissingPeopleText = new System.Windows.Forms.Label();
            this.SelectMissingPeopleField = new System.Windows.Forms.ComboBox();
            this.SelectMissingPeopleText = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CompletedButton = new System.Windows.Forms.Button();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.DateOfLossResultText = new System.Windows.Forms.Label();
            this.DateOfBirthResultText = new System.Windows.Forms.Label();
            this.FioResultText = new System.Windows.Forms.Label();
            this.DateOfLossText = new System.Windows.Forms.Label();
            this.DateOfBirthText = new System.Windows.Forms.Label();
            this.FIOText = new System.Windows.Forms.Label();
            this.SpecialSignText = new System.Windows.Forms.Label();
            this.LastLocationText = new System.Windows.Forms.Label();
            this.LastLocationResultText = new System.Windows.Forms.Label();
            this.SpecialSignResultText = new System.Windows.Forms.Label();
            this.IdPeopleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoFoundMissingPeopleText
            // 
            this.NoFoundMissingPeopleText.AutoSize = true;
            this.NoFoundMissingPeopleText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoFoundMissingPeopleText.Location = new System.Drawing.Point(317, 64);
            this.NoFoundMissingPeopleText.Name = "NoFoundMissingPeopleText";
            this.NoFoundMissingPeopleText.Size = new System.Drawing.Size(281, 22);
            this.NoFoundMissingPeopleText.TabIndex = 99;
            this.NoFoundMissingPeopleText.Text = "Нет пропавших, поздравляем!!!";
            // 
            // SelectMissingPeopleField
            // 
            this.SelectMissingPeopleField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.SelectMissingPeopleField.FormattingEnabled = true;
            this.SelectMissingPeopleField.Location = new System.Drawing.Point(321, 57);
            this.SelectMissingPeopleField.Name = "SelectMissingPeopleField";
            this.SelectMissingPeopleField.Size = new System.Drawing.Size(1037, 29);
            this.SelectMissingPeopleField.TabIndex = 98;
            this.SelectMissingPeopleField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // SelectMissingPeopleText
            // 
            this.SelectMissingPeopleText.AutoSize = true;
            this.SelectMissingPeopleText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectMissingPeopleText.Location = new System.Drawing.Point(12, 64);
            this.SelectMissingPeopleText.Name = "SelectMissingPeopleText";
            this.SelectMissingPeopleText.Size = new System.Drawing.Size(292, 22);
            this.SelectMissingPeopleText.TabIndex = 97;
            this.SelectMissingPeopleText.Text = "Выберите пропавшего человека";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(1193, 277);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 53);
            this.BackButton.TabIndex = 96;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // CompletedButton
            // 
            this.CompletedButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompletedButton.Location = new System.Drawing.Point(16, 277);
            this.CompletedButton.Name = "CompletedButton";
            this.CompletedButton.Size = new System.Drawing.Size(165, 53);
            this.CompletedButton.TabIndex = 95;
            this.CompletedButton.Text = "Выполнено";
            this.CompletedButton.UseVisualStyleBackColor = true;
            this.CompletedButton.Click += new System.EventHandler(this.CompletedButtonClick);
            // 
            // SelectedButton
            // 
            this.SelectedButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedButton.Location = new System.Drawing.Point(16, 277);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(165, 53);
            this.SelectedButton.TabIndex = 94;
            this.SelectedButton.Text = "Выбрать";
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.Click += new System.EventHandler(this.SelectButtonClick);
            // 
            // DateOfLossResultText
            // 
            this.DateOfLossResultText.AutoSize = true;
            this.DateOfLossResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfLossResultText.Location = new System.Drawing.Point(317, 123);
            this.DateOfLossResultText.Name = "DateOfLossResultText";
            this.DateOfLossResultText.Size = new System.Drawing.Size(327, 22);
            this.DateOfLossResultText.TabIndex = 93;
            this.DateOfLossResultText.Text = "Не имеется свободного специалиста";
            // 
            // DateOfBirthResultText
            // 
            this.DateOfBirthResultText.AutoSize = true;
            this.DateOfBirthResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthResultText.Location = new System.Drawing.Point(317, 64);
            this.DateOfBirthResultText.Name = "DateOfBirthResultText";
            this.DateOfBirthResultText.Size = new System.Drawing.Size(327, 22);
            this.DateOfBirthResultText.TabIndex = 92;
            this.DateOfBirthResultText.Text = "Не имеется свободного специалиста";
            // 
            // FioResultText
            // 
            this.FioResultText.AutoSize = true;
            this.FioResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioResultText.Location = new System.Drawing.Point(317, 9);
            this.FioResultText.Name = "FioResultText";
            this.FioResultText.Size = new System.Drawing.Size(327, 22);
            this.FioResultText.TabIndex = 91;
            this.FioResultText.Text = "Не имеется свободного специалиста";
            // 
            // DateOfLossText
            // 
            this.DateOfLossText.AutoSize = true;
            this.DateOfLossText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfLossText.Location = new System.Drawing.Point(12, 123);
            this.DateOfLossText.Name = "DateOfLossText";
            this.DateOfLossText.Size = new System.Drawing.Size(133, 22);
            this.DateOfLossText.TabIndex = 90;
            this.DateOfLossText.Text = "Дата пропажи";
            // 
            // DateOfBirthText
            // 
            this.DateOfBirthText.AutoSize = true;
            this.DateOfBirthText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthText.Location = new System.Drawing.Point(12, 64);
            this.DateOfBirthText.Name = "DateOfBirthText";
            this.DateOfBirthText.Size = new System.Drawing.Size(141, 22);
            this.DateOfBirthText.TabIndex = 89;
            this.DateOfBirthText.Text = "Дата рождения";
            // 
            // FIOText
            // 
            this.FIOText.AutoSize = true;
            this.FIOText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOText.Location = new System.Drawing.Point(12, 9);
            this.FIOText.Name = "FIOText";
            this.FIOText.Size = new System.Drawing.Size(56, 22);
            this.FIOText.TabIndex = 88;
            this.FIOText.Text = "ФИО";
            // 
            // SpecialSignText
            // 
            this.SpecialSignText.AutoSize = true;
            this.SpecialSignText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialSignText.Location = new System.Drawing.Point(12, 236);
            this.SpecialSignText.Name = "SpecialSignText";
            this.SpecialSignText.Size = new System.Drawing.Size(161, 22);
            this.SpecialSignText.TabIndex = 101;
            this.SpecialSignText.Text = "Особые приметы";
            // 
            // LastLocationText
            // 
            this.LastLocationText.AutoSize = true;
            this.LastLocationText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastLocationText.Location = new System.Drawing.Point(12, 177);
            this.LastLocationText.Name = "LastLocationText";
            this.LastLocationText.Size = new System.Drawing.Size(259, 22);
            this.LastLocationText.TabIndex = 100;
            this.LastLocationText.Text = "Последнее местонахождение";
            // 
            // LastLocationResultText
            // 
            this.LastLocationResultText.AutoSize = true;
            this.LastLocationResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastLocationResultText.Location = new System.Drawing.Point(317, 177);
            this.LastLocationResultText.Name = "LastLocationResultText";
            this.LastLocationResultText.Size = new System.Drawing.Size(327, 22);
            this.LastLocationResultText.TabIndex = 102;
            this.LastLocationResultText.Text = "Не имеется свободного специалиста";
            // 
            // SpecialSignResultText
            // 
            this.SpecialSignResultText.AutoSize = true;
            this.SpecialSignResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialSignResultText.Location = new System.Drawing.Point(317, 236);
            this.SpecialSignResultText.Name = "SpecialSignResultText";
            this.SpecialSignResultText.Size = new System.Drawing.Size(327, 22);
            this.SpecialSignResultText.TabIndex = 103;
            this.SpecialSignResultText.Text = "Не имеется свободного специалиста";
            // 
            // IdPeopleText
            // 
            this.IdPeopleText.AutoSize = true;
            this.IdPeopleText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdPeopleText.Location = new System.Drawing.Point(522, 214);
            this.IdPeopleText.Name = "IdPeopleText";
            this.IdPeopleText.Size = new System.Drawing.Size(0, 22);
            this.IdPeopleText.TabIndex = 104;
            // 
            // MissingPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 332);
            this.Controls.Add(this.IdPeopleText);
            this.Controls.Add(this.SpecialSignResultText);
            this.Controls.Add(this.LastLocationResultText);
            this.Controls.Add(this.SpecialSignText);
            this.Controls.Add(this.LastLocationText);
            this.Controls.Add(this.NoFoundMissingPeopleText);
            this.Controls.Add(this.SelectMissingPeopleField);
            this.Controls.Add(this.SelectMissingPeopleText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CompletedButton);
            this.Controls.Add(this.SelectedButton);
            this.Controls.Add(this.DateOfLossResultText);
            this.Controls.Add(this.DateOfBirthResultText);
            this.Controls.Add(this.FioResultText);
            this.Controls.Add(this.DateOfLossText);
            this.Controls.Add(this.DateOfBirthText);
            this.Controls.Add(this.FIOText);
            this.Name = "MissingPeople";
            this.Text = "Пропавшие люди";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PeopleFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoFoundMissingPeopleText;
        private System.Windows.Forms.ComboBox SelectMissingPeopleField;
        private System.Windows.Forms.Label SelectMissingPeopleText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CompletedButton;
        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.Label DateOfLossResultText;
        private System.Windows.Forms.Label DateOfBirthResultText;
        private System.Windows.Forms.Label FioResultText;
        private System.Windows.Forms.Label DateOfLossText;
        private System.Windows.Forms.Label DateOfBirthText;
        private System.Windows.Forms.Label FIOText;
        private System.Windows.Forms.Label SpecialSignText;
        private System.Windows.Forms.Label LastLocationText;
        private System.Windows.Forms.Label LastLocationResultText;
        private System.Windows.Forms.Label SpecialSignResultText;
        private System.Windows.Forms.Label IdPeopleText;
    }
}