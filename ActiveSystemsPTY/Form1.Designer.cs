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
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.stsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(79, 112);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(214, 304);
            this.lstOutput.TabIndex = 0;
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
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInput.Location = new System.Drawing.Point(350, 112);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(161, 23);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(622, 168);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 39);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(622, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.btnTag.UseVisualStyleBackColor = true;
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(378, 337);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(133, 39);
            this.btnLinearSearch.TabIndex = 3;
            this.btnLinearSearch.Text = "LINEAR SEARCH";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(378, 292);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(133, 39);
            this.btnBinarySearch.TabIndex = 3;
            this.btnBinarySearch.Text = "BINARY SEARCH";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
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
            this.btnExit.Location = new System.Drawing.Point(622, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(713, 393);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // stsInfo
            // 
            this.stsInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStatus});
            this.stsInfo.Location = new System.Drawing.Point(0, 428);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.Size = new System.Drawing.Size(108, 22);
            this.stsInfo.TabIndex = 8;
            this.stsInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stsInfo_ItemClicked);
            // 
            // stsStatus
            // 
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(60, 17);
            this.stsStatus.Text = "Feedback:";
            this.stsStatus.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // ActiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stsInfo);
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
            this.Load += new System.EventHandler(this.ActiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
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
    }
}