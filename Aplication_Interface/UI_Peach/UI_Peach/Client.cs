using System;
using System.Collections.Generic;
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
        private DataTable dataTable;
        private DataTable dataTable1;
        private List<Store> ClientList; // Declaração correta da lista
        private SqlDataAdapter dataAdapter;

        public Client(int storeIdx)
        {
            InitializeComponent();

            ClientList = new List<Store>(); // Inicialização da lista

            LoadHistorico();
        }

        public Client()
        {
            InitializeComponent();

            ClientList = new List<Store>(); // Inicialização da lista

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
            ClientList.Clear(); // Limpa a lista antes de preenchê-la novamente

            while (reader.Read())
            {
                Store store = new Store();
                store.Id = reader["id"].ToString();
                store.Name = reader["name"].ToString();
                store.Email = reader["email"].ToString();
                store.Phone = reader["phone"].ToString();
                store.Address = reader["address"].ToString();
                store.Nif = reader["nif"].ToString();
                ClientList.Add(store); // Adiciona o objeto à lista
            }

            CurrentStore = 0;
            ShowClient();

            reader.Close(); // Fecha o SqlDataReader
        }

        private void ShowClient()
        {
            if (CurrentStore < 0 || CurrentStore >= ClientList.Count) return;

            Store s = ClientList[CurrentStore];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadHistorico();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create a new instance of the SqlDataAdapter
                    dataAdapter = new SqlDataAdapter();

                    // Set the SelectCommand to the stored procedure
                    dataAdapter.SelectCommand = new SqlCommand("reservastodas", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    // Create a new DataTable
                    dataTable = new DataTable();

                    // Fill the DataTable with the data from the stored procedure
                    dataAdapter.Fill(dataTable);

                    // Set the DataTable as the data source for the DataGridView
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }

      
        private void Historic_btn1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create a new instance of the SqlDataAdapter
                    dataAdapter = new SqlDataAdapter();

                    // Set the SelectCommand to the stored procedure
                    dataAdapter.SelectCommand = new SqlCommand("spLoja", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    // Create a new DataTable
                    dataTable = new DataTable();

                    // Fill the DataTable with the data from the stored procedure
                    dataAdapter.Fill(dataTable);

                    // Set the DataTable as the data source for the DataGridView
                    dataGridView3.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //remover reserva
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //criar  reserva
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            LoginPanel homepage = new LoginPanel();
            homepage.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //pag inicial
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
        //aqui em baixo panel de inseir reverva
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["VerDetalhes"].Index && e.RowIndex >= 0)
            {
                int vendaId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["VendaId"].Value);

                // Chame a stored procedure "getCaixasOfSale" para obter os dados
                using (SqlConnection connection = new SqlConnection("ConnectionString"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("getCaixasOfSale", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@venda", vendaId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Popule o DataGridView com os dados retornados
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    SELECT[name] FROM peachProject.LOJA;


        //}
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            string sql = "SELECT [name] FROM peachProject.LOJA";

        //            using (SqlCommand command = new SqlCommand(sql, connection))
        //            {
        //                SqlDataReader reader = command.ExecuteReader();

        //                List<string> storeNames = new List<string>();

        //                while (reader.Read())
        //                {
        //                    string name = reader["name"].ToString();
        //                    storeNames.Add(name);
        //                }

        //                dataGridView3.DataSource = storeNames;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //}
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            string sql = "SELECT [name] FROM peachProject.LOJA";

        //            using (SqlCommand command = new SqlCommand(sql, connection))
        //            {
        //                SqlDataReader reader = command.ExecuteReader();

        //                comboBox1.Items.Clear(); // Limpa os itens existentes no comboBox1

        //                while (reader.Read())
        //                {
        //                    string name = reader["name"].ToString();
        //                    comboBox1.Items.Add(name); // Adiciona o nome da loja ao comboBox1
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }

        //}
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    string sql = "SELECT [name] FROM peachProject.LOJA";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = await command.ExecuteReaderAsync();

                        List<string> storeNames = new List<string>();

                        while (await reader.ReadAsync())
                        {
                            string name = reader["name"].ToString();
                            storeNames.Add(name);
                        }

                        comboBox1.BeginInvoke(new Action(() =>
                        {
                            comboBox1.Items.Clear(); // Limpa os itens existentes no comboBox1
                            comboBox1.Items.AddRange(storeNames.ToArray()); // Adiciona os nomes das lojas ao comboBox1
                        }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Verifique se o TextBox está vazio
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                // Ação a ser executada quando o texto é alterado
                string quantidadeKg = textBox3.Text;

                // Faça algo com a quantidade em kg, como salvar em uma variável ou chamar um método
                // por exemplo: SalvarQuantidadeKg(quantidadeKg);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Verifique se o TextBox está vazio
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Ação a ser executada quando o texto é alterado
                string data = textBox2.Text;

                // Faça algo com a data, como salvar em uma variável ou chamar um método
                // por exemplo: SalvarData(data);
            }
        }
        private void SeuMetodoDeBotao_Click(object sender, EventArgs e)
        {
            string conexaoString = "SuaConnectionString"; // Substitua pela string de conexão do seu banco de dados
            string comandoSql = "INSERT INTO RESERVA (RESERVA) VALUES (@data)"; // Substitua pelos valores corretos

            using (SqlConnection conexao = new SqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand(comandoSql, conexao))
                    {
                        comando.Parameters.AddWithValue("@data", textBox2.Text);

                        comando.ExecuteNonQuery();
                    }

                    // Ação a ser executada após a inserção bem-sucedida
                    // por exemplo: MessageBox.Show("Inserção bem-sucedida!");
                }
                catch (SqlException ex)
                {
                    // Lidar com o erro do SQL Server
                    MessageBox.Show("Erro ao inserir na tabela RESERVA: " + ex.Message);
                }
            }
        }

        private void BtnAddReserva_Click(object sender, EventArgs e)
        {
            int reservaId;
            if (int.TryParse(TxB_Id.Text, out reservaId))
            {
                // Verifique se os campos foram preenchidos corretamente
                if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(BtnTamanhoP.Text))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");
                    return;
                }

                string tamanho = BtnTamanhoP.Text;
                string nomeLoja = textBox2.Text;
                string data = textBox3.Text;
                int quantidade;

                if (!int.TryParse(comboBox1.Text, out quantidade))
                {
                    MessageBox.Show("Quantidade inválida. Insira um valor numérico válido.");
                    return;
                }

                try
                {
                    if (!VerifySGBDConnection())
                        return;

                    // Obtenha o ID da loja com base no nome da loja
                    string queryLoja = "SELECT id FROM peachProject.LOJA WHERE [name] = @NomeLoja";
                    SqlCommand cmdLoja = new SqlCommand(queryLoja, conn);
                    cmdLoja.Parameters.AddWithValue("@NomeLoja", nomeLoja);

                    object resultLoja = cmdLoja.ExecuteScalar();
                    if (resultLoja != null && int.TryParse(resultLoja.ToString(), out int lojaId))
                    {
                        // Insira os dados da reserva no banco de dados
                        string queryReserva = "INSERT INTO peachProject.RESERVA (id, [date], store) VALUES (@ReservaId, @Data, @LojaId)";
                        SqlCommand cmdReserva = new SqlCommand(queryReserva, conn);
                        cmdReserva.Parameters.AddWithValue("@ReservaId", reservaId);
                        cmdReserva.Parameters.AddWithValue("@Data", data);
                        cmdReserva.Parameters.AddWithValue("@LojaId", lojaId);

                        int rowsAffectedReserva = cmdReserva.ExecuteNonQuery();

                        if (rowsAffectedReserva > 0)
                        {
                            // Obter o ID da reserva inserida
                            string queryReservaId = "SELECT SCOPE_IDENTITY()";
                            SqlCommand cmdReservaId = new SqlCommand(queryReservaId, conn);
                            int novaReservaId = Convert.ToInt32(cmdReservaId.ExecuteScalar());

                            // Inserir os dados da reserva na tabela TIPOCAIXARESERVA
                            string queryTipoCaixaReserva = "INSERT INTO peachProject.TIPOCAIXARESERVA (reservation, code, size, quantity) VALUES (@ReservaId, @Code, @Size, @Quantity)";
                            SqlCommand cmdTipoCaixaReserva = new SqlCommand(queryTipoCaixaReserva, conn);
                            cmdTipoCaixaReserva.Parameters.AddWithValue("@ReservaId", novaReservaId);
                            cmdTipoCaixaReserva.Parameters.AddWithValue("@Code", 1); // Substitua pelos valores desejados
                            cmdTipoCaixaReserva.Parameters.AddWithValue("@Size", tamanho);
                            cmdTipoCaixaReserva.Parameters.AddWithValue("@Quantity", quantidade);

                            int rowsAffectedTipoCaixaReserva = cmdTipoCaixaReserva.ExecuteNonQuery();

                            if (rowsAffectedTipoCaixaReserva > 0)
                            {
                                MessageBox.Show("Reserva adicionada com sucesso.");
                                // Faça qualquer outra ação necessária após adicionar a reserva
                            }
                            else
                            {
                                MessageBox.Show("Falha ao adicionar reserva.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falha ao adicionar reserva.");
                        }

                    }
                }
                catch { }
            }
        }




        private void BtnTamanhoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = BtnTamanhoP.SelectedItem.ToString();

            try
            {
                if (!VerifySGBDConnection())
                    return;

                // Consultar o banco de dados para armazenar a opção selecionada
                string query = "INSERT INTO UserSelection ([Option]) VALUES (@Option)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Option", selectedOption);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    //if (rowsAffected > 0)
                    //{
                    //    MessageBox.Show("Opção armazenada com sucesso no banco de dados.");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Falha ao armazenar a opção no banco de dados.");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }



        //panbel de revover reserva aqui em baixo


        private void Criar_rev_btn2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;

            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create a new instance of the SqlDataAdapter
                    dataAdapter = new SqlDataAdapter();

                    // Set the SelectCommand to the stored procedure
                    dataAdapter.SelectCommand = new SqlCommand("reservastodas", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    // Create a new DataTable
                    dataTable = new DataTable();

                    // Fill the DataTable with the data from the stored procedure
                    dataAdapter.Fill(dataTable);

                    // Set the DataTable as the data source for the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }


        private void Btn_R_Reversa_Click(object sender, EventArgs e)
        {
            

            int reservaId;
            if (int.TryParse(TxB_Id.Text, out reservaId))
            {
                string query = "DELETE FROM peachProject.RESERVA WHERE id = @ReservaId";
                using (SqlConnection connection = new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; " + " uid = p5g7; " + "password = Paris1020Java "))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservaId", reservaId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Reserva removida com sucesso!");
                // Atualizar o DataGridView2 com as reservas atualizadas
                dataGridView2_CellContentClick();
            }
            else
            {
                MessageBox.Show("ID de reserva inválido!");
            }

         
        }

        private void dataGridView2_CellContentClick()
        {
            ;
            string query = "SELECT * FROM peachProject.Reservas";

            using (SqlConnection connection = new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; " + " uid = p5g7; " + "password = Paris1020Java "))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable1 = new DataTable();
                    adapter.Fill(dataTable1);
                    dataGridView2.DataSource = dataTable1;
                }
            }
        }

        private void TxB_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["VerDetalhes"].Index && e.RowIndex >= 0)
            {
                int vendaId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["VendaId"].Value);

                // Chame a stored procedure "getCaixasOfSale" para obter os dados
                using (SqlConnection connection = new SqlConnection("ConnectionString"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("getCaixasOfSale", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@venda", vendaId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Popule o DataGridView com os dados retornados
                    dataGridView2.DataSource = dataTable;
                }
            }


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
