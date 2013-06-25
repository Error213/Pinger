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
    public partial class NewGame : Form
    {
        bool isNameOk = true;
        bool isGenreOk = true;

        public NewGame()
        {
           
            InitializeComponent();
            this.Icon = new Icon("Resources/iconG.ico");
            comboBoxGenre.Items.AddRange(Enum.GetNames(typeof(Game.Genre)));
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        public string GetGameName()
        {
            return txtbxGameName.Text.Trim();
        }

        public int GetGenreSelector()
        {
            return comboBoxGenre.SelectedIndex;
        }

        private void NewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtbxGameName==null)
            {
                isNameOk = false;                
            }
            if (comboBoxGenre.SelectedItem==null)
            {
                isGenreOk = false;
            }
            if(!isGenreOk || !isNameOk)
                this.DialogResult = DialogResult.Cancel;
        }



    }
}
