namespace RepasoPA.Vistas;

public partial class Vista2 : ContentPage
{
	public Vista2(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Bienvenido " + usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

    }
}