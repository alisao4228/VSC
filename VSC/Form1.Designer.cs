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
            this.Open_Button = new System.Windows.Forms.Button();
            this.Info_TextBox = new System.Windows.Forms.TextBox();
            this.Table_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Table_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_Button
            // 
            this.Open_Button.Location = new System.Drawing.Point(41, 72);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(452, 29);
            this.Open_Button.TabIndex = 0;
            this.Open_Button.Text = "Открыть файл";
            this.Open_Button.UseVisualStyleBackColor = true;
            // 
            // Info_TextBox
            // 
            this.Info_TextBox.Location = new System.Drawing.Point(41, 29);
            this.Info_TextBox.Name = "Info_TextBox";
            this.Info_TextBox.Size = new System.Drawing.Size(452, 22);
            this.Info_TextBox.TabIndex = 1;
            // 
            // Table_DataGridView
            // 
            this.Table_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_DataGridView.Location = new System.Drawing.Point(41, 155);
            this.Table_DataGridView.Name = "Table_DataGridView";
            this.Table_DataGridView.RowHeadersWidth = 51;
            this.Table_DataGridView.RowTemplate.Height = 24;
            this.Table_DataGridView.Size = new System.Drawing.Size(452, 340);
            this.Table_DataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 507);
            this.Controls.Add(this.Table_DataGridView);
            this.Controls.Add(this.Info_TextBox);
            this.Controls.Add(this.Open_Button);
            this.Name = "Form1";
            this.Text = "Статистика Саши и Алисы";
            ((System.ComponentModel.ISupportInitialize)(this.Table_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_Button;
        private System.Windows.Forms.TextBox Info_TextBox;
        private System.Windows.Forms.DataGridView Table_DataGridView;
    }
}

