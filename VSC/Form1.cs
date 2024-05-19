using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;

namespace VSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(openFileDialog.FileName); // Получаем имя файла без расширения
                Info_TextBox.Text = fileNameWithoutExtension;

                // Чтение данных из файла Excel и отображение в DataGridView
                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        // Используем AsDataSet для получения всех данных из Excel в DataSet
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                        });

                        // Берем первый лист и привязываем его к DataGridView
                        if (result.Tables.Count > 0)
                        {
                            DataTable dataTable = result.Tables[0];
                            Table_DataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
        }

        private void CreateChart(DataTable dataTable)
        {
            Chart.Series.Clear();
            Chart.ChartAreas.Clear();
            Chart.ChartAreas.Add(new ChartArea("MainArea"));

            var xColumn = dataTable.Columns[0];
            var numericColumns = dataTable.Columns.Cast<DataColumn>()
                                .Where(col => col != xColumn && (col.DataType == typeof(double) || col.DataType == typeof(int)))
                                .ToList();

            if (numericColumns.Count == 0)
            {
                MessageBox.Show("Не найдены числовые столбцы для построения графиков.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var numericColumn in numericColumns)
            {
                var series = new Series(numericColumn.ColumnName) { ChartType = SeriesChartType.Line };

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[xColumn] != DBNull.Value && row[numericColumn] != DBNull.Value)
                    {
                        if (double.TryParse(row[xColumn].ToString(), out double xValue) && double.TryParse(row[numericColumn].ToString(), out double yValue))
                        {
                            series.Points.AddXY(xValue, yValue);
                        }
                    }
                }

                Chart.Series.Add(series);
            }
        }

    }
}
