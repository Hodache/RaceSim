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
        List<Vehicle> vehiclesList;
        List<Race> races;
        Race race;

        public MainWindow()
        {
            InitializeComponent();

            vehiclesList = new List<Vehicle> {
                new YagaStupa(),
                new Broom(),
                new RunningBoots(),
                new PumpkinChariot(),
                new FlyingCarpet(),
                new ChickenHut(),
                new Centaur(),
                new FlyingShip()
            };
            vehicleChoiceList.ItemsSource = vehiclesList;

            races = new List<Race>
            {
                new CommonRace(),
                new GroundRace(),
                new AirRace()
            };
            racesChoiceBox.ItemsSource = races;
        }

        private void vehicleChoiceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
