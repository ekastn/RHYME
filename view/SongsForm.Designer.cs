namespace RYHME.view
{
    partial class SongsForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.lyricsLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.lyricsTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.songsDataGridView = new System.Windows.Forms.DataGridView();

            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.lyricsLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.albumComboBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.lyricsTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.songsDataGridView);

            this.idLabel.Text = "ID";
            this.titleLabel.Text = "Title";
            this.albumLabel.Text = "Album";
            this.durationLabel.Text = "Duration";
            this.lyricsLabel.Text = "Lyrics";

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
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label lyricsLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox lyricsTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView songsDataGridView;
    }
}
