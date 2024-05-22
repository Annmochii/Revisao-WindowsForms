using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoTeste
{
    class CampoVazioException : Exception
    {
        public int ContatoId { get; set; }
        public CampoVazioException(int id, String mensagem) : base(mensagem)
        {
            this.ContatoId = id;
        }
    }
}
