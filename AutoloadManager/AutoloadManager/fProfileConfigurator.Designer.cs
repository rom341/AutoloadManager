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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
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
            this.rtbListOfPrograms.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbListOfPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbListOfPrograms.Location = new System.Drawing.Point(0, 0);
            this.rtbListOfPrograms.Name = "rtbListOfPrograms";
            this.rtbListOfPrograms.ReadOnly = true;
            this.rtbListOfPrograms.Size = new System.Drawing.Size(294, 103);
            this.rtbListOfPrograms.TabIndex = 0;
            this.rtbListOfPrograms.Text = "";
            // 
            // flpListOfPrograms
            // 
            this.flpListOfPrograms.AutoScroll = true;
            this.flpListOfPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpListOfPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListOfPrograms.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListOfPrograms.Location = new System.Drawing.Point(0, 0);
            this.flpListOfPrograms.Name = "flpListOfPrograms";
            this.flpListOfPrograms.Size = new System.Drawing.Size(294, 314);
            this.flpListOfPrograms.TabIndex = 2;
            this.flpListOfPrograms.WrapContents = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список файлов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 20;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbListOfPrograms);
            this.splitContainer1.Size = new System.Drawing.Size(294, 132);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flpListOfPrograms);
            this.splitContainer2.Size = new System.Drawing.Size(294, 450);
            this.splitContainer2.SplitterDistance = 132;
            this.splitContainer2.TabIndex = 3;
            // 
            // fProfileConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.btnAddNewProgram);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "fProfileConfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Configurator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddNewProgram;
        private System.Windows.Forms.RichTextBox rtbListOfPrograms;
        private System.Windows.Forms.FlowLayoutPanel flpListOfPrograms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}