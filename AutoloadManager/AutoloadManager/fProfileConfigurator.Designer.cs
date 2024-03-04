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
            this.flpListOfPrograms = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpProgramList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpProfileInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnChangeIcon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpProgramList.SuspendLayout();
            this.tlpProfileInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnAddNewProgram
            // 
            this.btnAddNewProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewProgram.Location = new System.Drawing.Point(4, 404);
            this.btnAddNewProgram.Name = "btnAddNewProgram";
            this.btnAddNewProgram.Size = new System.Drawing.Size(251, 34);
            this.btnAddNewProgram.TabIndex = 1;
            this.btnAddNewProgram.Text = "Add new program";
            this.btnAddNewProgram.UseVisualStyleBackColor = true;
            this.btnAddNewProgram.Click += new System.EventHandler(this.btnAddNewProgram_Click);
            // 
            // flpListOfPrograms
            // 
            this.flpListOfPrograms.AutoScroll = true;
            this.flpListOfPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpListOfPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListOfPrograms.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListOfPrograms.Location = new System.Drawing.Point(4, 25);
            this.flpListOfPrograms.Name = "flpListOfPrograms";
            this.flpListOfPrograms.Size = new System.Drawing.Size(251, 372);
            this.flpListOfPrograms.TabIndex = 2;
            this.flpListOfPrograms.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Program list";
            // 
            // tlpProgramList
            // 
            this.tlpProgramList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpProgramList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpProgramList.ColumnCount = 1;
            this.tlpProgramList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgramList.Controls.Add(this.label1, 0, 0);
            this.tlpProgramList.Controls.Add(this.btnAddNewProgram, 0, 2);
            this.tlpProgramList.Controls.Add(this.flpListOfPrograms, 0, 1);
            this.tlpProgramList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProgramList.Location = new System.Drawing.Point(4, 4);
            this.tlpProgramList.Name = "tlpProgramList";
            this.tlpProgramList.RowCount = 3;
            this.tlpProgramList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProgramList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgramList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpProgramList.Size = new System.Drawing.Size(259, 442);
            this.tlpProgramList.TabIndex = 5;
            // 
            // tlpProfileInfo
            // 
            this.tlpProfileInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpProfileInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpProfileInfo.ColumnCount = 1;
            this.tlpProfileInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProfileInfo.Controls.Add(this.panel2, 0, 2);
            this.tlpProfileInfo.Controls.Add(this.panel1, 0, 0);
            this.tlpProfileInfo.Controls.Add(this.panel3, 0, 1);
            this.tlpProfileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProfileInfo.Location = new System.Drawing.Point(536, 4);
            this.tlpProfileInfo.Name = "tlpProfileInfo";
            this.tlpProfileInfo.RowCount = 3;
            this.tlpProfileInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProfileInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpProfileInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProfileInfo.Size = new System.Drawing.Size(260, 442);
            this.tlpProfileInfo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnChangeIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 139);
            this.panel1.TabIndex = 4;
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIcon.Location = new System.Drawing.Point(0, 16);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(252, 98);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            // 
            // btnChangeIcon
            // 
            this.btnChangeIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeIcon.Location = new System.Drawing.Point(0, 114);
            this.btnChangeIcon.Name = "btnChangeIcon";
            this.btnChangeIcon.Size = new System.Drawing.Size(252, 25);
            this.btnChangeIcon.TabIndex = 3;
            this.btnChangeIcon.Text = "Change";
            this.btnChangeIcon.UseVisualStyleBackColor = true;
            this.btnChangeIcon.Click += new System.EventHandler(this.btnChangeIcon_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 140);
            this.panel3.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(0, 16);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(252, 124);
            this.tbName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile name";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 48);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Location = new System.Drawing.Point(0, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(127, 48);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Icon";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.tlpProgramList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tlpProfileInfo, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(270, 396);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnConfirm);
            this.splitContainer1.Size = new System.Drawing.Size(259, 50);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbDescription);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 141);
            this.panel2.TabIndex = 7;
            // 
            // tbDescription
            // 
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Location = new System.Drawing.Point(0, 16);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(252, 125);
            this.tbDescription.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // fProfileConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "fProfileConfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Configurator";
            this.tlpProgramList.ResumeLayout(false);
            this.tlpProgramList.PerformLayout();
            this.tlpProfileInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddNewProgram;
        private System.Windows.Forms.FlowLayoutPanel flpListOfPrograms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpProgramList;
        private System.Windows.Forms.TableLayoutPanel tlpProfileInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangeIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
    }
}