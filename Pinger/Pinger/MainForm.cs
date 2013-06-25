using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinger
{
    public partial class MainForm : Form
    {
        private Track track;
        public MainForm()
        {
            InitializeComponent();
            this.Icon =new Icon ("Resources/iconG.ico");
            notifyIconTray.Icon = new Icon("Resources/icon404.ico");
            notifyIconTray.Text = "Server not Selected";
            listViewToolStripMenuItem.Checked = true;
            treeView.Visible = false;
            Commands.SetListViewHeader(this);

        }

        #region Menu Form
        private void newServerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewServer NewServer = new NewServer();
            Server server;
            NewServer.ShowDialog(this);
            if (NewServer.DialogResult == DialogResult.OK)
            {
                server = new Server(NewServer.GetServerName(), NewServer.GetServerIP(),(Game)(Arrays.games[NewServer.GetGame()]));
                NewServer.Dispose();
                Commands.SetServer(server,this);
            }
            else
            {
                NewServer.Dispose();
            }

        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            Game game;
            newGame.ShowDialog(this);
            if (newGame.DialogResult == DialogResult.OK)
            {
                game = new Game(newGame.GetGameName(), newGame.GetGenreSelector());
                newGame.Dispose();
                Commands.SetGame(game,this);
            }
            else
                newGame.Dispose();
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == true)
                this.Visible = false;
        }
        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewToolStripMenuItem.Checked == false)
            {
                listViewToolStripMenuItem.Checked = true;
                nodeViewToolStripMenuItem.Checked = false;
                treeView.Visible = false;
                listView.Visible = true;

            }

        }

        private void nodeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nodeViewToolStripMenuItem.Checked == false)
            {
                nodeViewToolStripMenuItem.Checked = true;
                listViewToolStripMenuItem.Checked = false;
                treeView.Visible = true;
                listView.Visible = false;
            }

        }
        
        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(track!=null)
            track.Disable(this);
        }
        #endregion

        #region Menu Tray

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            track.Disable(this);
            this.Dispose();
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Visible = true;
        }
        
        private void disableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (track != null)
                track.Disable(this);
        }

        #endregion

        #region help
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras posuere tortor elit, id imperdiet diam condimentum in. Cras nec tellus et orci porttitor accumsan nec nec arcu. In vel vehicula velit, nec mollis lorem. Aliquam sit amet libero cursus, placerat massa quis, consequat magna. Maecenas venenatis quam nec viverra fermentum. Aenean in feugiat magna. Praesent condimentum aliquet ante, sed ullamcorper lacus euismod in. Duis facilisis tellus a urna tincidunt, nec commodo dui commodo. Ut in leo arcu. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Ut nec tortor lobortis, ullamcorper tortor sit amet, varius dui. Morbi ullamcorper nunc eget mauris fringilla tristique. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. ";
            MessageBox.Show(text,"Help",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Version 0.¸8.1 \n Pinger Software \n Copyright LGPL license \n"+ " http://www.gnu.org/licenses/lgpl.html ", "About", MessageBoxButtons.OK);
        }
        #endregion

        #region Form 

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
                labelSelectedServer.Text = listView.SelectedItems[0].Text;
            else
                listView.SelectedItems.Clear();
        }
 
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView.SelectedNode.Parent != null)
            {
                string str = treeView.SelectedNode.Text;
                var arr = str.Split(' ');
                var newtext = String.Join(" ", arr.Take(arr.Length - 1));
                labelSelectedServer.Text = newtext;
            }

        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (track != null)
                track.Disable(this);
            foreach (Server s in Arrays.servers)
            {
                if (s.GetServerName() == labelSelectedServer.Text)
                {
                    track = new Track();
                    Thread tracker= new Thread(() => track.tracker(s, this));
                    tracker.Start();
                        
                    
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (track != null)
                track.Disable(this);
        }
        #endregion

        #region Save Load Delete
        private void saveServersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadServersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteServersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arrays.servers.Clear();
            Arrays.games.Clear();
            treeView.Nodes.Clear();
            listView.Items.Clear();
        }
        #endregion









    }
}
