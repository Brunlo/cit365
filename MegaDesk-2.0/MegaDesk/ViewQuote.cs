using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private Form _MainMenu;
        public ViewAllQuotes(Form MainMenu)
        {
            InitializeComponent();
            _MainMenu = MainMenu;
            loadGrid();
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // All the created quotes will load.
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(data => new
                {
                    Date = data.QuoteDate,
                    Customer = data.CustomerName,
                    Width = data.Desk.WidthUpDown,
                    Depth = data.Desk.HeightUpDown,
                    NumberOfDrawers = data.Desk.NumDrawers,
                    SurfaceMaterials = data.Desk.Material,
                    DeliveryType = data.ShippingDays,
                    QuotePrice = data.Quote
                }).ToList();
            }
        }
            private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
