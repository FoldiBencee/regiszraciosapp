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

namespace foldibBeadndoj
{
    public partial class Form1 : Form
    {
        string nemek = "";
       
        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(fileName);
                    if (radioButton1.Checked)
                    {
                        sw.WriteLine(textBox1.Text+","+textBox2.Text +","+ "ferfi ," + listBox1.SelectedItem);
                    }
                    else
                    {
                        sw.WriteLine(textBox1.Text +","+textBox2.Text +","+ "no ,"+ listBox1.SelectedItem);
                    }
                    sw.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Hibha. nem siekrult a kiiras");
                }
            };
            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    string fileName = openFileDialog1.FileName;
                    StreamReader sr = new StreamReader(fileName);
                    string sorocskak = sr.ReadLine();
                    string[] tomb = sorocskak.Split(',');
                    textBox1.Text = tomb[0];
                    textBox2.Text = tomb[1];
                    if (nemek.Contains("ferfi"))
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    listBox1.SelectedItem = tomb[3];
                    sr.Close();

                    

                }
                catch (IOException)
                {
                    MessageBox.Show("hibaa siokertelen betoltes");
                }
            };

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox3.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
