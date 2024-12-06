using System;
using Microsoft.Maui.Controls;

namespace app;


    public partial class Lession1 : ContentPage
{
    public Lession1()
    {
        InitializeComponent();
    }

    private async void OnStartLessonButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Продолжить", "Вы начали свой первый урок по английскому!", "OK");
        Navigation.PushAsync(new Lession1_Test());
    }
}


