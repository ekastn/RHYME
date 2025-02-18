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
            titleLabel.Location = new Point(22, 51);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(100, 22);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            artistLabel.ForeColor = Color.White;
            artistLabel.Location = new Point(22, 121);
            artistLabel.Margin = new Padding(2, 0, 2, 0);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(100, 22);
            artistLabel.TabIndex = 2;
            artistLabel.Text = "Artist";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(128, 51);
            titleTextBox.Margin = new Padding(2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(330, 31);
            titleTextBox.TabIndex = 7;
            // 
            // artistsComboBox
            // 
            artistsComboBox.Location = new Point(128, 118);
            artistsComboBox.Margin = new Padding(2);
            artistsComboBox.Name = "artistsComboBox";
            artistsComboBox.Size = new Size(330, 33);
            artistsComboBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(887, 48);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 36);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(745, 107);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(86, 36);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(887, 107);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 36);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(613, 230);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(272, 31);
            searchTextBox.TabIndex = 15;
            // 
            // searchButton
            // 
            searchButton.ForeColor = SystemColors.ButtonHighlight;
            searchButton.Location = new Point(904, 229);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(88, 32);
            searchButton.TabIndex = 16;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // albumsDataGridView
            // 
            albumsDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            albumsDataGridView.ColumnHeadersHeight = 34;
            albumsDataGridView.Location = new Point(35, 284);
            albumsDataGridView.Margin = new Padding(2);
            albumsDataGridView.Name = "albumsDataGridView";
            albumsDataGridView.RowHeadersWidth = 62;
            albumsDataGridView.Size = new Size(957, 344);
            albumsDataGridView.TabIndex = 17;
            // 
            // exportButton
            // 
            exportButton.ForeColor = SystemColors.ButtonHighlight;
            exportButton.Location = new Point(746, 48);
            exportButton.Margin = new Padding(2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(84, 36);
            exportButton.TabIndex = 18;
            exportButton.Text = "Export";
            exportButton.Click += exportButton_Click;
            // 
            // AlbumsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.Desain_tanpa_judul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 648);
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
