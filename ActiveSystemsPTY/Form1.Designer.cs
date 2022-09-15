namespace ActiveSystemsPTY
{
    partial class ActiveForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveForm));
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTag = new System.Windows.Forms.Button();
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.stsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.stsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(70, 112);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(225, 289);
            this.lstOutput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstOutput, "Display all rego plates here");
            this.lstOutput.SelectedIndexChanged += new System.EventHandler(this.lstOutput_SelectedIndexChanged);
            this.lstOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstOutput_MouseDoubleClick);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblHeader.Location = new System.Drawing.Point(147, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(624, 49);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Active Systems PTY";
            // 
            // txtInput
            // 
            this.txtInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInput.Location = new System.Drawing.Point(350, 112);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(161, 23);
            this.txtInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtInput, "Enter a rego plate here");
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(622, 168);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 39);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OPEN";
            this.toolTip1.SetToolTip(this.btnOpen, "Open text file and load data.");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(622, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.toolTip1.SetToolTip(this.btnSave, "Save data to text file.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete an existing rego plate.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(378, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.toolTip1.SetToolTip(this.btnAdd, "Add a new rego plate.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(378, 203);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 37);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT";
            this.toolTip1.SetToolTip(this.btnEdit, "Edit or update an existing rego plate.");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTag
            // 
            this.btnTag.Location = new System.Drawing.Point(378, 382);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(86, 39);
            this.btnTag.TabIndex = 3;
            this.btnTag.Text = "TAG";
            this.toolTip1.SetToolTip(this.btnTag, "Tag a specific rego plate for future investigation.");
            this.btnTag.UseVisualStyleBackColor = true;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(378, 337);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(133, 39);
            this.btnLinearSearch.TabIndex = 3;
            this.btnLinearSearch.Text = "LINEAR SEARCH";
            this.toolTip1.SetToolTip(this.btnLinearSearch, "Linear Search for a specific rego plate.");
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            this.btnLinearSearch.Click += new System.EventHandler(this.btnLinearSearch_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(378, 292);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(133, 39);
            this.btnBinarySearch.TabIndex = 3;
            this.btnBinarySearch.Text = "BINARY SEARCH";
            this.toolTip1.SetToolTip(this.btnBinarySearch, "Binary Search for a specific rego plate.");
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(622, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "EXIT";
            this.toolTip1.SetToolTip(this.btnExit, "Quit the program.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(696, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.toolTip1.SetToolTip(this.btnReset, "Click here will delete all information, are you sure?");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(60, 17);
            this.stsStatus.Text = "Feedback:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files | *.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text Files | *.txt";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStatusLabel});
            this.statusStrip2.Location = new System.Drawing.Point(0, 456);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(800, 22);
            this.statusStrip2.TabIndex = 8;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // stsStatusLabel
            // 
            this.stsStatusLabel.Name = "stsStatusLabel";
            this.stsStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.stsStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // ActiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.btnLinearSearch);
            this.Controls.Add(this.btnTag);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lstOutput);
            this.Name = "ActiveForm";
            this.Text = "ActiveForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActiveForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstOutput;
        private Label lblHeader;
        private TextBox txtInput;
        private Button btnOpen;
        private Button btnSave;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnTag;
        private Button btnLinearSearch;
        private Button btnBinarySearch;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private Button btnExit;
        private Button btnReset;
        private StatusStrip stsInfo;
        private ToolStripStatusLabel stsStatus;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolTip toolTip1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel stsStatusLabel;
    }
}