using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        private Form _MainMenu;

        public SearchQuotes(Form MainMenu)
        {
            InitializeComponent();
            _MainMenu = MainMenu;
            loadGrid();

            var materials = Enum.GetValues(typeof(Desk.DeskMaterial))
                            .Cast<Desk.DeskMaterial>()
                            .ToList();

            comboBox1.DataSource = materials;

            comboBox1.SelectedIndex = -1;
        }
       

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // load existing quotes
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

        private void ComSearchMaterials(object sender, EventArgs e)
        {
            var deskMaterial = Enum.GetName(typeof(Desk.DeskMaterial), comboBox1.SelectedIndex).ToString();
            System.Diagnostics.Debug.WriteLine(deskMaterial);

            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // load existing quotes
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
                })
                .Where(q => q.SurfaceMaterials.ToString() == deskMaterial)
                .ToList();
            }
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private void SearchQuotes_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }
    }
}