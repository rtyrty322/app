using System.Xml.Linq;
namespace app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            // выбор языка
            if (LanguagePicker.SelectedIndex != -1)
            {
                string selectedLanguage = LanguagePicker.SelectedItem.ToString();
                LessonStatus.Text = $"Вы выбрали: {selectedLanguage}";
                LessonStatus.IsVisible = true;
            }
        }
        private void OnStartLessonClicked(object sender, EventArgs e)
        {
            if (LanguagePicker.SelectedIndex != -1)
            {
                // код, который запускает урок
                DisplayAlert("Урок начался", $"Вы начали урок по {LanguagePicker.SelectedItem.ToString()}.", "ОК");
                Navigation.PushAsync(new Lession1());
            }
            else
            {
                DisplayAlert("Ошибка", "Пожалуйста, выберите язык для начала урока.", "ОК");
            }
        }
    }
}