using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edwin_Work.Formularios
{
    public partial class Levantar : Form
    {
        public Levantar()
        {
            InitializeComponent();
        }
        double valor = 0;
        int dinheiro;
        private SqlConnection conexao = new SqlConnection(@"Data Source=LEOPOLDO07;Initial Catalog=BancoEdwin;Integrated Security=True");
        private void btnLevantar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            string query = "select Cliente.Saldo from Cliente where NumeroConta ='"+txtConta.Texts+"' ";
            SqlCommand command = new SqlCommand(query, conexao);
            object result = command.ExecuteScalar();
            if (result != null)
            {
                valor = double.Parse(result.ToString());
            }

            int aux = int.Parse(txtValor.Texts);
             
            //MessageBox.Show("valor" + aux);
            //MessageBox.Show("dinheiro" + valor);
            if (valor>aux)
            {
                valor -= 5;
                valor -= aux;
                string query1 = "UPDATE Cliente SET Saldo = @saldo  WHERE NumeroConta = @numero";
                SqlCommand command1 = new SqlCommand(query1, conexao);
                command1.Parameters.AddWithValue("@numero", txtConta.Texts);
                command1.Parameters.AddWithValue("@saldo", valor);
                try
                {

                    command1.ExecuteNonQuery();

                    MessageBox.Show("Levantamento Efectuado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Levantar Dinheiro: " + ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente para levantar " + aux);

            }
            conexao.Close();
        }
    }
}
