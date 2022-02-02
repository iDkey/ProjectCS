namespace WinFormsApp3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double result;
            double inValue = double.Parse(value.Text);
            if(convertFlag1.Checked)
            {
                result = inValue * 3.2808;
                resultOut.Text = result.ToString();
            }
            if (convertFlag2.Checked)
            {
                result = inValue * 0.3048;
                resultOut.Text = result.ToString();
            }
        }

        private void convertFlag1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void convertFlag2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}