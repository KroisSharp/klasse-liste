using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace måske_syg_liste.ViewModel
{
    class SletElevCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action executeSlet;

        public SletElevCommand(Action executeSlet)
        {
            this.executeSlet = executeSlet;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeSlet();
        }
    }
}
