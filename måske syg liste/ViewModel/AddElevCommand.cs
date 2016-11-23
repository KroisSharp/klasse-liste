using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace måske_syg_liste.ViewModel
{
    //arver fra Icommand fordi den indeholder 2 metoder vi skal bruge
    //event EventHandler CanExecuteChanged, 
    //bool CanExecute(object parameter),
    //void Execute(object parameter);
    public class AddElevCommand : ICommand
    {
        private readonly Action execute;


        public event EventHandler CanExecuteChanged;

        //ctor
        public AddElevCommand(Action execute)
        {
            this.execute = execute;
        }


        //bruges til at fortælle må jeg overhoved trykke på denne her knap
        // fx man skal udfylde navn og efter navn for at kunne trykke
        public bool CanExecute(object parameter)
        {
            return true;
        }


        public void Execute(object parameter)
        {
            execute();
        }
    }
}
