namespace Priority
{
    partial class non_Preemptive
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
            this.valuelbl = new System.Windows.Forms.Label();
            this.awtlbl = new System.Windows.Forms.Label();
            this.processTB4 = new System.Windows.Forms.TextBox();
            this.waitingTB4 = new System.Windows.Forms.TextBox();
            this.processTable = new System.Windows.Forms.TableLayoutPanel();
            this.priorityTB4 = new System.Windows.Forms.TextBox();
            this.burstTB4 = new System.Windows.Forms.TextBox();
            this.burstTB3 = new System.Windows.Forms.TextBox();
            this.processTB3 = new System.Windows.Forms.TextBox();
            this.burstTB2 = new System.Windows.Forms.TextBox();
            this.processTB2 = new System.Windows.Forms.TextBox();
            this.priorityTB1 = new System.Windows.Forms.TextBox();
            this.burstTB1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.processTB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priorityTB2 = new System.Windows.Forms.TextBox();
            this.priorityTB3 = new System.Windows.Forms.TextBox();
            this.waitingTB1 = new System.Windows.Forms.TextBox();
            this.waitingTB2 = new System.Windows.Forms.TextBox();
            this.waitingTB3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pLbl2 = new System.Windows.Forms.Label();
            this.timeLbl2 = new System.Windows.Forms.Label();
            this.timeLbl1 = new System.Windows.Forms.Label();
            this.pLbl1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.solveBtn = new System.Windows.Forms.Button();
            this.timeLbl3 = new System.Windows.Forms.Label();
            this.timeLbl4 = new System.Windows.Forms.Label();
            this.ganttPanel = new System.Windows.Forms.Panel();
            this.timeLbl8 = new System.Windows.Forms.Label();
            this.timeLbl7 = new System.Windows.Forms.Label();
            this.pLbl4 = new System.Windows.Forms.Label();
            this.timeLbl6 = new System.Windows.Forms.Label();
            this.timeLbl5 = new System.Windows.Forms.Label();
            this.pLbl3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.processTable.SuspendLayout();
            this.ganttPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // valuelbl
            // 
            this.valuelbl.AutoSize = true;
            this.valuelbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuelbl.Location = new System.Drawing.Point(308, 309);
            this.valuelbl.Name = "valuelbl";
            this.valuelbl.Size = new System.Drawing.Size(0, 24);
            this.valuelbl.TabIndex = 28;
            this.valuelbl.Visible = false;
            // 
            // awtlbl
            // 
            this.awtlbl.AutoSize = true;
            this.awtlbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awtlbl.Location = new System.Drawing.Point(10, 307);
            this.awtlbl.Name = "awtlbl";
            this.awtlbl.Size = new System.Drawing.Size(287, 27);
            this.awtlbl.TabIndex = 27;
            this.awtlbl.Text = "Average Waiting Time :";
            this.awtlbl.Visible = false;
            // 
            // processTB4
            // 
            this.processTB4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processTB4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTB4.Location = new System.Drawing.Point(3, 191);
            this.processTB4.Name = "processTB4";
            this.processTB4.Size = new System.Drawing.Size(251, 38);
            this.processTB4.TabIndex = 10;
            this.processTB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // waitingTB4
            // 
            this.waitingTB4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waitingTB4.Enabled = false;
            this.waitingTB4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingTB4.Location = new System.Drawing.Point(774, 191);
            this.waitingTB4.Name = "waitingTB4";
            this.waitingTB4.Size = new System.Drawing.Size(251, 38);
            this.waitingTB4.TabIndex = 17;
            this.waitingTB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processTable
            // 
            this.processTable.BackColor = System.Drawing.Color.Gainsboro;
            this.processTable.ColumnCount = 4;
            this.processTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.processTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.processTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.processTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.processTable.Controls.Add(this.processTB4, 0, 4);
            this.processTable.Controls.Add(this.waitingTB4, 0, 4);
            this.processTable.Controls.Add(this.priorityTB4, 0, 4);
            this.processTable.Controls.Add(this.burstTB4, 0, 4);
            this.processTable.Controls.Add(this.burstTB3, 1, 3);
            this.processTable.Controls.Add(this.processTB3, 0, 3);
            this.processTable.Controls.Add(this.burstTB2, 1, 2);
            this.processTable.Controls.Add(this.processTB2, 0, 2);
            this.processTable.Controls.Add(this.priorityTB1, 2, 1);
            this.processTable.Controls.Add(this.burstTB1, 1, 1);
            this.processTable.Controls.Add(this.label3, 2, 0);
            this.processTable.Controls.Add(this.label2, 1, 0);
            this.processTable.Controls.Add(this.processTB1, 0, 1);
            this.processTable.Controls.Add(this.label1, 0, 0);
            this.processTable.Controls.Add(this.priorityTB2, 2, 2);
            this.processTable.Controls.Add(this.priorityTB3, 2, 3);
            this.processTable.Controls.Add(this.waitingTB1, 3, 1);
            this.processTable.Controls.Add(this.waitingTB2, 3, 2);
            this.processTable.Controls.Add(this.waitingTB3, 3, 3);
            this.processTable.Controls.Add(this.label5, 3, 0);
            this.processTable.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTable.Location = new System.Drawing.Point(12, 12);
            this.processTable.Name = "processTable";
            this.processTable.RowCount = 5;
            this.processTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.30553F));
            this.processTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.58567F));
            this.processTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.03626F));
            this.processTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.03626F));
            this.processTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.03626F));
            this.processTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.processTable.Size = new System.Drawing.Size(1030, 238);
            this.processTable.TabIndex = 25;
            // 
            // priorityTB4
            // 
            this.priorityTB4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priorityTB4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTB4.Location = new System.Drawing.Point(517, 191);
            this.priorityTB4.Name = "priorityTB4";
            this.priorityTB4.Size = new System.Drawing.Size(251, 38);
            this.priorityTB4.TabIndex = 12;
            this.priorityTB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priorityTB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // burstTB4
            // 
            this.burstTB4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.burstTB4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burstTB4.Location = new System.Drawing.Point(260, 191);
            this.burstTB4.Name = "burstTB4";
            this.burstTB4.Size = new System.Drawing.Size(251, 38);
            this.burstTB4.TabIndex = 11;
            this.burstTB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // burstTB3
            // 
            this.burstTB3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.burstTB3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burstTB3.Location = new System.Drawing.Point(260, 144);
            this.burstTB3.Name = "burstTB3";
            this.burstTB3.Size = new System.Drawing.Size(251, 38);
            this.burstTB3.TabIndex = 8;
            this.burstTB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // processTB3
            // 
            this.processTB3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processTB3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTB3.Location = new System.Drawing.Point(3, 144);
            this.processTB3.Name = "processTB3";
            this.processTB3.Size = new System.Drawing.Size(251, 38);
            this.processTB3.TabIndex = 7;
            this.processTB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // burstTB2
            // 
            this.burstTB2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.burstTB2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burstTB2.Location = new System.Drawing.Point(260, 97);
            this.burstTB2.Name = "burstTB2";
            this.burstTB2.Size = new System.Drawing.Size(251, 38);
            this.burstTB2.TabIndex = 5;
            this.burstTB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // processTB2
            // 
            this.processTB2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processTB2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTB2.Location = new System.Drawing.Point(3, 97);
            this.processTB2.Name = "processTB2";
            this.processTB2.Size = new System.Drawing.Size(251, 38);
            this.processTB2.TabIndex = 4;
            this.processTB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priorityTB1
            // 
            this.priorityTB1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priorityTB1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTB1.Location = new System.Drawing.Point(517, 53);
            this.priorityTB1.Name = "priorityTB1";
            this.priorityTB1.Size = new System.Drawing.Size(251, 38);
            this.priorityTB1.TabIndex = 3;
            this.priorityTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priorityTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // burstTB1
            // 
            this.burstTB1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.burstTB1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burstTB1.Location = new System.Drawing.Point(260, 53);
            this.burstTB1.Name = "burstTB1";
            this.burstTB1.Size = new System.Drawing.Size(251, 38);
            this.burstTB1.TabIndex = 2;
            this.burstTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6);
            this.label3.Size = new System.Drawing.Size(251, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priority";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6);
            this.label2.Size = new System.Drawing.Size(251, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burst Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processTB1
            // 
            this.processTB1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processTB1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTB1.Location = new System.Drawing.Point(3, 53);
            this.processTB1.Name = "processTB1";
            this.processTB1.Size = new System.Drawing.Size(251, 38);
            this.processTB1.TabIndex = 1;
            this.processTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(251, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priorityTB2
            // 
            this.priorityTB2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priorityTB2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTB2.Location = new System.Drawing.Point(517, 97);
            this.priorityTB2.Name = "priorityTB2";
            this.priorityTB2.Size = new System.Drawing.Size(251, 38);
            this.priorityTB2.TabIndex = 6;
            this.priorityTB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priorityTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // priorityTB3
            // 
            this.priorityTB3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priorityTB3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTB3.Location = new System.Drawing.Point(517, 144);
            this.priorityTB3.Name = "priorityTB3";
            this.priorityTB3.Size = new System.Drawing.Size(251, 38);
            this.priorityTB3.TabIndex = 9;
            this.priorityTB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priorityTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTB1_KeyPress);
            // 
            // waitingTB1
            // 
            this.waitingTB1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waitingTB1.Enabled = false;
            this.waitingTB1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingTB1.Location = new System.Drawing.Point(774, 53);
            this.waitingTB1.Name = "waitingTB1";
            this.waitingTB1.Size = new System.Drawing.Size(251, 38);
            this.waitingTB1.TabIndex = 14;
            this.waitingTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // waitingTB2
            // 
            this.waitingTB2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waitingTB2.Enabled = false;
            this.waitingTB2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingTB2.Location = new System.Drawing.Point(774, 97);
            this.waitingTB2.Name = "waitingTB2";
            this.waitingTB2.Size = new System.Drawing.Size(251, 38);
            this.waitingTB2.TabIndex = 13;
            this.waitingTB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // waitingTB3
            // 
            this.waitingTB3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waitingTB3.Enabled = false;
            this.waitingTB3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingTB3.Location = new System.Drawing.Point(774, 144);
            this.waitingTB3.Name = "waitingTB3";
            this.waitingTB3.Size = new System.Drawing.Size(251, 38);
            this.waitingTB3.TabIndex = 15;
            this.waitingTB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(774, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 50);
            this.label5.TabIndex = 19;
            this.label5.Text = "Waiting Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLbl2
            // 
            this.pLbl2.AutoSize = true;
            this.pLbl2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLbl2.Location = new System.Drawing.Point(294, 58);
            this.pLbl2.Name = "pLbl2";
            this.pLbl2.Size = new System.Drawing.Size(0, 32);
            this.pLbl2.TabIndex = 4;
            // 
            // timeLbl2
            // 
            this.timeLbl2.AutoSize = true;
            this.timeLbl2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl2.Location = new System.Drawing.Point(184, 97);
            this.timeLbl2.Name = "timeLbl2";
            this.timeLbl2.Size = new System.Drawing.Size(0, 32);
            this.timeLbl2.TabIndex = 3;
            // 
            // timeLbl1
            // 
            this.timeLbl1.AutoSize = true;
            this.timeLbl1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl1.Location = new System.Drawing.Point(49, 97);
            this.timeLbl1.Name = "timeLbl1";
            this.timeLbl1.Size = new System.Drawing.Size(0, 32);
            this.timeLbl1.TabIndex = 2;
            // 
            // pLbl1
            // 
            this.pLbl1.AutoSize = true;
            this.pLbl1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLbl1.Location = new System.Drawing.Point(125, 58);
            this.pLbl1.Name = "pLbl1";
            this.pLbl1.Size = new System.Drawing.Size(0, 32);
            this.pLbl1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gantt Chart";
            // 
            // solveBtn
            // 
            this.solveBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.solveBtn.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveBtn.Location = new System.Drawing.Point(913, 460);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(124, 48);
            this.solveBtn.TabIndex = 24;
            this.solveBtn.Text = "Solve";
            this.solveBtn.UseVisualStyleBackColor = false;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // timeLbl3
            // 
            this.timeLbl3.AutoSize = true;
            this.timeLbl3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl3.Location = new System.Drawing.Point(238, 97);
            this.timeLbl3.Name = "timeLbl3";
            this.timeLbl3.Size = new System.Drawing.Size(0, 32);
            this.timeLbl3.TabIndex = 5;
            // 
            // timeLbl4
            // 
            this.timeLbl4.AutoSize = true;
            this.timeLbl4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl4.Location = new System.Drawing.Point(356, 97);
            this.timeLbl4.Name = "timeLbl4";
            this.timeLbl4.Size = new System.Drawing.Size(0, 32);
            this.timeLbl4.TabIndex = 6;
            // 
            // ganttPanel
            // 
            this.ganttPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ganttPanel.Controls.Add(this.timeLbl8);
            this.ganttPanel.Controls.Add(this.timeLbl7);
            this.ganttPanel.Controls.Add(this.pLbl4);
            this.ganttPanel.Controls.Add(this.timeLbl6);
            this.ganttPanel.Controls.Add(this.timeLbl5);
            this.ganttPanel.Controls.Add(this.label4);
            this.ganttPanel.Controls.Add(this.pLbl3);
            this.ganttPanel.Controls.Add(this.timeLbl4);
            this.ganttPanel.Controls.Add(this.timeLbl3);
            this.ganttPanel.Controls.Add(this.pLbl2);
            this.ganttPanel.Controls.Add(this.timeLbl2);
            this.ganttPanel.Controls.Add(this.timeLbl1);
            this.ganttPanel.Controls.Add(this.pLbl1);
            this.ganttPanel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganttPanel.Location = new System.Drawing.Point(12, 360);
            this.ganttPanel.Name = "ganttPanel";
            this.ganttPanel.Size = new System.Drawing.Size(855, 148);
            this.ganttPanel.TabIndex = 26;
            // 
            // timeLbl8
            // 
            this.timeLbl8.AutoSize = true;
            this.timeLbl8.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl8.Location = new System.Drawing.Point(788, 97);
            this.timeLbl8.Name = "timeLbl8";
            this.timeLbl8.Size = new System.Drawing.Size(0, 32);
            this.timeLbl8.TabIndex = 12;
            // 
            // timeLbl7
            // 
            this.timeLbl7.AutoSize = true;
            this.timeLbl7.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl7.Location = new System.Drawing.Point(644, 97);
            this.timeLbl7.Name = "timeLbl7";
            this.timeLbl7.Size = new System.Drawing.Size(0, 32);
            this.timeLbl7.TabIndex = 11;
            // 
            // pLbl4
            // 
            this.pLbl4.AutoSize = true;
            this.pLbl4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLbl4.Location = new System.Drawing.Point(713, 58);
            this.pLbl4.Name = "pLbl4";
            this.pLbl4.Size = new System.Drawing.Size(0, 32);
            this.pLbl4.TabIndex = 10;
            // 
            // timeLbl6
            // 
            this.timeLbl6.AutoSize = true;
            this.timeLbl6.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl6.Location = new System.Drawing.Point(582, 97);
            this.timeLbl6.Name = "timeLbl6";
            this.timeLbl6.Size = new System.Drawing.Size(0, 32);
            this.timeLbl6.TabIndex = 9;
            // 
            // timeLbl5
            // 
            this.timeLbl5.AutoSize = true;
            this.timeLbl5.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl5.Location = new System.Drawing.Point(418, 97);
            this.timeLbl5.Name = "timeLbl5";
            this.timeLbl5.Size = new System.Drawing.Size(0, 32);
            this.timeLbl5.TabIndex = 8;
            // 
            // pLbl3
            // 
            this.pLbl3.AutoSize = true;
            this.pLbl3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLbl3.Location = new System.Drawing.Point(502, 58);
            this.pLbl3.Name = "pLbl3";
            this.pLbl3.Size = new System.Drawing.Size(0, 32);
            this.pLbl3.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // non_Preemptive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 523);
            this.Controls.Add(this.valuelbl);
            this.Controls.Add(this.awtlbl);
            this.Controls.Add(this.processTable);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.ganttPanel);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "non_Preemptive";
            this.Text = "non-Preemptive";
            this.processTable.ResumeLayout(false);
            this.processTable.PerformLayout();
            this.ganttPanel.ResumeLayout(false);
            this.ganttPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valuelbl;
        private System.Windows.Forms.Label awtlbl;
        private System.Windows.Forms.TextBox processTB4;
        private System.Windows.Forms.TextBox waitingTB4;
        private System.Windows.Forms.TableLayoutPanel processTable;
        private System.Windows.Forms.TextBox priorityTB4;
        private System.Windows.Forms.TextBox burstTB4;
        private System.Windows.Forms.TextBox burstTB3;
        private System.Windows.Forms.TextBox processTB3;
        private System.Windows.Forms.TextBox burstTB2;
        private System.Windows.Forms.TextBox processTB2;
        private System.Windows.Forms.TextBox priorityTB1;
        private System.Windows.Forms.TextBox burstTB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox processTB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priorityTB2;
        private System.Windows.Forms.TextBox priorityTB3;
        private System.Windows.Forms.TextBox waitingTB1;
        private System.Windows.Forms.TextBox waitingTB2;
        private System.Windows.Forms.TextBox waitingTB3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pLbl2;
        private System.Windows.Forms.Label timeLbl2;
        private System.Windows.Forms.Label timeLbl1;
        private System.Windows.Forms.Label pLbl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Label timeLbl3;
        private System.Windows.Forms.Label timeLbl4;
        private System.Windows.Forms.Panel ganttPanel;
        private System.Windows.Forms.Label timeLbl8;
        private System.Windows.Forms.Label timeLbl7;
        private System.Windows.Forms.Label pLbl4;
        private System.Windows.Forms.Label timeLbl6;
        private System.Windows.Forms.Label timeLbl5;
        private System.Windows.Forms.Label pLbl3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}