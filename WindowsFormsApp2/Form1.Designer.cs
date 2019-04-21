namespace AOMEE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalMaxPop = new System.Windows.Forms.TextBox();
            this.TotalMaxPopConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TotalPopReset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MaxPopReset = new System.Windows.Forms.Button();
            this.CurrentMaxPopConfirm = new System.Windows.Forms.Button();
            this.CurrentMaxPop = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MaxPopInfo = new System.Windows.Forms.Label();
            this.PopCapValue = new System.Windows.Forms.Label();
            this.MaxPopValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actual max population (value between 0 and max pop cap)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max population cap (bypass 300 max pop cap limit)";
            // 
            // TotalMaxPop
            // 
            this.TotalMaxPop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.TotalMaxPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMaxPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMaxPop.Location = new System.Drawing.Point(8, 16);
            this.TotalMaxPop.Name = "TotalMaxPop";
            this.TotalMaxPop.Size = new System.Drawing.Size(159, 32);
            this.TotalMaxPop.TabIndex = 4;
            this.TotalMaxPop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalMaxPop_KeyDown);
            // 
            // TotalMaxPopConfirm
            // 
            this.TotalMaxPopConfirm.Location = new System.Drawing.Point(173, 15);
            this.TotalMaxPopConfirm.Name = "TotalMaxPopConfirm";
            this.TotalMaxPopConfirm.Size = new System.Drawing.Size(100, 35);
            this.TotalMaxPopConfirm.TabIndex = 7;
            this.TotalMaxPopConfirm.Text = "ok";
            this.TotalMaxPopConfirm.UseVisualStyleBackColor = true;
            this.TotalMaxPopConfirm.Click += new System.EventHandler(this.TotalMaxPopConfirm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(250, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 130);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 124);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TotalPopReset);
            this.panel4.Controls.Add(this.TotalMaxPop);
            this.panel4.Controls.Add(this.TotalMaxPopConfirm);
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 60);
            this.panel4.TabIndex = 9;
            // 
            // TotalPopReset
            // 
            this.TotalPopReset.Location = new System.Drawing.Point(271, 15);
            this.TotalPopReset.Name = "TotalPopReset";
            this.TotalPopReset.Size = new System.Drawing.Size(100, 35);
            this.TotalPopReset.TabIndex = 9;
            this.TotalPopReset.Text = "reset";
            this.TotalPopReset.UseVisualStyleBackColor = true;
            this.TotalPopReset.Click += new System.EventHandler(this.TotalPopReset_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.MaxPopReset);
            this.panel3.Controls.Add(this.CurrentMaxPopConfirm);
            this.panel3.Controls.Add(this.CurrentMaxPop);
            this.panel3.Location = new System.Drawing.Point(0, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 60);
            this.panel3.TabIndex = 4;
            // 
            // MaxPopReset
            // 
            this.MaxPopReset.Location = new System.Drawing.Point(275, 14);
            this.MaxPopReset.Name = "MaxPopReset";
            this.MaxPopReset.Size = new System.Drawing.Size(100, 35);
            this.MaxPopReset.TabIndex = 8;
            this.MaxPopReset.Text = "reset";
            this.MaxPopReset.UseVisualStyleBackColor = true;
            this.MaxPopReset.Click += new System.EventHandler(this.MaxPopReset_Click);
            // 
            // CurrentMaxPopConfirm
            // 
            this.CurrentMaxPopConfirm.BackColor = System.Drawing.Color.Transparent;
            this.CurrentMaxPopConfirm.Location = new System.Drawing.Point(177, 14);
            this.CurrentMaxPopConfirm.Name = "CurrentMaxPopConfirm";
            this.CurrentMaxPopConfirm.Size = new System.Drawing.Size(100, 35);
            this.CurrentMaxPopConfirm.TabIndex = 6;
            this.CurrentMaxPopConfirm.Text = "ok";
            this.CurrentMaxPopConfirm.UseVisualStyleBackColor = false;
            this.CurrentMaxPopConfirm.Click += new System.EventHandler(this.CurrentMaxPopConfirm_Click);
            // 
            // CurrentMaxPop
            // 
            this.CurrentMaxPop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.CurrentMaxPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentMaxPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMaxPop.Location = new System.Drawing.Point(12, 15);
            this.CurrentMaxPop.Name = "CurrentMaxPop";
            this.CurrentMaxPop.Size = new System.Drawing.Size(159, 32);
            this.CurrentMaxPop.TabIndex = 2;
            this.CurrentMaxPop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CurrentMaxPop_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(396, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 124);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.MaxPopInfo);
            this.panel5.Controls.Add(this.PopCapValue);
            this.panel5.Controls.Add(this.MaxPopValue);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(0, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 60);
            this.panel5.TabIndex = 10;
            // 
            // MaxPopInfo
            // 
            this.MaxPopInfo.AutoSize = true;
            this.MaxPopInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaxPopInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPopInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MaxPopInfo.Location = new System.Drawing.Point(3, 0);
            this.MaxPopInfo.Name = "MaxPopInfo";
            this.MaxPopInfo.Size = new System.Drawing.Size(220, 25);
            this.MaxPopInfo.TabIndex = 0;
            this.MaxPopInfo.Text = "Current max population:";
            // 
            // PopCapValue
            // 
            this.PopCapValue.AutoSize = true;
            this.PopCapValue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PopCapValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopCapValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.PopCapValue.Location = new System.Drawing.Point(230, 27);
            this.PopCapValue.Name = "PopCapValue";
            this.PopCapValue.Size = new System.Drawing.Size(45, 25);
            this.PopCapValue.TabIndex = 3;
            this.PopCapValue.Text = "300";
            // 
            // MaxPopValue
            // 
            this.MaxPopValue.AutoSize = true;
            this.MaxPopValue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaxPopValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPopValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.MaxPopValue.Location = new System.Drawing.Point(230, 0);
            this.MaxPopValue.Name = "MaxPopValue";
            this.MaxPopValue.Size = new System.Drawing.Size(45, 25);
            this.MaxPopValue.TabIndex = 1;
            this.MaxPopValue.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max limit population cap:";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanel.Controls.Add(this.InfoBox);
            this.InfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanel.Location = new System.Drawing.Point(3, 133);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(762, 69);
            this.InfoPanel.TabIndex = 9;
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoBox.DetectUrls = false;
            this.InfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.Color.Red;
            this.InfoBox.Location = new System.Drawing.Point(-3, 0);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InfoBox.Size = new System.Drawing.Size(765, 66);
            this.InfoBox.TabIndex = 11;
            this.InfoBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AOMEEUtilityHack.Properties.Resources.H9JVGXI;
            this.ClientSize = new System.Drawing.Size(774, 211);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(790, 260);
            this.MinimumSize = new System.Drawing.Size(750, 39);
            this.Name = "Form1";
            this.Text = "AOM EE Population Hack";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalMaxPop;
        private System.Windows.Forms.Button TotalMaxPopConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CurrentMaxPopConfirm;
        private System.Windows.Forms.TextBox CurrentMaxPop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TotalPopReset;
        private System.Windows.Forms.Button MaxPopReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PopCapValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MaxPopValue;
        private System.Windows.Forms.Label MaxPopInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.RichTextBox InfoBox;
    }
}

