namespace VSC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Open_Button = new System.Windows.Forms.Button();
            this.Info_TextBox = new System.Windows.Forms.TextBox();
            this.Table_DataGridView = new System.Windows.Forms.DataGridView();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Result_richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_Button
            // 
            this.Open_Button.Location = new System.Drawing.Point(41, 100);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(681, 34);
            this.Open_Button.TabIndex = 0;
            this.Open_Button.Text = "Открыть файл";
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // Info_TextBox
            // 
            this.Info_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Info_TextBox.Location = new System.Drawing.Point(41, 49);
            this.Info_TextBox.Name = "Info_TextBox";
            this.Info_TextBox.Size = new System.Drawing.Size(681, 34);
            this.Info_TextBox.TabIndex = 1;
            // 
            // Table_DataGridView
            // 
            this.Table_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_DataGridView.Location = new System.Drawing.Point(41, 155);
            this.Table_DataGridView.Name = "Table_DataGridView";
            this.Table_DataGridView.RowHeadersWidth = 51;
            this.Table_DataGridView.RowTemplate.Height = 24;
            this.Table_DataGridView.Size = new System.Drawing.Size(681, 497);
            this.Table_DataGridView.TabIndex = 2;
            // 
            // Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart.Legends.Add(legend3);
            this.Chart.Location = new System.Drawing.Point(808, 29);
            this.Chart.Name = "Chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(728, 299);
            this.Chart.TabIndex = 3;
            this.Chart.Text = "Chart";
            // 
            // Result_richTextBox
            // 
            this.Result_richTextBox.Location = new System.Drawing.Point(808, 362);
            this.Result_richTextBox.Name = "Result_richTextBox";
            this.Result_richTextBox.Size = new System.Drawing.Size(728, 290);
            this.Result_richTextBox.TabIndex = 4;
            this.Result_richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 697);
            this.Controls.Add(this.Result_richTextBox);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Table_DataGridView);
            this.Controls.Add(this.Info_TextBox);
            this.Controls.Add(this.Open_Button);
            this.Name = "Form1";
            this.Text = "Статистика Саши и Алисы";
            ((System.ComponentModel.ISupportInitialize)(this.Table_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_Button;
        private System.Windows.Forms.TextBox Info_TextBox;
        private System.Windows.Forms.DataGridView Table_DataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.RichTextBox Result_richTextBox;
    }
}

