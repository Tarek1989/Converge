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
    /// Interaction logic for AddHardware.xaml
    /// </summary>
    public partial class AddHardware : Window
    {
        public AddHardware()
        {
            InitializeComponent();
        }

        private string nodes;
        private string repeaters;
        private string hubs;

        private void Submit_Nodes(object sender, RoutedEventArgs e)
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);
            Hardware h = new Hardware();

            try
            {
                nodes = AddNodes.Text;
                repeaters = AddRepeaters.Text;
                hubs = AddHubs.Text;

                h.Nodes = Convert.ToInt32(nodes);
                h.Repeaters = Convert.ToInt32(repeaters);
                h.Hubs = Convert.ToInt32(hubs);

                t.AddHardware(h);

            }
            catch
            {
                MessageBox.Show("At a numerical value");
            }

            ShowHardware sh = new ShowHardware();
            sh.Show();
            this.Close();


        }
    }
}
