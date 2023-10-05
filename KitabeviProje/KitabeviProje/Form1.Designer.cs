namespace KitabeviProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customer = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.yazartxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toplamtxt = new System.Windows.Forms.TextBox();
            this.satistxt = new System.Windows.Forms.TextBox();
            this.miktartxt = new System.Windows.Forms.TextBox();
            this.uruntxt = new System.Windows.Forms.TextBox();
            this.barkodtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.satisiptalbutton = new System.Windows.Forms.Button();
            this.finallbl = new System.Windows.Forms.Label();
            this.satisButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.satışListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stok_takibiDataSet = new KitabeviProje.Stok_takibiDataSet();
            this.stoktakibiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepetTableAdapter = new KitabeviProje.Stok_takibiDataSetTableAdapters.sepetTableAdapter();
            this.sepetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logoutbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_takibiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakibiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(329, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.AliceBlue;
            this.customer.Controls.Add(this.pictureBox1);
            this.customer.Controls.Add(this.idtxt);
            this.customer.Controls.Add(this.idLabel);
            this.customer.Controls.Add(this.txtmail);
            this.customer.Controls.Add(this.txtnumber);
            this.customer.Controls.Add(this.txtaddress);
            this.customer.Controls.Add(this.txtname);
            this.customer.Controls.Add(this.label4);
            this.customer.Controls.Add(this.label3);
            this.customer.Controls.Add(this.label2);
            this.customer.Controls.Add(this.label1);
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(11, 55);
            this.customer.Margin = new System.Windows.Forms.Padding(2);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(2);
            this.customer.Size = new System.Drawing.Size(296, 237);
            this.customer.TabIndex = 1;
            this.customer.TabStop = false;
            this.customer.Text = "Müşteri";
            this.customer.Enter += new System.EventHandler(this.customer_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(100, 39);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(129, 27);
            this.idtxt.TabIndex = 22;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged_1);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 39);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(86, 20);
            this.idLabel.TabIndex = 21;
            this.idLabel.Text = "Müşteri İd\'si";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(100, 193);
            this.txtmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(129, 27);
            this.txtmail.TabIndex = 8;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(100, 117);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(129, 27);
            this.txtnumber.TabIndex = 7;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(100, 156);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(129, 27);
            this.txtaddress.TabIndex = 6;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 77);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(129, 27);
            this.txtname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad";
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.AliceBlue;
            this.product.Controls.Add(this.label10);
            this.product.Controls.Add(this.yazartxt);
            this.product.Controls.Add(this.pictureBox2);
            this.product.Controls.Add(this.toplamtxt);
            this.product.Controls.Add(this.satistxt);
            this.product.Controls.Add(this.miktartxt);
            this.product.Controls.Add(this.uruntxt);
            this.product.Controls.Add(this.barkodtxt);
            this.product.Controls.Add(this.label9);
            this.product.Controls.Add(this.label8);
            this.product.Controls.Add(this.label7);
            this.product.Controls.Add(this.label6);
            this.product.Controls.Add(this.label5);
            this.product.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(11, 313);
            this.product.Margin = new System.Windows.Forms.Padding(2);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(2);
            this.product.Size = new System.Drawing.Size(297, 261);
            this.product.TabIndex = 2;
            this.product.TabStop = false;
            this.product.Text = "Ürün";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Yazar Adı";
            // 
            // yazartxt
            // 
            this.yazartxt.Location = new System.Drawing.Point(105, 67);
            this.yazartxt.Margin = new System.Windows.Forms.Padding(2);
            this.yazartxt.Name = "yazartxt";
            this.yazartxt.Size = new System.Drawing.Size(129, 27);
            this.yazartxt.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(235, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // toplamtxt
            // 
            this.toplamtxt.Location = new System.Drawing.Point(105, 217);
            this.toplamtxt.Margin = new System.Windows.Forms.Padding(2);
            this.toplamtxt.Name = "toplamtxt";
            this.toplamtxt.Size = new System.Drawing.Size(129, 27);
            this.toplamtxt.TabIndex = 10;
            // 
            // satistxt
            // 
            this.satistxt.Location = new System.Drawing.Point(105, 178);
            this.satistxt.Margin = new System.Windows.Forms.Padding(2);
            this.satistxt.Name = "satistxt";
            this.satistxt.Size = new System.Drawing.Size(129, 27);
            this.satistxt.TabIndex = 6;
            this.satistxt.TextChanged += new System.EventHandler(this.satistxt_TextChanged);
            // 
            // miktartxt
            // 
            this.miktartxt.Location = new System.Drawing.Point(105, 141);
            this.miktartxt.Margin = new System.Windows.Forms.Padding(2);
            this.miktartxt.Name = "miktartxt";
            this.miktartxt.Size = new System.Drawing.Size(129, 27);
            this.miktartxt.TabIndex = 7;
            this.miktartxt.TextChanged += new System.EventHandler(this.miktartxt_TextChanged);
            // 
            // uruntxt
            // 
            this.uruntxt.Location = new System.Drawing.Point(105, 104);
            this.uruntxt.Margin = new System.Windows.Forms.Padding(2);
            this.uruntxt.Name = "uruntxt";
            this.uruntxt.Size = new System.Drawing.Size(129, 27);
            this.uruntxt.TabIndex = 8;
            // 
            // barkodtxt
            // 
            this.barkodtxt.Location = new System.Drawing.Point(105, 24);
            this.barkodtxt.Margin = new System.Windows.Forms.Padding(2);
            this.barkodtxt.Name = "barkodtxt";
            this.barkodtxt.Size = new System.Drawing.Size(129, 27);
            this.barkodtxt.TabIndex = 9;
            this.barkodtxt.TextChanged += new System.EventHandler(this.barkodtxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Toplam Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Barkod No";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(241, 586);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removebutton
            // 
            this.removebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removebutton.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebutton.Location = new System.Drawing.Point(361, 518);
            this.removebutton.Margin = new System.Windows.Forms.Padding(2);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(65, 32);
            this.removebutton.TabIndex = 16;
            this.removebutton.Text = "Sil";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // satisiptalbutton
            // 
            this.satisiptalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.satisiptalbutton.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satisiptalbutton.Location = new System.Drawing.Point(338, 553);
            this.satisiptalbutton.Margin = new System.Windows.Forms.Padding(2);
            this.satisiptalbutton.Name = "satisiptalbutton";
            this.satisiptalbutton.Size = new System.Drawing.Size(114, 38);
            this.satisiptalbutton.TabIndex = 17;
            this.satisiptalbutton.Text = "Satış İptal";
            this.satisiptalbutton.UseVisualStyleBackColor = true;
            this.satisiptalbutton.Click += new System.EventHandler(this.satisiptalbutton_Click);
            // 
            // finallbl
            // 
            this.finallbl.AutoSize = true;
            this.finallbl.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finallbl.Location = new System.Drawing.Point(934, 554);
            this.finallbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finallbl.Name = "finallbl";
            this.finallbl.Size = new System.Drawing.Size(99, 20);
            this.finallbl.TabIndex = 9;
            this.finallbl.Text = "Genel Toplam";
            // 
            // satisButton
            // 
            this.satisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.satisButton.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satisButton.Location = new System.Drawing.Point(1072, 528);
            this.satisButton.Margin = new System.Windows.Forms.Padding(2);
            this.satisButton.Name = "satisButton";
            this.satisButton.Size = new System.Drawing.Size(161, 48);
            this.satisButton.TabIndex = 18;
            this.satisButton.Text = "Satışı Tamamla";
            this.satisButton.UseVisualStyleBackColor = true;
            this.satisButton.Click += new System.EventHandler(this.satisButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.satışListeleToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eklemeToolStripMenuItem,
            this.listelemeToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // eklemeToolStripMenuItem
            // 
            this.eklemeToolStripMenuItem.Name = "eklemeToolStripMenuItem";
            this.eklemeToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.eklemeToolStripMenuItem.Text = "Ekleme";
            this.eklemeToolStripMenuItem.Click += new System.EventHandler(this.eklemeToolStripMenuItem_Click);
            // 
            // listelemeToolStripMenuItem
            // 
            this.listelemeToolStripMenuItem.Name = "listelemeToolStripMenuItem";
            this.listelemeToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.listelemeToolStripMenuItem.Text = "Listeleme";
            this.listelemeToolStripMenuItem.Click += new System.EventHandler(this.listelemeToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eklemeToolStripMenuItem1,
            this.listelemeToolStripMenuItem1});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // eklemeToolStripMenuItem1
            // 
            this.eklemeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriEkleToolStripMenuItem,
            this.markaEkleToolStripMenuItem,
            this.yazarEkleToolStripMenuItem});
            this.eklemeToolStripMenuItem1.Name = "eklemeToolStripMenuItem1";
            this.eklemeToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.eklemeToolStripMenuItem1.Text = "Ekleme";
            this.eklemeToolStripMenuItem1.Click += new System.EventHandler(this.eklemeToolStripMenuItem1_Click);
            // 
            // kategoriEkleToolStripMenuItem
            // 
            this.kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            this.kategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.kategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            this.kategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.kategoriEkleToolStripMenuItem_Click);
            // 
            // markaEkleToolStripMenuItem
            // 
            this.markaEkleToolStripMenuItem.Name = "markaEkleToolStripMenuItem";
            this.markaEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.markaEkleToolStripMenuItem.Text = "Marka Ekle";
            this.markaEkleToolStripMenuItem.Click += new System.EventHandler(this.markaEkleToolStripMenuItem_Click);
            // 
            // yazarEkleToolStripMenuItem
            // 
            this.yazarEkleToolStripMenuItem.Name = "yazarEkleToolStripMenuItem";
            this.yazarEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.yazarEkleToolStripMenuItem.Text = "Yazar Ekle";
            this.yazarEkleToolStripMenuItem.Click += new System.EventHandler(this.yazarEkleToolStripMenuItem_Click);
            // 
            // listelemeToolStripMenuItem1
            // 
            this.listelemeToolStripMenuItem1.Name = "listelemeToolStripMenuItem1";
            this.listelemeToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.listelemeToolStripMenuItem1.Text = "Listeleme";
            this.listelemeToolStripMenuItem1.Click += new System.EventHandler(this.listelemeToolStripMenuItem1_Click);
            // 
            // satışListeleToolStripMenuItem
            // 
            this.satışListeleToolStripMenuItem.Name = "satışListeleToolStripMenuItem";
            this.satışListeleToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.satışListeleToolStripMenuItem.Text = "Satış Listele";
            this.satışListeleToolStripMenuItem.Click += new System.EventHandler(this.satışListeleToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // stok_takibiDataSet
            // 
            this.stok_takibiDataSet.DataSetName = "Stok_takibiDataSet";
            this.stok_takibiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stoktakibiDataSetBindingSource
            // 
            this.stoktakibiDataSetBindingSource.DataSource = this.stok_takibiDataSet;
            this.stoktakibiDataSetBindingSource.Position = 0;
            // 
            // sepetBindingSource
            // 
            this.sepetBindingSource.DataMember = "sepet";
            this.sepetBindingSource.DataSource = this.stoktakibiDataSetBindingSource;
            // 
            // sepetTableAdapter
            // 
            this.sepetTableAdapter.ClearBeforeFill = true;
            // 
            // sepetBindingSource1
            // 
            this.sepetBindingSource1.DataMember = "sepet";
            this.sepetBindingSource1.DataSource = this.stoktakibiDataSetBindingSource;
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutbutton.BackgroundImage")));
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutbutton.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(1212, 0);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(32, 33);
            this.logoutbutton.TabIndex = 20;
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1244, 657);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.satisButton);
            this.Controls.Add(this.finallbl);
            this.Controls.Add(this.satisiptalbutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.product);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Stok Takibi ve Satış";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customer.ResumeLayout(false);
            this.customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.product.ResumeLayout(false);
            this.product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_takibiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakibiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox product;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox satistxt;
        private System.Windows.Forms.TextBox miktartxt;
        private System.Windows.Forms.TextBox uruntxt;
        private System.Windows.Forms.TextBox barkodtxt;
        private System.Windows.Forms.TextBox toplamtxt;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button satisiptalbutton;
        private System.Windows.Forms.Label finallbl;
        private System.Windows.Forms.Button satisButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eklemeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışListeleToolStripMenuItem;
        private System.Windows.Forms.BindingSource stoktakibiDataSetBindingSource;
        private Stok_takibiDataSet stok_takibiDataSet;
        private System.Windows.Forms.BindingSource sepetBindingSource;
        private Stok_takibiDataSetTableAdapters.sepetTableAdapter sepetTableAdapter;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.BindingSource sepetBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem yazarEkleToolStripMenuItem;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yazartxt;
    }
}

