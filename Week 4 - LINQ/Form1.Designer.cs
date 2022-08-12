namespace Week_4___LINQ
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
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(32, 379);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(162, 24);
            this.cbRole.TabIndex = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(393, 440);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 22);
            this.txtPhoneNumber.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Phone Number";
            // 
            // txtEmal
            // 
            this.txtEmal.Location = new System.Drawing.Point(393, 412);
            this.txtEmal.Name = "txtEmal";
            this.txtEmal.Size = new System.Drawing.Size(182, 22);
            this.txtEmal.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(393, 384);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 22);
            this.txtName.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(393, 356);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 22);
            this.txtID.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "ID";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 80);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(776, 243);
            this.dgv.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Manage Customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 540);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

