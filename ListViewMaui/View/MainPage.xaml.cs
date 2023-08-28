namespace ListViewMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
			lbl1.IsVisible = !lbl1.IsVisible;
			lbl2.IsVisible = !lbl2.IsVisible;
		}
    }
}
