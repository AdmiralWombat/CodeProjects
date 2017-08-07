using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlashCards.Models
{
	public class FlashCardsModel
	{
		private List<string> _flashCardSets = new List<string>();
		private string _currentFlashSet = "";
		public FlashCardsModel()
		{
			LoadKnownFlashCardSets();
			_currentFlashSet = _flashCardSets[0];
		}

		public List<string> flashCardSets
		{
			get { return _flashCardSets; }
			set { }
		}

		public string currentFlashSet
		{
			get { return _currentFlashSet; }
			set { _currentFlashSet = value; }
		}

		private void LoadKnownFlashCardSets()
		{
			DirectoryInfo dir = new DirectoryInfo(@".\");
			FileInfo[] files = dir.GetFiles("*.csv*");
			foreach (FileInfo file in files)
			{
				_flashCardSets.Add(file.Name);				
			}
		}
	}
}
