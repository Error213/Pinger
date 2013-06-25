using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinger
{
    public partial class NewServer : Form
    {
        bool isNameOk = true;
        bool isIpOk = true;
        bool isGameOk = true;
        public NewServer()
        {
            InitializeComponent();
         
            this.Icon = new Icon("Resources/iconG.ico");
            foreach (var game in Arrays.games)
                comboBoxGame.Items.Add(game);
           
            comboBoxGame.DropDownStyle = ComboBoxStyle.DropDownList;
        }
		 
        public string GetServerName()
        {
            return txtbxServerName.Text.Trim();
        }

        public string GetServerIP()
        {
            return txtbxServerIP.Text.Trim(); 
        }

        public int GetGame()
        {
            return comboBoxGame.SelectedIndex;
        }

        private void NewServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtbxServerName == null)
            {
                isNameOk = false;
            }
            if (txtbxServerIP == null)
            {
                isIpOk = false;
            }
            if (comboBoxGame.SelectedItem == null)
            {
                isGameOk = false;
            }
            if (!isGameOk || !isNameOk || !isIpOk)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
