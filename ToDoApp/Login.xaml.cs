namespace ToDoApp;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
	private async void Login_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}