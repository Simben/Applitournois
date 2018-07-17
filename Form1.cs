using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApliTournoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<Team> Teams = new List<Team>();//[26];
        private List<int> ForbidenPair = new List<int>();
        private List<int> Paired_Team = new List<int>();
        private List<KeyValuePair<int, int>> Pairing = new List<KeyValuePair<int, int>>();


        private void GenerateRonde()
        {
            for (int i = 0; i < Teams.Count - 1; i++)
            {
                Teams[i]._isAssigned = false;
            }


            //Tri par PP
            for (int i = 0; i < Teams.Count - 1; i++)
            {
                if (Teams[i]._Pts_Poutre < Teams[i + 1]._Pts_Poutre)
                {
                    Team temp = Teams[i];
                    Teams[i] = Teams[i + 1];
                    Teams[i + 1] = temp;
                    i = -1;
                }
            }
            // tripar PD
            for (int i = 0; i < Teams.Count - 1; i++)
            {
                if (Teams[i]._Pts_Poutre == Teams[i + 1]._Pts_Poutre)
                {
                    if (Teams[i]._Pts_Doublette < Teams[i + 1]._Pts_Doublette)
                    {
                        Team temp = Teams[i];
                        Teams[i] = Teams[i + 1];
                        Teams[i + 1] = temp;
                        i = -1;
                    }
                }
            }

            this.ForbidenPair.Clear();
            this.Pairing.Clear();
            Paired_Team.Clear();
            int cur = 1;

            for (int i = 0; i < Teams.Count - 1; i++)
            {
                if (Paired_Team.Contains(i))
                    continue;
                if (Teams[i]._Team_Rencontrees.Contains(Teams[i + cur]._ID) || Teams[i + cur]._Team_Rencontrees.Contains(Teams[i]._ID) || (ForbidenPair.Contains(i) && ForbidenPair.Contains(i + cur)))
                {
                    cur++;
                    i--;
                    if (i + cur == 26)
                    {
                        cur = 1;
                        i = -1;
                        ForbidenPair.Clear();
                        ForbidenPair.Add(Pairing.ElementAt(Pairing.Count - 1).Value);
                        ForbidenPair.Add(Pairing.ElementAt(Pairing.Count - 1).Key);
                        Pairing.RemoveAt(Pairing.Count - 1);
                    }
                    continue;
                }
                else
                {
                    Pairing.Add(new KeyValuePair<int, int>(i, i + cur));
                    Paired_Team.Add(i);
                    Paired_Team.Add(i + cur);
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Team temp = new Team();
            temp._ID = Teams.Count + 1;
            temp._Nom = TB_Nom.Text;
            temp._Region = TB_region.Text;


            Random rnd = new Random();
            for (int i = 0; i < 26; i++)
            {
                Teams[i] = new Team();
                Teams[i]._ID = i;
                Teams[i]._Nom = ((char)(65 + i)).ToString();
                Teams[i]._Pts_Doublette = rnd.Next(0, 2000);
                Teams[i]._Region = ((ApliTournoi.REGION)(i % 6)).ToString();

            }
        }
        private int _MaxPD = 0;


        private void Refresh()
        {
            this.listView1.Items.Clear();
            foreach (Team t in Teams)
            {
                if (t._Pts_Doublette > _MaxPD)
                    _MaxPD = (int)t._Pts_Doublette;
            }


            foreach (Team t in Teams)
            {
                //ListViewItem c = new ListViewItem();
                //c.Name = t._ID.ToString();
                string[] temp = new string[9];
                temp[0] = t._ID.ToString();
                temp[1] = t._Nom;
                temp[2] = t._Region;
                temp[3] = t._Pts_Doublette.ToString();
                temp[4] = (t._Pts_Doublette / (float)_MaxPD).ToString("0.000");
                temp[5] = t._Pts_Poutre.ToString();
                temp[6] = t._Pts_Peinture.ToString();
                temp[7] = (t._Pts_Poutre + (t._Pts_Doublette / (float)_MaxPD)).ToString();

                ListViewItem c = new ListViewItem(temp);
                this.listView1.Items.Add(c);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();            
        }
    }
}
