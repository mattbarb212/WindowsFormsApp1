namespace WindowsFormsApp1
{
    partial class cashRegister
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
            this.burgerOutputLabel = new System.Windows.Forms.Label();
            this.friesOutput = new System.Windows.Forms.Label();
            this.drinkOutputLabel = new System.Windows.Forms.Label();
            this.burgersTextBox = new System.Windows.Forms.TextBox();
            this.friesTextBox = new System.Windows.Forms.TextBox();
            this.drinksTextBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subTotalPriceLabel = new System.Windows.Forms.Label();
            this.subTotalOutputLabel = new System.Windows.Forms.Label();
            this.taxPriceLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.blackLine = new System.Windows.Forms.Label();
            this.tenderedOutputLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.changePriceLabel = new System.Windows.Forms.Label();
            this.printRecieptButton = new System.Windows.Forms.Button();
            this.redLine = new System.Windows.Forms.Label();
            this.recieptOutputLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerOutputLabel
            // 
            this.burgerOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burgerOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerOutputLabel.Location = new System.Drawing.Point(45, 42);
            this.burgerOutputLabel.Name = "burgerOutputLabel";
            this.burgerOutputLabel.Size = new System.Drawing.Size(148, 23);
            this.burgerOutputLabel.TabIndex = 0;
            this.burgerOutputLabel.Text = "Number of Burgers:";
            // 
            // friesOutput
            // 
            this.friesOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesOutput.Location = new System.Drawing.Point(45, 78);
            this.friesOutput.Name = "friesOutput";
            this.friesOutput.Size = new System.Drawing.Size(148, 23);
            this.friesOutput.TabIndex = 1;
            this.friesOutput.Text = "Number of Fries:";
            // 
            // drinkOutputLabel
            // 
            this.drinkOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkOutputLabel.Location = new System.Drawing.Point(45, 114);
            this.drinkOutputLabel.Name = "drinkOutputLabel";
            this.drinkOutputLabel.Size = new System.Drawing.Size(148, 23);
            this.drinkOutputLabel.TabIndex = 2;
            this.drinkOutputLabel.Text = "Number of Drinks:";
            // 
            // burgersTextBox
            // 
            this.burgersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgersTextBox.Location = new System.Drawing.Point(237, 32);
            this.burgersTextBox.Multiline = true;
            this.burgersTextBox.Name = "burgersTextBox";
            this.burgersTextBox.Size = new System.Drawing.Size(88, 33);
            this.burgersTextBox.TabIndex = 3;
            // 
            // friesTextBox
            // 
            this.friesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesTextBox.Location = new System.Drawing.Point(237, 68);
            this.friesTextBox.Multiline = true;
            this.friesTextBox.Name = "friesTextBox";
            this.friesTextBox.Size = new System.Drawing.Size(88, 33);
            this.friesTextBox.TabIndex = 4;
            // 
            // drinksTextBox
            // 
            this.drinksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksTextBox.Location = new System.Drawing.Point(237, 104);
            this.drinksTextBox.Multiline = true;
            this.drinksTextBox.Name = "drinksTextBox";
            this.drinksTextBox.Size = new System.Drawing.Size(88, 33);
            this.drinksTextBox.TabIndex = 5;
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(49, 143);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(276, 34);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // subTotalPriceLabel
            // 
            this.subTotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.subTotalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalPriceLabel.Location = new System.Drawing.Point(237, 180);
            this.subTotalPriceLabel.Name = "subTotalPriceLabel";
            this.subTotalPriceLabel.Size = new System.Drawing.Size(88, 33);
            this.subTotalPriceLabel.TabIndex = 7;
            // 
            // subTotalOutputLabel
            // 
            this.subTotalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutputLabel.Location = new System.Drawing.Point(45, 190);
            this.subTotalOutputLabel.Name = "subTotalOutputLabel";
            this.subTotalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.subTotalOutputLabel.TabIndex = 8;
            this.subTotalOutputLabel.Text = "Sub Total:";
            // 
            // taxPriceLabel
            // 
            this.taxPriceLabel.BackColor = System.Drawing.Color.White;
            this.taxPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxPriceLabel.Location = new System.Drawing.Point(237, 223);
            this.taxPriceLabel.Name = "taxPriceLabel";
            this.taxPriceLabel.Size = new System.Drawing.Size(88, 33);
            this.taxPriceLabel.TabIndex = 9;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.Location = new System.Drawing.Point(45, 233);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.taxOutputLabel.TabIndex = 10;
            this.taxOutputLabel.Text = "Tax:";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.Location = new System.Drawing.Point(45, 276);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalOutputLabel.TabIndex = 11;
            this.totalOutputLabel.Text = "Total:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.Color.White;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(237, 266);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(88, 33);
            this.totalPriceLabel.TabIndex = 12;
            // 
            // blackLine
            // 
            this.blackLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackLine.Location = new System.Drawing.Point(50, 311);
            this.blackLine.Name = "blackLine";
            this.blackLine.Size = new System.Drawing.Size(275, 17);
            this.blackLine.TabIndex = 13;
            // 
            // tenderedOutputLabel
            // 
            this.tenderedOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedOutputLabel.Location = new System.Drawing.Point(49, 341);
            this.tenderedOutputLabel.Name = "tenderedOutputLabel";
            this.tenderedOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.tenderedOutputLabel.TabIndex = 14;
            this.tenderedOutputLabel.Text = "Tendered:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 331);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 33);
            this.textBox1.TabIndex = 15;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(49, 367);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(276, 34);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutputLabel.Location = new System.Drawing.Point(45, 414);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(104, 23);
            this.changeOutputLabel.TabIndex = 17;
            this.changeOutputLabel.Text = "Change Due:";
            // 
            // changePriceLabel
            // 
            this.changePriceLabel.BackColor = System.Drawing.Color.White;
            this.changePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePriceLabel.Location = new System.Drawing.Point(237, 404);
            this.changePriceLabel.Name = "changePriceLabel";
            this.changePriceLabel.Size = new System.Drawing.Size(88, 33);
            this.changePriceLabel.TabIndex = 18;
            // 
            // printRecieptButton
            // 
            this.printRecieptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printRecieptButton.Location = new System.Drawing.Point(49, 440);
            this.printRecieptButton.Name = "printRecieptButton";
            this.printRecieptButton.Size = new System.Drawing.Size(276, 34);
            this.printRecieptButton.TabIndex = 19;
            this.printRecieptButton.Text = "Print Reciept";
            this.printRecieptButton.UseVisualStyleBackColor = true;
            // 
            // redLine
            // 
            this.redLine.BackColor = System.Drawing.Color.Red;
            this.redLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLine.Location = new System.Drawing.Point(-6, 0);
            this.redLine.Name = "redLine";
            this.redLine.Size = new System.Drawing.Size(711, 29);
            this.redLine.TabIndex = 20;
            this.redLine.Text = "Greasers Grill";
            this.redLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recieptOutputLabel
            // 
            this.recieptOutputLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.recieptOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recieptOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieptOutputLabel.Location = new System.Drawing.Point(359, 42);
            this.recieptOutputLabel.Name = "recieptOutputLabel";
            this.recieptOutputLabel.Size = new System.Drawing.Size(328, 395);
            this.recieptOutputLabel.TabIndex = 21;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(359, 440);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(328, 34);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // cashRegister
            // 
            this.ClientSize = new System.Drawing.Size(699, 486);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.recieptOutputLabel);
            this.Controls.Add(this.redLine);
            this.Controls.Add(this.printRecieptButton);
            this.Controls.Add(this.changePriceLabel);
            this.Controls.Add(this.changeOutputLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tenderedOutputLabel);
            this.Controls.Add(this.blackLine);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.taxPriceLabel);
            this.Controls.Add(this.subTotalOutputLabel);
            this.Controls.Add(this.subTotalPriceLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.drinksTextBox);
            this.Controls.Add(this.friesTextBox);
            this.Controls.Add(this.burgersTextBox);
            this.Controls.Add(this.drinkOutputLabel);
            this.Controls.Add(this.friesOutput);
            this.Controls.Add(this.burgerOutputLabel);
            this.Name = "cashRegister";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgersOutputLabel;
        private System.Windows.Forms.Label friesOutputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label burgerOutputLabel;
        private System.Windows.Forms.Label friesOutput;
        private System.Windows.Forms.Label drinkOutputLabel;
        private System.Windows.Forms.TextBox burgersTextBox;
        private System.Windows.Forms.TextBox friesTextBox;
        private System.Windows.Forms.TextBox drinksTextBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subTotalPriceLabel;
        private System.Windows.Forms.Label subTotalOutputLabel;
        private System.Windows.Forms.Label taxPriceLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label blackLine;
        private System.Windows.Forms.Label tenderedOutputLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.Label changePriceLabel;
        private System.Windows.Forms.Button printRecieptButton;
        private System.Windows.Forms.Label redLine;
        private System.Windows.Forms.Label recieptOutputLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

