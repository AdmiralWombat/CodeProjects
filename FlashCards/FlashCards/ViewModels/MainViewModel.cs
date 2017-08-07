using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		public BaseViewModel ViewModel { get; set; }

		private Models.FlashCardsModel _flashCardsModel;

		public MainViewModel()
		{
			_flashCardsModel = new Models.FlashCardsModel();

			Navigate<TitleViewModel>(new TitleViewModel(this));
		}

		public List<string> flashCardSets
		{
			get { return _flashCardsModel.flashCardSets; }
			set { _flashCardsModel.flashCardSets = value; }
		}

		public string currentFlashSet
		{
			get { return _flashCardsModel.currentFlashSet; }
			set { _flashCardsModel.currentFlashSet = value; }
		}

		public void Navigate<T>(BaseViewModel viewModel) where T : BaseViewModel
		{
			ViewModel = viewModel as T;
			Console.WriteLine(ViewModel.GetType());
			OnPropertyChanged("ViewModel");
		}
	}
}
