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
using LiveCharts.Wpf;
using ManufacturingDB;
using ManufacturingTest;
using LiveCharts;

namespace ManufacturingWPF
{
    /// <summary>
    /// Interaction logic for Stats.xaml
    /// </summary>
    public partial class Stats : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public Stats()
        {
            InitializeComponent();
            DisplayData();
        }

        /*Instructions of how to isntall new libs
         *  1. Use NuGet console to install package or use NuGet GUI to find it
         *  2. Add to reference
         *  3. Add the namespace to class you want it (i.e using system.windows.xxx or using LiveCharts.wpf)
         *  4. If using WPF then you could check if toolbox has drag and drop
         *              i.  Go to toolbox right click and add a new bar tab for ur package.
         *              ii. Once tab is done right click and press choose items
         *              iii.Find files/package of interest.
         *  5. If toolbox does not exist then at xaml you need to add the namespace (could be tricky as if no documentation is available then you have to play until u get the right one)
         *              i.  Type xmlns: followed by any letter/word (i.e xmlns:a) 
         *              ii. Insert namespace.
         *              iii.Once that's done go and type in your xmal ur code starting like this (<a:) */

        private int SumOfNodes()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> SumOfHardware = t.GetHardware().FindAll(x => x.Nodes != 0);

            int SumOfNodes = 0;

            foreach (Hardware i in SumOfHardware )
            {
                SumOfNodes += i.Nodes;
            }

            return SumOfNodes;
        }


        private int SumOfRepeaters()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> SumOfHardware = t.GetHardware().FindAll(x => x.Repeaters != 0);

            int SumOfRepeaters = 0;

            foreach (Hardware i in SumOfHardware)
            {
                SumOfRepeaters += i.Repeaters;
            }

            return SumOfRepeaters;
        }

        private int SumOfHubs()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> SumOfHardware = t.GetHardware().FindAll(x => x.Hubs != 0);

            int SumOfHubs= 0;

            foreach (Hardware i in SumOfHardware)
            {
                SumOfHubs += i.Hubs;
            }

            return SumOfHubs;
        }

        private string Month()
        {
            DateTime now = DateTime.Now;

            string month = DateTime.Now.ToString("MMMM");

            return month;
        }

        private void DisplayData()
        {

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                    {
                          Title = "Nodes",
                          Values = new ChartValues<int> { SumOfNodes() , 12313,123123 }
                    },

                 
            };

            SeriesCollection.Add
            (
                new ColumnSeries
                {
                    Title = "Repeaters",
                    Values = new ChartValues<int> { SumOfRepeaters(), 12313, 123123 }
                }
            );

            SeriesCollection.Add
           (
               new ColumnSeries
               { 
                   Title = "Hubs",
                   Values = new ChartValues<int> { SumOfHubs() , 12313, 123123 }
               }
           );


            
            Labels = new[] {"leo", Month() , "Tarek" };
            Formatter = value => value.ToString("N");

            DataContext = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowHardware sh = new ShowHardware();
            sh.Show();
            this.Close();
        }
    }
}
