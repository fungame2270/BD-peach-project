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
        private SqlCommand cmd;
        private int CurrentStore;

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
        }
        private void storeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storeList.SelectedIndex >= 0)
            {
                CurrentStore = storeList.SelectedIndex;
                showStore();
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

    }
}
