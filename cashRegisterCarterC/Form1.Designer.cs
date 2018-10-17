namespace cashRegisterCarterC
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.numBurgers = new System.Windows.Forms.TextBox();
            this.numFries = new System.Windows.Forms.TextBox();
            this.numDrinks = new System.Windows.Forms.TextBox();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderText = new System.Windows.Forms.TextBox();
            this.calcChange = new System.Windows.Forms.Button();
            this.changelabel = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.newbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Red;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(802, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Burgies Ferda";
            // 
            // numBurgers
            // 
            this.numBurgers.Location = new System.Drawing.Point(104, 64);
            this.numBurgers.Name = "numBurgers";
            this.numBurgers.Size = new System.Drawing.Size(100, 20);
            this.numBurgers.TabIndex = 1;
            // 
            // numFries
            // 
            this.numFries.Location = new System.Drawing.Point(104, 104);
            this.numFries.Name = "numFries";
            this.numFries.Size = new System.Drawing.Size(100, 20);
            this.numFries.TabIndex = 2;
            // 
            // numDrinks
            // 
            this.numDrinks.Location = new System.Drawing.Point(104, 146);
            this.numDrinks.Name = "numDrinks";
            this.numDrinks.Size = new System.Drawing.Size(100, 20);
            this.numDrinks.TabIndex = 3;
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Location = new System.Drawing.Point(4, 67);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(95, 13);
            this.burgerLabel.TabIndex = 5;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Location = new System.Drawing.Point(17, 107);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(81, 13);
            this.friesLabel.TabIndex = 6;
            this.friesLabel.Text = "Number of Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Location = new System.Drawing.Point(9, 153);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(89, 13);
            this.drinkLabel.TabIndex = 7;
            this.drinkLabel.Text = "Number of Drinks";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcButton.Location = new System.Drawing.Point(20, 181);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(159, 67);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate Totals";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(20, 270);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(159, 48);
            this.totalLabel.TabIndex = 9;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Location = new System.Drawing.Point(38, 343);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(100, 23);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderText
            // 
            this.tenderText.Location = new System.Drawing.Point(113, 343);
            this.tenderText.Name = "tenderText";
            this.tenderText.Size = new System.Drawing.Size(100, 20);
            this.tenderText.TabIndex = 11;
            // 
            // calcChange
            // 
            this.calcChange.Location = new System.Drawing.Point(20, 381);
            this.calcChange.Name = "calcChange";
            this.calcChange.Size = new System.Drawing.Size(100, 23);
            this.calcChange.TabIndex = 12;
            this.calcChange.Text = "Calculate Change";
            this.calcChange.UseVisualStyleBackColor = true;
            this.calcChange.Click += new System.EventHandler(this.calcChange_Click);
            // 
            // changelabel
            // 
            this.changelabel.Location = new System.Drawing.Point(162, 381);
            this.changelabel.Name = "changelabel";
            this.changelabel.Size = new System.Drawing.Size(100, 23);
            this.changelabel.TabIndex = 13;
            // 
            // reciptButton
            // 
            this.reciptButton.Location = new System.Drawing.Point(23, 415);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(164, 23);
            this.reciptButton.TabIndex = 15;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = true;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // newbutton
            // 
            this.newbutton.Location = new System.Drawing.Point(704, 415);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(75, 23);
            this.newbutton.TabIndex = 16;
            this.newbutton.Text = "New Order";
            this.newbutton.UseVisualStyleBackColor = true;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changelabel);
            this.Controls.Add(this.calcChange);
            this.Controls.Add(this.tenderText);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.numDrinks);
            this.Controls.Add(this.numFries);
            this.Controls.Add(this.numBurgers);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox numBurgers;
        private System.Windows.Forms.TextBox numFries;
        private System.Windows.Forms.TextBox numDrinks;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderText;
        private System.Windows.Forms.Button calcChange;
        private System.Windows.Forms.Label changelabel;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Button newbutton;
    }
}

