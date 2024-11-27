using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeuProjeto
{
    public class Usuario
    {
        public int ID_Cliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Cartao_de_credito { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
    }
    public static class UsuarioSessao
    {
        public static Usuario UsuarioAtual { get; set; }
    }

}