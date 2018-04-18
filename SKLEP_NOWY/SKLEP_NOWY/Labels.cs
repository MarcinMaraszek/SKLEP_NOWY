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
    public partial class Laptop_Detail : Form
    {
        Laptop laptop;
        SKLEPEntities db;
        public Laptop_Detail(Laptop laptop, SKLEPEntities db)
        {
            this.db = db;
            this.laptop = laptop;
            InitializeComponent();
        }

        private void Laptop_Detail_Load(object sender, EventArgs e)
        {
            this.txtProcesor.Text = laptop.procesor.ToString();
        }

        private void save_detail_MouseClick(object sender, MouseEventArgs e)
        {
            laptop.procesor = int.Parse(this.txtProcesor.Text);
            db.SaveChanges();
        }
    }
}
