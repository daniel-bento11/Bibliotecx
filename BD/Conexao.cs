using MySql.Data.MySqlClient;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    

    public class Conexao
    {

        objUser usuario = new objUser();
        MySqlDataReader reader;

        public string strCon = "server=localhost; uid=root;pwd=;database=biblioteca";
        public MySqlConnection conectar (){
            MySqlConnection conexao = new MySqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
        
        public DataTable logar(objUser usuario) {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Select * from usuario left join tipo_usuario on tipo_usuario = id_tipo where login=@login and senha=@senha", conexao);
            comando.Parameters.AddWithValue("@login",usuario.Login_user);
            comando.Parameters.AddWithValue("@senha", usuario.Password_user);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool verificar_user(objUser usuario)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Select * from usuario where login=@login", conexao);
            comando.Parameters.AddWithValue("@login", usuario.Login_user);
            reader = comando.ExecuteReader();
            return reader.Read();
        }

        public void cadastrar_user(objUser usuario)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Insert into usuario (nome, login, senha, tipo_usuario) values (@nome, @login, @senha, 2)", conexao);
            comando.Parameters.AddWithValue("@login", usuario.Login_user);
            comando.Parameters.AddWithValue("@nome", usuario.Nome_user);
            comando.Parameters.AddWithValue("@senha", usuario.Password_user);
            comando.ExecuteNonQuery();
        }

        public DataTable captar_genero()
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Select id_genero AS 'ID', nome_genero AS 'Gênero' from genero_literario", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool verificar_genero(objGenero genero)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Select * from genero_literario where nome_genero=@genero", conexao);
            comando.Parameters.AddWithValue("@genero", genero.Nome_genero);
            reader = comando.ExecuteReader();
            return reader.Read();
        }

        public void add_genero(objGenero genero)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Insert into genero_literario (nome_genero) values (@nome)", conexao);
            comando.Parameters.AddWithValue("@nome", genero.Nome_genero);
            comando.ExecuteNonQuery();
        }

        public void del_genero(objGenero genero)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Delete from genero_literario where id_genero = @id_genero", conexao);
            comando.Parameters.AddWithValue("@id_genero", genero.Id_genero);
            comando.ExecuteNonQuery();
        }

        public void alt_genero(objGenero genero)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Update genero_literario set nome_genero = @nome_genero where id_genero = @id_genero", conexao);
            comando.Parameters.AddWithValue("@id_genero", genero.Id_genero);
            comando.Parameters.AddWithValue("@nome_genero", genero.Nome_genero);
            comando.ExecuteNonQuery();
        }

        public DataTable captar_autor()
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Select id_autor AS 'ID', nome_autor AS 'Autor', nacionalidade as 'Nacionalidade' from autores", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void del_autor(objAutor autor)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Delete from autores where id_autor = @id_autor", conexao);
            comando.Parameters.AddWithValue("@id_autor", autor.Id_autor);
            comando.ExecuteNonQuery();
        }

        public void add_autor(objAutor autor)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Insert into autores (nome_autor, nacionalidade) values (@nome, @nacionalidade)", conexao);
            comando.Parameters.AddWithValue("@nome", autor.Nome_autor);
            comando.Parameters.AddWithValue("@nacionalidade", autor.Nacionalidade);
            comando.ExecuteNonQuery();
        }

        public bool verificar_autor(objAutor autor)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Select * from autores where nome_autor=@autor", conexao);
            comando.Parameters.AddWithValue("@autor", autor.Nome_autor);
            reader = comando.ExecuteReader();
            return reader.Read();
        }

        public void alt_autor(objAutor autor)
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Update autores set nome_autor = @autor, nacionalidade = @nacionalidade where id_autor = @id_autor", conexao);
            comando.Parameters.AddWithValue("@autor", autor.Nome_autor);
            comando.Parameters.AddWithValue("@nacionalidade", autor.Nacionalidade);
            comando.Parameters.AddWithValue("@id_autor", autor.Id_autor);
            comando.ExecuteNonQuery();
        }

        public DataTable captar_editora()
        {
            MySqlConnection conexao = conectar();
            MySqlCommand comando = new MySqlCommand("Select id_editora AS 'ID', nome_editora AS 'Editora', tipo_editora AS 'Tipo', concat(pais_editora, ' - ' ,estado_editora) AS 'Localidade', site_editora as 'Site' from editoras", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }

    
}
