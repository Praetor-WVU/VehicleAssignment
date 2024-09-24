namespace Assignment2
{
    partial class frmAssignment2
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
            lblMakeModel = new Label();
            lblYear = new Label();
            lblSummary = new Label();
            lstMakeModel = new ListBox();
            txtYear = new TextBox();
            grpColors = new GroupBox();
            rbtnRed = new RadioButton();
            rbtnBlue = new RadioButton();
            rbtnBlack = new RadioButton();
            rbtnWhite = new RadioButton();
            grpFeatures = new GroupBox();
            chkLaneAssist = new CheckBox();
            chkAC = new CheckBox();
            chkSyriusRadio = new CheckBox();
            chkPowerWin = new CheckBox();
            btnPurchase = new Button();
            grpColors.SuspendLayout();
            grpFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblMakeModel
            // 
            lblMakeModel.AutoSize = true;
            lblMakeModel.Location = new Point(12, 9);
            lblMakeModel.Name = "lblMakeModel";
            lblMakeModel.Size = new Size(121, 20);
            lblMakeModel.TabIndex = 0;
            lblMakeModel.Text = "&Make and Model";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(168, 9);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 1;
            lblYear.Text = "&Year";
            // 
            // lblSummary
            // 
            lblSummary.BorderStyle = BorderStyle.FixedSingle;
            lblSummary.Location = new Point(168, 161);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(436, 80);
            lblSummary.TabIndex = 4;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstMakeModel
            // 
            lstMakeModel.FormattingEnabled = true;
            lstMakeModel.Items.AddRange(new object[] { "Chevy Silverado", "Ford F-150", "Toyota Yaris", "Honda Element" });
            lstMakeModel.Location = new Point(12, 32);
            lstMakeModel.Name = "lstMakeModel";
            lstMakeModel.Size = new Size(150, 104);
            lstMakeModel.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(168, 32);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 6;
            // 
            // grpColors
            // 
            grpColors.Controls.Add(rbtnRed);
            grpColors.Controls.Add(rbtnBlue);
            grpColors.Controls.Add(rbtnBlack);
            grpColors.Controls.Add(rbtnWhite);
            grpColors.Location = new Point(299, 12);
            grpColors.Name = "grpColors";
            grpColors.Size = new Size(144, 146);
            grpColors.TabIndex = 7;
            grpColors.TabStop = false;
            grpColors.Text = "&Color";
            // 
            // rbtnRed
            // 
            rbtnRed.AutoSize = true;
            rbtnRed.Location = new Point(6, 20);
            rbtnRed.Name = "rbtnRed";
            rbtnRed.Size = new Size(56, 24);
            rbtnRed.TabIndex = 9;
            rbtnRed.TabStop = true;
            rbtnRed.Text = "Red";
            rbtnRed.UseVisualStyleBackColor = true;
            rbtnRed.CheckedChanged += rbtnRed_CheckedChanged;
            // 
            // rbtnBlue
            // 
            rbtnBlue.AutoSize = true;
            rbtnBlue.Location = new Point(6, 50);
            rbtnBlue.Name = "rbtnBlue";
            rbtnBlue.Size = new Size(59, 24);
            rbtnBlue.TabIndex = 10;
            rbtnBlue.TabStop = true;
            rbtnBlue.Text = "Blue";
            rbtnBlue.UseVisualStyleBackColor = true;
            rbtnBlue.CheckedChanged += rbtnBlue_CheckedChanged;
            // 
            // rbtnBlack
            // 
            rbtnBlack.AutoSize = true;
            rbtnBlack.Location = new Point(6, 80);
            rbtnBlack.Name = "rbtnBlack";
            rbtnBlack.Size = new Size(65, 24);
            rbtnBlack.TabIndex = 11;
            rbtnBlack.TabStop = true;
            rbtnBlack.Text = "Black";
            rbtnBlack.UseVisualStyleBackColor = true;
            rbtnBlack.CheckedChanged += rbtnBlack_CheckedChanged;
            // 
            // rbtnWhite
            // 
            rbtnWhite.AutoSize = true;
            rbtnWhite.Location = new Point(6, 110);
            rbtnWhite.Name = "rbtnWhite";
            rbtnWhite.Size = new Size(69, 24);
            rbtnWhite.TabIndex = 12;
            rbtnWhite.TabStop = true;
            rbtnWhite.Text = "White";
            rbtnWhite.UseVisualStyleBackColor = true;
            rbtnWhite.CheckedChanged += rbtnWhite_CheckedChanged;
            // 
            // grpFeatures
            // 
            grpFeatures.Controls.Add(chkLaneAssist);
            grpFeatures.Controls.Add(chkAC);
            grpFeatures.Controls.Add(chkSyriusRadio);
            grpFeatures.Controls.Add(chkPowerWin);
            grpFeatures.Location = new Point(449, 12);
            grpFeatures.Name = "grpFeatures";
            grpFeatures.Size = new Size(155, 146);
            grpFeatures.TabIndex = 0;
            grpFeatures.TabStop = false;
            grpFeatures.Text = "&Features";
            // 
            // chkLaneAssist
            // 
            chkLaneAssist.AutoSize = true;
            chkLaneAssist.Location = new Point(6, 110);
            chkLaneAssist.Name = "chkLaneAssist";
            chkLaneAssist.Size = new Size(103, 24);
            chkLaneAssist.TabIndex = 12;
            chkLaneAssist.Text = "Lane Assist";
            chkLaneAssist.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(6, 20);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(50, 24);
            chkAC.TabIndex = 9;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // chkSyriusRadio
            // 
            chkSyriusRadio.AutoSize = true;
            chkSyriusRadio.Location = new Point(6, 80);
            chkSyriusRadio.Name = "chkSyriusRadio";
            chkSyriusRadio.Size = new Size(112, 24);
            chkSyriusRadio.TabIndex = 11;
            chkSyriusRadio.Text = "Syrius Radio";
            chkSyriusRadio.UseVisualStyleBackColor = true;
            // 
            // chkPowerWin
            // 
            chkPowerWin.AutoSize = true;
            chkPowerWin.Location = new Point(6, 50);
            chkPowerWin.Name = "chkPowerWin";
            chkPowerWin.Size = new Size(136, 24);
            chkPowerWin.TabIndex = 10;
            chkPowerWin.Text = "Power Windows";
            chkPowerWin.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(39, 187);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(94, 29);
            btnPurchase.TabIndex = 8;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // frmAssignment2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 256);
            Controls.Add(btnPurchase);
            Controls.Add(grpFeatures);
            Controls.Add(grpColors);
            Controls.Add(txtYear);
            Controls.Add(lstMakeModel);
            Controls.Add(lblSummary);
            Controls.Add(lblYear);
            Controls.Add(lblMakeModel);
            Name = "frmAssignment2";
            Text = "Assignment 2";
            grpColors.ResumeLayout(false);
            grpColors.PerformLayout();
            grpFeatures.ResumeLayout(false);
            grpFeatures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMakeModel;
        private Label lblYear;
        private Label lblSummary;
        private ListBox lstMakeModel;
        private TextBox txtYear;
        private GroupBox grpColors;
        private GroupBox grpFeatures;
        private Button btnPurchase;
        private RadioButton rbtnRed;
        private RadioButton rbtnBlue;
        private RadioButton rbtnBlack;
        private RadioButton rbtnWhite;
        private CheckBox chkLaneAssist;
        private CheckBox chkAC;
        private CheckBox chkSyriusRadio;
        private CheckBox chkPowerWin;
    }
}
