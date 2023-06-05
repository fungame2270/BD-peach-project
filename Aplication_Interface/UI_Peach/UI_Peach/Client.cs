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
        private int CurrentStore;
        private DataTable dataTable;
        private List<Store> ClientList; // Declaração correta da lista
        private SqlDataAdapter dataAdapter;



        public Client(int storeIdx)
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
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            int storeId = GetStoreIdForCurrentUser(); // Replace this with your actual logic to retrieve the store ID for the current user

            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create a new instance of the SqlDataAdapter
                    dataAdapter = new SqlDataAdapter();

                    // Set the SelectCommand to the stored procedure
                    dataAdapter.SelectCommand = new SqlCommand("help_me", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@store", storeId);

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
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            // Get the store ID of the currently logged-in user
            int storeId = GetStoreIdForCurrentUser(); // Replace this with your actual logic to retrieve the store ID for the current user

            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create a new instance of the SqlDataAdapter
                    dataAdapter = new SqlDataAdapter();

                    // Set the SelectCommand to the stored procedure
                    dataAdapter.SelectCommand = new SqlCommand("help_me", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@store", storeId);

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

        private int GetStoreIdForCurrentUser()
        {
            return 8; //probelama ao ver qual é o user
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

            //LoginPanel homepage = new LoginPanel();
            //homepage.Show();
            //this.Hide();

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
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Verifique se o TextBox está vazio
            if (!string.IsNullOrWhiteSpace(BtnTamanhoP.Text))
            {
                // Ação a ser executada quando o texto é alterado
                string quantidadeKg = BtnTamanhoP.Text;

                // Faça algo com a quantidade em kg, como salvar em uma variável ou chamar um método
                // por exemplo: SalvarQuantidadeKg(quantidadeKg);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void SeuMetodoDeBotao_Click(object sender, EventArgs e)
        {
            string conexaoString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

           // string conexaoString = "SuaConnectionString"; // Substitua pela string de conexão do seu banco de dados
            string comandoSql = "INSERT INTO RESERVA (RESERVA) VALUES (@data)"; // Substitua pelos valores corretos

            using (SqlConnection conexao = new SqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand(comandoSql, conexao))
                    {
                        comando.Parameters.AddWithValue("@data", TBoxData.Text);

                        comando.ExecuteNonQuery();
                    }

                   
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
            string nome = BtnName.Text;
            int quantidade = int.Parse(BtnTamanhoP.Text);
            DateTime data = DateTime.Parse(TBoxData.Text);
            string tamanhoP = BtnTamanhoP.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(BtnTamanhoP.Text) ||
         string.IsNullOrWhiteSpace(TBoxData.Text) || string.IsNullOrWhiteSpace(tamanhoP))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar a reserva.", "Campos vazios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método, não prossegue com a inserção
            }
            // Aqui você pode adicionar a lógica para inserir esses valores em uma tabela
            // Por exemplo, usando ADO.NET para trabalhar com um banco de dados, ou qualquer outra forma de armazenamento de dados que esteja usando

            // Exemplo usando ADO.NET com SQL Server:
            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO REVERVA (Nome, Quantidade, Data, TamanhoP) VALUES (@Nome, @Quantidade, @Data, @TamanhoP)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Quantidade", quantidade);
                command.Parameters.AddWithValue("@Data", data);
                command.Parameters.AddWithValue("@TamanhoP", tamanhoP);

                connection.Open();
                command.ExecuteNonQuery();
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string selectedOption = BtnTamanhoP.SelectedItem.ToString();

            try
            {
                if (!VerifySGBDConnection())
                    return;

                // Verificar se a opção selecionada é uma das opções desejadas
                if (selectedOption != "SMALL" && selectedOption != "MEDIUM" && selectedOption != "BIG")
                {
                    MessageBox.Show("Opção inválida. Selecione SMALL, MEDIUM ou BIG.");
                    return;
                }

                // Consultar o banco de dados para armazenar a opção selecionada
                string query = "INSERT INTO UserSelection ([Option]) VALUES (@Option)"; //fazer isto aqui
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Option", selectedOption);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Opção armazenada com sucesso no banco de dados.");

                        // Inserir o valor correto na tabela desejada
                        string insertQuery = "INSERT INTO NomeDaTabela (nomeDaColuna) VALUES (@SelectedOption)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@SelectedOption", selectedOption);
                            int insertRowsAffected = insertCmd.ExecuteNonQuery();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao armazenar a opção no banco de dados.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BtnTamanhoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BtnTamanhoP.SelectedItem.ToString() == "SMALL")
            {

            }else if (BtnTamanhoP.SelectedItem.ToString() == "MEDIUM")
            {

            }else if (BtnTamanhoP.SelectedItem.ToString() == "MEDIUM")
            {

            }
            else
            {
                MessageBox.Show("Opção inválida. Selecione SMALL, MEDIUM ou BIG.");
                return;
            }

          
        }
        //panbel de revover reserva aqui em baixo


        private void Criar_rev_btn2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;

            
            
            int storeId = GetStoreIdForCurrentUser(); // Replace this with your actual logic to retrieve the store ID for the current user

            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

            BtnName.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                try
                {
                    connection.Open();
                    string query = "SELECT [name] FROM LOJA";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string medicoName = reader["name"].ToString();
                        BtnName.Items.Add(medicoName);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                //try
                //{
                //    connection.Open();
                //    string query = "SELECT size FROM TIPODECAIXA";
                //    SqlCommand command = new SqlCommand(query, connection);
                //    SqlDataReader reader = command.ExecuteReader();
                //    while (reader.Read())
                //    {
                //        string medicoName = reader["size"].ToString();
                //        BtnTamanhoP.Items.Add(medicoName);
                //    }
                //    reader.Close();
                //    connection.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: " + ex.Message);
                //}


                try
                {
                    // Create a new instance of the SqlDataAdapter
                    dataAdapter = new SqlDataAdapter();

                    // Set the SelectCommand to the stored procedure
                    dataAdapter.SelectCommand = new SqlCommand("help_me", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@store", storeId);

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

        private void Btn_R_Reversa_Click(object sender, EventArgs e)
        {
            int reservaId;
            if (int.TryParse(TxB_Id.Text, out reservaId))
            {
                try
                {
                    string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;User ID=p5g7;Password=Paris1020Java";
                    string query = "DELETE FROM RESERVA WHERE id = @ReservaId";

                    using (SqlConnection connection = new SqlConnection(connectionString))
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
                catch (SqlException ex)
                {
                    //MessageBox.Show("Ocorreu um erro ao tentar remover a reserva: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ID de reserva inválido!");
            }
        }


        private void dataGridView2_CellContentClick()
        {
            int storeId = GetStoreIdForCurrentUser(); // Replace this with your actual logic to retrieve the store ID for the current user

            string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create a new instance of the SqlDataAdapter
                    dataAdapter = new SqlDataAdapter();

                    // Set the SelectCommand to the stored procedure
                    dataAdapter.SelectCommand = new SqlCommand("help_me", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@store", storeId);

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

        private void TxB_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView3.Columns["VerDetalhes"].Index && e.RowIndex >= 0)
            {
                int vendaId = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["VendaId"].Value);

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
        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["VerDetalhes"].Index && e.RowIndex >= 0)
            {
                int vendaId = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["VendaId"].Value);

                // Call the stored procedure "getCaixasOfSale" to retrieve the data
                string connectionString = "Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + " uid = p5g7;" + "password =Paris1020Java ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("getCaixasOfSale", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@venda", vendaId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Populate the DataGridView with the returned data
                    dataGridView2.DataSource = dataTable;
                }
            }
        }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnTamanhoP_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginPanel homepage = new LoginPanel();
            homepage.Show();
            this.Hide();
        }
    }

}
