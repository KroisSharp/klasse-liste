using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace måske_syg_liste.ViewModel
{
    class KlasseViewmodel
    {
        public Model.KlasseListe PListe { get; set; }



        private Model.klasseinfo SelectedElev;

        public Model.klasseinfo selectedElev
        {
            get { return SelectedElev; }
            set { SelectedElev = value; }
        }


        public KlasseViewmodel()
        {
            PListe = new Model.KlasseListe();
        }

    }
}
