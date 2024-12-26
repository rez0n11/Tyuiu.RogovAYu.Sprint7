using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.RogovAYu.Sprint7.Project.V5.Lib;

namespace Tyuiu.RogovAYu.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        DataService ds = new();

        ToolTip toolTip = new ToolTip();
        public FormMain()
        {
            InitializeComponent();

            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(Load, "Загрузить Файл (.csv)");
            toolTip.SetToolTip(Save, "Сохранить Файл (.csv)");
            toolTip.SetToolTip(Graph, "Построить график");
            toolTip.SetToolTip(Info, "О Программе");
            toolTip.SetToolTip(Stats, "Открыть окно статистики");
        }



        private void Save_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "SaveData.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();
            string path = saveFileDialog.FileName;
            string str = "";
            if (new FileInfo(path).Exists) { File.Delete(path); }

            string[,] outp = new string[DataGrid.RowCount, DataGrid.ColumnCount];
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                for (int j = 0; j < DataGrid.ColumnCount; j++)
                {
                    if (j != DataGrid.ColumnCount - 1)
                    {
                        str += DataGrid.Rows[i].Cells[j].Value + ",";
                    }
                    else
                    {
                        str += DataGrid.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine); str = "";
            }
        }
        float minprice = 0, maxprice = 0, avgprice, minamount = 0, maxamount = 0, avgamount;
        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string[,] fileout = ds.Load(ofd.FileName);

            using StreamReader reader = new StreamReader(ofd.FileName);
            string[] lines = reader.ReadToEnd().Split('\n');

            int rc = lines.Length, cc = lines[0].Split(',', ';').Length;
            string[,] matrix = new string[rc, cc];
            DataGrid.RowCount = rc + 1;
            DataGrid.ColumnCount = cc;

            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < cc; j++)
                {
                    DataGrid.Rows[i].Cells[j].Value = fileout[i,j];
                }
            }

            minprice = float.Parse(DataGrid.Rows[0].Cells[2].Value.ToString());
            minamount = float.Parse(DataGrid.Rows[0].Cells[3].Value.ToString());
            maxprice = 0; avgprice = 0;
            maxamount = 0; avgamount = 0;
            for (int i = 0; i < rc; i++)
            {
                if (float.Parse(DataGrid.Rows[i].Cells[2].Value.ToString()) < minprice)
                {
                    minprice = float.Parse(DataGrid.Rows[i].Cells[2].Value.ToString());
                }
                if (float.Parse(DataGrid.Rows[i].Cells[2].Value.ToString()) > maxprice)
                {
                    maxprice = float.Parse(DataGrid.Rows[i].Cells[2].Value.ToString());
                }
                avgprice += float.Parse(DataGrid.Rows[i].Cells[2].Value.ToString());


                if (float.Parse(DataGrid.Rows[i].Cells[3].Value.ToString()) < minamount)
                {
                    minamount = float.Parse(DataGrid.Rows[i].Cells[3].Value.ToString());
                }
                if (float.Parse(DataGrid.Rows[i].Cells[3].Value.ToString()) > maxamount)
                {
                    maxamount = float.Parse(DataGrid.Rows[i].Cells[3].Value.ToString());
                }
                avgamount += float.Parse(DataGrid.Rows[i].Cells[3].Value.ToString());
            }
            avgprice /= rc; avgamount /= rc;

        }

        private void Graph_Click(object sender, EventArgs e)
        {
            ChartArea ca = chart.ChartAreas[0];

            Series s1 = chart.Series[0];
            Series s2 = chart.Series[1];
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();


            ca.AxisY2.Enabled = AxisEnabled.True;
            s1.YAxisType = AxisType.Primary;
            s2.YAxisType = AxisType.Secondary;

            ca.RecalculateAxesScale();
            for (int i = 0; i < DataGrid.RowCount - 1; i++)
            {


                chart.Series[0].Points.AddXY(i, float.Parse(DataGrid.Rows[i].Cells[2].Value.ToString()));
                chart.Series[1].Points.AddXY(i, float.Parse(DataGrid.Rows[i].Cells[3].Value.ToString()));

            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            FormAbout about = new();
            about.ShowDialog();
        }


        private void Mouse_Load(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Загрузить";
        }



        private void MouseGo(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Выполнить";
        }

        private void MouseInfo(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Справка";
        }

        private void Mouse_Save(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Сохранить";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Максимальная цена - {maxprice} \n" +
                            $"Минимальная цена - {minprice} \n" +
                            $"Средняя цена - {avgprice}\n\n\n" +
                            $"Максимальное количество - {maxamount}\n" +
                            $"Минимальное количество - {minamount}\n" +
                            $"Среднее количество - {avgamount}", "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Stats_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Статистика";
        }
    }
}

