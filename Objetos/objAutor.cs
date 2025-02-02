using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class objAutor
    {
        private string nome_autor;
        private int id_autor;
        private string nacionalidade;

        public string Nome_autor { get => nome_autor; set => nome_autor = value; }
        public int Id_autor { get => id_autor; set => id_autor = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
    }
}
