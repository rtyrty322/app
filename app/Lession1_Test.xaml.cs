using System;
using Microsoft.Maui.Controls;
namespace app;

public partial class Lession1_Test : ContentPage
{
    public Lession1_Test()
    {
        InitializeComponent();
    }

    private void OnCheckAnswersClicked(object sender, EventArgs e)
    {
        int score = 0;

        if (GetSelectedValue("question1") == "1") score++;
        if (GetSelectedValue("question2") == "1") score++;
        if (GetSelectedValue("question3") == "1") score++;

        ResultLabel.Text = $"Ваш результат: {score}/3";
    }

    private string GetSelectedValue(string groupName)
    {
        foreach (var child in (this.Content as StackLayout).Children)
        {
            if (child is RadioButton radioButton && radioButton.GroupName == groupName && radioButton.IsChecked)
            {
                return radioButton.Value.ToString();
            }
        }
        return "0";
    }
    private async void ClickedGetBack(object sender, EventArgs e)
    {
        await DisplayAlert("Подтверждение", "Вы уверены, что хотите выйти?", "Да");

        await Navigation.PushAsync(new MainPage());
    }
}