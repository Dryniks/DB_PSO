namespace WindowsFormsApp1.OtherUsers.Task
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
            this.ReasonText = new System.Windows.Forms.Label();
            this.CountyResultText = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ListInfo = new System.Windows.Forms.ListView();
            this.CountryText = new System.Windows.Forms.Label();
            this.CityResultText = new System.Windows.Forms.Label();
            this.DateResultText = new System.Windows.Forms.Label();
            this.CityText = new System.Windows.Forms.Label();
            this.DateText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReasonText
            // 
            this.ReasonText.AutoSize = true;
            this.ReasonText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReasonText.Location = new System.Drawing.Point(565, 159);
            this.ReasonText.Name = "ReasonText";
            this.ReasonText.Size = new System.Drawing.Size(327, 22);
            this.ReasonText.TabIndex = 127;
            this.ReasonText.Text = "Не имеется свободного специалиста";
            // 
            // CountyResultText
            // 
            this.CountyResultText.AutoSize = true;
            this.CountyResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountyResultText.Location = new System.Drawing.Point(314, 68);
            this.CountyResultText.Name = "CountyResultText";
            this.CountyResultText.Size = new System.Drawing.Size(327, 22);
            this.CountyResultText.TabIndex = 126;
            this.CountyResultText.Text = "Не имеется свободного специалиста";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(569, 405);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 33);
            this.BackButton.TabIndex = 125;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // ListInfo
            // 
            this.ListInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListInfo.HideSelection = false;
            this.ListInfo.Location = new System.Drawing.Point(12, 200);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(1343, 183);
            this.ListInfo.TabIndex = 122;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // CountryText
            // 
            this.CountryText.AutoSize = true;
            this.CountryText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryText.Location = new System.Drawing.Point(12, 68);
            this.CountryText.Name = "CountryText";
            this.CountryText.Size = new System.Drawing.Size(74, 22);
            this.CountryText.TabIndex = 120;
            this.CountryText.Text = "Страна";
            // 
            // CityResultText
            // 
            this.CityResultText.AutoSize = true;
            this.CityResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityResultText.Location = new System.Drawing.Point(314, 127);
            this.CityResultText.Name = "CityResultText";
            this.CityResultText.Size = new System.Drawing.Size(327, 22);
            this.CityResultText.TabIndex = 117;
            this.CityResultText.Text = "Не имеется свободного специалиста";
            // 
            // DateResultText
            // 
            this.DateResultText.AutoSize = true;
            this.DateResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateResultText.Location = new System.Drawing.Point(314, 13);
            this.DateResultText.Name = "DateResultText";
            this.DateResultText.Size = new System.Drawing.Size(327, 22);
            this.DateResultText.TabIndex = 116;
            this.DateResultText.Text = "Не имеется свободного специалиста";
            // 
            // CityText
            // 
            this.CityText.AutoSize = true;
            this.CityText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityText.Location = new System.Drawing.Point(9, 127);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(59, 22);
            this.CityText.TabIndex = 115;
            this.CityText.Text = "Город";
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateText.Location = new System.Drawing.Point(9, 13);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(163, 22);
            this.DateText.TabIndex = 114;
            this.DateText.Text = "Дата катастрофы";
            // 
            // Disaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.ReasonText);
            this.Controls.Add(this.CountyResultText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.CountryText);
            this.Controls.Add(this.CityResultText);
            this.Controls.Add(this.DateResultText);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.DateText);
            this.Name = "Disaster";
            this.Text = "Катастрофа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisasterFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReasonText;
        private System.Windows.Forms.Label CountyResultText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ListInfo;
        private System.Windows.Forms.Label CountryText;
        private System.Windows.Forms.Label CityResultText;
        private System.Windows.Forms.Label DateResultText;
        private System.Windows.Forms.Label CityText;
        private System.Windows.Forms.Label DateText;
    }
}