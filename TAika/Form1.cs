using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;
using System.IO;

namespace TAika
{
    public partial class Form1 : Form
    {
        string tanaan;
        int riviID = -1;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        CultureInfo culture;
        TimeSpan kausiTotal;

        DateTime nyt = DateTime.Today;
        int gkk = DateTime.Today.Month;
        int gvv = DateTime.Today.Year;

        MySqlConnection dbconn;

        public Form1()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height - 200;
            this.Width = Screen.PrimaryScreen.Bounds.Width - 200;
            this.Top = 100;

            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd.MM.yyyy";

            //-- Avataan tietokantayhteys
            dbconn = new MySqlConnection(conn);
            dbconn.Open();
            
            culture = new CultureInfo("fi-FI");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            tanaan = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(day.ToLower());
            
            AsetaKellonaika();
            timer1.Start();   
            TaytaGridi(gkk, gvv);
        }

        private void AsetaKellonaika()
        {
            string pvm = DateTime.Now.ToString("dd.MM.yyyy klo HH:mm:ss");          
            lblPaivays.Text = tanaan + ", " + pvm;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AsetaKellonaika();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbconn.Close();
            this.Close();
        }

        private void TaytaGridi(int kk, int vv)
        {
            List<aikarivi> lst = HaeData(kk, vv);
            string ktMin = kausiTotal.Minutes.ToString();

            if (kausiTotal.Minutes < 10)
                ktMin = "0" + kausiTotal.Minutes;

            lblKk.Text = "Tarkasteluajankohta: " + kk + " / " + vv + " - Kausi yhteensä: " + ((kausiTotal.Days * 24) + kausiTotal.Hours) + ":" + ktMin;

            gridi.DataSource = lst;

            gridi.Columns[0].HeaderText = "ID";
            gridi.Columns[1].HeaderText = "Pvm";
            gridi.Columns[2].HeaderText = "Pvm";
            gridi.Columns[3].HeaderText = "Aloitusaika";
            gridi.Columns[4].HeaderText = "Lopetusaika";
            gridi.Columns[5].HeaderText = "Työaika";
            gridi.Columns[6].HeaderText = "Info";

            gridi.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy";
            gridi.Columns[3].DefaultCellStyle.Format = "HH:mm";
            gridi.Columns[4].DefaultCellStyle.Format = "HH:mm";
            
            gridi.Columns[0].Visible = false;
            gridi.Columns[1].Visible = false;

            gridi.Columns[2].FillWeight = 60;
            gridi.Columns[3].FillWeight = 45;
            gridi.Columns[4].FillWeight = 45;
            gridi.Columns[5].FillWeight = 45;
            gridi.Columns[6].FillWeight = 200;

            if (gridi.Rows != null && gridi.Rows.Count > 0)
                riviID = (int)gridi.Rows[0].Cells[0].Value;
            else
                riviID = -1;
        }


