using System;
using System.Collections;
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
    public partial class EstoqueForm : Form
    {
        public EstoqueForm()
        {
            InitializeComponent();
            Application.DoEvents();
            //desabilita os botões
            excluirButton.Enabled = false;
            alterarButton.Enabled = false;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            var dados = new EstoqueDAO().ListarTodas();
            quantidadeLabel.Text = $"Registros encontrados: {dados.Count()}";
            listaDataGridView.DataSource = dados;
            excluirButton.Enabled = dados.Count() > 0;
            alterarButton.Enabled = excluirButton.Enabled;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do Produto?", ProductName,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id =
               Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
               new EstoqueDAO().Excluir(id);
               buscarButton.PerformClick();
               MessageBox.Show("Produto excluído com sucesso!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
            new CadastroForm(id).ShowDialog();
            buscarButton.PerformClick();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
            new CadastroForm().ShowDialog();
            buscarButton.PerformClick();
        }
    }
}
