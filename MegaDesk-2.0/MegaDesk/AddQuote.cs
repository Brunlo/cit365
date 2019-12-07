using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        private Form _MainMenu;
       

        public AddQuote(Form MainMenu)
        {
            
            InitializeComponent();
            _MainMenu = MainMenu;

            var materials = Enum.GetValues(typeof(Desk.DeskMaterial))
                            .Cast<Desk.DeskMaterial>()
                            .ToList();

            materialBox.DataSource = materials;

            materialBox.SelectedIndex = -1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }
        //Closes form
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void DeliveryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void NumericUpDownDrawers_ValueChanged(object sender, EventArgs e)
        {

        }
        //Get Quote Button
        private void GetQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            var deskQuote = new DeskQuote();
            try
            {
                desk.WidthUpDown = WidthUpDown.Value;
                desk.HeightUpDown = HeightUpDown.Value;
                desk.NumDrawers = int.Parse(numericUpDownDrawers.Value.ToString());

                desk.Material = (Desk.DeskMaterial)materialBox.SelectedValue;

                deskQuote.Desk = desk;
                deskQuote.CustomerName = customerName.Text;
                deskQuote.ShippingDays = int.Parse(deliveryBox.SelectedItem.ToString());
                deskQuote.QuoteDate = DateTime.Now;
                deskQuote.ShippingCost = deskQuote.GetShippingCost();
                deskQuote.StructureCost = deskQuote.GetStructureCost();
                deskQuote.SurfaceCost = deskQuote.GetSurfaceCost();
                deskQuote.Quote = deskQuote.GetQuote();

                System.Diagnostics.Debug.WriteLine(desk.NumDrawers);
                System.Diagnostics.Debug.WriteLine(deskQuote.StructureCost);
                System.Diagnostics.Debug.WriteLine(deskQuote.ShippingCost);
                System.Diagnostics.Debug.WriteLine(deskQuote.SurfaceCost);
            }
            catch (Exception ex)
            {

            }
                structCostlbl.Text = deskQuote.GetStructureCost().ToString();
                surfaceCostlbl.Text = deskQuote.GetSurfaceCost().ToString();
                shippingCostlbl.Text = deskQuote.GetShippingCost().ToString();
                finalCostlbl.Text = deskQuote.GetQuote().ToString();
            


            List<DeskQuote> deskQuotes = new List<DeskQuote>();
            if (!File.Exists(@"quotes.json"))
            {
                deskQuotes.Add(deskQuote);
                var list = JsonConvert.SerializeObject(deskQuotes);
                File.WriteAllText(@"quotes.json", JsonConvert.SerializeObject(deskQuotes));
            }
            else
            {
                using (StreamReader reader = new StreamReader(@"quotes.json"))
                {
                    string allQuotes = reader.ReadToEnd();
                    deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);
                }
                deskQuotes.Add(deskQuote);
                var list = JsonConvert.SerializeObject(deskQuotes);
                File.WriteAllText(@"quotes.json", list);
            }

          
        }
      
        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ShippingCost_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

