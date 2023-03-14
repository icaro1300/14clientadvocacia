using AdvocaciaCliente.Models;
using AdvocaciaCliente;
using System.Data.SqlClient;
using Dapper;


public class ClienteDAD
{
    private SqlConnection conexao;
    private object _conexao;

    public ClienteDAD()
    {
        _conexao = AdvocaciaCliente.ConexaoBD.getConexao();
    }
    public List<Cliente> getTodosClientes()
    {
        string sql = "select * from Cliente";
        var dados = (List<Cliente>)_conexao.Query<Cliente>(sql);
        return dados;
    }
}
