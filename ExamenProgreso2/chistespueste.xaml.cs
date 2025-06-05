namespace ExamenProgreso2;
using ExamenProgreso2.Repository;
using ExamenProgreso2.Models;
public partial class chistespueste : ContentPage
{
    private ChistesRepository _chistesRepository = new ChistesRepository();
    public chistespueste()
	{
		InitializeComponent();
	}
    private async void OnObtenerChisteClicked(object sender, EventArgs e)
    {
        var chistes = await _chistesRepository.GetCountryListAsync();
        var chiste = chistes.FirstOrDefault();
        if (chiste != null)
        {
            ChisteLabel.Text = $"{chiste.setup}\n\n{chiste.punchline}";
        }
        else
        {
            ChisteLabel.Text = "No se pudo obtener un chiste.";
        }
    }
}