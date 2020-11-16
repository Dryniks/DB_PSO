namespace WindowsFormsApp1.Admin.Profession
{
    partial class Profession
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
            this.label1 = new System.Windows.Forms.Label();
            this.TypeEqupmentField = new System.Windows.Forms.ComboBox();
            this.DescriptionEqupmentField = new System.Windows.Forms.TextBox();
            this.DescriptionEqupmentText = new System.Windows.Forms.Label();
            this.TypeEquipmentText = new System.Windows.Forms.Label();
            this.NameEquipmentField = new System.Windows.Forms.TextBox();
            this.NameEquipmentText = new System.Windows.Forms.Label();
            this.ProfessionField = new System.Windows.Forms.TextBox();
            this.ProfessionText = new System.Windows.Forms.Label();
            this.ListInfo = new System.Windows.Forms.ListView();
            this.AddProfessionButton = new System.Windows.Forms.Button();
            this.AddEqupmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(629, 82);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(160, 33);
            this.BackButton.TabIndex = 75;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = "Оборудования";
            // 
            // TypeEqupmentField
            // 
            this.TypeEqupmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic);
            this.TypeEqupmentField.FormattingEnabled = true;
            this.TypeEqupmentField.Location = new System.Drawing.Point(283, 169);
            this.TypeEqupmentField.Name = "TypeEqupmentField";
            this.TypeEqupmentField.Size = new System.Drawing.Size(323, 29);
            this.TypeEqupmentField.TabIndex = 73;
            this.TypeEqupmentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableHandledKeyPress);
            // 
            // DescriptionEqupmentField
            // 
            this.DescriptionEqupmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionEqupmentField.Location = new System.Drawing.Point(283, 215);
            this.DescriptionEqupmentField.MaxLength = 50;
            this.DescriptionEqupmentField.Name = "DescriptionEqupmentField";
            this.DescriptionEqupmentField.Size = new System.Drawing.Size(323, 29);
            this.DescriptionEqupmentField.TabIndex = 72;
            this.DescriptionEqupmentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionKeyPress);
            // 
            // DescriptionEqupmentText
            // 
            this.DescriptionEqupmentText.AutoSize = true;
            this.DescriptionEqupmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionEqupmentText.Location = new System.Drawing.Point(11, 222);
            this.DescriptionEqupmentText.Name = "DescriptionEqupmentText";
            this.DescriptionEqupmentText.Size = new System.Drawing.Size(222, 22);
            this.DescriptionEqupmentText.TabIndex = 71;
            this.DescriptionEqupmentText.Text = "Описание оборудования";
            // 
            // TypeEquipmentText
            // 
            this.TypeEquipmentText.AutoSize = true;
            this.TypeEquipmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeEquipmentText.Location = new System.Drawing.Point(13, 176);
            this.TypeEquipmentText.Name = "TypeEquipmentText";
            this.TypeEquipmentText.Size = new System.Drawing.Size(170, 22);
            this.TypeEquipmentText.TabIndex = 70;
            this.TypeEquipmentText.Text = "Тип оборудования";
            // 
            // NameEquipmentField
            // 
            this.NameEquipmentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEquipmentField.Location = new System.Drawing.Point(283, 123);
            this.NameEquipmentField.MaxLength = 50;
            this.NameEquipmentField.Name = "NameEquipmentField";
            this.NameEquipmentField.Size = new System.Drawing.Size(323, 29);
            this.NameEquipmentField.TabIndex = 69;
            // 
            // NameEquipmentText
            // 
            this.NameEquipmentText.AutoSize = true;
            this.NameEquipmentText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEquipmentText.Location = new System.Drawing.Point(13, 130);
            this.NameEquipmentText.Name = "NameEquipmentText";
            this.NameEquipmentText.Size = new System.Drawing.Size(218, 22);
            this.NameEquipmentText.TabIndex = 68;
            this.NameEquipmentText.Text = "Название оборудования";
            // 
            // ProfessionField
            // 
            this.ProfessionField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionField.Location = new System.Drawing.Point(283, 9);
            this.ProfessionField.MaxLength = 50;
            this.ProfessionField.Name = "ProfessionField";
            this.ProfessionField.Size = new System.Drawing.Size(323, 29);
            this.ProfessionField.TabIndex = 67;
            this.ProfessionField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RussianKeyPress);
            // 
            // ProfessionText
            // 
            this.ProfessionText.AutoSize = true;
            this.ProfessionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionText.Location = new System.Drawing.Point(12, 16);
            this.ProfessionText.Name = "ProfessionText";
            this.ProfessionText.Size = new System.Drawing.Size(105, 22);
            this.ProfessionText.TabIndex = 66;
            this.ProfessionText.Text = "Профессия";
            // 
            // ListInfo
            // 
            this.ListInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListInfo.HideSelection = false;
            this.ListInfo.Location = new System.Drawing.Point(15, 268);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(774, 174);
            this.ListInfo.TabIndex = 65;
            this.ListInfo.UseCompatibleStateImageBehavior = false;
            this.ListInfo.View = System.Windows.Forms.View.List;
            // 
            // AddProfessionButton
            // 
            this.AddProfessionButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProfessionButton.Location = new System.Drawing.Point(629, 9);
            this.AddProfessionButton.Name = "AddProfessionButton";
            this.AddProfessionButton.Size = new System.Drawing.Size(160, 52);
            this.AddProfessionButton.TabIndex = 64;
            this.AddProfessionButton.Text = "Добавить профессию";
            this.AddProfessionButton.UseVisualStyleBackColor = true;
            this.AddProfessionButton.Click += new System.EventHandler(this.AddProfessionButtonClick);
            // 
            // AddEqupmentButton
            // 
            this.AddEqupmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEqupmentButton.Location = new System.Drawing.Point(629, 156);
            this.AddEqupmentButton.Name = "AddEqupmentButton";
            this.AddEqupmentButton.Size = new System.Drawing.Size(160, 54);
            this.AddEqupmentButton.TabIndex = 63;
            this.AddEqupmentButton.Text = "Добавить оборудование";
            this.AddEqupmentButton.UseVisualStyleBackColor = true;
            this.AddEqupmentButton.Click += new System.EventHandler(this.AddEquipmentButtonClick);
            // 
            // Profession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeEqupmentField);
            this.Controls.Add(this.DescriptionEqupmentField);
            this.Controls.Add(this.DescriptionEqupmentText);
            this.Controls.Add(this.TypeEquipmentText);
            this.Controls.Add(this.NameEquipmentField);
            this.Controls.Add(this.NameEquipmentText);
            this.Controls.Add(this.ProfessionField);
            this.Controls.Add(this.ProfessionText);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.AddProfessionButton);
            this.Controls.Add(this.AddEqupmentButton);
            this.Name = "Profession";
            this.Text = "Добавить профессию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeEqupmentField;
        private System.Windows.Forms.TextBox DescriptionEqupmentField;
        private System.Windows.Forms.Label DescriptionEqupmentText;
        private System.Windows.Forms.Label TypeEquipmentText;
        private System.Windows.Forms.TextBox NameEquipmentField;
        private System.Windows.Forms.Label NameEquipmentText;
        private System.Windows.Forms.TextBox ProfessionField;
        private System.Windows.Forms.Label ProfessionText;
        private System.Windows.Forms.ListView ListInfo;
        private System.Windows.Forms.Button AddProfessionButton;
        private System.Windows.Forms.Button AddEqupmentButton;
    }
}