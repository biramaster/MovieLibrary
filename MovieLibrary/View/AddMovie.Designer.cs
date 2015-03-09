namespace MovieLibrary.View
{
    partial class AddMovie
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
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxRuntime = new System.Windows.Forms.TextBox();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvwMovie = new System.Windows.Forms.ListView();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDirector = new System.Windows.Forms.TextBox();
            this.btnAddDirector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.lvwDirector = new System.Windows.Forms.ListView();
            this.lvwMovieCopy = new System.Windows.Forms.ListView();
            this.lblMovieCopy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(194, 366);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(214, 23);
            this.btnAddImage.TabIndex = 32;
            this.btnAddImage.Text = "Add Image From File";
            this.btnAddImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 317);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Path";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 335);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 29;
            this.lblAge.Text = "Age";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(19, 291);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(46, 13);
            this.lblRuntime.TabIndex = 28;
            this.lblRuntime.Text = "Runtime";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(19, 118);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 27;
            this.lblDirector.Text = "Director";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(19, 75);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 26;
            this.lblGenre.Text = "Genre";
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(20, 396);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(133, 20);
            this.tbxPath.TabIndex = 25;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(20, 351);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(133, 20);
            this.tbxAge.TabIndex = 24;
            // 
            // tbxRuntime
            // 
            this.tbxRuntime.Location = new System.Drawing.Point(20, 310);
            this.tbxRuntime.Name = "tbxRuntime";
            this.tbxRuntime.Size = new System.Drawing.Size(133, 20);
            this.tbxRuntime.TabIndex = 23;
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(20, 91);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(133, 20);
            this.tbxGenre.TabIndex = 21;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(20, 464);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(130, 23);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "Change Movie";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Show All";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lvwMovie
            // 
            this.lvwMovie.Location = new System.Drawing.Point(435, 33);
            this.lvwMovie.Name = "lvwMovie";
            this.lvwMovie.Size = new System.Drawing.Size(353, 317);
            this.lvwMovie.TabIndex = 17;
            this.lvwMovie.UseCompatibleStateImageBehavior = false;
            this.lvwMovie.View = System.Windows.Forms.View.Details;
            this.lvwMovie.SelectedIndexChanged += new System.EventHandler(this.lvwMovie_SelectedIndexChanged);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(20, 50);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(133, 20);
            this.tbxTitle.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(19, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Director";
            // 
            // tbxDirector
            // 
            this.tbxDirector.Location = new System.Drawing.Point(19, 519);
            this.tbxDirector.Name = "tbxDirector";
            this.tbxDirector.Size = new System.Drawing.Size(133, 20);
            this.tbxDirector.TabIndex = 34;
            // 
            // btnAddDirector
            // 
            this.btnAddDirector.Location = new System.Drawing.Point(19, 559);
            this.btnAddDirector.Name = "btnAddDirector";
            this.btnAddDirector.Size = new System.Drawing.Size(130, 23);
            this.btnAddDirector.TabIndex = 33;
            this.btnAddDirector.Text = "Add Director";
            this.btnAddDirector.UseVisualStyleBackColor = true;
            this.btnAddDirector.Click += new System.EventHandler(this.btnAddDirector_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Movies";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Avalaible";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Filter Movie";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(713, 366);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(75, 23);
            this.btnAddCopy.TabIndex = 40;
            this.btnAddCopy.Text = "Add a Copy";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // lvwDirector
            // 
            this.lvwDirector.Location = new System.Drawing.Point(20, 135);
            this.lvwDirector.Name = "lvwDirector";
            this.lvwDirector.Size = new System.Drawing.Size(156, 139);
            this.lvwDirector.TabIndex = 41;
            this.lvwDirector.UseCompatibleStateImageBehavior = false;
            this.lvwDirector.View = System.Windows.Forms.View.Details;
            this.lvwDirector.SelectedIndexChanged += new System.EventHandler(this.lvwDirector_SelectedIndexChanged);
            // 
            // lvwMovieCopy
            // 
            this.lvwMovieCopy.Location = new System.Drawing.Point(435, 426);
            this.lvwMovieCopy.Name = "lvwMovieCopy";
            this.lvwMovieCopy.Size = new System.Drawing.Size(353, 156);
            this.lvwMovieCopy.TabIndex = 42;
            this.lvwMovieCopy.UseCompatibleStateImageBehavior = false;
            this.lvwMovieCopy.View = System.Windows.Forms.View.Details;
            // 
            // lblMovieCopy
            // 
            this.lblMovieCopy.AutoSize = true;
            this.lblMovieCopy.Location = new System.Drawing.Point(432, 403);
            this.lblMovieCopy.Name = "lblMovieCopy";
            this.lblMovieCopy.Size = new System.Drawing.Size(71, 13);
            this.lblMovieCopy.TabIndex = 43;
            this.lblMovieCopy.Text = "Movie Copies";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 608);
            this.Controls.Add(this.lblMovieCopy);
            this.Controls.Add(this.lvwMovieCopy);
            this.Controls.Add(this.lvwDirector);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDirector);
            this.Controls.Add(this.btnAddDirector);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxRuntime);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvwMovie);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button btnAddImage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblRuntime;
		private System.Windows.Forms.Label lblDirector;
		private System.Windows.Forms.Label lblGenre;
		private System.Windows.Forms.TextBox tbxPath;
		private System.Windows.Forms.TextBox tbxAge;
		private System.Windows.Forms.TextBox tbxRuntime;
		private System.Windows.Forms.TextBox tbxGenre;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ListView lvwMovie;
		private System.Windows.Forms.TextBox tbxTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxDirector;
        private System.Windows.Forms.Button btnAddDirector;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.ListView lvwDirector;
        private System.Windows.Forms.ListView lvwMovieCopy;
        private System.Windows.Forms.Label lblMovieCopy;
    }
}