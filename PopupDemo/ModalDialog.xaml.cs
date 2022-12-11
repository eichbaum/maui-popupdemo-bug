using CommunityToolkit.Maui.Views;

namespace PopupDemo;

public partial class ModalDialog : ContentPage
{
	public ModalDialog()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		this.ShowPopup(new PopupDialog());
    }
}
