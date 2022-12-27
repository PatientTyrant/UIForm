using _3_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Form
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NorthwindContext dbContext = new NorthwindContext();

            //#region First ve Firstordefault
            //List<int> ints = new List<int>() { 1, 23, 4, 5, 6, 7, 8, 9 };
            //int a = ints.First(c => c == 3);
            ////int b= ints.First(c => c == 44); // program burada hata verir // First komutu aranana eleman listede yoksa hata döner
            //int c = ints.FirstOrDefault(c => c == 3);
            //int d = ints.FirstOrDefault(c => c == 44); // Aranan eleman listede varsa ilkini burada aranan eleman eğer listede yoksa collection tipinin default değeri döner   
            //List<string> strings = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h" };
            //string z = strings.FirstOrDefault(c => c == "c");
            //// single => eğer aranan elamandan listede birden fazla var ise hata döner.. varsa elemanı döner
            //// singleordefault => eğer aranan elaman listede varsa elemanı yoksa collection nesnesinin default değerini döner...
            //#endregion


            Employee emp = dbContext.Employees.FirstOrDefault(c => c.FirstName == txtFirstName.Text && c.LastName == txtLastName.Text);

            if ( emp == null )
            {
                MessageBox.Show("Kullanıcı bulunamadı");
                return;
            }

            FrmRapor frm = new FrmRapor();
            frm.EmployeeId = emp.EmployeeId;
            frm.Show();
           // frm.ShowDialog(); // formu açar ve arkadaki forma müdahale ettirmez...

        }
    }
}
