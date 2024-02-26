namespace AutoloadManager
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpProfilesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpProfilesContainer
            // 
            this.flpProfilesContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProfilesContainer.Location = new System.Drawing.Point(32, 48);
            this.flpProfilesContainer.Name = "flpProfilesContainer";
            this.flpProfilesContainer.Size = new System.Drawing.Size(200, 359);
            this.flpProfilesContainer.TabIndex = 0;
            // 
            // btnAddNewProfile
            // 
            this.btnAddNewProfile.Location = new System.Drawing.Point(351, 189);
            this.btnAddNewProfile.Name = "btnAddNewProfile";
            this.btnAddNewProfile.Size = new System.Drawing.Size(136, 54);
            this.btnAddNewProfile.TabIndex = 1;
            this.btnAddNewProfile.Text = "Add new profile";
            this.btnAddNewProfile.UseVisualStyleBackColor = true;
            this.btnAddNewProfile.Click += new System.EventHandler(this.btnAddNewProfile_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNewProfile);
            this.Controls.Add(this.flpProfilesContainer);
            this.Name = "fMain";
            this.Text = "Autoload manager";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProfilesContainer;
        private System.Windows.Forms.Button btnAddNewProfile;
    }
}

