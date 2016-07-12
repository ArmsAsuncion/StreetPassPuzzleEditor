using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Mii_Plaza_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string filepath = "";

        private void EditValues(int offset, int until)
        {

            using (var fs = new FileStream(filepath,
                  FileMode.Open,
                  FileAccess.ReadWrite))
            {
                int length = until - offset + 1;
                byte[] replace = new byte[length];
                //byte[] replace = {0x00, 0x00, 0x00 };

                for (int x = 0; x < length; x++)
                {
                    replace[x] = 0xFF;
                }

                int value1 = 0, value2 = 0, value3 = 0, value4 = 0, value5 = 0;
                if (checkBox1.Checked) value1 = value1 + 0x80;
                if (checkBox2.Checked) value1 = value1 + 0x40;
                if (checkBox3.Checked) value1 = value1 + 0x20;
                if (checkBox4.Checked) value1 = value1 + 0x10;
                if (checkBox5.Checked) value1 = value1 + 0x08;
                if (checkBox6.Checked) value1 = value1 + 0x04;
                if (checkBox7.Checked) value1 = value1 + 0x02;
                if (checkBox8.Checked) value1 = value1 + 0x01;

                if (checkBox9.Checked) value2 = value2 + 0x80;
                if (checkBox10.Checked) value2 = value2 + 0x40;
                if (checkBox11.Checked) value2 = value2 + 0x20;
                if (checkBox12.Checked) value2 = value2 + 0x10;
                if (checkBox13.Checked) value2 = value2 + 0x08;
                if (checkBox14.Checked) value2 = value2 + 0x04;
                if (checkBox15.Checked) value2 = value2 + 0x02;
                if (checkBox16.Checked && length != 2) value2 = value2 + 0x01;

                if (checkBox17.Checked) value3 = value3 + 0x80;
                if (checkBox18.Checked) value3 = value3 + 0x40;
                if (checkBox19.Checked) value3 = value3 + 0x20;
                if (checkBox20.Checked) value3 = value3 + 0x10;
                if (checkBox21.Checked) value3 = value3 + 0x08;
                if (checkBox22.Checked) value3 = value3 + 0x04;
                if (checkBox23.Checked) value3 = value3 + 0x02;
                if (checkBox24.Checked) value3 = value3 + 0x01;

                if (checkBox25.Checked) value4 = value4 + 0x80;
                if (checkBox26.Checked) value4 = value4 + 0x40;
                if (checkBox27.Checked) value4 = value4 + 0x20;
                if (checkBox28.Checked) value4 = value4 + 0x10;
                if (checkBox29.Checked) value4 = value4 + 0x08;
                if (checkBox30.Checked) value4 = value4 + 0x04;
                if (checkBox31.Checked) value4 = value4 + 0x02;
                if (checkBox32.Checked) value4 = value4 + 0x01;

                if (checkBox33.Checked) value5 = value5 + 0x80;
                if (checkBox34.Checked) value5 = value5 + 0x40;
                if (checkBox35.Checked) value5 = value5 + 0x20;
                if (checkBox36.Checked) value5 = value5 + 0x10;
                if (checkBox37.Checked) value5 = value5 + 0x08;
                if (checkBox38.Checked) value5 = value5 + 0x04;
                if (checkBox39.Checked) value5 = value5 + 0x02;
                if (checkBox40.Checked) value5 = value5 + 0x01;

                replace[0] = Convert.ToByte(value1);
                replace[1] = Convert.ToByte(value2);
                if (length > 2)
                    replace[2] = Convert.ToByte(value3);
                if (length > 3)
                    replace[3] = Convert.ToByte(value4);
                if (length > 4)
                    replace[4] = Convert.ToByte(value5);
               

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

        private void EditValuesFF(int offset, int until)
        {
            using (var fs = new FileStream(filepath,
                  FileMode.Open,
                  FileAccess.ReadWrite))
            {
                int length = until - offset + 1;
                byte[] replace = new byte[length];

                for (int x = 0; x < length; x++)
                {
                    replace[x] = 0xFF;
                }

                fs.Position = offset;
                fs.Write(replace, 0, length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditValuesFF(0x44BDC, 0x44BEB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditValues(0x45578, 0x4557A);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditValues(0x455BC, 0x455BE);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditValues(0x45600, 0x45604);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditValues(0x45644, 0x45648);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditValues(0x45688, 0x4568A);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditValues(0x456CC, 0x456CE);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EditValues(0x45710, 0x45712);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EditValues(0x45754, 0x45758);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            EditValues(0x45798, 0x4579C);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EditValues(0x457DC, 0x457E0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EditValues(0x45820, 0x45824);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EditValues(0x45864, 0x45868);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditValues(0x45930, 0x45934);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            EditValues(0x45974, 0x45978);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            EditValues(0x459B8, 0x459BC);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            EditValues(0x459FC, 0x45A00);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            EditValues(0x45A40, 0x45A44);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            EditValues(0x45A84, 0x45A88);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            EditValues(0x45AC8, 0x45ACC);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            EditValues(0x45B0C, 0x45B10);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            EditValues(0x45B50, 0x45B54);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            EditValues(0x45B94, 0x45B98);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            EditValues(0x45BD8, 0x45BDC);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            EditValues(0x45C60, 0x45C64);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            EditValues(0x45CA4, 0x45CA8);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            EditValues(0x45CE8, 0x45CEC);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            EditValues(0x45D2C, 0x45D30);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            EditValues(0x45D70, 0x45D74);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            EditValues(0x45DB4, 0x45DB6);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            EditValues(0x45E3C, 0x45E3D);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            EditValues(0x45E80, 0x45E84);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            EditValues(0x45EC4, 0x45EC6);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            EditValues(0x45F4C, 0x45F50);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            EditValues(0x45F90, 0x45F91);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            EditValues(0x45FD4, 0x45FD5);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            EditValues(0x46018, 0x46019);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            EditValues(0x4605C, 0x46060);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            EditValues(0x460A0, 0x460A4);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            EditValues(0x460E4, 0x460E8);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            EditValues(0x46128, 0x4612C);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            EditValues(0x4616C, 0x46170);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            EditValues(0x461B0, 0x461B2);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            EditValues(0x4627C, 0x46280);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            EditValues(0x462C0, 0x462C1);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            EditValues(0x46304, 0x46308);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            EditValues(0x46348, 0x4634C);
        }

        private void button49_Click(object sender, EventArgs e)
        {

            EditValuesFF(0x44BDC, 0x44BEB);

            EditValues(0x45578, 0x4557A);

            EditValues(0x45578, 0x455BE);

            EditValues(0x45600, 0x45604);

            EditValues(0x45644, 0x45648);

            EditValues(0x45688, 0x4568A);

            EditValues(0x456CC, 0x456CE);

            EditValues(0x45710, 0x45712);

            EditValues(0x45754, 0x45758);

            EditValues(0x45798, 0x4579C);

            EditValues(0x457DC, 0x457E0);

            EditValues(0x45820, 0x45824);

            EditValues(0x45864, 0x45868);

            EditValues(0x45930, 0x45934);

            EditValues(0x45974, 0x45978);

            EditValues(0x459B8, 0x459BC);

            EditValues(0x459FC, 0x45A00);

            EditValues(0x45A40, 0x45A44);

            EditValues(0x45A84, 0x45A88);

            EditValues(0x45AC8, 0x45ACC);

            EditValues(0x45B0C, 0x45B10);

            EditValues(0x45B50, 0x45B54);

            EditValues(0x45B94, 0x45B98);

            EditValues(0x45BD8, 0x45BDC);

            EditValues(0x45C60, 0x45C64);

            EditValues(0x45CA4, 0x45CA8);

            EditValues(0x45CE8, 0x45CEC);

            EditValues(0x45D2C, 0x45D30);

            EditValues(0x45D70, 0x45D74);

            EditValues(0x45DB4, 0x45DB6);

            EditValues(0x45E3C, 0x45E3D);

            EditValues(0x45E80, 0x45E84);

            EditValues(0x45EC4, 0x45EC6);

            EditValues(0x45F4C, 0x45F50);

            EditValues(0x45F90, 0x45F91);

            EditValues(0x45FD4, 0x45FD5);

            EditValues(0x46018, 0x46019);

            EditValues(0x4605C, 0x46060);

            EditValues(0x460A0, 0x460A4);

            EditValues(0x460E4, 0x460E8);

            EditValues(0x46128, 0x4612C);

            EditValues(0x4616C, 0x46170);

            EditValues(0x461B0, 0x461B2);

            EditValues(0x4627C, 0x46280);

            EditValues(0x462C0, 0x462C1);

            EditValues(0x46304, 0x46308);

            EditValues(0x46348, 0x4634C);

            EditValues(0x4638C, 0x4638D);

            //** attempt **//
            EditValues(0x458A8, 0x458AB);
            EditValues(0x458EC, 0x458F0);
            EditValues(0x45C1C, 0x45C20);
            EditValues(0x45F08, 0x45F10);
            EditValues(0x461F4, 0x461F8);
            EditValues(0x46238, 0x4623C);

            //EditValues(0x45DF8, 0x45DFC);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "meet.dat|meet.dat|Data files (*.dat)|*.dat|All files (*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true ;

            if(file.ShowDialog() == DialogResult.OK)
    {
        try
        {
            if ((myStream = file.OpenFile()) != null)
            {
                using (myStream)
                {
                    // Insert code to read the stream here.
                    filepath = file.InitialDirectory + file.FileName;
                    tabControl2.Enabled = true;
                    MessageBox.Show("This tool will AUTO-SAVE the file when you press UNLOCK or EDIT SAVE.\n\nMake sure to BACK-UP the file before editing.", "Auto-Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
    }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream(filepath,
                FileMode.Open,
                FileAccess.ReadWrite))
            {
                int length = 0x43E72 - 0x43E70 + 1;
                byte[] replace = new byte[length];

                int streetpasstags = Int32.Parse(textBox1.Text);
                if (streetpasstags > 0xFFFFFF) streetpasstags = 0xFFFFFF;
                replace[2] = Convert.ToByte((streetpasstags/256)/256);
                replace[1] = Convert.ToByte((streetpasstags/256)%256);
                replace[0] = Convert.ToByte((streetpasstags%256)%256);

                fs.Position = 0x43E70;
                fs.Write(replace, 0, length);
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream(filepath,
    FileMode.Open,
    FileAccess.ReadWrite))
            {
                int length = 0x5B367 - 0x5B366 + 1;
                byte[] replace = new byte[length];

                int streetpasstags = Int32.Parse(textBox2.Text);
                if (streetpasstags > 0xFFFF) streetpasstags = 0xFFFF;
                replace[1] = Convert.ToByte(streetpasstags / 256);
                replace[0] = Convert.ToByte(streetpasstags % 256);

                fs.Position = 0x5B366;
                fs.Write(replace, 0, length);
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            EditValuesFF(0x4555A, 0x45562);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            EditValuesFF(0x57FD8, 0x58FA7);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all Puzzle Swap Pieces?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                EditValues2(0x44BDC, 0x44BEB);

                EditValues2(0x45578, 0x4557A);

                EditValues2(0x45578, 0x455BE);

                EditValues2(0x45600, 0x45604);

                EditValues2(0x45644, 0x45648);

                EditValues2(0x45688, 0x4568A);

                EditValues2(0x456CC, 0x456CE);

                EditValues2(0x45710, 0x45712);

                EditValues2(0x45754, 0x45758);

                EditValues2(0x45798, 0x4579C);

                EditValues2(0x457DC, 0x457E0);

                EditValues2(0x45820, 0x45824);

                EditValues2(0x45864, 0x45868);

                EditValues2(0x45930, 0x45934);

                EditValues2(0x45974, 0x45978);

                EditValues2(0x459B8, 0x459BC);

                EditValues2(0x459FC, 0x45A00);

                EditValues2(0x45A40, 0x45A44);

                EditValues2(0x45A84, 0x45A88);

                EditValues2(0x45AC8, 0x45ACC);

                EditValues2(0x45B0C, 0x45B10);

                EditValues2(0x45B50, 0x45B54);

                EditValues2(0x45B94, 0x45B98);

                EditValues2(0x45BD8, 0x45BDC);

                EditValues2(0x45C60, 0x45C64);

                EditValues2(0x45CA4, 0x45CA8);

                EditValues2(0x45CE8, 0x45CEC);

                EditValues2(0x45D2C, 0x45D30);

                EditValues2(0x45D70, 0x45D74);

                EditValues2(0x45DB4, 0x45DB6);

                EditValues2(0x45E3C, 0x45E3D);

                EditValues2(0x45E80, 0x45E84);

                EditValues2(0x45EC4, 0x45EC6);

                EditValues2(0x45F4C, 0x45F50);

                EditValues2(0x45F90, 0x45F91);

                EditValues2(0x45FD4, 0x45FD5);

                EditValues2(0x46018, 0x46019);

                EditValues2(0x4605C, 0x46060);

                EditValues2(0x460A0, 0x460A4);

                EditValues2(0x460E4, 0x460E8);

                EditValues2(0x46128, 0x4612C);

                EditValues2(0x4616C, 0x46170);

                EditValues2(0x461B0, 0x461B2);

                EditValues2(0x4627C, 0x46280);

                EditValues2(0x462C0, 0x462C1);

                EditValues2(0x46304, 0x46308);

                EditValues2(0x46348, 0x4634C);

                EditValues2(0x4638C, 0x4638D);

                //** attempt **//
                EditValues2(0x458A8, 0x458AB);
                EditValues2(0x458EC, 0x458F0);
                EditValues2(0x45C1C, 0x45C20);
                EditValues2(0x45F08, 0x45F10);
                EditValues2(0x461F4, 0x461F8);
                EditValues2(0x46238, 0x4623C);

               // EditValues2(0x45DF8, 0x45DFC);

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EditValues(0x458A8, 0x458AB);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EditValues(0x458EC, 0x458F0);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            EditValues(0x45C1C, 0x45C20);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            EditValues(0x45F08, 0x45F10);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            EditValues(0x461F4, 0x461F8);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            EditValues(0x46238, 0x4623C);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            EditValuesFF(0x5BDE0, 0x5BE31);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Unlocking most Hats and Costumers (+ Medals) might make you lose your progress on some DLC Games. Do you still want to continue?", "Confirmation", MessageBoxButtons.YesNo,  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                EditValuesFF(0x5B300, 0x5B34F);
            }
        }


        private void button57_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream(filepath,
                    FileMode.Open,
                    FileAccess.ReadWrite))
            {
                int length = 0x5B4D7 - 0x5B4D6 + 1;
                byte[] replace = new byte[length];

                int streetpasstags = 1000;
                if (streetpasstags > 0xFFFF) streetpasstags = 0xFFFF;
                replace[1] = Convert.ToByte(streetpasstags / 256);
                replace[0] = Convert.ToByte(streetpasstags % 256);

                fs.Position = 0x5B4D6;
                fs.Write(replace, 0, length);
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            EditValuesFF(0x5BFE9, 0x5BFF0);
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void openWarriorsWaySaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            //this.Hide();
            frm.ShowDialog();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            EditValues(0x4638C, 0x4638D);
        }

        }
}
