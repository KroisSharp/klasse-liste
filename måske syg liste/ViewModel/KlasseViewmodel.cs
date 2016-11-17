using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace måske_syg_liste.ViewModel
{
    class KlasseViewmodel : INotifyPropertyChanged
    {
        public Model.KlasseListe PListe { get; set; }



        private Model.klasseinfo SelectedElev;

        public Model.klasseinfo selectedElev
        {
            get { return SelectedElev; }
            set {
                SelectedElev = value;
                OnPropertyChanged(nameof(selectedElev));
            }
        }

        public Model.klasseinfo NewElev { get; set; }



        public KlasseViewmodel()
        {
            PListe = new Model.KlasseListe();
            AddElevCommand = new RelayCommand();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void AddNewElev()
        {
            PListe.Add(NewElev);
        }

        public RelayCommand AddElevCommand { get; set; }

    }
}
