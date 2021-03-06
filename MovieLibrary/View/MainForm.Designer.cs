﻿namespace MovieLibrary.View
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllMoviesInTheLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllAvailableMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCopiesOfAMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllMoviesInTheLibraryToolStripMenuItem,
            this.listAllAvailableMoviesToolStripMenuItem,
            this.addNewMoviesToolStripMenuItem,
            this.addNewCopiesOfAMovieToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.movieToolStripMenuItem.Text = "Movie";
            // 
            // listAllMoviesInTheLibraryToolStripMenuItem
            // 
            this.listAllMoviesInTheLibraryToolStripMenuItem.Name = "listAllMoviesInTheLibraryToolStripMenuItem";
            this.listAllMoviesInTheLibraryToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listAllMoviesInTheLibraryToolStripMenuItem.Text = "List all movies in the library";
            // 
            // listAllAvailableMoviesToolStripMenuItem
            // 
            this.listAllAvailableMoviesToolStripMenuItem.Name = "listAllAvailableMoviesToolStripMenuItem";
            this.listAllAvailableMoviesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listAllAvailableMoviesToolStripMenuItem.Text = "List all available movies";
            // 
            // addNewMoviesToolStripMenuItem
            // 
            this.addNewMoviesToolStripMenuItem.Name = "addNewMoviesToolStripMenuItem";
            this.addNewMoviesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.addNewMoviesToolStripMenuItem.Text = "Add new movies";
            this.addNewMoviesToolStripMenuItem.Click += new System.EventHandler(this.addNewMoviesToolStripMenuItem_Click);
            // 
            // addNewCopiesOfAMovieToolStripMenuItem
            // 
            this.addNewCopiesOfAMovieToolStripMenuItem.Name = "addNewCopiesOfAMovieToolStripMenuItem";
            this.addNewCopiesOfAMovieToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.addNewCopiesOfAMovieToolStripMenuItem.Text = "Add new copies of a movie";
            this.addNewCopiesOfAMovieToolStripMenuItem.Click += new System.EventHandler(this.addNewCopiesOfAMovieToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewMemberToolStripMenuItem,
            this.addANewLoanToolStripMenuItem});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // addANewMemberToolStripMenuItem
            // 
            this.addANewMemberToolStripMenuItem.Name = "addANewMemberToolStripMenuItem";
            this.addANewMemberToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.addANewMemberToolStripMenuItem.Text = "Add a new member";
            this.addANewMemberToolStripMenuItem.Click += new System.EventHandler(this.addANewMemberToolStripMenuItem_Click);
            // 
            // addANewLoanToolStripMenuItem
            // 
            this.addANewLoanToolStripMenuItem.Name = "addANewLoanToolStripMenuItem";
            this.addANewLoanToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.addANewLoanToolStripMenuItem.Text = "Add a new loan";
            this.addANewLoanToolStripMenuItem.Click += new System.EventHandler(this.addANewLoanToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem1,
            this.readFromDatabaseToolStripMenuItem,
            this.saveToDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // memberToolStripMenuItem1
            // 
            this.memberToolStripMenuItem1.Name = "memberToolStripMenuItem1";
            this.memberToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.memberToolStripMenuItem1.Text = "Member";
            this.memberToolStripMenuItem1.Click += new System.EventHandler(this.memberToolStripMenuItem1_Click);
            // 
            // readFromDatabaseToolStripMenuItem
            // 
            this.readFromDatabaseToolStripMenuItem.Name = "readFromDatabaseToolStripMenuItem";
            this.readFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.readFromDatabaseToolStripMenuItem.Text = "Read From Database";
            this.readFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.readFromDatabaseToolStripMenuItem_Click);
            // 
            // saveToDatabaseToolStripMenuItem
            // 
            this.saveToDatabaseToolStripMenuItem.Name = "saveToDatabaseToolStripMenuItem";
            this.saveToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveToDatabaseToolStripMenuItem.Text = "Save to Database";
            this.saveToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.saveToDatabaseToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllMoviesInTheLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllAvailableMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCopiesOfAMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToDatabaseToolStripMenuItem;
    }
}