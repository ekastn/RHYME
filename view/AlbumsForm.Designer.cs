namespace RYHME.view
{
    partial class AlbumsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            idLabel = new Label();
            titleLabel = new Label();
            artistLabel = new Label();
            releaseYearLabel = new Label();
            genreLabel = new Label();
            coverImageLabel = new Label();
            idTextBox = new TextBox();
            titleTextBox = new TextBox();
            artistsComboBox = new ComboBox();
            releaseYearTextBox = new TextBox();
            genreTextBox = new TextBox();
            coverImageTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            albumsDataGridView = new DataGridView();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)albumsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Location = new Point(17, 155);
            idLabel.Margin = new Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(80, 18);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(17, 125);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(80, 18);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            artistLabel.Location = new Point(17, 93);
            artistLabel.Margin = new Padding(2, 0, 2, 0);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(80, 18);
            artistLabel.TabIndex = 2;
            artistLabel.Text = "Artist";
            // 
            // releaseYearLabel
            // 
            releaseYearLabel.Location = new Point(17, 62);
            releaseYearLabel.Margin = new Padding(2, 0, 2, 0);
            releaseYearLabel.Name = "releaseYearLabel";
            releaseYearLabel.Size = new Size(80, 18);
            releaseYearLabel.TabIndex = 3;
            releaseYearLabel.Text = "Release Year";
            // 
            // genreLabel
            // 
            genreLabel.Location = new Point(17, 36);
            genreLabel.Margin = new Padding(2, 0, 2, 0);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(80, 18);
            genreLabel.TabIndex = 4;
            genreLabel.Text = "Genre";
            // 
            // coverImageLabel
            // 
            coverImageLabel.Location = new Point(17, 9);
            coverImageLabel.Margin = new Padding(2, 0, 2, 0);
            coverImageLabel.Name = "coverImageLabel";
            coverImageLabel.Size = new Size(80, 18);
            coverImageLabel.TabIndex = 5;
            coverImageLabel.Text = "Cover Image";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(102, 155);
            idTextBox.Margin = new Padding(2, 2, 2, 2);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(265, 27);
            idTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(102, 126);
            titleTextBox.Margin = new Padding(2, 2, 2, 2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(265, 27);
            titleTextBox.TabIndex = 7;
            // 
            // artistsComboBox
            // 
            artistsComboBox.Location = new Point(102, 94);
            artistsComboBox.Margin = new Padding(2, 2, 2, 2);
            artistsComboBox.Name = "artistsComboBox";
            artistsComboBox.Size = new Size(265, 28);
            artistsComboBox.TabIndex = 8;
            // 
            // releaseYearTextBox
            // 
            releaseYearTextBox.Location = new Point(102, 66);
            releaseYearTextBox.Margin = new Padding(2, 2, 2, 2);
            releaseYearTextBox.Name = "releaseYearTextBox";
            releaseYearTextBox.Size = new Size(265, 27);
            releaseYearTextBox.TabIndex = 9;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(102, 36);
            genreTextBox.Margin = new Padding(2, 2, 2, 2);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(265, 27);
            genreTextBox.TabIndex = 10;
            // 
            // coverImageTextBox
            // 
            coverImageTextBox.Location = new Point(102, 10);
            coverImageTextBox.Margin = new Padding(2, 2, 2, 2);
            coverImageTextBox.Name = "coverImageTextBox";
            coverImageTextBox.Size = new Size(265, 27);
            coverImageTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.Location = new Point(551, 58);
            addButton.Margin = new Padding(2, 2, 2, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(70, 29);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(437, 105);
            updateButton.Margin = new Padding(2, 2, 2, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(69, 29);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(551, 105);
            deleteButton.Margin = new Padding(2, 2, 2, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(70, 29);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(319, 191);
            searchTextBox.Margin = new Padding(2, 2, 2, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(218, 27);
            searchTextBox.TabIndex = 15;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(552, 190);
            searchButton.Margin = new Padding(2, 2, 2, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(70, 26);
            searchButton.TabIndex = 16;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // albumsDataGridView
            // 
            albumsDataGridView.ColumnHeadersHeight = 34;
            albumsDataGridView.Location = new Point(10, 221);
            albumsDataGridView.Margin = new Padding(2, 2, 2, 2);
            albumsDataGridView.Name = "albumsDataGridView";
            albumsDataGridView.RowHeadersWidth = 62;
            albumsDataGridView.Size = new Size(629, 176);
            albumsDataGridView.TabIndex = 17;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(438, 58);
            refreshButton.Margin = new Padding(2, 2, 2, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(67, 29);
            refreshButton.TabIndex = 18;
            refreshButton.Text = "Refresh";
            // 
            // AlbumsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 406);
            Controls.Add(refreshButton);
            Controls.Add(idLabel);
            Controls.Add(titleLabel);
            Controls.Add(artistLabel);
            Controls.Add(releaseYearLabel);
            Controls.Add(genreLabel);
            Controls.Add(coverImageLabel);
            Controls.Add(idTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(artistsComboBox);
            Controls.Add(releaseYearTextBox);
            Controls.Add(genreTextBox);
            Controls.Add(coverImageTextBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(albumsDataGridView);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AlbumsForm";
            Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)albumsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label releaseYearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label coverImageLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox artistsComboBox;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox coverImageTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView albumsDataGridView;
        private Button refreshButton;
    }
}
