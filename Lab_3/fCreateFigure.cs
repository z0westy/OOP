namespace Lab_2
{
    // Class for creating figures (everything except the triangle)
    public partial class fCreateFigure : Form
    {
        public fCreateFigure()
        {
            InitializeComponent();
        }

        // Event handler for validating entered data
        private void btnCreateFigure_Click(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(tbFirst.Text, out temp) && int.TryParse(tbSecond.Text, out temp) &&
                int.TryParse(tbThird.Text, out temp) && int.TryParse(tbFourth.Text, out temp))
                DialogResult = DialogResult.OK;
        }
    }
}
