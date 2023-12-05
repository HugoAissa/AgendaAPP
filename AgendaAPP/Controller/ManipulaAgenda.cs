using AgendaAPP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAPP.Controller
{
    internal class ManipulaAgenda
    {
        public static void addNumero()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_Cadastrar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("nomeAgenda", Agenda.NomeAgenda);
                cmd.Parameters.AddWithValue("ruaAgenda", Agenda.RuaAgenda);
                cmd.Parameters.AddWithValue("numeroAgenda", Agenda.NumeroAgenda);
                cmd.Parameters.AddWithValue("categoriaAgenda", Agenda.CategoriaAgenda);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarNumero()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_Alterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("id", Agenda.Id);

                cmd.Parameters.AddWithValue("nomeAgenda", Agenda.NomeAgenda);
                cmd.Parameters.AddWithValue("categoriaAgenda", Agenda.CategoriaAgenda);
                cmd.Parameters.AddWithValue("numeroAgenda", Agenda.NumeroAgenda);
                cmd.Parameters.AddWithValue("ruaAgenda", Agenda.RuaAgenda);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally { cn.Close(); }
        }
        public static void VisualizarNumero(){
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_Pesquisar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@id", Agenda.Id);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Agenda.Id = Convert.ToInt32(dr["id"]);
                    Agenda.CategoriaAgenda = dr["categoriaAgenda"].ToString();
                    Agenda.NomeAgenda = dr["nomeAgenda"].ToString();
                    Agenda.RuaAgenda = dr["ruaAgenda"].ToString();
                    Agenda.NumeroAgenda = dr["numeroAgenda"].ToString();



                }
                else
                {
                    Agenda.Id = 0;
                    Agenda.CategoriaAgenda = "";
                    Agenda.NomeAgenda = "";
                    Agenda.RuaAgenda = "";
                    Agenda.NumeroAgenda = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void DeletarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_Delete", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@id", Agenda.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static BindingSource VisualizarCategoria()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_PesquisarCategoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@categoriaAgenda", Agenda.CategoriaAgenda);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
