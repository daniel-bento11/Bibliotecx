using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class objUser
    {
        private int id_user;
        private string nome_user;
        private string login_user;
        private string password_user;
        private int id_tipo_user;
        private string nome_tipo_user;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Nome_user { get => nome_user; set => nome_user = value; }
        public string Login_user { get => login_user; set => login_user = value; }
        public int Id_tipo_user { get => id_tipo_user; set => id_tipo_user = value; }
        public string Nome_tipo_user { get => nome_tipo_user; set => nome_tipo_user = value; }
        public string Password_user { get => password_user; set => password_user = value; }
    }
}
