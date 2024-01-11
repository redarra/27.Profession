namespace _27.Profession
{
    public partial class Form1 : Form
    {
        String gender = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || gender == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Not all the fields are completed.");
            }
            else
            {
                label4.Text = ("Welcome " + textBox1.Text + ", you are a " + gender
                + ", your profession is " + comboBox1.Text);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { gender = radioButton1.Text; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { gender = radioButton2.Text; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { gender = radioButton3.Text; }
        }
    }
}