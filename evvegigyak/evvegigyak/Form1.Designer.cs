namespace evvegigyak
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
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonCalculate = new Button();
            domainUpDown = new DomainUpDown();
            labelResults = new Label();
            labelResults2 = new Label();
            labelResults3 = new Label();
            labelResults4 = new Label();
            labelResults5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(488, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 426);
            dataGridView1.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.RosyBrown;
            buttonCalculate.Cursor = Cursors.Hand;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.Location = new Point(325, 409);
            buttonCalculate.Margin = new Padding(0);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 1;
            buttonCalculate.Text = "Ok";
            buttonCalculate.UseVisualStyleBackColor = false;
            // 
            // domainUpDown
            // 
            domainUpDown.Location = new Point(106, 411);
            domainUpDown.Name = "domainUpDown";
            domainUpDown.Size = new Size(150, 27);
            domainUpDown.TabIndex = 2;
            domainUpDown.Text = "domainUpDown1";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Location = new Point(86, 29);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(0, 20);
            labelResults.TabIndex = 3;
            // 
            // labelResults2
            // 
            labelResults2.AutoSize = true;
            labelResults2.Location = new Point(86, 64);
            labelResults2.Name = "labelResults2";
            labelResults2.Size = new Size(0, 20);
            labelResults2.TabIndex = 4;
            // 
            // labelResults3
            // 
            labelResults3.AutoSize = true;
            labelResults3.Location = new Point(86, 100);
            labelResults3.Name = "labelResults3";
            labelResults3.Size = new Size(0, 20);
            labelResults3.TabIndex = 5;
            // 
            // labelResults4
            // 
            labelResults4.AutoSize = true;
            labelResults4.Location = new Point(86, 137);
            labelResults4.Name = "labelResults4";
            labelResults4.Size = new Size(0, 20);
            labelResults4.TabIndex = 6;
            labelResults4.Click += label3_Click;
            // 
            // labelResults5
            // 
            labelResults5.AutoSize = true;
            labelResults5.Location = new Point(86, 175);
            labelResults5.Name = "labelResults5";
            labelResults5.Size = new Size(0, 20);
            labelResults5.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResults5);
            Controls.Add(labelResults4);
            Controls.Add(labelResults3);
            Controls.Add(labelResults2);
            Controls.Add(labelResults);
            Controls.Add(domainUpDown);
            Controls.Add(buttonCalculate);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonCalculate;
        private DomainUpDown domainUpDown;
        private Label labelResults;
        private Label labelResults2;
        private Label labelResults3;
        private Label labelResults4;
        private Label labelResults5;
    }
}