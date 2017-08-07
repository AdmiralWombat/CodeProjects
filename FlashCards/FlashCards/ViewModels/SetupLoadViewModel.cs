using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FlashCards.ViewModels
{
	class SetupLoadViewModel : BaseViewModel
	{
		private MainViewModel _main;

		public SetupLoadViewModel(MainViewModel main) : base(main)
		{
			_main = main;
		}

		public ICommand LoadNew
		{
			get { return new RelayCommand(BeginLoadNew); }
		}	
		public ObservableCollection<string> Items 
		{ 
			get { return new ObservableCollection<string>(_main.flashCardSets); }
			set 
			{
				_main.flashCardSets = new List<string>(value);
			}
		}
		public string ItemSelected
		{
			get { return _main.currentFlashSet; }
			set
			{
				_main.currentFlashSet = value; 
				 OnPropertyChanged("ItemSelected");
			}
		}		
		public void BeginLoadNew(object param)
		{
			Navigate<SetupFlashCardsViewModel>();
		}
	}
}
