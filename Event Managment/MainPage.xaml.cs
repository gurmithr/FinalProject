namespace Event_Managment
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
           EventCreation Page = new EventCreation();
           await Navigation.PushAsync(new EventCreation());

        }
    }

}
