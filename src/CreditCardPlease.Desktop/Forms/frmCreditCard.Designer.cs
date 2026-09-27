namespace CreditCardPlease.Desktop
{
    partial class frmCreditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditCard));
            tlpMain = new TableLayoutPanel();
            msMain = new MenuStrip();
            miApplication = new ToolStripMenuItem();
            miUwu = new ToolStripMenuItem();
            miSeparator = new ToolStripSeparator();
            miExit = new ToolStripMenuItem();
            miSettings = new ToolStripMenuItem();
            miLanguage = new ToolStripMenuItem();
            miLanguageSystemDefault = new ToolStripMenuItem();
            miLanguageEnglish = new ToolStripMenuItem();
            miLanguagePortuguese = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            tlpBody = new TableLayoutPanel();
            pbImage = new PictureBox();
            tlpSubmissionForm = new TableLayoutPanel();
            tlpFields = new TableLayoutPanel();
            txtCardSecurityCode = new TextBox();
            txtCardExpirationDate = new TextBox();
            txtCardNumber = new TextBox();
            lblCardNumber = new Label();
            lblCardExpirationDate = new Label();
            lblCardSecurityCode = new Label();
            lblRequiredFields = new Label();
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
            msMain.Items.AddRange(new ToolStripItem[] { miApplication, miSettings, miAbout });
            resources.ApplyResources(msMain, "msMain");
            msMain.Name = "msMain";
            // 
            // miApplication
            // 
            miApplication.DropDownItems.AddRange(new ToolStripItem[] { miUwu, miSeparator, miExit });
            miApplication.Name = "miApplication";
            resources.ApplyResources(miApplication, "miApplication");
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
            tlpFields.Controls.Add(lblCardNumber, 0, 0);
            tlpFields.Controls.Add(lblCardExpirationDate, 0, 1);
            tlpFields.Controls.Add(lblCardSecurityCode, 0, 2);
            tlpFields.Controls.Add(lblRequiredFields, 0, 3);
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
            // 
            // txtCardNumber
            // 
            resources.ApplyResources(txtCardNumber, "txtCardNumber");
            txtCardNumber.Name = "txtCardNumber";
            // 
            // lblCardNumber
            // 
            resources.ApplyResources(lblCardNumber, "lblCardNumber");
            lblCardNumber.Name = "lblCardNumber";
            // 
            // lblCardExpirationDate
            // 
            resources.ApplyResources(lblCardExpirationDate, "lblCardExpirationDate");
            lblCardExpirationDate.Name = "lblCardExpirationDate";
            // 
            // lblCardSecurityCode
            // 
            resources.ApplyResources(lblCardSecurityCode, "lblCardSecurityCode");
            lblCardSecurityCode.Name = "lblCardSecurityCode";
            // 
            // lblRequiredFields
            // 
            resources.ApplyResources(lblRequiredFields, "lblRequiredFields");
            lblRequiredFields.ForeColor = SystemColors.ControlDarkDark;
            lblRequiredFields.Name = "lblRequiredFields";
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
            // frmCreditCard
            // 
            AcceptButton = btnSend;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            Controls.Add(tlpMain);
            MainMenuStrip = msMain;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreditCard";
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
        private Label lblCardNumber;
        private Label lblCardExpirationDate;
        private Label lblCardSecurityCode;
        private Label lblRequiredFields;
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
    }
}
