using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class RebirthShop : Form
    {
        public RebirthShop()
        {
            InitializeComponent();
        }

        private void butonInapoi_Click(object sender, EventArgs e)
        {
            CookieClicker.Form1.Instanta.InchideRebirthShop();
        }
    }
}
