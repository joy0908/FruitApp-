namespace MauiApp2;

public partial class NewPage2 : ContentPage
{
	public NewPage2(String uName)
	{
		InitializeComponent();
		lblUserName.Text = uName;
	}

    /*private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Navigation.PopModalAsync();
    }*/
}