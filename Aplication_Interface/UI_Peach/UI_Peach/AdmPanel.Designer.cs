namespace UI_Peach
{
    partial class AdmPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.storeButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.VariedadesBtn = new System.Windows.Forms.Button();
            this.storesPanel = new System.Windows.Forms.Panel();
            this.cancelStoreC = new System.Windows.Forms.Button();
            this.createStoreButton = new System.Windows.Forms.Button();
            this.newStoreStore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.storeNifBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storePhoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.storeEmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.storeAddressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storeNameBox = new System.Windows.Forms.TextBox();
            this.storeList = new System.Windows.Forms.ListBox();
            this.salesPanel = new System.Windows.Forms.Panel();
            this.CreateSaleBtn = new System.Windows.Forms.Button();
            this.stateCheck = new System.Windows.Forms.CheckBox();
            this.idOfVenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Caixaslist = new System.Windows.Forms.ListBox();
            this.salesList = new System.Windows.Forms.ListBox();
            this.createSalePanel = new System.Windows.Forms.Panel();
            this.CaixasInVendaCreateList = new System.Windows.Forms.ListBox();
            this.addCaixatoVenda = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.caixaVendaPesoBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CaixaVendaSizeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CaixaVendaVariedadeBox = new System.Windows.Forms.TextBox();
            this.cancelVenda = new System.Windows.Forms.Button();
            this.vendaComfirm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vendacreatestate = new System.Windows.Forms.TextBox();
            this.vendacreatestore = new System.Windows.Forms.TextBox();
            this.reservationPanel = new System.Windows.Forms.Panel();
            this.VariedadesPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.listVarietys = new System.Windows.Forms.ListBox();
            this.listtipocReserva = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listReservations = new System.Windows.Forms.ListBox();
            this.setSalePago = new System.Windows.Forms.Button();
            this.CurasAplicadasVariedade = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listFito = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.storesPanel.SuspendLayout();
            this.salesPanel.SuspendLayout();
            this.createSalePanel.SuspendLayout();
            this.reservationPanel.SuspendLayout();
            this.VariedadesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(13, 12);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(114, 49);
            this.storeButton.TabIndex = 0;
            this.storeButton.Text = "Stores";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(132, 12);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(114, 49);
            this.salesButton.TabIndex = 1;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // reservationsButton
            // 
            this.reservationsButton.Location = new System.Drawing.Point(252, 12);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(114, 49);
            this.reservationsButton.TabIndex = 2;
            this.reservationsButton.Text = "reservations";
            this.reservationsButton.UseVisualStyleBackColor = true;
            this.reservationsButton.Click += new System.EventHandler(this.reservationsButton_Click);
            // 
            // VariedadesBtn
            // 
            this.VariedadesBtn.Location = new System.Drawing.Point(372, 12);
            this.VariedadesBtn.Name = "VariedadesBtn";
            this.VariedadesBtn.Size = new System.Drawing.Size(114, 49);
            this.VariedadesBtn.TabIndex = 3;
            this.VariedadesBtn.Text = "Variedades/Curas";
            this.VariedadesBtn.UseVisualStyleBackColor = true;
            this.VariedadesBtn.Click += new System.EventHandler(this.VariedadesBtn_Click);
            // 
            // storesPanel
            // 
            this.storesPanel.Controls.Add(this.cancelStoreC);
            this.storesPanel.Controls.Add(this.createStoreButton);
            this.storesPanel.Controls.Add(this.newStoreStore);
            this.storesPanel.Controls.Add(this.label6);
            this.storesPanel.Controls.Add(this.storeNifBox);
            this.storesPanel.Controls.Add(this.label5);
            this.storesPanel.Controls.Add(this.storePhoneBox);
            this.storesPanel.Controls.Add(this.label4);
            this.storesPanel.Controls.Add(this.storeEmailBox);
            this.storesPanel.Controls.Add(this.label3);
            this.storesPanel.Controls.Add(this.storeAddressBox);
            this.storesPanel.Controls.Add(this.label2);
            this.storesPanel.Controls.Add(this.storeNameBox);
            this.storesPanel.Controls.Add(this.storeList);
            this.storesPanel.Location = new System.Drawing.Point(11, 66);
            this.storesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.storesPanel.Name = "storesPanel";
            this.storesPanel.Size = new System.Drawing.Size(1386, 522);
            this.storesPanel.TabIndex = 4;
            // 
            // cancelStoreC
            // 
            this.cancelStoreC.Location = new System.Drawing.Point(681, 276);
            this.cancelStoreC.Margin = new System.Windows.Forms.Padding(2);
            this.cancelStoreC.Name = "cancelStoreC";
            this.cancelStoreC.Size = new System.Drawing.Size(61, 26);
            this.cancelStoreC.TabIndex = 13;
            this.cancelStoreC.Text = "Cancel";
            this.cancelStoreC.UseVisualStyleBackColor = true;
            this.cancelStoreC.Visible = false;
            this.cancelStoreC.Click += new System.EventHandler(this.cancelStoreC_Click);
            // 
            // createStoreButton
            // 
            this.createStoreButton.Location = new System.Drawing.Point(562, 276);
            this.createStoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.createStoreButton.Name = "createStoreButton";
            this.createStoreButton.Size = new System.Drawing.Size(61, 26);
            this.createStoreButton.TabIndex = 12;
            this.createStoreButton.Text = "Create";
            this.createStoreButton.UseVisualStyleBackColor = true;
            this.createStoreButton.Visible = false;
            this.createStoreButton.Click += new System.EventHandler(this.createStoreButton_Click);
            // 
            // newStoreStore
            // 
            this.newStoreStore.Location = new System.Drawing.Point(46, 452);
            this.newStoreStore.Margin = new System.Windows.Forms.Padding(2);
            this.newStoreStore.Name = "newStoreStore";
            this.newStoreStore.Size = new System.Drawing.Size(70, 27);
            this.newStoreStore.TabIndex = 11;
            this.newStoreStore.Text = "New Store";
            this.newStoreStore.UseVisualStyleBackColor = true;
            this.newStoreStore.Click += new System.EventHandler(this.newStoreStore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nif:";
            // 
            // storeNifBox
            // 
            this.storeNifBox.Location = new System.Drawing.Point(505, 235);
            this.storeNifBox.Name = "storeNifBox";
            this.storeNifBox.ReadOnly = true;
            this.storeNifBox.Size = new System.Drawing.Size(293, 20);
            this.storeNifBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // storePhoneBox
            // 
            this.storePhoneBox.Location = new System.Drawing.Point(505, 187);
            this.storePhoneBox.Name = "storePhoneBox";
            this.storePhoneBox.ReadOnly = true;
            this.storePhoneBox.Size = new System.Drawing.Size(293, 20);
            this.storePhoneBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emal:";
            // 
            // storeEmailBox
            // 
            this.storeEmailBox.Location = new System.Drawing.Point(505, 142);
            this.storeEmailBox.Name = "storeEmailBox";
            this.storeEmailBox.ReadOnly = true;
            this.storeEmailBox.Size = new System.Drawing.Size(293, 20);
            this.storeEmailBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // storeAddressBox
            // 
            this.storeAddressBox.Location = new System.Drawing.Point(505, 94);
            this.storeAddressBox.Name = "storeAddressBox";
            this.storeAddressBox.ReadOnly = true;
            this.storeAddressBox.Size = new System.Drawing.Size(293, 20);
            this.storeAddressBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // storeNameBox
            // 
            this.storeNameBox.Location = new System.Drawing.Point(502, 43);
            this.storeNameBox.Name = "storeNameBox";
            this.storeNameBox.ReadOnly = true;
            this.storeNameBox.Size = new System.Drawing.Size(293, 20);
            this.storeNameBox.TabIndex = 1;
            // 
            // storeList
            // 
            this.storeList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeList.FormattingEnabled = true;
            this.storeList.ItemHeight = 16;
            this.storeList.Location = new System.Drawing.Point(12, 12);
            this.storeList.Name = "storeList";
            this.storeList.Size = new System.Drawing.Size(462, 404);
            this.storeList.TabIndex = 0;
            this.storeList.SelectedIndexChanged += new System.EventHandler(this.storeList_SelectedIndexChanged);
            // 
            // salesPanel
            // 
            this.salesPanel.Controls.Add(this.setSalePago);
            this.salesPanel.Controls.Add(this.CreateSaleBtn);
            this.salesPanel.Controls.Add(this.stateCheck);
            this.salesPanel.Controls.Add(this.idOfVenda);
            this.salesPanel.Controls.Add(this.label1);
            this.salesPanel.Controls.Add(this.Caixaslist);
            this.salesPanel.Controls.Add(this.salesList);
            this.salesPanel.Location = new System.Drawing.Point(6, 66);
            this.salesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.salesPanel.Name = "salesPanel";
            this.salesPanel.Size = new System.Drawing.Size(1403, 515);
            this.salesPanel.TabIndex = 1;
            // 
            // CreateSaleBtn
            // 
            this.CreateSaleBtn.Location = new System.Drawing.Point(17, 392);
            this.CreateSaleBtn.Name = "CreateSaleBtn";
            this.CreateSaleBtn.Size = new System.Drawing.Size(114, 45);
            this.CreateSaleBtn.TabIndex = 5;
            this.CreateSaleBtn.Text = "Create Sale";
            this.CreateSaleBtn.UseVisualStyleBackColor = true;
            this.CreateSaleBtn.Click += new System.EventHandler(this.CreateSaleBtn_Click);
            // 
            // stateCheck
            // 
            this.stateCheck.AutoSize = true;
            this.stateCheck.Location = new System.Drawing.Point(365, 5);
            this.stateCheck.Margin = new System.Windows.Forms.Padding(2);
            this.stateCheck.Name = "stateCheck";
            this.stateCheck.Size = new System.Drawing.Size(53, 17);
            this.stateCheck.TabIndex = 4;
            this.stateCheck.Text = "Credit";
            this.stateCheck.UseVisualStyleBackColor = true;
            this.stateCheck.CheckedChanged += new System.EventHandler(this.stateCheck_CheckedChanged);
            // 
            // idOfVenda
            // 
            this.idOfVenda.AutoSize = true;
            this.idOfVenda.Location = new System.Drawing.Point(778, 12);
            this.idOfVenda.Name = "idOfVenda";
            this.idOfVenda.Size = new System.Drawing.Size(18, 13);
            this.idOfVenda.TabIndex = 3;
            this.idOfVenda.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caixas da Venda";
            // 
            // Caixaslist
            // 
            this.Caixaslist.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixaslist.FormattingEnabled = true;
            this.Caixaslist.ItemHeight = 16;
            this.Caixaslist.Location = new System.Drawing.Point(685, 27);
            this.Caixaslist.Name = "Caixaslist";
            this.Caixaslist.Size = new System.Drawing.Size(672, 388);
            this.Caixaslist.TabIndex = 1;
            this.Caixaslist.SelectedIndexChanged += new System.EventHandler(this.Caixaslist_SelectedIndexChanged);
            // 
            // salesList
            // 
            this.salesList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesList.FormattingEnabled = true;
            this.salesList.ItemHeight = 16;
            this.salesList.Location = new System.Drawing.Point(7, 27);
            this.salesList.Margin = new System.Windows.Forms.Padding(2);
            this.salesList.Name = "salesList";
            this.salesList.Size = new System.Drawing.Size(652, 340);
            this.salesList.TabIndex = 0;
            this.salesList.SelectedIndexChanged += new System.EventHandler(this.salesList_SelectedIndexChanged);
            // 
            // createSalePanel
            // 
            this.createSalePanel.Controls.Add(this.CaixasInVendaCreateList);
            this.createSalePanel.Controls.Add(this.addCaixatoVenda);
            this.createSalePanel.Controls.Add(this.label11);
            this.createSalePanel.Controls.Add(this.caixaVendaPesoBox);
            this.createSalePanel.Controls.Add(this.label10);
            this.createSalePanel.Controls.Add(this.CaixaVendaSizeBox);
            this.createSalePanel.Controls.Add(this.label9);
            this.createSalePanel.Controls.Add(this.CaixaVendaVariedadeBox);
            this.createSalePanel.Controls.Add(this.cancelVenda);
            this.createSalePanel.Controls.Add(this.vendaComfirm);
            this.createSalePanel.Controls.Add(this.label8);
            this.createSalePanel.Controls.Add(this.label7);
            this.createSalePanel.Controls.Add(this.vendacreatestate);
            this.createSalePanel.Controls.Add(this.vendacreatestore);
            this.createSalePanel.Location = new System.Drawing.Point(4, 64);
            this.createSalePanel.Margin = new System.Windows.Forms.Padding(2);
            this.createSalePanel.Name = "createSalePanel";
            this.createSalePanel.Size = new System.Drawing.Size(1403, 515);
            this.createSalePanel.TabIndex = 5;
            // 
            // CaixasInVendaCreateList
            // 
            this.CaixasInVendaCreateList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixasInVendaCreateList.FormattingEnabled = true;
            this.CaixasInVendaCreateList.ItemHeight = 14;
            this.CaixasInVendaCreateList.Location = new System.Drawing.Point(661, 14);
            this.CaixasInVendaCreateList.Margin = new System.Windows.Forms.Padding(2);
            this.CaixasInVendaCreateList.Name = "CaixasInVendaCreateList";
            this.CaixasInVendaCreateList.Size = new System.Drawing.Size(387, 312);
            this.CaixasInVendaCreateList.TabIndex = 13;
            // 
            // addCaixatoVenda
            // 
            this.addCaixatoVenda.Location = new System.Drawing.Point(283, 165);
            this.addCaixatoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.addCaixatoVenda.Name = "addCaixatoVenda";
            this.addCaixatoVenda.Size = new System.Drawing.Size(75, 29);
            this.addCaixatoVenda.TabIndex = 12;
            this.addCaixatoVenda.Text = "Add Caixa";
            this.addCaixatoVenda.UseVisualStyleBackColor = true;
            this.addCaixatoVenda.Click += new System.EventHandler(this.addCaixatoVenda_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "peso";
            // 
            // caixaVendaPesoBox
            // 
            this.caixaVendaPesoBox.Location = new System.Drawing.Point(257, 132);
            this.caixaVendaPesoBox.Margin = new System.Windows.Forms.Padding(2);
            this.caixaVendaPesoBox.Name = "caixaVendaPesoBox";
            this.caixaVendaPesoBox.Size = new System.Drawing.Size(243, 20);
            this.caixaVendaPesoBox.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Size";
            // 
            // CaixaVendaSizeBox
            // 
            this.CaixaVendaSizeBox.Location = new System.Drawing.Point(257, 85);
            this.CaixaVendaSizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.CaixaVendaSizeBox.Name = "CaixaVendaSizeBox";
            this.CaixaVendaSizeBox.Size = new System.Drawing.Size(243, 20);
            this.CaixaVendaSizeBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Variedade(int)";
            // 
            // CaixaVendaVariedadeBox
            // 
            this.CaixaVendaVariedadeBox.Location = new System.Drawing.Point(257, 45);
            this.CaixaVendaVariedadeBox.Margin = new System.Windows.Forms.Padding(2);
            this.CaixaVendaVariedadeBox.Name = "CaixaVendaVariedadeBox";
            this.CaixaVendaVariedadeBox.Size = new System.Drawing.Size(243, 20);
            this.CaixaVendaVariedadeBox.TabIndex = 6;
            // 
            // cancelVenda
            // 
            this.cancelVenda.Location = new System.Drawing.Point(118, 123);
            this.cancelVenda.Margin = new System.Windows.Forms.Padding(2);
            this.cancelVenda.Name = "cancelVenda";
            this.cancelVenda.Size = new System.Drawing.Size(75, 29);
            this.cancelVenda.TabIndex = 5;
            this.cancelVenda.Text = "cancel";
            this.cancelVenda.UseVisualStyleBackColor = true;
            this.cancelVenda.Click += new System.EventHandler(this.cancelVenda_Click);
            // 
            // vendaComfirm
            // 
            this.vendaComfirm.Location = new System.Drawing.Point(26, 123);
            this.vendaComfirm.Margin = new System.Windows.Forms.Padding(2);
            this.vendaComfirm.Name = "vendaComfirm";
            this.vendaComfirm.Size = new System.Drawing.Size(75, 29);
            this.vendaComfirm.TabIndex = 4;
            this.vendaComfirm.Text = "Comfirm";
            this.vendaComfirm.UseVisualStyleBackColor = true;
            this.vendaComfirm.Click += new System.EventHandler(this.vendaComfirm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "state";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "store";
            // 
            // vendacreatestate
            // 
            this.vendacreatestate.Location = new System.Drawing.Point(31, 79);
            this.vendacreatestate.Margin = new System.Windows.Forms.Padding(2);
            this.vendacreatestate.Name = "vendacreatestate";
            this.vendacreatestate.Size = new System.Drawing.Size(162, 20);
            this.vendacreatestate.TabIndex = 1;
            // 
            // vendacreatestore
            // 
            this.vendacreatestore.Location = new System.Drawing.Point(31, 45);
            this.vendacreatestore.Margin = new System.Windows.Forms.Padding(2);
            this.vendacreatestore.Name = "vendacreatestore";
            this.vendacreatestore.Size = new System.Drawing.Size(162, 20);
            this.vendacreatestore.TabIndex = 0;
            // 
            // reservationPanel
            // 
            this.reservationPanel.Controls.Add(this.listtipocReserva);
            this.reservationPanel.Controls.Add(this.label12);
            this.reservationPanel.Controls.Add(this.listReservations);
            this.reservationPanel.Location = new System.Drawing.Point(4, 63);
            this.reservationPanel.Name = "reservationPanel";
            this.reservationPanel.Size = new System.Drawing.Size(1405, 522);
            this.reservationPanel.TabIndex = 6;
            // 
            // VariedadesPanel
            // 
            this.VariedadesPanel.Controls.Add(this.label15);
            this.VariedadesPanel.Controls.Add(this.listFito);
            this.VariedadesPanel.Controls.Add(this.label14);
            this.VariedadesPanel.Controls.Add(this.CurasAplicadasVariedade);
            this.VariedadesPanel.Controls.Add(this.label13);
            this.VariedadesPanel.Controls.Add(this.listVarietys);
            this.VariedadesPanel.Location = new System.Drawing.Point(4, 63);
            this.VariedadesPanel.Name = "VariedadesPanel";
            this.VariedadesPanel.Size = new System.Drawing.Size(1407, 525);
            this.VariedadesPanel.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Variedades";
            // 
            // listVarietys
            // 
            this.listVarietys.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVarietys.FormattingEnabled = true;
            this.listVarietys.ItemHeight = 14;
            this.listVarietys.Location = new System.Drawing.Point(9, 40);
            this.listVarietys.Name = "listVarietys";
            this.listVarietys.Size = new System.Drawing.Size(467, 410);
            this.listVarietys.TabIndex = 10;
            this.listVarietys.SelectedIndexChanged += new System.EventHandler(this.listVarietys_SelectedIndexChanged);
            // 
            // listtipocReserva
            // 
            this.listtipocReserva.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listtipocReserva.FormattingEnabled = true;
            this.listtipocReserva.ItemHeight = 14;
            this.listtipocReserva.Location = new System.Drawing.Point(737, 31);
            this.listtipocReserva.Name = "listtipocReserva";
            this.listtipocReserva.Size = new System.Drawing.Size(600, 410);
            this.listtipocReserva.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Reservations";
            // 
            // listReservations
            // 
            this.listReservations.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listReservations.FormattingEnabled = true;
            this.listReservations.ItemHeight = 14;
            this.listReservations.Location = new System.Drawing.Point(17, 32);
            this.listReservations.Name = "listReservations";
            this.listReservations.Size = new System.Drawing.Size(641, 410);
            this.listReservations.TabIndex = 7;
            this.listReservations.SelectedIndexChanged += new System.EventHandler(this.listReservations_SelectedIndexChanged);
            // 
            // setSalePago
            // 
            this.setSalePago.Location = new System.Drawing.Point(152, 392);
            this.setSalePago.Name = "setSalePago";
            this.setSalePago.Size = new System.Drawing.Size(114, 45);
            this.setSalePago.TabIndex = 6;
            this.setSalePago.Text = "Set sale to Pago";
            this.setSalePago.UseVisualStyleBackColor = true;
            this.setSalePago.Click += new System.EventHandler(this.setSalePago_Click);
            // 
            // CurasAplicadasVariedade
            // 
            this.CurasAplicadasVariedade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurasAplicadasVariedade.FormattingEnabled = true;
            this.CurasAplicadasVariedade.ItemHeight = 14;
            this.CurasAplicadasVariedade.Location = new System.Drawing.Point(512, 40);
            this.CurasAplicadasVariedade.Name = "CurasAplicadasVariedade";
            this.CurasAplicadasVariedade.Size = new System.Drawing.Size(318, 410);
            this.CurasAplicadasVariedade.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Curas Aplicadas numa variedade";
            // 
            // listFito
            // 
            this.listFito.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFito.FormattingEnabled = true;
            this.listFito.ItemHeight = 14;
            this.listFito.Location = new System.Drawing.Point(849, 40);
            this.listFito.Name = "listFito";
            this.listFito.Size = new System.Drawing.Size(457, 410);
            this.listFito.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(846, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "fitofarmaceutics";
            // 
            // AdmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 592);
            this.Controls.Add(this.VariedadesBtn);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.VariedadesPanel);
            this.Controls.Add(this.reservationPanel);
            this.Controls.Add(this.createSalePanel);
            this.Controls.Add(this.salesPanel);
            this.Controls.Add(this.storesPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdmPanel";
            this.Text = "Form2";
            this.storesPanel.ResumeLayout(false);
            this.storesPanel.PerformLayout();
            this.salesPanel.ResumeLayout(false);
            this.salesPanel.PerformLayout();
            this.createSalePanel.ResumeLayout(false);
            this.createSalePanel.PerformLayout();
            this.reservationPanel.ResumeLayout(false);
            this.reservationPanel.PerformLayout();
            this.VariedadesPanel.ResumeLayout(false);
            this.VariedadesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button VariedadesBtn;
        private System.Windows.Forms.Panel storesPanel;
        private System.Windows.Forms.ListBox storeList;
        private System.Windows.Forms.Panel salesPanel;
        private System.Windows.Forms.TextBox storeNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox storeAddressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox storeNifBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox storePhoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox storeEmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox salesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Caixaslist;
        private System.Windows.Forms.Label idOfVenda;
        private System.Windows.Forms.CheckBox stateCheck;
        private System.Windows.Forms.Button newStoreStore;
        private System.Windows.Forms.Button cancelStoreC;
        private System.Windows.Forms.Button createStoreButton;
        private System.Windows.Forms.Panel createSalePanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vendacreatestate;
        private System.Windows.Forms.TextBox vendacreatestore;
        private System.Windows.Forms.Button vendaComfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox caixaVendaPesoBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CaixaVendaSizeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CaixaVendaVariedadeBox;
        private System.Windows.Forms.Button addCaixatoVenda;
        private System.Windows.Forms.ListBox CaixasInVendaCreateList;
        private System.Windows.Forms.Button CreateSaleBtn;
        private System.Windows.Forms.Panel reservationPanel;
        private System.Windows.Forms.ListBox listtipocReserva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listReservations;
        private System.Windows.Forms.Panel VariedadesPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listVarietys;
        private System.Windows.Forms.Button setSalePago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox CurasAplicadasVariedade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listFito;
    }
}