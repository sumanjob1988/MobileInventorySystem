using MobileInventorySystem.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobileInventorySystem
{
    class MainWindowViewModel: ViewModelBase
    {
        private ICommand addMobileCommand;
        public ICommand AddMobileCommand
        {
            get
            {
                if (addMobileCommand == null)
                {
                    addMobileCommand = new RelayCommand(
                        param => this.AddMobile(),
                        param => this.CanAddMobile
                        );
                }
                return addMobileCommand;
            }
        }

        private void AddMobile()
        {
            try
            {
                //Add Mobile User Control Page
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private Boolean CanAddMobile
        {
            get { return true; }
        }
    }
}
