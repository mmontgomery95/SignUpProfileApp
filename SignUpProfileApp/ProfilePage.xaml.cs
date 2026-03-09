namespace SignUpProfileApp;
[QueryProperty(nameof(Username), "username")]
[QueryProperty(nameof(Email), "email")]
[QueryProperty(nameof(Password), "password")]
public partial class ProfilePage : ContentPage
{
	public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ProfilePage()
	{
		InitializeComponent();
            // When using Shell navigation, NavigationPage attached properties
            // may not hide the Shell back button. Set a BackButtonBehavior
            // to explicitly hide and disable the back button for this page.
            Shell.SetBackButtonBehavior(this, new BackButtonBehavior
            {
                IsEnabled = false,
                IsVisible = false
            });
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LblUsername.Text = $"Username: {Username}";
        LblEmail.Text = $"Email: {Email}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}