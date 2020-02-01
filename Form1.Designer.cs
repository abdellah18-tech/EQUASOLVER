namespace GiraffeApp
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
            this.title = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.rDomainButton = new System.Windows.Forms.RadioButton();
            this.cDomainButton = new System.Windows.Forms.RadioButton();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CheckSolutionButton = new System.Windows.Forms.Button();
            this.SolutionOneLabel = new System.Windows.Forms.Label();
            this.SolutionTwoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(116, 38);
            this.title.TabIndex = 0;
            this.title.Text = "EquaSolver";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.IndianRed;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(524, 278);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 48);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rDomainButton
            // 
            this.rDomainButton.AutoSize = true;
            this.rDomainButton.BackColor = System.Drawing.Color.Chocolate;
            this.rDomainButton.FlatAppearance.BorderSize = 0;
            this.rDomainButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rDomainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rDomainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rDomainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rDomainButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDomainButton.Location = new System.Drawing.Point(378, 22);
            this.rDomainButton.Name = "rDomainButton";
            this.rDomainButton.Size = new System.Drawing.Size(244, 25);
            this.rDomainButton.TabIndex = 2;
            this.rDomainButton.TabStop = true;
            this.rDomainButton.Text = "Solving in IR domain";
            this.rDomainButton.UseVisualStyleBackColor = false;
            // 
            // cDomainButton
            // 
            this.cDomainButton.AutoSize = true;
            this.cDomainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cDomainButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDomainButton.Location = new System.Drawing.Point(135, 18);
            this.cDomainButton.Name = "cDomainButton";
            this.cDomainButton.Size = new System.Drawing.Size(239, 25);
            this.cDomainButton.TabIndex = 3;
            this.cDomainButton.TabStop = true;
            this.cDomainButton.Text = "Solving in C domain";
            this.cDomainButton.UseVisualStyleBackColor = true;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(134, 89);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 21);
            this.textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(149, 116);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 21);
            this.textBoxB.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(180, 143);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 21);
            this.textBoxC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(98, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(113, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(144, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "C:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(237, 79);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "Developed by Zakaria FARHATI, for any issue or error:\nwww.github.com/farhatizakar" +
    "ia";
            // 
            // CheckSolutionButton
            // 
            this.CheckSolutionButton.BackColor = System.Drawing.Color.LightBlue;
            this.CheckSolutionButton.FlatAppearance.BorderSize = 0;
            this.CheckSolutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckSolutionButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSolutionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckSolutionButton.Location = new System.Drawing.Point(207, 170);
            this.CheckSolutionButton.Name = "CheckSolutionButton";
            this.CheckSolutionButton.Size = new System.Drawing.Size(99, 48);
            this.CheckSolutionButton.TabIndex = 11;
            this.CheckSolutionButton.Text = "Check for solutions";
            this.CheckSolutionButton.UseVisualStyleBackColor = false;
            this.CheckSolutionButton.Click += new System.EventHandler(this.CheckSolutionButton_Click);
            // 
            // SolutionOneLabel
            // 
            this.SolutionOneLabel.AutoSize = true;
            this.SolutionOneLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionOneLabel.Location = new System.Drawing.Point(447, 101);
            this.SolutionOneLabel.Name = "SolutionOneLabel";
            this.SolutionOneLabel.Size = new System.Drawing.Size(92, 23);
            this.SolutionOneLabel.TabIndex = 12;
            this.SolutionOneLabel.Text = "1st solution";
            // 
            // SolutionTwoLabel
            // 
            this.SolutionTwoLabel.AutoSize = true;
            this.SolutionTwoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionTwoLabel.Location = new System.Drawing.Point(447, 126);
            this.SolutionTwoLabel.Name = "SolutionTwoLabel";
            this.SolutionTwoLabel.Size = new System.Drawing.Size(98, 23);
            this.SolutionTwoLabel.TabIndex = 13;
            this.SolutionTwoLabel.Text = "2nd solution";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(635, 338);
            this.Controls.Add(this.SolutionTwoLabel);
            this.Controls.Add(this.SolutionOneLabel);
            this.Controls.Add(this.CheckSolutionButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.cDomainButton);
            this.Controls.Add(this.rDomainButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton rDomainButton;
        private System.Windows.Forms.RadioButton cDomainButton;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CheckSolutionButton;
        private System.Windows.Forms.Label SolutionOneLabel;
        private System.Windows.Forms.Label SolutionTwoLabel;
    }
}

