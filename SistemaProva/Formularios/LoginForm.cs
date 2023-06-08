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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            Global.UsuarioLogado = new UsuariosDAO().Login(loginTextBox.Text, senhaTextBox.Text);
            //não encontrou
            if (Global.UsuarioLogado == null)
            {
                MessageBox.Show("Usuário e senha não encontrado!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                senhaTextBox.Clear();
                loginTextBox.Focus();
            }
            else
            {
                //encontrou e testamos se está ativo
                if (Global.UsuarioLogado.Ativo == false)
                {
                    MessageBox.Show("Usuário desabilitado!", ProductName,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    senhaTextBox.Clear();
                    loginTextBox.Focus();
                }
                else
                {
                    //está tudo certo, fechamos a tela
                    Close();
                }

            }
        }
    }
}
