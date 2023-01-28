namespace project.historyControls
{
    partial class Transfers
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
            this.transfersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // transfersPanel
            // 
            this.transfersPanel.AutoScroll = true;
            this.transfersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transfersPanel.Location = new System.Drawing.Point(0, 0);
            this.transfersPanel.Name = "transfersPanel";
            this.transfersPanel.Size = new System.Drawing.Size(460, 561);
            this.transfersPanel.TabIndex = 9;
            // 
            // Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.transfersPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Transfers";
            this.Size = new System.Drawing.Size(460, 561);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel transfersPanel;
    }
}
