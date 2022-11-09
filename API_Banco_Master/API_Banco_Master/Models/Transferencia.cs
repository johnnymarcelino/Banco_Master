using System.Threading.Tasks;

namespace API_Banco_Master.Models
{
    public class Transferencia
    {
        public string ChavePixOrigem { get; set; }
        public decimal Valor { get; set; }
        public string ChavePixDestino { get; set; }

        #region Constructors
        public Transferencia()
        {
        }

        public Transferencia(string chavePixOrigem, decimal valor, string chavePixDestino)
        {
            ChavePixOrigem = chavePixOrigem;
            Valor = valor;
            ChavePixDestino = chavePixDestino;
        }
        #endregion


        #region Methods
        public async Task<bool> Transferir(Transferencia transferencia)
        {
            if (transferencia.ChavePixOrigem != ChavePixOrigem)
            {
                return false;
                throw new("Chave Pix Origem inexistente");
            }

            if (transferencia.ChavePixDestino != ChavePixDestino)
            {
                return false;
                throw new("Chave Pix Origem inexistente");
            }

            if (transferencia.Valor <= 0)
            {
                return false;
                throw new("Chave Pix Origem inexistente");
            }
            else
            {
                await transferencia.Transferir(transferencia);
                return true;
            }
        }
        #endregion
    }
}
