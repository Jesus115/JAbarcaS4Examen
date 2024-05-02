namespace JAbarcaInfS4Examen.Vistas;

public partial class VIndex : ContentPage
{
	public VIndex()
	{
		InitializeComponent();
	}
    public VIndex(string usuario)
    {
        InitializeComponent();
        idUsuarioIngreso.Text = usuario;
        DisplayAlert("Bienvenido", "Estimado " + usuario + " Ha Ingresado Correcctamente", "Cerrar");
    }

    void calPagoMensual_Clicked(System.Object sender, System.EventArgs e)
    {
        float valInicial = 3000;
        float mIniccial = (float)Convert.ToDecimal(txtMInicial.Text);
        float resGeneral = (valInicial-mIniccial);
        float cuotas = 3;
        float sumCuotas = resGeneral / cuotas;
        float inteeres = valInicial * (float)(0.05);
        txtMFinal.Text = Convert.ToString((sumCuotas+inteeres));
    }

    void verResumen_Clicked(System.Object sender, System.EventArgs e)
    {
        float valInicial = 3000;
        float mIniccial = (float)Convert.ToDecimal(txtMInicial.Text);
        float resGeneral = (valInicial - mIniccial);
        float cuotas = 3;
        float sumCuotas = resGeneral / cuotas;
        float inteeres = valInicial * (float)(0.05);
        string valorMensual = Convert.ToString((sumCuotas + inteeres));

        Navigation.PushAsync(new VRegistro(
                                            idUsuarioIngreso.Text,
                                            txtNombre.Text,
                                            txtApellido.Text,
                                            txtEdad.Text,
                                            Convert.ToString(txtFecha.Date),
                                            txtPais.Text,
                                            txtCiudad.Text,
                                            txtMInicial.Text,
                                            valorMensual,
                                            (valorMensual+ mIniccial)
                                        ));
    }
}
