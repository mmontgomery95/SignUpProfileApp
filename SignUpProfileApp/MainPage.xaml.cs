namespace SignUpProfileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SignupBtn_Clicked(object sender, EventArgs e)
        {
            var myData = new Dictionary<string, object>
            {
                { "username", $"{UsernameEntry.Text}" },
                { "email", $"{EmailEntry.Text}" },
                { "password", $"{PasswordEntry.Text}" },
                { "confirmPassword", $"{ConfirmPasswordEntry.Text}" }
            };
            Shell.Current.GoToAsync(nameof(ProfilePage), myData);

        }
    }

}
