using RaceSim.Races;
using System.Windows;

namespace RaceSim
{
    /// <summary>
    /// Логика взаимодействия для ResultsWindow.xaml
    /// </summary>
    public partial class ResultsWindow : Window
    {
        public ResultsWindow(List<RaceResult> raceResults)
        {
            InitializeComponent();
            raceResultsDataGrid.ItemsSource = raceResults;
        }
    }
}
