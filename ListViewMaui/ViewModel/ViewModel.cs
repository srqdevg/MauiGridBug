using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.Maui.ListView;

namespace ListViewMaui
{
	public class BookInfoRepository : INotifyPropertyChanged
	{
		public object select;
		public Command<object> ListViewSelectionChangedCommand { get; set; }

		private bool isEnabled;

		public bool IsEnabled
		{
			get => isEnabled;
			set
			{
				isEnabled = value;
				OnPropertyChanged(nameof(IsEnabled));
			}
		}


		private void SelectionChangedCommandMethod(object obj)
		{
			var listView = obj as SfListView;
		}


		#region Properties
		public ObservableCollection<BookInfo> BookInfo { get; set; }

		public ObservableCollection<object> Select
		{
			get => (ObservableCollection<object>) select;
			set
			{
				select = value;
				OnPropertyChanged("Select");
			}
		}
		#endregion

		#region Constructor
		public BookInfoRepository()
		{
			GenerateBookInfo();
			ListViewSelectionChangedCommand = new Command<object>(SelectionChangedCommandMethod);
			Select = new ObservableCollection<object>();
			Select.Add(BookInfo[0]);
		}
		#endregion

		#region Properties
		internal void GenerateBookInfo()
		{
			BookInfo = new ObservableCollection<BookInfo>();
			//Random r = new Random();
			//for (int i = 0; i < 30; i++)
			//{
			//    var bookinfo = new BookInfo();
			//    bookinfo.Rate = r.Next(7201, 7993).ToString();
			//    bookinfo.BookName = "NEW Book";
			//    bookinfo.BookDescription = "NEW Desc";
			//    bookInfo.Add(bookinfo);
			//}
			BookInfo.Add(new BookInfo
			{
				BookName = "Object-Oriented Programming in C# ",
				BookDescription = "Object-oriented programming is the de facto programming paradigm", Rate = "4335"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions", Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Machine Learning Using C#",
				BookDescription = "You’ll learn several different approaches to applying machine learning", Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Visual Studio Code",
				BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming", Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Android Programming", BookDescription = "It is provides a useful overview of the Android application lifecycle",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Xamarin.Forms", BookDescription = "Its creates mappings from its C# classes and controls directly",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
				{BookName = "Agile Software Development", BookDescription = "Learning new development processes can be difficult"});
			BookInfo.Add(new BookInfo
				{BookName = "Assembly Language", BookDescription = "Assembly language is as close to writing machine code"});
			BookInfo.Add(new BookInfo
			{
				BookName = "Cryptography in .NET",
				BookDescription = "Cryptography is used throughout software to protect all kinds of information"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Entity Framework Code First",
				BookDescription = "Follow author Ricardo Peres as he introduces the newest development mode"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "Localization for .NET",
				BookDescription = "Learn to write applications that support different languages and cultures"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "1Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "1Xamarin.Forms", BookDescription = "Its creates mappings from its C# classes and controls directly",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "1Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development",
				Rate = "4300"
			});
			BookInfo.Add(new BookInfo
				{BookName = "1Agile Software Development", BookDescription = "Learning new development processes can be difficult"});
			BookInfo.Add(new BookInfo
				{BookName = "1Assembly Language", BookDescription = "Assembly language is as close to writing machine code"});
			BookInfo.Add(new BookInfo
			{
				BookName = "1Cryptography in .NET",
				BookDescription = "Cryptography is used throughout software to protect all kinds of information"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "1Entity Framework Code First",
				BookDescription = "Follow author Ricardo Peres as he introduces the newest development mode"
			});
			BookInfo.Add(new BookInfo
			{
				BookName = "1Localization for .NET",
				BookDescription = "Learn to write applications that support different languages and cultures"
			});
		}
		#endregion

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string name)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}
}