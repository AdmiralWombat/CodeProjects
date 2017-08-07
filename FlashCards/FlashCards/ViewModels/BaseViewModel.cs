using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.ViewModels
{
	public class BaseViewModel : ObservableObject
	{
		private MainViewModel _mainVM;

		public BaseViewModel(MainViewModel mainVM)
		{
			_mainVM = mainVM;
		}

		protected void Navigate<T>() where T : BaseViewModel
		{
			T newVM = (T)Activator.CreateInstance(typeof(T), _mainVM);
			_mainVM.Navigate<T>(newVM);
		}
	}
}
