using I3Zad1.DAO;
using I3Zad1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I3Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQLHandler.SetupDataSet();

            napuniListBoxove();

         
        }

        private void napuniListBoxove()
        {
            lbIzvodjaci.Items.Clear();
            lbAlbumi.Items.Clear();
            foreach (DataRow row in SQLHandler.tblIzvodac.Rows)
            {
                lbIzvodjaci.Items.Add(new Izvodac((int)row["IDIzvodjac"],
                                                       row["Ime"].ToString()));
            }
           
           



        }

        private void lbIzvodjaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlbumi.Items.Clear();
            foreach (DataRow row in SQLHandler.tblAlbum.Rows)
            {

                if ((int)row["IzvodjacID"] == ((Izvodac)lbIzvodjaci.SelectedItem).IDIzvodjac)
                {
                    lbAlbumi.Items.Add(new Album((int)row["IDAlbum"],
                                                 (int)row["IzvodjacID"],
                                                      row["NaslovAlbuma"].ToString()));
                }

            }

            tbEditedIzvodjac.Text = ((Izvodac)lbIzvodjaci.SelectedItem).Ime;
        }

        private void lbAlbumi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateIzvodjac_Click(object sender, EventArgs e)
        {
            SQLHandler.UpdateIzvodjac(((Izvodac)lbIzvodjaci.SelectedItem).IDIzvodjac, tbEditedIzvodjac.Text);
            napuniListBoxove();
        }

        private void btnSpremiXML_Click(object sender, EventArgs e)
        {
            SQLHandler.SaveXML();
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            SQLHandler.DeleteAlbum(((Album)lbAlbumi.SelectedItem).IDAlbum);
            napuniListBoxove();
        }
    }
}
