using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace volunteerAppXam
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	    protected override void OnAppearing()
	    {
	        DisplayAlert("Hello", "this is MainPage", "ok");
	        base.OnAppearing();
	    }
	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Page1());
	    }
    }
}
