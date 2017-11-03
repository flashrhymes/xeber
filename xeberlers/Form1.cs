using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xeberlers.model1;

namespace xeberlers
{
    public partial class Form1 : Form
    {
        private newsEntities db = new newsEntities();
        private News selectedcategori;
        public Form1()
        {
            InitializeComponent();
            loadData();
            dgvnews.Columns[0].Visible = false;
            fillcombobox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            dgvnews.DataSource = db.News.Select(n => new
            {
                n.Id,
                n.Title,
                n.Date,
                n.Contents,
                categores = n.Categories.Name

            }).ToList();
        }
        private void fillcombobox()
        {
            List<Categories> list = db.Categories.ToList();
            foreach(Categories item in list)
            {
                cmbcategories.Items.Add(item.Name);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string title = txttitle.Text;
            DateTime date = dtpdate.Value;
            string content = rtbcontent.Text;
            string categoori = cmbcategories.Text;
            if (title == string.Empty || content == string.Empty || categoori == string.Empty)
            {
                MessageBox.Show("Xanalari secin");
                return;
            }

                News nw = new News();
            nw.Title = title;
            nw.Date = date;
            nw.Contents = content;
            int categoriId = this.getcategoriIdbyname(categoori);
            nw.CategoriId = categoriId;
            db.News.Add(nw);
            db.SaveChanges();
            loadData();
            

            

        }
        private int getcategoriIdbyname(string categori)
        {
            return db.Categories.FirstOrDefault(c => c.Name == categori).Id;
        }

        private void dgvnews_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int id = Convert.ToInt32(dgvnews.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.selectedcategori = db.News.Find(id);
            txttitle.Text = this.selectedcategori.Title;
            dtpdate.Value = (DateTime) this.selectedcategori.Date;
            rtbcontent.Text = this.selectedcategori.Contents;
            cmbcategories.Text = this.selectedcategori.Categories.Name;
            btnadd.Visible = false;
            btnUpdate.Visible = true;
            btndelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            selectedcategori.Title = txttitle.Text;
            selectedcategori.Date = dtpdate.Value;
            selectedcategori.Contents = rtbcontent.Text;
            selectedcategori.Categories.Name = cmbcategories.Text;
            db.SaveChanges();
            reset();



        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Eminisiniz mi?", "Sil", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.News.Remove(this.selectedcategori);
                db.SaveChanges();
                reset();
            }
        }
        private void reset()
        {
            loadData();
            txttitle.Text = "";
            rtbcontent.Text = "";
            cmbcategories.Text = "";
            btnadd.Visible = true;
            btnUpdate.Visible = false;
            btndelete.Visible = false;
        }
    }
}
