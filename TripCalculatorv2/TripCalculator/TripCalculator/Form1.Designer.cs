namespace TripCalculator
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
            this.txtLouis = new System.Windows.Forms.TextBox();
            this.txtCarter = new System.Windows.Forms.TextBox();
            this.txtDavid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddLouis = new System.Windows.Forms.Button();
            this.btnAddCarter = new System.Windows.Forms.Button();
            this.btnAddDavid = new System.Windows.Forms.Button();
            this.lstLouis = new System.Windows.Forms.ListBox();
            this.lstCarter = new System.Windows.Forms.ListBox();
            this.lstDavid = new System.Windows.Forms.ListBox();
            this.btnRemoveLouis = new System.Windows.Forms.Button();
            this.btnRemoveCarter = new System.Windows.Forms.Button();
            this.btnRemoveDavid = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblLouisTotal = new System.Windows.Forms.Label();
            this.lblLouisOwe = new System.Windows.Forms.Label();
            this.lblCarterTotal = new System.Windows.Forms.Label();
            this.lblCarterOwe = new System.Windows.Forms.Label();
            this.lblDavidTotal = new System.Windows.Forms.Label();
            this.lblDavidOwe = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLouis
            // 
            this.txtLouis.Location = new System.Drawing.Point(19, 29);
            this.txtLouis.Name = "txtLouis";
            this.txtLouis.Size = new System.Drawing.Size(175, 22);
            this.txtLouis.TabIndex = 0;
            this.txtLouis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLouis_KeyPress);
            // 
            // txtCarter
            // 
            this.txtCarter.Location = new System.Drawing.Point(23, 22);
            this.txtCarter.Name = "txtCarter";
            this.txtCarter.Size = new System.Drawing.Size(171, 22);
            this.txtCarter.TabIndex = 4;
            this.txtCarter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarter_KeyPress);
            // 
            // txtDavid
            // 
            this.txtDavid.Location = new System.Drawing.Point(20, 20);
            this.txtDavid.Name = "txtDavid";
            this.txtDavid.Size = new System.Drawing.Size(174, 22);
            this.txtDavid.TabIndex = 5;
            this.txtDavid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDavid_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "$";
            // 
            // btnAddLouis
            // 
            this.btnAddLouis.Location = new System.Drawing.Point(6, 179);
            this.btnAddLouis.Name = "btnAddLouis";
            this.btnAddLouis.Size = new System.Drawing.Size(91, 34);
            this.btnAddLouis.TabIndex = 9;
            this.btnAddLouis.Text = "Add";
            this.btnAddLouis.UseVisualStyleBackColor = true;
            this.btnAddLouis.Click += new System.EventHandler(this.btnAddLouis_Click);
            // 
            // btnAddCarter
            // 
            this.btnAddCarter.Location = new System.Drawing.Point(6, 174);
            this.btnAddCarter.Name = "btnAddCarter";
            this.btnAddCarter.Size = new System.Drawing.Size(91, 34);
            this.btnAddCarter.TabIndex = 10;
            this.btnAddCarter.Text = "Add";
            this.btnAddCarter.UseVisualStyleBackColor = true;
            this.btnAddCarter.Click += new System.EventHandler(this.btnAddCarter_Click);
            // 
            // btnAddDavid
            // 
            this.btnAddDavid.Location = new System.Drawing.Point(6, 168);
            this.btnAddDavid.Name = "btnAddDavid";
            this.btnAddDavid.Size = new System.Drawing.Size(91, 34);
            this.btnAddDavid.TabIndex = 11;
            this.btnAddDavid.Text = "Add";
            this.btnAddDavid.UseVisualStyleBackColor = true;
            this.btnAddDavid.Click += new System.EventHandler(this.btnAddDavid_Click);
            // 
            // lstLouis
            // 
            this.lstLouis.FormattingEnabled = true;
            this.lstLouis.ItemHeight = 16;
            this.lstLouis.Location = new System.Drawing.Point(6, 57);
            this.lstLouis.Name = "lstLouis";
            this.lstLouis.Size = new System.Drawing.Size(188, 116);
            this.lstLouis.TabIndex = 12;
            // 
            // lstCarter
            // 
            this.lstCarter.FormattingEnabled = true;
            this.lstCarter.ItemHeight = 16;
            this.lstCarter.Location = new System.Drawing.Point(6, 54);
            this.lstCarter.Name = "lstCarter";
            this.lstCarter.Size = new System.Drawing.Size(188, 116);
            this.lstCarter.TabIndex = 13;
            // 
            // lstDavid
            // 
            this.lstDavid.FormattingEnabled = true;
            this.lstDavid.ItemHeight = 16;
            this.lstDavid.Location = new System.Drawing.Point(6, 48);
            this.lstDavid.Name = "lstDavid";
            this.lstDavid.Size = new System.Drawing.Size(188, 116);
            this.lstDavid.TabIndex = 14;
            // 
            // btnRemoveLouis
            // 
            this.btnRemoveLouis.Location = new System.Drawing.Point(103, 179);
            this.btnRemoveLouis.Name = "btnRemoveLouis";
            this.btnRemoveLouis.Size = new System.Drawing.Size(91, 34);
            this.btnRemoveLouis.TabIndex = 15;
            this.btnRemoveLouis.Text = "Remove";
            this.btnRemoveLouis.UseVisualStyleBackColor = true;
            this.btnRemoveLouis.Click += new System.EventHandler(this.btnRemoveLouis_Click);
            // 
            // btnRemoveCarter
            // 
            this.btnRemoveCarter.Location = new System.Drawing.Point(103, 174);
            this.btnRemoveCarter.Name = "btnRemoveCarter";
            this.btnRemoveCarter.Size = new System.Drawing.Size(91, 34);
            this.btnRemoveCarter.TabIndex = 16;
            this.btnRemoveCarter.Text = "Remove";
            this.btnRemoveCarter.UseVisualStyleBackColor = true;
            this.btnRemoveCarter.Click += new System.EventHandler(this.btnRemoveCarter_Click);
            // 
            // btnRemoveDavid
            // 
            this.btnRemoveDavid.Location = new System.Drawing.Point(103, 168);
            this.btnRemoveDavid.Name = "btnRemoveDavid";
            this.btnRemoveDavid.Size = new System.Drawing.Size(91, 34);
            this.btnRemoveDavid.TabIndex = 17;
            this.btnRemoveDavid.Text = "Remove";
            this.btnRemoveDavid.UseVisualStyleBackColor = true;
            this.btnRemoveDavid.Click += new System.EventHandler(this.btnRemoveDavid_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(696, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLouis);
            this.groupBox1.Controls.Add(this.txtLouis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddLouis);
            this.groupBox1.Controls.Add(this.btnRemoveLouis);
            this.groupBox1.Location = new System.Drawing.Point(32, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 219);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Louis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCarter);
            this.groupBox2.Controls.Add(this.txtCarter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAddCarter);
            this.groupBox2.Controls.Add(this.btnRemoveCarter);
            this.groupBox2.Location = new System.Drawing.Point(279, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 216);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDavid);
            this.groupBox3.Controls.Add(this.txtDavid);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnAddDavid);
            this.groupBox3.Controls.Add(this.btnRemoveDavid);
            this.groupBox3.Location = new System.Drawing.Point(550, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 214);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "David";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(253, 454);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(263, 54);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblLouisTotal
            // 
            this.lblLouisTotal.AutoSize = true;
            this.lblLouisTotal.Location = new System.Drawing.Point(48, 352);
            this.lblLouisTotal.Name = "lblLouisTotal";
            this.lblLouisTotal.Size = new System.Drawing.Size(46, 17);
            this.lblLouisTotal.TabIndex = 23;
            this.lblLouisTotal.Text = "label1";
            this.lblLouisTotal.Visible = false;
            // 
            // lblLouisOwe
            // 
            this.lblLouisOwe.AutoSize = true;
            this.lblLouisOwe.Location = new System.Drawing.Point(48, 399);
            this.lblLouisOwe.Name = "lblLouisOwe";
            this.lblLouisOwe.Size = new System.Drawing.Size(46, 17);
            this.lblLouisOwe.TabIndex = 24;
            this.lblLouisOwe.Text = "label2";
            this.lblLouisOwe.Visible = false;
            // 
            // lblCarterTotal
            // 
            this.lblCarterTotal.AutoSize = true;
            this.lblCarterTotal.Location = new System.Drawing.Point(299, 351);
            this.lblCarterTotal.Name = "lblCarterTotal";
            this.lblCarterTotal.Size = new System.Drawing.Size(46, 17);
            this.lblCarterTotal.TabIndex = 25;
            this.lblCarterTotal.Text = "label3";
            this.lblCarterTotal.Visible = false;
            // 
            // lblCarterOwe
            // 
            this.lblCarterOwe.AutoSize = true;
            this.lblCarterOwe.Location = new System.Drawing.Point(299, 399);
            this.lblCarterOwe.Name = "lblCarterOwe";
            this.lblCarterOwe.Size = new System.Drawing.Size(46, 17);
            this.lblCarterOwe.TabIndex = 26;
            this.lblCarterOwe.Text = "label7";
            this.lblCarterOwe.Visible = false;
            // 
            // lblDavidTotal
            // 
            this.lblDavidTotal.AutoSize = true;
            this.lblDavidTotal.Location = new System.Drawing.Point(582, 351);
            this.lblDavidTotal.Name = "lblDavidTotal";
            this.lblDavidTotal.Size = new System.Drawing.Size(46, 17);
            this.lblDavidTotal.TabIndex = 27;
            this.lblDavidTotal.Text = "label8";
            this.lblDavidTotal.Visible = false;
            // 
            // lblDavidOwe
            // 
            this.lblDavidOwe.AutoSize = true;
            this.lblDavidOwe.Location = new System.Drawing.Point(582, 399);
            this.lblDavidOwe.Name = "lblDavidOwe";
            this.lblDavidOwe.Size = new System.Drawing.Size(46, 17);
            this.lblDavidOwe.TabIndex = 28;
            this.lblDavidOwe.Text = "label9";
            this.lblDavidOwe.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(19, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDavidOwe);
            this.Controls.Add(this.lblDavidTotal);
            this.Controls.Add(this.lblCarterOwe);
            this.Controls.Add(this.lblCarterTotal);
            this.Controls.Add(this.lblLouisOwe);
            this.Controls.Add(this.lblLouisTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLouis;
        private System.Windows.Forms.TextBox txtCarter;
        private System.Windows.Forms.TextBox txtDavid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddLouis;
        private System.Windows.Forms.Button btnAddCarter;
        private System.Windows.Forms.Button btnAddDavid;
        private System.Windows.Forms.ListBox lstLouis;
        private System.Windows.Forms.ListBox lstCarter;
        private System.Windows.Forms.ListBox lstDavid;
        private System.Windows.Forms.Button btnRemoveLouis;
        private System.Windows.Forms.Button btnRemoveCarter;
        private System.Windows.Forms.Button btnRemoveDavid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblLouisTotal;
        private System.Windows.Forms.Label lblLouisOwe;
        private System.Windows.Forms.Label lblCarterTotal;
        private System.Windows.Forms.Label lblCarterOwe;
        private System.Windows.Forms.Label lblDavidTotal;
        private System.Windows.Forms.Label lblDavidOwe;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}

