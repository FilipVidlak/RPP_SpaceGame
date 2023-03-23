using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace SpaceInvadors_rocnikovyprojekt
{
    public partial class Vesmir : Form
    {
        private SoundPlayer soundtrack;
        private SoundPlayer exploze;
        private PictureBox[] hvezdy;
        private PictureBox[] neprlode;
        private PictureBox[] neprmun;
        private PictureBox[] municehrace;
        private Random rnd;

        private int rychlostpozadi;
        private int rychlostneprmun;
        private int rychlostneprlode;
        private int rychlostvesmirnelodi;
        private int rychlostmunhrace;
        private int skore;
        private int uroven;
        private int obtiznost;
        private int pocetzmacknuti;
        private int pocetstisknutiklaves;

        private bool pauza;
        private bool konechry;

        public Vesmir()
        {
            InitializeComponent();
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Konechry(string text)
        {
            if (text == "KONEC HRY")
            {
                exploze.Play();
                label5.Location = new Point(145, 50);
                label5.Text = text.ToUpper();
                label5.Visible = true;
                konechry = true;
                pauza = true;
                Restart_button.Visible = true;
                Exit_button.Visible = true;
                StopTimers();
            }
            else
            {
                soundtrack.Stop();
                label5.Location = new Point(145, 50);
                label5.Text = text.ToUpper();
                label5.Visible = true;
                konechry = true;
                pauza = true;
                Restart_button.Visible = true;
                Exit_button.Visible = true;
                StopTimers();
            }
        }
        private void Zvuky()
        {
            soundtrack = new SoundPlayer("../../sounds/soundtrack.wav");
            exploze = new SoundPlayer("../../sounds/exploze.wav");
            soundtrack.PlayLooping();
        }
        private void InicializacePictureBoxu()
        {
            neprlode = new PictureBox[10];
            neprmun = new PictureBox[10];
            municehrace = new PictureBox[3];
            hvezdy = new PictureBox[8];
        }
        private void InicializacePozadi()
        {
            for (int i = 0; i < hvezdy.Length; i++)
            {
                hvezdy[i] = new PictureBox
                {
                    BorderStyle = BorderStyle.None
                };
                int sirka = rnd.Next(20, 580);
                int vyska = rnd.Next(-10, 400);
                hvezdy[i].Location = new Point(sirka, vyska);
                if (i % 2 == 0)
                {
                    hvezdy[i].Size = new Size(3, 3);
                    hvezdy[i].BackColor = Color.WhiteSmoke;
                }
                else
                {
                    hvezdy[i].Size = new Size(4, 4);
                    hvezdy[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(hvezdy[i]);
            }
        }

        private void InicializaceNepratel()
        {
            for (int i = 0; i < neprlode.Length; i++)
            {
                neprlode[i] = new PictureBox
                {
                    Size = new Size(54, 54),
                    Visible = true,
                    Location = new Point((i + 1) * 50, -50)
                };
                this.Controls.Add(neprlode[i]);
            }
            Image neprlode_1 = Image.FromFile(@"../../images/neprlod_1.png");
            Image neprlode_2 = Image.FromFile(@"../../images/neprlod_2.png");
            Image neprlode_3 = Image.FromFile(@"../../images/neprlod_3.png");
            Image boss = Image.FromFile(@"../../images/boss.png");
            neprlode[0].Image = boss;
            neprlode[1].Image = neprlode_2;
            neprlode[2].Image = neprlode_3;
            neprlode[3].Image = neprlode_3;
            neprlode[4].Image = neprlode_1;
            neprlode[5].Image = neprlode_3;
            neprlode[6].Image = neprlode_2;
            neprlode[7].Image = neprlode_3;
            neprlode[8].Image = neprlode_2;
            neprlode[9].Image = boss;
        }

        private void InicializaceMunNepratel()
        {
            for (int i = 0; i < neprmun.Length; i++)
            {
                neprmun[i] = new PictureBox
                {
                    Size = new Size(2, 20),
                    BackColor = Color.Red,
                    Visible = true
                };
                int random = rnd.Next(0, 10);
                neprmun[i].Location = new Point(neprlode[random].Location.X, neprlode[random].Location.Y - 15);
                this.Controls.Add(neprmun[i]);
            }
        }

        private void InicializaceMunHrace()
        {
            for (int i = 0; i < municehrace.Length; i++)
            {
                municehrace[i] = new PictureBox
                {
                    Size = new Size(6, 6),
                    BackColor = Color.Gold,
                    Visible = true,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.None
                };
                this.Controls.Add(municehrace[i]);
            }
        }

        private void Vesmir_Load(object sender, EventArgs e)
        {
            try
            {
                rnd = new Random();

                InicializacePictureBoxu();

                InicializacePozadi();

                InicializaceNepratel();

                InicializaceMunNepratel();

                InicializaceMunHrace();

                Zvuky();

                rychlostpozadi = 5;
                rychlostneprmun = 4;
                rychlostneprlode = 4;
                rychlostvesmirnelodi = 6;
                rychlostmunhrace = 15;
                skore = 0;
                uroven = 1;
                obtiznost = 10;
                pocetzmacknuti = 0;
                pocetstisknutiklaves = 0;

                label5.Visible = false;
                Restart_button.Visible = false;
                Exit_button.Visible = false;
                pauza = false;
                konechry = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nastala tato chyba: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Background_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < hvezdy.Length / 2; i++)
            {
                hvezdy[i].Top += rychlostpozadi;
                if (hvezdy[i].Top >= this.Height)
                {
                    hvezdy[i].Top = -hvezdy[i].Height;
                }
            }

            for (int i = hvezdy.Length / 2; i < hvezdy.Length; i++)
            {
                hvezdy[i].Top += rychlostpozadi - 2;
                if (hvezdy[i].Top >= this.Height)
                {
                    hvezdy[i].Top = -hvezdy[i].Height;
                }
            }
        }

        private void Neprmun_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (neprmun.Length - obtiznost); i++)
            {
                if (neprmun[i].Top < this.Height)
                {
                    neprmun[i].Visible = true;
                    neprmun[i].Top += rychlostneprmun;
                    Zasahneprlodi();
                }
                else
                {
                    neprmun[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    neprmun[i].Location = new Point(neprlode[x].Location.X + 27, neprlode[x].Location.Y + 30);
                }
            }
        }

        private void Neprlode_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < neprlode.Length; i++)
            {
                neprlode[i].Visible = true;
                neprlode[i].Top += rychlostneprlode;

                if (neprlode[i].Top > this.Height)
                {
                    neprlode[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void Municehrace_timer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < municehrace.Length; i++)
            {
                if (municehrace[i].Top > 0)
                {
                    municehrace[i].Visible = true;
                    municehrace[i].Top -= rychlostmunhrace;
                    Zasahvesmirnoulodi();
                }
                else
                {
                    municehrace[i].Visible = false;
                    municehrace[i].Location = new Point(Vesmirnalod.Location.X + 20, Vesmirnalod.Location.Y - i * 30);
                }
            }
        }

        private void Vesmir_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pauza)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    Pohybdoprava_timer.Stop();
                    Pohybdolu_timer.Stop();
                    Pohybdoleva_timer.Stop();
                    Pohybnahoru_timer.Start();
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    Pohybdoprava_timer.Stop();
                    Pohybnahoru_timer.Stop();
                    Pohybdoleva_timer.Stop();
                    Pohybdolu_timer.Start();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    Pohybdoprava_timer.Stop();
                    Pohybdolu_timer.Stop();
                    Pohybnahoru_timer.Stop();
                    Pohybdoleva_timer.Start();
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    Pohybnahoru_timer.Stop();
                    Pohybdolu_timer.Stop();
                    Pohybdoleva_timer.Stop();
                    Pohybdoprava_timer.Start();
                }
            }
        }

        private void Vesmir_KeyUp(object sender, KeyEventArgs e)
        {
            Pohybnahoru_timer.Stop();
            Pohybdolu_timer.Stop();
            Pohybdoleva_timer.Stop();
            Pohybdoprava_timer.Stop();
            if (e.KeyCode == Keys.P)
            {
                pocetzmacknuti++;
                if (!konechry && !pauza)
                {
                    label5.Location = new Point(50, 150);
                    label5.Text = "PAUZA";
                    label5.Visible = true;
                    soundtrack.Play();
                    StopTimers();
                    pauza = true;
                }
                if(pocetzmacknuti % 2 == 0 && pauza)
                {
                    StartTimers();
                    label5.Visible = false;
                    soundtrack.Play();
                    pauza = false;

                }
            }
        }

        private void StartTimers()
        {
            Background_timer.Start();
            Neprlode_timer.Start();
            Municehrace_timer.Start();
            Neprmun_timer.Start();
        }

        private void StopTimers()
        {
            Background_timer.Stop();
            Neprlode_timer.Stop();
            Municehrace_timer.Stop();
            Neprmun_timer.Stop();
        }

        private void Pohybdoleva_timer_Tick(object sender, EventArgs e)
        {
            if (Vesmirnalod.Left > 10)
            {
                Vesmirnalod.Left -= rychlostvesmirnelodi;
            }
        }

        private void Pohybdoprava_timer_Tick(object sender, EventArgs e)
        {
            if (Vesmirnalod.Right < 580)
            {

                Vesmirnalod.Left += rychlostvesmirnelodi;
            }
        }

        private void Pohybdolu_timer_Tick(object sender, EventArgs e)
        {
            if (Vesmirnalod.Top < 380)
            {
                Vesmirnalod.Top += rychlostvesmirnelodi;

            }
        }

        private void Pohybnahoru_timer_Tick(object sender, EventArgs e)
        {
            if (Vesmirnalod.Top > 5)
            {
                Vesmirnalod.Top -= rychlostvesmirnelodi;

            }
        }

        private void Zasahneprlodi()
        {
            for (int i = 0; i < neprmun.Length; i++)
            {
                if (neprmun[i].Bounds.IntersectsWith(Vesmirnalod.Bounds))
                {
                    neprmun[i].Visible = false;
                    Vesmirnalod.Visible = false;
                    Konechry("KONEC HRY");
                }
            }
        }

        private void Zasahvesmirnoulodi()
        {
            for (int i = 0; i < neprlode.Length; i++)
            {
                if (municehrace[0].Bounds.IntersectsWith(neprlode[i].Bounds)
                    || municehrace[1].Bounds.IntersectsWith(neprlode[i].Bounds)
                    || municehrace[2].Bounds.IntersectsWith(neprlode[i].Bounds))
                {
                    skore += 1;
                    if (skore < 10)
                    { label3.Text = "0" + skore.ToString(); }
                    else { label3.Text = skore.ToString(); }
                    if (skore % 20 == 0)
                    {
                        uroven += 1;
                        if (uroven < 10)
                        { label1.Text = "0" + uroven.ToString(); }
                        else { label1.Text = uroven.ToString(); }

                        if (rychlostneprlode <= 11 && rychlostneprmun <= 11 && obtiznost > 0)
                        {
                            obtiznost--;
                            rychlostneprlode++;
                            rychlostneprmun++;
                        }

                        if (uroven == 10)
                        {
                            Konechry("ZVLÁDLI JSTE \nSKORO NEMOŽNÉ!");
                        }
                    }
                    neprlode[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Vesmirnalod.Bounds.IntersectsWith(neprlode[i].Bounds))
                {
                    Vesmirnalod.Visible = false;
                    neprlode[i].Visible = false;
                    Konechry("KONEC HRY");
                }
            }
        }
    }
}
