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
            this.button4 = new System.Windows.Forms.Button();
            this.storesPanel = new System.Windows.Forms.Panel();
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
            this.idOfVenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Caixaslist = new System.Windows.Forms.ListBox();
            this.salesList = new System.Windows.Forms.ListBox();
            this.storesPanel.SuspendLayout();
            this.salesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(19, 18);
            this.storeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(171, 75);
            this.storeButton.TabIndex = 0;
            this.storeButton.Text = "Stores";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(198, 18);
            this.salesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(171, 75);
            this.salesButton.TabIndex = 1;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // reservationsButton
            // 
            this.reservationsButton.Location = new System.Drawing.Point(378, 18);
            this.reservationsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(171, 75);
            this.reservationsButton.TabIndex = 2;
            this.reservationsButton.Text = "reservations";
            this.reservationsButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // storesPanel
            // 
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
            this.storesPanel.Location = new System.Drawing.Point(20, 117);
            this.storesPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storesPanel.Name = "storesPanel";
            this.storesPanel.Size = new System.Drawing.Size(2079, 803);
            this.storesPanel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nif:";
            // 
            // storeNifBox
            // 
            this.storeNifBox.Location = new System.Drawing.Point(758, 362);
            this.storeNifBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeNifBox.Name = "storeNifBox";
            this.storeNifBox.ReadOnly = true;
            this.storeNifBox.Size = new System.Drawing.Size(438, 26);
            this.storeNifBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // storePhoneBox
            // 
            this.storePhoneBox.Location = new System.Drawing.Point(758, 288);
            this.storePhoneBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storePhoneBox.Name = "storePhoneBox";
            this.storePhoneBox.ReadOnly = true;
            this.storePhoneBox.Size = new System.Drawing.Size(438, 26);
            this.storePhoneBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emal:";
            // 
            // storeEmailBox
            // 
            this.storeEmailBox.Location = new System.Drawing.Point(758, 218);
            this.storeEmailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeEmailBox.Name = "storeEmailBox";
            this.storeEmailBox.ReadOnly = true;
            this.storeEmailBox.Size = new System.Drawing.Size(438, 26);
            this.storeEmailBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // storeAddressBox
            // 
            this.storeAddressBox.Location = new System.Drawing.Point(758, 145);
            this.storeAddressBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeAddressBox.Name = "storeAddressBox";
            this.storeAddressBox.ReadOnly = true;
            this.storeAddressBox.Size = new System.Drawing.Size(438, 26);
            this.storeAddressBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // storeNameBox
            // 
            this.storeNameBox.Location = new System.Drawing.Point(753, 66);
            this.storeNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeNameBox.Name = "storeNameBox";
            this.storeNameBox.ReadOnly = true;
            this.storeNameBox.Size = new System.Drawing.Size(438, 26);
            this.storeNameBox.TabIndex = 1;
            // 
            // storeList
            // 
            this.storeList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeList.FormattingEnabled = true;
            this.storeList.ItemHeight = 22;
            this.storeList.Location = new System.Drawing.Point(18, 18);
            this.storeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeList.Name = "storeList";
            this.storeList.Size = new System.Drawing.Size(691, 642);
            this.storeList.TabIndex = 0;
            this.storeList.SelectedIndexChanged += new System.EventHandler(this.storeList_SelectedIndexChanged);
            // 
            // salesPanel
            // 
            this.salesPanel.Controls.Add(this.idOfVenda);
            this.salesPanel.Controls.Add(this.label1);
            this.salesPanel.Controls.Add(this.Caixaslist);
            this.salesPanel.Controls.Add(this.salesList);
            this.salesPanel.Location = new System.Drawing.Point(20, 117);
            this.salesPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesPanel.Name = "salesPanel";
            this.salesPanel.Size = new System.Drawing.Size(2066, 803);
            this.salesPanel.TabIndex = 1;
            // 
            // idOfVenda
            // 
            this.idOfVenda.AutoSize = true;
            this.idOfVenda.Location = new System.Drawing.Point(1167, 18);
            this.idOfVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idOfVenda.Name = "idOfVenda";
            this.idOfVenda.Size = new System.Drawing.Size(26, 20);
            this.idOfVenda.TabIndex = 3;
            this.idOfVenda.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1028, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caixas da Venda";
            // 
            // Caixaslist
            // 
            this.Caixaslist.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixaslist.FormattingEnabled = true;
            this.Caixaslist.ItemHeight = 22;
            this.Caixaslist.Location = new System.Drawing.Point(1028, 42);
            this.Caixaslist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Caixaslist.Name = "Caixaslist";
            this.Caixaslist.Size = new System.Drawing.Size(1006, 598);
            this.Caixaslist.TabIndex = 1;
            this.Caixaslist.SelectedIndexChanged += new System.EventHandler(this.Caixaslist_SelectedIndexChanged);
            // 
            // salesList
            // 
            this.salesList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesList.FormattingEnabled = true;
            this.salesList.ItemHeight = 22;
            this.salesList.Location = new System.Drawing.Point(20, 18);
            this.salesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesList.Name = "salesList";
            this.salesList.Size = new System.Drawing.Size(920, 642);
            this.salesList.TabIndex = 0;
            this.salesList.SelectedIndexChanged += new System.EventHandler(this.salesList_SelectedIndexChanged);
            // 
            // AdmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 938);
            this.Controls.Add(this.salesPanel);
            this.Controls.Add(this.storesPanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.storeButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdmPanel";
            this.Text = "Form2";
            this.storesPanel.ResumeLayout(false);
            this.storesPanel.PerformLayout();
            this.salesPanel.ResumeLayout(false);
            this.salesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button button4;
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
    }
}