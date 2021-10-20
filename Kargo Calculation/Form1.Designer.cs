
namespace Kargo_Calculation
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
            this.cbx_Countries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_ProductTypes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txtB_count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_Width = new System.Windows.Forms.TextBox();
            this.txtB_Length = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_Weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_Countries
            // 
            this.cbx_Countries.FormattingEnabled = true;
            this.cbx_Countries.Location = new System.Drawing.Point(10, 53);
            this.cbx_Countries.Name = "cbx_Countries";
            this.cbx_Countries.Size = new System.Drawing.Size(103, 23);
            this.cbx_Countries.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product type";
            // 
            // cbx_ProductTypes
            // 
            this.cbx_ProductTypes.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_ProductTypes.FormattingEnabled = true;
            this.cbx_ProductTypes.Location = new System.Drawing.Point(10, 159);
            this.cbx_ProductTypes.Name = "cbx_ProductTypes";
            this.cbx_ProductTypes.Size = new System.Drawing.Size(103, 28);
            this.cbx_ProductTypes.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Count";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculate.Location = new System.Drawing.Point(124, 332);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(101, 34);
            this.btn_Calculate.TabIndex = 9;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.Location = new System.Drawing.Point(407, 373);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(0, 30);
            this.lbl_Price.TabIndex = 10;
            // 
            // txtB_count
            // 
            this.txtB_count.Location = new System.Drawing.Point(10, 251);
            this.txtB_count.Name = "txtB_count";
            this.txtB_count.Size = new System.Drawing.Size(100, 23);
            this.txtB_count.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Width";
            // 
            // txtB_Width
            // 
            this.txtB_Width.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB_Width.Location = new System.Drawing.Point(258, 53);
            this.txtB_Width.Name = "txtB_Width";
            this.txtB_Width.Size = new System.Drawing.Size(100, 27);
            this.txtB_Width.TabIndex = 13;
            this.txtB_Width.Text = "0";
            // 
            // txtB_Length
            // 
            this.txtB_Length.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB_Length.Location = new System.Drawing.Point(258, 161);
            this.txtB_Length.Name = "txtB_Length";
            this.txtB_Length.Size = new System.Drawing.Size(100, 27);
            this.txtB_Length.TabIndex = 15;
            this.txtB_Length.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(273, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Length";
            // 
            // txtB_Weight
            // 
            this.txtB_Weight.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB_Weight.Location = new System.Drawing.Point(255, 251);
            this.txtB_Weight.Name = "txtB_Weight";
            this.txtB_Weight.Size = new System.Drawing.Size(100, 27);
            this.txtB_Weight.TabIndex = 17;
            this.txtB_Weight.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(270, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(449, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Azn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 435);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtB_Weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB_Length);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB_Width);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_count);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_ProductTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Countries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Countries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_ProductTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txtB_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_Width;
        private System.Windows.Forms.TextBox txtB_Length;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_Weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

