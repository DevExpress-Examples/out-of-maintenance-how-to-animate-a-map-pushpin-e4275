using System;
using System.Windows.Controls;
using DevExpress.Xpf.Map;

namespace PushpinAnimation {
    public partial class MainPage : UserControl {
        Random rand = new Random((int)DateTime.Now.Ticks);

        public MainPage() {
            InitializeComponent();
            SelectRandomLocation();
        }

        private void PushpinLocationAnimation_Completed(object sender, EventArgs e) {
            SelectRandomLocation();
        }

        private void SelectRandomLocation() {
            pushpin.Location = (new GeoPoint(rand.NextDouble() * 40, rand.NextDouble() * 40));
        }
    }
}
