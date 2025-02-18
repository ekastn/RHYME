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
            nameTextBox = new TextBox();
            genreTextBox = new TextBox();
            contactTextBox = new TextBox();
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
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(40, 38);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 22);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // genreLabel
            // 
            genreLabel.ForeColor = Color.White;
            genreLabel.Location = new Point(40, 95);
            genreLabel.Margin = new Padding(2, 0, 2, 0);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(100, 22);
            genreLabel.TabIndex = 1;
            genreLabel.Text = "Genre";
            // 
            // contactLabel
            // 
            contactLabel.ForeColor = Color.White;
            contactLabel.Location = new Point(40, 146);
            contactLabel.Margin = new Padding(2, 0, 2, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(100, 22);
            contactLabel.TabIndex = 2;
            contactLabel.Text = "Contact";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(140, 38);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(362, 31);
            nameTextBox.TabIndex = 4;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(140, 91);
            genreTextBox.Margin = new Padding(2);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(362, 31);
            genreTextBox.TabIndex = 5;
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(140, 142);
            contactTextBox.Margin = new Padding(2);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(362, 31);
            contactTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(880, 49);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(92, 36);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(754, 102);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(84, 36);
            updateButton.TabIndex = 9;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(880, 102);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(92, 36);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(655, 219);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(239, 31);
            searchTextBox.TabIndex = 11;
            // 
            // searchButton
            // 
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(914, 219);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(78, 34);
            searchButton.TabIndex = 12;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // artistsDataGridView
            // 
            artistsDataGridView.BackgroundColor = Color.White;
            artistsDataGridView.ColumnHeadersHeight = 34;
            artistsDataGridView.Location = new Point(28, 282);
            artistsDataGridView.Margin = new Padding(2);
            artistsDataGridView.Name = "artistsDataGridView";
            artistsDataGridView.RowHeadersWidth = 62;
            artistsDataGridView.Size = new Size(964, 344);
            artistsDataGridView.TabIndex = 13;
            // 
            // exportButton
            // 
            exportButton.ForeColor = Color.White;
            exportButton.Location = new Point(754, 49);
            exportButton.Margin = new Padding(2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(84, 36);
            exportButton.TabIndex = 14;
            exportButton.Text = "Export";
            exportButton.Click += exportButton_Click;
            // 
            // ArtistsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.Desain_tanpa_judul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 648);
            Controls.Add(exportButton);
            Controls.Add(nameLabel);
            Controls.Add(genreLabel);
            Controls.Add(contactLabel);
            Controls.Add(nameTextBox);
            Controls.Add(genreTextBox);
            Controls.Add(contactTextBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(artistsDataGridView);
            DoubleBuffered = true;
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView artistsDataGridView;
        private Button exportButton;
    }
}
