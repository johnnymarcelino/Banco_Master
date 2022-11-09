using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace API_Banco_Master.Models
{
    public class Cliente : Transferencia
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string ChavePix { get; set; }
        public List<Cliente> registrarCliente { get; set; } = new List<Cliente>();

        #region Constructors
        public Cliente()
        {
        }

        public Cliente(string nome, string documento, string chavePix)
        {
            Nome = nome;
            Documento = documento;
            ChavePix = chavePix;
        }
        #endregion


        #region Methods
        public string PegarCliente(string verificarCliente)
        {
            if (registrarCliente == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                Nome = verificarCliente;
                return ChavePix;
            }
        }

        internal Cliente PegarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> RegistrarCliente(Cliente cliente)
        {
            registrarCliente.Add(cliente);
            return registrarCliente;
        }
        #endregion
    }
}
