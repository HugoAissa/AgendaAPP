using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAPP.Model
{
    internal class Agenda
    {
        private static int id;
        private static string categoriaAgenda;
        private static string numeroAgenda;
        private static string ruaAgenda;
        private static string nomeAgenda;

        public static int Id { get => id; set => id = value; }
        public static string CategoriaAgenda { get => categoriaAgenda; set => categoriaAgenda = value; }
        public static string NumeroAgenda { get => numeroAgenda; set => numeroAgenda = value; }
        public static string RuaAgenda { get => ruaAgenda; set => ruaAgenda = value; }
        public static string NomeAgenda { get => nomeAgenda; set => nomeAgenda = value; }
    }
}
