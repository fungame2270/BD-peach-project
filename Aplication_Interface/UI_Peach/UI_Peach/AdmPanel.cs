using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                showSaleCaixas();
            }
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ");
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
            s = (Sale)salesList.Items[CurrentSale];
            idOfVenda.Text = s.Id;
            loadCaixas(int.Parse(s.Id));
            
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
            cmd.Parameters.Add("@store", SqlDbType.Int).Value = Convert.ToInt32(vendacreatestore);
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 7).Value = vendacreatestate.Text;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            cmd.ExecuteNonQuery();

            foreach(Caixa c in CaixasInVendaCreateList.Items)
            {
                cmd.CommandText = "addToVenda";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@sale", SqlDbType.Int).Value = Convert.ToInt32(vendacreatestore);
                cmd.Parameters.Add("@state", SqlDbType.VarChar, 7).Value = vendacreatestate.Text;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;

            }

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
        }
    }
}
