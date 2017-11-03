namespace xeberlers
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
            this.dgvnews = new System.Windows.Forms.DataGridView();
            this.rtbcontent = new System.Windows.Forms.RichTextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbcategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnews)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnews
            // 
            this.dgvnews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnews.Location = new System.Drawing.Point(350, 12);
            this.dgvnews.Name = "dgvnews";
            this.dgvnews.Size = new System.Drawing.Size(604, 428);
            this.dgvnews.TabIndex = 0;
            this.dgvnews.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvnews_RowHeaderMouseClick);
            // 
            // rtbcontent
            // 
            this.rtbcontent.Location = new System.Drawing.Point(12, 137);
            this.rtbcontent.Name = "rtbcontent";
            this.rtbcontent.Size = new System.Drawing.Size(317, 137);
            this.rtbcontent.TabIndex = 1;
            this.rtbcontent.Text = "";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(12, 28);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(226, 20);
            this.txttitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time";
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(12, 89);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(226, 20);
            this.dtpdate.TabIndex = 5;
            // 
            // cmbcategories
            // 
            this.cmbcategories.FormattingEnabled = true;
            this.cmbcategories.Location = new System.Drawing.Point(12, 302);
            this.cmbcategories.Name = "cmbcategories";
            this.cmbcategories.Size = new System.Drawing.Size(226, 21);
            this.cmbcategories.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categories";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 338);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(317, 32);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add News";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(12, 388);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(317, 32);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 338);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(317, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 452);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbcategories);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.rtbcontent);
            this.Controls.Add(this.dgvnews);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnews;
        private System.Windows.Forms.RichTextBox rtbcontent;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbcategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

