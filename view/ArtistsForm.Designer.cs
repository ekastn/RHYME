namespace RYHME.view
{
    partial class ArtistsForm
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
            nameLabel = new Label();
            genreLabel = new Label();
            contactLabel = new Label();
            profilePictureLabel = new Label();
            nameTextBox = new TextBox();
            genreTextBox = new TextBox();
            contactTextBox = new TextBox();
            profilePictureTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            artistsDataGridView = new DataGridView();
            exportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)artistsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(16, 16);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(80, 18);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // genreLabel
            // 
            genreLabel.Location = new Point(16, 48);
            genreLabel.Margin = new Padding(2, 0, 2, 0);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(80, 18);
            genreLabel.TabIndex = 1;
            genreLabel.Text = "Genre";
            // 
            // contactLabel
            // 
            contactLabel.Location = new Point(16, 80);
            contactLabel.Margin = new Padding(2, 0, 2, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(80, 18);
            contactLabel.TabIndex = 2;
            contactLabel.Text = "Contact";
            // 
            // profilePictureLabel
            // 
            profilePictureLabel.Location = new Point(16, 112);
            profilePictureLabel.Margin = new Padding(2, 0, 2, 0);
            profilePictureLabel.Name = "profilePictureLabel";
            profilePictureLabel.Size = new Size(80, 18);
            profilePictureLabel.TabIndex = 3;
            profilePictureLabel.Text = "Profile Picture";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(96, 16);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(290, 27);
            nameTextBox.TabIndex = 4;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(96, 48);
            genreTextBox.Margin = new Padding(2);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(290, 27);
            genreTextBox.TabIndex = 5;
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(96, 80);
            contactTextBox.Margin = new Padding(2);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(290, 27);
            contactTextBox.TabIndex = 6;
            // 
            // profilePictureTextBox
            // 
            profilePictureTextBox.Location = new Point(96, 112);
            profilePictureTextBox.Margin = new Padding(2);
            profilePictureTextBox.Name = "profilePictureTextBox";
            profilePictureTextBox.Size = new Size(290, 27);
            profilePictureTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(539, 38);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(74, 29);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(438, 80);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(67, 29);
            updateButton.TabIndex = 9;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(539, 80);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(74, 29);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(16, 174);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(192, 27);
            searchTextBox.TabIndex = 11;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(247, 174);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(62, 27);
            searchButton.TabIndex = 12;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // artistsDataGridView
            // 
            artistsDataGridView.ColumnHeadersHeight = 34;
            artistsDataGridView.Location = new Point(16, 208);
            artistsDataGridView.Margin = new Padding(2);
            artistsDataGridView.Name = "artistsDataGridView";
            artistsDataGridView.RowHeadersWidth = 62;
            artistsDataGridView.Size = new Size(608, 144);
            artistsDataGridView.TabIndex = 13;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(438, 38);
            exportButton.Margin = new Padding(2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(67, 29);
            exportButton.TabIndex = 14;
            exportButton.Text = "Export";
            exportButton.Click += exportButton_Click;
            // 
            // ArtistsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(exportButton);
            Controls.Add(nameLabel);
            Controls.Add(genreLabel);
            Controls.Add(contactLabel);
            Controls.Add(profilePictureLabel);
            Controls.Add(nameTextBox);
            Controls.Add(genreTextBox);
            Controls.Add(contactTextBox);
            Controls.Add(profilePictureTextBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(artistsDataGridView);
            Margin = new Padding(2);
            Name = "ArtistsForm";
            Text = "ArtistsForm";
            ((System.ComponentModel.ISupportInitialize)artistsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label profilePictureLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox profilePictureTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView artistsDataGridView;
        private Button exportButton;
    }
}
