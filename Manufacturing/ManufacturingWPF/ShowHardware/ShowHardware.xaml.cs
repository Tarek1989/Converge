using ManufacturingDB;
using ManufacturingTest;
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

namespace ManufacturingWPF
{
    /// <summary>
    /// Interaction logic for ShowHardware.xaml
    /// </summary>
    public partial class ShowHardware : Window
    {
        public ShowHardware()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            //Retrieves the data from db
            List<Hardware> x = t.GetHardware();

            /*HArdwareList is the x:Name in ListView
            HardwareList.ItemSource = x is basically directing towards the data in list.*/
            HardwareList.ItemsSource = x;

            /*foreach(Hardware i in x )
            {
                //HardwareList.Items.Add(i);
            }*/
        }

        private void Add_Hardware(object sender, RoutedEventArgs e)
        {
            //PageOne.Content = new AddHardware();

            AddHardware ad = new AddHardware();
            ad.Show();
            this.Close();
        }

        private void Remove_Hardware(object sender, RoutedEventArgs e)
        {
            RemoveHardware rd = new RemoveHardware();
            rd.Show();
            this.Close();
        }

        private void Update_Hardware(object sender, RoutedEventArgs e)
        {
            UpdateHardware uh = new UpdateHardware();
            uh.Show();
            this.Close();
        }

        private void Stats (object sender, RoutedEventArgs e)
        {
            Stats s = new Stats();
            s.Show();
            this.Close();
        }
    }
}
