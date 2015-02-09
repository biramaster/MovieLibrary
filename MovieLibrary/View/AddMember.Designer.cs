namespace MovieLibrary.View
{
    partial class AddMember
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
            this.lblPersonal = new System.Windows.Forms.Label();
            this.tbxPersonal = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.addMemberbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwMember = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(35, 29);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(65, 13);
            this.lblPersonal.TabIndex = 0;
            this.lblPersonal.Text = "Personal ID:";
            // 
            // tbxPersonal
            // 
            this.tbxPersonal.Location = new System.Drawing.Point(38, 45);
            this.tbxPersonal.Name = "tbxPersonal";
            this.tbxPersonal.Size = new System.Drawing.Size(162, 20);
            this.tbxPersonal.TabIndex = 1;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(38, 101);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(162, 20);
            this.tbxname.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(38, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loan Movies";
            // 
            // addMemberbtn
            // 
            this.addMemberbtn.Location = new System.Drawing.Point(256, 97);
            this.addMemberbtn.Name = "addMemberbtn";
            this.addMemberbtn.Size = new System.Drawing.Size(75, 23);
            this.addMemberbtn.TabIndex = 6;
            this.addMemberbtn.Text = "Add Member";
            this.addMemberbtn.UseVisualStyleBackColor = true;
            this.addMemberbtn.Click += new System.EventHandler(this.addMemberbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Return Movie";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Members";
            // 
            // lvwMember
            // 
            this.lvwMember.Location = new System.Drawing.Point(420, 45);
            this.lvwMember.Name = "lvwMember";
            this.lvwMember.Size = new System.Drawing.Size(293, 214);
            this.lvwMember.TabIndex = 8;
            this.lvwMember.UseCompatibleStateImageBehavior = false;
            this.lvwMember.View = System.Windows.Forms.View.Details;
            this.lvwMember.SelectedIndexChanged += new System.EventHandler(this.lvwMember_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Movies";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(38, 333);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(293, 214);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Book copies available";
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(420, 333);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(293, 214);
            this.listView4.TabIndex = 12;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add Movie Copy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Loan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwMember);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addMemberbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxPersonal);
            this.Controls.Add(this.lblPersonal);
            this.Name = "AddMember";
            this.Text = "AddMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label lblPersonal;
		private System.Windows.Forms.TextBox tbxPersonal;
		private System.Windows.Forms.TextBox tbxname;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button addMemberbtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lvwMember;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}