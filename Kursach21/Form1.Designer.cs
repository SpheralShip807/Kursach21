
namespace Kursach21
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
            this.CreateTables = new System.Windows.Forms.Button();
            this.CountValues = new System.Windows.Forms.Button();
            this.DrawGrafs = new System.Windows.Forms.Button();
            this.FirstTable = new System.Windows.Forms.DataGridView();
            this.SecondTable = new System.Windows.Forms.DataGridView();
            this.AlgProiz = new System.Windows.Forms.DataGridView();
            this.AlgSum = new System.Windows.Forms.DataGridView();
            this.Dizun = new System.Windows.Forms.DataGridView();
            this.TablesHeight = new System.Windows.Forms.TextBox();
            this.TablesWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlgProiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlgSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dizun)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateTables
            // 
            this.CreateTables.Location = new System.Drawing.Point(5, 394);
            this.CreateTables.Name = "CreateTables";
            this.CreateTables.Size = new System.Drawing.Size(75, 44);
            this.CreateTables.TabIndex = 0;
            this.CreateTables.Text = "Create Tables";
            this.CreateTables.UseVisualStyleBackColor = true;
            this.CreateTables.Click += new System.EventHandler(this.CreateTables_Click);
            // 
            // CountValues
            // 
            this.CountValues.Location = new System.Drawing.Point(86, 394);
            this.CountValues.Name = "CountValues";
            this.CountValues.Size = new System.Drawing.Size(75, 44);
            this.CountValues.TabIndex = 1;
            this.CountValues.Text = "Count Values";
            this.CountValues.UseVisualStyleBackColor = true;
            this.CountValues.Click += new System.EventHandler(this.CountValues_Click);
            // 
            // DrawGrafs
            // 
            this.DrawGrafs.Location = new System.Drawing.Point(167, 394);
            this.DrawGrafs.Name = "DrawGrafs";
            this.DrawGrafs.Size = new System.Drawing.Size(75, 44);
            this.DrawGrafs.TabIndex = 2;
            this.DrawGrafs.Text = "Draw Grafs";
            this.DrawGrafs.UseVisualStyleBackColor = true;
            // 
            // FirstTable
            // 
            this.FirstTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstTable.Location = new System.Drawing.Point(4, 12);
            this.FirstTable.Name = "FirstTable";
            this.FirstTable.RowTemplate.Height = 25;
            this.FirstTable.Size = new System.Drawing.Size(240, 150);
            this.FirstTable.TabIndex = 3;
            // 
            // SecondTable
            // 
            this.SecondTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondTable.Location = new System.Drawing.Point(4, 168);
            this.SecondTable.Name = "SecondTable";
            this.SecondTable.Size = new System.Drawing.Size(240, 150);
            this.SecondTable.TabIndex = 4;
            // 
            // AlgProiz
            // 
            this.AlgProiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlgProiz.Location = new System.Drawing.Point(284, 12);
            this.AlgProiz.Name = "AlgProiz";
            this.AlgProiz.Size = new System.Drawing.Size(240, 150);
            this.AlgProiz.TabIndex = 5;
            // 
            // AlgSum
            // 
            this.AlgSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlgSum.Location = new System.Drawing.Point(530, 12);
            this.AlgSum.Name = "AlgSum";
            this.AlgSum.Size = new System.Drawing.Size(240, 150);
            this.AlgSum.TabIndex = 6;
            // 
            // Dizun
            // 
            this.Dizun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dizun.Location = new System.Drawing.Point(776, 12);
            this.Dizun.Name = "Dizun";
            this.Dizun.Size = new System.Drawing.Size(240, 150);
            this.Dizun.TabIndex = 7;
            // 
            // TablesHeight
            // 
            this.TablesHeight.Location = new System.Drawing.Point(4, 324);
            this.TablesHeight.Name = "TablesHeight";
            this.TablesHeight.Size = new System.Drawing.Size(100, 23);
            this.TablesHeight.TabIndex = 8;
            // 
            // TablesWeight
            // 
            this.TablesWeight.Location = new System.Drawing.Point(144, 324);
            this.TablesWeight.Name = "TablesWeight";
            this.TablesWeight.Size = new System.Drawing.Size(100, 23);
            this.TablesWeight.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Алгеброическое произведение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Алгеброическая сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 451);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablesWeight);
            this.Controls.Add(this.TablesHeight);
            this.Controls.Add(this.Dizun);
            this.Controls.Add(this.AlgSum);
            this.Controls.Add(this.AlgProiz);
            this.Controls.Add(this.SecondTable);
            this.Controls.Add(this.FirstTable);
            this.Controls.Add(this.DrawGrafs);
            this.Controls.Add(this.CountValues);
            this.Controls.Add(this.CreateTables);
            this.MaximumSize = new System.Drawing.Size(1050, 490);
            this.MinimumSize = new System.Drawing.Size(1050, 490);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlgProiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlgSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dizun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTables;
        private System.Windows.Forms.Button CountValues;
        private System.Windows.Forms.Button DrawGrafs;
        private System.Windows.Forms.DataGridView FirstTable;
        private System.Windows.Forms.DataGridView SecondTable;
        private System.Windows.Forms.DataGridView AlgProiz;
        private System.Windows.Forms.DataGridView AlgSum;
        private System.Windows.Forms.DataGridView Dizun;
        private System.Windows.Forms.TextBox TablesHeight;
        private System.Windows.Forms.TextBox TablesWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

