namespace WindowsFormsApp1.Coordinator.Task
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
            this.NoFoundDisasterText = new System.Windows.Forms.Label();
            this.SelectDisasterText = new System.Windows.Forms.Label();
            this.CityResultText = new System.Windows.Forms.Label();
            this.DateResultText = new System.Windows.Forms.Label();
            this.CityText = new System.Windows.Forms.Label();
            this.DateText = new System.Windows.Forms.Label();
            this.SelectDisasterField = new System.Windows.Forms.ComboBox();
            this.CountryText = new System.Windows.Forms.Label();
            this.ListInfo = new System.Windows.Forms.ListView();
            this.BackButton = new System.Windows.Forms.Button();
            this.CompletedButton = new System.Windows.Forms.Button();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.CountyResultText = new System.Windows.Forms.Label();
            this.ReasonText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoFoundDisasterText
            // 
            this.NoFoundDisasterText.AutoSize = true;
            this.NoFoundDisasterText.BackColor = System.Drawing.Color.Transparent;
            this.NoFoundDisasterText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoFoundDisasterText.ForeColor = System.Drawing.Color.White;
            this.NoFoundDisasterText.Location = new System.Drawing.Point(314, 72);
            this.NoFoundDisasterText.Name = "NoFoundDisasterText";
            this.NoFoundDisasterText.Size = new System.Drawing.Size(281, 22);
            this.NoFoundDisasterText.TabIndex = 105;
            this.NoFoundDisasterText.Text = "Нет пропавших, поздравляем!!!";
            // 
            // SelectDisasterText
            // 
            this.SelectDisasterText.AutoSize = true;
            this.SelectDisasterText.BackColor = System.Drawing.Color.Transparent;
            this.SelectDisasterText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDisasterText.ForeColor = System.Drawing.Color.White;
            this.SelectDisasterText.Location = new System.Drawing.Point(12, 72);
            this.SelectDisasterText.Name = "SelectDisasterText";
            this.SelectDisasterText.Size = new System.Drawing.Size(201, 22);
            this.SelectDisasterText.TabIndex = 104;
            this.SelectDisasterText.Text = "Выберите катастрофу";
            // 
            // CityResultText
            // 
            this.CityResultText.AutoSize = true;
            this.CityResultText.BackColor = System.Drawing.Color.Transparent;
            this.CityResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityResultText.ForeColor = System.Drawing.Color.White;
            this.CityResultText.Location = new System.Drawing.Point(314, 133);
            this.CityResultText.Name = "CityResultText";
            this.CityResultText.Size = new System.Drawing.Size(327, 22);
            this.CityResultText.TabIndex = 103;
            this.CityResultText.Text = "Не имеется свободного специалиста";
            // 
            // DateResultText
            // 
            this.DateResultText.AutoSize = true;
            this.DateResultText.BackColor = System.Drawing.Color.Transparent;
            this.DateResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateResultText.ForeColor = System.Drawing.Color.White;
            this.DateResultText.Location = new System.Drawing.Point(314, 19);
            this.DateResultText.Name = "DateResultText";
            this.DateResultText.Size = new System.Drawing.Size(327, 22);
            this.DateResultText.TabIndex = 102;
            this.DateResultText.Text = "Не имеется свободного специалиста";
            // 
            // CityText
            // 
            this.CityText.AutoSize = true;
            this.CityText.BackColor = System.Drawing.Color.Transparent;
            this.CityText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityText.ForeColor = System.Drawing.Color.White;
            this.CityText.Location = new System.Drawing.Point(9, 133);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(59, 22);
            this.CityText.TabIndex = 101;
            this.CityText.Text = "Город";
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.BackColor = System.Drawing.Color.Transparent;
            this.DateText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateText.ForeColor = System.Drawing.Color.White;
            this.DateText.Location = new System.Drawing.Point(9, 19);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(163, 22);
            this.DateText.TabIndex = 100;
            this.DateText.Text = "Дата катастрофы";
            // 
            // SelectDisasterField
            // 
            this.SelectDisasterField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SelectDisasterField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.SelectDisasterField.ForeColor = System.Drawing.Color.White;
            this.SelectDisasterField.FormattingEnabled = true;
            this.SelectDisasterField.Location = new System.Drawing.Point(318, 65);
            this.SelectDisasterField.Name = "SelectDisasterField";
            this.SelectDisasterField.Size = new System.Drawing.Size(1037, 29);
            this.SelectDisasterField.TabIndex = 107;
            this.SelectDisasterField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // CountryText
            // 
            this.CountryText.AutoSize = true;
            this.CountryText.BackColor = System.Drawing.Color.Transparent;
            this.CountryText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryText.ForeColor = System.Drawing.Color.White;
            this.CountryText.Location = new System.Drawing.Point(12, 74);
            this.CountryText.Name = "CountryText";
            this.CountryText.Size = new System.Drawing.Size(74, 22);
            this.CountryText.TabIndex = 106;
            this.CountryText.Text = "Страна";
            // 
            // ListInfo
            // 
            this.ListInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ListInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListInfo.ForeColor = System.Drawing.Color.White;
            this.ListInfo.HideSelection = false;
            this.ListInfo.Location = new System.Drawing.Point(12, 206);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(1343, 183);
            this.ListInfo.TabIndex = 108;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(1190, 395);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 53);
            this.BackButton.TabIndex = 111;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // CompletedButton
            // 
            this.CompletedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CompletedButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompletedButton.ForeColor = System.Drawing.Color.White;
            this.CompletedButton.Location = new System.Drawing.Point(12, 395);
            this.CompletedButton.Name = "CompletedButton";
            this.CompletedButton.Size = new System.Drawing.Size(165, 53);
            this.CompletedButton.TabIndex = 110;
            this.CompletedButton.Text = "Выполнено";
            this.CompletedButton.UseVisualStyleBackColor = false;
            this.CompletedButton.Click += new System.EventHandler(this.CompletedButtonClick);
            // 
            // SelectedButton
            // 
            this.SelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SelectedButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedButton.ForeColor = System.Drawing.Color.White;
            this.SelectedButton.Location = new System.Drawing.Point(12, 395);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(165, 53);
            this.SelectedButton.TabIndex = 109;
            this.SelectedButton.Text = "Выбрать";
            this.SelectedButton.UseVisualStyleBackColor = false;
            this.SelectedButton.Click += new System.EventHandler(this.SelectButtonClick);
            // 
            // CountyResultText
            // 
            this.CountyResultText.AutoSize = true;
            this.CountyResultText.BackColor = System.Drawing.Color.Transparent;
            this.CountyResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountyResultText.ForeColor = System.Drawing.Color.White;
            this.CountyResultText.Location = new System.Drawing.Point(314, 74);
            this.CountyResultText.Name = "CountyResultText";
            this.CountyResultText.Size = new System.Drawing.Size(327, 22);
            this.CountyResultText.TabIndex = 112;
            this.CountyResultText.Text = "Не имеется свободного специалиста";
            // 
            // ReasonText
            // 
            this.ReasonText.AutoSize = true;
            this.ReasonText.BackColor = System.Drawing.Color.Transparent;
            this.ReasonText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReasonText.ForeColor = System.Drawing.Color.White;
            this.ReasonText.Location = new System.Drawing.Point(501, 167);
            this.ReasonText.Name = "ReasonText";
            this.ReasonText.Size = new System.Drawing.Size(327, 22);
            this.ReasonText.TabIndex = 113;
            this.ReasonText.Text = "Не имеется свободного специалиста";
            // 
            // Disaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.ReasonText);
            this.Controls.Add(this.CountyResultText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CompletedButton);
            this.Controls.Add(this.SelectedButton);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.SelectDisasterField);
            this.Controls.Add(this.CountryText);
            this.Controls.Add(this.NoFoundDisasterText);
            this.Controls.Add(this.SelectDisasterText);
            this.Controls.Add(this.CityResultText);
            this.Controls.Add(this.DateResultText);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.DateText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Disaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Катастрофа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisasterFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoFoundDisasterText;
        private System.Windows.Forms.Label SelectDisasterText;
        private System.Windows.Forms.Label CityResultText;
        private System.Windows.Forms.Label DateResultText;
        private System.Windows.Forms.Label CityText;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.ComboBox SelectDisasterField;
        private System.Windows.Forms.Label CountryText;
        private System.Windows.Forms.ListView ListInfo;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CompletedButton;
        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.Label CountyResultText;
        private System.Windows.Forms.Label ReasonText;
    }
}