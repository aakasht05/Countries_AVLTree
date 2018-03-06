using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Countries_AVLTree
{
    public partial class CountryInfoForm : Form
    {
        CountryTree<Country> countryTree = new CountryTree<Country>();
        public CountryInfoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countriesListView.Columns.Add("Country", 100);
            countriesListView.Columns.Add("GDP Growth", 100);
            countriesListView.Columns.Add("Inflation", 75);
            countriesListView.Columns.Add("Trade Balance", 100);
            countriesListView.Columns.Add("HDI Ranking", 100);

            /*tradePartnersListView.Columns.Add("Country", 100);
            tradePartnersListView.Columns.Add("GDP Growth", 100);
            tradePartnersListView.Columns.Add("Inflation", 75);
            tradePartnersListView.Columns.Add("Trade Balance", 100);
            tradePartnersListView.Columns.Add("HDI Ranking", 100);*/

            editTradePartnersListView.Columns.Add("Country", 100);
            editTradePartnersListView.Columns.Add("GDP Growth", 100);
            editTradePartnersListView.Columns.Add("Inflation", 75);
            editTradePartnersListView.Columns.Add("Trade Balance", 100);
            editTradePartnersListView.Columns.Add("HDI Ranking", 100);

            numberOfCountriesValue.Text = "0";
            depthValue.Text = "0";

        }

        private void updateCountHeight()
        {
            numberOfCountriesValue.Text = countryTree.Count().ToString();
            depthValue.Text = countryTree.Height().ToString();
        }

        private void populateCountriesListView()
        {
            countriesListView.Items.Clear();

            List<Country> countryList = new List<Country>();

            countryList = countryTree.InOrder();

            for (int j = 0; j < countryList.Count; j++)
            {
                string[] row = { countryList[j].CountryName, countryList[j].GDPGrowth.ToString(), countryList[j].Inflation.ToString(), countryList[j].TradeBalance.ToString(), countryList[j].HDIRanking.ToString() };

                ListViewItem tmpItem = new ListViewItem(row);

                countriesListView.Items.Add(tmpItem);
            }
        }

        private void populateCountriesListView(List<Country> countryList)
        {
            countriesListView.Items.Clear();

            for (int j = 0; j < countryList.Count; j++)
            {
                string[] row = { countryList[j].CountryName, countryList[j].GDPGrowth.ToString(), countryList[j].Inflation.ToString(), countryList[j].TradeBalance.ToString(), countryList[j].HDIRanking.ToString() };

                ListViewItem tmpItem = new ListViewItem(row);

                countriesListView.Items.Add(tmpItem);
            }
        }

        /*private void populateTradePartnersListView()
        {
            tradePartnersListView.Items.Clear();

            Country selectedCountry = countryTree.FindItemByName(countriesListView.SelectedItems[0].SubItems[0].Text);

            for (int i = 0; i < selectedCountry.TradePartners.Length; i++)
            {
                Country tempTradePartner = countryTree.FindItemByName(selectedCountry.TradePartners[i]);

                string[] row = { tempTradePartner.CountryName, tempTradePartner.GDPGrowth.ToString(), tempTradePartner.Inflation.ToString(), tempTradePartner.TradeBalance.ToString(), tempTradePartner.HDIRanking.ToString() };

                ListViewItem tmpItem = new ListViewItem(row);

                tradePartnersListView.Items.Add(tmpItem);
            }
        }*/

        private void populateEditTradePartnersListView()
        {
            editTradePartnersListView.Items.Clear();

            Country selectedCountry = countryTree.FindItemByName(countriesListView.SelectedItems[0].SubItems[0].Text);

            for (int i = 0; i < selectedCountry.TradePartners.Length; i++)
            {
                Country tempTradePartner = countryTree.FindItemByName(selectedCountry.TradePartners[i]);

                string[] row = { tempTradePartner.CountryName, tempTradePartner.GDPGrowth.ToString(), tempTradePartner.Inflation.ToString(), tempTradePartner.TradeBalance.ToString(), tempTradePartner.HDIRanking.ToString() };

                ListViewItem tmpItem = new ListViewItem(row);

                editTradePartnersListView.Items.Add(tmpItem);
            }
        }

        private void populateEditCountry()
        {
            Country selectedCountry = countryTree.FindItemByName(countriesListView.SelectedItems[0].SubItems[0].Text);

            populateEditTradePartnersListView();

            valueCountryName.Text = selectedCountry.CountryName;
            tbValueGDPGrowth.Text = selectedCountry.GDPGrowth.ToString();
            tbValueInflation.Text = selectedCountry.Inflation.ToString();
            tbValueTradeBalance.Text = selectedCountry.TradeBalance.ToString();
            tbValueHDIRanking.Text = selectedCountry.HDIRanking.ToString();

        }

        private void clearEditCountry()
        {
            editTradePartnersListView.Items.Clear();
            valueCountryName.Text = "";
            tbValueGDPGrowth.Text = "";
            tbValueInflation.Text = "";
            tbValueTradeBalance.Text = "";
            tbValueHDIRanking.Text = "";
        }

        private void removeFromTradePartnersInTree(string name)
        {
            List<Country> countryList = new List<Country>();

            countryList = countryTree.InOrder();

            for (int i = 0; i < countryList.Count; i++)
            {
                if (countryList[i].TradePartners.Contains(name))
                {
                    countryList[i].TradePartners = countryList[i].TradePartners.Where(x => !name.Equals(x)).ToArray();
                }
            }

            populateCountriesListView(countryList);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //This function populates the AVLTree and the countriesListview.

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                countriesListView.Items.Clear();
                string file = openFileDialog1.FileName;
                Country[] countryArray = new Country[5000];
                FileHandler.readCSVIntoCountryArrayObject(file, countryArray);

                int i = 0;
                while (countryArray[i] != null)
                {
                    countryTree.InsertItem(countryArray[i]);

                    i++;
                }

                populateCountriesListView();

                updateCountHeight();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void countriesListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void countriesListView1_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (countriesListView.SelectedItems.Count > 0)
            {
                string countryToRemoveFromTree = countriesListView.SelectedItems[0].SubItems[0].Text;

                Country toRemove = countryTree.FindItemByName(countryToRemoveFromTree);

                if (toRemove != null)
                {
                    removeFromTradePartnersInTree(toRemove.CountryName);
                    countryTree.RemoveItem(toRemove);
                    //tradePartnersListView.Items.Clear();

                    clearEditCountry();
                    populateCountriesListView();
                    updateCountHeight();
                }
                else
                    return;
            }
            else
                return;

        }

        private void countrySearchTB_TextChanged(object sender, EventArgs e)
        {
            if (countrySearchTB.Text.ToString().CompareTo(String.Empty) == 0)
            {
                populateCountriesListView();
                return;
            }

            List<Country> listOfMatches = countryTree.KeywordSearch(countrySearchTB.Text.ToString());

            populateCountriesListView(listOfMatches);
        }

        private void valueCountryName_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            Country newObjectToAdd = new Country();

            newObjectToAdd.CountryName = valueCountryName.Text;
            try
            {
                newObjectToAdd.GDPGrowth = Convert.ToSingle(tbValueGDPGrowth.Text);
                newObjectToAdd.HDIRanking = Convert.ToSingle(tbValueHDIRanking.Text);
                newObjectToAdd.Inflation = Convert.ToSingle(tbValueInflation.Text);
                newObjectToAdd.TradeBalance = Convert.ToSingle(tbValueTradeBalance.Text);
            }
            catch (FormatException floatParseError)
            {
                MessageBox.Show("Invalid input detected.", "Error");
            }

            List<string> partners = new List<string>();
            for (int i = 0; i < editTradePartnersListView.Items.Count; i++)
            {
                partners.Add(editTradePartnersListView.Items[i].SubItems[0].Text);
            }

            newObjectToAdd.TradePartners = partners.ToArray<string>();

            bool itemExists = false;

            if ((countryTree.FindItemByName(newObjectToAdd.CountryName)) != null)
                itemExists = true;

            if (itemExists)
            {
                countryTree.RemoveItemByName(newObjectToAdd.CountryName);
                countryTree.InsertItem(newObjectToAdd);
            }
            else if (itemExists == false)
            {
                MessageBox.Show("Do you want to add the item: " + valueCountryName, "Important Question", MessageBoxButtons.YesNo);
            }

            //TODO VALIDATION!!!!!!

        }

        private void btnAddTradePartner_Click(object sender, EventArgs e) //TODO FIGURE A DECENT MECHANISM TO SELECT TRADE PARTNERS WHEN ADDING...
        {
            if (countriesListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem i in countriesListView.SelectedItems)
                {
                    string tradePartner = i.Text;

                    Country tempTradePartner = countryTree.FindItemByName(tradePartner);

                    string[] row = { tempTradePartner.CountryName, tempTradePartner.GDPGrowth.ToString(), tempTradePartner.Inflation.ToString(), tempTradePartner.TradeBalance.ToString(), tempTradePartner.HDIRanking.ToString() };

                    ListViewItem tmpItem = new ListViewItem(row);

                    editTradePartnersListView.Items.Add(tmpItem);
                }
            }
            else
                MessageBox.Show("Please choose a country from the main list (left).", "Choose");
        }

        private void countriesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            populateEditCountry();
            //populateTradePartnersListView();
        }

        private void btnRemoveTradePartner_Click(object sender, EventArgs e)
        {
            editTradePartnersListView.Items.Remove(editTradePartnersListView.SelectedItems[0]);
        }
    }
}
