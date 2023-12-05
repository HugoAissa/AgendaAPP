using AgendaAPP.Controller;
using AgendaAPP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAPP.View
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Agenda.CategoriaAgenda = txb_categoriaAgenda.Text;
            Agenda.NumeroAgenda = txb_numeroAgenda.Text;
            Agenda.RuaAgenda = txb_ruaAgenda.Text;
            Agenda.NomeAgenda = txb_nomeAgenda.Text;

            ManipulaAgenda Manipula = new ManipulaAgenda();
            ManipulaAgenda.addNumero();
        }

        private void txb_numeroAgenda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
