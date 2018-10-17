using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace cashRegisterCarterC
{
    public partial class Form1 : Form
    {
        double burgers, fries, drink, subtotal, tax, total, tendered, change;

        const double BURGERCOST = 2.49, FRIESCOST = 1.89, DRINKCOST = 0.99, TAX = 0.13;

        SoundPlayer player = new SoundPlayer(Properties.Resources.Printer);

        Graphics g;
        Pen drawPen = new Pen(Color.Black, 2);
        SolidBrush drawBrush = new SolidBrush(Color.Black);


        private void calcButton_Click(object sender, EventArgs e)
        {
            burgers = Convert.ToInt16(numBurgers.Text);
            fries = Convert.ToInt16(numFries.Text);
            drink = Convert.ToInt16(numDrinks.Text);

            subtotal = (burgers * BURGERCOST) + (fries * FRIESCOST) + (drink * DRINKCOST);
            tax = subtotal * TAX;
            total = subtotal + tax;

            totalLabel.Text = "Subtotal:   " + subtotal.ToString("C") + "\n Tax:   " + tax.ToString("C") + "\n Total:   " + total.ToString("C");

        }

        private void calcChange_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToInt16(tenderText.Text);

            change = tendered - total;

            changelabel.Text = "Change:   " + change.ToString("C");
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
           


            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            Font drawFont2 = new Font("Consolas", 12, FontStyle.Bold);


            g.DrawRectangle(drawPen, 300, 100, 200, 400);

            player.Play();
            Thread.Sleep(500);

            g.DrawString("Burgies Ferda", drawFont, drawBrush, 325, 125);
            Thread.Sleep(500);

            g.DrawString("Hamburgers x" + burgers + " @ " + BURGERCOST.ToString("C"), drawFont2, drawBrush, 300, 155);
            Thread.Sleep(500);
            g.DrawString("Fries      x" + fries + " @ " + FRIESCOST.ToString("C"), drawFont2, drawBrush, 300, 175);
            Thread.Sleep(500);
            g.DrawString("Drinks     x" + drink + " @ " + DRINKCOST.ToString("C"), drawFont2, drawBrush, 300, 200);
            Thread.Sleep(500);

            g.DrawString("Subtotal       " + subtotal.ToString("C"), drawFont2, drawBrush, 300, 300);
            Thread.Sleep(500);
            g.DrawString("Tax            " + tax.ToString("C"), drawFont2, drawBrush, 300, 325);
            Thread.Sleep(500);
            g.DrawString("Total          " + total.ToString("C"), drawFont2, drawBrush, 300, 350);
            Thread.Sleep(500);

            g.DrawString("Tendered       " + tendered.ToString("C"), drawFont2, drawBrush, 300, 400);
            Thread.Sleep(500);
            g.DrawString("Change         " + change.ToString("C"), drawFont2, drawBrush, 300, 425);
         }

        private void newbutton_Click(object sender, EventArgs e)
        {
            numBurgers.Text = "";
            numDrinks.Text = "";
            numFries.Text = "";
            tenderText.Text = "";

            burgers = 0;
            fries = 0;
            drink = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
            tendered = 0;
            change = 0;

            totalLabel.Text = "";
            changelabel.Text = "";

            Refresh();
        }




        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
    }
}
