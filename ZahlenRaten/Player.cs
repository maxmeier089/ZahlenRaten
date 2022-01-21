using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJ
{
    class Player
    {

        public string Name { get; private set; }

        public int Versuche { get; set; }


        public Player(string name)
        {
            Name = name;
            Versuche = 0;
        }

    }
}
