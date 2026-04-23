namespace Lab_2
{
    partial class fCreateTriangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbFirst = new TextBox();
            tbThird = new TextBox();
            tbSecond = new TextBox();
            tbFourth = new TextBox();
            tbFifth = new TextBox();
            tbSixth = new TextBox();
            lblFirst = new Label();
            lblSecond = new Label();
            lblThird = new Label();
            lblFourth = new Label();
            lblFifth = new Label();
            lblSixth = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // tbFirst
            // 
            tbFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFirst.Location = new Point(31, 48);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(155, 34);
            tbFirst.TabIndex = 0;
            // 
            // tbThird
            // 
            tbThird.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbThird.Location = new Point(31, 131);
            tbThird.Name = "tbThird";
            tbThird.Size = new Size(155, 34);
            tbThird.TabIndex = 2;
            // 
            // tbSecond
            // 
            tbSecond.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSecond.Location = new Point(222, 48);
            tbSecond.Name = "tbSecond";
            tbSecond.Size = new Size(155, 34);
            tbSecond.TabIndex = 1;
            // 
            // tbFourth
            // 
            tbFourth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFourth.Location = new Point(222, 131);
            tbFourth.Name = "tbFourth";
            tbFourth.Size = new Size(155, 34);
            tbFourth.TabIndex = 3;
            // 
            // tbFifth
            // 
            tbFifth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFifth.Location = new Point(31, 214);
            tbFifth.Name = "tbFifth";
            tbFifth.Size = new Size(155, 34);
            tbFifth.TabIndex = 4;
            // 
            // tbSixth
            // 
            tbSixth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSixth.Location = new Point(222, 214);
            tbSixth.Name = "tbSixth";
            tbSixth.Size = new Size(155, 34);
            tbSixth.TabIndex = 5;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFirst.Location = new Point(31, 17);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(32, 28);
            lblFirst.TabIndex = 6;
            lblFirst.Text = "x1";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSecond.Location = new Point(222, 17);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(33, 28);
            lblSecond.TabIndex = 7;
            lblSecond.Text = "y1";
            // 
            // lblThird
            // 
            lblThird.AutoSize = true;
            lblThird.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblThird.Location = new Point(31, 100);
            lblThird.Name = "lblThird";
            lblThird.Size = new Size(32, 28);
            lblThird.TabIndex = 8;
            lblThird.Text = "x2";
            // 
            // lblFourth
            // 
            lblFourth.AutoSize = true;
            lblFourth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFourth.Location = new Point(222, 100);
            lblFourth.Name = "lblFourth";
            lblFourth.Size = new Size(33, 28);
            lblFourth.TabIndex = 9;
            lblFourth.Text = "y2";
            // 
            // lblFifth
            // 
            lblFifth.AutoSize = true;
            lblFifth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFifth.Location = new Point(31, 183);
            lblFifth.Name = "lblFifth";
            lblFifth.Size = new Size(32, 28);
            lblFifth.TabIndex = 10;
            lblFifth.Text = "x3";
            // 
            // lblSixth
            // 
            lblSixth.AutoSize = true;
            lblSixth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSixth.Location = new Point(222, 183);
            lblSixth.Name = "lblSixth";
            lblSixth.Size = new Size(33, 28);
            lblSixth.TabIndex = 11;
            lblSixth.Text = "y3";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreate.Location = new Point(111, 284);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(183, 43);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // fCreateTriangle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 348);
            Controls.Add(btnCreate);
            Controls.Add(lblSixth);
            Controls.Add(lblFifth);
            Controls.Add(lblFourth);
            Controls.Add(lblThird);
            Controls.Add(lblSecond);
            Controls.Add(lblFirst);
            Controls.Add(tbSixth);
            Controls.Add(tbFifth);
            Controls.Add(tbFourth);
            Controls.Add(tbSecond);
            Controls.Add(tbThird);
            Controls.Add(tbFirst);
            Name = "fCreateTriangle";
            Text = "Создание фигуры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFirst;
        private Label lblSecond;
        private Label lblThird;
        private Label lblFourth;
        private Label lblFifth;
        private Label lblSixth;
        private Button btnCreate;
        public TextBox tbFirst;
        public TextBox tbThird;
        public TextBox tbSecond;
        public TextBox tbFourth;
        public TextBox tbFifth;
        public TextBox tbSixth;
    }
}