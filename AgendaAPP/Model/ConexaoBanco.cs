
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAPP.Model
{
    internal class ConexaoBanco
    {
        public static string Conectar()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\hugo.asantana1\source\repos\AgendaAPP\AgendaAPP\BancoDados\Database1.mdf; Integrated Security = True";
        }
    }
}
