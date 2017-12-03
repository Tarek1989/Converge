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

namespace ManufacturingWPF
{
    /// <summary>
    /// Interaction logic for Stats.xaml
    /// </summary>
    public partial class Stats : Window
    {
        public Stats()
        {
            InitializeComponent();
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
            
        
    }
}
