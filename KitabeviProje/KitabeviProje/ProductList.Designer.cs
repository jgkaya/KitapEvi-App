namespace KitabeviProje
{
    partial class ProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.barkodtxt = new System.Windows.Forms.TextBox();
            this.kategoritxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.uruntxt = new System.Windows.Forms.TextBox();
            this.miktartxt = new System.Windows.Forms.TextBox();
            this.alistxt = new System.Windows.Forms.TextBox();
            this.satistxt = new System.Windows.Forms.TextBox();
            this.updateproductbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barkodnoquerytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yazartxt = new System.Windows.Forms.TextBox();
            this.yazarcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yazarquerytxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Satış Fiyatı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Alış Fiyatı";
            // 
            // lblmiktar
            // 
            this.lblmiktar.AutoSize = true;
            this.lblmiktar.Location = new System.Drawing.Point(121, 302);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(56, 20);
            this.lblmiktar.TabIndex = 39;
            this.lblmiktar.Text = "Miktarı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(106, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "Ürün Adı";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(121, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Marka";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(106, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "Kategori";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(90, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 20);
            this.label21.TabIndex = 35;
            this.label21.Text = "Barkod No";
            // 
            // barkodtxt
            // 
            this.barkodtxt.Location = new System.Drawing.Point(181, 117);
            this.barkodtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barkodtxt.Name = "barkodtxt";
            this.barkodtxt.Size = new System.Drawing.Size(159, 27);
            this.barkodtxt.TabIndex = 28;
            // 
            // kategoritxt
            // 
            this.kategoritxt.Location = new System.Drawing.Point(181, 152);
            this.kategoritxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.Size = new System.Drawing.Size(159, 27);
            this.kategoritxt.TabIndex = 29;
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(181, 187);
            this.markatxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(159, 27);
            this.markatxt.TabIndex = 30;
            // 
            // uruntxt
            // 
            this.uruntxt.Location = new System.Drawing.Point(181, 259);
            this.uruntxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uruntxt.Name = "uruntxt";
            this.uruntxt.Size = new System.Drawing.Size(159, 27);
            this.uruntxt.TabIndex = 31;
            // 
            // miktartxt
            // 
            this.miktartxt.Location = new System.Drawing.Point(181, 296);
            this.miktartxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.miktartxt.Name = "miktartxt";
            this.miktartxt.Size = new System.Drawing.Size(159, 27);
            this.miktartxt.TabIndex = 32;
            // 
            // alistxt
            // 
            this.alistxt.Location = new System.Drawing.Point(181, 334);
            this.alistxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alistxt.Name = "alistxt";
            this.alistxt.Size = new System.Drawing.Size(159, 27);
            this.alistxt.TabIndex = 33;
            // 
            // satistxt
            // 
            this.satistxt.Location = new System.Drawing.Point(181, 374);
            this.satistxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satistxt.Name = "satistxt";
            this.satistxt.Size = new System.Drawing.Size(159, 27);
            this.satistxt.TabIndex = 34;
            // 
            // updateproductbutton
            // 
            this.updateproductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateproductbutton.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateproductbutton.Location = new System.Drawing.Point(257, 416);
            this.updateproductbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateproductbutton.Name = "updateproductbutton";
            this.updateproductbutton.Size = new System.Drawing.Size(84, 29);
            this.updateproductbutton.TabIndex = 42;
            this.updateproductbutton.Text = "Güncelle";
            this.updateproductbutton.UseVisualStyleBackColor = true;
            this.updateproductbutton.Click += new System.EventHandler(this.updateproductbutton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1281, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(845, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Barkod No ya göre sorgula";
            // 
            // barkodnoquerytxt
            // 
            this.barkodnoquerytxt.Location = new System.Drawing.Point(1052, 95);
            this.barkodnoquerytxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barkodnoquerytxt.Name = "barkodnoquerytxt";
            this.barkodnoquerytxt.Size = new System.Drawing.Size(193, 27);
            this.barkodnoquerytxt.TabIndex = 44;
            this.barkodnoquerytxt.TextChanged += new System.EventHandler(this.barkodnoquerytxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Kategori";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(323, 530);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 82);
            this.button2.TabIndex = 48;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 504);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 558);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 28);
            this.comboBox2.TabIndex = 50;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Yazar Adı";
            // 
            // yazartxt
            // 
            this.yazartxt.Location = new System.Drawing.Point(180, 222);
            this.yazartxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yazartxt.Name = "yazartxt";
            this.yazartxt.Size = new System.Drawing.Size(159, 27);
            this.yazartxt.TabIndex = 51;
            // 
            // yazarcomboBox
            // 
            this.yazarcomboBox.FormattingEnabled = true;
            this.yazarcomboBox.Location = new System.Drawing.Point(151, 608);
            this.yazarcomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yazarcomboBox.Name = "yazarcomboBox";
            this.yazarcomboBox.Size = new System.Drawing.Size(136, 28);
            this.yazarcomboBox.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Yazar Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Yazar Adına göre sırala";
            // 
            // yazarquerytxt
            // 
            this.yazarquerytxt.Location = new System.Drawing.Point(1052, 48);
            this.yazarquerytxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yazarquerytxt.Name = "yazarquerytxt";
            this.yazarquerytxt.Size = new System.Drawing.Size(193, 27);
            this.yazarquerytxt.TabIndex = 56;
            this.yazarquerytxt.TextChanged += new System.EventHandler(this.yazarquerytxt_TextChanged);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1425, 720);
            this.Controls.Add(this.yazarquerytxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yazarcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yazartxt);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barkodnoquerytxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateproductbutton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.barkodtxt);
            this.Controls.Add(this.kategoritxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.uruntxt);
            this.Controls.Add(this.miktartxt);
            this.Controls.Add(this.alistxt);
            this.Controls.Add(this.satistxt);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductList";
            this.Text = "Ürün Listeleme";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox barkodtxt;
        private System.Windows.Forms.TextBox kategoritxt;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox uruntxt;
        private System.Windows.Forms.TextBox miktartxt;
        private System.Windows.Forms.TextBox alistxt;
        private System.Windows.Forms.TextBox satistxt;
        private System.Windows.Forms.Button updateproductbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barkodnoquerytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yazartxt;
        private System.Windows.Forms.ComboBox yazarcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yazarquerytxt;
    }
}