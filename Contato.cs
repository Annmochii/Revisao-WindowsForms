using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoTeste
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public TipoTelefone Tipo { get; set; }

        public Contato (int id, string nome, string sobrenome, string telefone, TipoTelefone tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            this.Tipo = tipo;
        }
    }
}
