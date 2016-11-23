using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace måske_syg_liste.Model
{
    public class KlasseListe : ObservableCollection<klasseinfo>
    {
        //vi laver 2 nye instanser og tilføjer dem til vorers liste.
        //bemærk her bruger vi vores props fra klasseinfo
        public KlasseListe() : base()
        {
            this.Add(new klasseinfo()
            {
                FirstName = "Fornavn",
                LastName = "Efternavn",
                Mobil = "12345678",
                Email = "Mail@2.me",
                GitHubNavn = "Super Gitte"
            }
            );
            this.Add(new klasseinfo()
            {
                FirstName = "Fornavn1",
                LastName = "Efternavn1",
                Mobil = "12345679",
                Email = "Mail@22.me",
                GitHubNavn = "Super Gitte1"
            }
            );
        }
    }
}
