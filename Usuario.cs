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
        public string Senha { get; set; }
        public string Setor { get; set; }
        public string Cargo { get; set; }
        public string Contato { get; set; }
    }
    public static class UsuarioSessao
    {
        public static Usuario UsuarioAtual { get; set; }

        public static int Acesso()
        {
            int acesso = 0;

            if (UsuarioAtual.Cargo == "Diretor de Operações Industriais" ||
                UsuarioAtual.Cargo == "Gerente Industrial" ||
                UsuarioAtual.Cargo == "Manutentor Industrial")
            {
                acesso = 3;
            }
            else if (UsuarioAtual.Cargo == "Analista de Automação Industrial" ||
                     UsuarioAtual.Cargo == "Manutentor Industrial")
            {
                acesso = 2;
            }

            return acesso;            
        }
    }
}
