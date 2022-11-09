using API_Banco_Master.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Banco_Master.Controllers
{
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly Cliente _verificarCliente;
        private Transferencia _transferirPix;

        public ClienteController(Cliente cliente)
        {
            _verificarCliente = cliente;
        }

        [HttpGet]
        [Route("ConsultarCliente")]
        public Cliente ConsultarCliente(string Nome, string Documento, string ChavePix)
        {
            return _verificarCliente.PegarCliente(new Cliente(Nome, Documento, ChavePix));
        }

        [HttpPost]
        [Route("CadastrarCliente")]
        public Cliente CadastrarCliente(Cliente registrarCliente)
        {
            registrarCliente.RegistrarCliente(registrarCliente);
            return registrarCliente;
        }

        [HttpPost]
        [Route("TransferirPix")]
        public async Task<Transferencia> TransferirPix(Transferencia transferirPix)
        {
            await transferirPix.Transferir(transferirPix);
            _transferirPix = transferirPix;
            return _transferirPix;
        }
    }
}
