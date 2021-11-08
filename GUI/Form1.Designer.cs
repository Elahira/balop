
namespace GUI
{
    partial class Form1
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
            this.formload = new System.Windows.Forms.GroupBox();
            this.butthoat = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txthoten2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridthanhvien = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formload.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridthanhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // formload
            // 
            this.formload.Controls.Add(this.butthoat);
            this.formload.Controls.Add(this.butxoa);
            this.formload.Controls.Add(this.butsua);
            this.formload.Controls.Add(this.butthem);
            this.formload.Controls.Add(this.txtemail);
            this.formload.Controls.Add(this.txtPhone2);
            this.formload.Controls.Add(this.txthoten2);
            this.formload.Controls.Add(this.label9);
            this.formload.Controls.Add(this.label8);
            this.formload.Controls.Add(this.label7);
            this.formload.Controls.Add(this.label6);
            this.formload.Location = new System.Drawing.Point(12, 12);
            this.formload.Name = "formload";
            this.formload.Size = new System.Drawing.Size(1234, 262);
            this.formload.TabIndex = 0;
            this.formload.TabStop = false;
            this.formload.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(390, 204);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 37);
            this.butthoat.TabIndex = 10;
            this.butthoat.Text = "thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(262, 204);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 37);
            this.butxoa.TabIndex = 9;
            this.butxoa.Text = "xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(131, 204);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 37);
            this.butsua.TabIndex = 8;
            this.butsua.Text = "sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(11, 204);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 37);
            this.butthem.TabIndex = 7;
            this.butthem.Text = "thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(131, 150);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(280, 26);
            this.txtemail.TabIndex = 6;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(131, 104);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(280, 26);
            this.txtPhone2.TabIndex = 5;
            // 
            // txthoten2
            // 
            this.txthoten2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten2.Location = new System.Drawing.Point(131, 66);
            this.txthoten2.Name = "txthoten2";
            this.txthoten2.Size = new System.Drawing.Size(280, 26);
            this.txthoten2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "thông tin thành viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridthanhvien);
            this.groupBox4.Location = new System.Drawing.Point(12, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1234, 245);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // dataGridthanhvien
            // 
            this.dataGridthanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridthanhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Hoten,
            this.Phone,
            this.Email});
            this.dataGridthanhvien.Location = new System.Drawing.Point(7, 10);
            this.dataGridthanhvien.Name = "dataGridthanhvien";
            this.dataGridthanhvien.Size = new System.Drawing.Size(1221, 229);
            this.dataGridthanhvien.TabIndex = 0;
            this.dataGridthanhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridthanhvien_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 300;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "phone";
            this.Phone.HeaderText = "số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "email";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1258, 537);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.formload);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formload.ResumeLayout(false);
            this.formload.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridthanhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txthoten2;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        public System.Windows.Forms.DataGridView dataGridthanhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

