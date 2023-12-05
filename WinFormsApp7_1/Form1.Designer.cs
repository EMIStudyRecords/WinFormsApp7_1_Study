namespace WinFormsApp7_1
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
            priceBox = new TextBox();
            taxPriceBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            calcButton = new Button();
            SuspendLayout();
            // 
            // priceBox
            // 
            priceBox.Location = new Point(292, 96);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(245, 27);
            priceBox.TabIndex = 0;
            // 
            // taxPriceBox
            // 
            taxPriceBox.Enabled = false;
            taxPriceBox.Location = new Point(292, 179);
            taxPriceBox.Name = "taxPriceBox";
            taxPriceBox.Size = new Size(245, 27);
            taxPriceBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 103);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "税抜価格";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 182);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "税込価格";
            // 
            // calcButton
            // 
            calcButton.Location = new Point(423, 265);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(114, 55);
            calcButton.TabIndex = 4;
            calcButton.Text = "計算する";
            calcButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 450);
            Controls.Add(calcButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(taxPriceBox);
            Controls.Add(priceBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox priceBox;
        private TextBox taxPriceBox;
        private Label label1;
        private Label label2;
        private Button calcButton;
    }
}