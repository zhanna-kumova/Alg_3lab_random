namespace Alg_3lab_random
{
    partial class lab3
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
            this.first_btn = new System.Windows.Forms.Button();
            this.sec_btn = new System.Windows.Forms.Button();
            this.first_matrix = new System.Windows.Forms.ListBox();
            this.second_matrix = new System.Windows.Forms.ListBox();
            this.column = new System.Windows.Forms.Label();
            this.col_exists = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.min_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(12, 246);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(170, 46);
            this.first_btn.TabIndex = 1;
            this.first_btn.Text = "column with even numbers";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // sec_btn
            // 
            this.sec_btn.Location = new System.Drawing.Point(364, 246);
            this.sec_btn.Name = "sec_btn";
            this.sec_btn.Size = new System.Drawing.Size(170, 25);
            this.sec_btn.TabIndex = 2;
            this.sec_btn.Text = "get the second matrix";
            this.sec_btn.UseVisualStyleBackColor = true;
            this.sec_btn.Click += new System.EventHandler(this.sec_btn_Click);
            // 
            // first_matrix
            // 
            this.first_matrix.FormattingEnabled = true;
            this.first_matrix.ItemHeight = 16;
            this.first_matrix.Location = new System.Drawing.Point(40, 50);
            this.first_matrix.Name = "first_matrix";
            this.first_matrix.Size = new System.Drawing.Size(98, 84);
            this.first_matrix.TabIndex = 4;
            // 
            // second_matrix
            // 
            this.second_matrix.FormattingEnabled = true;
            this.second_matrix.ItemHeight = 16;
            this.second_matrix.Location = new System.Drawing.Point(396, 50);
            this.second_matrix.Name = "second_matrix";
            this.second_matrix.Size = new System.Drawing.Size(95, 84);
            this.second_matrix.TabIndex = 5;
            // 
            // column
            // 
            this.column.AutoSize = true;
            this.column.Location = new System.Drawing.Point(204, 100);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(105, 17);
            this.column.TabIndex = 6;
            this.column.Text = "column number";
            // 
            // col_exists
            // 
            this.col_exists.AutoSize = true;
            this.col_exists.Location = new System.Drawing.Point(204, 60);
            this.col_exists.Name = "col_exists";
            this.col_exists.Size = new System.Drawing.Size(166, 17);
            this.col_exists.TabIndex = 7;
            this.col_exists.Text = "tag of column\'s existence";
            this.col_exists.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(562, 60);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(33, 17);
            this.max_label.TabIndex = 8;
            this.max_label.Text = "max";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Location = new System.Drawing.Point(562, 100);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(30, 17);
            this.min_label.TabIndex = 9;
            this.min_label.Text = "min";
            // 
            // lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 373);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.col_exists);
            this.Controls.Add(this.column);
            this.Controls.Add(this.second_matrix);
            this.Controls.Add(this.first_matrix);
            this.Controls.Add(this.sec_btn);
            this.Controls.Add(this.first_btn);
            this.Name = "lab3";
            this.Text = "317 Kumova, lab 3, var 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button sec_btn;
        private System.Windows.Forms.ListBox first_matrix;
        private System.Windows.Forms.ListBox second_matrix;
        private System.Windows.Forms.Label column;
        private System.Windows.Forms.Label col_exists;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Label min_label;
    }
}

