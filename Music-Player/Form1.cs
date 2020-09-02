using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to play music 
            WindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        // Create global variables of string type array to save titles of tracks and path
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            // Code to select multiple files
            ofd.Multiselect = true;

            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Save the names of the track in the file array
                paths = ofd.FileNames; // Save the paths of the tracks in path array
                // Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // Display songs in Listbox
                }
            }
        }

        private void WindowsMediaPlayerMusic_Enter(object sender, EventArgs e)
        {

        }

        private void MusicPlayerApp_Load(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code to close the App
            this.Close();
        }
    }
}
