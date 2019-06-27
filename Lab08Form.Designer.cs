namespace COMP123_S2019_Lab08
{
    partial class Lab08Form
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
            this.Lab08Label = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab08Label
            // 
            this.Lab08Label.AutoSize = true;
            this.Lab08Label.Location = new System.Drawing.Point(0, 0);
            this.Lab08Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lab08Label.Name = "Lab08Label";
            this.Lab08Label.Size = new System.Drawing.Size(90, 37);
            this.Lab08Label.TabIndex = 0;
            this.Lab08Label.Text = "Lab08";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.IDTextBox);
            this.InfoGroupBox.Controls.Add(this.IDLabel);
            this.InfoGroupBox.Controls.Add(this.AgeTextBox);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.AgeLabel);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGroupBox.Location = new System.Drawing.Point(12, 40);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(600, 326);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubmitButton.Location = new System.Drawing.Point(480, 382);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(132, 47);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Location = new System.Drawing.Point(17, 382);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(452, 47);
            this.OutputLabel.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(7, 87);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(175, 43);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Enter Name:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(7, 145);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(175, 43);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Enter Age:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(188, 145);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(397, 43);
            this.AgeTextBox.TabIndex = 7;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(6, 31);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(176, 43);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID#:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(188, 87);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(397, 43);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(188, 31);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(397, 43);
            this.IDTextBox.TabIndex = 9;
            // 
            // Lab08Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.Lab08Label);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "Lab08Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab08";
            this.Load += new System.EventHandler(this.Lab08Form_Load);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab08Label;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

