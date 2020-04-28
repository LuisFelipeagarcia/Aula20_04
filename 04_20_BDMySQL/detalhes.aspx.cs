using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_20_BDMySQL
{
    public partial class detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CapturaID()) 
            {
                DadosConsulta();
            }
        }

        private void DadosConsulta()
        {
            var idCliente = obterIDCliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from cliente where cli_id =@id";
                cmd.Parameters.AddWithValue("@id", idCliente);
                Conexao.Conectar();
                var reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    txtId.Text          = reader["cli_id"].ToString();
                    txtNome.Text        = reader["cli_nome"].ToString();
                    txtLogradouro.Text  = reader["cli_logradouro"].ToString();
                    TxtNumero.Text      = reader["cli_numero"].ToString();
                    TxtComplemento.Text = reader["cli_complemento"].ToString();
                    txtBairro.Text      = reader["cli_bairro"].ToString();
                    txtCidade.Text      = reader["cli_cidade"].ToString();
                    txtUF.Text          = reader["cli_uf"].ToString();
                }
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
            }
            finally 
            {
                Conexao.Desconectar();
            }
        }

        private object obterIDCliente()
        {
            var id = 0;
            var idURL = Request.QueryString["id"];

            if (!int.TryParse(idURL, out id)) 
            {
                throw new Exception("ID unválido");
            }
            if (id <= 0) 
            {
                throw new Exception("ID unválido");
            }
            return id;
        }

        private bool CapturaID()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }
    }
}