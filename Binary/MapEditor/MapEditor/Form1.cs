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

namespace MapEditor
{
    public partial class Form1 : Form
    {
        StreamWriter writer;
        string line1;
        string line2;
        string line3;
        string line4;
        string line5;
        string line6;
        string line7;
        string line8;

        public Form1()
        {
            InitializeComponent();
            line1 = "";
            line2 = "";
            line3 = "";
            line4 = "";
            line5 = "";
            line6 = "";
            line7 = "";
            line8 = "";
        }

        /// <summary>
        /// Writes to the map file "customMap.txt"
        /// </summary>
        public void WriteToMap() //string _line1, string _line2, string _line3, string _line4, string _line5, string _line6, string _line7, string _line8
        {
            try
            {
                writer = new StreamWriter("customMap.txt");

                writer.WriteLine(line1);
                writer.WriteLine(line2);
                writer.WriteLine(line3);
                writer.WriteLine(line4);
                writer.WriteLine(line5);
                writer.WriteLine(line6);
                writer.WriteLine(line7);
                writer.Write(line8);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(writer != null)
                    writer.Close();
            }
        }

        #region Ignore

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        #endregion

        /// <summary>
        /// Reads every element in each text box and checks if they are allowed and if they aren't it will give you an error message.
        /// </summary>
        /// <returns>If you have correct values in the list it will return true, otherwise it will return false</returns>
        public bool ReadMap()
        {
            if (mapBox1.Text == "" || mapBox2.Text == "" || mapBox3.Text == "" || mapBox4.Text == "" || mapBox5.Text == "" || mapBox6.Text == "" || mapBox7.Text == "" || mapBox8.Text == "")
            {
                MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                    "Map Reading Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation
                                    );
                return false;
            }

