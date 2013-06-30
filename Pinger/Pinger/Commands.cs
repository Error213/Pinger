using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinger
{
    class Commands
    {
        public static void SetServer(Server server, MainForm form)
        {
            form.treeView.Nodes[server.GetGame().GetGameName()].Nodes.Add(server.GetServerName() + " " + server.GetDnsIP());
            form.treeView.ExpandAll();

            string[] row = { server.GetServerName(), server.GetDnsIP(), server.GetGame().GetGameName(), server.GetGame().GetGameGenre() };
            ListViewItem lvi = new ListViewItem(row);
            form.listView.Items.Add(lvi);
        }

        public static void SetGame(Game game, MainForm form)
        {

            Arrays.games.Add(game);
            form.treeView.Nodes.Add(game.GetGameName(), game.GetGameName());
        }

        public static void SetListViewHeader(MainForm form)
        {
            form.listView.Columns.Add("Server");
            form.listView.Columns.Add("DNS/IP");
            form.listView.Columns.Add("Game");
            form.listView.Columns.Add("Genre");
            form.listView.View = View.Details;
        }

        public static int pingHost(string Address)
        {
            Ping ping = new Ping();
            PingOptions options = new PingOptions();
            byte[] buffer = new byte[32];
            int timeout = 200;
            PingReply reply;

            try
            {
                reply = ping.Send(Address, timeout, buffer, options);
            }
            catch (Exception)
            {

                return -1;
            }
            reply = ping.Send(Address, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
                return (int)reply.RoundtripTime;
            else
                return -1;
        }


    }
}
