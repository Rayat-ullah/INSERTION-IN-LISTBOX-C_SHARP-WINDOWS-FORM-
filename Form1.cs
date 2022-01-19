namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void countbtn_Click(object sender, EventArgs e)
        {
            int count=listbox1.Items.Count;

            MessageBox.Show("items are:" + count.ToString());
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            listbox1.Sorted=true;
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            listbox1.Items.Remove(listbox1.SelectedItem);
        }

        private void clearlistbtn_Click(object sender, EventArgs e)
        {
            listbox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}