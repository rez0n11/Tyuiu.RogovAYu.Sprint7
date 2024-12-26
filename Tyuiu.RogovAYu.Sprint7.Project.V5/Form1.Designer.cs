namespace Tyuiu.RogovAYu.Sprint7.Project.V5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            Stats = new Button();
            Graph = new Button();
            Info = new Button();
            Save = new Button();
            Load = new Button();
            panel2 = new Panel();
            DataGrid = new DataGridView();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Название = new DataGridViewTextBoxColumn();
            Цена = new DataGridViewTextBoxColumn();
            Количество = new DataGridViewTextBoxColumn();
            Описание = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Stats);
            panel1.Controls.Add(Graph);
            panel1.Controls.Add(Info);
            panel1.Controls.Add(Save);
            panel1.Controls.Add(Load);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 61);
            panel1.TabIndex = 0;
            // 
            // Stats
            // 
            Stats.Image = (Image)resources.GetObject("Stats.Image");
            Stats.Location = new Point(451, 5);
            Stats.Name = "Stats";
            Stats.Size = new Size(50, 50);
            Stats.TabIndex = 4;
            Stats.UseVisualStyleBackColor = true;
            Stats.Click += button1_Click;
            Stats.MouseEnter += Stats_MouseEnter;
            // 
            // Graph
            // 
            Graph.Image = (Image)resources.GetObject("Graph.Image");
            Graph.Location = new Point(395, 5);
            Graph.Name = "Graph";
            Graph.Size = new Size(50, 50);
            Graph.TabIndex = 3;
            Graph.UseVisualStyleBackColor = true;
            Graph.Click += Graph_Click;
            Graph.MouseEnter += MouseGo;
            // 
            // Info
            // 
            Info.Anchor = AnchorStyles.Right;
            Info.Image = (Image)resources.GetObject("Info.Image");
            Info.Location = new Point(1087, 5);
            Info.Name = "Info";
            Info.Size = new Size(50, 50);
            Info.TabIndex = 2;
            Info.UseVisualStyleBackColor = true;
            Info.Click += Info_Click;
            Info.MouseEnter += MouseInfo;
            // 
            // Save
            // 
            Save.Image = (Image)resources.GetObject("Save.Image");
            Save.Location = new Point(105, 5);
            Save.Name = "Save";
            Save.Size = new Size(50, 50);
            Save.TabIndex = 1;
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            Save.MouseEnter += Mouse_Save;
            // 
            // Load
            // 
            Load.Image = (Image)resources.GetObject("Load.Image");
            Load.Location = new Point(12, 5);
            Load.Name = "Load";
            Load.Size = new Size(50, 50);
            Load.TabIndex = 0;
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            Load.MouseEnter += Mouse_Load;
            // 
            // panel2
            // 
            panel2.Controls.Add(DataGrid);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 389);
            panel2.TabIndex = 2;
            // 
            // DataGrid
            // 
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Название, Цена, Количество, Описание });
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Location = new Point(0, 0);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.Size = new Size(610, 389);
            DataGrid.TabIndex = 1;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Количество";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Цена";
            chart.Series.Add(series1);
            chart.Series.Add(series2);
            chart.Size = new Size(530, 389);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            // 
            // panel3
            // 
            panel3.Controls.Add(chart);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(610, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 389);
            panel3.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Код";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.SortMode = DataGridViewColumnSortMode.Programmatic;
            Column1.ToolTipText = "Код товара";
            Column1.Width = 64;
            // 
            // Название
            // 
            Название.HeaderText = "Название";
            Название.MinimumWidth = 6;
            Название.Name = "Название";
            Название.Width = 125;
            // 
            // Цена
            // 
            Цена.HeaderText = "Цена";
            Цена.MinimumWidth = 6;
            Цена.Name = "Цена";
            Цена.Width = 125;
            // 
            // Количество
            // 
            Количество.HeaderText = "Кол-во";
            Количество.MinimumWidth = 6;
            Количество.Name = "Количество";
            Количество.Width = 125;
            // 
            // Описание
            // 
            Описание.HeaderText = "Описание";
            Описание.MinimumWidth = 6;
            Описание.Name = "Описание";
            Описание.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1140, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            ShowIcon = false;
            Text = "Оптовая база";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Graph;
        private Button Info;
        private Button Save;
        private Button Load;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Panel panel3;
        private DataGridView DataGrid;
        private Button Stats;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Название;
        private DataGridViewTextBoxColumn Цена;
        private DataGridViewTextBoxColumn Количество;
        private DataGridViewTextBoxColumn Описание;
    }
}
