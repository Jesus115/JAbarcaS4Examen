namespace JAbarcaInfS4Examen.Vistas;

public partial class Vlogin : ContentPage
{
    List<string[]> usuariosContrasenas = new List<string[]>
    {
        new string[] {"estudiante2024", "uisrael2024"},
        new string[] {"examen1", "parcial1"},
        new string[] {"Jesus", "2024"}

    };
    public Vlogin()
	{
		InitializeComponent();
	}
    public Vlogin(string usuario, string clave)
    {
        InitializeComponent();
        usuariosContrasenas.Add(new string[] { usuario, clave });

    }

    void btnRegistrar_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new VRegister());
    }

    void btnIngreso_Clicked(System.Object sender, System.EventArgs e)
    {
        string usuario = idUsuario.Text;
        string clave = idClave.Text;

        // Variable para indicar si las credenciales son válidas
        bool credencialesValidas = validarConeccion(usuario, clave);
        


        if (credencialesValidas)
        {
            Navigation.PushAsync(new VIndex(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario / Contraseña Incorrectos", "Cerrar");
        }
    }

    void btnAcercaDe_Clicked(System.Object sender, System.EventArgs e)
    {

        Navigation.PushAsync(new VAcerca());


    }
    private bool validarConeccion(string usuario, string clave) {

        foreach (var usuarioContraseña in usuariosContrasenas)
        {
            string usuarioVal = usuarioContraseña[0];
            string contrasenaVal = usuarioContraseña[1];

            if (usuario == usuarioVal && clave == contrasenaVal)
            {
                return true;
            }
            
        }
        return false;
    }
}
