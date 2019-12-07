using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
                AddQuote frmAddQuote= new AddQuote(this);
                frmAddQuote.Show();
                Hide();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ViewAllQuotes frmViewAllQuotes = new ViewAllQuotes(this);
            frmViewAllQuotes.Show();
            Hide();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SearchQuotes frmSearchQuotes = new SearchQuotes(this);
            frmSearchQuotes.Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeskMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
