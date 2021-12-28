using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Kursach21
{
    //Структура для массивов
    public struct coords
    {
        public int coordX;
        public int coordY;
    }

    public partial class Form1 : Form
    {
        //Делаем единый размер ячеек
        void setCells(DataGridView x)
        {
            x.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            x.AutoResizeColumns();
            x.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            x.AllowUserToAddRows = false;//Запрет создавать новые строки
        }

        //Задаём размеры таблицы
        void createTables(DataGridView name, int x, int y)
        {
            name.ColumnCount = x;
            name.RowCount = y;
        }

        bool check = false;

        public Form1()
        {
            InitializeComponent();

            setCells(FirstTable);
            setCells(SecondTable);
            setCells(AlgProiz);
            setCells(AlgSum);
            setCells(Dizun);
        }

        //Задаем кол-во строк и столбцов
        private void CreateTables_Click(object sender, EventArgs e)
        {
            var heightOfTables = Convert.ToInt32(TablesHeight.Text);
            var weightOfTables = Convert.ToInt32(TablesWeight.Text);

            createTables(FirstTable, weightOfTables, heightOfTables);
            createTables(SecondTable, weightOfTables, heightOfTables);
            createTables(AlgProiz, weightOfTables, heightOfTables);
            createTables(AlgSum, weightOfTables, heightOfTables);
            createTables(Dizun, weightOfTables, heightOfTables);

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

                    AlgProiz.Rows[i].Cells[j].Value = Math.Round(value, 2);
                }
            }

            //Алгеброическая сумма
            for (int i = 0; i < FirstTable.RowCount; i++)
            {
                for (int j = 0; j < FirstTable.ColumnCount; j++)
                {
                    value = Convert.ToDouble(FirstTable.Rows[i].Cells[j].Value) + Convert.ToDouble(SecondTable.Rows[i].Cells[j].Value)
                        - Convert.ToDouble(FirstTable.Rows[i].Cells[j].Value) * Convert.ToDouble(SecondTable.Rows[i].Cells[j].Value);
                    AlgSum.Rows[i].Cells[j].Value = Math.Round(value, 2);
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

                    Dizun.Rows[i].Cells[j].Value = Math.Round(value, 2);
                }
            }
        }

        private void DrawGrafs_Click(object sender, EventArgs e)
        {
            check = true;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Проверка, чтобы не рисовать при запуске формы
            if (check)
            {
                //Массивы для координат стрелок
                var arrayOfxCoordsProiz = new coords[FirstTable.RowCount];
                var arrayOfxCoordsSum = new coords[FirstTable.RowCount];
                var arrayOfxCoordsDizun= new coords[FirstTable.RowCount];

                var arrayOfyCoordsProiz = new coords[FirstTable.ColumnCount];
                var arrayOfyCoordsSum = new coords[FirstTable.ColumnCount];
                var arrayOfyCoordsDizun= new coords[FirstTable.ColumnCount];

                //Переменная для отрисовки
                var test = e.Graphics;

                //Ручки для отрисовки
                var linePen = new Pen(Brushes.Black, 1.0f);
                var valuePen = new Pen(Brushes.DarkViolet, 1.0f);

                //Стрелка на конце линии
                valuePen.StartCap = LineCap.ArrowAnchor;
                valuePen.CustomEndCap = new AdjustableArrowCap(3, 5);

                //Подпись вершин
                var font = new Font("Times New Roman", 8.0f);
                var fontBrush = new SolidBrush(Color.Black);

                //Функции отрисовки
                void paintXFun(coords[] arrayName, int startXCoord, int yMove, int repeat)
                {
                    test.DrawEllipse(linePen, startXCoord, yMove, 10, 10);
                    test.DrawString($"X{repeat + 1}", font, fontBrush, new Point(startXCoord - 18, yMove));

                    arrayName[repeat].coordX = startXCoord + 5;
                    arrayName[repeat].coordY = yMove + 5;
                }
                
                void paintYFun(coords[] arrayName, int startXCoord, int yMove, int repeat)
                {
                    test.DrawEllipse(linePen, startXCoord, yMove, 10, 10);
                    test.DrawString($"Y{repeat + 1}", font, fontBrush, new Point(startXCoord + 13, yMove));

                    arrayName[repeat].coordX = startXCoord + 5;
                    arrayName[repeat].coordY = yMove + 5;
                }

                void paintLines(DataGridView tableName, coords[] arrayNameX, coords[] arrayNameY, int forX, int forY)
                {
                    if (Convert.ToDouble(tableName.Rows[forX].Cells[forY].Value) != 0)
                        test.DrawLine(valuePen, arrayNameX[forX].coordX, arrayNameX[forX].coordY, arrayNameY[forY].coordX, arrayNameY[forY].coordY);
                }

                var moveX = 230 / FirstTable.RowCount;
                var moveY = 230 / FirstTable.ColumnCount;

                //Рисуем вершины
                for (int i = 0; i < FirstTable.RowCount; i++)
                {
                    var y = 200 + moveX * i;

                    paintXFun(arrayOfxCoordsProiz, 300, y, i);
                    paintXFun(arrayOfxCoordsSum, 550, y, i);
                    paintXFun(arrayOfxCoordsDizun, 800, y, i);
                }

                for (int j = 0; j < FirstTable.ColumnCount; j++)
                {
                    var y = 200 + moveY * j;

                    paintYFun(arrayOfyCoordsProiz, 480, y, j);
                    paintYFun(arrayOfyCoordsSum, 730, y, j);
                    paintYFun(arrayOfyCoordsDizun, 980, y, j);
                }

                //Рисуем стрелки
                for (int i = 0; i < FirstTable.RowCount; i++)
                {
                    for (int j = 0; j < FirstTable.ColumnCount; j++)
                    {
                        paintLines(AlgProiz, arrayOfxCoordsProiz, arrayOfyCoordsProiz, i, j);
                        paintLines(AlgSum, arrayOfxCoordsSum, arrayOfyCoordsSum, i, j);
                        paintLines(Dizun, arrayOfxCoordsDizun, arrayOfyCoordsDizun, i, j);
                    }
                }
            }
        }
    }
}
