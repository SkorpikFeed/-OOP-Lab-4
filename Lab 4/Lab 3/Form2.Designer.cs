namespace Lab_3
{
    partial class Form2
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
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(44, 171);
            button3.Name = "button3";
            button3.Size = new Size(196, 60);
            button3.TabIndex = 4;
            button3.Text = "Журнал";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(569, 171);
            button5.Name = "button5";
            button5.Size = new Size(196, 60);
            button5.TabIndex = 6;
            button5.Text = "Газета";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(306, 171);
            button1.Name = "button1";
            button1.Size = new Size(196, 60);
            button1.TabIndex = 7;
            button1.Text = "Випадковий вибір";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button3);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button5;
        private Button button1;
    }
}