namespace SistemaProva
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerOLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.horaToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nomeUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.horaTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerOLoginToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.entrarToolStripMenuItem.Text = "&Entrar";
            // 
            // fazerOLoginToolStripMenuItem
            // 
            this.fazerOLoginToolStripMenuItem.Name = "fazerOLoginToolStripMenuItem";
            this.fazerOLoginToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fazerOLoginToolStripMenuItem.Text = "Fazer o Login";
            this.fazerOLoginToolStripMenuItem.Click += new System.EventHandler(this.fazerOLoginToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "E&stoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "&Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.janelaEmCascataToolStripMenuItem,
            this.alinhamentoHorizontalToolStripMenuItem,
            this.alinhamentoVerticalToolStripMenuItem,
            this.ladoALadoToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "E&xibir";
            // 
            // janelaEmCascataToolStripMenuItem
            // 
            this.janelaEmCascataToolStripMenuItem.Name = "janelaEmCascataToolStripMenuItem";
            this.janelaEmCascataToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.janelaEmCascataToolStripMenuItem.Text = "Janela em Cascata";
            this.janelaEmCascataToolStripMenuItem.Click += new System.EventHandler(this.janelaEmCascataToolStripMenuItem_Click);
            // 
            // alinhamentoHorizontalToolStripMenuItem
            // 
            this.alinhamentoHorizontalToolStripMenuItem.Name = "alinhamentoHorizontalToolStripMenuItem";
            this.alinhamentoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.alinhamentoHorizontalToolStripMenuItem.Text = "Alinhamento Horizontal";
            this.alinhamentoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.alinhamentoHorizontalToolStripMenuItem_Click);
            // 
            // alinhamentoVerticalToolStripMenuItem
            // 
            this.alinhamentoVerticalToolStripMenuItem.Name = "alinhamentoVerticalToolStripMenuItem";
            this.alinhamentoVerticalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.alinhamentoVerticalToolStripMenuItem.Text = "Alinhamento Vertical";
            this.alinhamentoVerticalToolStripMenuItem.Click += new System.EventHandler(this.alinhamentoVerticalToolStripMenuItem_Click);
            // 
            // ladoALadoToolStripMenuItem
            // 
            this.ladoALadoToolStripMenuItem.Name = "ladoALadoToolStripMenuItem";
            this.ladoALadoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ladoALadoToolStripMenuItem.Text = "Lado a Lado";
            this.ladoALadoToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horaToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.nomeUsuarioToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // horaToolStripStatusLabel
            // 
            this.horaToolStripStatusLabel.Name = "horaToolStripStatusLabel";
            this.horaToolStripStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.horaToolStripStatusLabel.Text = "Hora";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // nomeUsuarioToolStripStatusLabel
            // 
            this.nomeUsuarioToolStripStatusLabel.Name = "nomeUsuarioToolStripStatusLabel";
            this.nomeUsuarioToolStripStatusLabel.Size = new System.Drawing.Size(136, 17);
            this.nomeUsuarioToolStripStatusLabel.Text = "Nenhum usuário logado";
            // 
            // horaTimer
            // 
            this.horaTimer.Tick += new System.EventHandler(this.horaTimer_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerOLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel horaToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nomeUsuarioToolStripStatusLabel;
        private System.Windows.Forms.Timer horaTimer;
        private System.Windows.Forms.ToolStripMenuItem janelaEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

