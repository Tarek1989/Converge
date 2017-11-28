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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManufacturingWPF
{
    /// <summary>
    /// Interaction logic for AddHardware.xaml
    /// </summary>
    public partial class AddHardware : Page
    {
        public AddHardware()
        {
            InitializeComponent();
        }

        private void Submit_Nodes(object sender, RoutedEventArgs e )
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);
            Hardware h = new Hardware();

            string nodes = AddNodes.Text;

            int numberofnodes = Convert.ToInt32(nodes);
            h.Nodes = numberofnodes;

            //return update version but does not properly work
            PageTwo.Content = new ShowHardware();

            t.AddHardware(h);

        }
    }
}
