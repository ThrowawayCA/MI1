using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace I3Zad1.DAO
{
    class SQLHandler
    {
        static DataSet ds;

        public static DataTable tblIzvodac;
        public  static DataTable tblAlbum;
      

        public static SqlDataAdapter daIzvodac;
        public static SqlDataAdapter daAlbum;
    

        public static DataColumn colIzvodjacID;
        public static DataColumn colIDIzvodjac;

        public static DataColumn colAlbumID;
        public static DataColumn colIDAlbum;

      

        static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        private static void ShowAlbumi(int temp)
        {
            foreach (DataRow row in tblAlbum.Rows)
            {
                if ((int)row["IzvodjacID"] == temp)
                {
                    Console.WriteLine("ID:{0}, {1}",
                    row["IDAlbum"].ToString(),
                    row["NaslovAlbuma"].ToString());
                }


            }
            Console.WriteLine("Unesite za kojeg album zelite vidjeti pjesme");
            int albumID = Convert.ToInt32(Console.ReadLine());
     
        }


        public  static void SetupDataSet()
        {
            ds = new DataSet();

            daIzvodac = new SqlDataAdapter("SELECT * FROM Izvodjac", new SqlConnection(cs));
            daAlbum = new SqlDataAdapter("SELECT * FROM Album", new SqlConnection(cs));
         

            daIzvodac.Fill(ds, "Izvodjac");
            daAlbum.Fill(ds, "Album");
          

            tblIzvodac = ds.Tables["Izvodjac"];
            colIDIzvodjac = tblIzvodac.Columns["IDIzvodjac"];
            tblIzvodac.Columns["IDIzvodjac"].AutoIncrement = true;
            tblIzvodac.PrimaryKey = new DataColumn[] { ds.Tables["Izvodjac"].Columns["IDIzvodjac"] };

            tblAlbum = ds.Tables["Album"];
            colIDAlbum = tblAlbum.Columns["IDAlbum"];
            colIzvodjacID = tblAlbum.Columns["IzvodjacID"];
            tblAlbum.Columns["IDAlbum"].AutoIncrement = true;
            tblAlbum.PrimaryKey = new DataColumn[] { ds.Tables["Album"].Columns["IDAlbum"] };


          

            new SqlCommandBuilder(daAlbum);
            new SqlCommandBuilder(daIzvodac);
           

            ds.Relations.Add(new DataRelation("Izvodjac_Album", colIDIzvodjac, colIzvodjacID));
         
        }

        public static void SaveXML()
        {
            try
            {
                ds.WriteXml("Zadatak_32.xml", XmlWriteMode.IgnoreSchema);
                tblAlbum.WriteXml("Zadatak_03_Album.xml", XmlWriteMode.IgnoreSchema);
                Console.WriteLine("Podaci uspjesno spremljeni.");
            }
            catch (Exception)
            {
                Console.WriteLine("Greška prilikom spremanja podataka u XML.");
            }
        }

        public static void UpdateIzvodjac(int id, string naziv)
        {

            DataRow rowKupac = tblIzvodac.Rows.Find(id);
            rowKupac["Ime"] = naziv;
            UpdateDB(daIzvodac, tblIzvodac);

        }

        private static void UpdateDB(SqlDataAdapter da, DataTable dt)
        {
            try
            {
                da.Update(dt);
                Console.WriteLine("Podaci uspješno spremljeni u bazu.");
            }
            catch (Exception)
            {
                Console.WriteLine("Greška prilikom spremanja u bazu.");
            }

        }

        public static void DeleteAlbum(int idAlbum)
        {
            tblAlbum.Rows.Find(idAlbum).Delete();
            Console.WriteLine("Album uspješno obrisan.");
            UpdateDB(daAlbum, tblAlbum);
        }
    }
}
