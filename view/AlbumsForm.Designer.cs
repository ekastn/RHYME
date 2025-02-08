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
            artistComboBox = new ComboBox();
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
            idLabel.Location = new Point(21, 194);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(100, 23);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(21, 156);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(100, 23);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            artistLabel.Location = new Point(21, 116);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(100, 23);
            artistLabel.TabIndex = 2;
            artistLabel.Text = "Artist";
            // 
            // releaseYearLabel
            // 
            releaseYearLabel.Location = new Point(21, 78);
            releaseYearLabel.Name = "releaseYearLabel";
            releaseYearLabel.Size = new Size(100, 23);
            releaseYearLabel.TabIndex = 3;
            releaseYearLabel.Text = "Release Year";
            // 
            // genreLabel
            // 
            genreLabel.Location = new Point(21, 45);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(100, 23);
            genreLabel.TabIndex = 4;
            genreLabel.Text = "Genre";
            // 
            // coverImageLabel
            // 
            coverImageLabel.Location = new Point(21, 11);
            coverImageLabel.Name = "coverImageLabel";
            coverImageLabel.Size = new Size(100, 23);
            coverImageLabel.TabIndex = 5;
            coverImageLabel.Text = "Cover Image";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(127, 194);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(330, 31);
            idTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(127, 157);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(330, 31);
            titleTextBox.TabIndex = 7;
            // 
            // artistComboBox
            // 
            artistComboBox.Location = new Point(127, 118);
            artistComboBox.Name = "artistComboBox";
            artistComboBox.Size = new Size(330, 33);
            artistComboBox.TabIndex = 8;
            // 
            // releaseYearTextBox
            // 
            releaseYearTextBox.Location = new Point(127, 82);
            releaseYearTextBox.Name = "releaseYearTextBox";
            releaseYearTextBox.Size = new Size(330, 31);
            releaseYearTextBox.TabIndex = 9;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(127, 45);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(330, 31);
            genreTextBox.TabIndex = 10;
            // 
            // coverImageTextBox
            // 
            coverImageTextBox.Location = new Point(127, 12);
            coverImageTextBox.Name = "coverImageTextBox";
            coverImageTextBox.Size = new Size(330, 31);
            coverImageTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.Location = new Point(689, 72);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 36);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(546, 131);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(86, 36);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(689, 131);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 36);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(399, 239);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(271, 31);
            searchTextBox.TabIndex = 15;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(690, 237);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(87, 33);
            searchButton.TabIndex = 16;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // albumsDataGridView
            // 
            albumsDataGridView.ColumnHeadersHeight = 34;
            albumsDataGridView.Location = new Point(12, 276);
            albumsDataGridView.Name = "albumsDataGridView";
            albumsDataGridView.RowHeadersWidth = 62;
            albumsDataGridView.Size = new Size(786, 220);
            albumsDataGridView.TabIndex = 17;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(548, 72);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(84, 36);
            refreshButton.TabIndex = 18;
            refreshButton.Text = "Refresh";
            // 
            // AlbumsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 508);
            Controls.Add(refreshButton);
            Controls.Add(idLabel);
            Controls.Add(titleLabel);
            Controls.Add(artistLabel);
            Controls.Add(releaseYearLabel);
            Controls.Add(genreLabel);
            Controls.Add(coverImageLabel);
            Controls.Add(idTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(artistComboBox);
            Controls.Add(releaseYearTextBox);
            Controls.Add(genreTextBox);
            Controls.Add(coverImageTextBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(albumsDataGridView);
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
        private System.Windows.Forms.ComboBox artistComboBox;
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
