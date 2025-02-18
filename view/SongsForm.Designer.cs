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
            titleLabel = new Label();
            albumLabel = new Label();
            durationLabel = new Label();
            titleTextBox = new TextBox();
            albumComboBox = new ComboBox();
            durationTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            songsDataGridView = new DataGridView();
            exportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)songsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(55, 60);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(45, 23);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // albumLabel
            // 
            albumLabel.ForeColor = Color.White;
            albumLabel.Location = new Point(56, 153);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new Size(73, 23);
            albumLabel.TabIndex = 2;
            albumLabel.Text = "Album";
            // 
            // durationLabel
            // 
            durationLabel.ForeColor = Color.White;
            durationLabel.Location = new Point(55, 106);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 23);
            durationLabel.TabIndex = 3;
            durationLabel.Text = "Duration";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(163, 56);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(225, 31);
            titleTextBox.TabIndex = 6;
            // 
            // albumComboBox
            // 
            albumComboBox.Location = new Point(164, 148);
            albumComboBox.Name = "albumComboBox";
            albumComboBox.Size = new Size(225, 33);
            albumComboBox.TabIndex = 7;
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(163, 102);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(226, 31);
            durationTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(754, 54);
            addButton.Name = "addButton";
            addButton.Size = new Size(87, 32);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(754, 114);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(87, 34);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(884, 115);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(87, 33);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(550, 268);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(338, 31);
            searchTextBox.TabIndex = 13;
            // 
            // searchButton
            // 
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(913, 269);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(78, 31);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // songsDataGridView
            // 
            songsDataGridView.BackgroundColor = Color.White;
            songsDataGridView.ColumnHeadersHeight = 34;
            songsDataGridView.Location = new Point(22, 320);
            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.RowHeadersWidth = 62;
            songsDataGridView.Size = new Size(969, 305);
            songsDataGridView.TabIndex = 15;
            // 
            // exportButton
            // 
            exportButton.ForeColor = Color.White;
            exportButton.Location = new Point(884, 54);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(87, 32);
            exportButton.TabIndex = 16;
            exportButton.Text = "Export";
            exportButton.Click += exportButton_Click;
            // 
            // SongsForm
            // 
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.Desain_tanpa_judul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 648);
            Controls.Add(exportButton);
            Controls.Add(titleLabel);
            Controls.Add(albumLabel);
            Controls.Add(durationLabel);
            Controls.Add(titleTextBox);
            Controls.Add(albumComboBox);
            Controls.Add(durationTextBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(songsDataGridView);
            DoubleBuffered = true;
            Name = "SongsForm";
            ((System.ComponentModel.ISupportInitialize)songsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView songsDataGridView;
        private Button exportButton;
    }
}
