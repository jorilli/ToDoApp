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
			ErrorLabel.Text = "Email ist g�ltig.";
		}
		else 
		{
			ErrorLabel.Text = "Email ist nicht g�ltig. Eine Mailadresse muss '@' und '.' enthalten.";
		}
	}
}