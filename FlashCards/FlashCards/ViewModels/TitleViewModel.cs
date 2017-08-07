using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.IO;

namespace FlashCards.ViewModels
{
	public class TitleViewModel : BaseViewModel
	{		
		private MainViewModel _main;

		public TitleViewModel(MainViewModel main) : base(main)
		{			
			_main = main;			
		}
		
		public ICommand StartFlashCards
		{
			get { return new RelayCommand(BeginStartFlashCards); }
		}
		public ICommand ConfigFlashCards
		{
			get { return new RelayCommand(BeginConfigFlashCards); }
		}
		public ICommand LoadNewFlashCards
		{
			get { return new RelayCommand(BeginLoadNewFlashCards); }
		}
		

		public string FlashSet
		{
			get 
			{
				return _main.currentFlashSet;
			}
			set
			{
				_main.currentFlashSet = value;
				OnPropertyChanged("FlashSet");
			}
		}

		public void BeginStartFlashCards(object param)
		{
			Navigate<FlashViewModel>();
		}
		public void BeginConfigFlashCards(object param)
		{
			Navigate<SetupLoadViewModel>();
		}
		public void BeginLoadNewFlashCards(object param)
		{
			Navigate<LoadNewViewModel>();
		}		
	}
}
