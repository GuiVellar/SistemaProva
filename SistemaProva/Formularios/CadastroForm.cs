using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaProva
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
            Text = "Novo Produto";
            idTextBox.Text = "Automático";
            idTextBox.ReadOnly = true;
            nomeTextBox.Focus();

            ListarSiglas();
        }

        public CadastroForm(int id)
        {
            InitializeComponent();
            var cadastro = new EstoqueDAO().Buscar(id);

            Text = "Alteração de Produto";
            idTextBox.Text = cadastro.Id.ToString();
            idTextBox.ReadOnly = true;

            nomeTextBox.Text = cadastro.Nome;
            nomeTextBox.Focus();

            ListarSiglas();
            Application.DoEvents();
            siglaComboBox.SelectedValue = cadastro.Sigla;
        }

        void ListarSiglas()
        {
            var lista = new MarcasDAO().Listar();
            siglaComboBox.DisplayMember = "Nome";
            siglaComboBox.ValueMember = "Sigla";
            siglaComboBox.DataSource = lista;
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (Text == "Novo Produto")
            {
                //faz a inclusão
                new EstoqueDAO().Adicionar(nomeTextBox.Text, siglaComboBox.SelectedValue.ToString());
                MessageBox.Show("Cidade adicionada com sucesso!", ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                //faz a alteração
                new EstoqueDAO().Atualizar(Convert.ToInt32(idTextBox.Text), 
                    nomeTextBox.Text, siglaComboBox.SelectedValue.ToString());
                MessageBox.Show("Cidade alterada com sucesso!", ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }
    }
}
