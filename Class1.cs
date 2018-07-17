using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApliTournoi
{
    public class CONST
    {
        public const int MAX_ROUND = 4;
    }

    public enum REGION
    {
        Paris,
        ARA,
        PACA,
        Haut_de_France,
        Centre,
        Grande_Aquitaine
    }

    public class Team
    {
        public bool _isAssigned = false;
        public int _ID = 0;
        public string _Nom = "";
        public string _Region;
        public float _Pts_Doublette = 0F;
        public float _Pts_Peinture = 0F;
        public int _Pts_Poutre = 0;
        public List<int> _Tables_jouees = null;
        public List<int> _Team_Rencontrees = null;


        public Team()
        {
            _Tables_jouees = new List<int>();
            _Team_Rencontrees = new List<int>();
        }
    };

    public class Ronde
    {
        public List<Pairing> Pair = new List<Pairing>();
    }

    public class Pairing
    {
        Team _A = null;
        Team _B = null;
        int _Result_A = 0;
        int _Result_B = 0;
        int _Table = 0;

        public Pairing(Team A, Team B, int Score_A, int Score_B, int Table)
        {
            _A = A;
            _B = B;
            _Result_A = Score_A;
            _Result_B = Score_B;
            _Table = Table;
        }
    }


}

