using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_Forms
{
    public class CampoVazioException : Exception
    {
        int UsuarioID { get; set; }
        public CampoVazioException(int usuarioID, String mensagem) : base(mensagem)
        {
            this.UsuarioID = usuarioID;
        }
    }
}
