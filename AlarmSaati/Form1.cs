namespace AlarmSaati
{
    public partial class Form1 : Form
    {
        int saat = 0, dakika = 0, saniye = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1baslat_Click(object sender, EventArgs e)
        {
            saat = (int)numericUpDownsaat.Value;
            dakika = (int)numericUpDowndakika.Value;
            saniye = (int)numericUpDownsaniye.Value;
            timerzaman.Interval = 1000; // Timer'ý saniye bazýnda ayarla
            timerzaman.Start();
        }

        private void timerzaman_Tick(object sender, EventArgs e)
        {
            if (saniye == 0 && dakika == 0 && saat == 0) // Saat, dakika ve saniye deðerlerinin hepsi 0 olduðunda alarmý durdur
            {
                timerzaman.Stop();
                MessageBox.Show("Alarm Bitti");
                return;
            }

            if (saniye == 0)
            {
                if (dakika == 0)
                {
                    if (saat > 0)
                    {
                        saat--;
                        dakika = 59;
                    }
                }
                else
                {
                    dakika--;
                }
                saniye = 59;
            }
            else
            {
                saniye--;
            }

            labelzaman.Text = string.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);
        }

        private void button1dur_Click(object sender, EventArgs e)
        {
            timerzaman.Stop();
            saat = 0; dakika = 0; saniye = 0;
            labelzaman.Text = string.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);
        }
    }
}