        private List<aikarivi> HaeData(int kk, int vv)
        {
            string sql = "select * from tunnit " + 
                "where year(pvm) = " + vv.ToString() + " and " +
                "month(pvm) = " + kk.ToString() + " " +
                "order by pvm desc";

            List<aikarivi> lst = new List<aikarivi>();
            MySqlCommand cmd = new MySqlCommand(sql, dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            long tsum = 0;

            da.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DateTime dd = (DateTime)dr["pvm"];
                    DayOfWeek dow = dd.DayOfWeek;
                    string dayname = culture.DateTimeFormat.GetDayName(dow);
                    string fipv = CultureInfo.CurrentCulture.TextInfo.ToLower(dayname.ToLower());
                    string vp = fipv.Substring(0, 2);

                    aikarivi ar = new aikarivi
                    {
                        id = (int)dr["id"],
                        pvm = dd,
                        vp = dd.ToString(@"dd.MM.yyyy") + " (" + vp + ")",
                        alku = (DateTime)dr["aloitus"],
                        loppu = (DateTime)dr["lopetus"],
                        tyoaika = (string)dr["tyoaika"] + " h",
                        info = (string)dr["info"]
                };
                    lst.Add(ar);

                    tsum = tsum + TimeSpan.Parse(dr["tyoaika"].ToString()).Ticks;
                }
            }
            kausiTotal = TimeSpan.FromTicks(tsum);
            return lst;
        }

        private aikarivi LisaaDatarivi()
        {
            string alkuaika = dtPicker.Value.ToString(@"yyyy-MM-dd") + " " + txtAlkuaika.Text;
            string loppuaika = dtPicker.Value.ToString(@"yyyy-MM-dd") + " " + txtLoppuaika.Text;

            DateTime dt1 = DateTime.Parse(alkuaika);
            DateTime dt2 = DateTime.Parse(loppuaika);
            TimeSpan ts = (dt2 - dt1);

            aikarivi ar = new aikarivi
            {
                id = riviID,
                pvm = DateTime.Parse(dtPicker.Value.ToString(@"yyyy-MM-dd")),
                alku = dt1,
                loppu = dt2,
                tyoaika = ts.ToString(@"hh\:mm"),
                info = txtInfo.Text
            };

            return ar;
        }

        private void PoistaDatarivi(int id)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
          DialogResult dr = MessageBox.Show("Haluatko todellakin poistaa valitun rivin? " + id, "Poisto", buttons); 
            if (dr.Equals(DialogResult.OK))
            {
                string sql = "DELETE FROM tunnit WHERE id = " + riviID;
                MySqlCommand cmd = new MySqlCommand(sql, dbconn);
                cmd.ExecuteNonQuery();

                gridi.DataSource = null;
                gridi.Rows.Clear();
                TaytaGridi(gkk, gvv);
                gridi.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoistaDatarivi(riviID);
        }

        private void gridi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rivi = e.RowIndex;
            if (rivi > -1)
                riviID = (int)gridi.Rows[rivi].Cells[0].Value;
            else
                riviID = 0;
        }


        private void ToggleButtons(bool enabled)
        {
            btnAdd.Enabled = enabled;
            button1.Enabled = enabled;
            kk_eteen.Enabled = enabled;
            kk_taakse.Enabled = enabled;
            button2.Enabled = enabled;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtPicker.Value = nyt;
            txtAlkuaika.Text = "";
            txtLoppuaika.Text = "";
            txtTunnit.Text = "";
            txtInfo.Text = "";
            lblID.Text = "-1";
            riviID = -1;
            pnl.Show();
            ToggleButtons(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnl.Hide();
            ToggleButtons(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aikarivi ar = LisaaDatarivi();
            VieKantaan(ar);

            gridi.DataSource = null;
            gridi.Rows.Clear();
            TaytaGridi(gkk, gvv);

            pnl.Hide();
            gridi.Refresh();
            ToggleButtons(true);
        }


        private void VieKantaan(aikarivi ar)
        {
            string sql = "";

            if (ar.id == -1)
            {
                sql = "insert into tunnit(pvm, aloitus, lopetus, tyoaika, info) " +
                   "values ('" + ar.pvm.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                               ar.alku.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                               ar.loppu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                               ar.tyoaika +
                   "', '" + ar.info + "');";
            }
            else
            {
                sql = "update tunnit SET " +
                    "pvm = '" + ar.pvm.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    "aloitus = '" + ar.alku.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    "lopetus = '" + ar.loppu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    "tyoaika = '" + ar.tyoaika + "', " +
                    "info = '" + ar.info + "' " + 
                    "where id = " + ar.id;
            }

            MySqlCommand cmd = new MySqlCommand(sql, dbconn);
            cmd.ExecuteNonQuery();
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kk_taakse_Click(object sender, EventArgs e)
        {
            if (gkk > 1)
            {
                gkk = gkk - 1;
            }
            else
            {
                gkk = 12;
                gvv = gvv - 1;
            }

            TaytaGridi(gkk, gvv);
        }

        private void kk_eteen_Click(object sender, EventArgs e)
        {
            
            if (gkk < 12)
            {
                gkk = gkk + 1;
            }
            else
            {
                gkk = 1;
                gvv = gvv + 1;
            }

            TaytaGridi(gkk, gvv);
        }

        private void gridi_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rivi = e.RowIndex;
            if (rivi > -1)
            {
                riviID = (int)gridi.Rows[rivi].Cells[0].Value;
                HaeRiviData(riviID);
            }
        }

        private void HaeRiviData(int id)
        {
            string sql = "select * from tunnit where id = " + id.ToString();
            MySqlCommand cmd = new MySqlCommand(sql, dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                aikarivi ar = new aikarivi();
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    ar.id = id;
                    ar.pvm = DateTime.Parse(dr["pvm"].ToString());
                    ar.alku = DateTime.Parse(dr["aloitus"].ToString());
                    ar.loppu = DateTime.Parse(dr["lopetus"].ToString());
                    ar.tyoaika = dr["tyoaika"].ToString();
                    ar.info = dr["info"].ToString();

                    pnl.Show();
                    lblID.Text = id.ToString();
                    dtPicker.Value = ar.pvm;
                    txtAlkuaika.Text = ar.alku.ToString("HH:mm").Replace(".", ":");
                    txtLoppuaika.Text = ar.loppu.ToString("HH:mm").Replace(".", ":");
                    txtTunnit.Text = ar.tyoaika;
                    txtInfo.Text = ar.info;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string ktMin = kausiTotal.Minutes.ToString();
            string file = @"c:\data\report.txt";
            List<aikarivi> lst = HaeData(gkk, gvv);

            StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8);

            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("\tTYÖAIKARAPORTTI KAUDELTA " + gkk.ToString() + "/" + gvv.ToString());
            sw.WriteLine("\t-----------------------------------------------------------------------------");
            sw.WriteLine("");
            sw.WriteLine("\tPVM\t\tALKU\tLOPPU\tTYÖAIKA\t\tINFO");
            sw.WriteLine("");
            
            foreach(aikarivi ar in lst)
            {
                sw.WriteLine("\t" + ar.pvm.ToString(@"dd.MM.yyyy") + "\t" + ar.alku.ToString("HH:mm") + "\t" + ar.loppu.ToString("HH:mm") + "\t" + ar.tyoaika + "\t\t" + ar.info);
            }

            sw.WriteLine("\t-----------------------------------------------------------------------------");
            if (kausiTotal.Minutes < 10)
                ktMin = "0" + kausiTotal.Minutes;

            sw.WriteLine("\tKausi yhteensä:\t\t\t" + ((kausiTotal.Days * 24) + kausiTotal.Hours) + ":" + ktMin + " h");

            sw.Flush();
            sw.Close();

            System.Diagnostics.Process.Start(file);
        }

        private void gridi_SelectionChanged(object sender, EventArgs e)
        {
            TimeSpan viikoTyoaika = new TimeSpan(37, 30, 0);
            TimeSpan valintaYhteensa = new TimeSpan(0);
            long ticksYhteensa = 0;
            string vMin = "";
            string viikkoYlitys = "";
            long ylitys = 0;
            TimeSpan spanYlitys = new TimeSpan(0);
            string sYlitys = "";

            foreach (DataGridViewRow drv in gridi.SelectedRows)
            {
                string tunnit = drv.Cells[5].Value.ToString().Replace(" h", "");
                long ticksit = TimeSpan.Parse(tunnit).Ticks;
                ticksYhteensa = ticksYhteensa + ticksit;
            }
            valintaYhteensa = TimeSpan.FromTicks(ticksYhteensa);

            if (valintaYhteensa.Minutes < 10)
                vMin = "0" + valintaYhteensa.Minutes;
            else
                vMin = valintaYhteensa.Minutes.ToString();

            string valYht = ((valintaYhteensa.Days * 24) + valintaYhteensa.Hours) + ":" + vMin + " h";

            if (valintaYhteensa.Ticks > viikoTyoaika.Ticks)
            {
                ylitys = valintaYhteensa.Ticks - viikoTyoaika.Ticks;
                spanYlitys = TimeSpan.FromTicks(ylitys);

                if (spanYlitys.Minutes < 10)
                    sYlitys = "0" + spanYlitys.Minutes;
                else
                    sYlitys = spanYlitys.Minutes.ToString();

                viikkoYlitys = " / ylitys +" + ((spanYlitys.Days * 24) + spanYlitys.Hours) + ":" + sYlitys + " h";
            }
            else
                viikkoYlitys = "";


            //-- Näytetään viikkoylitys jos valittujen rivien yhteismäärä ylittää viikkotyötunnit 37.5h.
            lblViikko.Text = "Valinta yhteensä: " + valYht + viikkoYlitys;
        }
    }
}
