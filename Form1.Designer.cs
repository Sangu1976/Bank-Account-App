namespace Bank_Account_App
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            CreateAccountBtn = new Button();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Owner :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 342);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(130, 41);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(214, 27);
            OwnerTxt.TabIndex = 1;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(136, 335);
            AmountNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(208, 27);
            AmountNum.TabIndex = 2;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(412, 41);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(300, 188);
            BankAccountsGrid.TabIndex = 3;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(137, 125);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(207, 29);
            CreateAccountBtn.TabIndex = 4;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(412, 267);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(94, 29);
            DepositBtn.TabIndex = 4;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(618, 267);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(94, 29);
            WithdrawBtn.TabIndex = 4;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button CreateAccountBtn;
        private Button DepositBtn;
        private Button WithdrawBtn;
    }
}
