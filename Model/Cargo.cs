using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnaGabriela.Model
{
    class Cargo
    {
        private int id_cargo;
        private String nome_cargo;

        public int ID_Cargo { get => id_cargo; set => id_cargo = value; }
        public string Nome_Cargo { get => nome_cargo; set => nome_cargo = value; }
    }
}
