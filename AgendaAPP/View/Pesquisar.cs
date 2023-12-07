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
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {


            Agenda.Id = Convert.ToInt32(txb_idPesquisar.Text);
            ManipulaAgenda Manipula = new ManipulaAgenda();
            Manipula.VisualizarNumero();

            txb_categoriaPesquisar.Text = Agenda.CategoriaAgenda;
            txb_nomePesquisar.Text = Agenda.NomeAgenda;
            txb_numeroPesquisar.Text = Agenda.NumeroAgenda;
            txb_ruaPesquisar.Text = Agenda.RuaAgenda;
        }
    }
}
