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
    public partial class PesquisarNome : Form
    {
        public PesquisarNome()
        {
            InitializeComponent();
        }

        private void btn_pesquisarNome_Click(object sender, EventArgs e)
        {
            Agenda.NomeAgenda = txb_PesquisarNome.Text;

            ManipulaAgenda.VisualizarNome();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.DataSource = ManipulaAgenda.VisualizarNome();
            dataGridView1.Columns[5].HeaderCell.Value = "Codigo";
            dataGridView1.Columns[6].HeaderCell.Value = "Categoria";
            dataGridView1.Columns[7].HeaderCell.Value = "Nome";
            dataGridView1.Columns[8].HeaderCell.Value = "Telefone";
            dataGridView1.Columns[9].HeaderCell.Value = "Endereço";
        }
    }
}
