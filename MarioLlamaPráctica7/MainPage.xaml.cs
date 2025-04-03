namespace MarioLlamaPráctica7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            textoLBL.Text = Preferences.Default.Get("TXTInicio","Hola Mundo!!!");
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            textoLBL.Text=textoEN.Text;
            Preferences.Default.Set("TXTInicio", textoEN.Text);
        }
    }

}
