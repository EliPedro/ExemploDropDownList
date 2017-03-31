using System.Collections.Generic;

namespace WebExemploDropDownList.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        public List<Cliente> ListaClientes()
        {
            return new List<Cliente>
            {
                new Cliente {ClienteId = 0, Nome = "Pedro" },
                new Cliente {ClienteId = 1, Nome = "Karol" },
                new Cliente {ClienteId = 2, Nome = "Maria" },
                new Cliente {ClienteId = 3, Nome = "Sandra" },
            };            
        }
    }
}