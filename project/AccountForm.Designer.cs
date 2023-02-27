namespace project
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.LoginForm_palette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Лич = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currentPasswordField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.enterButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backArrowPicture = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginForm_palette
            // 
            this.LoginForm_palette.ButtonSpecs.FormClose.Image = global::project.Properties.Resources.mc_red;
            this.LoginForm_palette.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::project.Properties.Resources.mc_red;
            this.LoginForm_palette.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::project.Properties.Resources.sign_error_icon;
            this.LoginForm_palette.ButtonSpecs.FormClose.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Auto;
            this.LoginForm_palette.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form;
            this.LoginForm_palette.ButtonSpecs.FormMax.Image = global::project.Properties.Resources.mc_green;
            this.LoginForm_palette.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::project.Properties.Resources.mc_green;
            this.LoginForm_palette.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::project.Properties.Resources.mc_green;
            this.LoginForm_palette.ButtonSpecs.FormMin.Image = global::project.Properties.Resources.mc_yellw;
            this.LoginForm_palette.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::project.Properties.Resources.mc_yellw;
            this.LoginForm_palette.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::project.Properties.Resources.mc_yellw;
            this.LoginForm_palette.ButtonSpecs.FormRestore.Image = global::project.Properties.Resources.mc_green;
            this.LoginForm_palette.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::project.Properties.Resources.mc_green;
            this.LoginForm_palette.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::project.Properties.Resources.mc_green;
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.LoginForm_palette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginForm_palette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.LoginForm_palette.ButtonStyles.ButtonFormClose.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.LoginForm_palette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginForm_palette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.LoginForm_palette.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.LoginForm_palette.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.LoginForm_palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.LoginForm_palette.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.LoginForm_palette.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 10;
            this.LoginForm_palette.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.LoginForm_palette.HeaderStyles.HeaderForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.LoginForm_palette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginForm_palette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            this.LoginForm_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginForm_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginForm_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Лич
            // 
            this.Лич.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Лич.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Лич.Location = new System.Drawing.Point(131, -18);
            this.Лич.Name = "Лич";
            this.Лич.Size = new System.Drawing.Size(223, 70);
            this.Лич.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.Лич.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.Лич.StateCommon.ShortText.ColorAngle = 45F;
            this.Лич.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.Лич.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Лич.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.Лич.TabIndex = 11;
            this.Лич.Values.Text = "Аккаунт";
            // 
            // currentPasswordField
            // 
            this.currentPasswordField.Location = new System.Drawing.Point(12, 606);
            this.currentPasswordField.MaxLength = 30;
            this.currentPasswordField.Name = "currentPasswordField";
            this.currentPasswordField.Size = new System.Drawing.Size(300, 43);
            this.currentPasswordField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.currentPasswordField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.currentPasswordField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.currentPasswordField.StateCommon.Border.ColorAngle = 45F;
            this.currentPasswordField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.currentPasswordField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.currentPasswordField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.currentPasswordField.StateCommon.Border.Rounding = 10;
            this.currentPasswordField.StateCommon.Border.Width = 2;
            this.currentPasswordField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.currentPasswordField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.currentPasswordField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.currentPasswordField.TabIndex = 3;
            this.currentPasswordField.Text = "Текущий пароль";
            this.currentPasswordField.Enter += new System.EventHandler(this.currentPasswordField_Enter);
            this.currentPasswordField.Leave += new System.EventHandler(this.currentPasswordField_Leave);
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Location = new System.Drawing.Point(342, 606);
            this.enterButton.Name = "enterButton";
            this.enterButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.enterButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.enterButton.OverrideDefault.Back.ColorAngle = 45F;
            this.enterButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.enterButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.enterButton.OverrideDefault.Border.ColorAngle = 45F;
            this.enterButton.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.enterButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.enterButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.enterButton.OverrideDefault.Border.Rounding = 10;
            this.enterButton.OverrideDefault.Border.Width = 1;
            this.enterButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.enterButton.Size = new System.Drawing.Size(130, 43);
            this.enterButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.enterButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.enterButton.StateCommon.Back.ColorAngle = 45F;
            this.enterButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.enterButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.enterButton.StateCommon.Border.ColorAngle = 45F;
            this.enterButton.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.enterButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.enterButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.enterButton.StateCommon.Border.Rounding = 10;
            this.enterButton.StateCommon.Border.Width = 1;
            this.enterButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.enterButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.enterButton.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.enterButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(40)))), ((int)(((byte)(3)))));
            this.enterButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(133)))), ((int)(((byte)(8)))));
            this.enterButton.StatePressed.Back.ColorAngle = 45F;
            this.enterButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(40)))), ((int)(((byte)(3)))));
            this.enterButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(133)))), ((int)(((byte)(8)))));
            this.enterButton.StatePressed.Border.ColorAngle = 45F;
            this.enterButton.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.enterButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.enterButton.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.enterButton.StatePressed.Border.Rounding = 10;
            this.enterButton.StatePressed.Border.Width = 1;
            this.enterButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.enterButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.enterButton.StateTracking.Back.ColorAngle = 45F;
            this.enterButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.enterButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.enterButton.StateTracking.Border.ColorAngle = 45F;
            this.enterButton.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.enterButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.enterButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.enterButton.StateTracking.Border.Rounding = 10;
            this.enterButton.StateTracking.Border.Width = 1;
            this.enterButton.TabIndex = 0;
            this.enterButton.Values.Text = "Изменить";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // backArrowPicture
            // 
            this.backArrowPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backArrowPicture.Image = global::project.Properties.Resources.backArrow;
            this.backArrowPicture.Location = new System.Drawing.Point(13, 7);
            this.backArrowPicture.Name = "backArrowPicture";
            this.backArrowPicture.Size = new System.Drawing.Size(39, 30);
            this.backArrowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrowPicture.TabIndex = 12;
            this.backArrowPicture.TabStop = false;
            this.backArrowPicture.Click += new System.EventHandler(this.backArrowPicture_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPanel.Location = new System.Drawing.Point(-6, 53);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(513, 531);
            this.containerPanel.TabIndex = 0;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.currentPasswordField);
            this.Controls.Add(this.backArrowPicture);
            this.Controls.Add(this.Лич);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountForm";
            this.Palette = this.LoginForm_palette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATF Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette LoginForm_palette;
        private System.Windows.Forms.PictureBox backArrowPicture;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Лич;
        internal ComponentFactory.Krypton.Toolkit.KryptonTextBox currentPasswordField;
        private ComponentFactory.Krypton.Toolkit.KryptonButton enterButton;
        private System.Windows.Forms.FlowLayoutPanel containerPanel;
    }
}