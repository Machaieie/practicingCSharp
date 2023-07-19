using Edwin_Work.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edwin_Work.Formularios
{
    
    public partial class Cadastro : Form
    {
       
        private List<Cliente> contas;
        private SqlConnection conexao = new SqlConnection(@"Data Source=LEOPOLDO07;Initial Catalog=BancoEdwin;Integrated Security=True");
        //private string caminhoArquivo = @"C:\Users\asus\source\repos\Edwin_Work\FicheirosTXT\Cadastro.txt";
        SqlCommand comando = new SqlCommand();
        public Cadastro()
        {
            InitializeComponent();
        }
        
       

        public void Adicionar()
        {
           
        {


         
        }
        }

        private void txtNome__TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
      

           Cliente conta = new Cliente(txtNome.Texts, txtApelido.Texts, txtTelefone.Texts, txtEmail.Texts, double.Parse(txtSaldo.Texts));
            contas = new List<Cliente>();
            contas.Add(conta);
            conexao.Open();
            // string query = "INSERT INTO Cliente (Titular, Apelido, Telefone, Email, Saldo)" +"VALUES ('"+txtNome.Texts+ "','" + txtApelido.Texts + "','" + txtTelefone.Texts + "','" + txtEmail.Texts + "','" + double.Parse(txtNome.Texts) + "') ";

            string query1 = $"INSERT INTO Cliente (Titular, Apelido, Telefone, Email, Saldo) VALUES ('{txtNome.Texts}', '{txtApelido.Texts}','{txtTelefone.Texts}','{txtEmail.Texts}','{double.Parse(txtSaldo.Texts)}')";
            try
            {
                

                SqlCommand command = new SqlCommand(query1, conexao);
                command.ExecuteNonQuery();

                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex.Message);
            }


            txtNome.clear();
            txtApelido.clear();
            txtTelefone.clear();
            txtEmail.clear();
            txtSaldo.clear();
            conexao.Close();
            //MessageBox.Show("Cliente Cadastrado com sucesso!");
        }
    }
}
