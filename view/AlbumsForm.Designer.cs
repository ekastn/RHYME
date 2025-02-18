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
            titleLabel = new Label();
            artistLabel = new Label();
            titleTextBox = new TextBox();
            artistsComboBox = new ComboBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            albumsDataGridView = new DataGridView();
            exportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)albumsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(18, 41);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(80, 18);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            artistLabel.ForeColor = Color.White;
            artistLabel.Location = new Point(18, 97);
            artistLabel.Margin = new Padding(2, 0, 2, 0);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(80, 18);
            artistLabel.TabIndex = 2;
            artistLabel.Text = "Artist";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(102, 41);
            titleTextBox.Margin = new Padding(2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(265, 27);
            titleTextBox.TabIndex = 7;
            // 
            // artistsComboBox
            // 
            artistsComboBox.Location = new Point(102, 94);
            artistsComboBox.Margin = new Padding(2);
            artistsComboBox.Name = "artistsComboBox";
            artistsComboBox.Size = new Size(265, 28);
            artistsComboBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(749, 44);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(70, 29);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(635, 91);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(69, 29);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(749, 91);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(70, 29);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(515, 178);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(218, 27);
            searchTextBox.TabIndex = 15;
            // 
            // searchButton
            // 
            searchButton.ForeColor = SystemColors.ButtonHighlight;
            searchButton.Location = new Point(748, 177);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(70, 26);
            searchButton.TabIndex = 16;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // albumsDataGridView
            // 
            albumsDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            albumsDataGridView.ColumnHeadersHeight = 34;
            albumsDataGridView.Location = new Point(11, 227);
            albumsDataGridView.Margin = new Padding(2);
            albumsDataGridView.Name = "albumsDataGridView";
            albumsDataGridView.RowHeadersWidth = 62;
            albumsDataGridView.Size = new Size(819, 233);
            albumsDataGridView.TabIndex = 17;
            // 
            // exportButton
            // 
            exportButton.ForeColor = SystemColors.ButtonHighlight;
            exportButton.Location = new Point(636, 44);
            exportButton.Margin = new Padding(2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(67, 29);
            exportButton.TabIndex = 18;
            exportButton.Text = "Export";
            exportButton.Click += exportButton_Click;
            // 
            // AlbumsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.Desain_tanpa_judul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 471);
            Controls.Add(exportButton);
            Controls.Add(titleLabel);
            Controls.Add(artistLabel);
            Controls.Add(titleTextBox);
            Controls.Add(artistsComboBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(albumsDataGridView);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "AlbumsForm";
            Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)albumsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox artistsComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView albumsDataGridView;
        private Button exportButton;
    }
}
