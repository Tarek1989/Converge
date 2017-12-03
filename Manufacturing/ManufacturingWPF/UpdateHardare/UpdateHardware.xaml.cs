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
    /// Interaction logic for UpdateHardware.xaml
    /// </summary>
    public partial class UpdateHardware : Window
    {
        public UpdateHardware()
        {
            InitializeComponent();
            IDList();
        }

        private void IDList()
        {   ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            List<Hardware> hardware = t.GetHardware();
            IDlist.ItemsSource = hardware;

        }

         private void Update_Hardware(object sender, RoutedEventArgs e)
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);



            try
            {
                //Get data
                List<Hardware> hardware = t.GetHardware();

                //Get user input
                string _IDItem = IDlist.Text;
                int IDItem = Convert.ToInt32(_IDItem);

                //Prepare node/repeater/hub parameters
                string _node = Node.Text;
                int node = Convert.ToInt32(_node);

                string _repeater = Repeater.Text;
                int repeater = Convert.ToInt32(_repeater);

                string _hub = Hub.Text;
                int hub = Convert.ToInt32(_hub);

                //looping in list
                foreach (Hardware i in hardware)
                {
                    if (i.ID == IDItem)
                    {

                        i.Nodes = node;
                        i.Repeaters = repeater;
                        i.Hubs = hub;
                        t.UpdateHardware(i);
                        
                    }
                }


                ShowHardware sh = new ShowHardware();
                sh.Show();
                this.Close();
            }
            catch
            {
                //Try or catch in care user enter invalid id number or string
                MessageBox.Show("Your update has failed. Please check for:" + "\n" + "- Character" + "\n" + "- String" + "\n" + "- Empty box");
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
