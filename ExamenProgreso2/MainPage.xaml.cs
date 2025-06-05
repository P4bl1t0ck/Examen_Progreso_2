namespace ExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        //Boton que llevara a chistes al consumo de apis
        private void Chistes_Clicked(object sender, EventArgs e)
        {

        }
        //Boton que llevara a la seccion de mi informacion personal
        private void About_Clicked(object sender, EventArgs e)
        {

        }
        /*
private void OnCounterClicked(object? sender, EventArgs e)
{
count++;

if (count == 1)
CounterBtn.Text = $"Clicked {count} time";
else
CounterBtn.Text = $"Clicked {count} times";

SemanticScreenReader.Announce(CounterBtn.Text);
}
*/

    }
}
