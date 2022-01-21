using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = ALMSTWKND.UI.WindowsForms.Controls.Button;

namespace Test_Project
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Clicked(object sender, Button.ButtonClickedEventArgs e)
        {
            MessageBox.Show("Button clicked.");
        }
    }
}
