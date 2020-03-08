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
            this.label2 = new System.Windows.Forms.Label();
            this.TotalMaxPop = new System.Windows.Forms.TextBox();
            this.TotalMaxPopConfirm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TotalPopReset = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MaxPopInfo = new System.Windows.Forms.Label();
            this.PopCapValue = new System.Windows.Forms.Label();
            this.MaxPopValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CurrentMaxPop = new System.Windows.Forms.TextBox();
            this.CurrentMaxPopConfirm = new System.Windows.Forms.Button();
            this.MaxPopReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max population cap (bypass 300 max pop cap limit)";
            // 
            // TotalMaxPop
            // 
            this.TotalMaxPop.BackColor = System.Drawing.Color.White;
            this.TotalMaxPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMaxPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMaxPop.Location = new System.Drawing.Point(10, 29);
            this.TotalMaxPop.Name = "TotalMaxPop";
            this.TotalMaxPop.Size = new System.Drawing.Size(159, 32);
            this.TotalMaxPop.TabIndex = 4;
            this.TotalMaxPop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalMaxPop_KeyDown);
            // 
            // TotalMaxPopConfirm
            // 
            this.TotalMaxPopConfirm.BackColor = System.Drawing.Color.White;
            this.TotalMaxPopConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.TotalMaxPopConfirm.FlatAppearance.BorderSize = 3;
            this.TotalMaxPopConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalMaxPopConfirm.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMaxPopConfirm.Location = new System.Drawing.Point(175, 27);
            this.TotalMaxPopConfirm.Name = "TotalMaxPopConfirm";
            this.TotalMaxPopConfirm.Size = new System.Drawing.Size(100, 35);
            this.TotalMaxPopConfirm.TabIndex = 7;
            this.TotalMaxPopConfirm.Text = "ok";
            this.TotalMaxPopConfirm.UseVisualStyleBackColor = false;
            this.TotalMaxPopConfirm.Click += new System.EventHandler(this.TotalMaxPopConfirm_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.TotalMaxPop);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TotalPopReset);
            this.panel4.Controls.Add(this.TotalMaxPopConfirm);
            this.panel4.Location = new System.Drawing.Point(3, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 69);
            this.panel4.TabIndex = 9;
            // 
            // TotalPopReset
            // 
            this.TotalPopReset.BackColor = System.Drawing.Color.White;
            this.TotalPopReset.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.TotalPopReset.FlatAppearance.BorderSize = 3;
            this.TotalPopReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalPopReset.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPopReset.Location = new System.Drawing.Point(276, 27);
            this.TotalPopReset.Name = "TotalPopReset";
            this.TotalPopReset.Size = new System.Drawing.Size(100, 35);
            this.TotalPopReset.TabIndex = 9;
            this.TotalPopReset.Text = "reset";
            this.TotalPopReset.UseVisualStyleBackColor = false;
            this.TotalPopReset.Click += new System.EventHandler(this.TotalPopReset_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.AliceBlue;
            this.panel5.Controls.Add(this.MaxPopInfo);
            this.panel5.Controls.Add(this.PopCapValue);
            this.panel5.Controls.Add(this.MaxPopValue);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 63);
            this.panel5.TabIndex = 10;
            // 
            // MaxPopInfo
            // 
            this.MaxPopInfo.AutoSize = true;
            this.MaxPopInfo.BackColor = System.Drawing.Color.Transparent;
            this.MaxPopInfo.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPopInfo.ForeColor = System.Drawing.Color.Black;
            this.MaxPopInfo.Location = new System.Drawing.Point(6, 7);
            this.MaxPopInfo.Name = "MaxPopInfo";
            this.MaxPopInfo.Size = new System.Drawing.Size(247, 18);
            this.MaxPopInfo.TabIndex = 0;
            this.MaxPopInfo.Text = "Current max population:";
            // 
            // PopCapValue
            // 
            this.PopCapValue.AutoSize = true;
            this.PopCapValue.BackColor = System.Drawing.Color.Transparent;
            this.PopCapValue.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopCapValue.ForeColor = System.Drawing.Color.Green;
            this.PopCapValue.Location = new System.Drawing.Point(255, 34);
            this.PopCapValue.Name = "PopCapValue";
            this.PopCapValue.Size = new System.Drawing.Size(36, 18);
            this.PopCapValue.TabIndex = 3;
            this.PopCapValue.Text = "300";
            // 
            // MaxPopValue
            // 
            this.MaxPopValue.AutoSize = true;
            this.MaxPopValue.BackColor = System.Drawing.Color.Transparent;
            this.MaxPopValue.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPopValue.ForeColor = System.Drawing.Color.Green;
            this.MaxPopValue.Location = new System.Drawing.Point(255, 7);
            this.MaxPopValue.Name = "MaxPopValue";
            this.MaxPopValue.Size = new System.Drawing.Size(36, 18);
            this.MaxPopValue.TabIndex = 1;
            this.MaxPopValue.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max limit population cap:";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.InfoPanel.Controls.Add(this.InfoBox);
            this.InfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanel.Location = new System.Drawing.Point(4, 228);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(387, 75);
            this.InfoPanel.TabIndex = 9;
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.AliceBlue;
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoBox.DetectUrls = false;
            this.InfoBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.InfoBox.ForeColor = System.Drawing.Color.Red;
            this.InfoBox.Location = new System.Drawing.Point(3, 2);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InfoBox.Size = new System.Drawing.Size(381, 70);
            this.InfoBox.TabIndex = 11;
            this.InfoBox.Text = "";
            this.InfoBox.TextChanged += new System.EventHandler(this.InfoBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.MaxPopReset);
            this.panel3.Controls.Add(this.CurrentMaxPopConfirm);
            this.panel3.Controls.Add(this.CurrentMaxPop);
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 66);
            this.panel3.TabIndex = 4;
            // 
            // CurrentMaxPop
            // 
            this.CurrentMaxPop.BackColor = System.Drawing.Color.White;
            this.CurrentMaxPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentMaxPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMaxPop.Location = new System.Drawing.Point(12, 25);
            this.CurrentMaxPop.Name = "CurrentMaxPop";
            this.CurrentMaxPop.Size = new System.Drawing.Size(159, 32);
            this.CurrentMaxPop.TabIndex = 2;
            this.CurrentMaxPop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CurrentMaxPop_KeyDown);
            // 
            // CurrentMaxPopConfirm
            // 
            this.CurrentMaxPopConfirm.BackColor = System.Drawing.Color.White;
            this.CurrentMaxPopConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CurrentMaxPopConfirm.FlatAppearance.BorderSize = 3;
            this.CurrentMaxPopConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentMaxPopConfirm.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMaxPopConfirm.Location = new System.Drawing.Point(177, 24);
            this.CurrentMaxPopConfirm.Name = "CurrentMaxPopConfirm";
            this.CurrentMaxPopConfirm.Size = new System.Drawing.Size(100, 35);
            this.CurrentMaxPopConfirm.TabIndex = 6;
            this.CurrentMaxPopConfirm.Text = "ok";
            this.CurrentMaxPopConfirm.UseVisualStyleBackColor = false;
            this.CurrentMaxPopConfirm.Click += new System.EventHandler(this.CurrentMaxPopConfirm_Click);
            // 
            // MaxPopReset
            // 
            this.MaxPopReset.BackColor = System.Drawing.Color.White;
            this.MaxPopReset.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.MaxPopReset.FlatAppearance.BorderSize = 3;
            this.MaxPopReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxPopReset.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPopReset.Location = new System.Drawing.Point(277, 24);
            this.MaxPopReset.Name = "MaxPopReset";
            this.MaxPopReset.Size = new System.Drawing.Size(100, 35);
            this.MaxPopReset.TabIndex = 8;
            this.MaxPopReset.Text = "reset";
            this.MaxPopReset.UseVisualStyleBackColor = false;
            this.MaxPopReset.Click += new System.EventHandler(this.MaxPopReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actual max population (value between 0 and max pop cap)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 307);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.InfoPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 346);
            this.Name = "Form1";
            this.Text = "AOM EE Population Hack";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalMaxPop;
        private System.Windows.Forms.Button TotalMaxPopConfirm;
        private System.Windows.Forms.Button TotalPopReset;
        private System.Windows.Forms.Label PopCapValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MaxPopValue;
        private System.Windows.Forms.Label MaxPopInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MaxPopReset;
        private System.Windows.Forms.Button CurrentMaxPopConfirm;
        private System.Windows.Forms.TextBox CurrentMaxPop;
    }
}

