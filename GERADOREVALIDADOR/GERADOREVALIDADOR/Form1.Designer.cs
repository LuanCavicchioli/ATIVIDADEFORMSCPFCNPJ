namespace GERADOREVALIDADOR
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gERADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RBNCpf = new System.Windows.Forms.RadioButton();
            this.RBNCnpj = new System.Windows.Forms.RadioButton();
            this.SAIR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtComandoGerado = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERADORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gERADORToolStripMenuItem
            // 
            this.gERADORToolStripMenuItem.Name = "gERADORToolStripMenuItem";
            this.gERADORToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.gERADORToolStripMenuItem.Text = "GERADOR";
            this.gERADORToolStripMenuItem.Click += new System.EventHandler(this.gERADORToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RBNCpf
            // 
            this.RBNCpf.AutoSize = true;
            this.RBNCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNCpf.Location = new System.Drawing.Point(35, 93);
            this.RBNCpf.Name = "RBNCpf";
            this.RBNCpf.Size = new System.Drawing.Size(149, 28);
            this.RBNCpf.TabIndex = 2;
            this.RBNCpf.Text = "VALIDAR CPF";
            this.RBNCpf.UseVisualStyleBackColor = true;
            this.RBNCpf.CheckedChanged += new System.EventHandler(this.RBNCpf_CheckedChanged);
            // 
            // RBNCnpj
            // 
            this.RBNCnpj.AutoSize = true;
            this.RBNCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNCnpj.Location = new System.Drawing.Point(190, 93);
            this.RBNCnpj.Name = "RBNCnpj";
            this.RBNCnpj.Size = new System.Drawing.Size(160, 28);
            this.RBNCnpj.TabIndex = 3;
            this.RBNCnpj.Text = "VALIDAR CNPJ";
            this.RBNCnpj.UseVisualStyleBackColor = true;
            // 
            // SAIR
            // 
            this.SAIR.Location = new System.Drawing.Point(147, 321);
            this.SAIR.Name = "SAIR";
            this.SAIR.Size = new System.Drawing.Size(75, 23);
            this.SAIR.TabIndex = 4;
            this.SAIR.Text = "SAIR";
            this.SAIR.UseVisualStyleBackColor = true;
            this.SAIR.Click += new System.EventHandler(this.SAIR_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtComandoGerado
            // 
            this.TxtComandoGerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComandoGerado.Location = new System.Drawing.Point(99, 166);
            this.TxtComandoGerado.Name = "TxtComandoGerado";
            this.TxtComandoGerado.Size = new System.Drawing.Size(185, 29);
            this.TxtComandoGerado.TabIndex = 6;
            this.TxtComandoGerado.TextChanged += new System.EventHandler(this.TxtComandoGerado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 445);
            this.Controls.Add(this.TxtComandoGerado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SAIR);
            this.Controls.Add(this.RBNCnpj);
            this.Controls.Add(this.RBNCpf);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VALIDADOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERADORToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton RBNCpf;
        private System.Windows.Forms.RadioButton RBNCnpj;
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtComandoGerado;
    }
}

