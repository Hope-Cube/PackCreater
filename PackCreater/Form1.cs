namespace PackCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void description_check_Click(object sender, EventArgs e)
        {
            if (description_check.Checked)
            {
                description.Visible = true;
                description.Enabled = true;
                description.Focus();
            }
            else
            {
                description.Visible = false;
                description.Enabled = false;
            }
        }

        private void folder_select_Click(object sender, EventArgs e)
        {
            if(fBD.ShowDialog() == DialogResult.OK)
            {
                pack_name.Text = fBD.SelectedPath;
            }
        }
    }
}