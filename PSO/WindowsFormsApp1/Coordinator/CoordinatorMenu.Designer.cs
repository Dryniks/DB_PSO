namespace PSO_DB.Coordinator
{
    partial class CoordinatorMenu
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
            this.TaskButton = new System.Windows.Forms.Button();
            this.TeamDepartmentButton = new System.Windows.Forms.Button();
            this.MyTeamButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskButton
            // 
            this.TaskButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskButton.Location = new System.Drawing.Point(12, 12);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(278, 53);
            this.TaskButton.TabIndex = 7;
            this.TaskButton.Text = "Задания";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButtonClick);
            // 
            // TeamDepartmentButton
            // 
            this.TeamDepartmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamDepartmentButton.Location = new System.Drawing.Point(12, 77);
            this.TeamDepartmentButton.Name = "TeamDepartmentButton";
            this.TeamDepartmentButton.Size = new System.Drawing.Size(278, 53);
            this.TeamDepartmentButton.TabIndex = 6;
            this.TeamDepartmentButton.Text = "Департамент команды";
            this.TeamDepartmentButton.UseVisualStyleBackColor = true;
            this.TeamDepartmentButton.Click += new System.EventHandler(this.TeamDepartmentButtonClick);
            // 
            // MyTeamButton
            // 
            this.MyTeamButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyTeamButton.Location = new System.Drawing.Point(12, 144);
            this.MyTeamButton.Name = "MyTeamButton";
            this.MyTeamButton.Size = new System.Drawing.Size(278, 53);
            this.MyTeamButton.TabIndex = 9;
            this.MyTeamButton.Text = "Моя команда";
            this.MyTeamButton.UseVisualStyleBackColor = true;
            this.MyTeamButton.Click += new System.EventHandler(this.MyTeamButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(12, 209);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(278, 53);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // CoordinatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 274);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MyTeamButton);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.TeamDepartmentButton);
            this.Name = "CoordinatorMenu";
            this.Text = "Меню координатора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoordinatorMenuFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.Button TeamDepartmentButton;
        private System.Windows.Forms.Button MyTeamButton;
        private System.Windows.Forms.Button ExitButton;
    }
}