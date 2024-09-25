using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RaceSim.Vehicles;
using RaceSim.Races;
using RaceSim.Vehicles.AirVehicles;
using RaceSim.Vehicles.GroundVehicles;

namespace RaceSim
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Race> races = new List<Race> {
                new CommonRace(),
                new GroundRace(),
                new AirRace()
            };
        Race currentRace;

        List<Vehicle> vehiclesList = new List<Vehicle> {
                new YagaStupa(),
                new Broom(),
                new RunningBoots(),
                new PumpkinChariot(),
                new FlyingCarpet(),
                new ChickenHut(),
                new Centaur(),
                new FlyingShip()
            };
        List<Vehicle> possibleVehicles;

        public MainWindow()
        {
            InitializeComponent();

            racesChoiceBox.ItemsSource = races;
            racesChoiceBox.SelectedIndex = 0;
        }

        private void racesChoiceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentRace = racesChoiceBox.SelectedItem as Race;
            try
            {
                vehicleChoiceList.ItemsSource = getPossibleVehicles();
            }
            catch (NullReferenceException)
            {
                vehicleChoiceList.ItemsSource = new List<Vehicle>();
            }
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            float raceDistance = float.Parse(distanceField.Text);

            List<RaceResult> raceResults = new();
            foreach (Vehicle participant in vehicleChoiceList.SelectedItems)
            {
                RaceResult result = new RaceResult(participant, (float)Math.Round(participant.GetRideTime(raceDistance), 2));
                raceResults.Add(result);
            }

            raceResults.Sort((result1, result2) => result1.time.CompareTo(result2.time));
            ShowRaceResults(raceResults);
        }


        private List<Vehicle> getPossibleVehicles()
        {
            return vehiclesList.Where(vehicle => currentRace.VehicleMathcesRace(vehicle)).ToList();
        }

        private void ShowRaceResults(List<RaceResult> raceResults)
        {
            ResultsWindow resultsWindow = new ResultsWindow(raceResults);
            resultsWindow.Show();
        }
    }   
}
