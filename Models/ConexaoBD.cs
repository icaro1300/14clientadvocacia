using System.Data.SqlClient;

namespace AdvocaciaCliente.Models
{
    public class ConexaoBD
    {
        private SqlConnection banco;
        public SqlConnection getconexao()
        {
            if (banco == null)
            {
                banco = new SqlConnection(@"Server=,.\SENAI2022; Database=BDJURIDICO; User id =sa; Password= senai.123);");
            }
            return null;
        }

        internal static object getConexao()
        {
            throw new NotImplementedException();
        }
    }
}