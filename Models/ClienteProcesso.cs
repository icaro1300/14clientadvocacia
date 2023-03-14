using Microsoft.AspNetCore.Http.HttpResults;

namespace AdvocaciaCliente.Models
{
    public class ClienteProcesso
    {
        public int ClieID { get; set; }
        public double PROID { get; set; } //ex: homicido52829
        public string TIPID { get; set; }
        public double DATAVINCULO  { get; set; } //ex: 01 de janeiro OU 01/01/0000
       
    }
}
