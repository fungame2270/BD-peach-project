using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace UI_Peach
{
    public partial class Client : Form
    {
        private SqlConnection conn;
        private int loggedStore;
        private int CurrentSale;
        private int currentRes;

        public Client(int storeIdx)
        {
            InitializeComponent();
            loggedStore = storeIdx;
            loadCompras();
            comprasPane.BringToFront();
        }



        private SqlConnection GetSGBDConnection()
        {
            //return new SqlConnection("Data Source = THE_MACHINE\\SQLEXPRESS;" + "Initial Catalog = peachProject; uid = Teste;" + "password = booga");
            return new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER, 8101; " + " uid = p5g7; " + "password = Paris1020Java ");
        }

        private bool VerifySGBDConnection()
        {
            if (conn == null)
                conn = GetSGBDConnection();

            if (conn.State != ConnectionState.Open)
                conn.Open();

            return conn.State == ConnectionState.Open;
        }

        private void comprasBtn_Click(object sender, EventArgs e)
        {
            comprasPane.BringToFront();
            loadCompras();

        }
        private void loadCompras(String state = null)
        {
            if (!VerifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("dbo.getVendas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 7).Value = state;
            cmd.Parameters.Add("@store", SqlDbType.Int).Value = loggedStore;
            SqlDataReader reader = cmd.ExecuteReader();
            list_compras.Items.Clear();

            while (reader.Read())
            {
                Sale S = new Sale();
                S.Id = reader["id"].ToString();
                S.State = reader["state"].ToString();
                S.StoreName = reader["name"].ToString();
                S.Date = reader["date"].ToString();
                S.StoreId = reader["store"].ToString();
                S.Price = reader["price"].ToString();
                list_compras.Items.Add(S);
            }
            CurrentSale = 0;
            conn.Close();
            showSaleCaixas();

        }
        private void showSaleCaixas()
        {
            if (CurrentSale < 0) return;
            Sale s = new Sale();
            if (list_compras.Items.Count != 0)
            {
                s = (Sale)list_compras.Items[CurrentSale];
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
            if (!VerifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("getCaixasOfsale", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@venda", SqlDbType.Int).Value = venda;
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

        private void list_compras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_compras.SelectedIndex >= 0)
            {
                CurrentSale = list_compras.SelectedIndex;
                Sale s = (Sale)list_compras.SelectedItem;
                showSaleCaixas();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resPanel.BringToFront();
            loadRes();
        }

        private void loadRes()
        {
            if (!VerifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("dbo.getReservas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@store", SqlDbType.Int).Value = loggedStore;
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
            if (listReservations.Items.Count == 0) return;
            Reservation s = new Reservation();
            s = (Reservation)listReservations.Items[currentRes];
            idOfVenda.Text = s.ID;
            loadTCaixasRes(int.Parse(s.ID));

        }

        private void loadTCaixasRes(int res)
        {
            if (!VerifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("getTipoCaixasRes", conn);
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

        private void criar_res_Click(object sender, EventArgs e)
        {
            createResPanel.BringToFront();
            if (CaixaVendaVariedadeBoxDrop.Items.Count == 0)
            {
                if (!VerifySGBDConnection())
                    return;
                SqlCommand command = new SqlCommand("GetVariatyNames", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Variadade S = new Variadade();
                    S.Code = reader["code"].ToString();
                    S.Name = reader["name"].ToString();
                    CaixaVendaVariedadeBoxDrop.Items.Add(S);
                }
                reader.Close();
                conn.Close();
            }
            if (CaixaVendaSizeBoxDrop.Items.Count == 0)
            {
                CaixaVendaSizeBoxDrop.Items.Add("SMALL");
                CaixaVendaSizeBoxDrop.Items.Add("MEDIUM");
                CaixaVendaSizeBoxDrop.Items.Add("BIG");
            }
            loadDisponibilidades();

        }

        private void addCaixatoVenda_Click(object sender, EventArgs e)
        {
            TipoCaixa c = new TipoCaixa();
            Variadade v = CaixaVendaVariedadeBoxDrop.SelectedItem as Variadade;
            c.Vcode = v.Code;
            c.Vname= v.Name;
            c.Size = CaixaVendaSizeBoxDrop.SelectedItem.ToString();
            c.Quantaty = caixaVendaPesoBox.Text;
            caixaVendaPesoBox.Text = "";
            CaixaVendaSizeBoxDrop.SelectionLength = 0;
            CaixaVendaVariedadeBoxDrop.SelectionLength = 0;
            CaixasInVendaCreateList.Items.Add(c);
        }

        private void cancelVenda_Click(object sender, EventArgs e)
        {
            CaixasInVendaCreateList.Items.Clear();
        }

        private void vendaComfirm_Click(object sender, EventArgs e)
        {
            if (!VerifySGBDConnection())
                return;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("code", typeof(Int32));
            dataTable.Columns.Add("size", typeof(String));
            dataTable.Columns.Add("qty", typeof(Int32));
            foreach (TipoCaixa c in CaixasInVendaCreateList.Items)
            {
                dataTable.Rows.Add(c.Vcode, c.Size, c.Quantaty);
            }


            SqlCommand cmd = new SqlCommand("newReserva", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@store", SqlDbType.Int).Value = loggedStore;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateRes.Value.ToString();
            SqlParameter sqlParam = cmd.Parameters.AddWithValue("@caixas", dataTable);
            sqlParam.SqlDbType = SqlDbType.Structured;
            cmd.ExecuteNonQuery();

            conn.Close();
            CaixasInVendaCreateList.Items.Clear();
        }
        private void loadDisponibilidades()
        {
            if (!VerifySGBDConnection())
                return;
            SqlCommand command = new SqlCommand("seeAvailability", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            listTipoCaixaAvilable.Items.Clear();
            while (reader.Read())
            {
                TipoDeCaixa tc = new TipoDeCaixa();
                tc.Name = reader["name"].ToString();
                tc.Size = reader["size"].ToString();
                tc.Availability = reader["availability"].ToString();
                tc.PriceKg = reader["pricekg"].ToString();
                listTipoCaixaAvilable.Items.Add(tc);
            }
            reader.Close();
        }
    }
}
