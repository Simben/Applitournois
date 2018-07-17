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
    public partial class Ronde : Form
    {
        private List<Team> _Teams = null;
        public Ronde(ref List<Team> Teams)
        {
            InitializeComponent();
            _Teams = Teams;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Trie()
        {
            _MaxPD = 0;
            foreach (Team t in _Teams)
            {
                if (t._Pts_Doublette > _MaxPD)
                    _MaxPD = (int)t._Pts_Doublette;
            }

            for (int i = 0; i < tTeams.Length - 1; i++)
            {
                float A = (tTeams[i]._Pts_Poutre + (tTeams[i]._Pts_Doublette / (float)_MaxPD));
                float B = (tTeams[i+1]._Pts_Poutre + (tTeams[i+1]._Pts_Doublette / (float)_MaxPD));
                if (A < B)
                {
                    Team temp = tTeams[i];
                    tTeams[i] = tTeams[i + 1];
                    tTeams[i + 1] = temp;
                    i = -1;
                }
            }
        }

        private int _MaxPD = 0;
        private Team[] tTeams = null;

        private void Refresh()
        {
            tTeams = new Team[_Teams.Count];
            _MaxPD = 0;
            this.listView1.Items.Clear();
            int i = 0;
            foreach (Team t in _Teams)
            {
                tTeams[i] = t;
                i++;
                if (t._Pts_Doublette > _MaxPD)
                    _MaxPD = (int)t._Pts_Doublette;
            }

            Trie();


            foreach (Team t in tTeams)
            {
                //ListViewItem c = new ListViewItem();
                //c.Name = t._ID.ToString();
                string[] temp = new string[9];
                temp[0] = t._ID.ToString();
                temp[1] = t._Nom;
                temp[2] = t._Region;

                temp[3] = (t._Pts_Poutre + (t._Pts_Doublette / (float)_MaxPD)).ToString("0.00");

                ListViewItem c = new ListViewItem(temp);
                this.listView1.Items.Add(c);
            }
        }


        private List<int> ForbidenPair = new List<int>();
        private List<int> Paired_Team = new List<int>();
        private List<KeyValuePair<int, int>> Pairing = new List<KeyValuePair<int, int>>();
        private void button2_Click(object sender, EventArgs e)
        {
            Trie(); // on trie par PD

            this.ForbidenPair.Clear();
            this.Pairing.Clear();
            Paired_Team.Clear();
            int cur = 1;

            for (int i = 0; i < tTeams.Length - 1; i++)
            {
                if (Paired_Team.Contains(i))
                    continue;
                if (tTeams[i]._Team_Rencontrees.Contains(tTeams[i + cur]._ID) || tTeams[i + cur]._Team_Rencontrees.Contains(tTeams[i]._ID) || (ForbidenPair.Contains(i) && ForbidenPair.Contains(i + cur)))
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
    }
}
