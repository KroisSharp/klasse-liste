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
        public KlasseListe() : base()
        {
            this.Add(new klasseinfo()
            {
                FirstName = "Fornavn",
                LastName = "Efternavn",
                Mobil = 12345678,
                Email = "Mail@2.me",
                GitHubNavn = "Super Gitte"
            }
            );
        }
    }
}
