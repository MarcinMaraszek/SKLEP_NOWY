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
    public partial class Lista_Laptopow : Form
    {
        SKLEPEntities db;

        public Lista_Laptopow(SKLEPEntities sklepEntities)
        {
            db = sklepEntities;
            InitializeComponent();
        }

        private void Lista_Laptopow_Load(object sender, EventArgs e)
        {
            this.Grid_Laptopy.DataSource = db.Laptop.ToList();
        }

        private void Grid_Laptopy_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Laptop selectedLaptop = (Laptop)((DataGridView)sender).CurrentRow.DataBoundItem;
            Laptop_Detail laptopDetail = new Laptop_Detail(selectedLaptop);
            laptopDetail.Show();
        }
    }
}
