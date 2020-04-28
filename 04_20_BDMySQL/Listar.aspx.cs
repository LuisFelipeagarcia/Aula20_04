using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_20_BDMySQL
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            string query = @"select cli_id, cli_nome from cliente";
            DataTable dt = new DataTable();

            try 
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, Conexao.Connection);
                da.Fill(dt);
                rptClientes.DataSource = dt;
                rptClientes.DataBind();
            } 
            catch (Exception ex) 
            {
                lblMsg.Text = "Falha: " + ex.Message;
            } 
            
        }
    }
}