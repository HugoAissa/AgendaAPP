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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Agenda.Id = Convert.ToInt32(lbl_id.Text);


            if (txb_numeroAlterar.Text == "")
            {
                MessageBox.Show("Digite a matricula que deseja excluir.");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja realmente alterar o usuário: " + txb_numeroAlterar.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resposta == DialogResult.Yes)
                {
                    Agenda.CategoriaAgenda = txb_categoriaAlterar.Text;
                    Agenda.NumeroAgenda = txb_numeroAlterar.Text;
                    Agenda.RuaAgenda = txb_ruaAlterar.Text;
                    Agenda.NomeAgenda = txb_nomeAlterar.Text;
                    ManipulaAgenda Manipula = new ManipulaAgenda();
                    Manipula.AlterarNumero();

                }
                else
                {
                    txb_categoriaAlterar.Text = "";
                    txb_numeroAlterar.Text = "";
                    txb_ruaAlterar.Text = "";
                   txb_nomeAlterar.Text= "";

                }
            }

        }
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Agenda.Id = Convert.ToInt32(lbl_id.Text);
            txb_categoriaAlterar.Text = Agenda.CategoriaAgenda;
            txb_nomeAlterar.Text = Agenda.NomeAgenda;                                                                      
            txb_numeroAlterar.Text = Agenda.NumeroAgenda;

            txb_ruaAlterar.Text = Agenda.RuaAgenda;

            ManipulaAgenda Manipula = new ManipulaAgenda();
            ManipulaAgenda.VisualizarNumero();
        }
    }
}

