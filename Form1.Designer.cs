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
            this.giftsLIST = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showBT = new System.Windows.Forms.Button();
            this.allpriceLB = new System.Windows.Forms.Label();
            this.giftsCountLB = new System.Windows.Forms.Label();
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
            this.createBT.Click += new System.EventHandler(this.createBT_Click);
            // 
            // giftsLIST
            // 
            this.giftsLIST.FormattingEnabled = true;
            this.giftsLIST.ItemHeight = 16;
            this.giftsLIST.Location = new System.Drawing.Point(360, 72);
            this.giftsLIST.Name = "giftsLIST";
            this.giftsLIST.Size = new System.Drawing.Size(311, 84);
            this.giftsLIST.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "przedmiot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "imie";
            // 
            // showBT
            // 
            this.showBT.Location = new System.Drawing.Point(360, 22);
            this.showBT.Name = "showBT";
            this.showBT.Size = new System.Drawing.Size(75, 23);
            this.showBT.TabIndex = 8;
            this.showBT.Text = "wyswietl";
            this.showBT.UseVisualStyleBackColor = true;
            this.showBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // allpriceLB
            // 
            this.allpriceLB.AutoSize = true;
            this.allpriceLB.Location = new System.Drawing.Point(357, 169);
            this.allpriceLB.Name = "allpriceLB";
            this.allpriceLB.Size = new System.Drawing.Size(87, 16);
            this.allpriceLB.TabIndex = 9;
            this.allpriceLB.Text = "laczna kwota:";
            // 
            // giftsCountLB
            // 
            this.giftsCountLB.AutoSize = true;
            this.giftsCountLB.Location = new System.Drawing.Point(357, 201);
            this.giftsCountLB.Name = "giftsCountLB";
            this.giftsCountLB.Size = new System.Drawing.Size(102, 16);
            this.giftsCountLB.TabIndex = 10;
            this.giftsCountLB.Text = "ilosc prezentow:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giftsCountLB);
            this.Controls.Add(this.allpriceLB);
            this.Controls.Add(this.showBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giftsLIST);
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
        private System.Windows.Forms.ListBox giftsLIST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showBT;
        private System.Windows.Forms.Label allpriceLB;
        private System.Windows.Forms.Label giftsCountLB;
    }
}

