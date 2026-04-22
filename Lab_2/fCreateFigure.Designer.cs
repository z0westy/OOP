namespace Lab_2
{
    partial class fCreateFigure
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
            lblFirst = new Label();
            lblSecond = new Label();
            lblThird = new Label();
            label1 = new Label();
            btnCreateFigure = new Button();
            tbFirst = new TextBox();
            tbSecond = new TextBox();
            tbThird = new TextBox();
            tbFourth = new TextBox();
            SuspendLayout();
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFirst.Location = new Point(31, 17);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(36, 28);
            lblFirst.TabIndex = 1;
            lblFirst.Text = "x1:";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSecond.Location = new Point(222, 17);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(33, 28);
            lblSecond.TabIndex = 3;
            lblSecond.Text = "y1";
            // 
            // lblThird
            // 
            lblThird.AutoSize = true;
            lblThird.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblThird.Location = new Point(31, 100);
            lblThird.Name = "lblThird";
            lblThird.Size = new Size(36, 28);
            lblThird.TabIndex = 5;
            lblThird.Text = "x2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(222, 100);
            label1.Name = "label1";
            label1.Size = new Size(37, 28);
            label1.TabIndex = 7;
            label1.Text = "y2:";
            // 
            // btnCreateFigure
            // 
            btnCreateFigure.Location = new Point(126, 199);
            btnCreateFigure.Name = "btnCreateFigure";
            btnCreateFigure.Size = new Size(156, 37);
            btnCreateFigure.TabIndex = 8;
            btnCreateFigure.Text = "Создать";
            btnCreateFigure.UseVisualStyleBackColor = true;
            btnCreateFigure.Click += btnCreateFigure_Click;
            // 
            // tbFirst
            // 
            tbFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFirst.Location = new Point(31, 48);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(155, 34);
            tbFirst.TabIndex = 13;
            // 
            // tbSecond
            // 
            tbSecond.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSecond.Location = new Point(222, 48);
            tbSecond.Name = "tbSecond";
            tbSecond.Size = new Size(155, 34);
            tbSecond.TabIndex = 14;
            // 
            // tbThird
            // 
            tbThird.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbThird.Location = new Point(31, 131);
            tbThird.Name = "tbThird";
            tbThird.Size = new Size(155, 34);
            tbThird.TabIndex = 15;
            // 
            // tbFourth
            // 
            tbFourth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFourth.Location = new Point(222, 131);
            tbFourth.Name = "tbFourth";
            tbFourth.Size = new Size(155, 34);
            tbFourth.TabIndex = 16;
            // 
            // fCreateFigure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 253);
            Controls.Add(tbFourth);
            Controls.Add(tbThird);
            Controls.Add(tbSecond);
            Controls.Add(tbFirst);
            Controls.Add(btnCreateFigure);
            Controls.Add(label1);
            Controls.Add(lblThird);
            Controls.Add(lblSecond);
            Controls.Add(lblFirst);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fCreateFigure";
            Text = "Создание фигуры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFirst;
        private Label lblSecond;
        private Label lblThird;
        private Label label1;
        private Button btnCreateFigure;
        public TextBox tbFirst;
        public TextBox tbSecond;
        public TextBox tbThird;
        public TextBox tbFourth;
    }
}