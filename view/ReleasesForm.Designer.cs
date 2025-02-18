using RYHME.Models;

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
            albumOrSongLabel = new Label();
            releaseDateLabel = new Label();
            statusLabel = new Label();
            albumOrSongComboBox = new ComboBox();
            releaseDatePicker = new DateTimePicker();
            statusComboBox = new ComboBox();
            addReleaseButton = new Button();
            updateReleaseButton = new Button();
            deleteReleaseButton = new Button();
            releasesDataGridView = new DataGridView();
            exportButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            typeLabel = new Label();
            typeComboBox = new ComboBox();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)releasesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // albumOrSongLabel
            // 
            albumOrSongLabel.ForeColor = Color.White;
            albumOrSongLabel.Location = new Point(30, 155);
            albumOrSongLabel.Name = "albumOrSongLabel";
            albumOrSongLabel.Size = new Size(100, 23);
            albumOrSongLabel.TabIndex = 0;
            albumOrSongLabel.Text = "Album or Song";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.ForeColor = Color.White;
            releaseDateLabel.Location = new Point(30, 101);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(100, 23);
            releaseDateLabel.TabIndex = 1;
            releaseDateLabel.Text = "Release Date";
            // 
            // statusLabel
            // 
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(30, 49);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(100, 23);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status";
            // 
            // albumOrSongComboBox
            // 
            albumOrSongComboBox.Location = new Point(136, 150);
            albumOrSongComboBox.Name = "albumOrSongComboBox";
            albumOrSongComboBox.Size = new Size(309, 33);
            albumOrSongComboBox.TabIndex = 3;
            // 
            // releaseDatePicker
            // 
            releaseDatePicker.Location = new Point(136, 97);
            releaseDatePicker.Name = "releaseDatePicker";
            releaseDatePicker.Size = new Size(309, 31);
            releaseDatePicker.TabIndex = 4;
            // 
            // statusComboBox
            // 
            statusComboBox.Items.AddRange(new object[] { ReleaseStatus.Draft, ReleaseStatus.Scheduled, ReleaseStatus.Released, ReleaseStatus.Cancelled });
            statusComboBox.Location = new Point(136, 44);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(309, 33);
            statusComboBox.TabIndex = 5;
            // 
            // addReleaseButton
            // 
            addReleaseButton.ForeColor = Color.White;
            addReleaseButton.Location = new Point(769, 279);
            addReleaseButton.Name = "addReleaseButton";
            addReleaseButton.Size = new Size(96, 31);
            addReleaseButton.TabIndex = 6;
            addReleaseButton.Text = "Add";
            addReleaseButton.Click += addReleaseButton_Click;
            // 
            // updateReleaseButton
            // 
            updateReleaseButton.ForeColor = Color.White;
            updateReleaseButton.Location = new Point(906, 279);
            updateReleaseButton.Name = "updateReleaseButton";
            updateReleaseButton.Size = new Size(89, 31);
            updateReleaseButton.TabIndex = 7;
            updateReleaseButton.Text = "Update";
            updateReleaseButton.Click += updateReleaseButton_Click;
            // 
            // deleteReleaseButton
            // 
            deleteReleaseButton.ForeColor = Color.White;
            deleteReleaseButton.Location = new Point(906, 217);
            deleteReleaseButton.Name = "deleteReleaseButton";
            deleteReleaseButton.Size = new Size(89, 33);
            deleteReleaseButton.TabIndex = 8;
            deleteReleaseButton.Text = "Delete";
            deleteReleaseButton.Click += deleteReleaseButton_Click;
            // 
            // releasesDataGridView
            // 
            releasesDataGridView.BackgroundColor = Color.White;
            releasesDataGridView.ColumnHeadersHeight = 34;
            releasesDataGridView.Location = new Point(21, 332);
            releasesDataGridView.Name = "releasesDataGridView";
            releasesDataGridView.RowHeadersWidth = 62;
            releasesDataGridView.Size = new Size(974, 304);
            releasesDataGridView.TabIndex = 9;
            // 
            // exportButton
            // 
            exportButton.ForeColor = Color.White;
            exportButton.Location = new Point(769, 217);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(96, 33);
            exportButton.TabIndex = 15;
            exportButton.Text = "Export";
            exportButton.Click += exportButton_Click;
            // 
            // searchButton
            // 
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(280, 275);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(78, 34);
            searchButton.TabIndex = 16;
            searchButton.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(25, 279);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(239, 31);
            searchTextBox.TabIndex = 17;
            // 
            // typeLabel
            // 
            typeLabel.ForeColor = Color.White;
            typeLabel.Location = new Point(537, 39);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(100, 23);
            typeLabel.TabIndex = 18;
            typeLabel.Text = "Type";
            // 
            // typeComboBox
            // 
            typeComboBox.Items.AddRange(new object[] { ReleaseType.Single, ReleaseType.Album });
            typeComboBox.Location = new Point(643, 39);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(309, 33);
            typeComboBox.TabIndex = 19;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            typeComboBox.SelectedValueChanged += typeComboBox_SelectedValueChanged;
            // 
            // notesLabel
            // 
            notesLabel.ForeColor = Color.White;
            notesLabel.Location = new Point(537, 90);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(100, 23);
            notesLabel.TabIndex = 20;
            notesLabel.Text = "Notes";
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(643, 90);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(309, 31);
            notesTextBox.TabIndex = 21;
            // 
            // ReleasesForm
            // 
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.Desain_tanpa_judul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 648);
            Controls.Add(notesTextBox);
            Controls.Add(notesLabel);
            Controls.Add(typeComboBox);
            Controls.Add(typeLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(exportButton);
            Controls.Add(albumOrSongLabel);
            Controls.Add(releaseDateLabel);
            Controls.Add(statusLabel);
            Controls.Add(albumOrSongComboBox);
            Controls.Add(releaseDatePicker);
            Controls.Add(statusComboBox);
            Controls.Add(addReleaseButton);
            Controls.Add(updateReleaseButton);
            Controls.Add(deleteReleaseButton);
            Controls.Add(releasesDataGridView);
            DoubleBuffered = true;
            Name = "ReleasesForm";
            Load += ReleasesForm_Load;
            ((System.ComponentModel.ISupportInitialize)releasesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button exportButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label typeLabel;
        private ComboBox typeComboBox;
        private Label notesLabel;
        private TextBox notesTextBox;
    }
}

