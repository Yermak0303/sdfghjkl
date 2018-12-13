using System;
using System.Windows.Forms;


namespace CS_ListView
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item1;
            item1 = listView1.Items.Add(txtStudentID.Text);
            item1.SubItems.Add(txtFirstname.Text);
            item1.SubItems.Add(txtSurname.Text);
            item1.SubItems.Add(cmbNationalscale.Text);
            if (int.Parse(mtbGraduatepoint.Text) <= 100)
            {
                item1.SubItems.Add(mtbGraduatepoint.Text);
            }
            else
            {
                MessageBox.Show("Error");
            }
            item1.SubItems.Add(cmbScale.Text);
            item1.SubItems.Add(cmbCourse.Text);
            item1.SubItems.Add(cmbYear.Text);

            //txtStudentID.Text = "";
            //txtFirstname.Text = "";
            //txtSurname.Text = "";
            //cmbNationalscale.Text = "";
            //mtbGraduatepoint.Text = "";
            //cmbScale.Text = "";
            //cmbCourse.Text = "";
            //cmbYear.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNationalscale.Items.Add("Незадовільно");
            cmbNationalscale.Items.Add("Задовільно");
            cmbNationalscale.Items.Add("Добре");
            cmbNationalscale.Items.Add("Відмінно");


            cmbScale.Items.Add("A");
            cmbScale.Items.Add("B");
            cmbScale.Items.Add("C");
            cmbScale.Items.Add("D");
            cmbScale.Items.Add("E");
            cmbScale.Items.Add("F");
            cmbScale.Items.Add("FX");


            cmbCourse.Items.Add("Computer Sceense");
            cmbCourse.Items.Add("Games Development");
            cmbCourse.Items.Add("Match");
            cmbCourse.Items.Add("OBD");
            cmbCourse.Items.Add("lOGIC");
            cmbCourse.Items.Add("Business Studies");
            cmbCourse.Items.Add("Phisics");
            cmbCourse.Items.Add("TEMK");
            cmbCourse.Items.Add("Auto Cad");


            cmbYear.Items.Add("First");
            cmbYear.Items.Add("second");
            cmbYear.Items.Add("Third");
            cmbYear.Items.Add("Fourth");
            cmbYear.Items.Add("Fifth");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                label9.Text = " Item" + listView1.SelectedIndices[0] + " Was clicked.";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "System Down", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes) { Application.Exit(); }
        }

        private void btnRemove__Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count > 0)
            {
                ListViewItem item1;
                item1 = listView1.SelectedItems[0];
                item1.Remove();
                label9.Text = "";

            }
        }


        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbScale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbNationalscale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbGraduatepoint_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstname.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                //txtFirstname.Text.Remove(txtFirstname.Text.Length - 1);
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtStudentID.Text, "^[0-9]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                //txtSurname.Text.Remove(txtSurname.Text.Length - 1);
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSurname.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                //txtSurname.Text.Remove(txtSurname.Text.Length - 1);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtStudentID.Text = String.Empty;
            //txtFirstname.Text = String.Empty;
            //txtSurname.Text = String.Empty;
            //cmbNationalscale.Text = String.Empty;
            //mtbGraduatepoint.Text = String.Empty;
            //cmbScale.Text = String.Empty;
            //cmbCourse.Text = String.Empty;
            //cmbYear.Text = String.Empty;

            txtStudentID.Clear();
            txtFirstname.Clear();
            txtSurname.Clear();
            mtbGraduatepoint.Clear();
        }

        
    }
}
