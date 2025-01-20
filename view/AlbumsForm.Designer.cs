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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AlbumsForm";

            this.idLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.releaseYearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.coverImageLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.artistComboBox = new System.Windows.Forms.ComboBox();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.coverImageTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.albumsDataGridView = new System.Windows.Forms.DataGridView();

            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.releaseYearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.coverImageLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.artistComboBox);
            this.Controls.Add(this.releaseYearTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.coverImageTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.albumsDataGridView);

            this.idLabel.Text = "ID";
            this.titleLabel.Text = "Title";
            this.artistLabel.Text = "Artist";
            this.releaseYearLabel.Text = "Release Year";
            this.genreLabel.Text = "Genre";
            this.coverImageLabel.Text = "Cover Image";

            this.addButton.Text = "Add";
            this.updateButton.Text = "Update";
            this.deleteButton.Text = "Delete";
            this.searchButton.Text = "Search";

            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);

            // Set control positions and sizes here
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
    }
}
