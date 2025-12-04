namespace M4Food.Views;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    // 1. Log Out Button Logic
    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Log Out", "Are you sure you want to leave?", "Yes", "No");
        if (answer)
        {
            // Go back to the Login Page
            await Navigation.PushAsync(new LoginPage());
        }
    }

    // 2. Edit Button Logic
    private async void OnEditProfileClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Profile", "Edit feature coming soon!", "OK");
    }
}