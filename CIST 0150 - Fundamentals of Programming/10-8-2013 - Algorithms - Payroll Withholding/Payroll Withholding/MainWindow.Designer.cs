namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Payroll_Withholding
{
    partial class MainWindow
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.payPerHourLabel = new System.Windows.Forms.Label();
            this.hoursWorkedInput = new System.Windows.Forms.TextBox();
            this.payPerHourInput = new System.Windows.Forms.TextBox();
            this.filingStatusGroup = new System.Windows.Forms.GroupBox();
            this.filingStatusFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.singleRateRadio = new System.Windows.Forms.RadioButton();
            this.familyRateRadio = new System.Windows.Forms.RadioButton();
            this.residencyGroup = new System.Windows.Forms.GroupBox();
            this.residencyFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.pennsylvaniaRadio = new System.Windows.Forms.RadioButton();
            this.newYorkRadio = new System.Windows.Forms.RadioButton();
            this.otherStatesRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.ficaLabel = new System.Windows.Forms.Label();
            this.grossPayOutput = new System.Windows.Forms.Label();
            this.ficaOutput = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.divider1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.payAfterFicaLabel = new System.Windows.Forms.Label();
            this.payAfterFicaOutput = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.netPayOutput = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.fedIncomeTaxLabel = new System.Windows.Forms.Label();
            this.stateIncomeTaxLabel = new System.Windows.Forms.Label();
            this.fedIncomeTaxOutput = new System.Windows.Forms.Label();
            this.stateIncomeTaxOutput = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.filingStatusGroup.SuspendLayout();
            this.filingStatusFlow.SuspendLayout();
            this.residencyGroup.SuspendLayout();
            this.residencyFlow.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(424, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Payroll_Withholding.Properties.Resources.young_weird_man_holding_calculator_7881339;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(207, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(216, 50);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Payroll Withholding\r\nCalculator";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.hoursWorkedLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.payPerHourLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hoursWorkedInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.payPerHourInput, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(212, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(18, 0);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(79, 23);
            this.hoursWorkedLabel.TabIndex = 0;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            this.hoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payPerHourLabel
            // 
            this.payPerHourLabel.AutoSize = true;
            this.payPerHourLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.payPerHourLabel.Location = new System.Drawing.Point(24, 23);
            this.payPerHourLabel.Name = "payPerHourLabel";
            this.payPerHourLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.payPerHourLabel.Size = new System.Drawing.Size(73, 23);
            this.payPerHourLabel.TabIndex = 1;
            this.payPerHourLabel.Text = "Pay Per Hour:";
            this.payPerHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hoursWorkedInput
            // 
            this.hoursWorkedInput.Location = new System.Drawing.Point(103, 3);
            this.hoursWorkedInput.Name = "hoursWorkedInput";
            this.hoursWorkedInput.Size = new System.Drawing.Size(94, 20);
            this.hoursWorkedInput.TabIndex = 2;
            this.hoursWorkedInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.itemKeyUp);
            // 
            // payPerHourInput
            // 
            this.payPerHourInput.Location = new System.Drawing.Point(103, 26);
            this.payPerHourInput.Name = "payPerHourInput";
            this.payPerHourInput.Size = new System.Drawing.Size(94, 20);
            this.payPerHourInput.TabIndex = 3;
            this.payPerHourInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.itemKeyUp);
            // 
            // filingStatusGroup
            // 
            this.filingStatusGroup.Controls.Add(this.filingStatusFlow);
            this.filingStatusGroup.Location = new System.Drawing.Point(12, 230);
            this.filingStatusGroup.Name = "filingStatusGroup";
            this.filingStatusGroup.Size = new System.Drawing.Size(189, 75);
            this.filingStatusGroup.TabIndex = 4;
            this.filingStatusGroup.TabStop = false;
            this.filingStatusGroup.Text = "Filing Status";
            // 
            // filingStatusFlow
            // 
            this.filingStatusFlow.Controls.Add(this.singleRateRadio);
            this.filingStatusFlow.Controls.Add(this.familyRateRadio);
            this.filingStatusFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filingStatusFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.filingStatusFlow.Location = new System.Drawing.Point(3, 16);
            this.filingStatusFlow.Name = "filingStatusFlow";
            this.filingStatusFlow.Padding = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.filingStatusFlow.Size = new System.Drawing.Size(183, 56);
            this.filingStatusFlow.TabIndex = 0;
            // 
            // singleRateRadio
            // 
            this.singleRateRadio.AutoSize = true;
            this.singleRateRadio.Location = new System.Drawing.Point(13, 7);
            this.singleRateRadio.Name = "singleRateRadio";
            this.singleRateRadio.Size = new System.Drawing.Size(80, 17);
            this.singleRateRadio.TabIndex = 0;
            this.singleRateRadio.TabStop = true;
            this.singleRateRadio.Text = "&Single Rate";
            this.singleRateRadio.UseVisualStyleBackColor = true;
            this.singleRateRadio.CheckedChanged += new System.EventHandler(this.itemChanged);
            // 
            // familyRateRadio
            // 
            this.familyRateRadio.AutoSize = true;
            this.familyRateRadio.Location = new System.Drawing.Point(13, 30);
            this.familyRateRadio.Name = "familyRateRadio";
            this.familyRateRadio.Size = new System.Drawing.Size(80, 17);
            this.familyRateRadio.TabIndex = 1;
            this.familyRateRadio.TabStop = true;
            this.familyRateRadio.Text = "Fa&mily Rate";
            this.familyRateRadio.UseVisualStyleBackColor = true;
            this.familyRateRadio.CheckedChanged += new System.EventHandler(this.itemChanged);
            // 
            // residencyGroup
            // 
            this.residencyGroup.Controls.Add(this.residencyFlow);
            this.residencyGroup.Location = new System.Drawing.Point(12, 311);
            this.residencyGroup.Name = "residencyGroup";
            this.residencyGroup.Size = new System.Drawing.Size(189, 96);
            this.residencyGroup.TabIndex = 5;
            this.residencyGroup.TabStop = false;
            this.residencyGroup.Text = "Residency";
            // 
            // residencyFlow
            // 
            this.residencyFlow.Controls.Add(this.pennsylvaniaRadio);
            this.residencyFlow.Controls.Add(this.newYorkRadio);
            this.residencyFlow.Controls.Add(this.otherStatesRadio);
            this.residencyFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residencyFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.residencyFlow.Location = new System.Drawing.Point(3, 16);
            this.residencyFlow.Name = "residencyFlow";
            this.residencyFlow.Padding = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.residencyFlow.Size = new System.Drawing.Size(183, 77);
            this.residencyFlow.TabIndex = 0;
            // 
            // pennsylvaniaRadio
            // 
            this.pennsylvaniaRadio.AutoSize = true;
            this.pennsylvaniaRadio.Location = new System.Drawing.Point(13, 7);
            this.pennsylvaniaRadio.Name = "pennsylvaniaRadio";
            this.pennsylvaniaRadio.Size = new System.Drawing.Size(88, 17);
            this.pennsylvaniaRadio.TabIndex = 0;
            this.pennsylvaniaRadio.TabStop = true;
            this.pennsylvaniaRadio.Text = "&Pennsylvania";
            this.pennsylvaniaRadio.UseVisualStyleBackColor = true;
            this.pennsylvaniaRadio.CheckedChanged += new System.EventHandler(this.itemChanged);
            // 
            // newYorkRadio
            // 
            this.newYorkRadio.AutoSize = true;
            this.newYorkRadio.Location = new System.Drawing.Point(13, 30);
            this.newYorkRadio.Name = "newYorkRadio";
            this.newYorkRadio.Size = new System.Drawing.Size(72, 17);
            this.newYorkRadio.TabIndex = 1;
            this.newYorkRadio.TabStop = true;
            this.newYorkRadio.Text = "New &York";
            this.newYorkRadio.UseVisualStyleBackColor = true;
            this.newYorkRadio.CheckedChanged += new System.EventHandler(this.itemChanged);
            // 
            // otherStatesRadio
            // 
            this.otherStatesRadio.AutoSize = true;
            this.otherStatesRadio.Location = new System.Drawing.Point(13, 53);
            this.otherStatesRadio.Name = "otherStatesRadio";
            this.otherStatesRadio.Size = new System.Drawing.Size(161, 17);
            this.otherStatesRadio.TabIndex = 2;
            this.otherStatesRadio.TabStop = true;
            this.otherStatesRadio.Text = "&Other States (no withholding)";
            this.otherStatesRadio.UseVisualStyleBackColor = true;
            this.otherStatesRadio.CheckedChanged += new System.EventHandler(this.itemChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grossPayLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ficaLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grossPayOutput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ficaOutput, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(212, 230);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.grossPayLabel.Location = new System.Drawing.Point(3, 0);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(58, 23);
            this.grossPayLabel.TabIndex = 0;
            this.grossPayLabel.Text = "Gross Pay:";
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ficaLabel
            // 
            this.ficaLabel.AutoSize = true;
            this.ficaLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ficaLabel.Location = new System.Drawing.Point(3, 23);
            this.ficaLabel.Name = "ficaLabel";
            this.ficaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ficaLabel.Size = new System.Drawing.Size(33, 23);
            this.ficaLabel.TabIndex = 1;
            this.ficaLabel.Text = "FICA:";
            this.ficaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grossPayOutput
            // 
            this.grossPayOutput.AutoSize = true;
            this.grossPayOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.grossPayOutput.Location = new System.Drawing.Point(197, 0);
            this.grossPayOutput.Name = "grossPayOutput";
            this.grossPayOutput.Size = new System.Drawing.Size(0, 23);
            this.grossPayOutput.TabIndex = 2;
            this.grossPayOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ficaOutput
            // 
            this.ficaOutput.AutoSize = true;
            this.ficaOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.ficaOutput.Location = new System.Drawing.Point(197, 23);
            this.ficaOutput.Name = "ficaOutput";
            this.ficaOutput.Size = new System.Drawing.Size(0, 23);
            this.ficaOutput.TabIndex = 3;
            this.ficaOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 414);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.divider1});
            this.shapeContainer1.Size = new System.Drawing.Size(424, 438);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 213;
            this.lineShape1.X2 = 410;
            this.lineShape1.Y1 = 378;
            this.lineShape1.Y2 = 378;
            // 
            // divider1
            // 
            this.divider1.Name = "divider1";
            this.divider1.X1 = 213;
            this.divider1.X2 = 410;
            this.divider1.Y1 = 280;
            this.divider1.Y2 = 280;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.payAfterFicaLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.payAfterFicaOutput, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(212, 285);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 23);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // payAfterFicaLabel
            // 
            this.payAfterFicaLabel.AutoSize = true;
            this.payAfterFicaLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.payAfterFicaLabel.Location = new System.Drawing.Point(3, 0);
            this.payAfterFicaLabel.Name = "payAfterFicaLabel";
            this.payAfterFicaLabel.Size = new System.Drawing.Size(79, 23);
            this.payAfterFicaLabel.TabIndex = 0;
            this.payAfterFicaLabel.Text = "Pay After FICA:";
            this.payAfterFicaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payAfterFicaOutput
            // 
            this.payAfterFicaOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.payAfterFicaOutput.Location = new System.Drawing.Point(103, 0);
            this.payAfterFicaOutput.Name = "payAfterFicaOutput";
            this.payAfterFicaOutput.Size = new System.Drawing.Size(94, 23);
            this.payAfterFicaOutput.TabIndex = 1;
            this.payAfterFicaOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.netPayLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.netPayOutput, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(212, 383);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 23);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // netPayLabel
            // 
            this.netPayLabel.AutoSize = true;
            this.netPayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.netPayLabel.Location = new System.Drawing.Point(3, 0);
            this.netPayLabel.Name = "netPayLabel";
            this.netPayLabel.Size = new System.Drawing.Size(48, 23);
            this.netPayLabel.TabIndex = 0;
            this.netPayLabel.Text = "Net Pay:";
            this.netPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // netPayOutput
            // 
            this.netPayOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.netPayOutput.Location = new System.Drawing.Point(103, 0);
            this.netPayOutput.Name = "netPayOutput";
            this.netPayOutput.Size = new System.Drawing.Size(94, 23);
            this.netPayOutput.TabIndex = 1;
            this.netPayOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Controls.Add(this.fedIncomeTaxLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.stateIncomeTaxLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.fedIncomeTaxOutput, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.stateIncomeTaxOutput, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(212, 328);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // fedIncomeTaxLabel
            // 
            this.fedIncomeTaxLabel.AutoSize = true;
            this.fedIncomeTaxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fedIncomeTaxLabel.Location = new System.Drawing.Point(3, 0);
            this.fedIncomeTaxLabel.Name = "fedIncomeTaxLabel";
            this.fedIncomeTaxLabel.Size = new System.Drawing.Size(104, 23);
            this.fedIncomeTaxLabel.TabIndex = 0;
            this.fedIncomeTaxLabel.Text = "Federal Income Tax:";
            this.fedIncomeTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stateIncomeTaxLabel
            // 
            this.stateIncomeTaxLabel.AutoSize = true;
            this.stateIncomeTaxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stateIncomeTaxLabel.Location = new System.Drawing.Point(3, 23);
            this.stateIncomeTaxLabel.Name = "stateIncomeTaxLabel";
            this.stateIncomeTaxLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stateIncomeTaxLabel.Size = new System.Drawing.Size(94, 23);
            this.stateIncomeTaxLabel.TabIndex = 1;
            this.stateIncomeTaxLabel.Text = "State Income Tax:";
            this.stateIncomeTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fedIncomeTaxOutput
            // 
            this.fedIncomeTaxOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.fedIncomeTaxOutput.Location = new System.Drawing.Point(123, 0);
            this.fedIncomeTaxOutput.Name = "fedIncomeTaxOutput";
            this.fedIncomeTaxOutput.Size = new System.Drawing.Size(74, 23);
            this.fedIncomeTaxOutput.TabIndex = 2;
            this.fedIncomeTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stateIncomeTaxOutput
            // 
            this.stateIncomeTaxOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.stateIncomeTaxOutput.Location = new System.Drawing.Point(123, 23);
            this.stateIncomeTaxOutput.Name = "stateIncomeTaxOutput";
            this.stateIncomeTaxOutput.Size = new System.Drawing.Size(74, 23);
            this.stateIncomeTaxOutput.TabIndex = 3;
            this.stateIncomeTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(12, 416);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(0, 13);
            this.clockLabel.TabIndex = 12;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 438);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.residencyGroup);
            this.Controls.Add(this.filingStatusGroup);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.shapeContainer1);
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 476);
            this.MinimumSize = new System.Drawing.Size(440, 476);
            this.Name = "MainWindow";
            this.Text = "Payroll Calculator";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.filingStatusGroup.ResumeLayout(false);
            this.filingStatusFlow.ResumeLayout(false);
            this.filingStatusFlow.PerformLayout();
            this.residencyGroup.ResumeLayout(false);
            this.residencyFlow.ResumeLayout(false);
            this.residencyFlow.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label payPerHourLabel;
        private System.Windows.Forms.TextBox hoursWorkedInput;
        private System.Windows.Forms.TextBox payPerHourInput;
        private System.Windows.Forms.GroupBox filingStatusGroup;
        private System.Windows.Forms.FlowLayoutPanel filingStatusFlow;
        private System.Windows.Forms.RadioButton singleRateRadio;
        private System.Windows.Forms.RadioButton familyRateRadio;
        private System.Windows.Forms.GroupBox residencyGroup;
        private System.Windows.Forms.FlowLayoutPanel residencyFlow;
        private System.Windows.Forms.RadioButton pennsylvaniaRadio;
        private System.Windows.Forms.RadioButton newYorkRadio;
        private System.Windows.Forms.RadioButton otherStatesRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label ficaLabel;
        private System.Windows.Forms.Label grossPayOutput;
        private System.Windows.Forms.Label ficaOutput;
        private System.Windows.Forms.Splitter splitter1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape divider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label payAfterFicaLabel;
        private System.Windows.Forms.Label payAfterFicaOutput;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.Label netPayOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label fedIncomeTaxLabel;
        private System.Windows.Forms.Label stateIncomeTaxLabel;
        private System.Windows.Forms.Label fedIncomeTaxOutput;
        private System.Windows.Forms.Label stateIncomeTaxOutput;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
    }
}

