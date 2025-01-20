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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ArtistsForm";

            this.nameLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.profilePictureLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.profilePictureTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.artistsDataGridView = new System.Windows.Forms.DataGridView();

            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.profilePictureLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.profilePictureTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.artistsDataGridView);

            this.nameLabel.Text = "Name";
            this.genreLabel.Text = "Genre";
            this.contactLabel.Text = "Contact";
            this.profilePictureLabel.Text = "Profile Picture";
            this.addButton.Text = "Add";
            this.updateButton.Text = "Update";
            this.deleteButton.Text = "Delete";
            this.searchButton.Text = "Search";

            this.nameLabel.Location = new System.Drawing.Point(20, 20);
            this.genreLabel.Location = new System.Drawing.Point(20, 60);
            this.contactLabel.Location = new System.Drawing.Point(20, 100);
            this.profilePictureLabel.Location = new System.Drawing.Point(20, 140);
            this.nameTextBox.Location = new System.Drawing.Point(120, 20);
            this.genreTextBox.Location = new System.Drawing.Point(120, 60);
            this.contactTextBox.Location = new System.Drawing.Point(120, 100);
            this.profilePictureTextBox.Location = new System.Drawing.Point(120, 140);
            this.addButton.Location = new System.Drawing.Point(20, 180);
            this.updateButton.Location = new System.Drawing.Point(100, 180);
            this.deleteButton.Location = new System.Drawing.Point(180, 180);
            this.searchTextBox.Location = new System.Drawing.Point(20, 220);
            this.searchButton.Location = new System.Drawing.Point(200, 220);
            this.artistsDataGridView.Location = new System.Drawing.Point(20, 260);
            this.artistsDataGridView.Size = new System.Drawing.Size(760, 180);
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
    }
}
