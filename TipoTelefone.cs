using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoTeste
{
    public class TipoTelefone
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public TipoTelefone (int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