            try
            {
                #region Line1 Loop

                for (int i = 0; i < 36; i++)
                {
                    switch (mapBox1.Text[i])
                    {
                        case 'r':
                            line1 += mapBox1.Text[i];
                            break;
                        case '.':
                            line1 += mapBox1.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox1.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox1.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox1.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }
                for (int i = 0; i < 36; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line1 += mapBox2.Text[i];
                            break;
                        case '.':
                            line1 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }
                for (int i = 0; i < 36; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line1 += mapBox3.Text[i];
                            break;
                        case '.':
                            line1 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }
                for (int i = 0; i < 36; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line1 += mapBox4.Text[i];
                            break;
                        case '.':
                            line1 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }
                for (int i = 0; i < 36; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line1 += mapBox5.Text[i];
                            break;
                        case '.':
                            line1 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }
                for (int i = 0; i < 36; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line1 += mapBox6.Text[i];
                            break;
                        case '.':
                            line1 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }
                for (int i = 0; i < 36; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line1 += mapBox7.Text[i];
                            break;
                        case '.':
                            line1 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }
                for (int i = 0; i < 41; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line1 += mapBox8.Text[i];
                            break;
                        case '.':
                            line1 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line1 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line1 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line1 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            return false;
                    }
                }

                #endregion

                #region Line2 Loop

                for (int i = 36; i < 72; i++)
                {
                    switch (mapBox1.Text[i])
                    {
                        case 'r':
                            line2 += mapBox1.Text[i];
                            break;
                        case '.':
                            line2 += mapBox1.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox1.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox1.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox1.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }
                for (int i = 36; i < 72; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line2 += mapBox2.Text[i];
                            break;
                        case '.':
                            line2 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }
                for (int i = 36; i < 72; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line2 += mapBox3.Text[i];
                            break;
                        case '.':
                            line2 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }
                for (int i = 36; i < 72; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line2 += mapBox4.Text[i];
                            break;
                        case '.':
                            line2 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }
                for (int i = 36; i < 72; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line2 += mapBox5.Text[i];
                            break;
                        case '.':
                            line2 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }
                for (int i = 36; i < 72; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line2 += mapBox6.Text[i];
                            break;
                        case '.':
                            line2 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }
                for (int i = 36; i < 72; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line2 += mapBox7.Text[i];
                            break;
                        case '.':
                            line2 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }
                for (int i = 41; i < 82; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line2 += mapBox8.Text[i];
                            break;
                        case '.':
                            line2 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line2 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line2 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line2 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            return false;
                    }
                }

                #endregion

                #region Line3 Loop

                for (int i = 72; i < 108; i++)
                {
                    switch (mapBox1.Text[i])
                    {
                        case 'r':
                            line3 += mapBox1.Text[i];
                            break;
                        case '.':
                            line3 += mapBox1.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox1.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox1.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox1.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }
                for (int i = 72; i < 108; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line3 += mapBox2.Text[i];
                            break;
                        case '.':
                            line3 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }
                for (int i = 72; i < 108; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line3 += mapBox3.Text[i];
                            break;
                        case '.':
                            line3 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }
                for (int i = 72; i < 108; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line3 += mapBox4.Text[i];
                            break;
                        case '.':
                            line3 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }
                for (int i = 72; i < 108; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line3 += mapBox5.Text[i];
                            break;
                        case '.':
                            line3 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }
                for (int i = 72; i < 108; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line3 += mapBox6.Text[i];
                            break;
                        case '.':
                            line3 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }
                for (int i = 72; i < 108; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line3 += mapBox7.Text[i];
                            break;
                        case '.':
                            line3 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }
                for (int i = 82; i < 123; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line3 += mapBox8.Text[i];
                            break;
                        case '.':
                            line3 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line3 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line3 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line3 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            return false;
                    }
                }

                #endregion

                #region Line4 Loop

                for (int i = 108; i < 144; i++)
                {
                    switch (mapBox1.Text[i])
                    {
                        case 'r':
                            line4 += mapBox1.Text[i];
                            break;
                        case '.':
                            line4 += mapBox1.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox1.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox1.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox1.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }
                for (int i = 108; i < 144; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line4 += mapBox2.Text[i];
                            break;
                        case '.':
                            line4 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }
                for (int i = 108; i < 144; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line4 += mapBox3.Text[i];
                            break;
                        case '.':
                            line4 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }
                for (int i = 108; i < 144; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line4 += mapBox4.Text[i];
                            break;
                        case '.':
                            line4 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }
                for (int i = 108; i < 144; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line4 += mapBox5.Text[i];
                            break;
                        case '.':
                            line4 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }
                for (int i = 108; i < 144; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line4 += mapBox6.Text[i];
                            break;
                        case '.':
                            line4 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }
                for (int i = 108; i < 144; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line4 += mapBox7.Text[i];
                            break;
                        case '.':
                            line4 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }
                for (int i = 123; i < 164; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line4 += mapBox8.Text[i];
                            break;
                        case '.':
                            line4 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line4 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line4 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line4 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            return false;
                    }
                }

                #endregion

                #region Line5 Loop

                for (int i = 144; i < 180; i++)
                {
                    switch (mapBox1.Text[i])
                    {
                        case 'r':
                            line5 += mapBox1.Text[i];
                            break;
                        case '.':
                            line5 += mapBox1.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox1.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox1.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox1.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }
                for (int i = 144; i < 180; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line5 += mapBox2.Text[i];
                            break;
                        case '.':
                            line5 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }
                for (int i = 144; i < 180; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line5 += mapBox3.Text[i];
                            break;
                        case '.':
                            line5 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }
                for (int i = 144; i < 180; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line5 += mapBox4.Text[i];
                            break;
                        case '.':
                            line5 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }
                for (int i = 144; i < 180; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line5 += mapBox5.Text[i];
                            break;
                        case '.':
                            line5 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }
                for (int i = 144; i < 180; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line5 += mapBox6.Text[i];
                            break;
                        case '.':
                            line5 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }
                for (int i = 144; i < 180; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line5 += mapBox7.Text[i];
                            break;
                        case '.':
                            line5 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }
                for (int i = 164; i < 205; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line5 += mapBox8.Text[i];
                            break;
                        case '.':
                            line5 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line5 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line5 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line5 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            return false;
                    }
                }

                #endregion

                #region Line6 Loop

                for (int i = 180; i < 216; i++)
                {
                    switch (mapBox1.Text[i])
                    {
                        case 'r':
                            line6 += mapBox1.Text[i];
                            break;
                        case '.':
                            line6 += mapBox1.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox1.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox1.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox1.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }
                for (int i = 180; i < 216; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line6 += mapBox2.Text[i];
                            break;
                        case '.':
                            line6 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }
                for (int i = 180; i < 216; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line6 += mapBox3.Text[i];
                            break;
                        case '.':
                            line6 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }
                for (int i = 180; i < 216; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line6 += mapBox4.Text[i];
                            break;
                        case '.':
                            line6 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }
                for (int i = 180; i < 216; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line6 += mapBox5.Text[i];
                            break;
                        case '.':
                            line6 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }
                for (int i = 180; i < 216; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line6 += mapBox6.Text[i];
                            break;
                        case '.':
                            line6 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }
                for (int i = 180; i < 216; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line6 += mapBox7.Text[i];
                            break;
                        case '.':
                            line6 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }
                for (int i = 205; i < 246; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line6 += mapBox8.Text[i];
                            break;
                        case '.':
                            line6 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line6 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line6 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line6 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            return false;
                    }
                }

                #endregion

                #region Line7 Loop

                for (int i = 216; i < 252; i++)
                {
                    if (mapBox1.Text[220] != '.' && i == 221)
                    {
                        line7 += '.';
                    }
                    else
                    {
                        switch (mapBox1.Text[i])
                        {
                            case 'r':
                                line7 += mapBox1.Text[i];
                                break;
                            case '.':
                                line7 += mapBox1.Text[i];
                                break;
                            case 'b':
                                line7 += mapBox1.Text[i];
                                break;
                            case 'i':
                                line7 += mapBox1.Text[i];
                                break;
                            case 'e':
                                line7 += mapBox1.Text[i];
                                break;
                            default:
                                MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                            "Map Reading Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation
                                            );
                                line1 = "";
                                line2 = "";
                                line3 = "";
                                line4 = "";
                                line5 = "";
                                line6 = "";
                                line7 = "";
                                return false;
                        }
                    }
                }
                for (int i = 216; i < 252; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line7 += mapBox2.Text[i];
                            break;
                        case '.':
                            line7 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line7 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line7 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line7 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            return false;
                    }
                }
                for (int i = 216; i < 252; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line7 += mapBox3.Text[i];
                            break;
                        case '.':
                            line7 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line7 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line7 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line7 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            return false;
                    }
                }
                for (int i = 216; i < 252; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line7 += mapBox4.Text[i];
                            break;
                        case '.':
                            line7 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line7 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line7 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line7 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            return false;
                    }
                }
                for (int i = 216; i < 252; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line7 += mapBox5.Text[i];
                            break;
                        case '.':
                            line7 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line7 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line7 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line7 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            return false;
                    }
                }
                for (int i = 216; i < 252; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line7 += mapBox6.Text[i];
                            break;
                        case '.':
                            line7 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line7 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line7 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line7 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            return false;
                    }
                }
                for (int i = 216; i < 252; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line7 += mapBox7.Text[i];
                            break;
                        case '.':
                            line7 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line7 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line7 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line7 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            return false;
                    }
                }
                for (int i = 246; i < 287; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line7 += mapBox8.Text[i];
                            break;
                        case '.':
                            line7 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line7 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line7 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line7 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            return false;
                    }
                }

                #endregion

                #region Line8 Loop

                for (int i = 252; i < 288; i++)
                {
                    switch (mapBox1.Text[i])
                    {
                        case 'r':
                            line8 += mapBox1.Text[i];
                            break;
                        case '.':
                            line8 += mapBox1.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox1.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox1.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox1.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }
                for (int i = 252; i < 288; i++)
                {
                    switch (mapBox2.Text[i])
                    {
                        case 'r':
                            line8 += mapBox2.Text[i];
                            break;
                        case '.':
                            line8 += mapBox2.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox2.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox2.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox2.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }
                for (int i = 252; i < 288; i++)
                {
                    switch (mapBox3.Text[i])
                    {
                        case 'r':
                            line8 += mapBox3.Text[i];
                            break;
                        case '.':
                            line8 += mapBox3.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox3.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox3.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox3.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }
                for (int i = 252; i < 288; i++)
                {
                    switch (mapBox4.Text[i])
                    {
                        case 'r':
                            line8 += mapBox4.Text[i];
                            break;
                        case '.':
                            line8 += mapBox4.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox4.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox4.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox4.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }
                for (int i = 252; i < 288; i++)
                {
                    switch (mapBox5.Text[i])
                    {
                        case 'r':
                            line8 += mapBox5.Text[i];
                            break;
                        case '.':
                            line8 += mapBox5.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox5.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox5.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox5.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }
                for (int i = 252; i < 288; i++)
                {
                    switch (mapBox6.Text[i])
                    {
                        case 'r':
                            line8 += mapBox6.Text[i];
                            break;
                        case '.':
                            line8 += mapBox6.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox6.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox6.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox6.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }
                for (int i = 252; i < 288; i++)
                {
                    switch (mapBox7.Text[i])
                    {
                        case 'r':
                            line8 += mapBox7.Text[i];
                            break;
                        case '.':
                            line8 += mapBox7.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox7.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox7.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox7.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }
                for (int i = 287; i < 328; i++)
                {
                    switch (mapBox8.Text[i])
                    {
                        case 'r':
                            line8 += mapBox8.Text[i];
                            break;
                        case '.':
                            line8 += mapBox8.Text[i];
                            break;
                        case 'b':
                            line8 += mapBox8.Text[i];
                            break;
                        case 'i':
                            line8 += mapBox8.Text[i];
                            break;
                        case 'e':
                            line8 += mapBox8.Text[i];
                            break;
                        default:
                            MessageBox.Show("Could not read the map. Try making sure all the values are acceptable.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                            line1 = "";
                            line2 = "";
                            line3 = "";
                            line4 = "";
                            line5 = "";
                            line6 = "";
                            line7 = "";
                            line8 = "";
                            return false;
                    }
                }

                #endregion
            }
            catch (IndexOutOfRangeException iRE)
            {
                MessageBox.Show("Could not read the map. Try making sure you have the necessary number of values.",
                                        "Map Reading Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation
                                        );
                line1 = "";
                line2 = "";
                line3 = "";
                line4 = "";
                line5 = "";
                line6 = "";
                line7 = "";
                line8 = "";

                return false;
            }

            return true;
            
            //WriteToMap();
    }

        /// <summary>
        /// When you click the button it will check if ReadMap() returns true it will call WriteToMap(), otherwise it will do nothing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            bool mapRead = ReadMap();
            if (mapRead)
                WriteToMap();
        }
    }
}
