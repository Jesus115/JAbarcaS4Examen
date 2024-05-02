namespace JAbarcaInfS4Examen.Vistas;

public partial class VRegistro : ContentPage
{
	public VRegistro()
	{
		InitializeComponent();
	}
    public VRegistro(
                        string usuario,
                        string nombre,
                        string apellido,
                        string edad,
                        string fecha,
                        string pais,
                        string ciudad,
                        string mInicial,
                        string pgMenual,
                        string total

                    )
    {
        InitializeComponent();
        idUsuarioIngreso.Text = usuario;
        txtNombre.Text = nombre;
        txtApelido.Text = apellido;
        txtEdad.Text = edad;
        txtFecha.Text = fecha;
        txtPais.Text = pais;
        txtCiudad.Text = ciudad;
        txtMInicial.Text = mInicial;
        txtMMensual.Text = pgMenual;
        txtMTotal.Text = total;
    }

    void btnCerrarSesion_Clicked(System.Object sender, System.EventArgs e)
    {
        limpiarCampos();
        Navigation.PushAsync(new Vlogin());


    }
    private bool limpiarCampos() {
        idUsuarioIngreso.Text = "";
        txtNombre.Text = "";
        txtApelido.Text = "";
        txtEdad.Text = "";
        txtFecha.Text = "";
        txtPais.Text = "";
        txtCiudad.Text = "";
        txtMInicial.Text = "";
        txtMMensual.Text = "";
        txtMTotal.Text = "";
        return true;
    }


}
