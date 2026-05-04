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
            btnCreateFigure = new Button();
            SuspendLayout();
            // 
            // btnCreateFigure
            // 
            btnCreateFigure.Location = new Point(12, 61);
            btnCreateFigure.Name = "btnCreateFigure";
            btnCreateFigure.Size = new Size(156, 37);
            btnCreateFigure.TabIndex = 8;
            btnCreateFigure.Text = "Создать";
            btnCreateFigure.UseVisualStyleBackColor = true;
            btnCreateFigure.Click += btnCreateFigure_Click;
            // 
            // fCreateFigure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 151);
            Controls.Add(btnCreateFigure);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fCreateFigure";
            Text = "Создание фигуры";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateFigure;
    }
}