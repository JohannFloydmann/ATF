namespace project
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUp_palette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.loginField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.signUpLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nameField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.surnameField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.enterButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.emailField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.numberField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.backArrowPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUp_palette
            // 
            this.SignUp_palette.ButtonSpecs.FormClose.Image = global::project.Properties.Resources.mc_red;
            this.SignUp_palette.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::project.Properties.Resources.mc_red;
            this.SignUp_palette.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::project.Properties.Resources.sign_error_icon;
            this.SignUp_palette.ButtonSpecs.FormClose.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Auto;
            this.SignUp_palette.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form;
            this.SignUp_palette.ButtonSpecs.FormMax.Image = global::project.Properties.Resources.mc_green;
            this.SignUp_palette.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::project.Properties.Resources.mc_green;
            this.SignUp_palette.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::project.Properties.Resources.mc_green;
            this.SignUp_palette.ButtonSpecs.FormMin.Image = global::project.Properties.Resources.mc_yellw;
            this.SignUp_palette.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::project.Properties.Resources.mc_yellw;
            this.SignUp_palette.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::project.Properties.Resources.mc_yellw;
            this.SignUp_palette.ButtonSpecs.FormRestore.Image = global::project.Properties.Resources.mc_green;
            this.SignUp_palette.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::project.Properties.Resources.mc_green;
            this.SignUp_palette.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::project.Properties.Resources.mc_green;
            this.SignUp_palette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignUp_palette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.SignUp_palette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignUp_palette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.SignUp_palette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignUp_palette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.SignUp_palette.ButtonStyles.ButtonFormClose.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.SignUp_palette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignUp_palette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.SignUp_palette.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.SignUp_palette.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.SignUp_palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.SignUp_palette.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SignUp_palette.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 10;
            this.SignUp_palette.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.SignUp_palette.HeaderStyles.HeaderForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SignUp_palette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignUp_palette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            this.SignUp_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SignUp_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SignUp_palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // loginField
            // 
            this.loginField.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.loginField.Location = new System.Drawing.Point(93, 377);
            this.loginField.MaxLength = 30;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(300, 43);
            this.loginField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.loginField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.loginField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.loginField.StateCommon.Border.ColorAngle = 45F;
            this.loginField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.loginField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginField.StateCommon.Border.Rounding = 10;
            this.loginField.StateCommon.Border.Width = 2;
            this.loginField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.loginField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.loginField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.loginField.TabIndex = 5;
            this.loginField.Text = "Логин";
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // passwordField
            // 
            this.passwordField.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.passwordField.Location = new System.Drawing.Point(93, 428);
            this.passwordField.MaxLength = 20;
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(300, 43);
            this.passwordField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.passwordField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.passwordField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.passwordField.StateCommon.Border.ColorAngle = 45F;
            this.passwordField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.passwordField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordField.StateCommon.Border.Rounding = 10;
            this.passwordField.StateCommon.Border.Width = 2;
            this.passwordField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.passwordField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.passwordField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.passwordField.TabIndex = 6;
            this.passwordField.Text = "Пароль";
            this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            // 
            // signUpLabel
            // 
            this.signUpLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signUpLabel.Location = new System.Drawing.Point(77, 40);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(331, 70);
            this.signUpLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.signUpLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.signUpLabel.StateCommon.ShortText.ColorAngle = 45F;
            this.signUpLabel.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.signUpLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.signUpLabel.TabIndex = 4;
            this.signUpLabel.Values.Text = "Регистрация";
            // 
            // nameField
            // 
            this.nameField.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.nameField.Location = new System.Drawing.Point(93, 155);
            this.nameField.MaxLength = 30;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(300, 43);
            this.nameField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.nameField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.nameField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.nameField.StateCommon.Border.ColorAngle = 45F;
            this.nameField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.nameField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nameField.StateCommon.Border.Rounding = 10;
            this.nameField.StateCommon.Border.Width = 2;
            this.nameField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.nameField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.nameField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.nameField.TabIndex = 1;
            this.nameField.Text = "Имя";
            this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
            // 
            // surnameField
            // 
            this.surnameField.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.surnameField.Location = new System.Drawing.Point(93, 206);
            this.surnameField.MaxLength = 30;
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(300, 43);
            this.surnameField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.surnameField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.surnameField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.surnameField.StateCommon.Border.ColorAngle = 45F;
            this.surnameField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.surnameField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.surnameField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.surnameField.StateCommon.Border.Rounding = 10;
            this.surnameField.StateCommon.Border.Width = 2;
            this.surnameField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.surnameField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.surnameField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.surnameField.TabIndex = 2;
            this.surnameField.Text = "Фамилия";
            this.surnameField.Enter += new System.EventHandler(this.surnameField_Enter);
            this.surnameField.Leave += new System.EventHandler(this.surnameField_Leave);
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Location = new System.Drawing.Point(93, 534);
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
            this.enterButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.enterButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.enterButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.enterButton.Size = new System.Drawing.Size(300, 65);
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
            this.enterButton.Values.Text = "Зарегистрироваться";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // emailField
            // 
            this.emailField.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.emailField.Location = new System.Drawing.Point(93, 266);
            this.emailField.MaxLength = 30;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(300, 43);
            this.emailField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.emailField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.emailField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.emailField.StateCommon.Border.ColorAngle = 45F;
            this.emailField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.emailField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.emailField.StateCommon.Border.Rounding = 10;
            this.emailField.StateCommon.Border.Width = 2;
            this.emailField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.emailField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.emailField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.emailField.TabIndex = 3;
            this.emailField.Text = "Email";
            this.emailField.Enter += new System.EventHandler(this.emailField_Enter);
            this.emailField.Leave += new System.EventHandler(this.emailField_Leave);
            // 
            // numberField
            // 
            this.numberField.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.numberField.Location = new System.Drawing.Point(93, 317);
            this.numberField.MaxLength = 11;
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(300, 43);
            this.numberField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.numberField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.numberField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.numberField.StateCommon.Border.ColorAngle = 45F;
            this.numberField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.numberField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numberField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.numberField.StateCommon.Border.Rounding = 10;
            this.numberField.StateCommon.Border.Width = 2;
            this.numberField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.numberField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.numberField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.numberField.TabIndex = 4;
            this.numberField.Text = "Номер телефона";
            this.numberField.Enter += new System.EventHandler(this.numberField_Enter);
            this.numberField.Leave += new System.EventHandler(this.numberField_Leave);
            // 
            // backArrowPicture
            // 
            this.backArrowPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backArrowPicture.Image = global::project.Properties.Resources.backArrow;
            this.backArrowPicture.Location = new System.Drawing.Point(12, 12);
            this.backArrowPicture.Name = "backArrowPicture";
            this.backArrowPicture.Size = new System.Drawing.Size(39, 30);
            this.backArrowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrowPicture.TabIndex = 8;
            this.backArrowPicture.TabStop = false;
            this.backArrowPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.backArrowPicture);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Palette = this.SignUp_palette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATF Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette SignUp_palette;
        internal ComponentFactory.Krypton.Toolkit.KryptonTextBox loginField;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel signUpLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton enterButton;
        private System.Windows.Forms.PictureBox backArrowPicture;
        internal ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordField;
        protected internal ComponentFactory.Krypton.Toolkit.KryptonTextBox nameField;
        protected internal ComponentFactory.Krypton.Toolkit.KryptonTextBox surnameField;
        protected internal ComponentFactory.Krypton.Toolkit.KryptonTextBox emailField;
        protected internal ComponentFactory.Krypton.Toolkit.KryptonTextBox numberField;
    }
}