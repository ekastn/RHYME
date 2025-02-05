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
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)artistsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(20, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 23);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // genreLabel
            // 
            genreLabel.Location = new Point(20, 60);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(100, 23);
            genreLabel.TabIndex = 1;
            genreLabel.Text = "Genre";
            // 
            // contactLabel
            // 
            contactLabel.Location = new Point(20, 100);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(100, 23);
            contactLabel.TabIndex = 2;
            contactLabel.Text = "Contact";
            // 
            // profilePictureLabel
            // 
            profilePictureLabel.Location = new Point(20, 140);
            profilePictureLabel.Name = "profilePictureLabel";
            profilePictureLabel.Size = new Size(100, 23);
            profilePictureLabel.TabIndex = 3;
            profilePictureLabel.Text = "Profile Picture";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(120, 20);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(361, 31);
            nameTextBox.TabIndex = 4;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(120, 60);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(361, 31);
            genreTextBox.TabIndex = 5;
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(120, 100);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(361, 31);
            contactTextBox.TabIndex = 6;
            // 
            // profilePictureTextBox
            // 
            profilePictureTextBox.Location = new Point(120, 140);
            profilePictureTextBox.Name = "profilePictureTextBox";
            profilePictureTextBox.Size = new Size(361, 31);
            profilePictureTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(688, 50);
            addButton.Name = "addButton";
            addButton.Size = new Size(78, 33);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(567, 100);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(84, 36);
            updateButton.TabIndex = 9;
            updateButton.Text = "Update";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(688, 101);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(78, 34);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(20, 217);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(239, 31);
            searchTextBox.TabIndex = 11;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(309, 217);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(78, 34);
            searchButton.TabIndex = 12;
            searchButton.Text = "Search";
            // 
            // artistsDataGridView
            // 
            artistsDataGridView.ColumnHeadersHeight = 34;
            artistsDataGridView.Location = new Point(20, 260);
            artistsDataGridView.Name = "artistsDataGridView";
            artistsDataGridView.RowHeadersWidth = 62;
            artistsDataGridView.Size = new Size(760, 180);
            artistsDataGridView.TabIndex = 13;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(567, 47);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(84, 36);
            refreshButton.TabIndex = 14;
            refreshButton.Text = "Refresh";
            // 
            // ArtistsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refreshButton);
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
        private Button refreshButton;
    }
}
