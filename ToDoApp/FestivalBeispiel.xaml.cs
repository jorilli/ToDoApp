using System.Runtime.CompilerServices;

namespace ToDoApp;

public partial class FestivalBeispiel : ContentPage
{
	public FestivalBeispiel()
	{
		InitializeComponent();
	}
	protected bool SetProperty<T>(ref T backingStore, T value,
						  [CallerMemberName] string propertyName = "",
						  Action onChanged = null)
	{
		if (EqualityComparer<T>.Default.Equals(backingStore, value))
			return false;

		backingStore = value;
		onChanged?.Invoke();
		OnPropertyChanged(propertyName);
		return true;
	}

	private List<string> locations = new List<string>
{
	"Chur",
	"Bern",
	"Zurich",
	"Olten",
	"Tessin"
};
	public List<string> Locations
	{
		get { return locations; }
		set { SetProperty(ref locations, value); }
	}
}