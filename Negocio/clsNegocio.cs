using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Objetos;

namespace Negocio
{
    public class clsNegocio
    {
        Conexao con = new Conexao();
        public DataTable Logar(objUser usuario)
        {
            return con.logar(usuario);
        }

        public bool Verificar_Usuario(objUser usuario)
        {
            return con.verificar_user(usuario);
        }

        public void Cadastrar_usuario(objUser usuario)
        {
            con.cadastrar_user(usuario);
        }

        public DataTable Captar_genero()
        {
            return con.captar_genero();
        }

        public bool Verificar_Genero(objGenero genero)
        {
            return con.verificar_genero(genero);
        }

        public void Add_Genero(objGenero genero)
        {
            con.add_genero(genero);
        }

        public void Del_Genero(objGenero genero)
        {
            con.del_genero(genero);
        }

        public void Alt_Genero(objGenero genero)
        {
            con.alt_genero(genero);
        }
    }
}