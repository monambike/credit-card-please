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
            tlpMain = new TableLayoutPanel();
            tlpFooter = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
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
            lblTip = new Label();
            lblTitle = new Label();
            lblThanks = new Label();
            tlpMain.SuspendLayout();
            tlpFooter.SuspendLayout();
            tlpBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            tlpSubmissionForm.SuspendLayout();
            tlpFields.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpFooter, 0, 1);
            tlpMain.Controls.Add(tlpBody, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.Size = new Size(800, 450);
            tlpMain.TabIndex = 0;
            // 
            // tlpFooter
            // 
            tlpFooter.AutoSize = true;
            tlpFooter.ColumnCount = 3;
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle());
            tlpFooter.ColumnStyles.Add(new ColumnStyle());
            tlpFooter.Controls.Add(button1, 1, 0);
            tlpFooter.Controls.Add(button2, 2, 0);
            tlpFooter.Dock = DockStyle.Fill;
            tlpFooter.Location = new Point(3, 418);
            tlpFooter.Name = "tlpFooter";
            tlpFooter.RowCount = 1;
            tlpFooter.RowStyles.Add(new RowStyle());
            tlpFooter.Size = new Size(794, 29);
            tlpFooter.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(635, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Send data";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(716, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // tlpBody
            // 
            tlpBody.ColumnCount = 2;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBody.Controls.Add(pbImage, 0, 0);
            tlpBody.Controls.Add(tlpSubmissionForm, 1, 0);
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.Location = new Point(3, 3);
            tlpBody.Name = "tlpBody";
            tlpBody.RowCount = 1;
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBody.Size = new Size(794, 409);
            tlpBody.TabIndex = 1;
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(3, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(391, 403);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // tlpSubmissionForm
            // 
            tlpSubmissionForm.ColumnCount = 1;
            tlpSubmissionForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSubmissionForm.Controls.Add(tlpFields, 0, 1);
            tlpSubmissionForm.Controls.Add(lblTitle, 0, 0);
            tlpSubmissionForm.Controls.Add(lblThanks, 0, 2);
            tlpSubmissionForm.Dock = DockStyle.Fill;
            tlpSubmissionForm.Location = new Point(400, 3);
            tlpSubmissionForm.Name = "tlpSubmissionForm";
            tlpSubmissionForm.RowCount = 3;
            tlpSubmissionForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSubmissionForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSubmissionForm.RowStyles.Add(new RowStyle());
            tlpSubmissionForm.Size = new Size(391, 403);
            tlpSubmissionForm.TabIndex = 1;
            // 
            // tlpFields
            // 
            tlpFields.ColumnCount = 2;
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFields.Controls.Add(txtCardSecurityCode, 1, 2);
            tlpFields.Controls.Add(txtCardExpirationDate, 1, 1);
            tlpFields.Controls.Add(txtCardNumber, 1, 0);
            tlpFields.Controls.Add(lblCardNumber, 0, 0);
            tlpFields.Controls.Add(lblCardExpirationDate, 0, 1);
            tlpFields.Controls.Add(lblCardSecurityCode, 0, 2);
            tlpFields.Controls.Add(lblTip, 0, 3);
            tlpFields.Dock = DockStyle.Fill;
            tlpFields.Location = new Point(3, 169);
            tlpFields.Name = "tlpFields";
            tlpFields.RowCount = 4;
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpFields.Size = new Size(385, 160);
            tlpFields.TabIndex = 0;
            // 
            // txtCardSecurityCode
            // 
            txtCardSecurityCode.Font = new Font("Segoe UI", 12F);
            txtCardSecurityCode.Location = new Point(195, 83);
            txtCardSecurityCode.MaxLength = 4;
            txtCardSecurityCode.Name = "txtCardSecurityCode";
            txtCardSecurityCode.PlaceholderText = "CVV";
            txtCardSecurityCode.Size = new Size(51, 29);
            txtCardSecurityCode.TabIndex = 1;
            // 
            // txtCardExpirationDate
            // 
            txtCardExpirationDate.Font = new Font("Segoe UI", 12F);
            txtCardExpirationDate.Location = new Point(195, 43);
            txtCardExpirationDate.MaxLength = 5;
            txtCardExpirationDate.Name = "txtCardExpirationDate";
            txtCardExpirationDate.PlaceholderText = "MM/AA";
            txtCardExpirationDate.Size = new Size(100, 29);
            txtCardExpirationDate.TabIndex = 2;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Dock = DockStyle.Fill;
            txtCardNumber.Font = new Font("Segoe UI", 12F);
            txtCardNumber.Location = new Point(195, 3);
            txtCardNumber.MaxLength = 20;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.PlaceholderText = "1234 5678 9012 3456";
            txtCardNumber.Size = new Size(187, 29);
            txtCardNumber.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Dock = DockStyle.Fill;
            lblCardNumber.Font = new Font("Segoe UI", 12F);
            lblCardNumber.Location = new Point(3, 0);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(186, 40);
            lblCardNumber.TabIndex = 4;
            lblCardNumber.Text = "Card Number:";
            // 
            // lblCardExpirationDate
            // 
            lblCardExpirationDate.AutoSize = true;
            lblCardExpirationDate.Dock = DockStyle.Fill;
            lblCardExpirationDate.Font = new Font("Segoe UI", 12F);
            lblCardExpirationDate.Location = new Point(3, 40);
            lblCardExpirationDate.Name = "lblCardExpirationDate";
            lblCardExpirationDate.Size = new Size(186, 40);
            lblCardExpirationDate.TabIndex = 5;
            lblCardExpirationDate.Text = "Expiration Date:";
            // 
            // lblCardSecurityCode
            // 
            lblCardSecurityCode.AutoSize = true;
            lblCardSecurityCode.Dock = DockStyle.Fill;
            lblCardSecurityCode.Font = new Font("Segoe UI", 12F);
            lblCardSecurityCode.Location = new Point(3, 80);
            lblCardSecurityCode.Name = "lblCardSecurityCode";
            lblCardSecurityCode.Size = new Size(186, 40);
            lblCardSecurityCode.TabIndex = 6;
            lblCardSecurityCode.Text = "Security Code:";
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Dock = DockStyle.Fill;
            lblTip.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTip.ForeColor = SystemColors.ControlDarkDark;
            lblTip.Location = new Point(3, 120);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(186, 40);
            lblTip.TabIndex = 7;
            lblTip.Text = "* Required Fields";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(20);
            lblTitle.Size = new Size(385, 166);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "H-Hello!\r\nC-Could you provide your\r\ncredit card info, pretty please?";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThanks
            // 
            lblThanks.AutoSize = true;
            lblThanks.Dock = DockStyle.Fill;
            lblThanks.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblThanks.Location = new Point(3, 332);
            lblThanks.Name = "lblThanks";
            lblThanks.Padding = new Padding(20);
            lblThanks.Size = new Size(385, 71);
            lblThanks.TabIndex = 2;
            lblThanks.Text = "T-Thanks!";
            lblThanks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCreditCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreditCard";
            Text = "I-I need that data... Please...";
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tlpFooter.ResumeLayout(false);
            tlpBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            tlpSubmissionForm.ResumeLayout(false);
            tlpSubmissionForm.PerformLayout();
            tlpFields.ResumeLayout(false);
            tlpFields.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpFooter;
        private Button button1;
        private Button button2;
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
        private Label lblTip;
        private Label lblTitle;
        private Label lblThanks;
    }
}
