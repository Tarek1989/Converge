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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> x = t.GetHardware();


            foreach (Hardware i in x)
            {

                if(i.ID == 1)
                {
                    
                   string a = i.Nodes.ToString();
                    Nodes.Text = a;
                }

            } 


        }

    }
}
