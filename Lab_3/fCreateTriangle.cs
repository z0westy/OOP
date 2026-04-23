namespace Lab_2
{
    // Class for modal form with creating triangle
    public partial class fCreateTriangle : Form
    {
        public fCreateTriangle()
        {
            InitializeComponent();
        }

        // Event handler for validating entered data
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(tbFirst.Text, out temp) && int.TryParse(tbSecond.Text, out temp) &&
                int.TryParse(tbThird.Text, out temp) && int.TryParse(tbFourth.Text, out temp) &&
                int.TryParse(tbFifth.Text, out temp) && int.TryParse(tbSixth.Text, out temp))
                DialogResult = DialogResult.OK;
        }
    }
}
