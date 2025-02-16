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
            ((System.ComponentModel.ISupportInitialize)songsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(55, 60);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(45, 23);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // albumLabel
            // 
            albumLabel.Location = new Point(377, 60);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new Size(73, 23);
            albumLabel.TabIndex = 2;
            albumLabel.Text = "Album";
            // 
            // durationLabel
            // 
            durationLabel.Location = new Point(55, 102);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(90, 23);
            durationLabel.TabIndex = 3;
            durationLabel.Text = "Duration";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(163, 52);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(141, 31);
            titleTextBox.TabIndex = 6;
            // 
            // albumComboBox
            // 
            albumComboBox.Location = new Point(377, 94);
            albumComboBox.Name = "albumComboBox";
            albumComboBox.Size = new Size(141, 33);
            albumComboBox.TabIndex = 7;
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(163, 94);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(142, 31);
            durationTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(547, 151);
            addButton.Name = "addButton";
            addButton.Size = new Size(87, 32);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(640, 149);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(87, 34);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(733, 149);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(87, 33);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(14, 149);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(338, 31);
            searchTextBox.TabIndex = 13;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(377, 150);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(78, 31);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // songsDataGridView
            // 
            songsDataGridView.ColumnHeadersHeight = 34;
            songsDataGridView.Location = new Point(14, 188);
            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.RowHeadersWidth = 62;
            songsDataGridView.Size = new Size(806, 184);
            songsDataGridView.TabIndex = 15;
            // 
            // SongsForm
            // 
            ClientSize = new Size(832, 384);
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
    }
}
