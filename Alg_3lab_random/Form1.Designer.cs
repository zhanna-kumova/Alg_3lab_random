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
            this.column = new System.Windows.Forms.Label();
            this.col_exists = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.min_label = new System.Windows.Forms.Label();
            this.matrix1dGV = new System.Windows.Forms.DataGridView();
            this.matrix2dGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(12, 519);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(281, 46);
            this.first_btn.TabIndex = 1;
            this.first_btn.Text = "column with even numbers";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // sec_btn
            // 
            this.sec_btn.Location = new System.Drawing.Point(533, 519);
            this.sec_btn.Name = "sec_btn";
            this.sec_btn.Size = new System.Drawing.Size(270, 46);
            this.sec_btn.TabIndex = 2;
            this.sec_btn.Text = "get max and min elements";
            this.sec_btn.UseVisualStyleBackColor = true;
            this.sec_btn.Click += new System.EventHandler(this.sec_btn_Click);
            // 
            // column
            // 
            this.column.AutoSize = true;
            this.column.Location = new System.Drawing.Point(133, 100);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(105, 17);
            this.column.TabIndex = 6;
            this.column.Text = "column number";
            // 
            // col_exists
            // 
            this.col_exists.AutoSize = true;
            this.col_exists.Location = new System.Drawing.Point(107, 60);
            this.col_exists.Name = "col_exists";
            this.col_exists.Size = new System.Drawing.Size(166, 17);
            this.col_exists.TabIndex = 7;
            this.col_exists.Text = "tag of column\'s existence";
            this.col_exists.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(641, 46);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(33, 17);
            this.max_label.TabIndex = 8;
            this.max_label.Text = "max";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Location = new System.Drawing.Point(644, 100);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(30, 17);
            this.min_label.TabIndex = 9;
            this.min_label.Text = "min";
            // 
            // matrix1dGV
            // 
            this.matrix1dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix1dGV.Location = new System.Drawing.Point(12, 143);
            this.matrix1dGV.Name = "matrix1dGV";
            this.matrix1dGV.RowHeadersWidth = 51;
            this.matrix1dGV.RowTemplate.Height = 24;
            this.matrix1dGV.Size = new System.Drawing.Size(376, 307);
            this.matrix1dGV.TabIndex = 10;
            // 
            // matrix2dGV
            // 
            this.matrix2dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix2dGV.Location = new System.Drawing.Point(468, 143);
            this.matrix2dGV.Name = "matrix2dGV";
            this.matrix2dGV.RowHeadersWidth = 51;
            this.matrix2dGV.RowTemplate.Height = 24;
            this.matrix2dGV.Size = new System.Drawing.Size(367, 307);
            this.matrix2dGV.TabIndex = 11;
            // 
            // lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.matrix2dGV);
            this.Controls.Add(this.matrix1dGV);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.col_exists);
            this.Controls.Add(this.column);
            this.Controls.Add(this.sec_btn);
            this.Controls.Add(this.first_btn);
            this.Name = "lab3";
            this.Text = "317 Kumova, lab 3, var 13";
            ((System.ComponentModel.ISupportInitialize)(this.matrix1dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button sec_btn;
        private System.Windows.Forms.Label column;
        private System.Windows.Forms.Label col_exists;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.DataGridView matrix1dGV;
        private System.Windows.Forms.DataGridView matrix2dGV;
    }
}

