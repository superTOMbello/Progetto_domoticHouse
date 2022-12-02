using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Server_DomoticHouse
{
    public partial class Form1 : Form
    {
        private bool serverAttivo = false;

        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        string risposta;

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "NON CONNESSO";
            pictureBox1.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceOFF.png");
            pictureBox2.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceOFF.png");
            pictureBox13.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceOFF.png");
            pictureBox3.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\auto_chiusa.png");
            pictureBox5.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\TV_spenta.png");
            pictureBox6.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\allarme_spento.png");
            pictureBox7.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\lavatrice_spenta.png");
            pictureBox8.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\sfondo.png");
            pictureBox9.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\termostato_spento.png");
            pictureBox10.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\kappa_Spenta.png");
            pictureBox11.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\forno_spento.png");
            pictureBox12.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\frigo_spento.png");
            pictureBox14.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luce_esterna_spenta.png");
            pictureBox15.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luce_esterna_spenta.png");
        }

        private void btn_Avvio_Click(object sender, EventArgs e)
        {
            this.serverAttivo = true;
            byte[] bytes = new Byte[1024];

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            label5.Text = "CONNESSIONE IN CORSO...";
            label5.Refresh();

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                r.Next(1, 11);

                if (r.Equals(3) && r.Equals(7) && r.Equals(9))
                {
                    risposta = "ok";
                    pictureBox8.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\wifi.png");
                    pictureBox8.Refresh();
                }
                else
                {
                    risposta = "ko";
                    label5.Text = "ERRORE DI CONNESSIONE";
                    pictureBox8.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\sfondo.png");
                    pictureBox8.Refresh();
                }

                //risposta = "ko";

                while (this.serverAttivo && risposta.Equals("ok"))
                {
                    label5.Text = "CONNESSIONE EFFETTUATA";
                    label5.Refresh();
                    //pictureBox8.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\wifi.png");
                    //pictureBox8.Refresh();
                    Socket handler = listener.Accept();
                    string data = null;

                    int bytesRec = handler.Receive(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                         if (data.Equals("LUCE_CAMERA_ON"))
                    {
                        //label1.Text = "LUCE CAMERA ACCESA";
                        //label1.Refresh();
                        pictureBox1.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceON.png");
                        pictureBox1.Refresh();
                    }
                    else if (data.Equals("LUCE_CAMERA_OFF"))
                    {
                        //label1.Text = "LUCE CAMERA SPENTA";
                        //label1.Refresh();
                        pictureBox1.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceOFF.png");
                        pictureBox1.Refresh();
                    }
                    else if (data.Equals("TV_ON"))
                    {
                        //label2.Text = "LUCE SALA ACCESA";
                        //label2.Refresh();
                        pictureBox5.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\TV.png");
                        pictureBox5.Refresh();
                    }
                    else if (data.Equals("TV_OFF"))
                    {
                       //label2.Text = "LUCE SALA SPENTA";
                        //label2.Refresh();
                        pictureBox5.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\TV_spenta.png");
                        pictureBox5.Refresh();
                    }
                    else if (data.Equals("LUCE_LAVANDERIA_ON"))
                    {
                       //label3.Text = "LUCE CAMERA MATRIMONIALE ACCESA";
                       //label3.Refresh();
                        pictureBox2.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceON.png");
                        pictureBox2.Refresh();
                    }
                    else if (data.Equals("LUCE_LAVANDERIA_OFF"))
                    {
                        //label3.Text = "LUCE CAMERA MATRIMONIALE SPENTA";
                        //label3.Refresh();
                        pictureBox2.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceOFF.png");
                        pictureBox2.Refresh();
                    }
                    else if (data.Equals("LUCE_SALA_ON"))
                    {
                        //label3.Text = "LUCE CAMERA MATRIMONIALE ACCESA";
                        //label3.Refresh();
                        pictureBox13.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceON.png");
                        pictureBox13.Refresh();
                    }
                    else if (data.Equals("LUCE_SALA_OFF"))
                    {
                        //label3.Text = "LUCE CAMERA MATRIMONIALE SPENTA";
                        //label3.Refresh();
                        pictureBox13.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luceOFF.png");
                        pictureBox13.Refresh();
                    }
                    else if (data.Equals("LAVATRICE_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox7.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\lavatrice.png");
                        pictureBox7.Refresh();
                    }
                    else if (data.Equals("LAVATRICE_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox7.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\lavatrice_spenta.png");
                        pictureBox7.Refresh();
                    }
                    else if (data.Equals("AUTO_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox3.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\auto.png");
                        pictureBox3.Refresh();
                    }
                    else if (data.Equals("AUTO_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox3.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\auto_chiusa.png");
                        pictureBox3.Refresh();
                    }
                    else if (data.Equals("FORNO_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox11.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\forno.png");
                        pictureBox11.Refresh();
                    }
                    else if (data.Equals("FORNO_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox11.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\forno_spento.png");
                        pictureBox11.Refresh();
                    }
                    else if (data.Equals("FRIGO_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox12.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\frigo.png");
                        pictureBox12.Refresh();
                    }
                    else if (data.Equals("FRIGO_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox12.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\lfrigo_spento.png");
                        pictureBox12.Refresh();
                    }
                    else if (data.Equals("ALLARME_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox6.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\allarme.png");
                        pictureBox6.Refresh();
                    }
                    else if (data.Equals("ALLARME_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox6.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\allarme_spento.png");
                        pictureBox6.Refresh();
                    }
                    else if (data.Equals("TERMOSTATO_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox9.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\termostato.png");
                        pictureBox9.Refresh();
                    }
                    else if (data.Equals("TERMOSTATO_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox9.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\termostato_spento.png");
                        pictureBox9.Refresh();
                    }
                    else if (data.Equals("CAPPA_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox10.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\kappa.png");
                        pictureBox10.Refresh();
                    }
                    else if (data.Equals("CAPPA_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox10.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\kappa_spenta.png");
                        pictureBox10.Refresh();
                    }
                    else if (data.Equals("LUCE_ESTERNA_ON"))
                    {
                        //label4.Text = "LUCE BAGNO ACCESA";
                        //label4.Refresh();
                        pictureBox14.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luce_esterna.png");
                        pictureBox14.Refresh();
                        pictureBox15.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luce_esterna.png");
                        pictureBox15.Refresh();
                    }
                    else if (data.Equals("LUCE_ESTERNA_OFF"))
                    {
                        //label4.Text = "LUCE BAGNO SPENTA";
                        //label4.Refresh();
                        pictureBox14.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luce_esterna_spenta.png");
                        pictureBox14.Refresh();
                        pictureBox15.Image = Image.FromFile(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\luce_esterna_spenta.png");
                        pictureBox15.Refresh();
                    }
                    else if (data.Equals(" "))
                    {

                    }
                    else if (data.Equals(" "))
                    {

                    }
                    else
                    {
                        risposta = "CODICE SCONOSCIUTO";
                    }

                    byte[] msg = Encoding.ASCII.GetBytes(risposta);
                    handler.Send(msg);
                    Console.WriteLine("Messaggio inviato");
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.ToString());
            }
        }

        private void btn_ferma_Click(object sender, EventArgs e)
        {
            this.serverAttivo = false;

            pictureBox8.Load(@"C:\\Archivio\\Paleocapa\\T e P\\C#\\Progetto casa domotica\\immagini\\sfondo.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
