namespace project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainForm_palette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.infoPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.moneyLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.increasedMoneyLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.decreasedMoneyLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.moneyLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numberLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.transferButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.outButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backArrowPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoPanel)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.moneyLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainForm_palette
            // 
            this.MainForm_palette.ButtonSpecs.FormClose.Image = global::project.Properties.Resources.mc_red;
            this.MainForm_palette.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::project.Properties.Resources.mc_red;
            this.MainForm_palette.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::project.Properties.Resources.mc_red;
            this.MainForm_palette.ButtonSpecs.FormMax.Image = global::project.Properties.Resources.mc_green;
            this.MainForm_palette.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::project.Properties.Resources.mc_green;
            this.MainForm_palette.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::project.Properties.Resources.mc_green;
            this.MainForm_palette.ButtonSpecs.FormMin.Image = global::project.Properties.Resources.mc_yellw;
            this.MainForm_palette.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::project.Properties.Resources.mc_yellw;
            this.MainForm_palette.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::project.Properties.Resources.mc_yellw;
            this.MainForm_palette.ButtonSpecs.FormRestore.Image = global::project.Properties.Resources.mc_green;
            this.MainForm_palette.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::project.Properties.Resources.mc_green;
            this.MainForm_palette.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::project.Properties.Resources.mc_green;
            this.MainForm_palette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainForm_palette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.MainForm_palette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainForm_palette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.MainForm_palette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainForm_palette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.MainForm_palette.ButtonStyles.ButtonFormClose.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.MainForm_palette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainForm_palette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.MainForm_palette.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.MainForm_palette.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.MainForm_palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.MainForm_palette.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainForm_palette.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 10;
            this.MainForm_palette.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.MainForm_palette.HeaderStyles.HeaderForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainForm_palette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainForm_palette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            this.MainForm_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainForm_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainForm_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainForm_palette.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.LoginForm_palette_PalettePaint);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.moneyLayoutPanel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Controls.Add(this.moneyLabel);
            this.infoPanel.Controls.Add(this.numberLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(484, 211);
            this.infoPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.infoPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.infoPanel.StateCommon.ColorAngle = 20F;
            this.infoPanel.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.infoPanel.TabIndex = 0;
            this.infoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // moneyLayoutPanel
            // 
            this.moneyLayoutPanel.AutoSize = true;
            this.moneyLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.moneyLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLayoutPanel.Controls.Add(this.increasedMoneyLabel);
            this.moneyLayoutPanel.Controls.Add(this.decreasedMoneyLabel);
            this.moneyLayoutPanel.ForeColor = System.Drawing.Color.Bisque;
            this.moneyLayoutPanel.Location = new System.Drawing.Point(51, 168);
            this.moneyLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.moneyLayoutPanel.Name = "moneyLayoutPanel";
            this.moneyLayoutPanel.Size = new System.Drawing.Size(115, 30);
            this.moneyLayoutPanel.TabIndex = 1;
            // 
            // increasedMoneyLabel
            // 
            this.increasedMoneyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.increasedMoneyLabel.Location = new System.Drawing.Point(0, 0);
            this.increasedMoneyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.increasedMoneyLabel.Name = "increasedMoneyLabel";
            this.increasedMoneyLabel.Size = new System.Drawing.Size(49, 30);
            this.increasedMoneyLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkGreen;
            this.increasedMoneyLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(23)))));
            this.increasedMoneyLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increasedMoneyLabel.TabIndex = 3;
            this.increasedMoneyLabel.Values.Text = "↑ 10";
            this.increasedMoneyLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // decreasedMoneyLabel
            // 
            this.decreasedMoneyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.decreasedMoneyLabel.Location = new System.Drawing.Point(49, 0);
            this.decreasedMoneyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.decreasedMoneyLabel.Name = "decreasedMoneyLabel";
            this.decreasedMoneyLabel.Size = new System.Drawing.Size(66, 30);
            this.decreasedMoneyLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkRed;
            this.decreasedMoneyLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decreasedMoneyLabel.TabIndex = 4;
            this.decreasedMoneyLabel.Values.Text = "↓5000";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameLabel.Location = new System.Drawing.Point(100, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(312, 45);
            this.nameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.nameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Values.Text = "u_ name u_surname";
            this.nameLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.nameLabel_Paint);
            // 
            // moneyLabel
            // 
            this.moneyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.moneyLabel.Location = new System.Drawing.Point(36, 134);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(316, 47);
            this.moneyLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.moneyLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Values.Text = "₸ [u_currentMoney]";
            this.moneyLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.moneyLabel_Paint);
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numberLabel.Location = new System.Drawing.Point(177, 12);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(155, 27);
            this.numberLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.numberLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Values.Text = "u_phoneNumber";
            this.numberLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // transferButton
            // 
            this.transferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferButton.Location = new System.Drawing.Point(156, 513);
            this.transferButton.Name = "transferButton";
            this.transferButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.transferButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.transferButton.OverrideDefault.Back.ColorAngle = 45F;
            this.transferButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.transferButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.transferButton.OverrideDefault.Border.ColorAngle = 45F;
            this.transferButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.transferButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.transferButton.OverrideDefault.Border.Rounding = 10;
            this.transferButton.OverrideDefault.Border.Width = 2;
            this.transferButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.transferButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(81)))));
            this.transferButton.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            this.transferButton.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.transferButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.transferButton.Size = new System.Drawing.Size(171, 78);
            this.transferButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.transferButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.transferButton.StateCommon.Back.ColorAngle = 45F;
            this.transferButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.transferButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.transferButton.StateCommon.Border.ColorAngle = 45F;
            this.transferButton.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.transferButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.transferButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.transferButton.StateCommon.Border.Rounding = 10;
            this.transferButton.StateCommon.Border.Width = 2;
            this.transferButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.transferButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.transferButton.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.transferButton.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.transferButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transferButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.transferButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(35)))));
            this.transferButton.StatePressed.Back.ColorAngle = 45F;
            this.transferButton.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.transferButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.transferButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(35)))));
            this.transferButton.StatePressed.Border.ColorAngle = 45F;
            this.transferButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.transferButton.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.transferButton.StatePressed.Border.Rounding = 10;
            this.transferButton.StatePressed.Border.Width = 2;
            this.transferButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.transferButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.transferButton.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.transferButton.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.transferButton.StateTracking.Back.ColorAngle = 45F;
            this.transferButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.transferButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.transferButton.StateTracking.Border.ColorAngle = 45F;
            this.transferButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.transferButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.transferButton.StateTracking.Border.Rounding = 10;
            this.transferButton.StateTracking.Border.Width = 2;
            this.transferButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.transferButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.transferButton.TabIndex = 2;
            this.transferButton.Values.Text = "Перевод";
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // outButton
            // 
            this.outButton.AutoSize = true;
            this.outButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outButton.Location = new System.Drawing.Point(145, 407);
            this.outButton.Name = "outButton";
            this.outButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.outButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.outButton.OverrideDefault.Back.ColorAngle = 45F;
            this.outButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.outButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.outButton.OverrideDefault.Border.ColorAngle = 45F;
            this.outButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.outButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.outButton.OverrideDefault.Border.Rounding = 10;
            this.outButton.OverrideDefault.Border.Width = 2;
            this.outButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.outButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(81)))));
            this.outButton.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            this.outButton.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.outButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.outButton.Size = new System.Drawing.Size(196, 78);
            this.outButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.outButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.outButton.StateCommon.Back.ColorAngle = 45F;
            this.outButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.outButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.outButton.StateCommon.Border.ColorAngle = 45F;
            this.outButton.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.outButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.outButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.outButton.StateCommon.Border.Rounding = 10;
            this.outButton.StateCommon.Border.Width = 3;
            this.outButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.outButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.outButton.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.outButton.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.outButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.outButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(35)))));
            this.outButton.StatePressed.Back.ColorAngle = 45F;
            this.outButton.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.outButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.outButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(35)))));
            this.outButton.StatePressed.Border.ColorAngle = 45F;
            this.outButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.outButton.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.outButton.StatePressed.Border.Rounding = 10;
            this.outButton.StatePressed.Border.Width = 2;
            this.outButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.outButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.outButton.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.outButton.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.outButton.StateTracking.Back.ColorAngle = 45F;
            this.outButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.outButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.outButton.StateTracking.Border.ColorAngle = 45F;
            this.outButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.outButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.outButton.StateTracking.Border.Rounding = 10;
            this.outButton.StateTracking.Border.Width = 2;
            this.outButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.outButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.outButton.TabIndex = 3;
            this.outButton.Values.Text = "Снятие наличных";
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(156, 290);
            this.addButton.Name = "addButton";
            this.addButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.addButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.addButton.OverrideDefault.Back.ColorAngle = 45F;
            this.addButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.addButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.addButton.OverrideDefault.Border.ColorAngle = 45F;
            this.addButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addButton.OverrideDefault.Border.Rounding = 10;
            this.addButton.OverrideDefault.Border.Width = 2;
            this.addButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.addButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(81)))));
            this.addButton.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            this.addButton.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.addButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addButton.Size = new System.Drawing.Size(171, 78);
            this.addButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.addButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.addButton.StateCommon.Back.ColorAngle = 45F;
            this.addButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.addButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.addButton.StateCommon.Border.ColorAngle = 45F;
            this.addButton.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.addButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addButton.StateCommon.Border.Rounding = 10;
            this.addButton.StateCommon.Border.Width = 3;
            this.addButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.addButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.addButton.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.addButton.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.addButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.addButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(35)))));
            this.addButton.StatePressed.Back.ColorAngle = 45F;
            this.addButton.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.addButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.addButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(35)))));
            this.addButton.StatePressed.Border.ColorAngle = 45F;
            this.addButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addButton.StatePressed.Border.Rounding = 10;
            this.addButton.StatePressed.Border.Width = 2;
            this.addButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.addButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.addButton.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.addButton.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.addButton.StateTracking.Back.ColorAngle = 45F;
            this.addButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.addButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.addButton.StateTracking.Border.ColorAngle = 45F;
            this.addButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addButton.StateTracking.Border.Rounding = 10;
            this.addButton.StateTracking.Border.Width = 2;
            this.addButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.addButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(10)))));
            this.addButton.TabIndex = 4;
            this.addButton.Values.Text = "Пополнение";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backArrowPicture
            // 
            this.backArrowPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backArrowPicture.Image = global::project.Properties.Resources.backArrow;
            this.backArrowPicture.Location = new System.Drawing.Point(12, 223);
            this.backArrowPicture.Name = "backArrowPicture";
            this.backArrowPicture.Size = new System.Drawing.Size(39, 30);
            this.backArrowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrowPicture.TabIndex = 9;
            this.backArrowPicture.TabStop = false;
            this.backArrowPicture.Click += new System.EventHandler(this.backArrowPicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.backArrowPicture);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.infoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Palette = this.MainForm_palette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATF Bank";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.infoPanel)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.moneyLayoutPanel.ResumeLayout(false);
            this.moneyLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainForm_palette;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel infoPanel;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel numberLabel;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel moneyLabel;
        private System.Windows.Forms.FlowLayoutPanel moneyLayoutPanel;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel increasedMoneyLabel;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel decreasedMoneyLabel;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton transferButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton outButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
        private System.Windows.Forms.PictureBox backArrowPicture;
    }
}