using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;

namespace Sistema_Notas
{

    class CadastroUsuarios
    {
        private static User[] usuarios =
        {
            new User(){Login = "mariacruz@escola.com", Pass = "abc123"},
            new User(){Login = "fernadasouza@escola.com", Pass = "123abc"},
            new User(){Login = "otaviomen@escola.com", Pass = "mnb123"}
        };

        private static User usuariologado = null;

        public static User Userlogado
        {
            get { return usuariologado; }
            private set { usuariologado = value; }

        }
        
        public bool Login(string login, string pass)
        {
            foreach (var item in usuarios)
            {
                if (item.Login == login && item.Pass == pass)
                {
                    usuariologado = Userlogado;
                    return true;
                }
            }
            return false;
        }
    }


}
