namespace ToDoApp;

public partial class Exit : ContentPage
{
	public Exit()
	{
		InitializeComponent();
	}
	private async void Login_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Login());
	}
}