namespace ToDoApp;

public partial class HomeMenu : ContentPage
{
	public HomeMenu()
	{
		InitializeComponent();
	}

    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void Profil_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Account());
    }

    private async void Exit_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Exit());
    }
}