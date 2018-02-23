using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Ishod3Zad1
{
    class Program
    {
        static DataSet ds;

        static DataTable tblIzvodac;
        static DataTable tblAlbum;
        static DataTable tblPjesma;

        static SqlDataAdapter daIzvodac;
        static SqlDataAdapter daAlbum;
        static SqlDataAdapter daPjesma;

        static DataColumn colIzvodjacID;
        static DataColumn colIDIzvodjac;

        static DataColumn colAlbumID;
        static DataColumn colIDAlbum;

        static DataColumn colPjesmaID;
        static DataColumn colIDPjesma;


        static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        static void Main(string[] args)
        {
            SetupDataSet();
            ShowMenu();

            return;
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Prikaz izvodjaca");
            Console.WriteLine("Q. Izlaz");
            Console.WriteLine("-----------------------");

            switch (Console.ReadLine().ToUpper())
            {
                case "1":
                    Console.Clear();
                    ShowIzvodjaci();
                    ReturnToMenu();
                    break;
            
                case "K":
                    return;
                default:
                    ShowMenu();
                    break;
            }
        }

        private static void ShowIzvodjaci()
        {
            foreach (DataRow row in tblIzvodac.Rows)
            {

                Console.WriteLine("ID:{0}, {1}",
                    row["IDIzvodjac"].ToString(),
                    row["Ime"].ToString());

            }
            Console.WriteLine("Unesite za kojeg izvodjaca zelite vidjeti albume");
            int temp = Convert.ToInt32(Console.ReadLine());
            ShowAlbumi(temp);
        }

        private static void ShowAlbumi(int temp)
        {
            foreach (DataRow row in tblAlbum.Rows)
            {
                if ((int)row["IzvodjacID"]==temp)
                {
                    Console.WriteLine("ID:{0}, {1}",
                    row["IDAlbum"].ToString(),
                    row["NaslovAlbuma"].ToString());
                }
                

            }
            Console.WriteLine("Unesite za kojeg album zelite vidjeti pjesme");
            int albumID = Convert.ToInt32(Console.ReadLine());
            ShowPjesme(albumID);
        }

        private static void ShowPjesme(int albumID)
        {
            foreach (DataRow row in tblPjesma.Rows)
            {
                if ((int)row["AlbumID"] == albumID)
                {
                    Console.WriteLine("ID:{0}, {1}",
                    row["IDPjesma"].ToString(),
                    row["NaslovPjesme"].ToString());
                }


            }
        }

        private static void ReturnToMenu()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Povratak na izbornik...");
            Console.ReadKey();

            ShowMenu();
        }


        private static void SetupDataSet()
        {
            ds = new DataSet();

            daIzvodac = new SqlDataAdapter("SELECT * FROM Izvodjac", new SqlConnection(cs));
            daAlbum = new SqlDataAdapter("SELECT * FROM Album", new SqlConnection(cs));
            daPjesma = new SqlDataAdapter("SELECT * FROM Pjesma", new SqlConnection(cs));

            daIzvodac.Fill(ds, "Izvodjac");
            daAlbum.Fill(ds, "Album");
            daPjesma.Fill(ds, "Pjesma");

            tblIzvodac = ds.Tables["Izvodjac"];
            colIDIzvodjac = tblIzvodac.Columns["IDIzvodjac"];
            tblIzvodac.Columns["IDIzvodjac"].AutoIncrement = true;
            tblIzvodac.PrimaryKey = new DataColumn[] { ds.Tables["Izvodjac"].Columns["IDIzvodjac"] };

            tblAlbum = ds.Tables["Album"];
            colIDAlbum = tblAlbum.Columns["IDAlbum"];
            colIzvodjacID = tblAlbum.Columns["IzvodjacID"];
            tblAlbum.Columns["IDAlbum"].AutoIncrement = true;
            tblAlbum.PrimaryKey = new DataColumn[] { ds.Tables["Album"].Columns["IDAlbum"] };


            tblPjesma = ds.Tables["Pjesma"];
            colIDPjesma = tblPjesma.Columns["IDPjesma"];
            colAlbumID = tblPjesma.Columns["AlbumID"];
            tblPjesma.PrimaryKey = new DataColumn[] { colIDPjesma };

            new SqlCommandBuilder(daAlbum);
            new SqlCommandBuilder(daIzvodac);
            new SqlCommandBuilder(daPjesma);

            ds.Relations.Add(new DataRelation("Izvodjac_Album", colIDIzvodjac, colIzvodjacID));
            ds.Relations.Add(new DataRelation("Album_Pjesma", colIDAlbum, colAlbumID));
        }

    }
}
