using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UventoXF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchPage : ContentPage
	{
        public string[] sourceItems = new[] { "Davide Reale", "Fabio Nicotra", "Alessandro Rossi","Nicola Sottoferro","Testo a casososososo","Test123","Dev123DEV"};

		public ObservableCollection<String> MyItems { get; set; }
		public SearchPage ()
		{
			InitializeComponent ();
			MyItems = new ObservableCollection<String> (sourceItems);
			BindingContext = this;
		}

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
			var SearchTerm = e.NewTextValue;
			if (string.IsNullOrWhiteSpace(SearchTerm)) { 
				SearchTerm	= string.Empty;
			}
			SearchTerm = SearchTerm.ToLowerInvariant();

			var filteredItems = sourceItems.Where(value =>
			value.ToLowerInvariant().Contains(SearchTerm)).ToList();

			if(string.IsNullOrEmpty(SearchTerm))
			{
				filteredItems = sourceItems.ToList();
			}

			foreach(var value in filteredItems)
			{
				if (!filteredItems.Contains(value))
				{
					MyItems.Remove(value);
				}
				else if (!MyItems.Contains(value))
				{
					MyItems.Add(value);
				}
			}
        }
    }
}