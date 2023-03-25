namespace Stadium_Seating
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassAbox = new System.Windows.Forms.TextBox();
            this.ClassBbox = new System.Windows.Forms.TextBox();
            this.Classcbox = new System.Windows.Forms.TextBox();
            this.Outputbox = new System.Windows.Forms.TextBox();
            this.CalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class A Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class B Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class C Seats";
            // 
            // ClassAbox
            // 
            this.ClassAbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassAbox.Location = new System.Drawing.Point(162, 49);
            this.ClassAbox.Name = "ClassAbox";
            this.ClassAbox.Size = new System.Drawing.Size(51, 29);
            this.ClassAbox.TabIndex = 3;
            this.ClassAbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClassBbox
            // 
            this.ClassBbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBbox.Location = new System.Drawing.Point(162, 82);
            this.ClassBbox.Name = "ClassBbox";
            this.ClassBbox.Size = new System.Drawing.Size(51, 29);
            this.ClassBbox.TabIndex = 4;
            this.ClassBbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Classcbox
            // 
            this.Classcbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classcbox.Location = new System.Drawing.Point(162, 115);
            this.Classcbox.Name = "Classcbox";
            this.Classcbox.Size = new System.Drawing.Size(51, 29);
            this.Classcbox.TabIndex = 5;
            this.Classcbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Outputbox
            // 
            this.Outputbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outputbox.Location = new System.Drawing.Point(21, 170);
            this.Outputbox.Name = "Outputbox";
            this.Outputbox.ReadOnly = true;
            this.Outputbox.Size = new System.Drawing.Size(277, 29);
            this.Outputbox.TabIndex = 6;
            this.Outputbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalBtn
            // 
            this.CalBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalBtn.Location = new System.Drawing.Point(194, 218);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(104, 38);
            this.CalBtn.TabIndex = 7;
            this.CalBtn.Text = "Calculate";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 283);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.Outputbox);
            this.Controls.Add(this.Classcbox);
            this.Controls.Add(this.ClassBbox);
            this.Controls.Add(this.ClassAbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClassAbox;
        private System.Windows.Forms.TextBox ClassBbox;
        private System.Windows.Forms.TextBox Classcbox;
        private System.Windows.Forms.TextBox Outputbox;
        private System.Windows.Forms.Button CalBtn;
    }
}

