namespace Lab_2
{
    // Class for creating figures (everything except the triangle)
    public partial class fCreateFigure : Form
    {
        public TextBox[] textBoxes;

        // Function for getting int values from all textBoxes
        public int[] getTextBoxesValues()
        {
            int[] res = new int[textBoxes.Length];

            for (int i = 0; i < textBoxes.Length; i++)
            {
                int.TryParse(textBoxes[i].Text, out res[i]);
            }

            return res;
        }

        // Form constructor that creates a given number of text boxes
        public fCreateFigure(int num, string[] placeholders = null)
        {
            InitializeComponent();

            int x = 30; 
            int y = 30;

            textBoxes = new TextBox[num];
            for (int i = 0; i < num; i++)
            {
                textBoxes[i] = new TextBox();
                if (placeholders != null) { textBoxes[i].PlaceholderText = placeholders[i]; }
                textBoxes[i].Size = new Size(125, 25);
                textBoxes[i].Font = new Font(textBoxes[i].Font.FontFamily.Name, 12, 
                    textBoxes[i].Font.Style);
                textBoxes[i].Location = new Point(x, y);
                y += 45;

                this.Controls.Add(textBoxes[i]);
            }

            int margin = textBoxes[0].Location.X - (btnCreateFigure.Width - textBoxes[0].Width) / 2;
            btnCreateFigure.Location = new Point(margin, y + 15);

            this.ClientSize = new Size(btnCreateFigure.Location.X + btnCreateFigure.Width + margin, 
                btnCreateFigure.Location.Y + btnCreateFigure.Height + 15);
        }

        // Event handler for validating entered data
        private void btnCreateFigure_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (!int.TryParse(textBoxes[i].Text, out temp))
                {
                    DialogResult = DialogResult.No;
                    return;
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
