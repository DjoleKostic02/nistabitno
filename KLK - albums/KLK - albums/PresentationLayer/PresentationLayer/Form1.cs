using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly AlbumBusiness albumBusiness;
        public Form1()
        {
            this.albumBusiness = new AlbumBusiness();
            InitializeComponent();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RefreshData() {

            List<Album> albums = this.albumBusiness.GelAllAlbums();
            listBoxAlbums.Items.Clear();

            foreach (Album a in albums) {
                listBoxAlbums.Items.Add("Id: " + a.Id + "Naslov: " + a.Title + "Umetnik: " + a.Artist + "Cena: " + a.Price); 
           }
        }

        private void buttonInsertAlbum_Click(object sender, EventArgs e)
        {
            Album a = new Album();
            a.Title = textBoxTitle.Text;
            a.Artist = textBoxArtist.Text;
            a.Price = Convert.ToDecimal(textBoxPrice.Text);

            if(this.albumBusiness.InsertAlbum(a))
            {
                RefreshData();
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData() ;
        }
    }
}
