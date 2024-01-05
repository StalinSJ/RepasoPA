namespace RepasoPA.Vistas;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;

        Navigation.PushAsync(new Vistas.Vista2(usuario));
    }
}