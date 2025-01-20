using Tyuiu.NazarovaKH.Sprint7.Project.V1.Lib;
using System.Text;

namespace Tyuiu.NazarovaKH.Sprint7.Project.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_NKH.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_NKH.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        public string openFilePath;
        public int column, rows;
        bool issemicolon = true;
        private void buttonCharPie_NKH_Click(object sender, EventArgs e)
        {
            try
            {
                chartPower_NKH.Series[0].Points.Clear();
                if (rows <= 1)
                {
                    MessageBox.Show("Нет данных для построения диаграммы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<string> Brand = new List<string>();
                List<int> PowerCol = new List<int>();
                List<string> errorRows = new List<string>();

                for (int i = 1; i < dataGridViewDataBase_NKH.Rows.Count; i++)
                {
                    if (dataGridViewDataBase_NKH.Rows[i].Cells[11].Value != null && dataGridViewDataBase_NKH.Rows[i].Cells[10].Value != null)
                    {
                        if (int.TryParse(dataGridViewDataBase_NKH.Rows[i].Cells[11].Value.ToString().Trim(), out int power))
                        {
                            PowerCol.Add(power);
                            Brand.Add(dataGridViewDataBase_NKH.Rows[i].Cells[10].Value.ToString().Trim());
                        }
                        else
                        {
                            errorRows.Add($"Строка {i + 1}: Неверный формат мощности.");
                            continue;
                        }
                    }
                    else
                    {
                        errorRows.Add($"Строка {i + 1}: Пропущены данные в столбцах 10 или 11.");
                        continue;
                    }
                }
                if (errorRows.Count > 0)
                {
                    MessageBox.Show($"Обнаружены ошибки при обработке данных:\n{string.Join("\n", errorRows)}", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Brand.Count == 0)
                {
                    MessageBox.Show("Нет корректных данных для построения диаграммы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string[] Brand1 = Brand.Distinct().ToArray();
                for (int i = 0; i < Brand1.Length; i++)
                {
                    int sumPower = 0;
                    int count = 0;
                    for (int j = 0; j < Brand.Count; j++)
                    {
                        if (Brand[j] == Brand1[i])
                        {
                            sumPower += PowerCol[j];
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        chartPower_NKH.Series[0].Points.AddXY(Brand1[i], sumPower / count);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось построить диаграмму: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonSaveFile_NKH.Enabled = false;
            buttonDelete_NKH.Enabled = false;
            textBoxSearch_NKH.Enabled = false;
            buttonCancelChanges_NKH.Enabled = false;
            textBoxAvg_NKH.Enabled = false;
            textBoxMax_NKH.Enabled = false;
            textBoxMin_NKH.Enabled = false;
            buttonStopMinMaxAvg_NKH.Enabled = false;
            buttonSearch_NKH.Enabled = false;
            buttonStartValues_NKH.Enabled = false;
            buttonAdd_NKH.Enabled = false;
            buttonDeleteRow_NKH.Enabled = false;
            buttonCharPie_NKH.Enabled = false;
            textBoxFiltr_NKH.Enabled = false;
            buttonFiltr_NKH.Enabled = false;
            buttonDeleteChart_NKH.Enabled = false;
            buttonCancelFiltr_NKH.Enabled = false;
            buttonStopSearch_NKH.Enabled = false;
        }

        private void buttonCancelChanges_NKH_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_NKH.Rows.Clear();
            if (!string.IsNullOrEmpty(openFilePath))
            {
                if (!issemicolon)
                {
                    try
                    {
                        string[] firstLine = File.ReadAllLines(openFilePath, Encoding.UTF8).FirstOrDefault()?.Split(',');
                        if (firstLine != null)
                        {
                            column = firstLine.Length;
                        }
                        else
                        {
                            MessageBox.Show("Файл пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        dataGridViewDataBase_NKH.ColumnCount = column;
                        using (var reader = new StreamReader(openFilePath))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(',');

                                dataGridViewDataBase_NKH.Rows.Add(values);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        string[] firstLine = File.ReadAllLines(openFilePath, Encoding.UTF8).FirstOrDefault()?.Split(';');
                        if (firstLine != null)
                        {
                            column = firstLine.Length;
                        }
                        else
                        {
                            MessageBox.Show("Файл пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        dataGridViewDataBase_NKH.ColumnCount = column;
                        using (var reader = new StreamReader(openFilePath))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                dataGridViewDataBase_NKH.Rows.Add(values);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                rows = dataGridViewDataBase_NKH.Rows.Count;
                dataGridViewDataBase_NKH.Rows[0].Cells[0].Selected = false;
            }
        }

        private void buttonOpenFile_NKH_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_NKH.Rows.Clear();
            if (string.IsNullOrEmpty(openFilePath))
            {
                if (!issemicolon)
                {
                    try
                    {
                        dataGridViewDataBase_NKH.AllowUserToAddRows = false;
                        openFileDialog_NKH.ShowDialog();
                        openFilePath = openFileDialog_NKH.FileName;
                        if (!string.IsNullOrEmpty(openFilePath))
                        {
                            string[] firstLine = File.ReadAllLines(openFilePath, Encoding.UTF8).FirstOrDefault()?.Split(',');
                            if (firstLine != null)
                            {
                                column = firstLine.Length;
                            }
                            else
                            {
                                MessageBox.Show("Файл пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            dataGridViewDataBase_NKH.ColumnCount = column;
                            using (var reader = new StreamReader(openFilePath))
                            {
                                while (!reader.EndOfStream)
                                {
                                    var line = reader.ReadLine();
                                    var values = line.Split(',');
                                    dataGridViewDataBase_NKH.Rows.Add(values);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вы не выбрали файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Выбран неверный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        openFileDialog_NKH.ShowDialog();
                        openFilePath = openFileDialog_NKH.FileName;
                        if (!string.IsNullOrEmpty(openFilePath))
                        {
                            string[] firstLine = File.ReadAllLines(openFilePath, Encoding.UTF8).FirstOrDefault()?.Split(';');
                            if (firstLine != null)
                            {
                                column = firstLine.Length;
                            }
                            else
                            {
                                MessageBox.Show("Файл пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            dataGridViewDataBase_NKH.AllowUserToAddRows = false;
                            dataGridViewDataBase_NKH.ColumnCount = column;
                            using (var reader = new StreamReader(openFilePath))
                            {
                                while (!reader.EndOfStream)
                                {
                                    var line = reader.ReadLine();
                                    var values = line.Split(';');
                                    dataGridViewDataBase_NKH.Rows.Add(values);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вы не выбрали файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Выбран неверный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                rows = dataGridViewDataBase_NKH.Rows.Count;

                if (rows > 0)
                {
                    dataGridViewDataBase_NKH.Rows[0].Cells[0].Selected = false;

                    buttonSaveFile_NKH.Enabled = true;
                    buttonDelete_NKH.Enabled = true;
                    textBoxSearch_NKH.Enabled = true;
                    buttonCancelChanges_NKH.Enabled = true;
                    textBoxAvg_NKH.Enabled = true;
                    textBoxMax_NKH.Enabled = true;
                    textBoxMin_NKH.Enabled = true;
                    buttonStopMinMaxAvg_NKH.Enabled = true;
                    buttonSearch_NKH.Enabled = true;
                    buttonStartValues_NKH.Enabled = true;
                    buttonAdd_NKH.Enabled = true;
                    buttonDeleteRow_NKH.Enabled = true;
                    buttonCharPie_NKH.Enabled = true;
                    textBoxFiltr_NKH.Enabled = true;
                    buttonFiltr_NKH.Enabled = true;
                    buttonDeleteChart_NKH.Enabled = true;
                    buttonCancelFiltr_NKH.Enabled = true;
                    buttonStopSearch_NKH.Enabled = true;
                }
            }
        }

        private void checkBoxTochZap_NKH_CheckedChanged(object sender, EventArgs e)
        {
            if (issemicolon)
            {
                issemicolon = false;
            }
            else
            {
                issemicolon = true;
            }
        }

        private void buttonSaveFile_NKH_Click(object sender, EventArgs e)
        {
            if (!issemicolon)
            {
                try
                {
                    saveFileDialog_NKH.FileName = ".csv";
                    saveFileDialog_NKH.InitialDirectory = @":L";
                    if (saveFileDialog_NKH.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_NKH.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = dataGridViewDataBase_NKH.RowCount;
                        int columns = dataGridViewDataBase_NKH.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(dataGridViewDataBase_NKH.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(",");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    saveFileDialog_NKH.FileName = ".csv";
                    saveFileDialog_NKH.InitialDirectory = @":L";
                    if (saveFileDialog_NKH.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_NKH.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = dataGridViewDataBase_NKH.RowCount;
                        int columns = dataGridViewDataBase_NKH.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(dataGridViewDataBase_NKH.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(";");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_NKH_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_NKH.Rows.Clear();

            buttonSaveFile_NKH.Enabled = false;
            buttonDelete_NKH.Enabled = false;
            textBoxSearch_NKH.Enabled = false;
            buttonCancelChanges_NKH.Enabled = false;
            textBoxAvg_NKH.Enabled = false;
            textBoxMax_NKH.Enabled = false;
            textBoxMin_NKH.Enabled = false;
            buttonStopMinMaxAvg_NKH.Enabled = false;
            buttonSearch_NKH.Enabled = false;
            buttonStartValues_NKH.Enabled = false;
            buttonAdd_NKH.Enabled = false;
            buttonDeleteRow_NKH.Enabled = false;
            buttonCharPie_NKH.Enabled = false;
            textBoxFiltr_NKH.Enabled = false;
            buttonFiltr_NKH.Enabled = false;
            buttonDeleteChart_NKH.Enabled = false;
            buttonCancelFiltr_NKH.Enabled = false;
            buttonStopSearch_NKH.Enabled = false;
        }

        private void buttonHelp_NKH_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void panelDataBase_NKH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDataBase_NKH_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dataGridViewDataBase_NKH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridViewDataBase_NKH_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDataBase_NKH_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            int so = 1;
            if (dataGridViewDataBase_NKH.SortOrder == SortOrder.Ascending)
            {
                so = -1;
            }
            if (e.RowIndex1 == 0 || e.RowIndex2 == 0)
            {
                if (e.RowIndex1 == 0)
                {
                    e.SortResult = -so;
                }
                else
                {
                    e.SortResult = so;
                }
                e.Handled = true;
            }
        }

        private void buttonStartValues_NKH_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                if (rows <= 1)
                {
                    MessageBox.Show("Нет данных для расчета", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<int> PowerCol = new List<int>();
                List<string> errorRows = new List<string>();
                for (int i = 1; i < dataGridViewDataBase_NKH.Rows.Count; i++)
                {
                    if (dataGridViewDataBase_NKH.Rows[i].Cells[11].Value != null)
                    {
                        if (int.TryParse(dataGridViewDataBase_NKH.Rows[i].Cells[11].Value.ToString().Trim(), out int power))
                        {
                            PowerCol.Add(power);
                        }
                        else
                        {
                            errorRows.Add($"Строка {i + 1}: Неверный формат мощности.");
                            continue;
                        }
                    }
                    else
                    {
                        errorRows.Add($"Строка {i + 1}: Пропущены данные в столбце.");
                        continue;
                    }
                }
                if (errorRows.Count > 0)
                {
                    MessageBox.Show($"Обнаружены ошибки при обработке данных:\n{string.Join("\n", errorRows)}", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (PowerCol.Count == 0)
                {
                    MessageBox.Show("Нет корректных данных для расчета", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                textBoxMax_NKH.Text = ds.GetMaxValue(PowerCol.ToArray()).ToString();
                textBoxMin_NKH.Text = ds.GetMinValue(PowerCol.ToArray()).ToString();
                textBoxAvg_NKH.Text = ds.GetAvgValue(PowerCol.ToArray()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonStopMinMaxAvg_NKH_Click(object sender, EventArgs e)
        {
            textBoxAvg_NKH.Text = null;
            textBoxMax_NKH.Text = null;
            textBoxMin_NKH.Text = null;
        }

        private void buttonAdd_NKH_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_NKH.Rows.Add();
            rows++;
        }

        private void buttonDeleteRow_NKH_Click(object sender, EventArgs e)
        {
            if (dataGridViewDataBase_NKH.Rows.Count > 0)
            {
                dataGridViewDataBase_NKH.Rows.RemoveAt(dataGridViewDataBase_NKH.Rows.Count - 1);
                rows--;
            }
        }

        private void buttonDeleteChart_NKH_Click(object sender, EventArgs e)
        {
            chartPower_NKH.Series[0].Points.Clear();
        }

        private void textBoxSearch_NKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFiltr_NKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_NKH_Click(object sender, EventArgs e)
        {

        }

        private void buttonFiltr_NKH_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_NKH.ClearSelection();

            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (dataGridViewDataBase_NKH.Rows[i].Cells[j].Value != null && dataGridViewDataBase_NKH.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxFiltr_NKH.Text.ToLower()))
                        {
                            dataGridViewDataBase_NKH.Rows[i].Selected = true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStopSearch_NKH_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewDataBase_NKH.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (dataGridViewDataBase_NKH.Rows[i].Cells[j].Value != null && dataGridViewDataBase_NKH.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearch_NKH.Text.ToLower()))
                        {
                            dataGridViewDataBase_NKH.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelFiltr_NKH_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_NKH.ClearSelection();
            textBoxFiltr_NKH.Text = null;
        }

        private void checkBoxTochZap_NKH_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void labelZap_NKH_Click(object sender, EventArgs e)
        {

        }
        private void buttonStopSearch_YDS_Click_1(object sender, EventArgs e)
        {
            textBoxSearch_NKH.Text = null;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewDataBase_NKH.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
    }
}
