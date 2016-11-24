using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Windows.Storage;

namespace måske_syg_liste.ViewModel
{
    class KlasseViewmodel : INotifyPropertyChanged
    {
        //props
        //vi skriver "model" foran for at fortælle at den skal kigge i vores "Model" mappe man kan bruge using
        public Model.KlasseListe PListe { get; set; }

        public Model.klasseinfo NewElev { get; set; }

        public AddElevCommand AddKlasseCommand { get; set; }

        public SletElevCommand SletKlasseCommand { get; set; }

        public RelayCommand AddElevCommand { get; set; }

        public RelayCommand SaveCommand { get; set; }

        StorageFolder localfolder = null;

        private readonly string filNavn = "JsonText.json";

        public RelayCommand HentDataCommand { get; set; }


        #region Select elev prop & instance field

        private Model.klasseinfo SelectedElev;
        //WriteLine(nameof(person.Address.ZipCode)); // prints "ZipCode”
        // nameof kan altså gå ind på vores Plist fx og finde navn.
        //bliver brugt her med SletElev metode
        public Model.klasseinfo selectedElev
        {
            get { return SelectedElev; }
            set {
                SelectedElev = value;
                OnPropertyChanged(nameof(selectedElev));
            }
        }
        #endregion


        #region vores PropertyChangedEventHandler 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


        //metode til at tilføje ny elev ind i vores liste væriderne får den fra de tekstbox som vi har lavet data binding til.
        public void AddNewElev()
        {
            PListe.Add(NewElev);
        }

        
        //denne metode skulle vælge den valgte elev og slette den fra listen. dog sletter den bare den sidste på listen man kan altså ikke vælge
        //med mindre man vælger en af dem man lavede i ctor -- fejl i propertychanged?
        public void SletElev()
        {
            PListe.Remove(SelectedElev);
        }

/// <summary>
/// ctor laver alle nye instancer. så de kan bruges i vores viewmodel
/// MERE info
/// </summary>
        public KlasseViewmodel()
        {
            PListe = new Model.KlasseListe();
            AddKlasseCommand = new AddElevCommand(AddNewElev);
            NewElev = new Model.klasseinfo();
            SletKlasseCommand = new SletElevCommand(SletElev);
            localfolder = ApplicationData.Current.LocalFolder;
            SaveCommand = new RelayCommand(GemDataTilDiskAsync);
            HentDataCommand = new RelayCommand(HentDataFraDisk);
        }
        //her gemmer vi til disk via async så vi kan lave videre imens 
        public async void GemDataTilDiskAsync()
        {
            string jsonText = this.PListe.GetJson();
            StorageFile file = await localfolder.CreateFileAsync(filNavn, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);
        }
        public async void HentDataFraDisk()
        {
            //vi vil gerne clear liste så vi ikke henter igen
            this.PListe.Clear();

            StorageFile file = await localfolder.GetFileAsync(filNavn);
            string jsonText = await FileIO.ReadTextAsync(file);
            PListe.hentjson(jsonText);

        }

    }
}
