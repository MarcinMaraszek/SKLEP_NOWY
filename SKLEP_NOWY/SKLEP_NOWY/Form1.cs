using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKLEP_NOWY
{
    public partial class FormStart : Form
    {
        SKLEPEntities sklepEntities = new SKLEPEntities();
        public FormStart()
        {
            InitializeComponent();
        }

        private void Open_Laptop_Click(object sender, EventArgs e)
        {
            Lista_Laptopow laptoplista = new Lista_Laptopow(sklepEntities);
            laptoplista.Show();
        }
    }
}
