namespace zaliczeniowy1
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.giftTB = new System.Windows.Forms.TextBox();
            this.createBT = new System.Windows.Forms.Button();
            this.giftsLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(41, 56);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(230, 22);
            this.nameTB.TabIndex = 0;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(41, 220);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(230, 22);
            this.priceTB.TabIndex = 1;
            // 
            // giftTB
            // 
            this.giftTB.Location = new System.Drawing.Point(41, 134);
            this.giftTB.Name = "giftTB";
            this.giftTB.Size = new System.Drawing.Size(230, 22);
            this.giftTB.TabIndex = 2;
            this.giftTB.TextChanged += new System.EventHandler(this.giftTB_TextChanged);
            // 
            // createBT
            // 
            this.createBT.Location = new System.Drawing.Point(41, 276);
            this.createBT.Name = "createBT";
            this.createBT.Size = new System.Drawing.Size(75, 23);
            this.createBT.TabIndex = 3;
            this.createBT.Text = "stworz";
            this.createBT.UseVisualStyleBackColor = true;
            // 
            // giftsLB
            // 
            this.giftsLB.FormattingEnabled = true;
            this.giftsLB.ItemHeight = 16;
            this.giftsLB.Location = new System.Drawing.Point(369, 56);
            this.giftsLB.Name = "giftsLB";
            this.giftsLB.Size = new System.Drawing.Size(120, 84);
            this.giftsLB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giftsLB);
            this.Controls.Add(this.createBT);
            this.Controls.Add(this.giftTB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.nameTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox giftTB;
        private System.Windows.Forms.Button createBT;
        private System.Windows.Forms.ListBox giftsLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

