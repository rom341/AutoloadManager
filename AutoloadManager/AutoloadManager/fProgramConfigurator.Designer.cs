namespace AutoloadManager
{
    partial class fProgramConfigurator
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnChangeIcon = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChangeFileName = new System.Windows.Forms.Button();
            this.lFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirm.Location = new System.Drawing.Point(146, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 25);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIcon.Location = new System.Drawing.Point(0, 16);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(290, 99);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            // 
            // btnChangeIcon
            // 
            this.btnChangeIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeIcon.Location = new System.Drawing.Point(0, 115);
            this.btnChangeIcon.Name = "btnChangeIcon";
            this.btnChangeIcon.Size = new System.Drawing.Size(290, 25);
            this.btnChangeIcon.TabIndex = 3;
            this.btnChangeIcon.Text = "Change";
            this.btnChangeIcon.UseVisualStyleBackColor = true;
            this.btnChangeIcon.Click += new System.EventHandler(this.btnChangeIcon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 471);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnChangeIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 140);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 25);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 141);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(0, 16);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(290, 125);
            this.tbName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChangeFileName);
            this.panel4.Controls.Add(this.lFileName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 141);
            this.panel4.TabIndex = 7;
            // 
            // btnChangeFileName
            // 
            this.btnChangeFileName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeFileName.Location = new System.Drawing.Point(0, 116);
            this.btnChangeFileName.Name = "btnChangeFileName";
            this.btnChangeFileName.Size = new System.Drawing.Size(290, 25);
            this.btnChangeFileName.TabIndex = 3;
            this.btnChangeFileName.Text = "Change";
            this.btnChangeFileName.UseVisualStyleBackColor = true;
            this.btnChangeFileName.Click += new System.EventHandler(this.btnChangeFileName_Click);
            // 
            // lFileName
            // 
            this.lFileName.AutoSize = true;
            this.lFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFileName.Location = new System.Drawing.Point(0, 16);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(0, 16);
            this.lFileName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "File name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Icon";
            // 
            // fProgramConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fProgramConfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnChangeIcon;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChangeFileName;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}