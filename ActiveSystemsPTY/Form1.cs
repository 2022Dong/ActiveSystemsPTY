namespace ActiveSystemsPTY
{
    public partial class ActiveForm : Form
    {
        public ActiveForm()
        {
            InitializeComponent();
        }

        // Creat list data structure.
        List<string> myList = new List<string>();

        // Update teh listbox form the list.
        private void UpdataListBox()
        {
            myList.Sort();
            lstOutput.Items.Clear();
            for(int i = 0; i < myList.Count; i++)
            {
                lstOutput.Items.Add(myList[i]);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // Edit item if one is selected.
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.White;            
            if (txtInput.Text.Length != 0)
            {
                if (!myList.Contains(txtInput.Text))
                {
                    myList[lstOutput.SelectedIndex] = txtInput.Text;
                    UpdataListBox();
                    txtInput.Clear();
                }
            }
            else if (txtInput.Text.Length == 0)
            {
                txtInput.BackColor = Color.Red;
            }
            else
            {
                txtInput.BackColor = Color.Red;
            }

        }

        // Delete item if one is selected.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstOutput.SelectedIndex != -1)
                myList.RemoveAt(lstOutput.SelectedIndex);
            UpdataListBox();
        }

        private void ActiveForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        // Clear all items in ListBox.
        private void btnReset_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        // Exit applicateion
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Add item to myList.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.White;
            if (!myList.Contains(txtInput.Text))
            {
                myList.Add(txtInput.Text);
                UpdataListBox();
                txtInput.Clear();
            }
            else
            {
                txtInput.BackColor = Color.Red;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
        }
    }
}