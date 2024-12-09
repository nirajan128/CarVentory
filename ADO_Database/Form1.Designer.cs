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
            this.getDataButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDataButton.Location = new System.Drawing.Point(33, 59);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(148, 23);
            this.getDataButton.TabIndex = 1;
            this.getDataButton.Text = "Get Car Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(33, 92);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(509, 173);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

