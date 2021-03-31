using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace Sistema_Notas_Add
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConnection);

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            

            try
            {
                conexao.Open();

                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conexao;

                string nota = textNota.Text;
                string nome = textNome.Text;
                string matricula = textMatricula.Text;
                string materia = comboMateria.Text;
                string bimestre = comboBimestre.Text;

                command.CommandText = "INSERT INTO alunos " +
                    "VALUES ("+ nota +","+ nome +","+ matricula +","+ matricula +","+ materia +""+ bimestre + " )";
                command.ExecuteNonQuery();

                MessageBox.Show("Registro Inserido com Sucesso!" + MessageBoxButtons.OK);
                command.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO! " + ex );
            }
            finally
            {
                conexao.Close();
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConnection);


            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }

            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            

            try
            {
                conexao.Open();

                SqlCeCommand command = new SqlCeCommand();

                command.Connection = conexao;
                MessageBox.Show("Banco de Dados Conectado");
                command.CommandText = "CREATE TABLE alunos (Matricula INT NOT NULL PRIMARY KEY, Materia NVARCHAR(50), Nome NVARCHAR(50))";
                //command.CommandText = "INSERT INTO alunos VALUES (Nota_1 + Nota_2 + Nota_3 + Nota_4) / 4 WHERE Media_Final ";
                command.ExecuteNonQuery();

                conexao.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO! " + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

