﻿namespace rsatest
{
    partial class GUIClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbQuery = new System.Windows.Forms.TabPage();
            this.tbModify = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtModifyCommand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtModifyPassphrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifyBrowsePrivateKeyPath = new System.Windows.Forms.Button();
            this.txtModifyPrivateKeyPath = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModifyQuery = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.tbKeys = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtQueryWithIdentifier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQueryWithExpression = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuerySelect = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQueryFrom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQueryWhere = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQueryGroupBy = new System.Windows.Forms.TextBox();
            this.txtQueryHaving = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQueryOrderBy = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgQueryResults = new System.Windows.Forms.DataGridView();
            this.btnQueryExecute = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnModifyCommit = new System.Windows.Forms.Button();
            this.dgModifyResults = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbQuery.SuspendLayout();
            this.tbModify.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryResults)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModifyResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConnectionString);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(148, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL to query.ashx:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 641);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbQuery);
            this.tabControl1.Controls.Add(this.tbLog);
            this.tabControl1.Controls.Add(this.tbModify);
            this.tabControl1.Controls.Add(this.tbKeys);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 620);
            this.tabControl1.TabIndex = 0;
            // 
            // tbQuery
            // 
            this.tbQuery.Controls.Add(this.panel6);
            this.tbQuery.Controls.Add(this.panel5);
            this.tbQuery.Location = new System.Drawing.Point(4, 25);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuery.Size = new System.Drawing.Size(681, 591);
            this.tbQuery.TabIndex = 0;
            this.tbQuery.Text = "Query";
            this.tbQuery.UseVisualStyleBackColor = true;
            // 
            // tbModify
            // 
            this.tbModify.Controls.Add(this.panel4);
            this.tbModify.Controls.Add(this.panel3);
            this.tbModify.Controls.Add(this.panel2);
            this.tbModify.Controls.Add(this.panel1);
            this.tbModify.Location = new System.Drawing.Point(4, 25);
            this.tbModify.Name = "tbModify";
            this.tbModify.Padding = new System.Windows.Forms.Padding(3);
            this.tbModify.Size = new System.Drawing.Size(681, 591);
            this.tbModify.TabIndex = 1;
            this.tbModify.Text = "Modify";
            this.tbModify.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgModifyResults);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 230);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtModifyQuery);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 148);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtModifyCommand);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 148);
            this.panel2.TabIndex = 4;
            // 
            // txtModifyCommand
            // 
            this.txtModifyCommand.AcceptsReturn = true;
            this.txtModifyCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModifyCommand.HideSelection = false;
            this.txtModifyCommand.Location = new System.Drawing.Point(0, 23);
            this.txtModifyCommand.Multiline = true;
            this.txtModifyCommand.Name = "txtModifyCommand";
            this.txtModifyCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModifyCommand.Size = new System.Drawing.Size(675, 122);
            this.txtModifyCommand.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "SQL command:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtModifyPassphrase);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnModifyBrowsePrivateKeyPath);
            this.panel1.Controls.Add(this.txtModifyPrivateKeyPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 59);
            this.panel1.TabIndex = 3;
            // 
            // txtModifyPassphrase
            // 
            this.txtModifyPassphrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModifyPassphrase.Location = new System.Drawing.Point(208, 31);
            this.txtModifyPassphrase.Name = "txtModifyPassphrase";
            this.txtModifyPassphrase.PasswordChar = '*';
            this.txtModifyPassphrase.Size = new System.Drawing.Size(426, 22);
            this.txtModifyPassphrase.TabIndex = 4;
            this.txtModifyPassphrase.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passphrase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "OpenSSL RSA private key file:";
            // 
            // btnModifyBrowsePrivateKeyPath
            // 
            this.btnModifyBrowsePrivateKeyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyBrowsePrivateKeyPath.Location = new System.Drawing.Point(641, 3);
            this.btnModifyBrowsePrivateKeyPath.Name = "btnModifyBrowsePrivateKeyPath";
            this.btnModifyBrowsePrivateKeyPath.Size = new System.Drawing.Size(31, 23);
            this.btnModifyBrowsePrivateKeyPath.TabIndex = 2;
            this.btnModifyBrowsePrivateKeyPath.Text = "...";
            this.btnModifyBrowsePrivateKeyPath.UseVisualStyleBackColor = true;
            // 
            // txtModifyPrivateKeyPath
            // 
            this.txtModifyPrivateKeyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModifyPrivateKeyPath.Location = new System.Drawing.Point(208, 3);
            this.txtModifyPrivateKeyPath.Name = "txtModifyPrivateKeyPath";
            this.txtModifyPrivateKeyPath.Size = new System.Drawing.Size(425, 22);
            this.txtModifyPrivateKeyPath.TabIndex = 1;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(4, 25);
            this.tbLog.Name = "tbLog";
            this.tbLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbLog.Size = new System.Drawing.Size(681, 591);
            this.tbLog.TabIndex = 2;
            this.tbLog.Text = "Log";
            this.tbLog.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "SQL verification query:";
            // 
            // txtModifyQuery
            // 
            this.txtModifyQuery.AcceptsReturn = true;
            this.txtModifyQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModifyQuery.HideSelection = false;
            this.txtModifyQuery.Location = new System.Drawing.Point(0, 23);
            this.txtModifyQuery.Multiline = true;
            this.txtModifyQuery.Name = "txtModifyQuery";
            this.txtModifyQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModifyQuery.Size = new System.Drawing.Size(675, 122);
            this.txtModifyQuery.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionString.Location = new System.Drawing.Point(148, 43);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(534, 22);
            this.txtConnectionString.TabIndex = 3;
            // 
            // tbKeys
            // 
            this.tbKeys.Location = new System.Drawing.Point(4, 25);
            this.tbKeys.Name = "tbKeys";
            this.tbKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tbKeys.Size = new System.Drawing.Size(681, 591);
            this.tbKeys.TabIndex = 3;
            this.tbKeys.Text = "Key Management";
            this.tbKeys.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtQueryOrderBy);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtQueryHaving);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtQueryGroupBy);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtQueryWhere);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtQueryFrom);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtQuerySelect);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtQueryWithExpression);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtQueryWithIdentifier);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(675, 365);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgQueryResults);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 368);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(675, 220);
            this.panel6.TabIndex = 1;
            // 
            // txtQueryWithIdentifier
            // 
            this.txtQueryWithIdentifier.Location = new System.Drawing.Point(87, 4);
            this.txtQueryWithIdentifier.Name = "txtQueryWithIdentifier";
            this.txtQueryWithIdentifier.Size = new System.Drawing.Size(78, 22);
            this.txtQueryWithIdentifier.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "AS (";
            // 
            // txtQueryWithExpression
            // 
            this.txtQueryWithExpression.AcceptsReturn = true;
            this.txtQueryWithExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryWithExpression.Location = new System.Drawing.Point(212, 4);
            this.txtQueryWithExpression.Multiline = true;
            this.txtQueryWithExpression.Name = "txtQueryWithExpression";
            this.txtQueryWithExpression.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueryWithExpression.Size = new System.Drawing.Size(444, 82);
            this.txtQueryWithExpression.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "WITH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "SELECT";
            // 
            // txtQuerySelect
            // 
            this.txtQuerySelect.AcceptsReturn = true;
            this.txtQuerySelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuerySelect.HideSelection = false;
            this.txtQuerySelect.Location = new System.Drawing.Point(89, 92);
            this.txtQuerySelect.Multiline = true;
            this.txtQuerySelect.Name = "txtQuerySelect";
            this.txtQuerySelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuerySelect.Size = new System.Drawing.Size(583, 57);
            this.txtQuerySelect.TabIndex = 5;
            this.txtQuerySelect.Text = "\r\n";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = ")";
            // 
            // txtQueryFrom
            // 
            this.txtQueryFrom.AcceptsReturn = true;
            this.txtQueryFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryFrom.HideSelection = false;
            this.txtQueryFrom.Location = new System.Drawing.Point(89, 155);
            this.txtQueryFrom.Multiline = true;
            this.txtQueryFrom.Name = "txtQueryFrom";
            this.txtQueryFrom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueryFrom.Size = new System.Drawing.Size(583, 57);
            this.txtQueryFrom.TabIndex = 7;
            this.txtQueryFrom.Text = "\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "FROM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "WHERE";
            // 
            // txtQueryWhere
            // 
            this.txtQueryWhere.AcceptsReturn = true;
            this.txtQueryWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryWhere.HideSelection = false;
            this.txtQueryWhere.Location = new System.Drawing.Point(89, 218);
            this.txtQueryWhere.Multiline = true;
            this.txtQueryWhere.Name = "txtQueryWhere";
            this.txtQueryWhere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueryWhere.Size = new System.Drawing.Size(583, 57);
            this.txtQueryWhere.TabIndex = 9;
            this.txtQueryWhere.Text = "\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "GROUP BY";
            // 
            // txtQueryGroupBy
            // 
            this.txtQueryGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryGroupBy.Location = new System.Drawing.Point(87, 281);
            this.txtQueryGroupBy.Name = "txtQueryGroupBy";
            this.txtQueryGroupBy.Size = new System.Drawing.Size(583, 22);
            this.txtQueryGroupBy.TabIndex = 12;
            // 
            // txtQueryHaving
            // 
            this.txtQueryHaving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryHaving.Location = new System.Drawing.Point(87, 309);
            this.txtQueryHaving.Name = "txtQueryHaving";
            this.txtQueryHaving.Size = new System.Drawing.Size(583, 22);
            this.txtQueryHaving.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "HAVING";
            // 
            // txtQueryOrderBy
            // 
            this.txtQueryOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryOrderBy.Location = new System.Drawing.Point(87, 337);
            this.txtQueryOrderBy.Name = "txtQueryOrderBy";
            this.txtQueryOrderBy.Size = new System.Drawing.Size(583, 22);
            this.txtQueryOrderBy.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "ORDER BY";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnQueryExecute);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(675, 35);
            this.panel7.TabIndex = 0;
            // 
            // dgQueryResults
            // 
            this.dgQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQueryResults.Location = new System.Drawing.Point(0, 35);
            this.dgQueryResults.Name = "dgQueryResults";
            this.dgQueryResults.RowTemplate.Height = 24;
            this.dgQueryResults.Size = new System.Drawing.Size(675, 185);
            this.dgQueryResults.TabIndex = 1;
            // 
            // btnQueryExecute
            // 
            this.btnQueryExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryExecute.Location = new System.Drawing.Point(597, 7);
            this.btnQueryExecute.Name = "btnQueryExecute";
            this.btnQueryExecute.Size = new System.Drawing.Size(75, 23);
            this.btnQueryExecute.TabIndex = 0;
            this.btnQueryExecute.Text = "Execute";
            this.btnQueryExecute.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnModifyCommit);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(675, 39);
            this.panel8.TabIndex = 0;
            // 
            // btnModifyCommit
            // 
            this.btnModifyCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyCommit.Location = new System.Drawing.Point(596, 7);
            this.btnModifyCommit.Name = "btnModifyCommit";
            this.btnModifyCommit.Size = new System.Drawing.Size(75, 23);
            this.btnModifyCommit.TabIndex = 0;
            this.btnModifyCommit.Text = "Test";
            this.btnModifyCommit.UseVisualStyleBackColor = true;
            // 
            // dgModifyResults
            // 
            this.dgModifyResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModifyResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgModifyResults.Location = new System.Drawing.Point(0, 39);
            this.dgModifyResults.Name = "dgModifyResults";
            this.dgModifyResults.RowTemplate.Height = 24;
            this.dgModifyResults.Size = new System.Drawing.Size(675, 191);
            this.dgModifyResults.TabIndex = 1;
            // 
            // GUIClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIClient";
            this.Text = "query.ashx client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbQuery.ResumeLayout(false);
            this.tbModify.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryResults)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgModifyResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbQuery;
        private System.Windows.Forms.TabPage tbModify;
        private System.Windows.Forms.TabPage tbLog;
        private System.Windows.Forms.Button btnModifyBrowsePrivateKeyPath;
        private System.Windows.Forms.TextBox txtModifyPrivateKeyPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtModifyPassphrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtModifyCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtModifyQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbKeys;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtQuerySelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQueryWithExpression;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQueryWithIdentifier;
        private System.Windows.Forms.TextBox txtQueryFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQueryOrderBy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQueryHaving;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQueryGroupBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQueryWhere;
        private System.Windows.Forms.DataGridView dgQueryResults;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnQueryExecute;
        private System.Windows.Forms.DataGridView dgModifyResults;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnModifyCommit;
    }
}