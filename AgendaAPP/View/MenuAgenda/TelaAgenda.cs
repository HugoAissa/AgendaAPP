using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAPP.View.MenuAgenda
{
    public partial class TelaAgenda : Form
    {
        public TelaAgenda()
        {
            InitializeComponent();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Alterar CadastroAgenda = new Alterar();
            CadastroAgenda.Show();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro CadastroAgenda = new Cadastro();
            CadastroAgenda.Show();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            Deletar CadastroAgenda = new Deletar();
            CadastroAgenda.Show();
        }

        private void btn_pesquisarid_Click(object sender, EventArgs e)
        {
            Pesquisar CadastroAgenda = new Pesquisar();
            CadastroAgenda.Show();
        }

        private void btn_pesquisarcategoria_Click(object sender, EventArgs e)
        {
            PesquisarCategoria CadastroAgenda = new PesquisarCategoria();
            CadastroAgenda.Show();
        }
    }
}
