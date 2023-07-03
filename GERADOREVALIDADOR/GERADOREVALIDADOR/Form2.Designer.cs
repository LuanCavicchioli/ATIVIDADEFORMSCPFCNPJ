namespace GERADOREVALIDADOR
{
    partial class Form2
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
            this.RBNGerarCpf = new System.Windows.Forms.RadioButton();
            this.RBNGerarCnpj = new System.Windows.Forms.RadioButton();
            this.OK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtComandoGerado1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vOLTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBNGerarCpf
            // 
            this.RBNGerarCpf.AutoSize = true;
            this.RBNGerarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNGerarCpf.Location = new System.Drawing.Point(54, 95);
            this.RBNGerarCpf.Name = "RBNGerarCpf";
            this.RBNGerarCpf.Size = new System.Drawing.Size(136, 28);
            this.RBNGerarCpf.TabIndex = 0;
            this.RBNGerarCpf.TabStop = true;
            this.RBNGerarCpf.Text = "GERAR CPF";
            this.RBNGerarCpf.UseVisualStyleBackColor = true;
            this.RBNGerarCpf.CheckedChanged += new System.EventHandler(this.RBNGerarCpf_CheckedChanged);
            // 
            // RBNGerarCnpj
            // 
            this.RBNGerarCnpj.AutoSize = true;
            this.RBNGerarCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNGerarCnpj.Location = new System.Drawing.Point(196, 95);
            this.RBNGerarCnpj.Name = "RBNGerarCnpj";
            this.RBNGerarCnpj.Size = new System.Drawing.Size(147, 28);
            this.RBNGerarCnpj.TabIndex = 1;
            this.RBNGerarCnpj.TabStop = true;
            this.RBNGerarCnpj.Text = "GERAR CPNJ";
            this.RBNGerarCnpj.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(158, 269);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtComandoGerado1
            // 
            this.TxtComandoGerado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComandoGerado1.Location = new System.Drawing.Point(86, 192);
            this.TxtComandoGerado1.Name = "TxtComandoGerado1";
            this.TxtComandoGerado1.ReadOnly = true;
            this.TxtComandoGerado1.Size = new System.Drawing.Size(227, 31);
            this.TxtComandoGerado1.TabIndex = 4;
            this.TxtComandoGerado1.TextChanged += new System.EventHandler(this.TxtComandoGerado1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vOLTARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vOLTARToolStripMenuItem
            // 
            this.vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            this.vOLTARToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.vOLTARToolStripMenuItem.Text = "VALIDADOR";
            this.vOLTARToolStripMenuItem.Click += new System.EventHandler(this.vOLTARToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 441);
            this.Controls.Add(this.TxtComandoGerado1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.RBNGerarCnpj);
            this.Controls.Add(this.RBNGerarCpf);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERADOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBNGerarCpf;
        private System.Windows.Forms.RadioButton RBNGerarCnpj;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtComandoGerado1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vOLTARToolStripMenuItem;
    }
}