using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp
{
    public static class ViewModelLocator
    {
        public static BurgerViewModel _burgerViewModel= new BurgerViewModel();
        public static BurgerViewModel BurgerViewModel
        {
            get
            {
                return _burgerViewModel;
            }
        }
    }
}
