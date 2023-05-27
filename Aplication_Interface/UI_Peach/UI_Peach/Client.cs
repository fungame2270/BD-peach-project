using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UI_Peach
{
    public partial class Client : Form
    {
        private SqlConnection conn;
        private int CurrentStore;
        private int CurrentSale;

        public object ClientList { get; }

        public Client()
        {
            InitializeComponent();
            ClientList.BringToFront();
            LoadHistorico();
        }

        private SqlConnection GetSGBDConnection()
        {
            return new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ");
        }

        private bool VerifySGBDConnection()
        {
            if (conn == null)
                conn = GetSGBDConnection();

            if (conn.State != ConnectionState.Open)
                conn.Open();

            return conn.State == ConnectionState.Open;
        }

        private void LoadHistorico()
        {
            if (!VerifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("EXEC dbo.getStores", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ClientList.Items.Clear();

            while (reader.Read())
            {
                //Crie uma estrutura de dados Store para armazenar os dados do banco de dados
                // e adicione à lista storeList
                // Exemplo:
                Store store = new Store();
                store.Id = reader["id"].ToString();
                store.Name = reader["name"].ToString();
                store.Email = reader["email"].ToString();
                store.Phone = reader["phone"].ToString();
                store.Address = reader["address"].ToString();
                store.Nif = reader["nif"].ToString();
                ClientList.Items.Add(store);
            }

            CurrentStore = 0;
            ShowStore();
            conn.Close();
        }

 

        private void ShowStore()
        {
            if (CurrentStore < 0) return;
            Store s = new Store();
            s = (Store)ClientList.Items[CurrentStore];
            storeNameBox.Text = s.Name;
            storeEmailBox.Text = s.Email;
            storePhoneBox.Text = s.Phone;
            storeAddressBox.Text = s.Address;
            storeNifBox.Text = s.Nif;
            ClientList.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadHistorico();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Remov_Rev_Btn(object sender, EventArgs e)
        {

        }

        private void Historic_btn1_Click(object sender, EventArgs e)
        {

        }

        private void Criar_rev_btn2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
