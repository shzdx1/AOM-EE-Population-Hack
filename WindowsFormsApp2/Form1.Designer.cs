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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalMaxPop = new System.Windows.Forms.TextBox();
            this.TotalMaxPopConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalPopReset = new System.Windows.Forms.Button();
            this.MaxPopReset = new System.Windows.Forms.Button();
            this.CurrentMaxPop = new System.Windows.Forms.TextBox();
            this.CurrentMaxPopConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actual max population (value between 0 and max pop cap)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Population max cap (bypass 300 max pop limit)";
            // 
            // TotalMaxPop
            // 
            this.TotalMaxPop.Location = new System.Drawing.Point(12, 105);
            this.TotalMaxPop.Name = "TotalMaxPop";
            this.TotalMaxPop.Size = new System.Drawing.Size(125, 20);
            this.TotalMaxPop.TabIndex = 4;
            this.TotalMaxPop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalMaxPop_KeyDown);
            // 
            // TotalMaxPopConfirm
            // 
            this.TotalMaxPopConfirm.Location = new System.Drawing.Point(137, 103);
            this.TotalMaxPopConfirm.Name = "TotalMaxPopConfirm";
            this.TotalMaxPopConfirm.Size = new System.Drawing.Size(75, 23);
            this.TotalMaxPopConfirm.TabIndex = 7;
            this.TotalMaxPopConfirm.Text = "ok";
            this.TotalMaxPopConfirm.UseVisualStyleBackColor = true;
            this.TotalMaxPopConfirm.Click += new System.EventHandler(this.TotalMaxPopConfirm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(600, 450);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalPopReset);
            this.panel1.Controls.Add(this.MaxPopReset);
            this.panel1.Controls.Add(this.TotalMaxPopConfirm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CurrentMaxPop);
            this.panel1.Controls.Add(this.TotalMaxPop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CurrentMaxPopConfirm);
            this.panel1.Location = new System.Drawing.Point(3, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 219);
            this.panel1.TabIndex = 1;
            // 
            // TotalPopReset
            // 
            this.TotalPopReset.Location = new System.Drawing.Point(211, 103);
            this.TotalPopReset.Name = "TotalPopReset";
            this.TotalPopReset.Size = new System.Drawing.Size(75, 23);
            this.TotalPopReset.TabIndex = 9;
            this.TotalPopReset.Text = "reset";
            this.TotalPopReset.UseVisualStyleBackColor = true;
            this.TotalPopReset.Click += new System.EventHandler(this.TotalPopReset_Click);
            // 
            // MaxPopReset
            // 
            this.MaxPopReset.Location = new System.Drawing.Point(211, 31);
            this.MaxPopReset.Name = "MaxPopReset";
            this.MaxPopReset.Size = new System.Drawing.Size(75, 23);
            this.MaxPopReset.TabIndex = 8;
            this.MaxPopReset.Text = "reset";
            this.MaxPopReset.UseVisualStyleBackColor = true;
            // 
            // CurrentMaxPop
            // 
            this.CurrentMaxPop.Location = new System.Drawing.Point(12, 33);
            this.CurrentMaxPop.Name = "CurrentMaxPop";
            this.CurrentMaxPop.Size = new System.Drawing.Size(125, 20);
            this.CurrentMaxPop.TabIndex = 2;
            // 
            // CurrentMaxPopConfirm
            // 
            this.CurrentMaxPopConfirm.Location = new System.Drawing.Point(137, 31);
            this.CurrentMaxPopConfirm.Name = "CurrentMaxPopConfirm";
            this.CurrentMaxPopConfirm.Size = new System.Drawing.Size(75, 23);
            this.CurrentMaxPopConfirm.TabIndex = 6;
            this.CurrentMaxPopConfirm.Text = "ok";
            this.CurrentMaxPopConfirm.UseVisualStyleBackColor = true;
            this.CurrentMaxPopConfirm.Click += new System.EventHandler(this.CurrentMaxPopConfirm_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 219);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button TotalPopReset;
        private System.Windows.Forms.Button MaxPopReset;
    }
}

