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
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LblUsername.Text = $"Username: {Username}";
        LblEmail.Text = $"Email: {Email}";
        LblPassword.Text = $"Password: {Password}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}