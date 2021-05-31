
namespace Lab10_2
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtBxWFeet = new System.Windows.Forms.TextBox();
            this.txtBxLfeet = new System.Windows.Forms.TextBox();
            this.gpBxTypePrice = new System.Windows.Forms.GroupBox();
            this.rdBtnOak = new System.Windows.Forms.RadioButton();
            this.rdBtnMaple = new System.Windows.Forms.RadioButton();
            this.rdBtnWalnut = new System.Windows.Forms.RadioButton();
            this.rdBtnCherry = new System.Windows.Forms.RadioButton();
            this.lblWFeet = new System.Windows.Forms.Label();
            this.txtBxWInches = new System.Windows.Forms.TextBox();
            this.lblWinches = new System.Windows.Forms.Label();
            this.lblLfeet = new System.Windows.Forms.Label();
            this.lblLinches = new System.Windows.Forms.Label();
            this.txtBxLinches = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBxTotalCost = new System.Windows.Forms.TextBox();
            this.gpBxTypePrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(103, 53);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            this.lblWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(103, 103);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(52, 17);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length";
            this.lblLength.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBxWFeet
            // 
            this.txtBxWFeet.Location = new System.Drawing.Point(159, 53);
            this.txtBxWFeet.Name = "txtBxWFeet";
            this.txtBxWFeet.Size = new System.Drawing.Size(100, 22);
            this.txtBxWFeet.TabIndex = 2;
            // 
            // txtBxLfeet
            // 
            this.txtBxLfeet.Location = new System.Drawing.Point(159, 103);
            this.txtBxLfeet.Name = "txtBxLfeet";
            this.txtBxLfeet.Size = new System.Drawing.Size(100, 22);
            this.txtBxLfeet.TabIndex = 3;
            // 
            // gpBxTypePrice
            // 
            this.gpBxTypePrice.Controls.Add(this.rdBtnCherry);
            this.gpBxTypePrice.Controls.Add(this.rdBtnWalnut);
            this.gpBxTypePrice.Controls.Add(this.rdBtnMaple);
            this.gpBxTypePrice.Controls.Add(this.rdBtnOak);
            this.gpBxTypePrice.Location = new System.Drawing.Point(102, 195);
            this.gpBxTypePrice.Name = "gpBxTypePrice";
            this.gpBxTypePrice.Size = new System.Drawing.Size(364, 205);
            this.gpBxTypePrice.TabIndex = 4;
            this.gpBxTypePrice.TabStop = false;
            this.gpBxTypePrice.Text = "Type and Price of Floor Covering";
            this.gpBxTypePrice.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdBtnOak
            // 
            this.rdBtnOak.AutoSize = true;
            this.rdBtnOak.Checked = true;
            this.rdBtnOak.Location = new System.Drawing.Point(7, 38);
            this.rdBtnOak.Name = "rdBtnOak";
            this.rdBtnOak.Size = new System.Drawing.Size(227, 21);
            this.rdBtnOak.TabIndex = 0;
            this.rdBtnOak.TabStop = true;
            this.rdBtnOak.Text = "Oak --- $34.95 per sqaure yard";
            this.rdBtnOak.UseVisualStyleBackColor = true;
            // 
            // rdBtnMaple
            // 
            this.rdBtnMaple.AutoSize = true;
            this.rdBtnMaple.Location = new System.Drawing.Point(7, 84);
            this.rdBtnMaple.Name = "rdBtnMaple";
            this.rdBtnMaple.Size = new System.Drawing.Size(239, 21);
            this.rdBtnMaple.TabIndex = 1;
            this.rdBtnMaple.Text = "Maple --- $36.95 per sqaure yard";
            this.rdBtnMaple.UseVisualStyleBackColor = true;
            // 
            // rdBtnWalnut
            // 
            this.rdBtnWalnut.AutoSize = true;
            this.rdBtnWalnut.Location = new System.Drawing.Point(7, 130);
            this.rdBtnWalnut.Name = "rdBtnWalnut";
            this.rdBtnWalnut.Size = new System.Drawing.Size(245, 21);
            this.rdBtnWalnut.TabIndex = 2;
            this.rdBtnWalnut.Text = "Walnut --- $38.95 per sqaure yard";
            this.rdBtnWalnut.UseVisualStyleBackColor = true;
            // 
            // rdBtnCherry
            // 
            this.rdBtnCherry.AutoSize = true;
            this.rdBtnCherry.Location = new System.Drawing.Point(7, 176);
            this.rdBtnCherry.Name = "rdBtnCherry";
            this.rdBtnCherry.Size = new System.Drawing.Size(311, 21);
            this.rdBtnCherry.TabIndex = 3;
            this.rdBtnCherry.Text = "Cherry Hardwood --- $41.95 per sqaure yard";
            this.rdBtnCherry.UseVisualStyleBackColor = true;
            // 
            // lblWFeet
            // 
            this.lblWFeet.AutoSize = true;
            this.lblWFeet.Location = new System.Drawing.Point(261, 53);
            this.lblWFeet.Name = "lblWFeet";
            this.lblWFeet.Size = new System.Drawing.Size(32, 17);
            this.lblWFeet.TabIndex = 5;
            this.lblWFeet.Text = "feet";
            // 
            // txtBxWInches
            // 
            this.txtBxWInches.Location = new System.Drawing.Point(313, 53);
            this.txtBxWInches.Name = "txtBxWInches";
            this.txtBxWInches.Size = new System.Drawing.Size(100, 22);
            this.txtBxWInches.TabIndex = 6;
            // 
            // lblWinches
            // 
            this.lblWinches.AutoSize = true;
            this.lblWinches.Location = new System.Drawing.Point(416, 53);
            this.lblWinches.Name = "lblWinches";
            this.lblWinches.Size = new System.Drawing.Size(49, 17);
            this.lblWinches.TabIndex = 7;
            this.lblWinches.Text = "inches";
            // 
            // lblLfeet
            // 
            this.lblLfeet.AutoSize = true;
            this.lblLfeet.Location = new System.Drawing.Point(261, 103);
            this.lblLfeet.Name = "lblLfeet";
            this.lblLfeet.Size = new System.Drawing.Size(32, 17);
            this.lblLfeet.TabIndex = 8;
            this.lblLfeet.Text = "feet";
            // 
            // lblLinches
            // 
            this.lblLinches.AutoSize = true;
            this.lblLinches.Location = new System.Drawing.Point(416, 103);
            this.lblLinches.Name = "lblLinches";
            this.lblLinches.Size = new System.Drawing.Size(49, 17);
            this.lblLinches.TabIndex = 9;
            this.lblLinches.Text = "inches";
            // 
            // txtBxLinches
            // 
            this.txtBxLinches.Location = new System.Drawing.Point(313, 103);
            this.txtBxLinches.Name = "txtBxLinches";
            this.txtBxLinches.Size = new System.Drawing.Size(100, 22);
            this.txtBxLinches.TabIndex = 10;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(106, 448);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(175, 23);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.Text = "Compute Total Cost";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(313, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 24);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBxTotalCost
            // 
            this.txtBxTotalCost.Location = new System.Drawing.Point(107, 510);
            this.txtBxTotalCost.Multiline = true;
            this.txtBxTotalCost.Name = "txtBxTotalCost";
            this.txtBxTotalCost.Size = new System.Drawing.Size(380, 169);
            this.txtBxTotalCost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.Controls.Add(this.txtBxTotalCost);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtBxLinches);
            this.Controls.Add(this.lblLinches);
            this.Controls.Add(this.lblLfeet);
            this.Controls.Add(this.lblWinches);
            this.Controls.Add(this.txtBxWInches);
            this.Controls.Add(this.lblWFeet);
            this.Controls.Add(this.gpBxTypePrice);
            this.Controls.Add(this.txtBxLfeet);
            this.Controls.Add(this.txtBxWFeet);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBxTypePrice.ResumeLayout(false);
            this.gpBxTypePrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtBxWFeet;
        private System.Windows.Forms.TextBox txtBxLfeet;
        private System.Windows.Forms.GroupBox gpBxTypePrice;
        private System.Windows.Forms.RadioButton rdBtnCherry;
        private System.Windows.Forms.RadioButton rdBtnWalnut;
        private System.Windows.Forms.RadioButton rdBtnMaple;
        private System.Windows.Forms.RadioButton rdBtnOak;
        private System.Windows.Forms.Label lblWFeet;
        private System.Windows.Forms.TextBox txtBxWInches;
        private System.Windows.Forms.Label lblWinches;
        private System.Windows.Forms.Label lblLfeet;
        private System.Windows.Forms.Label lblLinches;
        private System.Windows.Forms.TextBox txtBxLinches;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBxTotalCost;
    }
}

