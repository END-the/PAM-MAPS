using Microsoft.Maui.Maps;

namespace PAM_Maps

{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {

            InitializeComponent();
            //inicialização do mapa
            var location = new Location(-23.51955620023332, -46.595764769894195);
            var mapSpan = new MapSpan(location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
        }

    }

}
