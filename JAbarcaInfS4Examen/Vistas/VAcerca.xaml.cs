namespace JAbarcaInfS4Examen.Vistas;

public partial class VAcerca : ContentPage
{
	public VAcerca()
	{
		InitializeComponent();
		cursoUsuarioConectado.Text = "7 mo";
		aniousuarioConecctado.Text = "2024";
        carreraUsuarioConectado.Text = "Informatica";
        nombreApellidoUsuario.Text = "Jesus Abarca Garzon";

		DisplayAlert("Jesus Abarca Garzon ", "7 mo "+ " Informatica "+ " 2024 ","Cerrar");
    }
}
