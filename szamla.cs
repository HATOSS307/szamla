using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlak
{
    internal class szamla
    {
        int id;
        string tulajdonosNeve;
        decimal egyenleg;
        MySqlDateTime nyitasdatum;

        public int Id { get => id; set => id = value; }
        public string TulajdonosNeve { get => tulajdonosNeve; set => tulajdonosNeve = value; }
        public decimal Egyenleg { get => egyenleg; set => egyenleg = value; }
        public MySqlDateTime Nyitasdatum { get => nyitasdatum; set => nyitasdatum = value; }

        public szamla(int id, string tulajdonosNeve, decimal egyenleg, MySqlDateTime nyitasdatum)
        {
            Id = id;
            TulajdonosNeve = tulajdonosNeve;
            Egyenleg = egyenleg;
            Nyitasdatum = nyitasdatum;
        }
        public override string ToString()
        {
            return tulajdonosNeve + " (" + egyenleg + ") " + nyitasdatum;
        }
    }
}
