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
                FirstName = "fornavn",
                LastName = "efternavn",
                Mobil = 12345678,
                Email = "mail@2.me",
                GitHubNavn = "super Gitte"
            }
            );
        }
    }
}
