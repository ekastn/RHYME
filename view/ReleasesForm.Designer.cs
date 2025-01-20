namespace RYHME.view
{
    partial class ReleasesForm
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
            this.albumOrSongLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.albumOrSongComboBox = new System.Windows.Forms.ComboBox();
            this.releaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.addReleaseButton = new System.Windows.Forms.Button();
            this.updateReleaseButton = new System.Windows.Forms.Button();
            this.deleteReleaseButton = new System.Windows.Forms.Button();
            this.releasesDataGridView = new System.Windows.Forms.DataGridView();

            this.Controls.Add(this.albumOrSongLabel);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.albumOrSongComboBox);
            this.Controls.Add(this.releaseDatePicker);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.addReleaseButton);
            this.Controls.Add(this.updateReleaseButton);
            this.Controls.Add(this.deleteReleaseButton);
            this.Controls.Add(this.releasesDataGridView);

            this.albumOrSongLabel.Text = "Album or Song";
            this.releaseDateLabel.Text = "Release Date";
            this.statusLabel.Text = "Status";

            this.addReleaseButton.Text = "Add";
            this.updateReleaseButton.Text = "Update";
            this.deleteReleaseButton.Text = "Delete";

            this.addReleaseButton.Click += new System.EventHandler(this.addReleaseButton_Click);
            this.updateReleaseButton.Click += new System.EventHandler(this.updateReleaseButton_Click);
            this.deleteReleaseButton.Click += new System.EventHandler(this.deleteReleaseButton_Click);

            // Set control positions and sizes here
        }

        private System.Windows.Forms.Label albumOrSongLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox albumOrSongComboBox;
        private System.Windows.Forms.DateTimePicker releaseDatePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button addReleaseButton;
        private System.Windows.Forms.Button updateReleaseButton;
        private System.Windows.Forms.Button deleteReleaseButton;
        private System.Windows.Forms.DataGridView releasesDataGridView;
    }
}
