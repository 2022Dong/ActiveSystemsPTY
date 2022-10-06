using System.Xml.Linq;

namespace ActiveSystemsPTY
{
    public partial class ActiveForm : Form
    {
        public ActiveForm()
        {
            InitializeComponent();
            stsStatusLabel.Text = "Feedback:";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
        }

        // Creat list data structure.
        List<string> myList = new List<string>();

        // Update teh listbox form the list.
        private void UpdataListBox()
        {
            myList.Sort();
            lstOutput.Items.Clear();
            for (int i = 0; i < myList.Count; i++)
            {
                lstOutput.Items.Add(myList[i]);
            }
        }

        // Edit item if one is selected.
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.White;
            if (!string.IsNullOrEmpty(txtInput.Text) && !myList.Contains(txtInput.Text) && lstOutput.SelectedIndex != -1)
            {
                stsStatusLabel.Text = "Feedback:";
                stsStatusLabel.BackColor = Color.White;
                myList[lstOutput.SelectedIndex] = txtInput.Text;
                UpdataListBox();              
                txtInput.Clear();
                txtInput.Focus();
            }
            else if (string.IsNullOrEmpty(txtInput.Text))
            {
                txtInput.BackColor = Color.Red;
                stsStatusLabel.Text = "Please enter a rego plate.";
                stsStatusLabel.BackColor = Color.Red;
            }
            else if (lstOutput.SelectedIndex == -1)
            {
                txtInput.BackColor = Color.Red;
                stsStatusLabel.Text = "Please select a rego plate.";
                stsStatusLabel.BackColor = Color.Red;
            }

            else
            {
                txtInput.BackColor = Color.Red;
                stsStatusLabel.Text = "The rego plate have already existed.";
                stsStatusLabel.BackColor = Color.Red;
            }
        }

        // Delete item if one is selected.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstOutput.SelectedIndex != -1)
                myList.RemoveAt(lstOutput.SelectedIndex);
            UpdataListBox();
            txtInput.Clear();
            txtInput.Focus();
        }

         // Clear all items in ListBox.
        private void btnReset_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            myList.Clear();
            txtInput.Clear();
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
            if (!string.IsNullOrEmpty(txtInput.Text) && !myList.Contains(txtInput.Text))
            {
                stsStatusLabel.Text = "Feedback:";
                stsStatusLabel.BackColor = Color.White;
                myList.Add(txtInput.Text);
                UpdataListBox();
                txtInput.Clear();
                txtInput.Focus();
            }
            else if (string.IsNullOrEmpty(txtInput.Text))
            {
                txtInput.BackColor = Color.Red;
                stsStatusLabel.Text = "Please enter a rego plate.";
                stsStatusLabel.BackColor = Color.Red;
            }
            else
            {
                txtInput.BackColor = Color.Red;
                stsStatusLabel.Text = "The rego plate have already existed.";
                stsStatusLabel.BackColor = Color.Red;
            }
        }


        // Open file
        private void btnOpen_Click(object sender, EventArgs e)

        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myList.Clear();
                string file = openFileDialog1.FileName;
                string line;
                using (StreamReader sr = new StreamReader(file))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        myList.Add(line);
                    }
                }
                UpdataListBox();
            }
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)

        {

            int x = myList.BinarySearch(txtInput.Text);
            if (x < 0 && !string.IsNullOrEmpty(txtInput.Text))
            {
                stsStatusLabel.Text = "Not found!";
                stsStatusLabel.BackColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(txtInput.Text))
            {
                stsStatusLabel.Text = "Please enter an item.";
                stsStatusLabel.BackColor = Color.Red;
            }
            else
            {
                stsStatusLabel.Text = "Item exists!";
                stsStatusLabel.BackColor = Color.Green;
            }
        }

        // Save file
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string file = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(file))
                {
                    foreach(string plate in myList)
                    {
                        sw.WriteLine(plate);
                    }
                }
            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInput.Text = lstOutput.GetItemText(lstOutput.SelectedItem);
        }

        private void lstOutput_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            if (lstOutput.SelectedIndex >= 0)
                myList.RemoveAt(lstOutput.SelectedIndex);
            MessageBox.Show("Item to be delete.");
            UpdataListBox();
            txtInput.Clear();
            txtInput.Focus();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {        
            if (lstOutput.SelectedIndex < 0) return;
            
            int idx = lstOutput.SelectedIndex;

            if (myList[idx][0] == 'z')
            {
                // Untag.
                myList[idx] = myList[idx].Substring(1);
            }
            else
            {
                // Tag.
                myList[idx] = 'z' + myList[idx];
            }

            UpdataListBox();
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < myList.Count(); index1++)
            {
                if (txtInput.Text == myList[index1])
                {
                    stsStatusLabel.Text = "Item exists!";
                    stsStatusLabel.BackColor = Color.Green;
                }
                else if (myList[index1] != txtInput.Text && !string.IsNullOrEmpty(txtInput.Text))
                {
                    stsStatusLabel.Text = "Not found!";
                    stsStatusLabel.BackColor = Color.Red;
                }
                else
                {
                    stsStatusLabel.Text = "Please enter an item.";
                    stsStatusLabel.BackColor = Color.Red;
                }
            }
        }

        private void ActiveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string file = "";
            for (int i = 0; i < 100; i++)
            {
                file = "demo_" + i.ToString() + ".txt";
                if (!File.Exists(file)) break;
                if (i == 99) return;
            }
            
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (string plate in myList)
                {
                    sw.WriteLine(plate);
                }
            }
        }
    }
}