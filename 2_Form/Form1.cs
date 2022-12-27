using _2_Form.Entites;

namespace _2_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindContext dbcontext = new NorthwindContext();
            lboxCategories.DataSource = dbcontext.Categories.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = (Category)lboxCategories.SelectedItem;

            string catname = cat.CategoryName;
            int catId = cat.CategoryId;

            MessageBox.Show($"{catId} - {catname}");

            NorthwindContext dbContext = new NorthwindContext();

            lboxProducts.DataSource = dbContext.Products.Where(c => c.CategoryId == catId).ToList();



        }

    }
}