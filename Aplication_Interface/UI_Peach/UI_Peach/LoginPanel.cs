using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI_Peach
{
    public partial class LoginPanel : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private bool IsAdm;
        private int storeIdx;


        public LoginPanel()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(225, 112);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(225, 141);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(156, 23);
            this.txtPass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(234, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(597, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source = THE_MACHINE\\SQLEXPRESS;" + "Initial Catalog = peachProject; uid = Teste;" + "password = booga");
        }

        private bool verifySGBDConnection()
        {
            if (conn == null)
                conn = getSGBDConnection();

                conn.Open();

            return conn.State == ConnectionState.Open;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            cmd = new SqlCommand("[loginP]",conn);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar,20).Value = txtUser.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar,64).Value = txtPass.Text;
            cmd.Parameters.Add("@store", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@IsAdm", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            if (Convert.ToBoolean(cmd.Parameters["@IsAdm"].Value))
            {
                Hide();
                AdmPanel amdpanel = new AdmPanel();
                amdpanel.Show();
            }
            else
            {
                Hide();
                int id = Convert.ToInt32(cmd.Parameters["@store"].Value);
                Client stPanel = new Client(id);
                stPanel.Show();
            }

            conn.Close();
        }
    }
}
