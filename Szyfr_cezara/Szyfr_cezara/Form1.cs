using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfr_cezara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Szyfruj_Click(object sender, EventArgs e)
        {
            string text = Tekst.Text;
            int move = (int)Przesuniecie.Value;
            int dlugosc = (int)text.Length;
            int[] tab = new int[dlugosc];
            for (int i = 0; i < dlugosc; i++)
            {
                tab[i] = (int)text[i];
            }
            string odpowiedz = "";
            char rodzaj = 'x';

            if (move >= 0)
            {
                if (male.Checked == true && cyfry.Checked == true && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] += move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] - 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }


                if (male.Checked == true && cyfry.Checked == true && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] += move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] - 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == true && cyfry.Checked == false && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] += move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] - 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == true && cyfry.Checked == false && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] += move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] - 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == true && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90))
                        {
                            tab[i] += move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] - 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == true && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57))
                        {
                            tab[i] += move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] - 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == false && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57))
                        {
                            tab[i] += move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] - 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] - 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == false && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        odpowiedz += '*';
                    }
                }

                MessageBox.Show(odpowiedz);

            }
            else
            {
                if (male.Checked == true && cyfry.Checked == true && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] -= move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] + 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }


                if (male.Checked == true && cyfry.Checked == true && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] -= move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] + 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == true && cyfry.Checked == false && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] -= move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] + 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == true && cyfry.Checked == false && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                        {
                            tab[i] -= move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] + 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == true && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90))
                        {
                            tab[i] -= move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] + 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == true && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57))
                        {
                            tab[i] -= move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] + 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == false && wielkie.Checked == true)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        if (tab[i] >= 48 && tab[i] <= 57)
                            rodzaj = 'l';
                        if (tab[i] >= 65 && tab[i] <= 90)
                            rodzaj = 'w';
                        if (tab[i] >= 97 && tab[i] <= 122)
                            rodzaj = 'm';
                        if ((tab[i] >= 48 && tab[i] <= 57))
                        {
                            tab[i] -= move;
                            if ((tab[i] >= 48 && tab[i] <= 57) || (tab[i] >= 65 && tab[i] <= 90) || (tab[i] >= 97 && tab[i] <= 122))
                            {
                                odpowiedz += Convert.ToChar(tab[i]);

                            }
                            else
                            {
                                if (rodzaj == 'm')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'w')
                                    odpowiedz += Convert.ToChar(tab[i] + 26);
                                if (rodzaj == 'l')
                                    odpowiedz += Convert.ToChar(tab[i] + 10);
                            }
                        }
                        else
                            odpowiedz += '*';
                    }
                }

                if (male.Checked == false && cyfry.Checked == false && wielkie.Checked == false)
                {
                    for (int i = 0; i < dlugosc; i++)
                    {
                        odpowiedz += '*';
                    }
                }

                MessageBox.Show(odpowiedz);
            }


        }
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tekst.Text = "";
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}