using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    //File.WriteAllLines(fileName, listSzovegek.Items.Cast<string>().ToArray());

                    using (var sw = new StreamWriter(fileName))
                    {
                        if (ferfi.Checked)
                        {
                            sw.Write(nevBox.Text + ";" + szulDatumBox.Text + ";" + ferfi.Text + ";");
                        }
                        else if (no.Checked)
                        {
                            sw.Write(nevBox.Text + ";" + szulDatumBox.Text + ";" + no.Text + ";");
                        }
                        foreach (var item in listSzovegek.Items)
                        {                    
                            sw.Write(item+";");
                        }
                        sw.WriteLine();
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült a kiírás.");
                }
            };

            openFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);
                    List<string> lista = new List<string>();
                    listSzovegek.Items.Clear();
                    nevBox.Clear();
                    szulDatumBox.Clear();
                    foreach (var item in sorok)
                    {
                        string[] words = item.Split(';');
                        foreach (var word in words)
                        {
                            nevBox.Text += word[0];
                            szulDatumBox.Text += word[1];
                            if (word[2].Equals("F"))
                            {
                                ferfi.Checked = true;
                            }
                            else if (word[2].Equals("N"))
                            {
                                no.Checked = true;
                            }
                            //listSzovegek.Text += word[3];
                            listSzovegek.Items.Add(word[3]);
                        }
                        
                    }/*
                    string fileName = openFileDialog1.FileName;
                    string path = openFileDialog1.InitialDirectory = @"C:\Users\Diak\Desktop\"+fileName;*/

                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült a beolvasás.");
                }
            };
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            listSzovegek.Items.Add(hozzaadTxt.Text);
            hozzaadTxt.Text = "";
        }

        private void btnMent_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //openFileDialog1.InitialDirectory = @"C:\Users\Diak\Desktop";


        }
    }
}
