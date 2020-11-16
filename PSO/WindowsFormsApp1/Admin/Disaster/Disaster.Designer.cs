namespace WindowsFormsApp1.Admin.Disaster
{
    partial class Disaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disaster));
            this.BackButton = new System.Windows.Forms.Button();
            this.AddDisasterButton = new System.Windows.Forms.Button();
            this.DateText = new System.Windows.Forms.Label();
            this.CityField = new System.Windows.Forms.TextBox();
            this.CityText = new System.Windows.Forms.Label();
            this.CountryField = new System.Windows.Forms.TextBox();
            this.CountryText = new System.Windows.Forms.Label();
            this.ReasonField = new System.Windows.Forms.TextBox();
            this.ReasonText = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.Label();
            this.TypeField = new System.Windows.Forms.ComboBox();
            this.DateField = new System.Windows.Forms.DateTimePicker();
            this.EditDisasterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(334, 282);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(211, 53);
            this.BackButton.TabIndex = 38;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // AddDisasterButton
            // 
            this.AddDisasterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDisasterButton.ForeColor = System.Drawing.Color.White;
            this.AddDisasterButton.Location = new System.Drawing.Point(12, 282);
            this.AddDisasterButton.Name = "AddDisasterButton";
            this.AddDisasterButton.Size = new System.Drawing.Size(211, 53);
            this.AddDisasterButton.TabIndex = 37;
            this.AddDisasterButton.Text = "Добавить";
            this.AddDisasterButton.UseVisualStyleBackColor = true;
            this.AddDisasterButton.Click += new System.EventHandler(this.AddDisasterButtonClick);
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.BackColor = System.Drawing.Color.Transparent;
            this.DateText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateText.ForeColor = System.Drawing.Color.White;
            this.DateText.Location = new System.Drawing.Point(13, 217);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(52, 22);
            this.DateText.TabIndex = 31;
            this.DateText.Text = "Дата";
            // 
            // CityField
            // 
            this.CityField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CityField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityField.ForeColor = System.Drawing.Color.White;
            this.CityField.Location = new System.Drawing.Point(222, 160);
            this.CityField.MaxLength = 50;
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(323, 29);
            this.CityField.TabIndex = 30;
            this.CityField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // CityText
            // 
            this.CityText.AutoSize = true;
            this.CityText.BackColor = System.Drawing.Color.Transparent;
            this.CityText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityText.ForeColor = System.Drawing.Color.White;
            this.CityText.Location = new System.Drawing.Point(13, 167);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(59, 22);
            this.CityText.TabIndex = 29;
            this.CityText.Text = "Город";
            // 
            // CountryField
            // 
            this.CountryField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CountryField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryField.ForeColor = System.Drawing.Color.White;
            this.CountryField.Location = new System.Drawing.Point(222, 106);
            this.CountryField.MaxLength = 50;
            this.CountryField.Name = "CountryField";
            this.CountryField.Size = new System.Drawing.Size(323, 29);
            this.CountryField.TabIndex = 28;
            this.CountryField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // CountryText
            // 
            this.CountryText.AutoSize = true;
            this.CountryText.BackColor = System.Drawing.Color.Transparent;
            this.CountryText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryText.ForeColor = System.Drawing.Color.White;
            this.CountryText.Location = new System.Drawing.Point(12, 113);
            this.CountryText.Name = "CountryText";
            this.CountryText.Size = new System.Drawing.Size(74, 22);
            this.CountryText.TabIndex = 27;
            this.CountryText.Text = "Страна";
            // 
            // ReasonField
            // 
            this.ReasonField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReasonField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReasonField.ForeColor = System.Drawing.Color.White;
            this.ReasonField.Location = new System.Drawing.Point(222, 54);
            this.ReasonField.MaxLength = 50;
            this.ReasonField.Name = "ReasonField";
            this.ReasonField.Size = new System.Drawing.Size(323, 29);
            this.ReasonField.TabIndex = 26;
            this.ReasonField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReasonKeyPress);
            // 
            // ReasonText
            // 
            this.ReasonText.AutoSize = true;
            this.ReasonText.BackColor = System.Drawing.Color.Transparent;
            this.ReasonText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReasonText.ForeColor = System.Drawing.Color.White;
            this.ReasonText.Location = new System.Drawing.Point(13, 61);
            this.ReasonText.Name = "ReasonText";
            this.ReasonText.Size = new System.Drawing.Size(88, 22);
            this.ReasonText.TabIndex = 25;
            this.ReasonText.Text = "Причина";
            // 
            // TypeText
            // 
            this.TypeText.AutoSize = true;
            this.TypeText.BackColor = System.Drawing.Color.Transparent;
            this.TypeText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeText.ForeColor = System.Drawing.Color.White;
            this.TypeText.Location = new System.Drawing.Point(13, 14);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(45, 22);
            this.TypeText.TabIndex = 23;
            this.TypeText.Text = "Тип";
            // 
            // TypeField
            // 
            this.TypeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TypeField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.TypeField.ForeColor = System.Drawing.Color.White;
            this.TypeField.FormattingEnabled = true;
            this.TypeField.Location = new System.Drawing.Point(222, 7);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(323, 29);
            this.TypeField.TabIndex = 39;
            this.TypeField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // DateField
            // 
            this.DateField.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DateField.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DateField.CustomFormat = "dd.MM.yyyy";
            this.DateField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.DateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateField.Location = new System.Drawing.Point(222, 210);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(323, 29);
            this.DateField.TabIndex = 40;
            this.DateField.Value = new System.DateTime(2020, 11, 10, 0, 3, 52, 0);
            this.DateField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // EditDisasterButton
            // 
            this.EditDisasterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditDisasterButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDisasterButton.ForeColor = System.Drawing.Color.White;
            this.EditDisasterButton.Location = new System.Drawing.Point(12, 282);
            this.EditDisasterButton.Name = "EditDisasterButton";
            this.EditDisasterButton.Size = new System.Drawing.Size(211, 53);
            this.EditDisasterButton.TabIndex = 41;
            this.EditDisasterButton.Text = "Редактировать";
            this.EditDisasterButton.UseVisualStyleBackColor = false;
            this.EditDisasterButton.Click += new System.EventHandler(this.EditDisasterButtonClick);
            // 
            // Disaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 344);
            this.Controls.Add(this.EditDisasterButton);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.TypeField);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddDisasterButton);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.CityField);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.CountryField);
            this.Controls.Add(this.CountryText);
            this.Controls.Add(this.ReasonField);
            this.Controls.Add(this.ReasonText);
            this.Controls.Add(this.TypeText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Disaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о катастрофе";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisasterFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddDisasterButton;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.Label CityText;
        private System.Windows.Forms.TextBox CountryField;
        private System.Windows.Forms.Label CountryText;
        private System.Windows.Forms.TextBox ReasonField;
        private System.Windows.Forms.Label ReasonText;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.ComboBox TypeField;
        private System.Windows.Forms.DateTimePicker DateField;
        private System.Windows.Forms.Button EditDisasterButton;
    }
}