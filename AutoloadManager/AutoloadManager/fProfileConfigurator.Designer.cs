namespace AutoloadManager
{
    partial class fProfileConfigurator
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddNewProgram = new System.Windows.Forms.Button();
            this.rtbListOfPrograms = new System.Windows.Forms.RichTextBox();
            this.flpListOfPrograms = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpListOfPrograms.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddNewProgram
            // 
            this.btnAddNewProgram.Location = new System.Drawing.Point(358, 197);
            this.btnAddNewProgram.Name = "btnAddNewProgram";
            this.btnAddNewProgram.Size = new System.Drawing.Size(130, 43);
            this.btnAddNewProgram.TabIndex = 1;
            this.btnAddNewProgram.Text = "Add new program";
            this.btnAddNewProgram.UseVisualStyleBackColor = true;
            this.btnAddNewProgram.Click += new System.EventHandler(this.btnAddNewProgram_Click);
            // 
            // rtbListOfPrograms
            // 
            this.rtbListOfPrograms.Location = new System.Drawing.Point(3, 19);
            this.rtbListOfPrograms.Name = "rtbListOfPrograms";
            this.rtbListOfPrograms.ReadOnly = true;
            this.rtbListOfPrograms.Size = new System.Drawing.Size(227, 80);
            this.rtbListOfPrograms.TabIndex = 0;
            this.rtbListOfPrograms.Text = "";
            // 
            // flpListOfPrograms
            // 
            this.flpListOfPrograms.AutoScroll = true;
            this.flpListOfPrograms.Controls.Add(this.label1);
            this.flpListOfPrograms.Controls.Add(this.rtbListOfPrograms);
            this.flpListOfPrograms.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListOfPrograms.Location = new System.Drawing.Point(12, 12);
            this.flpListOfPrograms.Name = "flpListOfPrograms";
            this.flpListOfPrograms.Size = new System.Drawing.Size(248, 426);
            this.flpListOfPrograms.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // fProfileConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpListOfPrograms);
            this.Controls.Add(this.btnAddNewProgram);
            this.Name = "fProfileConfigurator";
            this.Text = "Profile Configurator";
            this.flpListOfPrograms.ResumeLayout(false);
            this.flpListOfPrograms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddNewProgram;
        private System.Windows.Forms.RichTextBox rtbListOfPrograms;
        private System.Windows.Forms.FlowLayoutPanel flpListOfPrograms;
        private System.Windows.Forms.Label label1;
    }
}