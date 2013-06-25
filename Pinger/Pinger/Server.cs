using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    class Server
    {
        string serverName;
        string dnsIP;
        Game game;

        public Server()
        {
            serverName = "testServer";
            dnsIP = "test.server.hr";
            game = new Game("Call of duty",0);
        }

        public Server(string server,string IP, Game _game)
        {
            serverName = server;
            dnsIP = IP;
            game = _game;
        }

        public string GetServerName()
        {
            return serverName;
        }

        public string GetDnsIP()
        {
            return dnsIP;
        }
        public Game GetGame()
        {
            return game;
        }


    }
}
