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
    public partial class Deletar : Form
    {
        public Deletar()
        {
            InitializeComponent();
        }

        private void btn_pesquisarDeletar_Click(object sender, EventArgs e)
        {
            Agenda.Id = Convert.ToInt32(lbl_id.Text);
            ManipulaAgenda Manipula = new ManipulaAgenda();
            ManipulaAgenda.VisualizarNumero();

            txb_categoriaDeletar.Text = Agenda.CategoriaAgenda;
            txb_nomeDeletar.Text = Agenda.NomeAgenda;
            txb_numeroDeletar.Text = Agenda.NumeroAgenda;
            txb_ruaDeletar.Text = Agenda.RuaAgenda;

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

            Agenda.Id = Convert.ToInt32(lbl_id.Text);

            if (lbl_id.Text == "")
            {
                MessageBox.Show("Digite a matricula que deseja excluir.");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja realmente excluir o usuário: " + txb_nomeDeletar.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resposta == DialogResult.Yes)
                {

                    ManipulaAgenda Manipula = new ManipulaAgenda();
                    ManipulaAgenda.DeletarUsuario();


                }
                else
                {
                    txb_categoriaDeletar.Text = "";
                    txb_nomeDeletar.Text = "";
                    txb_numeroDeletar.Text = "";
                    txb_ruaDeletar.Text = "";
                }
            }
        }
    }

}
