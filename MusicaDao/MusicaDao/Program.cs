using Db;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaDao
{
  class Program
  {
    static void Main(string[] args)
    {
      MusicaDao dao = DaoFactory.CreateDao<MusicaDao>();



      //CRIANDO UMA MÚSICA PARA INSERTIR NO BANCO DE DADOS
      Musica m1 = new Musica() { Titulo = "Fear of The Dark", Cantor = "Iron Maiden", Album = "Fear of The Dark", Ano = 1994, Genero = Genero.Rock };
      Musica m2 = new Musica() { Titulo = "Wasting Love", Cantor = "Iron Maiden", Album = "Killers", Ano = 1965, Genero = Genero.Rock };
      Musica m3 = new Musica() { Titulo = "Brave New World", Cantor = "Iron Maiden", Album = "Dance of Death", Ano = 2004, Genero = Genero.Rock };
      Musica m4 = new Musica() { Titulo = "The Trooper", Cantor = "Iron Maiden", Album = "A Matter life and Death", Ano = 2017, Genero = Genero.Rock };

      //PARA TESTE DE UPDATE
      Musica m5 = new Musica() { Id = 1, Titulo = "Furacão 2000", Cantor = "Tigrão", Album = "Boladão", Ano = 2015, Genero = Genero.Pop };


      dao.Atualizar(m5);

      //dao.Insert(m1);
      //dao.Insert(m2);
      //dao.Insert(m3);
      //dao.Insert(m4);

      //Musica m = dao.Carregar(1);

      //Console.WriteLine(m);

      //dao.Apagar(12);

      Console.WriteLine("Músicas Cadastradas: " + dao.Count());
      

    }
  }


  //CLASE MÚSICADao
  //TEM ACESSO AOS MÉTODOS HERDADOS DA CLASSE DAO
  class MusicaDao : Dao
  {
    //MÉTODO PARA INSERIR UMA MÚSICA
    public void Insert(Musica m)
    {

      //COLOQUEI DENTRO DO USING PARA EXECUTAR O DISPOSE AUTOMATICAMENTE DEPOIS DO USO E NÃO TER INSTANCIAS ABERTAS
      using (DbConnection conn = CreateConnection())
      {
        using (DbCommand cmd = CreateCommand(conn, "INSERT INTO Musica (Titulo,Album,Ano,Genero,Cantor) VALUES(@Titulo,@Album,@Ano,@Genero,@Cantor)"))
        { //AQUI ESTOU USANDO PARAMETERS @ PODE SER QUALQUER NOME

          //METODOS QUE FORAM CRIANDO NA CLASSE DAO
          CreateParameter(cmd, "@Titulo", m.Titulo, null);
          CreateParameter(cmd, "@Album", m.Album, null);
          CreateParameter(cmd, "@Ano", m.Ano, null);
          CreateParameter(cmd, "@Genero", m.Genero, null);
          CreateParameter(cmd, "@cantor", m.Cantor, null);

          cmd.ExecuteNonQuery();//PARA FAZER A INSERÇÃO
        }
      }
    }

    public void Atualizar(Musica m)
    {

      //COLOQUEI DENTRO DO USING PARA EXECUTAR O DISPOSE AUTOMATICAMENTE DEPOIS DO USO E NÃO TER INSTANCIAS ABERTAS
      using (DbConnection conn = CreateConnection())
      {
        using (DbCommand cmd = CreateCommand(conn, "UPDATE Musica SET Titulo = @Titulo, Album = @Album, Ano = @Ano, Genero = @Genero, Cantor = @Cantor WHERE id = @Id"))
        { //AQUI ESTOU USANDO PARAMETERS @ PODE SER QUALQUER NOME

          //METODOS QUE FORAM CRIANDO NA CLASSE DAO
          CreateParameter(cmd, "@Id", m.Id, null);
          CreateParameter(cmd, "@Titulo", m.Titulo, null);
          CreateParameter(cmd, "@Album", m.Album, null);
          CreateParameter(cmd, "@Ano", m.Ano, null);
          CreateParameter(cmd, "@Genero", m.Genero, null);
          CreateParameter(cmd, "@cantor", m.Cantor, null);

          cmd.ExecuteNonQuery();//PARA FAZER A INSERÇÃO
        }
      }
    }

    public void Apagar(int id)
    {
      using (DbConnection conn = CreateConnection())
      {
        using (DbCommand cmd = CreateCommand(conn, "DELETE from Musica WHERE id = @Id"))
        { //AQUI ESTOU USANDO PARAMETERS @ PODE SER QUALQUER NOME

          //METODOS QUE FORAM CRIANDO NA CLASSE DAO
          CreateParameter(cmd, "@Id", id, null);

          cmd.ExecuteNonQuery();//PARA DELETAR
        }
      }
    }




    public int Count()
    {
      using (DbConnection conn = CreateConnection())
      {
        using (DbCommand cmd = CreateCommand(conn, "SELECT COUNT (*) FROM Musica"))
        {
          int count = (int)cmd.ExecuteScalar();

          return count;
        }
      }
    }

    //CARREGAR DE ACORDO COM O ID
    public Musica Carregar(int id)
    {
      using (DbConnection conn = CreateConnection())
      {
        using (DbCommand cmd = CreateCommand(conn, "SELECT Id, Titulo, Album, Ano, Genero, Cantor FROM Musica WHERE id = @Id")) //AQUI ESTOU USANDO PARAMETERS @ PODE SER QUALQUER NOME)
        {

          CreateParameter(cmd, "@Id", id, null);
          using (DbDataReader dr = cmd.ExecuteReader())
          {

            //SE NÃO EXISTE DADOS RETORNA NULO
            if (!dr.Read())
            {
              return null;
            }

            //se existe dados retorna uma nova musica com os dados trazidos do banco
            return new Musica()
            {
              Id = (int)dr["Id"],
              Titulo = (string)dr["Titulo"],
              Album = (string)dr["Album"],
              Ano = (int)dr["Ano"],
              //convertendo para o tipo do genero
              Genero = (Genero)Enum.Parse(typeof(Genero), (string)dr["Genero"]),
              Cantor = (string)dr["Cantor"]

            };
          }
        }
      }
    }
  }

  //CLASSE MÚSICA
  class Musica
  {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Cantor { get; set; }
    public string Album { get; set; }
    public int? Ano { get; set; } //ACEITA NULLABLE
    public Genero Genero { get; set; }

    public override string ToString()
    {
      return String.Format("ID: {0} \nTitulo: {1}  \nCantor {2}  \nAlbum: {3}  \nAno {4}  \nGenero: {5} ", Id, Titulo, Cantor, Album, Ano, Genero);

      //return String.Format("ID: {0} - Titulo: {1} ", Id, Titulo);
    }
  }
  enum Genero
  {
    Rock,
    Pop,
    Jazz,
    Reggae,
    Blues
  }

}
