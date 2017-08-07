using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlashCards.Views
{
	/// <summary>
	/// Interaction logic for LoadNewView.xaml
	/// </summary>
	public partial class LoadNewView : UserControl
	{
		public LoadNewView()
		{
			InitializeComponent();
			//DataContext = new ViewModels.TitleViewModel(null);
		}
	}
}
