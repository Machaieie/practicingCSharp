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

namespace Edwin_Work
{
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
        }
        private SqlConnection conexao = new SqlConnection(@"Data Source=LEOPOLDO07;Initial Catalog=BancoEdwin;Integrated Security=True");
        //private string caminhoArquivo = @"C:\Users\asus\source\repos\Edwin_Work\FicheirosTXT\Cadastro.txt";
        SqlCommand comando = new SqlCommand();
        private void textButton1__TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            string query = "UPDATE Cliente SET Titular = @titular, Apelido = @apelido, Telefone = @telefone, Email = @email  WHERE NumeroConta = @numero";
            SqlCommand command = new SqlCommand(query, conexao);
            command.Parameters.AddWithValue("@titular", txtNome.Texts);
            command.Parameters.AddWithValue("@apelido", txtApelido.Texts);
            command.Parameters.AddWithValue("@telefone", txtCelular.Texts);
            command.Parameters.AddWithValue("@Email", txtEmail.Texts);
            command.Parameters.AddWithValue("@numero", txtConta.Texts);


            try
            {

                command.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Atualizar os dados: " + ex.Message);
            }


            txtNome.clear();
            txtApelido.clear();
            txtCelular.clear();
            txtEmail.clear();
            txtConta.clear();
            conexao.Close();
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
