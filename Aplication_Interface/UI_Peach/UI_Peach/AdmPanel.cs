using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Peach
{
    public partial class AdmPanel : Form
    {
        private SqlConnection conn;
        private int CurrentStore;
        private int CurrentSale;
        private int currentRes;
        private int currentVariety;

        public AdmPanel()
        {
            InitializeComponent();
            storesPanel.BringToFront();
            loadStores();
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            storesPanel.BringToFront();
            loadStores();

        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            salesPanel.BringToFront();
            loadSales();
        }
        private void storeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storeList.SelectedIndex >= 0)
            {
                CurrentStore = storeList.SelectedIndex;
                showStore();
            }
        }
        private void Caixaslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //todo
        }
        private void salesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (salesList.SelectedIndex >= 0)
            {
                CurrentSale = salesList.SelectedIndex;
                Sale s = (Sale)salesList.SelectedItem;
                if (s.State.Equals("CREDITO"))
                    setSalePago.Visible= true;
                else
                    setSalePago.Visible= false;
                showSaleCaixas();
            }
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source = THE_MACHINE\\SQLEXPRESS;" + "Initial Catalog = peachProject; uid = Teste;" + "password = booga");
        }


        private bool verifySGBDConnection()
        {
            if (conn == null)
                conn = getSGBDConnection();

            if (conn.State != ConnectionState.Open)
                conn.Open();

            return conn.State == ConnectionState.Open;
        }

        private void loadStores()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("EXEC dbo.getStores", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            storeList.Items.Clear();

            while (reader.Read())
            {
                Store S = new Store();
                S.Id = reader["id"].ToString();
                S.Name = reader["name"].ToString();
                S.Email = reader["email"].ToString();
                S.Phone = reader["phone"].ToString();
                S.Address = reader["address"].ToString();
                S.Nif = reader["nif"].ToString();
                storeList.Items.Add(S);
            }
            CurrentStore = 0;
            showStore();

            conn.Close();
        }
        private void showStore()
        {
            if(CurrentStore < 0) return;
            Store s = new Store();
            s = (Store)storeList.Items[CurrentStore];
            storeNameBox.Text = s.Name;
            storeEmailBox.Text = s.Email;
            storePhoneBox.Text = s.Phone;
            storeAddressBox.Text = s.Address;
            storeNifBox.Text = s.Nif;
        }

        private void loadSales(int? store= null,String state = null)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("dbo.getVendas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 7).Value = state;
            cmd.Parameters.Add("@store", SqlDbType.Int).Value = store;
            SqlDataReader reader = cmd.ExecuteReader();
            salesList.Items.Clear();

            while (reader.Read())
            {
                Sale S = new Sale();
                S.Id = reader["id"].ToString();
                S.State = reader["state"].ToString();
                S.StoreName= reader["name"].ToString();
                S.Date = reader["date"].ToString();
                S.StoreId= reader["store"].ToString();
                S.Price = reader["price"].ToString();
                salesList.Items.Add(S);
            }
            CurrentSale = 0;
            conn.Close();
            showSaleCaixas();

        }
        private void showSaleCaixas()
        {
            if (CurrentSale < 0) return;
            Sale s = new Sale();
            if(salesList.Items.Count != 0)
            {
            s = (Sale)salesList.Items[CurrentSale];
            idOfVenda.Text = s.Id;
            loadCaixas(int.Parse(s.Id));
            }
            else
            {
                Caixaslist.Items.Clear();
            }
        }

        private void loadCaixas(int venda)
        {
            if(!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("getCaixasOfsale", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@venda",SqlDbType.Int).Value = venda;
            SqlDataReader reader = cmd.ExecuteReader();
            Caixaslist.Items.Clear();
            while (reader.Read())
            {
                Caixa c = new Caixa();
                c.VendaID = reader["venda"].ToString();
                c.CaixaID = reader["id"].ToString();
                c.Variedade = reader["name"].ToString();
                c.Size = reader["size"].ToString();
                c.Weight = reader["weight"].ToString();
                c.Price = reader["price"].ToString();
                Caixaslist.Items.Add(c);
            }
            conn.Close();
        }

        private void stateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (stateCheck.Checked)
                loadSales(state: "CREDITO");
            else
                loadSales();
        }

        private void newStoreStore_Click(object sender, EventArgs e)
        {
            prepareToCreateStor(true);
        }

        private void createStoreButton_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("addStore", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 64).Value = storeNameBox.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 64).Value = storeEmailBox.Text != "" ? storeEmailBox.Text : null;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 9).Value = storePhoneBox.Text;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 64).Value = storeAddressBox.Text;
            int? nif = Convert.ToInt32(storeNifBox.Text);
            cmd.Parameters.Add("@nif", SqlDbType.Int).Value = storeNifBox.Text != "" ? nif : null; 
            cmd.ExecuteNonQuery();
            prepareToCreateStor(false);
        }

        private void cancelStoreC_Click(object sender, EventArgs e)
        {
            prepareToCreateStor(false);
        }

        private void prepareToCreateStor(bool x)
        {
            x = !x;
            storeNameBox.Text = "";
            storeEmailBox.Text = "";
            storePhoneBox.Text = "";
            storeAddressBox.Text = "";
            storeNifBox.Text = "";
            storeList.Enabled = x;
            storeNameBox.ReadOnly = x;
            storeEmailBox.ReadOnly = x;
            storePhoneBox.ReadOnly = x;
            storeAddressBox.ReadOnly = x;
            storeNifBox.ReadOnly = x;
            createStoreButton.Visible = !x;
            cancelStoreC.Visible = !x;
            newStoreStore.Visible = x;
            storeList.Items.Clear();
            if (x) { loadStores(); }
        }

        private void vendaComfirm_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("newVenda",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@store", SqlDbType.Int).Value = Convert.ToInt32(vendacreatestore.Text);
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 7).Value = vendacreatestate.Text;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString();
            cmd.Parameters.Add("@venda", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            int sale = Convert.ToInt32(cmd.Parameters["@venda"].Value);
            foreach(Caixa c in CaixasInVendaCreateList.Items)
            {
                cmd.CommandText = "addToVenda";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@sale", SqlDbType.Int).Value = sale;
                cmd.Parameters.Add("@weigth", SqlDbType.Decimal, 4).Value = c.Weight;
                cmd.Parameters.Add("@code", SqlDbType.Int).Value = c.Variedade;
                cmd.Parameters.Add("@size", SqlDbType.VarChar,6).Value = c.Size;
                cmd.ExecuteNonQuery();

            }
            CaixasInVendaCreateList.Items.Clear();
            salesPanel.BringToFront();

        }

        private void addCaixatoVenda_Click(object sender, EventArgs e)
        {
            Caixa c = new Caixa();
            c.Variedade = CaixaVendaVariedadeBox.Text;
            c.Size = CaixaVendaSizeBox.Text;
            c.Weight = caixaVendaPesoBox.Text;
            caixaVendaPesoBox.Text = "";
            CaixaVendaSizeBox.Text = "";
            CaixaVendaVariedadeBox.Text = "";
            CaixasInVendaCreateList.Items.Add(c);
        }

        private void cancelVenda_Click(object sender, EventArgs e)
        {
            CaixasInVendaCreateList.Items.Clear();
            salesPanel.BringToFront();
        }

        private void CreateSaleBtn_Click(object sender, EventArgs e)
        {
            createSalePanel.BringToFront();
        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {
            reservationPanel.BringToFront();
            loadRes();
        }

        private void loadRes(int? store = null)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("dbo.getReservas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@store", SqlDbType.Int).Value = store;
            SqlDataReader reader = cmd.ExecuteReader();
            listReservations.Items.Clear();

            while (reader.Read())
            {
                Reservation S = new Reservation();
                S.ID = reader["id"].ToString();
                S.StoreName = reader["name"].ToString();
                S.Date = reader["date"].ToString();
                S.StoreId = reader["store"].ToString();
                S.Quantaty = reader["quantity"].ToString();
                listReservations.Items.Add(S);
            }
            currentRes = 0;
            conn.Close();
            showResTCaixas();

        }
        private void showResTCaixas()
        {
            if (currentRes < 0) return;
            Reservation s = new Reservation();
            s = (Reservation)listReservations.Items[currentRes];
            idOfVenda.Text = s.ID;
            loadTCaixasRes(int.Parse(s.ID));

        }

        private void loadTCaixasRes(int res)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("getTipoCaixas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@reserva", SqlDbType.Int).Value = res;
            SqlDataReader reader = cmd.ExecuteReader();
            listtipocReserva.Items.Clear();
            while (reader.Read())
            {
                TipoCaixa T = new TipoCaixa();
                T.Vcode = reader["code"].ToString();
                T.Vname = reader["name"].ToString();
                T.Size = reader["size"].ToString();
                T.reservation = reader["reservation"].ToString();
                T.Quantaty = reader["quantity"].ToString();
                T.PriceKg = reader["pricekg"].ToString();
                listtipocReserva.Items.Add(T);
            }
            conn.Close();
        }

        private void listReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listReservations.SelectedIndex >= 0)
            {
                currentRes = listReservations.SelectedIndex;
                showResTCaixas();
            }
        }

        private void VariedadesBtn_Click(object sender, EventArgs e)
        {
            VariedadesPanel.BringToFront();
            loadVari();
            loadFito();

        }
        private void loadVari()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("dbo.getVariedadesCuraState", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            listVarietys.Items.Clear();

            while (reader.Read())
            {
                Variadade v = new Variadade();
                v.Code = reader["code"].ToString();
                v.Name= reader["name"].ToString();
                v.Season = reader["season"].ToString().Substring(0,4);
                v.Trees = reader["trees"].ToString() ;
                v.Available = reader["disponibilidade"].ToString();
                listVarietys.Items.Add(v);
            }
            currentVariety = 0;
            conn.Close();

        }
        private void loadFito()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("dbo.getFito", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            listFito.Items.Clear();

            while (reader.Read())
            {
                string v = String.Format("{0,-3} {1,-20} {2,2}", reader["id"], reader["name"], reader["interval_days"]);
                listFito.Items.Add(v);
            }
            conn.Close();

        }

        private void setSalePago_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            Sale s = (Sale)salesList.Items[CurrentSale];
            SqlCommand cmd = new SqlCommand("updateVendaState", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(s.Id);
            cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = "PAGO";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated with sucess");
            loadSales();
        }

        private void listVarietys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVarietys.SelectedIndex >= 0)
            {
                currentVariety = listVarietys.SelectedIndex;
                showCuras();
            }
        }

        private void showCuras()
        {
            if (!verifySGBDConnection())
                return;
            Variadade v = (Variadade)listVarietys.Items[currentVariety];
            SqlCommand cmd = new SqlCommand("curasNaVariedade", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(v.Code);
            SqlDataReader reader = cmd.ExecuteReader();
            CurasAplicadasVariedade.Items.Clear();
            while (reader.Read())
            {
                string s = String.Format("{0,-2} {1}", reader["fitofarmaceutic"], reader["DateH"]);
                CurasAplicadasVariedade.Items.Add(s);
            }
            conn.Close();
        }
    }
}
