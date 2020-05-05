using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_20_BDMySQL
{
    public partial class Editar : System.Web.UI.Page
    {
        #region Page_Loado
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                if (CapturaID())
                {
                    DadosEditar();
                }
            }
            
        }
        #endregion Page_Loado
        

        private bool CapturaID()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }

        private void DadosEditar()
        {
            var idCliente = ObterIDCliente();

            try 
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from cliente where cli_id =@id";

                cmd.Parameters.AddWithValue("@id", idCliente);
                Conexao.Conectar();
                var reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    txtId.Text = reader["cli_id"].ToString();
                    txtNome.Text = reader["cli_nome"].ToString();
                    txtLogradouro.Text = reader["cli_logradouro"].ToString();
                    TxtNumero.Text = reader["cli_numero"].ToString();
                    TxtComplemento.Text = reader["cli_complemento"].ToString();
                    txtBairro.Text = reader["cli_bairro"].ToString();
                    txtCidade.Text = reader["cli_cidade"].ToString();
                    txtUF.Text = reader["cli_uf"].ToString();

                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private object ObterIDCliente()
        {
            var id = 0;
            var idURL = Request.QueryString["id"];

            if (!int.TryParse(idURL,out id)) 
            {
                throw new Exception("ID INVÁLIDO");
            }
            if (id<=0)
            {
                throw new Exception("ID INVÁLIDO");
            }
            return id;
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            try 
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"update cliente set cli_nome = @nome,
                                                       cli_logradouro = @logradouro,
                                                       cli_numero = @numero,
                                                       cli_complemento = @complemento,
                                                       cli_bairro = @bairro,
                                                       cli_cidade = @cidade,
                                                       cli_uf = @uf
                                                       where cli_id = @id;";

                cmd.Parameters.AddWithValue("id", txtId.Text);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
                cmd.Parameters.AddWithValue("numero", TxtNumero.Text);
                cmd.Parameters.AddWithValue("complemento", TxtComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("uf", txtUF.Text);

                Conexao.Conectar();
                cmd.ExecuteNonQuery();
                Response.Redirect("Listar.aspx");
            } 
            catch (Exception ex) 
            {
                lblResultado.Text = "Falha" + ex.Message;
            } 
            finally 
            {
                Conexao.Desconectar();
            }
        }
    }
}