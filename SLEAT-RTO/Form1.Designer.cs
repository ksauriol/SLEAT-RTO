namespace SLEAT_RTO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ercotRadioBtn = new System.Windows.Forms.RadioButton();
            this.pjmRadioBtn = new System.Windows.Forms.RadioButton();
            this.sppRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.equipmentRadioBtn = new System.Windows.Forms.RadioButton();
            this.stationRadioBtn = new System.Windows.Forms.RadioButton();
            this.lineRadioBtn = new System.Windows.Forms.RadioButton();
            this.testLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.testLbl);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 140);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ercotRadioBtn);
            this.groupBox2.Controls.Add(this.pjmRadioBtn);
            this.groupBox2.Controls.Add(this.sppRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(182, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ercotRadioBtn
            // 
            this.ercotRadioBtn.AutoSize = true;
            this.ercotRadioBtn.Location = new System.Drawing.Point(6, 21);
            this.ercotRadioBtn.Name = "ercotRadioBtn";
            this.ercotRadioBtn.Size = new System.Drawing.Size(77, 21);
            this.ercotRadioBtn.TabIndex = 0;
            this.ercotRadioBtn.TabStop = true;
            this.ercotRadioBtn.Text = "ERCOT";
            this.ercotRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pjmRadioBtn
            // 
            this.pjmRadioBtn.AutoSize = true;
            this.pjmRadioBtn.Location = new System.Drawing.Point(6, 49);
            this.pjmRadioBtn.Name = "pjmRadioBtn";
            this.pjmRadioBtn.Size = new System.Drawing.Size(56, 21);
            this.pjmRadioBtn.TabIndex = 1;
            this.pjmRadioBtn.TabStop = true;
            this.pjmRadioBtn.Text = "PJM";
            this.pjmRadioBtn.UseVisualStyleBackColor = true;
            // 
            // sppRadioBtn
            // 
            this.sppRadioBtn.AutoSize = true;
            this.sppRadioBtn.Location = new System.Drawing.Point(6, 77);
            this.sppRadioBtn.Name = "sppRadioBtn";
            this.sppRadioBtn.Size = new System.Drawing.Size(56, 21);
            this.sppRadioBtn.TabIndex = 2;
            this.sppRadioBtn.TabStop = true;
            this.sppRadioBtn.Text = "SPP";
            this.sppRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equipmentRadioBtn);
            this.groupBox1.Controls.Add(this.stationRadioBtn);
            this.groupBox1.Controls.Add(this.lineRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // equipmentRadioBtn
            // 
            this.equipmentRadioBtn.AutoSize = true;
            this.equipmentRadioBtn.Location = new System.Drawing.Point(6, 17);
            this.equipmentRadioBtn.Name = "equipmentRadioBtn";
            this.equipmentRadioBtn.Size = new System.Drawing.Size(96, 21);
            this.equipmentRadioBtn.TabIndex = 0;
            this.equipmentRadioBtn.TabStop = true;
            this.equipmentRadioBtn.Text = "Equipment";
            this.equipmentRadioBtn.UseVisualStyleBackColor = true;
            // 
            // stationRadioBtn
            // 
            this.stationRadioBtn.AutoSize = true;
            this.stationRadioBtn.Location = new System.Drawing.Point(6, 73);
            this.stationRadioBtn.Name = "stationRadioBtn";
            this.stationRadioBtn.Size = new System.Drawing.Size(73, 21);
            this.stationRadioBtn.TabIndex = 2;
            this.stationRadioBtn.TabStop = true;
            this.stationRadioBtn.Text = "Station";
            this.stationRadioBtn.UseVisualStyleBackColor = true;
            // 
            // lineRadioBtn
            // 
            this.lineRadioBtn.AutoSize = true;
            this.lineRadioBtn.Location = new System.Drawing.Point(6, 45);
            this.lineRadioBtn.Name = "lineRadioBtn";
            this.lineRadioBtn.Size = new System.Drawing.Size(56, 21);
            this.lineRadioBtn.TabIndex = 1;
            this.lineRadioBtn.TabStop = true;
            this.lineRadioBtn.Text = "Line";
            this.lineRadioBtn.UseVisualStyleBackColor = true;
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Location = new System.Drawing.Point(402, 14);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(36, 17);
            this.testLbl.TabIndex = 1;
            this.testLbl.Text = "Test";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 383);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(635, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(601, 383);
            this.dataGridView2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(9, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 407);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton stationRadioBtn;
        private System.Windows.Forms.RadioButton lineRadioBtn;
        private System.Windows.Forms.RadioButton equipmentRadioBtn;
        private System.Windows.Forms.Label testLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ercotRadioBtn;
        private System.Windows.Forms.RadioButton pjmRadioBtn;
        private System.Windows.Forms.RadioButton sppRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
    }
}

