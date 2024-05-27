using PaginaPrincipalBlog.Models;

namespace PaginaPrincipalBlog.Resources;

public partial class Contenido : ContentPage
{
	public Contenido()
	{
		InitializeComponent();
	}
    private async void OnImageTapped(object sender, EventArgs e)
    {
        var tappedImage = sender as Image;
        var selectedImage = tappedImage?.BindingContext as Facultad; // Aseg�rate de que Facultad es el tipo de tu modelo

        if (selectedImage != null)
        {
            // Navegar a una nueva p�gina y pasar la imagen seleccionada como par�metro
            await Navigation.PushAsync(new Contenido());
        }
    }
}