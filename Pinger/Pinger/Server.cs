using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Pinger
{
    public class Server
    {
        public string serverName { get; set; }
        public string dnsIP { get; set; }
        public Game game { get; set; }

        private Server()
        {

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
