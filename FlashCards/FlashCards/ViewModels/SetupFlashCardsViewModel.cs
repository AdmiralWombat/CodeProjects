using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.ViewModels
{
	class SetupFlashCardsViewModel : BaseViewModel
	{
		private MainViewModel _main;

		public SetupFlashCardsViewModel(MainViewModel main) : base(main)
		{
			_main = main;
		}
	}
}
