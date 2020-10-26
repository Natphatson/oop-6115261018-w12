namespace oop_6115261018_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.PF_ID = new System.Windows.Forms.Label();
            this.PF_brandName = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPF_ID = new System.Windows.Forms.TextBox();
            this.txtPF_brandName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "แป้งรองพื้น";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PF_ID
            // 
            this.PF_ID.AutoSize = true;
            this.PF_ID.Location = new System.Drawing.Point(55, 118);
            this.PF_ID.Name = "PF_ID";
            this.PF_ID.Size = new System.Drawing.Size(91, 17);
            this.PF_ID.TabIndex = 1;
            this.PF_ID.Text = "รหัสแป้งรองพื้น";
            // 
            // PF_brandName
            // 
            this.PF_brandName.AutoSize = true;
            this.PF_brandName.Location = new System.Drawing.Point(55, 179);
            this.PF_brandName.Name = "PF_brandName";
            this.PF_brandName.Size = new System.Drawing.Size(63, 17);
            this.PF_brandName.TabIndex = 2;
            this.PF_brandName.Text = "ชื่อแบรนด์";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(71, 281);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "เพิ่ม";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(190, 281);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 23);
            this.btndisplay.TabIndex = 4;
            this.btndisplay.Text = "แสดงผล";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(424, 281);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = "ถัดไป";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(305, 281);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "ลบ";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 206);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtPF_ID
            // 
            this.txtPF_ID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPF_ID.Location = new System.Drawing.Point(177, 113);
            this.txtPF_ID.Name = "txtPF_ID";
            this.txtPF_ID.Size = new System.Drawing.Size(100, 22);
            this.txtPF_ID.TabIndex = 10;
            this.txtPF_ID.TextChanged += new System.EventHandler(this.txtPF_ID_TextChanged);
            // 
            // txtPF_brandName
            // 
            this.txtPF_brandName.Location = new System.Drawing.Point(177, 179);
            this.txtPF_brandName.Name = "txtPF_brandName";
            this.txtPF_brandName.Size = new System.Drawing.Size(100, 22);
            this.txtPF_brandName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPF_brandName);
            this.Controls.Add(this.txtPF_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.add);
            this.Controls.Add(this.PF_brandName);
            this.Controls.Add(this.PF_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PF_ID;
        private System.Windows.Forms.Label PF_brandName;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPF_ID;
        private System.Windows.Forms.TextBox txtPF_brandName;
    }
}