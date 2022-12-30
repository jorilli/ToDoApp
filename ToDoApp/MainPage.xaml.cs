﻿namespace ToDoApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FestivalEdditing());
    }
    private async void Menu_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OverviewFilter());
    }

}

