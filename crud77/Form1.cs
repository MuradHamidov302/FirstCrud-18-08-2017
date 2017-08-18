using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud77
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            read();
        }
        crud77Entities db = new crud77Entities();

        string ad1 ;
        string soyad1;
        string age1;

        void bosh()
        {
            ad1 = Ad.Text;
            soyad1 = Soyad.Text;
            age1 = Age.Text;
            if (string.IsNullOrEmpty(ad1) || string.IsNullOrEmpty(soyad1) || string.IsNullOrEmpty(age1))
            {
                MessageBox.Show("Bosh buraxma.");
                return;
            }
        }

        void read()
        {
            var elems = db.crud77.ToList();
            idData.Items.Clear();
            foreach (var item in elems)
            {
                idData.Items.Add(item.Id);
            }
        }



        private void add_Click(object sender, EventArgs e)
        {
            bosh();

            crud77 qeyd = new crud77();
            qeyd.name = ad1;
            qeyd.surname = soyad1;
            qeyd.age = Convert.ToInt32(age1);
            db.crud77.Add(qeyd);
            db.SaveChanges();
           read();
             MessageBox.Show("bitdi");
                return;
            
        }

        private void idData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idData.SelectedItem);
            var id1 = db.crud77.Where((x) => x.Id == id).First();
            Ad.Text = id1.name;
            Soyad.Text = id1.surname;
            Age.Text = id1.age.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (idData.SelectedItem == null)
            {
                MessageBox.Show("Combobox sechilmeyib");
                return;
            }
            bosh();
            int id = Convert.ToInt32(idData.SelectedItem);
            var id1 = db.crud77.Where((x) => x.Id == id).First();
            id1.name= Ad.Text;
           id1.surname= Soyad.Text ;
            id1.age=Convert.ToInt32(Age.Text );
            db.SaveChanges();
            MessageBox.Show("bitdi");
            return;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idData.SelectedItem == null)
            {
                MessageBox.Show("Combobox sechilmeyib");
                return;
            }
            int id = Convert.ToInt32(idData.SelectedItem);
            var book = db.crud77.Where(x => x.Id == id).First();
            db.crud77.Remove(book);
            db.SaveChanges();
            idData.Text = "";
            Ad.Text = "";
            Soyad.Text = "";
            Age.Text = "";
            read();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
