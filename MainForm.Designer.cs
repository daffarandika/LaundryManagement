namespace Laundry_Management
{
    partial class MainForm
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.RichTextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbJemput = new System.Windows.Forms.CheckBox();
            this.cbAntar = new System.Windows.Forms.CheckBox();
            this.tbJemput = new System.Windows.Forms.TextBox();
            this.tbAntar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbHari = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 174);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(776, 219);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellValueChanged);
            this.dgvOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOrder_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Penerimaan Order Baru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomer Telpon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alamat Pelanggan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal Masuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tanggal Selesai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lama";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(119, 60);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(197, 20);
            this.tbPhone.TabIndex = 0;
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(119, 86);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 20);
            this.tbName.TabIndex = 9;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(118, 113);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(198, 55);
            this.tbAlamat.TabIndex = 10;
            this.tbAlamat.Text = "";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(430, 51);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 11;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(430, 78);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 12;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(430, 104);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(60, 20);
            this.tbDays.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hari";
            // 
            // cbJemput
            // 
            this.cbJemput.AutoSize = true;
            this.cbJemput.Location = new System.Drawing.Point(430, 130);
            this.cbJemput.Name = "cbJemput";
            this.cbJemput.Size = new System.Drawing.Size(67, 17);
            this.cbJemput.TabIndex = 15;
            this.cbJemput.Text = "Dijemput";
            this.cbJemput.UseVisualStyleBackColor = true;
            // 
            // cbAntar
            // 
            this.cbAntar.AutoSize = true;
            this.cbAntar.Location = new System.Drawing.Point(529, 130);
            this.cbAntar.Name = "cbAntar";
            this.cbAntar.Size = new System.Drawing.Size(60, 17);
            this.cbAntar.TabIndex = 16;
            this.cbAntar.Text = "Diantar";
            this.cbAntar.UseVisualStyleBackColor = true;
            // 
            // tbJemput
            // 
            this.tbJemput.Location = new System.Drawing.Point(701, 434);
            this.tbJemput.Name = "tbJemput";
            this.tbJemput.Size = new System.Drawing.Size(87, 20);
            this.tbJemput.TabIndex = 20;
            this.tbJemput.Text = "0";
            // 
            // tbAntar
            // 
            this.tbAntar.Location = new System.Drawing.Point(701, 408);
            this.tbAntar.Name = "tbAntar";
            this.tbAntar.Size = new System.Drawing.Size(87, 20);
            this.tbAntar.TabIndex = 17;
            this.tbAntar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Biaya Jemput";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Biaya Antar";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(701, 488);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(87, 20);
            this.tbTotal.TabIndex = 24;
            this.tbTotal.Text = "0";
            // 
            // tbHari
            // 
            this.tbHari.Location = new System.Drawing.Point(701, 462);
            this.tbHari.Name = "tbHari";
            this.tbHari.Size = new System.Drawing.Size(87, 20);
            this.tbHari.TabIndex = 21;
            this.tbHari.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(606, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Biaya Hari";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbHari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbJemput);
            this.Controls.Add(this.tbAntar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbAntar);
            this.Controls.Add(this.cbJemput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrder);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox tbAlamat;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbJemput;
        private System.Windows.Forms.CheckBox cbAntar;
        private System.Windows.Forms.TextBox tbJemput;
        private System.Windows.Forms.TextBox tbAntar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbHari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

