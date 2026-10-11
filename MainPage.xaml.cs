namespace CalculadoraCombustivel;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			double etanol = Convert.ToDouble(txt_etanol.Text);
			double gasolina = Convert.ToDouble(txt_gasolina.Text);

			string msg = "";

            if (etanol <= (gasolina * 0.7))
			{
				msg = "Etanol compensa mais!";
			}
			else { msg = "Gasolina compensa mais!"; }
			{
				DisplayAlert("Resultado", msg, "OK");
            }
        }
		catch (Exception ex)
		{
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}
