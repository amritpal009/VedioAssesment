
using System;

namespace VedioAssesment
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.PopMovBtn = new System.Windows.Forms.Button();
            this.PopCustBtn = new System.Windows.Forms.Button();
            this.LoadRentedMovies = new System.Windows.Forms.Button();
            this.IssueMovieBtn = new System.Windows.Forms.Button();
            this.ReturnMovieBtn = new System.Windows.Forms.Button();
            this.LoadMovies = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.MovieIDTBox = new System.Windows.Forms.TextBox();
            this.DltCustBtn = new System.Windows.Forms.Button();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.CustIDTBox = new System.Windows.Forms.TextBox();
            this.UpdCustBtn = new System.Windows.Forms.Button();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.PhLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.FNLabel = new System.Windows.Forms.Label();
            this.PhTBox = new System.Windows.Forms.TextBox();
            this.AdTBox = new System.Windows.Forms.TextBox();
            this.LNTBox = new System.Windows.Forms.TextBox();
            this.FNTBox = new System.Windows.Forms.TextBox();
            this.movie = new System.Windows.Forms.GroupBox();
            this.UpdateMovies = new System.Windows.Forms.Button();
            this.DeleteMovies = new System.Windows.Forms.Button();
            this.AddMovies = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Rental_Cost = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.textRental_Cost = new System.Windows.Forms.TextBox();
            this.textCopies = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.movie.SuspendLayout();
            this.customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.Color.Red;
            this.LoadBtn.Location = new System.Drawing.Point(28, 14);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(144, 102);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load Customers";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // PopMovBtn
            // 
            this.PopMovBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PopMovBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopMovBtn.ForeColor = System.Drawing.Color.Red;
            this.PopMovBtn.Location = new System.Drawing.Point(440, 12);
            this.PopMovBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PopMovBtn.Name = "PopMovBtn";
            this.PopMovBtn.Size = new System.Drawing.Size(128, 102);
            this.PopMovBtn.TabIndex = 30;
            this.PopMovBtn.Text = "Famous Movie";
            this.PopMovBtn.UseVisualStyleBackColor = false;
            this.PopMovBtn.Click += new System.EventHandler(this.PopMovBtn_Click);
            // 
            // PopCustBtn
            // 
            this.PopCustBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PopCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopCustBtn.ForeColor = System.Drawing.Color.Red;
            this.PopCustBtn.Location = new System.Drawing.Point(576, 12);
            this.PopCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PopCustBtn.Name = "PopCustBtn";
            this.PopCustBtn.Size = new System.Drawing.Size(158, 102);
            this.PopCustBtn.TabIndex = 29;
            this.PopCustBtn.Text = "Good Customer";
            this.PopCustBtn.UseVisualStyleBackColor = false;
            this.PopCustBtn.Click += new System.EventHandler(this.PopCustBtn_Click);
            // 
            // LoadRentedMovies
            // 
            this.LoadRentedMovies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadRentedMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadRentedMovies.ForeColor = System.Drawing.Color.Red;
            this.LoadRentedMovies.Location = new System.Drawing.Point(298, 12);
            this.LoadRentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.LoadRentedMovies.Name = "LoadRentedMovies";
            this.LoadRentedMovies.Size = new System.Drawing.Size(134, 102);
            this.LoadRentedMovies.TabIndex = 28;
            this.LoadRentedMovies.Text = "Load Rented Movies";
            this.LoadRentedMovies.UseVisualStyleBackColor = false;
            this.LoadRentedMovies.Click += new System.EventHandler(this.LoadRentedMovies_Click);
            // 
            // IssueMovieBtn
            // 
            this.IssueMovieBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IssueMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueMovieBtn.ForeColor = System.Drawing.Color.Red;
            this.IssueMovieBtn.Location = new System.Drawing.Point(742, 12);
            this.IssueMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IssueMovieBtn.Name = "IssueMovieBtn";
            this.IssueMovieBtn.Size = new System.Drawing.Size(132, 102);
            this.IssueMovieBtn.TabIndex = 27;
            this.IssueMovieBtn.Text = "Issue Movie";
            this.IssueMovieBtn.UseVisualStyleBackColor = false;
            this.IssueMovieBtn.Click += new System.EventHandler(this.IssueMovieBtn_Click);
            // 
            // ReturnMovieBtn
            // 
            this.ReturnMovieBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMovieBtn.ForeColor = System.Drawing.Color.Red;
            this.ReturnMovieBtn.Location = new System.Drawing.Point(882, 12);
            this.ReturnMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnMovieBtn.Name = "ReturnMovieBtn";
            this.ReturnMovieBtn.Size = new System.Drawing.Size(129, 102);
            this.ReturnMovieBtn.TabIndex = 26;
            this.ReturnMovieBtn.Text = "Return Movie";
            this.ReturnMovieBtn.UseVisualStyleBackColor = false;
            this.ReturnMovieBtn.Click += new System.EventHandler(this.ReturnMovieBtn_Click);
            // 
            // LoadMovies
            // 
            this.LoadMovies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadMovies.ForeColor = System.Drawing.Color.Red;
            this.LoadMovies.Location = new System.Drawing.Point(178, 13);
            this.LoadMovies.Margin = new System.Windows.Forms.Padding(4);
            this.LoadMovies.Name = "LoadMovies";
            this.LoadMovies.Size = new System.Drawing.Size(119, 102);
            this.LoadMovies.TabIndex = 25;
            this.LoadMovies.Text = "Load Movies";
            this.LoadMovies.UseVisualStyleBackColor = false;
            this.LoadMovies.Click += new System.EventHandler(this.LoadMovies_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(73, 123);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 51;
            this.MainGrid.Size = new System.Drawing.Size(872, 361);
            this.MainGrid.TabIndex = 24;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(37, 50);
            this.MovieIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(83, 20);
            this.MovieIDLabel.TabIndex = 45;
            this.MovieIDLabel.Text = "Movie ID";
            // 
            // MovieIDTBox
            // 
            this.MovieIDTBox.Enabled = false;
            this.MovieIDTBox.Location = new System.Drawing.Point(7, 82);
            this.MovieIDTBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieIDTBox.Name = "MovieIDTBox";
            this.MovieIDTBox.Size = new System.Drawing.Size(132, 27);
            this.MovieIDTBox.TabIndex = 44;
            // 
            // DltCustBtn
            // 
            this.DltCustBtn.BackColor = System.Drawing.Color.Red;
            this.DltCustBtn.ForeColor = System.Drawing.Color.Black;
            this.DltCustBtn.Location = new System.Drawing.Point(403, 138);
            this.DltCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DltCustBtn.Name = "DltCustBtn";
            this.DltCustBtn.Size = new System.Drawing.Size(132, 66);
            this.DltCustBtn.TabIndex = 43;
            this.DltCustBtn.Text = "Delete Customer";
            this.DltCustBtn.UseVisualStyleBackColor = false;
            this.DltCustBtn.Click += new System.EventHandler(this.DltCustBtn_Click);
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(182, 20);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(115, 20);
            this.CustIDLabel.TabIndex = 42;
            this.CustIDLabel.Text = "Customer ID";
            this.CustIDLabel.Click += new System.EventHandler(this.CustIDLabel_Click);
            // 
            // CustIDTBox
            // 
            this.CustIDTBox.Enabled = false;
            this.CustIDTBox.Location = new System.Drawing.Point(182, 40);
            this.CustIDTBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustIDTBox.Name = "CustIDTBox";
            this.CustIDTBox.Size = new System.Drawing.Size(132, 27);
            this.CustIDTBox.TabIndex = 41;
            this.CustIDTBox.TextChanged += new System.EventHandler(this.CustIDTBox_TextChanged);
            // 
            // UpdCustBtn
            // 
            this.UpdCustBtn.BackColor = System.Drawing.Color.Red;
            this.UpdCustBtn.Location = new System.Drawing.Point(282, 138);
            this.UpdCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdCustBtn.Name = "UpdCustBtn";
            this.UpdCustBtn.Size = new System.Drawing.Size(115, 66);
            this.UpdCustBtn.TabIndex = 40;
            this.UpdCustBtn.Text = "Update Customer";
            this.UpdCustBtn.UseVisualStyleBackColor = false;
            this.UpdCustBtn.Click += new System.EventHandler(this.UpdCustBtn_Click);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.BackColor = System.Drawing.Color.Red;
            this.AddCustBtn.Location = new System.Drawing.Point(143, 138);
            this.AddCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(127, 66);
            this.AddCustBtn.TabIndex = 39;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = false;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(460, 72);
            this.PhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(61, 20);
            this.PhLabel.TabIndex = 38;
            this.PhLabel.Text = "Phone";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(319, 72);
            this.AdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(78, 20);
            this.AdLabel.TabIndex = 37;
            this.AdLabel.Text = "Address";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(178, 72);
            this.LNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(100, 20);
            this.LNLabel.TabIndex = 36;
            this.LNLabel.Text = "Last Name";
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(323, 20);
            this.FNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(102, 20);
            this.FNLabel.TabIndex = 35;
            this.FNLabel.Text = "First Name";
            // 
            // PhTBox
            // 
            this.PhTBox.Location = new System.Drawing.Point(464, 91);
            this.PhTBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhTBox.Name = "PhTBox";
            this.PhTBox.Size = new System.Drawing.Size(132, 27);
            this.PhTBox.TabIndex = 34;
            // 
            // AdTBox
            // 
            this.AdTBox.Location = new System.Drawing.Point(323, 91);
            this.AdTBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdTBox.Name = "AdTBox";
            this.AdTBox.Size = new System.Drawing.Size(132, 27);
            this.AdTBox.TabIndex = 33;
            // 
            // LNTBox
            // 
            this.LNTBox.Location = new System.Drawing.Point(182, 91);
            this.LNTBox.Margin = new System.Windows.Forms.Padding(4);
            this.LNTBox.Name = "LNTBox";
            this.LNTBox.Size = new System.Drawing.Size(132, 27);
            this.LNTBox.TabIndex = 32;
            // 
            // FNTBox
            // 
            this.FNTBox.Location = new System.Drawing.Point(323, 40);
            this.FNTBox.Margin = new System.Windows.Forms.Padding(4);
            this.FNTBox.Name = "FNTBox";
            this.FNTBox.Size = new System.Drawing.Size(132, 27);
            this.FNTBox.TabIndex = 31;
            // 
            // movie
            // 
            this.movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.movie.Controls.Add(this.UpdateMovies);
            this.movie.Controls.Add(this.MovieIDLabel);
            this.movie.Controls.Add(this.DeleteMovies);
            this.movie.Controls.Add(this.MovieIDTBox);
            this.movie.Controls.Add(this.AddMovies);
            this.movie.Controls.Add(this.Year);
            this.movie.Controls.Add(this.Title);
            this.movie.Controls.Add(this.Rental_Cost);
            this.movie.Controls.Add(this.Plot);
            this.movie.Controls.Add(this.Genre);
            this.movie.Controls.Add(this.Copies);
            this.movie.Controls.Add(this.Rating);
            this.movie.Controls.Add(this.txtPlot);
            this.movie.Controls.Add(this.txtGenre);
            this.movie.Controls.Add(this.textRental_Cost);
            this.movie.Controls.Add(this.textCopies);
            this.movie.Controls.Add(this.txtYear);
            this.movie.Controls.Add(this.txtTitle);
            this.movie.Controls.Add(this.txtRating);
            this.movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie.ForeColor = System.Drawing.Color.Red;
            this.movie.Location = new System.Drawing.Point(1037, 73);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(360, 457);
            this.movie.TabIndex = 46;
            this.movie.TabStop = false;
            this.movie.Text = "movie";
            // 
            // UpdateMovies
            // 
            this.UpdateMovies.BackColor = System.Drawing.Color.Cyan;
            this.UpdateMovies.Location = new System.Drawing.Point(139, 369);
            this.UpdateMovies.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateMovies.Name = "UpdateMovies";
            this.UpdateMovies.Size = new System.Drawing.Size(83, 66);
            this.UpdateMovies.TabIndex = 67;
            this.UpdateMovies.Text = "Update Movies";
            this.UpdateMovies.UseVisualStyleBackColor = false;
            this.UpdateMovies.Click += new System.EventHandler(this.UpdateMovies_Click);
            // 
            // DeleteMovies
            // 
            this.DeleteMovies.BackColor = System.Drawing.Color.Cyan;
            this.DeleteMovies.Location = new System.Drawing.Point(251, 369);
            this.DeleteMovies.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteMovies.Name = "DeleteMovies";
            this.DeleteMovies.Size = new System.Drawing.Size(83, 66);
            this.DeleteMovies.TabIndex = 66;
            this.DeleteMovies.Text = "Delete Movies";
            this.DeleteMovies.UseVisualStyleBackColor = false;
            this.DeleteMovies.Click += new System.EventHandler(this.DeleteMovies_Click);
            // 
            // AddMovies
            // 
            this.AddMovies.BackColor = System.Drawing.Color.Cyan;
            this.AddMovies.Location = new System.Drawing.Point(27, 369);
            this.AddMovies.Margin = new System.Windows.Forms.Padding(4);
            this.AddMovies.Name = "AddMovies";
            this.AddMovies.Size = new System.Drawing.Size(83, 66);
            this.AddMovies.TabIndex = 65;
            this.AddMovies.Text = "Add Movies";
            this.AddMovies.UseVisualStyleBackColor = false;
            this.AddMovies.Click += new System.EventHandler(this.AddMovies_Click);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(198, 114);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(47, 20);
            this.Year.TabIndex = 63;
            this.Year.Text = "Year";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(64, 114);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(46, 20);
            this.Title.TabIndex = 61;
            this.Title.Text = "Title";
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.AutoSize = true;
            this.Rental_Cost.Location = new System.Drawing.Point(37, 171);
            this.Rental_Cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rental_Cost.Name = "Rental_Cost";
            this.Rental_Cost.Size = new System.Drawing.Size(112, 20);
            this.Rental_Cost.TabIndex = 60;
            this.Rental_Cost.Text = "Rental_Cost";
            // 
            // Plot
            // 
            this.Plot.AutoSize = true;
            this.Plot.Location = new System.Drawing.Point(48, 248);
            this.Plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(42, 20);
            this.Plot.TabIndex = 59;
            this.Plot.Text = "Plot";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(198, 248);
            this.Genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(60, 20);
            this.Genre.TabIndex = 58;
            this.Genre.Text = "Genre";
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(198, 171);
            this.Copies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(67, 20);
            this.Copies.TabIndex = 57;
            this.Copies.Text = "Copies";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(187, 61);
            this.Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(63, 20);
            this.Rating.TabIndex = 56;
            this.Rating.Text = "Rating";
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(0, 269);
            this.txtPlot.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(132, 27);
            this.txtPlot.TabIndex = 55;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(168, 269);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(132, 27);
            this.txtGenre.TabIndex = 53;
            // 
            // textRental_Cost
            // 
            this.textRental_Cost.Location = new System.Drawing.Point(7, 192);
            this.textRental_Cost.Margin = new System.Windows.Forms.Padding(4);
            this.textRental_Cost.Name = "textRental_Cost";
            this.textRental_Cost.Size = new System.Drawing.Size(132, 27);
            this.textRental_Cost.TabIndex = 52;
            // 
            // textCopies
            // 
            this.textCopies.Location = new System.Drawing.Point(168, 192);
            this.textCopies.Margin = new System.Windows.Forms.Padding(4);
            this.textCopies.Name = "textCopies";
            this.textCopies.Size = new System.Drawing.Size(132, 27);
            this.textCopies.TabIndex = 51;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(168, 135);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(132, 27);
            this.txtYear.TabIndex = 50;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(7, 135);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 27);
            this.txtTitle.TabIndex = 48;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(147, 82);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(132, 27);
            this.txtRating.TabIndex = 47;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customer.Controls.Add(this.FNTBox);
            this.customer.Controls.Add(this.LNTBox);
            this.customer.Controls.Add(this.DltCustBtn);
            this.customer.Controls.Add(this.UpdCustBtn);
            this.customer.Controls.Add(this.AdTBox);
            this.customer.Controls.Add(this.AddCustBtn);
            this.customer.Controls.Add(this.CustIDLabel);
            this.customer.Controls.Add(this.PhTBox);
            this.customer.Controls.Add(this.CustIDTBox);
            this.customer.Controls.Add(this.FNLabel);
            this.customer.Controls.Add(this.LNLabel);
            this.customer.Controls.Add(this.AdLabel);
            this.customer.Controls.Add(this.PhLabel);
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Black;
            this.customer.Location = new System.Drawing.Point(264, 520);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(747, 211);
            this.customer.TabIndex = 47;
            this.customer.TabStop = false;
            this.customer.Text = "customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1431, 757);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.PopMovBtn);
            this.Controls.Add(this.PopCustBtn);
            this.Controls.Add(this.LoadRentedMovies);
            this.Controls.Add(this.IssueMovieBtn);
            this.Controls.Add(this.ReturnMovieBtn);
            this.Controls.Add(this.LoadMovies);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.movie.ResumeLayout(false);
            this.movie.PerformLayout();
            this.customer.ResumeLayout(false);
            this.customer.PerformLayout();
            this.ResumeLayout(false);

        }

       private void CustIDTBox_TextChanged(object sender, EventArgs e)
        {
            
       }

        private void CustIDLabel_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button PopMovBtn;
        private System.Windows.Forms.Button PopCustBtn;
        private System.Windows.Forms.Button LoadRentedMovies;
        private System.Windows.Forms.Button IssueMovieBtn;
        private System.Windows.Forms.Button ReturnMovieBtn;
        private System.Windows.Forms.Button LoadMovies;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.TextBox MovieIDTBox;
        private System.Windows.Forms.Button DltCustBtn;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.TextBox CustIDTBox;
        private System.Windows.Forms.Button UpdCustBtn;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.TextBox PhTBox;
        private System.Windows.Forms.TextBox AdTBox;
        private System.Windows.Forms.TextBox LNTBox;
        private System.Windows.Forms.TextBox FNTBox;
        private System.Windows.Forms.GroupBox movie;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button UpdateMovies;
        private System.Windows.Forms.Button DeleteMovies;
        private System.Windows.Forms.Button AddMovies;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Rental_Cost;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox textRental_Cost;
        private System.Windows.Forms.TextBox textCopies;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox customer;
    }
}

