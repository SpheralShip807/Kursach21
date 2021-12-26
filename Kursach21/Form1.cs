using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Запрет создавать новые строки
            FirstTable.AllowUserToAddRows = false;
            SecondTable.AllowUserToAddRows = false;

            //Делаем единый размер ячеек
            FirstTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FirstTable.AutoResizeColumns();
            FirstTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            SecondTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SecondTable.AutoResizeColumns();
            SecondTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            AlgProiz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AlgProiz.AutoResizeColumns();
            AlgProiz.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            AlgSum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AlgSum.AutoResizeColumns();
            AlgSum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Dizun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dizun.AutoResizeColumns();
            Dizun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        //Задаем кол-во строк и столбцов
        private void CreateTables_Click(object sender, EventArgs e)
        {
            var heightOfTables = Convert.ToInt32(TablesHeight.Text);
            var weightOfTables = Convert.ToInt32(TablesWeight.Text);

            FirstTable.ColumnCount = weightOfTables;
            FirstTable.RowCount = heightOfTables;

            SecondTable.ColumnCount = weightOfTables;
            SecondTable.RowCount = heightOfTables;

            AlgProiz.ColumnCount = weightOfTables;
            AlgProiz.RowCount = heightOfTables;

            AlgSum.ColumnCount = weightOfTables;
            AlgSum.RowCount = heightOfTables;

            Dizun.ColumnCount = weightOfTables;
            Dizun.RowCount = heightOfTables;

            //Рандом для тестов
            var random = new Random();

            for (int i = 0; i < FirstTable.RowCount; i++)
            {
                for (int j = 0; j < FirstTable.ColumnCount; j++)
                {
                    FirstTable.Rows[i].Cells[j].Value = Math.Round(random.NextDouble(), 1);
                    SecondTable.Rows[i].Cells[j].Value = Math.Round(random.NextDouble(), 1);
                }
            }
        }

        private void CountValues_Click(object sender, EventArgs e)
        {
            //Рабочая переменная
            double value;

            //Алгеброическое произведение
            for (int i = 0; i < FirstTable.RowCount; i++)
            {
                for (int j = 0; j < FirstTable.ColumnCount; j++)
                {
                    value = Convert.ToDouble(FirstTable.Rows[i].Cells[j].Value) * Convert.ToDouble(SecondTable.Rows[i].Cells[j].Value);

                    AlgProiz.Rows[i].Cells[j].Value = Math.Round(value, 1);
                }
            }

            //Алгеброическая сумма
            for (int i = 0; i < FirstTable.RowCount; i++)
            {
                for (int j = 0; j < FirstTable.ColumnCount; j++)
                {
                    value = Convert.ToDouble(FirstTable.Rows[i].Cells[j].Value) + Convert.ToDouble(SecondTable.Rows[i].Cells[j].Value)
                        - Convert.ToDouble(FirstTable.Rows[i].Cells[j].Value) * Convert.ToDouble(SecondTable.Rows[i].Cells[j].Value);
                    if (value >= 1)
                        AlgSum.Rows[i].Cells[j].Value = 1;
                    else
                        AlgSum.Rows[i].Cells[j].Value = Math.Round(value, 1);
                }
            }

            //Дизъюктивная сумма
            for (int i = 0; i < FirstTable.RowCount; i++)
            {
                for (int j = 0; j < FirstTable.ColumnCount; j++)
                {
                    //Для простоты работы
                    var first = Convert.ToDouble(FirstTable.Rows[i].Cells[j].Value);
                    var second = Convert.ToDouble(SecondTable.Rows[i].Cells[j].Value);

                    value = Math.Max(Math.Min(first, 1 - second), Math.Min(1 - first, second));

                    Dizun.Rows[i].Cells[j].Value = Math.Round(value, 1);
                }
            }
        }

        private void DrawGrafs_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var test = e.Graphics;

            var linePen = new Pen(Brushes.Black, 1.0f);
            var valuePen = new Pen(Brushes.DarkViolet, 4.0f);

            test.DrawLine(linePen, 370, 370, 390, 390);
            test.DrawLine(valuePen, 390, 390, 410, 410);
        }
    }
}
