namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation1 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DragMain = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.Transition = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.aimfov = new System.Windows.Forms.Panel();
            this.AimlockXBypass = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AimlockXInject = new Guna.UI2.WinForms.Guna2GradientButton();
            this.aimfovleader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.settings = new Guna.UI2.WinForms.Guna2Button();
            this.aimassist = new System.Windows.Forms.Panel();
            this.AimAssistMedio = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AimAssistLento = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AimAssistRapido = new Guna.UI2.WinForms.Guna2GradientButton();
            this.aimassistleader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.otimizar = new System.Windows.Forms.Panel();
            this.OtimizaçãoTirarDelay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.otimizaçãoPCFAST = new Guna.UI2.WinForms.Guna2GradientButton();
            this.otimizarleader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Regedit = new System.Windows.Forms.Panel();
            this.RegeditAjustavel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RegeditUltimate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RegeditVip = new Guna.UI2.WinForms.Guna2GradientButton();
            this.regeditleader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Shadow = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.eliMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eliAimfov = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eliAimfov2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eliRegedit = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eliRegedit2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragAimFov = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragAimfov2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragReg = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragReg2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragOtimizar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragOtimizar2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragMenu = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.eliOtimizar = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eliOtimizar2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.EliAimAssist = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.EliAimassist2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragAimAssist = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragAimAssist2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.aimfov.SuspendLayout();
            this.aimfovleader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.aimassist.SuspendLayout();
            this.aimassistleader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.otimizar.SuspendLayout();
            this.otimizarleader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Regedit.SuspendLayout();
            this.regeditleader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DragMain
            // 
            this.DragMain.TargetControl = this;
            // 
            // Transition
            // 
            this.Transition.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Transition.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.siticoneControlBox1.BorderRadius = 5;
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(578, 1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 40;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click_1);
            // 
            // aimfov
            // 
            this.aimfov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.aimfov.Controls.Add(this.AimlockXBypass);
            this.aimfov.Controls.Add(this.AimlockXInject);
            this.aimfov.Controls.Add(this.aimfovleader);
            this.Transition.SetDecoration(this.aimfov, Siticone.UI.AnimatorNS.DecorationType.None);
            this.aimfov.Location = new System.Drawing.Point(331, 331);
            this.aimfov.Name = "aimfov";
            this.aimfov.Size = new System.Drawing.Size(239, 192);
            this.aimfov.TabIndex = 41;
            // 
            // AimlockXBypass
            // 
            this.AimlockXBypass.Animated = true;
            this.AimlockXBypass.BorderRadius = 20;
            this.AimlockXBypass.CheckedState.Parent = this.AimlockXBypass;
            this.AimlockXBypass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AimlockXBypass.CustomImages.Parent = this.AimlockXBypass;
            this.Transition.SetDecoration(this.AimlockXBypass, Siticone.UI.AnimatorNS.DecorationType.None);
            this.AimlockXBypass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimlockXBypass.FillColor2 = System.Drawing.Color.Purple;
            this.AimlockXBypass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimlockXBypass.ForeColor = System.Drawing.Color.White;
            this.AimlockXBypass.HoverState.FillColor = System.Drawing.Color.Purple;
            this.AimlockXBypass.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimlockXBypass.HoverState.Parent = this.AimlockXBypass;
            this.AimlockXBypass.Location = new System.Drawing.Point(27, 125);
            this.AimlockXBypass.Name = "AimlockXBypass";
            this.AimlockXBypass.ShadowDecoration.Parent = this.AimlockXBypass;
            this.AimlockXBypass.Size = new System.Drawing.Size(180, 45);
            this.AimlockXBypass.TabIndex = 44;
            this.AimlockXBypass.Text = "BYPASS";
            this.AimlockXBypass.Click += new System.EventHandler(this.AimlockXBypass_Click);
            // 
            // AimlockXInject
            // 
            this.AimlockXInject.Animated = true;
            this.AimlockXInject.BorderRadius = 20;
            this.AimlockXInject.CheckedState.Parent = this.AimlockXInject;
            this.AimlockXInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AimlockXInject.CustomImages.Parent = this.AimlockXInject;
            this.Transition.SetDecoration(this.AimlockXInject, Siticone.UI.AnimatorNS.DecorationType.None);
            this.AimlockXInject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimlockXInject.FillColor2 = System.Drawing.Color.Purple;
            this.AimlockXInject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimlockXInject.ForeColor = System.Drawing.Color.White;
            this.AimlockXInject.HoverState.FillColor = System.Drawing.Color.Purple;
            this.AimlockXInject.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimlockXInject.HoverState.Parent = this.AimlockXInject;
            this.AimlockXInject.Location = new System.Drawing.Point(27, 59);
            this.AimlockXInject.Name = "AimlockXInject";
            this.AimlockXInject.ShadowDecoration.Parent = this.AimlockXInject;
            this.AimlockXInject.Size = new System.Drawing.Size(180, 45);
            this.AimlockXInject.TabIndex = 43;
            this.AimlockXInject.Text = "INJECT";
            this.AimlockXInject.Click += new System.EventHandler(this.AimlockXInject_Click);
            // 
            // aimfovleader
            // 
            this.aimfovleader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.aimfovleader.Controls.Add(this.label2);
            this.aimfovleader.Controls.Add(this.pictureBox1);
            this.Transition.SetDecoration(this.aimfovleader, Siticone.UI.AnimatorNS.DecorationType.None);
            this.aimfovleader.Location = new System.Drawing.Point(0, 0);
            this.aimfovleader.Name = "aimfovleader";
            this.aimfovleader.Size = new System.Drawing.Size(239, 43);
            this.aimfovleader.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Transition.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "AIMLOCK X";
            // 
            // pictureBox1
            // 
            this.Transition.SetDecoration(this.pictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.pnMenu.Controls.Add(this.guna2Separator1);
            this.pnMenu.Controls.Add(this.guna2VSeparator1);
            this.pnMenu.Controls.Add(this.siticoneControlBox2);
            this.pnMenu.Controls.Add(this.guna2Button1);
            this.pnMenu.Controls.Add(this.settings);
            this.pnMenu.Controls.Add(this.aimassist);
            this.pnMenu.Controls.Add(this.otimizar);
            this.pnMenu.Controls.Add(this.Regedit);
            this.pnMenu.Controls.Add(this.aimfov);
            this.pnMenu.Controls.Add(this.siticoneControlBox1);
            this.Transition.SetDecoration(this.pnMenu, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pnMenu.Location = new System.Drawing.Point(4, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(624, 549);
            this.pnMenu.TabIndex = 42;
            // 
            // guna2Separator1
            // 
            this.Transition.SetDecoration(this.guna2Separator1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.Purple;
            this.guna2Separator1.Location = new System.Drawing.Point(60, 312);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(510, 10);
            this.guna2Separator1.TabIndex = 53;
            // 
            // guna2VSeparator1
            // 
            this.Transition.SetDecoration(this.guna2VSeparator1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Purple;
            this.guna2VSeparator1.Location = new System.Drawing.Point(309, 59);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 464);
            this.guna2VSeparator1.TabIndex = 52;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.siticoneControlBox2.BorderRadius = 5;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.siticoneControlBox2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneControlBox2.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(527, 1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 51;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.Transition.SetDecoration(this.guna2Button1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(441, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(45, 29);
            this.guna2Button1.TabIndex = 50;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // settings
            // 
            this.settings.BorderRadius = 5;
            this.settings.CheckedState.Parent = this.settings;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.CustomImages.Parent = this.settings;
            this.Transition.SetDecoration(this.settings, Siticone.UI.AnimatorNS.DecorationType.None);
            this.settings.FillColor = System.Drawing.Color.Transparent;
            this.settings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings.HoverState.Parent = this.settings;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(486, 2);
            this.settings.Name = "settings";
            this.settings.ShadowDecoration.Parent = this.settings;
            this.settings.Size = new System.Drawing.Size(45, 29);
            this.settings.TabIndex = 49;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // aimassist
            // 
            this.aimassist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.aimassist.Controls.Add(this.AimAssistMedio);
            this.aimassist.Controls.Add(this.AimAssistLento);
            this.aimassist.Controls.Add(this.AimAssistRapido);
            this.aimassist.Controls.Add(this.aimassistleader);
            this.Transition.SetDecoration(this.aimassist, Siticone.UI.AnimatorNS.DecorationType.None);
            this.aimassist.Location = new System.Drawing.Point(60, 59);
            this.aimassist.Name = "aimassist";
            this.aimassist.Size = new System.Drawing.Size(239, 246);
            this.aimassist.TabIndex = 46;
            // 
            // AimAssistMedio
            // 
            this.AimAssistMedio.Animated = true;
            this.AimAssistMedio.BorderRadius = 20;
            this.AimAssistMedio.CheckedState.Parent = this.AimAssistMedio;
            this.AimAssistMedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AimAssistMedio.CustomImages.Parent = this.AimAssistMedio;
            this.Transition.SetDecoration(this.AimAssistMedio, Siticone.UI.AnimatorNS.DecorationType.None);
            this.AimAssistMedio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimAssistMedio.FillColor2 = System.Drawing.Color.Purple;
            this.AimAssistMedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimAssistMedio.ForeColor = System.Drawing.Color.White;
            this.AimAssistMedio.HoverState.FillColor = System.Drawing.Color.Purple;
            this.AimAssistMedio.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimAssistMedio.HoverState.Parent = this.AimAssistMedio;
            this.AimAssistMedio.Location = new System.Drawing.Point(27, 118);
            this.AimAssistMedio.Name = "AimAssistMedio";
            this.AimAssistMedio.ShadowDecoration.Parent = this.AimAssistMedio;
            this.AimAssistMedio.Size = new System.Drawing.Size(180, 45);
            this.AimAssistMedio.TabIndex = 45;
            this.AimAssistMedio.Text = "MEDIO";
            this.AimAssistMedio.Click += new System.EventHandler(this.AimAssistMedio_Click);
            // 
            // AimAssistLento
            // 
            this.AimAssistLento.Animated = true;
            this.AimAssistLento.BorderRadius = 20;
            this.AimAssistLento.CheckedState.Parent = this.AimAssistLento;
            this.AimAssistLento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AimAssistLento.CustomImages.Parent = this.AimAssistLento;
            this.Transition.SetDecoration(this.AimAssistLento, Siticone.UI.AnimatorNS.DecorationType.None);
            this.AimAssistLento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimAssistLento.FillColor2 = System.Drawing.Color.Purple;
            this.AimAssistLento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimAssistLento.ForeColor = System.Drawing.Color.White;
            this.AimAssistLento.HoverState.FillColor = System.Drawing.Color.Purple;
            this.AimAssistLento.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimAssistLento.HoverState.Parent = this.AimAssistLento;
            this.AimAssistLento.Location = new System.Drawing.Point(27, 183);
            this.AimAssistLento.Name = "AimAssistLento";
            this.AimAssistLento.ShadowDecoration.Parent = this.AimAssistLento;
            this.AimAssistLento.Size = new System.Drawing.Size(180, 45);
            this.AimAssistLento.TabIndex = 44;
            this.AimAssistLento.Text = "LENTO";
            this.AimAssistLento.Click += new System.EventHandler(this.AimAssistLento_Click);
            // 
            // AimAssistRapido
            // 
            this.AimAssistRapido.Animated = true;
            this.AimAssistRapido.BorderRadius = 20;
            this.AimAssistRapido.CheckedState.Parent = this.AimAssistRapido;
            this.AimAssistRapido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AimAssistRapido.CustomImages.Parent = this.AimAssistRapido;
            this.Transition.SetDecoration(this.AimAssistRapido, Siticone.UI.AnimatorNS.DecorationType.None);
            this.AimAssistRapido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimAssistRapido.FillColor2 = System.Drawing.Color.Purple;
            this.AimAssistRapido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimAssistRapido.ForeColor = System.Drawing.Color.White;
            this.AimAssistRapido.HoverState.FillColor = System.Drawing.Color.Purple;
            this.AimAssistRapido.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.AimAssistRapido.HoverState.Parent = this.AimAssistRapido;
            this.AimAssistRapido.Location = new System.Drawing.Point(27, 56);
            this.AimAssistRapido.Name = "AimAssistRapido";
            this.AimAssistRapido.ShadowDecoration.Parent = this.AimAssistRapido;
            this.AimAssistRapido.Size = new System.Drawing.Size(180, 45);
            this.AimAssistRapido.TabIndex = 43;
            this.AimAssistRapido.Text = "RAPIDO";
            this.AimAssistRapido.Click += new System.EventHandler(this.AimAssistRapido_Click);
            // 
            // aimassistleader
            // 
            this.aimassistleader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.aimassistleader.Controls.Add(this.label5);
            this.aimassistleader.Controls.Add(this.pictureBox4);
            this.Transition.SetDecoration(this.aimassistleader, Siticone.UI.AnimatorNS.DecorationType.None);
            this.aimassistleader.Location = new System.Drawing.Point(0, 0);
            this.aimassistleader.Name = "aimassistleader";
            this.aimassistleader.Size = new System.Drawing.Size(239, 43);
            this.aimassistleader.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.Transition.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "AIM ASSIST";
            // 
            // pictureBox4
            // 
            this.Transition.SetDecoration(this.pictureBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // otimizar
            // 
            this.otimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.otimizar.Controls.Add(this.OtimizaçãoTirarDelay);
            this.otimizar.Controls.Add(this.otimizaçãoPCFAST);
            this.otimizar.Controls.Add(this.otimizarleader);
            this.Transition.SetDecoration(this.otimizar, Siticone.UI.AnimatorNS.DecorationType.None);
            this.otimizar.Location = new System.Drawing.Point(60, 331);
            this.otimizar.Name = "otimizar";
            this.otimizar.Size = new System.Drawing.Size(239, 192);
            this.otimizar.TabIndex = 45;
            // 
            // OtimizaçãoTirarDelay
            // 
            this.OtimizaçãoTirarDelay.Animated = true;
            this.OtimizaçãoTirarDelay.BorderRadius = 20;
            this.OtimizaçãoTirarDelay.CheckedState.Parent = this.OtimizaçãoTirarDelay;
            this.OtimizaçãoTirarDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OtimizaçãoTirarDelay.CustomImages.Parent = this.OtimizaçãoTirarDelay;
            this.Transition.SetDecoration(this.OtimizaçãoTirarDelay, Siticone.UI.AnimatorNS.DecorationType.None);
            this.OtimizaçãoTirarDelay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.OtimizaçãoTirarDelay.FillColor2 = System.Drawing.Color.Purple;
            this.OtimizaçãoTirarDelay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtimizaçãoTirarDelay.ForeColor = System.Drawing.Color.White;
            this.OtimizaçãoTirarDelay.HoverState.FillColor = System.Drawing.Color.Purple;
            this.OtimizaçãoTirarDelay.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.OtimizaçãoTirarDelay.HoverState.Parent = this.OtimizaçãoTirarDelay;
            this.OtimizaçãoTirarDelay.Location = new System.Drawing.Point(27, 125);
            this.OtimizaçãoTirarDelay.Name = "OtimizaçãoTirarDelay";
            this.OtimizaçãoTirarDelay.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.OtimizaçãoTirarDelay.ShadowDecoration.Parent = this.OtimizaçãoTirarDelay;
            this.OtimizaçãoTirarDelay.Size = new System.Drawing.Size(180, 45);
            this.OtimizaçãoTirarDelay.TabIndex = 44;
            this.OtimizaçãoTirarDelay.Text = "TIRAR DELAY";
            this.OtimizaçãoTirarDelay.Click += new System.EventHandler(this.OtimizaçãoTirarDelay_Click);
            // 
            // otimizaçãoPCFAST
            // 
            this.otimizaçãoPCFAST.Animated = true;
            this.otimizaçãoPCFAST.BorderRadius = 20;
            this.otimizaçãoPCFAST.CheckedState.Parent = this.otimizaçãoPCFAST;
            this.otimizaçãoPCFAST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otimizaçãoPCFAST.CustomImages.Parent = this.otimizaçãoPCFAST;
            this.Transition.SetDecoration(this.otimizaçãoPCFAST, Siticone.UI.AnimatorNS.DecorationType.None);
            this.otimizaçãoPCFAST.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.otimizaçãoPCFAST.FillColor2 = System.Drawing.Color.Purple;
            this.otimizaçãoPCFAST.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otimizaçãoPCFAST.ForeColor = System.Drawing.Color.White;
            this.otimizaçãoPCFAST.HoverState.FillColor = System.Drawing.Color.Purple;
            this.otimizaçãoPCFAST.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.otimizaçãoPCFAST.HoverState.Parent = this.otimizaçãoPCFAST;
            this.otimizaçãoPCFAST.Location = new System.Drawing.Point(27, 59);
            this.otimizaçãoPCFAST.Name = "otimizaçãoPCFAST";
            this.otimizaçãoPCFAST.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.otimizaçãoPCFAST.ShadowDecoration.Parent = this.otimizaçãoPCFAST;
            this.otimizaçãoPCFAST.Size = new System.Drawing.Size(180, 45);
            this.otimizaçãoPCFAST.TabIndex = 43;
            this.otimizaçãoPCFAST.Text = "PC FAST";
            this.otimizaçãoPCFAST.Click += new System.EventHandler(this.otimizaçãoPCFAST_Click);
            // 
            // otimizarleader
            // 
            this.otimizarleader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.otimizarleader.Controls.Add(this.label4);
            this.otimizarleader.Controls.Add(this.pictureBox3);
            this.Transition.SetDecoration(this.otimizarleader, Siticone.UI.AnimatorNS.DecorationType.None);
            this.otimizarleader.Location = new System.Drawing.Point(0, 0);
            this.otimizarleader.Name = "otimizarleader";
            this.otimizarleader.Size = new System.Drawing.Size(239, 43);
            this.otimizarleader.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Transition.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "OTIMIZAÇÃO";
            // 
            // pictureBox3
            // 
            this.Transition.SetDecoration(this.pictureBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Regedit
            // 
            this.Regedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Regedit.Controls.Add(this.RegeditAjustavel);
            this.Regedit.Controls.Add(this.RegeditUltimate);
            this.Regedit.Controls.Add(this.RegeditVip);
            this.Regedit.Controls.Add(this.regeditleader);
            this.Transition.SetDecoration(this.Regedit, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Regedit.Location = new System.Drawing.Point(331, 59);
            this.Regedit.Name = "Regedit";
            this.Regedit.Size = new System.Drawing.Size(239, 246);
            this.Regedit.TabIndex = 45;
            // 
            // RegeditAjustavel
            // 
            this.RegeditAjustavel.Animated = true;
            this.RegeditAjustavel.BorderRadius = 20;
            this.RegeditAjustavel.CheckedState.Parent = this.RegeditAjustavel;
            this.RegeditAjustavel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegeditAjustavel.CustomImages.Parent = this.RegeditAjustavel;
            this.Transition.SetDecoration(this.RegeditAjustavel, Siticone.UI.AnimatorNS.DecorationType.None);
            this.RegeditAjustavel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.RegeditAjustavel.FillColor2 = System.Drawing.Color.Purple;
            this.RegeditAjustavel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegeditAjustavel.ForeColor = System.Drawing.Color.White;
            this.RegeditAjustavel.HoverState.FillColor = System.Drawing.Color.Purple;
            this.RegeditAjustavel.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.RegeditAjustavel.HoverState.Parent = this.RegeditAjustavel;
            this.RegeditAjustavel.Location = new System.Drawing.Point(27, 183);
            this.RegeditAjustavel.Name = "RegeditAjustavel";
            this.RegeditAjustavel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.RegeditAjustavel.ShadowDecoration.Parent = this.RegeditAjustavel;
            this.RegeditAjustavel.Size = new System.Drawing.Size(180, 45);
            this.RegeditAjustavel.TabIndex = 45;
            this.RegeditAjustavel.Text = "AJUSTAVEL";
            this.RegeditAjustavel.Click += new System.EventHandler(this.RegeditAjustavel_Click);
            // 
            // RegeditUltimate
            // 
            this.RegeditUltimate.Animated = true;
            this.RegeditUltimate.BorderRadius = 20;
            this.RegeditUltimate.CheckedState.Parent = this.RegeditUltimate;
            this.RegeditUltimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegeditUltimate.CustomImages.Parent = this.RegeditUltimate;
            this.Transition.SetDecoration(this.RegeditUltimate, Siticone.UI.AnimatorNS.DecorationType.None);
            this.RegeditUltimate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.RegeditUltimate.FillColor2 = System.Drawing.Color.Purple;
            this.RegeditUltimate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegeditUltimate.ForeColor = System.Drawing.Color.White;
            this.RegeditUltimate.HoverState.FillColor = System.Drawing.Color.Purple;
            this.RegeditUltimate.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.RegeditUltimate.HoverState.Parent = this.RegeditUltimate;
            this.RegeditUltimate.Location = new System.Drawing.Point(27, 118);
            this.RegeditUltimate.Name = "RegeditUltimate";
            this.RegeditUltimate.ShadowDecoration.Parent = this.RegeditUltimate;
            this.RegeditUltimate.Size = new System.Drawing.Size(180, 45);
            this.RegeditUltimate.TabIndex = 44;
            this.RegeditUltimate.Text = "ULTIMATE";
            this.RegeditUltimate.Click += new System.EventHandler(this.RegeditUltimate_Click);
            // 
            // RegeditVip
            // 
            this.RegeditVip.Animated = true;
            this.RegeditVip.BorderRadius = 20;
            this.RegeditVip.CheckedState.Parent = this.RegeditVip;
            this.RegeditVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegeditVip.CustomImages.Parent = this.RegeditVip;
            this.Transition.SetDecoration(this.RegeditVip, Siticone.UI.AnimatorNS.DecorationType.None);
            this.RegeditVip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.RegeditVip.FillColor2 = System.Drawing.Color.Purple;
            this.RegeditVip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegeditVip.ForeColor = System.Drawing.Color.White;
            this.RegeditVip.HoverState.FillColor = System.Drawing.Color.Purple;
            this.RegeditVip.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.RegeditVip.HoverState.Parent = this.RegeditVip;
            this.RegeditVip.Location = new System.Drawing.Point(27, 56);
            this.RegeditVip.Name = "RegeditVip";
            this.RegeditVip.ShadowDecoration.Parent = this.RegeditVip;
            this.RegeditVip.Size = new System.Drawing.Size(180, 45);
            this.RegeditVip.TabIndex = 43;
            this.RegeditVip.Text = "VIP";
            this.RegeditVip.Click += new System.EventHandler(this.RegeditVip_Click);
            // 
            // regeditleader
            // 
            this.regeditleader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.regeditleader.Controls.Add(this.label3);
            this.regeditleader.Controls.Add(this.pictureBox2);
            this.Transition.SetDecoration(this.regeditleader, Siticone.UI.AnimatorNS.DecorationType.None);
            this.regeditleader.Location = new System.Drawing.Point(0, 0);
            this.regeditleader.Name = "regeditleader";
            this.regeditleader.Size = new System.Drawing.Size(239, 43);
            this.regeditleader.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.Transition.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "REGEDIT";
            // 
            // pictureBox2
            // 
            this.Transition.SetDecoration(this.pictureBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // eliMain
            // 
            this.eliMain.TargetControl = this;
            // 
            // eliAimfov
            // 
            this.eliAimfov.TargetControl = this.aimfov;
            // 
            // eliAimfov2
            // 
            this.eliAimfov2.TargetControl = this.aimfovleader;
            // 
            // eliRegedit
            // 
            this.eliRegedit.TargetControl = this.Regedit;
            // 
            // eliRegedit2
            // 
            this.eliRegedit2.TargetControl = this.regeditleader;
            // 
            // DragAimFov
            // 
            this.DragAimFov.TargetControl = this.aimfov;
            // 
            // DragAimfov2
            // 
            this.DragAimfov2.TargetControl = this.aimfovleader;
            // 
            // DragReg
            // 
            this.DragReg.TargetControl = this.Regedit;
            // 
            // DragReg2
            // 
            this.DragReg2.TargetControl = this.regeditleader;
            // 
            // DragOtimizar
            // 
            this.DragOtimizar.TargetControl = this.otimizar;
            // 
            // DragOtimizar2
            // 
            this.DragOtimizar2.TargetControl = this.otimizarleader;
            // 
            // DragMenu
            // 
            this.DragMenu.TargetControl = this.pnMenu;
            // 
            // eliOtimizar
            // 
            this.eliOtimizar.TargetControl = this.otimizar;
            // 
            // eliOtimizar2
            // 
            this.eliOtimizar2.TargetControl = this.otimizarleader;
            // 
            // EliAimAssist
            // 
            this.EliAimAssist.TargetControl = this.aimassist;
            // 
            // EliAimassist2
            // 
            this.EliAimassist2.TargetControl = this.aimassistleader;
            // 
            // DragAimAssist
            // 
            this.DragAimAssist.TargetControl = this.aimassist;
            // 
            // DragAimAssist2
            // 
            this.DragAimAssist2.TargetControl = this.aimassistleader;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(636, 562);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.label1);
            this.Transition.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.aimfov.ResumeLayout(false);
            this.aimfovleader.ResumeLayout(false);
            this.aimfovleader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.aimassist.ResumeLayout(false);
            this.aimassistleader.ResumeLayout(false);
            this.aimassistleader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.otimizar.ResumeLayout(false);
            this.otimizarleader.ResumeLayout(false);
            this.otimizarleader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Regedit.ResumeLayout(false);
            this.regeditleader.ResumeLayout(false);
            this.regeditleader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl DragMain;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition Transition;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm Shadow;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse eliMain;
        private System.Windows.Forms.Panel aimfov;
        private Guna.UI2.WinForms.Guna2Elipse eliAimfov;
        private System.Windows.Forms.Panel aimfovleader;
        private Guna.UI2.WinForms.Guna2Elipse eliAimfov2;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton AimlockXBypass;
        private Guna.UI2.WinForms.Guna2GradientButton AimlockXInject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel otimizar;
        private Guna.UI2.WinForms.Guna2GradientButton OtimizaçãoTirarDelay;
        private Guna.UI2.WinForms.Guna2GradientButton otimizaçãoPCFAST;
        private System.Windows.Forms.Panel otimizarleader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Regedit;
        private Guna.UI2.WinForms.Guna2GradientButton RegeditAjustavel;
        private Guna.UI2.WinForms.Guna2GradientButton RegeditUltimate;
        private Guna.UI2.WinForms.Guna2GradientButton RegeditVip;
        private System.Windows.Forms.Panel regeditleader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse eliRegedit;
        private Guna.UI2.WinForms.Guna2Elipse eliRegedit2;
        private Guna.UI2.WinForms.Guna2DragControl DragAimFov;
        private Guna.UI2.WinForms.Guna2DragControl DragAimfov2;
        private Guna.UI2.WinForms.Guna2DragControl DragReg;
        private Guna.UI2.WinForms.Guna2DragControl DragReg2;
        private Guna.UI2.WinForms.Guna2DragControl DragOtimizar;
        private Guna.UI2.WinForms.Guna2DragControl DragOtimizar2;
        private Guna.UI2.WinForms.Guna2DragControl DragMenu;
        private Guna.UI2.WinForms.Guna2Elipse eliOtimizar;
        private Guna.UI2.WinForms.Guna2Elipse eliOtimizar2;
        private System.Windows.Forms.Panel aimassist;
        private Guna.UI2.WinForms.Guna2GradientButton AimAssistLento;
        private Guna.UI2.WinForms.Guna2GradientButton AimAssistRapido;
        private System.Windows.Forms.Panel aimassistleader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2GradientButton AimAssistMedio;
        private Guna.UI2.WinForms.Guna2Elipse EliAimAssist;
        private Guna.UI2.WinForms.Guna2Elipse EliAimassist2;
        private Guna.UI2.WinForms.Guna2DragControl DragAimAssist;
        private Guna.UI2.WinForms.Guna2DragControl DragAimAssist2;
        private Guna.UI2.WinForms.Guna2Button settings;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}