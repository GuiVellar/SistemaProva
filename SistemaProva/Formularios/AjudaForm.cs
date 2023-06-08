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
    public partial class AjudaForm : Form
    {
        public AjudaForm()
        {
            InitializeComponent();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contatoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clique AQUI para entrar em Contato!");
            }
        }
        private void VisitLink()
        {
            contatoLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start
            ("https://api.whatsapp.com/send?phone=5517996626833&text=Ol%C3%A1,%20queria%20saber%20a%20respeito%20do%20Sistema.%20Estou%20com%20duvidas!");
        }
    }
}
