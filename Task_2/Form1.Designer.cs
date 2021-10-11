using  System.Windows.Forms;

namespace Task_2
{
     
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private Button btn1;
        private TextBox side;
        private Label square;
        private Label rhombus;
        private Label circle;
        private Label squarePer;
        private Label rhombusPer;
        private Label circlePer;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "Form1";

            btn1 = new Button();
            btn1.Name = "btn1";
            btn1.Text = "Calculate perimeter";
            btn1.Location = new System.Drawing.Point(200, 20);
            btn1.Size = new System.Drawing.Size(200, 30);

            side = new TextBox();
            side.Name = "side";
            side.Text = "Enter side";
            side.Location = new System.Drawing.Point(20, 20);
            side.Size = new System.Drawing.Size(100, 20);

            square = new Label();
            square.Name = "square";
            square.Text = "Square";
            square.Location = new System.Drawing.Point(100, 100);
            square.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(square);

            rhombus = new Label();
            rhombus.Name = "rhombus";
            rhombus.Text = "Rhombus";
            rhombus.Location = new System.Drawing.Point(100, 200);
            rhombus.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(rhombus);

            circle = new Label();
            circle.Name = "circle";
            circle.Text = "Circle";
            circle.Location = new System.Drawing.Point(100, 300);
            circle.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(circle);

            squarePer = new Label();
            squarePer.Name = "squarePer";
            squarePer.Text = "SquarePer";
            squarePer.Location = new System.Drawing.Point(200, 100);
            squarePer.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(squarePer);

            rhombusPer = new Label();
            rhombusPer.Name = "rhombusPer";
            rhombusPer.Text = "RhombusPer";
            rhombusPer.Location = new System.Drawing.Point(200, 200);
            rhombusPer.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(rhombusPer);

            circlePer = new Label();
            circlePer.Name = "circlePer";
            circlePer.Text = "CirclePer";
            circlePer.Location = new System.Drawing.Point(200, 300);
            circlePer.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(circlePer);


            this.Controls.Add(btn1);
            this.Controls.Add(side);
        }

       

        #endregion
    }
}

