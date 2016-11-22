using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace måske_syg_liste.ViewModel
{
    public class AddElevCommand : ICommand
    {
        private readonly Action execute;


        public event EventHandler CanExecuteChanged;


        public AddElevCommand(Action execute)
        {
            this.execute = execute;
        }


        //bruges til at fortælle må jeg overhoved trykke på denne her knap
        // kan man add ting fx er der skrevet noget i det felter der skal stå noget i
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
