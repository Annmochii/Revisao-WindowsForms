using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_Forms
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario Tipo { get; set; }

        public Usuario (int id, string nome, string nUsuario, string email, string senha, TipoUsuario tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.NomeUsuario = nUsuario;
            this.Email = email;
            this.Senha = senha;
            this.Tipo = tipo;
        }
    }
}
