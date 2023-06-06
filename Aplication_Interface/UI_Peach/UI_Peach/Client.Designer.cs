namespace UI_Peach
{
    partial class Client
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
            this.comprasBtn = new System.Windows.Forms.Button();
            this.comprasPane = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idOfVenda = new System.Windows.Forms.Label();
            this.Caixaslist = new System.Windows.Forms.ListBox();
            this.list_compras = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resPanel = new System.Windows.Forms.Panel();
            this.listtipocReserva = new System.Windows.Forms.ListBox();
            this.listReservations = new System.Windows.Forms.ListBox();
            this.criar_res = new System.Windows.Forms.Button();
            this.createResPanel = new System.Windows.Forms.Panel();
            this.CaixaVendaSizeBoxDrop = new System.Windows.Forms.ComboBox();
            this.CaixaVendaVariedadeBoxDrop = new System.Windows.Forms.ComboBox();
            this.CaixasInVendaCreateList = new System.Windows.Forms.ListBox();
            this.addCaixatoVenda = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.caixaVendaPesoBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelVenda = new System.Windows.Forms.Button();
            this.vendaComfirm = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.listTipoCaixaAvilable = new System.Windows.Forms.ListBox();
            this.dateRes = new System.Windows.Forms.DateTimePicker();
            this.comprasPane.SuspendLayout();
            this.resPanel.SuspendLayout();
            this.createResPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comprasBtn
            // 
            this.comprasBtn.Location = new System.Drawing.Point(12, 12);
            this.comprasBtn.Name = "comprasBtn";
            this.comprasBtn.Size = new System.Drawing.Size(93, 42);
            this.comprasBtn.TabIndex = 0;
            this.comprasBtn.Text = "As Minhas Compras";
            this.comprasBtn.UseVisualStyleBackColor = true;
            this.comprasBtn.Click += new System.EventHandler(this.comprasBtn_Click);
            // 
            // comprasPane
            // 
            this.comprasPane.Controls.Add(this.label2);
            this.comprasPane.Controls.Add(this.label1);
            this.comprasPane.Controls.Add(this.idOfVenda);
            this.comprasPane.Controls.Add(this.Caixaslist);
            this.comprasPane.Controls.Add(this.list_compras);
            this.comprasPane.Location = new System.Drawing.Point(12, 83);
            this.comprasPane.Name = "comprasPane";
            this.comprasPane.Size = new System.Drawing.Size(1186, 436);
            this.comprasPane.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Compras:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Venda:";
            // 
            // idOfVenda
            // 
            this.idOfVenda.AutoSize = true;
            this.idOfVenda.Location = new System.Drawing.Point(709, 9);
            this.idOfVenda.Name = "idOfVenda";
            this.idOfVenda.Size = new System.Drawing.Size(18, 13);
            this.idOfVenda.TabIndex = 14;
            this.idOfVenda.Text = "ID";
            // 
            // Caixaslist
            // 
            this.Caixaslist.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixaslist.FormattingEnabled = true;
            this.Caixaslist.ItemHeight = 14;
            this.Caixaslist.Location = new System.Drawing.Point(671, 25);
            this.Caixaslist.Name = "Caixaslist";
            this.Caixaslist.Size = new System.Drawing.Size(430, 368);
            this.Caixaslist.TabIndex = 13;
            // 
            // list_compras
            // 
            this.list_compras.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_compras.FormattingEnabled = true;
            this.list_compras.ItemHeight = 14;
            this.list_compras.Location = new System.Drawing.Point(17, 25);
            this.list_compras.Name = "list_compras";
            this.list_compras.Size = new System.Drawing.Size(586, 368);
            this.list_compras.TabIndex = 12;
            this.list_compras.SelectedIndexChanged += new System.EventHandler(this.list_compras_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "As Minhas Reservas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resPanel
            // 
            this.resPanel.Controls.Add(this.listtipocReserva);
            this.resPanel.Controls.Add(this.listReservations);
            this.resPanel.Location = new System.Drawing.Point(12, 83);
            this.resPanel.Name = "resPanel";
            this.resPanel.Size = new System.Drawing.Size(1198, 436);
            this.resPanel.TabIndex = 3;
            // 
            // listtipocReserva
            // 
            this.listtipocReserva.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listtipocReserva.FormattingEnabled = true;
            this.listtipocReserva.ItemHeight = 14;
            this.listtipocReserva.Location = new System.Drawing.Point(612, 9);
            this.listtipocReserva.Name = "listtipocReserva";
            this.listtipocReserva.Size = new System.Drawing.Size(574, 410);
            this.listtipocReserva.TabIndex = 10;
            // 
            // listReservations
            // 
            this.listReservations.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listReservations.FormattingEnabled = true;
            this.listReservations.ItemHeight = 14;
            this.listReservations.Location = new System.Drawing.Point(17, 9);
            this.listReservations.Name = "listReservations";
            this.listReservations.Size = new System.Drawing.Size(571, 410);
            this.listReservations.TabIndex = 8;
            // 
            // criar_res
            // 
            this.criar_res.Location = new System.Drawing.Point(210, 12);
            this.criar_res.Name = "criar_res";
            this.criar_res.Size = new System.Drawing.Size(93, 42);
            this.criar_res.TabIndex = 4;
            this.criar_res.Text = "Criar Reserva";
            this.criar_res.UseVisualStyleBackColor = true;
            this.criar_res.Click += new System.EventHandler(this.criar_res_Click);
            // 
            // createResPanel
            // 
            this.createResPanel.Controls.Add(this.dateRes);
            this.createResPanel.Controls.Add(this.label19);
            this.createResPanel.Controls.Add(this.listTipoCaixaAvilable);
            this.createResPanel.Controls.Add(this.CaixaVendaSizeBoxDrop);
            this.createResPanel.Controls.Add(this.CaixaVendaVariedadeBoxDrop);
            this.createResPanel.Controls.Add(this.CaixasInVendaCreateList);
            this.createResPanel.Controls.Add(this.addCaixatoVenda);
            this.createResPanel.Controls.Add(this.label11);
            this.createResPanel.Controls.Add(this.caixaVendaPesoBox);
            this.createResPanel.Controls.Add(this.label10);
            this.createResPanel.Controls.Add(this.label9);
            this.createResPanel.Controls.Add(this.cancelVenda);
            this.createResPanel.Controls.Add(this.vendaComfirm);
            this.createResPanel.Location = new System.Drawing.Point(12, 83);
            this.createResPanel.Margin = new System.Windows.Forms.Padding(2);
            this.createResPanel.Name = "createResPanel";
            this.createResPanel.Size = new System.Drawing.Size(1198, 436);
            this.createResPanel.TabIndex = 6;
            // 
            // CaixaVendaSizeBoxDrop
            // 
            this.CaixaVendaSizeBoxDrop.FormattingEnabled = true;
            this.CaixaVendaSizeBoxDrop.Location = new System.Drawing.Point(468, 83);
            this.CaixaVendaSizeBoxDrop.Name = "CaixaVendaSizeBoxDrop";
            this.CaixaVendaSizeBoxDrop.Size = new System.Drawing.Size(241, 21);
            this.CaixaVendaSizeBoxDrop.TabIndex = 17;
            // 
            // CaixaVendaVariedadeBoxDrop
            // 
            this.CaixaVendaVariedadeBoxDrop.FormattingEnabled = true;
            this.CaixaVendaVariedadeBoxDrop.Location = new System.Drawing.Point(468, 43);
            this.CaixaVendaVariedadeBoxDrop.Name = "CaixaVendaVariedadeBoxDrop";
            this.CaixaVendaVariedadeBoxDrop.Size = new System.Drawing.Size(241, 21);
            this.CaixaVendaVariedadeBoxDrop.TabIndex = 16;
            // 
            // CaixasInVendaCreateList
            // 
            this.CaixasInVendaCreateList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixasInVendaCreateList.FormattingEnabled = true;
            this.CaixasInVendaCreateList.ItemHeight = 14;
            this.CaixasInVendaCreateList.Location = new System.Drawing.Point(714, 9);
            this.CaixasInVendaCreateList.Margin = new System.Windows.Forms.Padding(2);
            this.CaixasInVendaCreateList.Name = "CaixasInVendaCreateList";
            this.CaixasInVendaCreateList.Size = new System.Drawing.Size(469, 410);
            this.CaixasInVendaCreateList.TabIndex = 13;
            // 
            // addCaixatoVenda
            // 
            this.addCaixatoVenda.Location = new System.Drawing.Point(556, 163);
            this.addCaixatoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.addCaixatoVenda.Name = "addCaixatoVenda";
            this.addCaixatoVenda.Size = new System.Drawing.Size(75, 29);
            this.addCaixatoVenda.TabIndex = 12;
            this.addCaixatoVenda.Text = "Add TipoCaixa";
            this.addCaixatoVenda.UseVisualStyleBackColor = true;
            this.addCaixatoVenda.Click += new System.EventHandler(this.addCaixatoVenda_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 110);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "quantidade";
            // 
            // caixaVendaPesoBox
            // 
            this.caixaVendaPesoBox.Location = new System.Drawing.Point(466, 129);
            this.caixaVendaPesoBox.Margin = new System.Windows.Forms.Padding(2);
            this.caixaVendaPesoBox.Name = "caixaVendaPesoBox";
            this.caixaVendaPesoBox.Size = new System.Drawing.Size(243, 20);
            this.caixaVendaPesoBox.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Variedade";
            // 
            // cancelVenda
            // 
            this.cancelVenda.Location = new System.Drawing.Point(608, 238);
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
            this.vendaComfirm.Location = new System.Drawing.Point(504, 238);
            this.vendaComfirm.Margin = new System.Windows.Forms.Padding(2);
            this.vendaComfirm.Name = "vendaComfirm";
            this.vendaComfirm.Size = new System.Drawing.Size(75, 29);
            this.vendaComfirm.TabIndex = 4;
            this.vendaComfirm.Text = "Comfirm";
            this.vendaComfirm.UseVisualStyleBackColor = true;
            this.vendaComfirm.Click += new System.EventHandler(this.vendaComfirm_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Tipo De Caixa e Suas Variedades";
            // 
            // listTipoCaixaAvilable
            // 
            this.listTipoCaixaAvilable.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTipoCaixaAvilable.FormattingEnabled = true;
            this.listTipoCaixaAvilable.ItemHeight = 14;
            this.listTipoCaixaAvilable.Location = new System.Drawing.Point(3, 28);
            this.listTipoCaixaAvilable.Name = "listTipoCaixaAvilable";
            this.listTipoCaixaAvilable.Size = new System.Drawing.Size(459, 410);
            this.listTipoCaixaAvilable.TabIndex = 18;
            // 
            // dateRes
            // 
            this.dateRes.Location = new System.Drawing.Point(493, 197);
            this.dateRes.Name = "dateRes";
            this.dateRes.Size = new System.Drawing.Size(200, 20);
            this.dateRes.TabIndex = 20;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 540);
            this.Controls.Add(this.createResPanel);
            this.Controls.Add(this.criar_res);
            this.Controls.Add(this.resPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comprasPane);
            this.Controls.Add(this.comprasBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.Text = "Client";
            this.comprasPane.ResumeLayout(false);
            this.comprasPane.PerformLayout();
            this.resPanel.ResumeLayout(false);
            this.createResPanel.ResumeLayout(false);
            this.createResPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button comprasBtn;
        private System.Windows.Forms.Panel comprasPane;
        private System.Windows.Forms.ListBox list_compras;
        private System.Windows.Forms.ListBox Caixaslist;
        private System.Windows.Forms.Label idOfVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel resPanel;
        private System.Windows.Forms.ListBox listReservations;
        private System.Windows.Forms.ListBox listtipocReserva;
        private System.Windows.Forms.Button criar_res;
        private System.Windows.Forms.Panel createResPanel;
        private System.Windows.Forms.ComboBox CaixaVendaSizeBoxDrop;
        private System.Windows.Forms.ComboBox CaixaVendaVariedadeBoxDrop;
        private System.Windows.Forms.ListBox CaixasInVendaCreateList;
        private System.Windows.Forms.Button addCaixatoVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox caixaVendaPesoBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelVenda;
        private System.Windows.Forms.Button vendaComfirm;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listTipoCaixaAvilable;
        private System.Windows.Forms.DateTimePicker dateRes;
    }
}