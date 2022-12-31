namespace ToDoApp;

public partial class FaqBereich : ContentPage
{
	public FaqBereich()
	{
		InitializeComponent();
	}
	private async void Email_Uberprufung(object sender, EventArgs e)
	{
		var email = EmailEingabe.Text;

		if(email.Contains("@") & email.Contains("."))
		{
			ErrorLabel.Text = "Email ist gültig.";
		}
		else 
		{
			ErrorLabel.Text = "Email ist nicht gültig. Eine Mailadresse muss '@' und '.' enthalten.";
		}
	}
}