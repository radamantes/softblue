using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
  //PARA QUE NÃO POSSA SER ESTANCIADO
  public abstract class Dao
  {
    static DbProviderFactory providerFactory; //FONTE DE DADOS DO BANCO DE DADOS
    static string connString; //STRING DE CONEXÃO
    static bool initialized; //PARA SABER SE JÁ FOI INICIALIZADO


    //MÉTODO QUE INICIALIZA A CONEXÃO
    //RECEBE UM PROVIDER NAME E UMA STRING DE CONEXÃO
    //SERVE PARA INSTANCIAR UM PROVIDER
    public static void Init(string providerName, string pstringConn)
    {
      providerFactory = DbProviderFactories.GetFactory(providerName);
      connString = pstringConn;
      initialized = true;
    }


    //INICIAR O DAO COM DADOS PADRÕES CASO O USUÁRIO NÃO QUEIRA ESPECIFICAR
    public static void Init()
    {
      //ESSE CHAMA O MÉTODO ACIMA (init)E PASSA OS VALORES PADRÕES OU VOCÊ PODE CHAMAR O MÉTODO ACIMA E PASSAR SEUS PRÓPRIOS VALORES
      Init(ConfigurationManager.AppSettings["dbProvider"], ConfigurationManager.ConnectionStrings["dbConnString"].ConnectionString);
    }

    //MÉOTODO PARA RETORNAR UMA CONEXÃO ABERTA
    //SERVE PARA NÃO FICAR TENDO QUE ABRIR CONEXÃO TODA HORA E REPETIR CÓDIGO
    //Retorna uma DbConnection
    protected DbConnection CreateConnection()
    {

      //SE NÃO TIVER UMA CONEXÃO INICIALIZADA ELE IRÁ INICIALIZAR A CONEXÃO PADRÃO
      if (!initialized)
      {
        Init();
      }

      DbConnection conn = providerFactory.CreateConnection();
      conn.ConnectionString = connString;
      conn.Open();
      return conn;
    }
    //MÉOTOD PARA CRIAR UMA COMANDO NO BANCO DE DADOS DE SELECT INSERT WHATEVER
    //RETORNA UM Dbcommand
    protected DbCommand CreateCommand(DbConnection conn, string text)
    {
      DbCommand cmd = providerFactory.CreateCommand();
      cmd.Connection = conn; //ARMAZENO A CONEXÃO QUE QUERO QUE SEJA EXECUTADA O COMANDO
      cmd.CommandText = text;
      return cmd;
    }

    //MÉTODO QUE RETORNA UMA PARÂMETRO
    protected DbParameter CreateParameter(DbCommand cmd, string name, object value, DbType? type) //PARA QUE POSSA DEFINITIR VALOR COMO NULL COLOQUEI O EXCLAMÇAÕ
    {
      DbParameter param = providerFactory.CreateParameter();
      param.ParameterName = name;
      param.Value = value;

      //SE O TYPE TEM VALOR OU SEJA QUE NÃO É NULLO
      if (type.HasValue)
      {
        param.DbType = type.Value;
      }
      cmd.Parameters.Add(param);  //DBCOMAND ADICIONAR O PARÂMETRO

      return param; //RETORN O PARÂMETRO
    }
  }
}
