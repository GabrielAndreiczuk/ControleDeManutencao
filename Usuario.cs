using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Setor { get; set; }
    }
    public static class UsuarioSessao
    {
        public static Usuario UsuarioAtual { get; set; }
    }

}
