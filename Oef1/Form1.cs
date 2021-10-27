using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace Oef1
{
    public partial class Task_manager : Form
    {

        public delegate void Tonen(object rij);

        public Task_manager()
        {
            InitializeComponent();
            inputDate.Visible = false;
        }

        private List<System.Timers.Timer> Timerlist = new List<System.Timers.Timer>();
        private Rij<TeDoen> rij = new Rij<TeDoen>();
        private List<TeDoen> rememberObjects = new List<TeDoen>();
        private List<DateTime> lijstDates = new List<DateTime>();

        public int Wacht()
        {
            TimeSpan wachttijd = inputDate.Value - DateTime.Now;
            System.Threading.Thread.Sleep((int)wachttijd.TotalMinutes);
            return (int)wachttijd.TotalMilliseconds;
        }


        private void OpslaanTaak_Click(object sender, System.EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                if (inputDate.Value > DateTime.Now)
                {

                    rememberObjects.Add(new TeDoen(inputDate.Value, inputTitle.Text, textBox1.Lines));
                    lijstDates.Add(inputDate.Value);
                    StartTimer();
                    inputTitle.Text = null;
                    textBox1.Text = null;

                }
                else
                {
                    MessageBox.Show(" dit is in het verleten ! begin opnieuw");
                }
            }
            else
            {
                rij.InDeRij(new TeDoen(inputTitle.Text, textBox1.Lines));
                inputTitle.Text = null;
                textBox1.Text = null;

            }

            //reset of all elements after create 
            inputDate.Value = DateTime.Now;

        }

        public void StartTimer()
        {
            System.Timers.Timer Localtimer = new System.Timers.Timer(Wacht());
            Localtimer.Elapsed += label5_Tick;
            Localtimer.AutoReset = false;
            Localtimer.Start();
            Timerlist.Add(Localtimer);
        }

        private void label5_Tick(object sender, EventArgs e)
        {
            foreach (DateTime date in lijstDates)
            {
                if (date <= DateTime.Now)
                {
                    rij.WhenShow(rememberObjects[lijstDates.IndexOf(date)]);

                    rememberObjects.RemoveAt(lijstDates.IndexOf(date));
                    lijstDates.RemoveAt(lijstDates.IndexOf(date));

                }

            }
        }


        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                inputDate.Visible = true;
            }
            else
            {
                inputDate.Visible = false;
            }

        }

        private void volgendeTaak_Click(object sender, EventArgs e)
        {
             rij.Toon();

        
        }

        private void ZetAchteraan_Click(object sender, EventArgs e)
        {
            rij.ZetAchteraan();
            
        }


        private void verwijderTaak_Click(object sender, EventArgs e)
        {

            rij.UitDeRij();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (button2.Text == "ON")
            {
                button2.Text = "OFF";
                button2.BackColor = Color.Red;
                rij.tonen -= new Tonen(show_MessageBox);
            }
            else
            {
                button2.Text = "ON";
                button2.BackColor = Color.Green;
                rij.tonen += new Tonen(show_MessageBox);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "ON")
            {
                button1.Text = "OFF";
                button1.BackColor = Color.Red;
                inputInhoud.Text = null;
                rij.tonen -= new Tonen(show_textvenster);
            }
            else
            {
                button1.Text = "ON";
                button1.BackColor = Color.Green;
                rij.tonen += new Tonen(show_textvenster);
            }


        }

        private void show_textvenster(object lijst)
        {

            inputInhoud.Text = lijst.ToString();

        }


        private void show_MessageBox(object lijst)
        {

            MessageBox.Show(lijst.ToString());

        }

    }
}
