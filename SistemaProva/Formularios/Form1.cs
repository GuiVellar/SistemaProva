using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProva
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void horaTimer_Tick(object sender, EventArgs e)
        {
            horaToolStripStatusLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            horaTimer.Start();
            VerificarLogin();
        }

        private void janelaEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void alinhamentoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void alinhamentoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ladoALadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjudaForm Ajuda = new AjudaForm();
            Ajuda.MdiParent = this;
            Ajuda.Show();
            Ajuda.WindowState = FormWindowState.Normal;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstoqueForm Estoque = new EstoqueForm();
            Estoque.MdiParent = this;
            Estoque.Show();
            Estoque.WindowState = FormWindowState.Maximized;
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroForm Cadastro = new CadastroForm();
            Cadastro.MdiParent = this;
            Cadastro.Show();
            Cadastro.WindowState = FormWindowState.Maximized;
        }
        void VerificarLogin()
        {
            if (Global.UsuarioLogado == null)
            {
                nomeUsuarioToolStripStatusLabel.Text = "Nenhum usuário logado";
                //fecha os forms abertos
                foreach (Form f in this.MdiChildren)
                    f.Close();
                fazerOLoginToolStripMenuItem.Text = "Entrar";
                //chama a tela de login
                new LoginForm().ShowDialog();
            }
            if (Global.UsuarioLogado != null)
            {
                //só habilita o menu de usuários se for admin (nível 1)
                fazerOLoginToolStripMenuItem.Text = "Fazer Logoff";
                nomeUsuarioToolStripStatusLabel.Text = Global.UsuarioLogado.Nome;
            }
        }

        private void fazerOLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.UsuarioLogado = null;
            VerificarLogin();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizadorRelatorio visualizadorRelatorioForm = new
            VisualizadorRelatorio();
            visualizadorRelatorioForm.GerarRelatorioCidades();
            visualizadorRelatorioForm.ShowDialog();
        }
    }
}
