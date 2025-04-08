using P.II_C.II_SI_Actores_y_Series.Windows;

namespace P.II_C.II_SI_Actores_y_Series
{
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
            this.Text="Software TV Show 1.8 (GUI)";
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            
        }

        private void btSeries_Click(object sender, EventArgs e) {
            SeriesWindow seriesWindow = new SeriesWindow();

            seriesWindow.Show();
        }

        private void btActors_Click(object sender, EventArgs e) {
            ActorsWindow actorsWindow = new ActorsWindow();

            actorsWindow.Show();
        }
    }
}
