namespace WindowsFormsApp1.Coordinator.Department
{
    partial class Department
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
            this.MainDepartmentResultText = new System.Windows.Forms.Label();
            this.DepartmentResultText = new System.Windows.Forms.Label();
            this.RegionResultText = new System.Windows.Forms.Label();
            this.MainDepartmentText = new System.Windows.Forms.Label();
            this.DepartmentText = new System.Windows.Forms.Label();
            this.RegionText = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SelectRegionField = new System.Windows.Forms.ComboBox();
            this.SelectRegionText = new System.Windows.Forms.Label();
            this.NoFoundRegionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainDepartmentResultText
            // 
            this.MainDepartmentResultText.AutoSize = true;
            this.MainDepartmentResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDepartmentResultText.Location = new System.Drawing.Point(313, 123);
            this.MainDepartmentResultText.Name = "MainDepartmentResultText";
            this.MainDepartmentResultText.Size = new System.Drawing.Size(327, 22);
            this.MainDepartmentResultText.TabIndex = 81;
            this.MainDepartmentResultText.Text = "Не имеется свободного специалиста";
            // 
            // DepartmentResultText
            // 
            this.DepartmentResultText.AutoSize = true;
            this.DepartmentResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentResultText.Location = new System.Drawing.Point(313, 64);
            this.DepartmentResultText.Name = "DepartmentResultText";
            this.DepartmentResultText.Size = new System.Drawing.Size(327, 22);
            this.DepartmentResultText.TabIndex = 80;
            this.DepartmentResultText.Text = "Не имеется свободного специалиста";
            // 
            // RegionResultText
            // 
            this.RegionResultText.AutoSize = true;
            this.RegionResultText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionResultText.Location = new System.Drawing.Point(313, 9);
            this.RegionResultText.Name = "RegionResultText";
            this.RegionResultText.Size = new System.Drawing.Size(327, 22);
            this.RegionResultText.TabIndex = 79;
            this.RegionResultText.Text = "Не имеется свободного специалиста";
            // 
            // MainDepartmentText
            // 
            this.MainDepartmentText.AutoSize = true;
            this.MainDepartmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDepartmentText.Location = new System.Drawing.Point(8, 123);
            this.MainDepartmentText.Name = "MainDepartmentText";
            this.MainDepartmentText.Size = new System.Drawing.Size(271, 22);
            this.MainDepartmentText.TabIndex = 78;
            this.MainDepartmentText.Text = "Адрес главного департамента";
            // 
            // DepartmentText
            // 
            this.DepartmentText.AutoSize = true;
            this.DepartmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentText.Location = new System.Drawing.Point(8, 64);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(187, 22);
            this.DepartmentText.TabIndex = 77;
            this.DepartmentText.Text = "Адрес департамента";
            // 
            // RegionText
            // 
            this.RegionText.AutoSize = true;
            this.RegionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionText.Location = new System.Drawing.Point(8, 9);
            this.RegionText.Name = "RegionText";
            this.RegionText.Size = new System.Drawing.Size(136, 22);
            this.RegionText.TabIndex = 76;
            this.RegionText.Text = "Адрес региона";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(1140, 177);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 53);
            this.BackButton.TabIndex = 84;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(551, 177);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(165, 53);
            this.EditButton.TabIndex = 83;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditDepartmentButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(12, 177);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(165, 53);
            this.SaveButton.TabIndex = 82;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveDepartmentButtonClick);
            // 
            // SelectRegionField
            // 
            this.SelectRegionField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.SelectRegionField.FormattingEnabled = true;
            this.SelectRegionField.Location = new System.Drawing.Point(201, 64);
            this.SelectRegionField.Name = "SelectRegionField";
            this.SelectRegionField.Size = new System.Drawing.Size(1104, 29);
            this.SelectRegionField.TabIndex = 86;
            this.SelectRegionField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // SelectRegionText
            // 
            this.SelectRegionText.AutoSize = true;
            this.SelectRegionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectRegionText.Location = new System.Drawing.Point(12, 64);
            this.SelectRegionText.Name = "SelectRegionText";
            this.SelectRegionText.Size = new System.Drawing.Size(161, 22);
            this.SelectRegionText.TabIndex = 85;
            this.SelectRegionText.Text = "Выберите регион";
            // 
            // NoFoundRegionText
            // 
            this.NoFoundRegionText.AutoSize = true;
            this.NoFoundRegionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoFoundRegionText.Location = new System.Drawing.Point(313, 66);
            this.NoFoundRegionText.Name = "NoFoundRegionText";
            this.NoFoundRegionText.Size = new System.Drawing.Size(220, 22);
            this.NoFoundRegionText.TabIndex = 87;
            this.NoFoundRegionText.Text = "Нет доступного региона";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 242);
            this.Controls.Add(this.NoFoundRegionText);
            this.Controls.Add(this.SelectRegionField);
            this.Controls.Add(this.SelectRegionText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MainDepartmentResultText);
            this.Controls.Add(this.DepartmentResultText);
            this.Controls.Add(this.RegionResultText);
            this.Controls.Add(this.MainDepartmentText);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.RegionText);
            this.Name = "Department";
            this.Text = "Департамент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainDepartmentResultText;
        private System.Windows.Forms.Label DepartmentResultText;
        private System.Windows.Forms.Label RegionResultText;
        private System.Windows.Forms.Label MainDepartmentText;
        private System.Windows.Forms.Label DepartmentText;
        private System.Windows.Forms.Label RegionText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox SelectRegionField;
        private System.Windows.Forms.Label SelectRegionText;
        private System.Windows.Forms.Label NoFoundRegionText;
    }
}