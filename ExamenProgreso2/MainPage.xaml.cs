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
            Navigation.PushAsync(new chistespueste());
        }
        //Boton que llevara a la seccion de mi informacion personal
        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Aboutme());
        }
        

    }
}
