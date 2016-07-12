using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mii_Plaza_Editor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static string filepath = "";

        private void Form3_Load(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "mgBtl0.dat|mgBtl0.dat|Data files (*.dat)|*.dat|All files (*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = file.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            filepath = file.InitialDirectory + file.FileName;
                            //tabControl2.Enabled = true;
                            //Form1 frm = new Form1();
                            //frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                            //frm.Hide();
                            MessageBox.Show("This tool will AUTO-SAVE the file when you press UNLOCK or EDIT SAVE.\n\nMake sure to BACK-UP the file before editing.", "Auto-Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            else
            {
                this.Close();
                //Form1 frm = new Form1();
                //frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                //frm.Show();
                //this.Close();
            }

        }

        private void EditValues(int offset, int streetpasstags)
        {
            using (var fs = new FileStream(filepath,
                FileMode.Open,
                FileAccess.ReadWrite))
            {
                int length = (offset+2) - offset + 1;
                byte[] replace = new byte[length];

                //int streetpasstags = Int32.Parse(textBox1.Text);
                if (streetpasstags > 0xFFFFFF) streetpasstags = 0xFFFFFF;
                replace[2] = Convert.ToByte((streetpasstags / 256) / 256);
                replace[1] = Convert.ToByte((streetpasstags / 256) % 256);
                replace[0] = Convert.ToByte((streetpasstags % 256) % 256);

                fs.Position = offset;
                fs.Write(replace, 0, length);
            }
        }

        private void EditValues2(int offset, int until)
        {
            using (var fs = new FileStream(filepath,
                  FileMode.Open,
                  FileAccess.ReadWrite))
            {
                int length = until - offset + 1;
                byte[] replace = new byte[length];

                for (int x = 0; x < length; x++)
                {
                    replace[x] = 0x00;
                }

                fs.Position = offset;
                fs.Write(replace, 0, length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditValues(0x00034, Convert.ToInt32(textBox1.Text));
            EditValues2(0x00028, 0x0002A);
            EditValues2(0x00040, 0x00042);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditValues(0x00B28, Convert.ToInt32(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditValues(0x00B2C, Convert.ToInt32(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditValues(0x00B30, Convert.ToInt32(textBox4.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditValues(0x00B34, Convert.ToInt32(textBox5.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditValues(0x00B3C, Convert.ToInt32(textBox6.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EditValues(0x00B74, Convert.ToInt32(textBox7.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime Date = dateTimePicker1.Value;
            DateTime FirstCount = new DateTime(2000, 1, 1);
            TimeSpan ts = Date - FirstCount;
            int Days = Convert.ToInt32(ts.TotalDays);
            //MessageBox.Show(Convert.ToString(Days));
            EditValues(0x00B40, Days);
        }
    }
}
