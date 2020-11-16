namespace WindowsFormsApp1.Admin.Departamet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.BackButton = new System.Windows.Forms.Button();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.MainDepartmentField = new System.Windows.Forms.TextBox();
            this.MainDepartmentText = new System.Windows.Forms.Label();
            this.DepartmentField = new System.Windows.Forms.TextBox();
            this.DepartmentText = new System.Windows.Forms.Label();
            this.RegionField = new System.Windows.Forms.TextBox();
            this.RegionText = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(577, 165);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(211, 53);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddDepartmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepartmentButton.ForeColor = System.Drawing.Color.White;
            this.AddDepartmentButton.Location = new System.Drawing.Point(12, 165);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(211, 53);
            this.AddDepartmentButton.TabIndex = 25;
            this.AddDepartmentButton.Text = "Добавить";
            this.AddDepartmentButton.UseVisualStyleBackColor = false;
            this.AddDepartmentButton.Click += new System.EventHandler(this.AddDepartmentButtonClick);
            // 
            // MainDepartmentField
            // 
            this.MainDepartmentField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MainDepartmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDepartmentField.ForeColor = System.Drawing.Color.White;
            this.MainDepartmentField.Location = new System.Drawing.Point(221, 111);
            this.MainDepartmentField.MaxLength = 50;
            this.MainDepartmentField.Name = "MainDepartmentField";
            this.MainDepartmentField.Size = new System.Drawing.Size(567, 29);
            this.MainDepartmentField.TabIndex = 24;
            this.MainDepartmentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // MainDepartmentText
            // 
            this.MainDepartmentText.AutoSize = true;
            this.MainDepartmentText.BackColor = System.Drawing.Color.Transparent;
            this.MainDepartmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDepartmentText.ForeColor = System.Drawing.Color.White;
            this.MainDepartmentText.Location = new System.Drawing.Point(11, 113);
            this.MainDepartmentText.Name = "MainDepartmentText";
            this.MainDepartmentText.Size = new System.Drawing.Size(204, 22);
            this.MainDepartmentText.TabIndex = 23;
            this.MainDepartmentText.Text = "Главный департамент";
            // 
            // DepartmentField
            // 
            this.DepartmentField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DepartmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentField.ForeColor = System.Drawing.Color.White;
            this.DepartmentField.Location = new System.Drawing.Point(221, 61);
            this.DepartmentField.MaxLength = 50;
            this.DepartmentField.Name = "DepartmentField";
            this.DepartmentField.Size = new System.Drawing.Size(567, 29);
            this.DepartmentField.TabIndex = 22;
            this.DepartmentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // DepartmentText
            // 
            this.DepartmentText.AutoSize = true;
            this.DepartmentText.BackColor = System.Drawing.Color.Transparent;
            this.DepartmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentText.ForeColor = System.Drawing.Color.White;
            this.DepartmentText.Location = new System.Drawing.Point(12, 61);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(124, 22);
            this.DepartmentText.TabIndex = 21;
            this.DepartmentText.Text = "Департамент";
            // 
            // RegionField
            // 
            this.RegionField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegionField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionField.ForeColor = System.Drawing.Color.White;
            this.RegionField.Location = new System.Drawing.Point(221, 12);
            this.RegionField.MaxLength = 50;
            this.RegionField.Name = "RegionField";
            this.RegionField.Size = new System.Drawing.Size(567, 29);
            this.RegionField.TabIndex = 20;
            this.RegionField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // RegionText
            // 
            this.RegionText.AutoSize = true;
            this.RegionText.BackColor = System.Drawing.Color.Transparent;
            this.RegionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionText.ForeColor = System.Drawing.Color.White;
            this.RegionText.Location = new System.Drawing.Point(12, 14);
            this.RegionText.Name = "RegionText";
            this.RegionText.Size = new System.Drawing.Size(72, 22);
            this.RegionText.TabIndex = 19;
            this.RegionText.Text = "Регион";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(12, 165);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(211, 53);
            this.EditButton.TabIndex = 27;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditDepartmentButtonClick);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 230);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddDepartmentButton);
            this.Controls.Add(this.MainDepartmentField);
            this.Controls.Add(this.MainDepartmentText);
            this.Controls.Add(this.DepartmentField);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.RegionField);
            this.Controls.Add(this.RegionText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Департамент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.TextBox MainDepartmentField;
        private System.Windows.Forms.Label MainDepartmentText;
        private System.Windows.Forms.TextBox DepartmentField;
        private System.Windows.Forms.Label DepartmentText;
        private System.Windows.Forms.TextBox RegionField;
        private System.Windows.Forms.Label RegionText;
        private System.Windows.Forms.Button EditButton;
    }
}