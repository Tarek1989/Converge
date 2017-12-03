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
    /// Interaction logic for RemoveHardware.xaml
    /// </summary>
    public partial class RemoveHardware : Window
    {
        public RemoveHardware()
        {
            InitializeComponent();
        }

        //in order to reset the auto_increase of sql ID you need to truncate the table

        private void Remove_Hardware(object sender, RoutedEventArgs e)
        {
            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            try
            {
                //Get data
                List<Hardware> hardware = t.GetHardware();


                //Get user input
                string _RemoveItem = Remove.Text;
                int RemoveItem = Convert.ToInt32(_RemoveItem);

               
                //loop into data to find hardware of interest
            

                foreach (Hardware i in hardware)
                {

                    if (i.ID == RemoveItem)
                    {

                        t.RemoveHardware(i);
                        MessageBox.Show("Hardware succesfully removed");
                        break;
                        

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
