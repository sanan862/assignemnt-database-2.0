namespace assignemnt_database_2._0
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
            this.memberslbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Firstnamelbl = new System.Windows.Forms.Label();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.Genderlbl = new System.Windows.Forms.Label();
            this.membersDGV1 = new System.Windows.Forms.DataGridView();
            this.IDtxtbox = new System.Windows.Forms.TextBox();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.txtboxdob = new System.Windows.Forms.TextBox();
            this.txtboxgenderid = new System.Windows.Forms.TextBox();
            this.txtboxfirstname = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membersDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // memberslbl
            // 
            this.memberslbl.AutoSize = true;
            this.memberslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberslbl.Location = new System.Drawing.Point(257, 9);
            this.memberslbl.Name = "memberslbl";
            this.memberslbl.Size = new System.Drawing.Size(173, 42);
            this.memberslbl.TabIndex = 0;
            this.memberslbl.Text = "Members";
            this.memberslbl.Click += new System.EventHandler(this.memberslbl_Click);
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(87, 228);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(62, 13);
            this.IDlbl.TabIndex = 1;
            this.IDlbl.Text = "Member_ID";
            // 
            // Firstnamelbl
            // 
            this.Firstnamelbl.AutoSize = true;
            this.Firstnamelbl.Location = new System.Drawing.Point(89, 258);
            this.Firstnamelbl.Name = "Firstnamelbl";
            this.Firstnamelbl.Size = new System.Drawing.Size(60, 13);
            this.Firstnamelbl.TabIndex = 2;
            this.Firstnamelbl.Text = "First_Name";
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.Location = new System.Drawing.Point(87, 289);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(61, 13);
            this.lastnamelbl.TabIndex = 3;
            this.lastnamelbl.Text = "Last_Name";
            // 
            // DOBlbl
            // 
            this.DOBlbl.AutoSize = true;
            this.DOBlbl.Location = new System.Drawing.Point(74, 323);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(74, 13);
            this.DOBlbl.TabIndex = 4;
            this.DOBlbl.Text = "Date_Of_Birth";
            // 
            // Genderlbl
            // 
            this.Genderlbl.AutoSize = true;
            this.Genderlbl.Location = new System.Drawing.Point(75, 354);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(59, 13);
            this.Genderlbl.TabIndex = 5;
            this.Genderlbl.Text = "Gender_ID";
            // 
            // membersDGV1
            // 
            this.membersDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDGV1.Location = new System.Drawing.Point(116, 54);
            this.membersDGV1.Name = "membersDGV1";
            this.membersDGV1.Size = new System.Drawing.Size(425, 150);
            this.membersDGV1.TabIndex = 6;
            this.membersDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memebersDGV1_CellContentClick);
            // 
            // IDtxtbox
            // 
            this.IDtxtbox.Location = new System.Drawing.Point(154, 225);
            this.IDtxtbox.Name = "IDtxtbox";
            this.IDtxtbox.Size = new System.Drawing.Size(163, 20);
            this.IDtxtbox.TabIndex = 7;
            // 
            // txtboxlastname
            // 
            this.txtboxlastname.Location = new System.Drawing.Point(154, 286);
            this.txtboxlastname.Name = "txtboxlastname";
            this.txtboxlastname.Size = new System.Drawing.Size(163, 20);
            this.txtboxlastname.TabIndex = 8;
            // 
            // txtboxdob
            // 
            this.txtboxdob.Location = new System.Drawing.Point(154, 316);
            this.txtboxdob.Name = "txtboxdob";
            this.txtboxdob.Size = new System.Drawing.Size(163, 20);
            this.txtboxdob.TabIndex = 9;
            // 
            // txtboxgenderid
            // 
            this.txtboxgenderid.Location = new System.Drawing.Point(154, 347);
            this.txtboxgenderid.Name = "txtboxgenderid";
            this.txtboxgenderid.Size = new System.Drawing.Size(163, 20);
            this.txtboxgenderid.TabIndex = 10;
            // 
            // txtboxfirstname
            // 
            this.txtboxfirstname.Location = new System.Drawing.Point(154, 255);
            this.txtboxfirstname.Name = "txtboxfirstname";
            this.txtboxfirstname.Size = new System.Drawing.Size(163, 20);
            this.txtboxfirstname.TabIndex = 11;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(670, 109);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 12;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(670, 155);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 13;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(670, 198);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 14;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.txtboxfirstname);
            this.Controls.Add(this.txtboxgenderid);
            this.Controls.Add(this.txtboxdob);
            this.Controls.Add(this.txtboxlastname);
            this.Controls.Add(this.IDtxtbox);
            this.Controls.Add(this.membersDGV1);
            this.Controls.Add(this.Genderlbl);
            this.Controls.Add(this.DOBlbl);
            this.Controls.Add(this.lastnamelbl);
            this.Controls.Add(this.Firstnamelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.memberslbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.membersDGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberslbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Firstnamelbl;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.Label Genderlbl;
        private System.Windows.Forms.DataGridView membersDGV1;
        private System.Windows.Forms.TextBox IDtxtbox;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.TextBox txtboxdob;
        private System.Windows.Forms.TextBox txtboxgenderid;
        private System.Windows.Forms.TextBox txtboxfirstname;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
    }
}

