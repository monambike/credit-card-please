namespace CreditCardPlease.Desktop
{
    partial class FormCreditCard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditCard));
            tlpMain = new TableLayoutPanel();
            msMain = new MenuStrip();
            miApplication = new ToolStripMenuItem();
            miMonika = new ToolStripMenuItem();
            miUwu = new ToolStripMenuItem();
            miSeparator = new ToolStripSeparator();
            miExit = new ToolStripMenuItem();
            miSettings = new ToolStripMenuItem();
            miLanguage = new ToolStripMenuItem();
            miLanguageSystemDefault = new ToolStripMenuItem();
            miLanguageEnglish = new ToolStripMenuItem();
            miLanguagePortuguese = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            miDisclaimer = new ToolStripMenuItem();
            tlpBody = new TableLayoutPanel();
            pbImage = new PictureBox();
            tlpSubmissionForm = new TableLayoutPanel();
            tlpFields = new TableLayoutPanel();
            txtCardSecurityCode = new TextBox();
            txtCardExpirationDate = new TextBox();
            txtCardNumber = new TextBox();
            lblRequiredFields = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblCardExpirationDateRequired = new Label();
            lblCardExpirationDate = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblCardSecurityCodeRequired = new Label();
            lblCardSecurityCode = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCardNumberRequired = new Label();
            lblCardNumber = new Label();
            lblTitle = new Label();
            lblThanks = new Label();
            lblSeparator = new Label();
            tlpFooter = new TableLayoutPanel();
            btnCancel = new Button();
            btnSend = new Button();
            tlpMain.SuspendLayout();
            msMain.SuspendLayout();
            tlpBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            tlpSubmissionForm.SuspendLayout();
            tlpFields.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tlpFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            resources.ApplyResources(tlpMain, "tlpMain");
            tlpMain.Controls.Add(msMain, 0, 0);
            tlpMain.Controls.Add(tlpBody, 0, 1);
            tlpMain.Controls.Add(lblSeparator, 0, 2);
            tlpMain.Controls.Add(tlpFooter, 0, 3);
            tlpMain.Name = "tlpMain";
            // 
            // msMain
            // 
            msMain.Items.AddRange(new ToolStripItem[] { miApplication, miSettings, miAbout, miDisclaimer });
            resources.ApplyResources(msMain, "msMain");
            msMain.Name = "msMain";
            // 
            // miApplication
            // 
            miApplication.DropDownItems.AddRange(new ToolStripItem[] { miMonika, miUwu, miSeparator, miExit });
            miApplication.Name = "miApplication";
            resources.ApplyResources(miApplication, "miApplication");
            // 
            // miMonika
            // 
            miMonika.Name = "miMonika";
            resources.ApplyResources(miMonika, "miMonika");
            miMonika.Click += miMonika_Click;
            // 
            // miUwu
            // 
            miUwu.Name = "miUwu";
            resources.ApplyResources(miUwu, "miUwu");
            miUwu.Click += miUwu_Click;
            // 
            // miSeparator
            // 
            miSeparator.Name = "miSeparator";
            resources.ApplyResources(miSeparator, "miSeparator");
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            resources.ApplyResources(miExit, "miExit");
            miExit.Click += miExit_Click;
            // 
            // miSettings
            // 
            miSettings.DropDownItems.AddRange(new ToolStripItem[] { miLanguage });
            miSettings.Name = "miSettings";
            resources.ApplyResources(miSettings, "miSettings");
            // 
            // miLanguage
            // 
            miLanguage.DropDownItems.AddRange(new ToolStripItem[] { miLanguageSystemDefault, miLanguageEnglish, miLanguagePortuguese });
            miLanguage.Name = "miLanguage";
            resources.ApplyResources(miLanguage, "miLanguage");
            // 
            // miLanguageSystemDefault
            // 
            miLanguageSystemDefault.Name = "miLanguageSystemDefault";
            resources.ApplyResources(miLanguageSystemDefault, "miLanguageSystemDefault");
            miLanguageSystemDefault.Click += miLanguageSystemDefault_Click;
            // 
            // miLanguageEnglish
            // 
            miLanguageEnglish.Name = "miLanguageEnglish";
            resources.ApplyResources(miLanguageEnglish, "miLanguageEnglish");
            miLanguageEnglish.Click += miLanguageEnglish_Click;
            // 
            // miLanguagePortuguese
            // 
            miLanguagePortuguese.Name = "miLanguagePortuguese";
            resources.ApplyResources(miLanguagePortuguese, "miLanguagePortuguese");
            miLanguagePortuguese.Click += miLanguagePortuguese_Click;
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            resources.ApplyResources(miAbout, "miAbout");
            miAbout.Click += miAbout_Click;
            // 
            // miDisclaimer
            // 
            miDisclaimer.Name = "miDisclaimer";
            resources.ApplyResources(miDisclaimer, "miDisclaimer");
            miDisclaimer.Click += miDisclaimer_Click;
            // 
            // tlpBody
            // 
            resources.ApplyResources(tlpBody, "tlpBody");
            tlpBody.Controls.Add(pbImage, 0, 0);
            tlpBody.Controls.Add(tlpSubmissionForm, 1, 0);
            tlpBody.Name = "tlpBody";
            // 
            // pbImage
            // 
            resources.ApplyResources(pbImage, "pbImage");
            pbImage.Image = Properties.Resources.BannerSayori;
            pbImage.Name = "pbImage";
            pbImage.TabStop = false;
            // 
            // tlpSubmissionForm
            // 
            resources.ApplyResources(tlpSubmissionForm, "tlpSubmissionForm");
            tlpSubmissionForm.Controls.Add(tlpFields, 0, 1);
            tlpSubmissionForm.Controls.Add(lblTitle, 0, 0);
            tlpSubmissionForm.Controls.Add(lblThanks, 0, 2);
            tlpSubmissionForm.Name = "tlpSubmissionForm";
            // 
            // tlpFields
            // 
            resources.ApplyResources(tlpFields, "tlpFields");
            tlpFields.Controls.Add(txtCardSecurityCode, 1, 2);
            tlpFields.Controls.Add(txtCardExpirationDate, 1, 1);
            tlpFields.Controls.Add(txtCardNumber, 1, 0);
            tlpFields.Controls.Add(lblRequiredFields, 0, 3);
            tlpFields.Controls.Add(flowLayoutPanel2, 0, 1);
            tlpFields.Controls.Add(flowLayoutPanel3, 0, 2);
            tlpFields.Controls.Add(flowLayoutPanel1, 0, 0);
            tlpFields.Name = "tlpFields";
            // 
            // txtCardSecurityCode
            // 
            resources.ApplyResources(txtCardSecurityCode, "txtCardSecurityCode");
            txtCardSecurityCode.Name = "txtCardSecurityCode";
            // 
            // txtCardExpirationDate
            // 
            resources.ApplyResources(txtCardExpirationDate, "txtCardExpirationDate");
            txtCardExpirationDate.Name = "txtCardExpirationDate";
            txtCardExpirationDate.TextChanged += txtCardExpirationDate_TextChanged;
            // 
            // txtCardNumber
            // 
            resources.ApplyResources(txtCardNumber, "txtCardNumber");
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
            // 
            // lblRequiredFields
            // 
            resources.ApplyResources(lblRequiredFields, "lblRequiredFields");
            lblRequiredFields.ForeColor = Color.IndianRed;
            lblRequiredFields.Name = "lblRequiredFields";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Controls.Add(lblCardExpirationDateRequired);
            flowLayoutPanel2.Controls.Add(lblCardExpirationDate);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // lblCardExpirationDateRequired
            // 
            resources.ApplyResources(lblCardExpirationDateRequired, "lblCardExpirationDateRequired");
            lblCardExpirationDateRequired.ForeColor = Color.Red;
            lblCardExpirationDateRequired.Name = "lblCardExpirationDateRequired";
            // 
            // lblCardExpirationDate
            // 
            resources.ApplyResources(lblCardExpirationDate, "lblCardExpirationDate");
            lblCardExpirationDate.Name = "lblCardExpirationDate";
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(flowLayoutPanel3, "flowLayoutPanel3");
            flowLayoutPanel3.Controls.Add(lblCardSecurityCodeRequired);
            flowLayoutPanel3.Controls.Add(lblCardSecurityCode);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // lblCardSecurityCodeRequired
            // 
            resources.ApplyResources(lblCardSecurityCodeRequired, "lblCardSecurityCodeRequired");
            lblCardSecurityCodeRequired.ForeColor = Color.Red;
            lblCardSecurityCodeRequired.Name = "lblCardSecurityCodeRequired";
            // 
            // lblCardSecurityCode
            // 
            resources.ApplyResources(lblCardSecurityCode, "lblCardSecurityCode");
            lblCardSecurityCode.Name = "lblCardSecurityCode";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(lblCardNumberRequired);
            flowLayoutPanel1.Controls.Add(lblCardNumber);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // lblCardNumberRequired
            // 
            resources.ApplyResources(lblCardNumberRequired, "lblCardNumberRequired");
            lblCardNumberRequired.ForeColor = Color.Red;
            lblCardNumberRequired.Name = "lblCardNumberRequired";
            // 
            // lblCardNumber
            // 
            resources.ApplyResources(lblCardNumber, "lblCardNumber");
            lblCardNumber.Name = "lblCardNumber";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // lblThanks
            // 
            resources.ApplyResources(lblThanks, "lblThanks");
            lblThanks.Name = "lblThanks";
            // 
            // lblSeparator
            // 
            lblSeparator.BorderStyle = BorderStyle.Fixed3D;
            resources.ApplyResources(lblSeparator, "lblSeparator");
            lblSeparator.Name = "lblSeparator";
            // 
            // tlpFooter
            // 
            resources.ApplyResources(tlpFooter, "tlpFooter");
            tlpFooter.Controls.Add(btnCancel, 2, 0);
            tlpFooter.Controls.Add(btnSend, 1, 0);
            tlpFooter.Name = "tlpFooter";
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSend
            // 
            resources.ApplyResources(btnSend, "btnSend");
            btnSend.Name = "btnSend";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // FormCreditCard
            // 
            AcceptButton = btnSend;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            Controls.Add(tlpMain);
            MainMenuStrip = msMain;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreditCard";
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            tlpBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            tlpSubmissionForm.ResumeLayout(false);
            tlpSubmissionForm.PerformLayout();
            tlpFields.ResumeLayout(false);
            tlpFields.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tlpFooter.ResumeLayout(false);
            tlpFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpBody;
        private PictureBox pbImage;
        private TableLayoutPanel tlpSubmissionForm;
        private TableLayoutPanel tlpFields;
        private TextBox txtCardSecurityCode;
        private TextBox txtCardExpirationDate;
        private TextBox txtCardNumber;
        private Label lblTitle;
        private Label lblThanks;
        private TableLayoutPanel tlpFooter;
        private Button btnCancel;
        private Button btnSend;
        private Label lblSeparator;
        private MenuStrip msMain;
        private ToolStripMenuItem miApplication;
        private ToolStripMenuItem miUwu;
        private ToolStripSeparator miSeparator;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem miSettings;
        private ToolStripMenuItem miLanguage;
        private ToolStripMenuItem miLanguageSystemDefault;
        private ToolStripMenuItem miLanguageEnglish;
        private ToolStripMenuItem miLanguagePortuguese;
        private ToolStripMenuItem miAbout;
        private ToolStripMenuItem miDisclaimer;
        private ToolStripMenuItem miMonika;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblCardExpirationDateRequired;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblCardSecurityCodeRequired;
        private Label lblRequiredFields;
        private Label lblCardExpirationDate;
        private Label lblCardSecurityCode;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCardNumberRequired;
        private Label lblCardNumber;
    }
}
