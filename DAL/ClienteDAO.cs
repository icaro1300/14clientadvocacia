using AdvocaciaCliente.Models;
using AdvocaciaCliente;
using System.Data.SqlClient;


public class ClienteDAO
{
    private object _conexao;

    public ClienteDAO(object conexao)
    {
        _conexao = AdvocaciaCliente.ConexaoBD.getConexao();
        _conexao = conexao;
    }
    public List<Cliente> getTodosClientes()
    {
        string sql = "select * from Cliente";
        List<Cliente> dados = (List<Cliente>)_conexao.Query<Cliente>(sql);
        return dados;
    }
    public bool inserirCliente(Cliente cliente)
    {
        try
        {
            string sql = "INSERT INTO [dbo].[Cliente]  ([CLINOME],[CLIENDERECO] ,[CLINUMEROENDERECO], " +
                "[CIDADE]  ,[ESTADOSIGLA]     ,[CLICPF]  ,[CLICNPJ]) " +
                "VALUES  (@CLINOME, @CLIENDERECO,  @CLINUMEROENDERECO , @CIDADE, @ESTADOSIGLA, @CLICPF, @CLICNPJ) ";
            int qtdInserida = _conexao.Execute(sql, cliente);
            if (qtdInserida > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        catch (Exception)
        {

            return false;
        }
    }
}