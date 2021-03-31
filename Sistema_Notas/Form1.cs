using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Notas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            textLogin.Clear();
            textPass.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CadastroUsuarios usuarios =new CadastroUsuarios();
           

            string senha = textPass.Text;
            string login = textLogin.Text;

            

            if (usuarios.Login(login,senha))
            {
                MessageBox.Show("Bem-Vindo(a) ao Sistema ");
            }
            else
            {
                MessageBox.Show("Senha e/ou Login Incorretos");
            }

            
            
            
            
        }
    }
}
