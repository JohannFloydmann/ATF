namespace project.historyControls
{
    partial class Transactions
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.transactionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // transactionPanel
            // 
            this.transactionPanel.AutoScroll = true;
            this.transactionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionPanel.Location = new System.Drawing.Point(0, 0);
            this.transactionPanel.Name = "transactionPanel";
            this.transactionPanel.Size = new System.Drawing.Size(460, 561);
            this.transactionPanel.TabIndex = 10;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.transactionPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(460, 561);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel transactionPanel;
    }
}
