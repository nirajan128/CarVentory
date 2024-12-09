namespace ADO_Database
{
    partial class MainForm
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
            this.infolable = new System.Windows.Forms.Label();
            this.getDataButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.statusLable = new System.Windows.Forms.Label();
            this.vehicleTextBox = new System.Windows.Forms.TextBox();
            this.mileAgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infolable
            // 
            this.infolable.AutoSize = true;
            this.infolable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolable.Location = new System.Drawing.Point(29, 18);
            this.infolable.Name = "infolable";
            this.infolable.Size = new System.Drawing.Size(576, 20);
            this.infolable.TabIndex = 0;
            this.infolable.Text = "Requirement: Current Version of SQL EXPRESS on yout local machine";
            this.infolable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infolable.Click += new System.EventHandler(this.label1_Click);
            // 
            // getDataButton
            // 
            this.getDataButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDataButton.Location = new System.Drawing.Point(33, 59);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(148, 23);
            this.getDataButton.TabIndex = 1;
            this.getDataButton.Text = "Get Car Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(33, 92);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(381, 173);
            this.resultListBox.TabIndex = 2;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // statusLable
            // 
            this.statusLable.AutoSize = true;
            this.statusLable.Location = new System.Drawing.Point(30, 281);
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(0, 13);
            this.statusLable.TabIndex = 3;
            // 
            // vehicleTextBox
            // 
            this.vehicleTextBox.Location = new System.Drawing.Point(554, 92);
            this.vehicleTextBox.Name = "vehicleTextBox";
            this.vehicleTextBox.ReadOnly = true;
            this.vehicleTextBox.Size = new System.Drawing.Size(136, 20);
            this.vehicleTextBox.TabIndex = 4;
            // 
            // mileAgeTextBox
            // 
            this.mileAgeTextBox.Location = new System.Drawing.Point(554, 136);
            this.mileAgeTextBox.Name = "mileAgeTextBox";
            this.mileAgeTextBox.ReadOnly = true;
            this.mileAgeTextBox.Size = new System.Drawing.Size(136, 20);
            this.mileAgeTextBox.TabIndex = 5;
            this.mileAgeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected Vehicle";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Average Milage";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // addCar
            // 
            this.addCar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar.Location = new System.Drawing.Point(450, 196);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(148, 23);
            this.addCar.TabIndex = 8;
            this.addCar.Text = "Add Car";
            this.addCar.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mileAgeTextBox);
            this.Controls.Add(this.vehicleTextBox);
            this.Controls.Add(this.statusLable);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.infolable);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infolable;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label statusLable;
        private System.Windows.Forms.TextBox vehicleTextBox;
        private System.Windows.Forms.TextBox mileAgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCar;
    }
}

