using System.Resources;

namespace Tyuiu.NazarovaKH.Sprint7.Project.V1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelButtons_NKH = new Panel();
            buttonCancelChanges_NKH = new Button();
            buttonCharPie_NKH = new Button();
            buttonDelete_NKH = new Button();
            buttonOpenFile_NKH = new Button();
            buttonSaveFile_NKH = new Button();
            buttonHelp_NKH = new Button();
            LabelTiitle_NKH = new Label();
            panelDataBase_NKH = new Panel();
            groupBoxDataBase_NKH = new GroupBox();
            dataGridViewDataBase_NKH = new DataGridView();
            panelSort_NKH = new Panel();
            groupBoxAdd_NKH = new GroupBox();
            buttonDeleteRow_NKH = new Button();
            buttonAdd_NKH = new Button();
            groupBoxFunc_NKH = new GroupBox();
            buttonDeleteChart_NKH = new Button();
            chartPower_NKH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxMinMaxAvg_NKH = new GroupBox();
            buttonStartValues_NKH = new Button();
            buttonStopMinMaxAvg_NKH = new Button();
            labelAvg_NKH = new Label();
            labelMin_NKH = new Label();
            labelMax_NKH = new Label();
            textBoxAvg_NKH = new TextBox();
            textBoxMin_NKH = new TextBox();
            textBoxMax_NKH = new TextBox();
            groupBoxSearch_NKH = new GroupBox();
            buttonStopSearch_NKH = new Button();
            textBoxSearch_NKH = new TextBox();
            buttonSearch_NKH = new Button();
            textBoxFiltr_NKH = new TextBox();
            buttonFiltr_NKH = new Button();
            buttonCancelFiltr_NKH = new Button();
            toolTipHelp_NKH = new ToolTip(components);
            openFileDialog_NKH = new OpenFileDialog();
            saveFileDialog_NKH = new SaveFileDialog();
            panelButtons_NKH.SuspendLayout();
            panelDataBase_NKH.SuspendLayout();
            groupBoxDataBase_NKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataBase_NKH).BeginInit();
            panelSort_NKH.SuspendLayout();
            groupBoxAdd_NKH.SuspendLayout();
            groupBoxFunc_NKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPower_NKH).BeginInit();
            groupBoxMinMaxAvg_NKH.SuspendLayout();
            groupBoxSearch_NKH.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_NKH
            // 
            panelButtons_NKH.BackColor = Color.White;
            panelButtons_NKH.Controls.Add(buttonCancelChanges_NKH);
            panelButtons_NKH.Controls.Add(buttonCharPie_NKH);
            panelButtons_NKH.Controls.Add(buttonDelete_NKH);
            panelButtons_NKH.Controls.Add(buttonOpenFile_NKH);
            panelButtons_NKH.Controls.Add(buttonSaveFile_NKH);
            panelButtons_NKH.Controls.Add(buttonHelp_NKH);
            panelButtons_NKH.Controls.Add(LabelTiitle_NKH);
            panelButtons_NKH.Dock = DockStyle.Top;
            panelButtons_NKH.Location = new Point(0, 0);
            panelButtons_NKH.Margin = new Padding(3, 4, 3, 4);
            panelButtons_NKH.Name = "panelButtons_NKH";
            panelButtons_NKH.Size = new Size(1478, 106);
            panelButtons_NKH.TabIndex = 0;
            // 
            // buttonCancelChanges_NKH
            // 
            buttonCancelChanges_NKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelChanges_NKH.Image = (Image)resources.GetObject("buttonCancelChanges_NKH.Image");
            buttonCancelChanges_NKH.Location = new Point(1147, 13);
            buttonCancelChanges_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonCancelChanges_NKH.Name = "buttonCancelChanges_NKH";
            buttonCancelChanges_NKH.Size = new Size(59, 77);
            buttonCancelChanges_NKH.TabIndex = 5;
            toolTipHelp_NKH.SetToolTip(buttonCancelChanges_NKH, "Отменить изменения\r\nНажмите, чтобы отменить изменения в таблице.");
            buttonCancelChanges_NKH.UseVisualStyleBackColor = true;
            buttonCancelChanges_NKH.Click += buttonCancelChanges_NKH_Click;
            // 
            // buttonCharPie_NKH
            // 
            buttonCharPie_NKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCharPie_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCharPie_NKH.Image = (Image)resources.GetObject("buttonCharPie_NKH.Image");
            buttonCharPie_NKH.Location = new Point(1082, 13);
            buttonCharPie_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonCharPie_NKH.Name = "buttonCharPie_NKH";
            buttonCharPie_NKH.Size = new Size(59, 77);
            buttonCharPie_NKH.TabIndex = 0;
            buttonCharPie_NKH.Text = "\r\n";
            toolTipHelp_NKH.SetToolTip(buttonCharPie_NKH, "Построить диаграмму.\r\nНажмите, чтобы построить диаграмму Марка & Мощность.");
            buttonCharPie_NKH.UseVisualStyleBackColor = true;
            buttonCharPie_NKH.Click += buttonCharPie_NKH_Click;
            // 
            // buttonDelete_NKH
            // 
            buttonDelete_NKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete_NKH.Image = (Image)resources.GetObject("buttonDelete_NKH.Image");
            buttonDelete_NKH.Location = new Point(1342, 14);
            buttonDelete_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonDelete_NKH.Name = "buttonDelete_NKH";
            buttonDelete_NKH.Size = new Size(59, 77);
            buttonDelete_NKH.TabIndex = 4;
            toolTipHelp_NKH.SetToolTip(buttonDelete_NKH, "Удалить файл\r\nНажмите, чтобы удалить файл с приложения.");
            buttonDelete_NKH.UseVisualStyleBackColor = true;
            buttonDelete_NKH.Click += buttonDelete_NKH_Click;
            // 
            // buttonOpenFile_NKH
            // 
            buttonOpenFile_NKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_NKH.Image = (Image)resources.GetObject("buttonOpenFile_NKH.Image");
            buttonOpenFile_NKH.Location = new Point(1212, 13);
            buttonOpenFile_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_NKH.Name = "buttonOpenFile_NKH";
            buttonOpenFile_NKH.Size = new Size(59, 77);
            buttonOpenFile_NKH.TabIndex = 3;
            toolTipHelp_NKH.SetToolTip(buttonOpenFile_NKH, "Открыть файл\r\nНажмите, чтобы выбрать и открыть нужный файл \r\nдля редактирования.");
            buttonOpenFile_NKH.UseVisualStyleBackColor = true;
            buttonOpenFile_NKH.Click += buttonOpenFile_NKH_Click;
            // 
            // buttonSaveFile_NKH
            // 
            buttonSaveFile_NKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSaveFile_NKH.Image = (Image)resources.GetObject("buttonSaveFile_NKH.Image");
            buttonSaveFile_NKH.Location = new Point(1277, 13);
            buttonSaveFile_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_NKH.Name = "buttonSaveFile_NKH";
            buttonSaveFile_NKH.Size = new Size(59, 77);
            buttonSaveFile_NKH.TabIndex = 2;
            toolTipHelp_NKH.SetToolTip(buttonSaveFile_NKH, "Сохранить файл\r\nНажмите, чтобы сохранить файл.");
            buttonSaveFile_NKH.UseVisualStyleBackColor = true;
            buttonSaveFile_NKH.Click += buttonSaveFile_NKH_Click;
            // 
            // buttonHelp_NKH
            // 
            buttonHelp_NKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NKH.Image = (Image)resources.GetObject("buttonHelp_NKH.Image");
            buttonHelp_NKH.Location = new Point(1407, 14);
            buttonHelp_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_NKH.Name = "buttonHelp_NKH";
            buttonHelp_NKH.Size = new Size(59, 77);
            buttonHelp_NKH.TabIndex = 1;
            toolTipHelp_NKH.SetToolTip(buttonHelp_NKH, "Руководство\r\nНажмите, чтобы получить информацию о программе.");
            buttonHelp_NKH.UseVisualStyleBackColor = true;
            buttonHelp_NKH.Click += buttonHelp_NKH_Click;
            // 
            // LabelTiitle_NKH
            // 
            LabelTiitle_NKH.AutoSize = true;
            LabelTiitle_NKH.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelTiitle_NKH.Location = new Point(12, 26);
            LabelTiitle_NKH.Name = "LabelTiitle_NKH";
            LabelTiitle_NKH.Size = new Size(643, 54);
            LabelTiitle_NKH.TabIndex = 0;
            LabelTiitle_NKH.Text = "Авторемонтные мастерские";
            // 
            // panelDataBase_NKH
            // 
            panelDataBase_NKH.BackColor = Color.White;
            panelDataBase_NKH.Controls.Add(groupBoxDataBase_NKH);
            panelDataBase_NKH.Dock = DockStyle.Fill;
            panelDataBase_NKH.Location = new Point(0, 106);
            panelDataBase_NKH.Margin = new Padding(3, 5, 3, 5);
            panelDataBase_NKH.Name = "panelDataBase_NKH";
            panelDataBase_NKH.Size = new Size(1174, 779);
            panelDataBase_NKH.TabIndex = 1;
            panelDataBase_NKH.Paint += panelDataBase_NKH_Paint;
            // 
            // groupBoxDataBase_NKH
            // 
            groupBoxDataBase_NKH.Controls.Add(dataGridViewDataBase_NKH);
            groupBoxDataBase_NKH.Dock = DockStyle.Fill;
            groupBoxDataBase_NKH.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxDataBase_NKH.Location = new Point(0, 0);
            groupBoxDataBase_NKH.Margin = new Padding(3, 4, 3, 4);
            groupBoxDataBase_NKH.Name = "groupBoxDataBase_NKH";
            groupBoxDataBase_NKH.Padding = new Padding(3, 5, 3, 5);
            groupBoxDataBase_NKH.Size = new Size(1174, 779);
            groupBoxDataBase_NKH.TabIndex = 0;
            groupBoxDataBase_NKH.TabStop = false;
            groupBoxDataBase_NKH.Text = "База данных:";
            // 
            // dataGridViewDataBase_NKH
            // 
            dataGridViewDataBase_NKH.AllowUserToDeleteRows = false;
            dataGridViewDataBase_NKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDataBase_NKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDataBase_NKH.BackgroundColor = Color.White;
            dataGridViewDataBase_NKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataBase_NKH.Dock = DockStyle.Fill;
            dataGridViewDataBase_NKH.Location = new Point(3, 26);
            dataGridViewDataBase_NKH.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDataBase_NKH.Name = "dataGridViewDataBase_NKH";
            dataGridViewDataBase_NKH.RowHeadersVisible = false;
            dataGridViewDataBase_NKH.RowHeadersWidth = 51;
            dataGridViewDataBase_NKH.RowTemplate.Height = 24;
            dataGridViewDataBase_NKH.Size = new Size(1168, 748);
            dataGridViewDataBase_NKH.TabIndex = 0;
            dataGridViewDataBase_NKH.CellValidating += dataGridViewDataBase_NKH_CellValidating;
            dataGridViewDataBase_NKH.DataBindingComplete += dataGridViewDataBase_NKH_DataBindingComplete;
            dataGridViewDataBase_NKH.SelectionChanged += dataGridViewDataBase_NKH_SelectionChanged;
            dataGridViewDataBase_NKH.SortCompare += dataGridViewDataBase_NKH_SortCompare;
            // 
            // panelSort_NKH
            // 
            panelSort_NKH.BackColor = Color.White;
            panelSort_NKH.Controls.Add(groupBoxAdd_NKH);
            panelSort_NKH.Controls.Add(groupBoxFunc_NKH);
            panelSort_NKH.Controls.Add(groupBoxMinMaxAvg_NKH);
            panelSort_NKH.Controls.Add(groupBoxSearch_NKH);
            panelSort_NKH.Dock = DockStyle.Right;
            panelSort_NKH.Location = new Point(1174, 106);
            panelSort_NKH.Margin = new Padding(3, 4, 3, 4);
            panelSort_NKH.Name = "panelSort_NKH";
            panelSort_NKH.Size = new Size(304, 779);
            panelSort_NKH.TabIndex = 2;
            // 
            // groupBoxAdd_NKH
            // 
            groupBoxAdd_NKH.Controls.Add(buttonDeleteRow_NKH);
            groupBoxAdd_NKH.Controls.Add(buttonAdd_NKH);
            groupBoxAdd_NKH.Dock = DockStyle.Fill;
            groupBoxAdd_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxAdd_NKH.Location = new Point(0, 660);
            groupBoxAdd_NKH.Margin = new Padding(3, 4, 3, 4);
            groupBoxAdd_NKH.Name = "groupBoxAdd_NKH";
            groupBoxAdd_NKH.Padding = new Padding(3, 4, 3, 4);
            groupBoxAdd_NKH.Size = new Size(304, 119);
            groupBoxAdd_NKH.TabIndex = 3;
            groupBoxAdd_NKH.TabStop = false;
            groupBoxAdd_NKH.Text = "Добавление строки";
            // 
            // buttonDeleteRow_NKH
            // 
            buttonDeleteRow_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteRow_NKH.Location = new Point(23, 74);
            buttonDeleteRow_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteRow_NKH.Name = "buttonDeleteRow_NKH";
            buttonDeleteRow_NKH.Size = new Size(181, 33);
            buttonDeleteRow_NKH.TabIndex = 1;
            buttonDeleteRow_NKH.Text = "Удалить";
            buttonDeleteRow_NKH.UseVisualStyleBackColor = true;
            buttonDeleteRow_NKH.Click += buttonDeleteRow_NKH_Click;
            // 
            // buttonAdd_NKH
            // 
            buttonAdd_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd_NKH.Location = new Point(23, 33);
            buttonAdd_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonAdd_NKH.Name = "buttonAdd_NKH";
            buttonAdd_NKH.Size = new Size(181, 33);
            buttonAdd_NKH.TabIndex = 0;
            buttonAdd_NKH.Text = "Добавить";
            buttonAdd_NKH.UseVisualStyleBackColor = true;
            buttonAdd_NKH.Click += buttonAdd_NKH_Click;
            // 
            // groupBoxFunc_NKH
            // 
            groupBoxFunc_NKH.Controls.Add(buttonDeleteChart_NKH);
            groupBoxFunc_NKH.Controls.Add(chartPower_NKH);
            groupBoxFunc_NKH.Dock = DockStyle.Top;
            groupBoxFunc_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFunc_NKH.Location = new Point(0, 441);
            groupBoxFunc_NKH.Margin = new Padding(3, 4, 3, 4);
            groupBoxFunc_NKH.Name = "groupBoxFunc_NKH";
            groupBoxFunc_NKH.Padding = new Padding(3, 4, 3, 4);
            groupBoxFunc_NKH.Size = new Size(304, 219);
            groupBoxFunc_NKH.TabIndex = 2;
            groupBoxFunc_NKH.TabStop = false;
            groupBoxFunc_NKH.Text = "График:";
            // 
            // buttonDeleteChart_NKH
            // 
            buttonDeleteChart_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteChart_NKH.Location = new Point(176, 178);
            buttonDeleteChart_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteChart_NKH.Name = "buttonDeleteChart_NKH";
            buttonDeleteChart_NKH.Size = new Size(80, 36);
            buttonDeleteChart_NKH.TabIndex = 2;
            buttonDeleteChart_NKH.Text = "Удалить";
            buttonDeleteChart_NKH.UseVisualStyleBackColor = true;
            buttonDeleteChart_NKH.Click += buttonDeleteChart_NKH_Click;
            // 
            // chartPower_NKH
            // 
            chartArea1.Name = "ChartArea1";
            chartPower_NKH.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPower_NKH.Legends.Add(legend1);
            chartPower_NKH.Location = new Point(6, 26);
            chartPower_NKH.Margin = new Padding(3, 4, 3, 4);
            chartPower_NKH.Name = "chartPower_NKH";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPower_NKH.Series.Add(series1);
            chartPower_NKH.Size = new Size(267, 188);
            chartPower_NKH.TabIndex = 1;
            chartPower_NKH.Text = "chart1";
            // 
            // groupBoxMinMaxAvg_NKH
            // 
            groupBoxMinMaxAvg_NKH.Controls.Add(buttonStartValues_NKH);
            groupBoxMinMaxAvg_NKH.Controls.Add(buttonStopMinMaxAvg_NKH);
            groupBoxMinMaxAvg_NKH.Controls.Add(labelAvg_NKH);
            groupBoxMinMaxAvg_NKH.Controls.Add(labelMin_NKH);
            groupBoxMinMaxAvg_NKH.Controls.Add(labelMax_NKH);
            groupBoxMinMaxAvg_NKH.Controls.Add(textBoxAvg_NKH);
            groupBoxMinMaxAvg_NKH.Controls.Add(textBoxMin_NKH);
            groupBoxMinMaxAvg_NKH.Controls.Add(textBoxMax_NKH);
            groupBoxMinMaxAvg_NKH.Dock = DockStyle.Top;
            groupBoxMinMaxAvg_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMinMaxAvg_NKH.Location = new Point(0, 175);
            groupBoxMinMaxAvg_NKH.Margin = new Padding(3, 4, 3, 4);
            groupBoxMinMaxAvg_NKH.Name = "groupBoxMinMaxAvg_NKH";
            groupBoxMinMaxAvg_NKH.Padding = new Padding(3, 4, 3, 4);
            groupBoxMinMaxAvg_NKH.Size = new Size(304, 266);
            groupBoxMinMaxAvg_NKH.TabIndex = 1;
            groupBoxMinMaxAvg_NKH.TabStop = false;
            groupBoxMinMaxAvg_NKH.Text = "Поиск значений мощности:";
            // 
            // buttonStartValues_NKH
            // 
            buttonStartValues_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStartValues_NKH.Location = new Point(23, 173);
            buttonStartValues_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonStartValues_NKH.Name = "buttonStartValues_NKH";
            buttonStartValues_NKH.Size = new Size(181, 33);
            buttonStartValues_NKH.TabIndex = 10;
            buttonStartValues_NKH.Text = "Расчитать значения";
            buttonStartValues_NKH.UseVisualStyleBackColor = true;
            buttonStartValues_NKH.Click += buttonStartValues_NKH_Click;
            // 
            // buttonStopMinMaxAvg_NKH
            // 
            buttonStopMinMaxAvg_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStopMinMaxAvg_NKH.Location = new Point(23, 214);
            buttonStopMinMaxAvg_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonStopMinMaxAvg_NKH.Name = "buttonStopMinMaxAvg_NKH";
            buttonStopMinMaxAvg_NKH.Size = new Size(181, 33);
            buttonStopMinMaxAvg_NKH.TabIndex = 9;
            buttonStopMinMaxAvg_NKH.Text = "Прекратить расчеты";
            buttonStopMinMaxAvg_NKH.UseVisualStyleBackColor = true;
            buttonStopMinMaxAvg_NKH.Click += buttonStopMinMaxAvg_NKH_Click;
            // 
            // labelAvg_NKH
            // 
            labelAvg_NKH.AutoSize = true;
            labelAvg_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAvg_NKH.Location = new Point(24, 136);
            labelAvg_NKH.Name = "labelAvg_NKH";
            labelAvg_NKH.Size = new Size(62, 16);
            labelAvg_NKH.TabIndex = 8;
            labelAvg_NKH.Text = "Average:";
            // 
            // labelMin_NKH
            // 
            labelMin_NKH.AutoSize = true;
            labelMin_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMin_NKH.Location = new Point(33, 96);
            labelMin_NKH.Name = "labelMin_NKH";
            labelMin_NKH.Size = new Size(31, 16);
            labelMin_NKH.TabIndex = 7;
            labelMin_NKH.Text = "Min:";
            // 
            // labelMax_NKH
            // 
            labelMax_NKH.AutoSize = true;
            labelMax_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMax_NKH.Location = new Point(29, 50);
            labelMax_NKH.Name = "labelMax_NKH";
            labelMax_NKH.Size = new Size(35, 16);
            labelMax_NKH.TabIndex = 6;
            labelMax_NKH.Text = "Max:";
            // 
            // textBoxAvg_NKH
            // 
            textBoxAvg_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAvg_NKH.Location = new Point(92, 133);
            textBoxAvg_NKH.Margin = new Padding(3, 4, 3, 4);
            textBoxAvg_NKH.Name = "textBoxAvg_NKH";
            textBoxAvg_NKH.ReadOnly = true;
            textBoxAvg_NKH.Size = new Size(112, 22);
            textBoxAvg_NKH.TabIndex = 5;
            // 
            // textBoxMin_NKH
            // 
            textBoxMin_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxMin_NKH.Location = new Point(65, 90);
            textBoxMin_NKH.Margin = new Padding(3, 4, 3, 4);
            textBoxMin_NKH.Name = "textBoxMin_NKH";
            textBoxMin_NKH.ReadOnly = true;
            textBoxMin_NKH.Size = new Size(139, 22);
            textBoxMin_NKH.TabIndex = 4;
            // 
            // textBoxMax_NKH
            // 
            textBoxMax_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxMax_NKH.Location = new Point(65, 47);
            textBoxMax_NKH.Margin = new Padding(3, 4, 3, 4);
            textBoxMax_NKH.Name = "textBoxMax_NKH";
            textBoxMax_NKH.ReadOnly = true;
            textBoxMax_NKH.Size = new Size(139, 22);
            textBoxMax_NKH.TabIndex = 3;
            // 
            // groupBoxSearch_NKH
            // 
            groupBoxSearch_NKH.Controls.Add(buttonStopSearch_NKH);
            groupBoxSearch_NKH.Controls.Add(textBoxSearch_NKH);
            groupBoxSearch_NKH.Controls.Add(buttonSearch_NKH);
            groupBoxSearch_NKH.Controls.Add(textBoxFiltr_NKH);
            groupBoxSearch_NKH.Controls.Add(buttonFiltr_NKH);
            groupBoxSearch_NKH.Controls.Add(buttonCancelFiltr_NKH);
            groupBoxSearch_NKH.Dock = DockStyle.Top;
            groupBoxSearch_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxSearch_NKH.Location = new Point(0, 0);
            groupBoxSearch_NKH.Margin = new Padding(0);
            groupBoxSearch_NKH.Name = "groupBoxSearch_NKH";
            groupBoxSearch_NKH.Padding = new Padding(0);
            groupBoxSearch_NKH.Size = new Size(304, 175);
            groupBoxSearch_NKH.TabIndex = 0;
            groupBoxSearch_NKH.TabStop = false;
            groupBoxSearch_NKH.Text = "Поиск и фильтрация:";
            // 
            // buttonStopSearch_NKH
            // 
            buttonStopSearch_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStopSearch_NKH.Location = new Point(216, 43);
            buttonStopSearch_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonStopSearch_NKH.Name = "buttonStopSearch_NKH";
            buttonStopSearch_NKH.Size = new Size(40, 46);
            buttonStopSearch_NKH.TabIndex = 16;
            toolTipHelp_NKH.SetToolTip(buttonStopSearch_NKH, "Прекратить поиск.\r\nНажмите, чтобы прекратить поиск.\r\n");
            buttonStopSearch_NKH.UseVisualStyleBackColor = true;
            buttonStopSearch_NKH.Click += buttonStopSearch_NKH_Click;
            // 
            // textBoxSearch_NKH
            // 
            textBoxSearch_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch_NKH.Location = new Point(29, 26);
            textBoxSearch_NKH.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch_NKH.Name = "textBoxSearch_NKH";
            textBoxSearch_NKH.Size = new Size(181, 22);
            textBoxSearch_NKH.TabIndex = 11;
            textBoxSearch_NKH.TextChanged += textBoxSearch_NKH_TextChanged;
            // 
            // buttonSearch_NKH
            // 
            buttonSearch_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch_NKH.Location = new Point(29, 56);
            buttonSearch_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonSearch_NKH.Name = "buttonSearch_NKH";
            buttonSearch_NKH.Size = new Size(181, 33);
            buttonSearch_NKH.TabIndex = 12;
            buttonSearch_NKH.Text = "Начать поиск";
            buttonSearch_NKH.UseVisualStyleBackColor = true;
            buttonSearch_NKH.Click += buttonSearch_NKH_Click;
            // 
            // textBoxFiltr_NKH
            // 
            textBoxFiltr_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFiltr_NKH.Location = new Point(29, 97);
            textBoxFiltr_NKH.Margin = new Padding(3, 4, 3, 4);
            textBoxFiltr_NKH.Name = "textBoxFiltr_NKH";
            textBoxFiltr_NKH.Size = new Size(181, 22);
            textBoxFiltr_NKH.TabIndex = 13;
            textBoxFiltr_NKH.TextChanged += textBoxFiltr_NKH_TextChanged;
            // 
            // buttonFiltr_NKH
            // 
            buttonFiltr_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFiltr_NKH.Location = new Point(29, 127);
            buttonFiltr_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonFiltr_NKH.Name = "buttonFiltr_NKH";
            buttonFiltr_NKH.Size = new Size(181, 33);
            buttonFiltr_NKH.TabIndex = 14;
            buttonFiltr_NKH.Text = "Фильтрация";
            buttonFiltr_NKH.UseVisualStyleBackColor = true;
            buttonFiltr_NKH.Click += buttonFiltr_NKH_Click;
            // 
            // buttonCancelFiltr_NKH
            // 
            buttonCancelFiltr_NKH.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancelFiltr_NKH.Location = new Point(216, 114);
            buttonCancelFiltr_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonCancelFiltr_NKH.Name = "buttonCancelFiltr_NKH";
            buttonCancelFiltr_NKH.Size = new Size(40, 46);
            buttonCancelFiltr_NKH.TabIndex = 15;
            toolTipHelp_NKH.SetToolTip(buttonCancelFiltr_NKH, "Прекратить фильтрацию.\r\nНажмите, чтобы прекратить фильтрацию");
            buttonCancelFiltr_NKH.UseVisualStyleBackColor = true;
            buttonCancelFiltr_NKH.Click += buttonCancelFiltr_NKH_Click;
            // 
            // toolTipHelp_NKH
            // 
            toolTipHelp_NKH.IsBalloon = true;
            // 
            // openFileDialog_NKH
            // 
            openFileDialog_NKH.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 885);
            Controls.Add(panelDataBase_NKH);
            Controls.Add(panelSort_NKH);
            Controls.Add(panelButtons_NKH);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1496, 932);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Вариант 1 | Project | Назарова К.Х.";
            Load += FormMain_Load;
            panelButtons_NKH.ResumeLayout(false);
            panelButtons_NKH.PerformLayout();
            panelDataBase_NKH.ResumeLayout(false);
            groupBoxDataBase_NKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataBase_NKH).EndInit();
            panelSort_NKH.ResumeLayout(false);
            groupBoxAdd_NKH.ResumeLayout(false);
            groupBoxFunc_NKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPower_NKH).EndInit();
            groupBoxMinMaxAvg_NKH.ResumeLayout(false);
            groupBoxMinMaxAvg_NKH.PerformLayout();
            groupBoxSearch_NKH.ResumeLayout(false);
            groupBoxSearch_NKH.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_NKH;
        private Button buttonCancelChanges_NKH;
        private Button buttonCharPie_NKH;
        private Button buttonDelete_NKH;
        private Button buttonOpenFile_NKH;
        private Button buttonSaveFile_NKH;
        private Button buttonHelp_NKH;
        private Label LabelTitle_NKH;
        private Panel panelDataBase_NKH;
        private Panel panelSort_NKH;
        private GroupBox groupBoxAdd_NKH;
        private Button buttonDeleteRow_NKH;
        private Button buttonAdd_NKH;
        private GroupBox groupBoxFunc_NKH;
        private Button buttonDeleteChart_NKH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPower_NKH;
        private GroupBox groupBoxMinMaxAvg_NKH;
        private Button buttonStartValues_NKH;
        private Button buttonStopMinMaxAvg_NKH;
        private Label labelAvg_NKH;
        private Label labelMin_NKH;
        private Label labelMax_NKH;
        private TextBox textBoxAvg_NKH;
        private TextBox textBoxMin_NKH;
        private TextBox textBoxMax_NKH;
        private ToolTip toolTipHelp_NKH;
        private GroupBox groupBoxDataBase_NKH;
        private Label LabelTiitle_NKH;
        private DataGridView dataGridViewDataBase_NKH;
        private GroupBox groupBoxSearch_NKH;
        private TextBox textBoxSearch_NKH;
        private Button buttonSearch_NKH;
        private TextBox textBoxFiltr_NKH;
        private Button buttonFiltr_NKH;
        private Button buttonCancelFiltr_NKH;
        private Button buttonStopSearch_NKH;
        private OpenFileDialog openFileDialog_NKH;
        private SaveFileDialog saveFileDialog_NKH;
    }
}
