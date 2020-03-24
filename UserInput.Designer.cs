namespace TicTacToeGame
{
    partial class UserInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInput));
            this.p1namelabel = new System.Windows.Forms.Label();
            this.p2namelabel = new System.Windows.Forms.Label();
            this.P1nameTextBox = new System.Windows.Forms.TextBox();
            this.p2NameTextBox = new System.Windows.Forms.TextBox();
            this.UserInputSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p1namelabel
            // 
            this.p1namelabel.AutoSize = true;
            this.p1namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1namelabel.Location = new System.Drawing.Point(24, 24);
            this.p1namelabel.Name = "p1namelabel";
            this.p1namelabel.Size = new System.Drawing.Size(125, 18);
            this.p1namelabel.TabIndex = 0;
            this.p1namelabel.Text = "Player One Name";
            // 
            // p2namelabel
            // 
            this.p2namelabel.AutoSize = true;
            this.p2namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2namelabel.Location = new System.Drawing.Point(23, 64);
            this.p2namelabel.Name = "p2namelabel";
            this.p2namelabel.Size = new System.Drawing.Size(126, 18);
            this.p2namelabel.TabIndex = 1;
            this.p2namelabel.Text = "Player Two Name";
            // 
            // P1nameTextBox
            // 
            this.P1nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1nameTextBox.Location = new System.Drawing.Point(155, 20);
            this.P1nameTextBox.Name = "P1nameTextBox";
            this.P1nameTextBox.Size = new System.Drawing.Size(203, 26);
            this.P1nameTextBox.TabIndex = 2;
            // 
            // p2NameTextBox
            // 
            this.p2NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2NameTextBox.Location = new System.Drawing.Point(155, 60);
            this.p2NameTextBox.Name = "p2NameTextBox";
            this.p2NameTextBox.Size = new System.Drawing.Size(203, 26);
            this.p2NameTextBox.TabIndex = 3;
            this.p2NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2NameTextBox_KeyPress);
            // 
            // UserInputSubmitButton
            // 
            this.UserInputSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputSubmitButton.Location = new System.Drawing.Point(274, 103);
            this.UserInputSubmitButton.Name = "UserInputSubmitButton";
            this.UserInputSubmitButton.Size = new System.Drawing.Size(75, 28);
            this.UserInputSubmitButton.TabIndex = 4;
            this.UserInputSubmitButton.Text = "Play";
            this.UserInputSubmitButton.UseVisualStyleBackColor = true;
            this.UserInputSubmitButton.Click += new System.EventHandler(this.UserInputSubmitButton_Click);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 147);
            this.Controls.Add(this.UserInputSubmitButton);
            this.Controls.Add(this.p2NameTextBox);
            this.Controls.Add(this.P1nameTextBox);
            this.Controls.Add(this.p2namelabel);
            this.Controls.Add(this.p1namelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 186);
            this.MinimumSize = new System.Drawing.Size(399, 186);
            this.Name = "UserInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Input";
            this.Load += new System.EventHandler(this.UserInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1namelabel;
        private System.Windows.Forms.Label p2namelabel;
        private System.Windows.Forms.TextBox P1nameTextBox;
        private System.Windows.Forms.TextBox p2NameTextBox;
        private System.Windows.Forms.Button UserInputSubmitButton;
    }
}