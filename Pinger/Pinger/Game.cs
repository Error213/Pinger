using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    public class Game
    {
        public enum Genre { FPS, RTS, RPG, MMO, MOBA, TPS, Sandbox, Other };
        public string gameName { get; set; }
        public Genre genre { get; set; }

        public Game()
        {

        }

        public Game(string name,int genreSelector)
        {
            gameName = name;
            genre =(Genre)genreSelector;
        }

        public string GetGameName()
        {
            return gameName;
        }

        public string GetGameGenre()
        {
            return Enum.GetName(typeof(Genre), genre);
        }

        public override string ToString()
        {
            return gameName;
        }
    }
}
