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
        public Func<int, string> Formatter { get; set; }

        public Stats()
        {
            InitializeComponent();
            // SubsequentMonths();
            SubsequentMonths();
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


        //method that fetches data and filters nodes based on month december
        private int DecemberNodes()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> decembernodes = t.GetHardware().FindAll(x => x.Date.Month==12);

            int DecemberSumOfNodes = 0;

            foreach (Hardware i in decembernodes)
            {
                DecemberSumOfNodes += i.Nodes;
            }

            return DecemberSumOfNodes;
        }
        //method that fetches data and filters repearters based on month december
        private int DecemberRepeaters()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> decemberrepeaters = t.GetHardware().FindAll(x => x.Date.Month==12);

            int DecemberSumOfRepeaters = 0;

            foreach (Hardware i in decemberrepeaters)
            {
                DecemberSumOfRepeaters += i.Repeaters;
            }

            return DecemberSumOfRepeaters;
        }
        //method that fetches data and filters hubs based on month december
        private int DecemberHubs()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> decemberhubs= t.GetHardware().FindAll(x => x.Date.Month == 12);

            int DecemberSumOfHubs = 0;

            foreach (Hardware i in decemberhubs)
            {
                DecemberSumOfHubs += i.Hubs;
            }

            return DecemberSumOfHubs;
        }

        //Method that fetches data and filters nodes based on month January 
        private int JanuaryNodes()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> januarynodes = t.GetHardware().FindAll(x => x.Date.Month==01);

            int JanuarySumOfNodes = 0;

            foreach (Hardware i in januarynodes)
            {
                JanuarySumOfNodes += i.Nodes;
            }

            return JanuarySumOfNodes;
        }
        //Method that fetches data and filters repeaters based on month January 
        private int JanuaryRepeaters()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> januaryrepeaters = t.GetHardware().FindAll(x => x.Date.Month==01);

            int JanuarySumOfRepeaters = 0;

            foreach (Hardware i in januaryrepeaters)
            {
                JanuarySumOfRepeaters += i.Repeaters;
            }

            return JanuarySumOfRepeaters;
        }
        //Method that fetches data and filters hubs based on month January 
        private int JanuaryHubs()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> januaryhubs = t.GetHardware().FindAll(x => x.Date.Month == 01);

            int JanuarySumOfHubs = 0;

            foreach (Hardware i in januaryhubs)
            {
                JanuarySumOfHubs += i.Hubs;
            }

            return JanuarySumOfHubs;
        }

        //Method that fetches data and filters nodes based on month february
        private int FebruaryNodes()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> februarynodes = t.GetHardware().FindAll(x => x.Date.Month==02);

            int FebruarySumOfNodes = 0;

            foreach (Hardware i in februarynodes)
            {
                FebruarySumOfNodes += i.Nodes;
            }

            return FebruarySumOfNodes;
        }
        //Method that fetches data and filters repeaters based on month february
        private int FebruaryRepeaters()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> februaryrepeaters = t.GetHardware().FindAll(x => x.Date.Month==02);

            int FebruarySumOfRepeaters = 0;

            foreach (Hardware i in februaryrepeaters)
            {
                FebruarySumOfRepeaters += i.Repeaters;
            }

            return FebruarySumOfRepeaters;
        }
        //Method that fetches data and filters nodes based on month february
        private int FebruaryHubs()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> februaryhubs = t.GetHardware().FindAll(x => x.Date.Month==02);

            int FebruarySumOfHubs = 0;

            foreach (Hardware i in februaryhubs)
            {
                FebruarySumOfHubs += i.Hubs;
            }

            return FebruarySumOfHubs;
        }

        //Method that fetches data and filters nodes based on month March
        private int MarchNodes()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> marchnodes = t.GetHardware().FindAll(x => x.Date.Month==03);

            int MarchSumOfNodes = 0;

            foreach (Hardware i in marchnodes)
            {
                MarchSumOfNodes += i.Nodes;
            }

            return MarchSumOfNodes;
        }
        //Method that fetches data and filters repeaters based on month March
        private int MarchRepeaters()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> marchrepeaters = t.GetHardware().FindAll(x => x.Date.Month==03);

            int MarchSumOfRepeaters = 0;

            foreach (Hardware i in marchrepeaters)
            {
                MarchSumOfRepeaters += i.Repeaters;
            }

            return MarchSumOfRepeaters;
        }
        //Method that fetches data and filters hubs based on month March
        private int MarchHubs()
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> marchhubs = t.GetHardware().FindAll(x => x.Date.Month==03);

            int MarchSumOfHubs= 0;

            foreach (Hardware i in marchhubs)
            {
                MarchSumOfHubs += i.Hubs;
            }

            return MarchSumOfHubs;
        }


        //Method that gives you current month
        private string Month()
        {

            string month = DateTime.Now.Month.ToString();

            return month;
        }


        private void DisplayDecemberData()
        {

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                    {
                          Title = "Nodes",
                          Values = new ChartValues<int> { DecemberNodes()  }
                    },

                 
            };

            SeriesCollection.Add
            (
                new ColumnSeries
                {
                    Title = "Repeaters",
                    Values = new ChartValues<int> { DecemberRepeaters() }
                }
            );

            SeriesCollection.Add
           (
               new ColumnSeries
               { 
                   Title = "Hubs",
                   Values = new ChartValues<int> { DecemberHubs() }
               }
           );


            
            Labels = new[] { Month() };
            Formatter = value => value.ToString("N");

            DataContext = this;

        }

        private void DisplayJanuaryData()
        {

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                    {
                          Title = "Nodes",
                          Values = new ChartValues<int> { DecemberNodes(),  JanuaryNodes()  }
                    },


            };

            SeriesCollection.Add
            (
                new ColumnSeries
                {
                    Title = "Repeaters",
                    Values = new ChartValues<int> { DecemberRepeaters(), JanuaryRepeaters() }
                }
            );

            SeriesCollection.Add
           (
               new ColumnSeries
               {
                   Title = "Hubs",
                   Values = new ChartValues<int> { DecemberHubs(), JanuaryHubs() }
               }
           );



            Labels = new[] { Month(), Month() };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        private void DisplayFebruaryData()
        {

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                    {
                          Title = "Nodes",
                          Values = new ChartValues<int> { DecemberNodes(), JanuaryNodes(),  FebruaryNodes()  }
                    },


            };

            SeriesCollection.Add
            (
                new ColumnSeries
                {
                    Title = "Repeaters",
                    Values = new ChartValues<int> { DecemberRepeaters(), JanuaryRepeaters(), FebruaryRepeaters() }
                }
            );

            SeriesCollection.Add
           (
               new ColumnSeries
               {
                   Title = "Hubs",
                   Values = new ChartValues<int> { DecemberHubs(),JanuaryHubs(), FebruaryHubs() }
               }
           );



            Labels = new[] { Month(), Month(), Month() };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        private void DisplayMarchData()
        {

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                    {
                          Title = "Nodes",
                          Values = new ChartValues<int> { DecemberNodes(), JanuaryNodes(), FebruaryNodes(), MarchNodes()  }
                    },


            };

            SeriesCollection.Add
            (
                new ColumnSeries
                {
                    Title = "Repeaters",
                    Values = new ChartValues<int> { DecemberRepeaters(), JanuaryRepeaters(), FebruaryRepeaters(),  MarchRepeaters() }
                }
            );

            SeriesCollection.Add
           (
               new ColumnSeries
               {
                   Title = "Hubs",
                   Values = new ChartValues<int> { DecemberHubs(), JanuaryHubs(),FebruaryHubs(), MarchHubs() }
               }
           );



            Labels = new[] { Month(), Month(), Month(), Month() };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        //Method that gives subsequent months
        private void SubsequentMonths()
        {
            DateTime now = DateTime.Now;
            int month = now.Month;

            switch (month)
            {
                //if month is december(12) show data for december
                case 12:
                    DisplayDecemberData();
                    break;

                //if month is january(01) show data for december and january
                case 01:
                    DisplayJanuaryData();
                    break;

                //if month is FEBRUARY(02) show data for december, january nad february
                case 02:
                    DisplayFebruaryData();
                    break;

                //if month is march(03) show data for december,january,february and March
                case 03:
                    DisplayMarchData();
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowHardware sh = new ShowHardware();
            sh.Show();
            this.Close();
        }
    }
}
