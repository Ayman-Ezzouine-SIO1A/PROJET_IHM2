using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.ComponentModel;
namespace PROJET_IHM2
{
    class C_BASE
    {
        public BindingList<C_MONSTRE> les_monstres = new BindingList<C_MONSTRE>();
       
        public void Sauvegarde_toi()
        {
            string donnees = JsonSerializer.Serialize<BindingList<C_MONSTRE>>(les_monstres);
            File.WriteAllText("monstres.json", donnees);
        }

        public void Charge_toi()
        {
            string donnees = File.ReadAllText("monstres.json");
            les_monstres = JsonSerializer.Deserialize<BindingList<C_MONSTRE>>(donnees);
        }
    }
}