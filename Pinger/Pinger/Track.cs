using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pinger
{
    class Track
    {
        public void tracker(Server s, MainForm form)
        {
            form.notifyIconTray.ShowBalloonTip(300,"Connected to"+s.GetServerName(),"Ping is"+" "+Commands.pingHost(s.GetDnsIP()),ToolTipIcon.Info);
            while (!_Disable)
            {
                
                int ping = Commands.pingHost(s.GetDnsIP());
                if (ping < 150 && ping >= 0)
                    form.notifyIconTray.Icon = new Icon("Resources/iconG.ico");
                else if (ping < 400 && ping >=150)
                    form.notifyIconTray.Icon = new Icon("Resources/iconY.ico");
                else if (ping >= 400)
                    form.notifyIconTray.Icon = new Icon("Resources/iconR.ico");
                else
                    form.notifyIconTray.Icon = new Icon("Resources/icon404.ico");

                if(ping>=0)
                    form.notifyIconTray.Text = s.GetServerName().ToUpper() + " " + s.GetDnsIP() + "\n" + ping + "ms"+" "+s.GetGame().GetGameName();
                else
                    form.notifyIconTray.Text = s.GetServerName().ToUpper() + " " + s.GetDnsIP() + "\n" + "Host Unreachable" + " " + s.GetGame().GetGameName();

                System.Threading.Thread.Sleep(2000);
            }
        }
        public void Disable(MainForm form)
        {
                _Disable = true;
            form.notifyIconTray.Icon = new Icon("Resources/icon404.ico");
            form.notifyIconTray.Text = "Server not Selected";

        }
        private volatile bool _Disable;
    }
}
