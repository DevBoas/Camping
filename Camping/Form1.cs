using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Camping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ///int sdays = 0;
        ///int odays = 0;
        private Decimal checkSeason(Decimal prijs, DateTime startDate, DateTime endDate, DateTime currentDate)
        {
            if (currentDate == endDate)
                return prijs;

            DateTime seasonStart = new DateTime(DateTime.Now.Year, 7, 11);
            DateTime seasonEnd = new DateTime(DateTime.Now.Year, 8, 16); //15
            Decimal inSeason = 30 + prijs;
            Decimal outSeason = 25 + prijs;

            if (currentDate >= seasonStart && currentDate < seasonEnd)
            {
                prijs += inSeason;
                ///sdays++;
                ///MessageBox.Show("Days in season " + sdays.ToString());
            }
            else
            {
                ///odays++;
                prijs += outSeason;
                ///MessageBox.Show("Days out of season " + odays.ToString());
            }
            return checkSeason(prijs, startDate, endDate, currentDate.AddDays(1));
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            Decimal prijs = 0;
            int meter = 0;
            int personen = 0;
            Int32.TryParse(TextBoxMeter.Text, out meter);
            if (Int32.TryParse(TextBoxPersonen.Text, out personen))
                prijs += personen * 5;
            if (meter < 10)
            {
                prijs = prijs - ((10 - meter) * 2);
            }
            else
                prijs = prijs + ((meter - 10) * 3);
            
            if (CheckBoxHond.Checked)
                prijs += 4;
            if (CheckBoxAutoTent.Checked)
                prijs += 6;
            prijs = checkSeason(prijs, DateTimeVan.Value, DateTimeTot.Value, DateTimeVan.Value);
            Output.Text = "Tarief = €" + prijs.ToString();
            //MessageBox.Show(prijs.ToString());
        }
    }
}
