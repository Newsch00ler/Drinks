using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks
{
    public partial class Form1 : Form
    {
        List<Drinks> drinksList = new List<Drinks>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0: // если 0, то сок
                        this.drinksList.Add(new Juice());
                        break;
                    case 1: // если 1 то газировка
                        this.drinksList.Add(new Soda());
                        break;
                    case 2: // если 2 то алко
                        this.drinksList.Add(new Alcohol());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoCount = 0;

            foreach (var drink in this.drinksList)
            {
                if (drink is Juice)
                {
                    juiceCount += 1;
                }
                else if (drink is Soda)
                {
                    sodaCount += 1;
                }
                else if (drink is Alcohol)
                {
                    alcoCount += 1;
                }
            }

            textInfo.Text = "Сок\tГазировка\tАлкоголь";
            textInfo.Text += "\n";
            textInfo.Text += String.Format("{0}\t{1}\t\t{2}", juiceCount, sodaCount, alcoCount);
        }
    }
}
