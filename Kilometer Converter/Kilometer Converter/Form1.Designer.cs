namespace Kilometer_Converter
{
    partial class mainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KilometerBox = new System.Windows.Forms.TextBox();
            this.MilesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kilometers ";
            // 
            // KilometerBox
            // 
            this.KilometerBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilometerBox.Location = new System.Drawing.Point(131, 60);
            this.KilometerBox.Name = "KilometerBox";
            this.KilometerBox.Size = new System.Drawing.Size(100, 29);
            this.KilometerBox.TabIndex = 3;
            this.KilometerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.KilometerBox.TextChanged += new System.EventHandler(this.KilometerBox_TextChanged);
            // 
            // MilesBox
            // 
            this.MilesBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilesBox.Location = new System.Drawing.Point(131, 121);
            this.MilesBox.Name = "MilesBox";
            this.MilesBox.ReadOnly = true;
            this.MilesBox.Size = new System.Drawing.Size(100, 29);
            this.MilesBox.TabIndex = 4;
            this.MilesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 231);
            this.Controls.Add(this.MilesBox);
            this.Controls.Add(this.KilometerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "mainPage";
            this.Opacity = 0.9D;
            this.Text = "Kilometer Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KilometerBox;
        private System.Windows.Forms.TextBox MilesBox;
    }
}

