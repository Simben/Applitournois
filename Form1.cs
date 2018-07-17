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



        private void GenerateRonde()
        {
          /*  for (int i = 0; i < Teams.Count - 1; i++)
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
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Team temp = new Team();
            temp._ID = Teams.Count + 1;
            temp._Nom = TB_Nom.Text;
            temp._Region = TB_region.Text;
            temp._Pts_Doublette = Convert.ToInt32((TB_PD.Text == "") ? "0" : TB_PD.Text);
            temp._Pts_Peinture = (float)Convert.ToDouble((TB_PPaint.Text == "") ? "0" : TB_PD.Text);
            temp._Pts_Poutre = Convert.ToInt32((TB_PP.Text == "") ? "0" : TB_PD.Text);




            this.Teams.Add(temp);
            Refresh();
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
                string[] temp = new string[10];
                temp[0] = t._ID.ToString();
                temp[1] = t._Nom;
                temp[2] = t._Region;
                temp[3] = t._Pts_Doublette.ToString();
                temp[4] = (t._Pts_Doublette / (float)_MaxPD).ToString("0.00");
                temp[5] = t._Pts_Poutre.ToString();
                temp[6] = t._Pts_Peinture.ToString();
                temp[7] = (t._Pts_Poutre + (t._Pts_Doublette / (float)_MaxPD)).ToString("0.00");

                temp[8] = "";
                foreach (var ttt in t._Team_Rencontrees)
                    temp[8] += ttt.ToString() + "|";

                if (!String.IsNullOrEmpty(temp[8]))
                    temp[8] = temp[8].Substring(0, temp[8].Length - 1);
               

                temp[9] = "";
                foreach (var ttt in t._Tables_jouees)
                    temp[9] += ttt.ToString() + "|";

                if (!String.IsNullOrEmpty(temp[9]))
                    temp[9] = temp[9].Substring(0, temp[9].Length - 1);
                

                ListViewItem c = new ListViewItem(temp);
                this.listView1.Items.Add(c);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();            
        }
        private int Selected_Index = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 1)
                return;

            Selected_Index = Convert.ToInt32(this.listView1.SelectedItems[0].Text);

            int index = Selected_Index;

            TB_Nom.Text = Teams[index]._Nom;
            TB_region.Text = Teams[index]._Region;
            TB_PD.Text = Teams[index]._Pts_Doublette.ToString();
            TB_PPaint.Text = Teams[index]._Pts_Peinture.ToString("0.00");
            TB_PP.Text = Teams[index]._Pts_Poutre.ToString();
            string tt = "";
            foreach (var t in Teams[index]._Team_Rencontrees)
                tt += t.ToString() + "|";

            if(!String.IsNullOrEmpty(tt))
                tt = tt.Substring(0,tt.Length - 1);
            this.TB_Teams.Text = tt;

            tt = "";
            foreach (var t in Teams[index]._Tables_jouees)
                tt += t.ToString() + "|";

            if (!String.IsNullOrEmpty(tt))
                tt = tt.Substring(0, tt.Length - 1);
            this.TB_Tables.Text = tt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Selected_Index == -1) return;

            int index = Selected_Index;

            this.Teams[index]._Nom = TB_Nom.Text;
            this.Teams[index]._Region = TB_region.Text;
            this.Teams[index]._Pts_Doublette = Convert.ToInt32((TB_PD.Text == "") ? "0" : TB_PD.Text);
            this.Teams[index]._Pts_Peinture = (float)Convert.ToDouble((TB_PPaint.Text == "") ? "0" : TB_PD.Text);
            this.Teams[index]._Pts_Poutre = Convert.ToInt32((TB_PP.Text == "") ? "0" : TB_PP.Text);

            this.Teams[index]._Team_Rencontrees.Clear();
            string[] tt = this.TB_Teams.Text.Split('|');
            foreach (var item in tt)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    int Table = Convert.ToInt32(item);
                    this.Teams[index]._Team_Rencontrees.Add(Table);
                }
            }

            this.Teams[index]._Tables_jouees.Clear();
            tt = this.TB_Tables.Text.Split('|');
            foreach (var item in tt)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    int Table = Convert.ToInt32(item);
                    this.Teams[index]._Tables_jouees.Add(Table);
                }
            }

            Refresh();
            this.Selected_Index = -1;

            TB_Nom.Text = "";
            TB_region.Text = "";
            TB_PD.Text = "";
            TB_PPaint.Text = "";
            TB_PP.Text = "";
            this.TB_Teams.Text = "";
            this.TB_Tables.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ronde dlg = new Ronde(ref Teams);
            dlg.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teams.Clear();
            Team t = null;
            Random rnd = new Random();
            for (int i = 0; i < 26; i++)
            {
                t = new Team();
                t._ID = i;
                t._Nom = ((char)(65 + i)).ToString();
                t._Pts_Doublette = rnd.Next(0, 2000);
                t._Region = ((ApliTournoi.REGION)(i % 6)).ToString();
                Teams.Add(t);

            }
        }
    }
}
