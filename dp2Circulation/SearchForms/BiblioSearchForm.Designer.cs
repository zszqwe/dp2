namespace dp2Circulation
{
    partial class BiblioSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioSearchForm));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_queryWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip_biblioDb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_viewBiblioDbProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_query = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_from = new DigitalPlatform.CommonControl.TabComboBox();
            this.label_matchStyle = new System.Windows.Forms.Label();
            this.comboBox_matchStyle = new System.Windows.Forms.ComboBox();
            this.checkedComboBox_biblioDbNames = new DigitalPlatform.CommonControl.CheckedComboBox();
            this.toolStrip_search = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton_searchKeys = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_continueLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_searchKeyID = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_searchKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton_inputTimeString = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_rfc1123Single = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_uSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_rfc1123Range = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_uRange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_prevQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_nextQuery = new System.Windows.Forms.ToolStripButton();
            this.button_search = new System.Windows.Forms.Button();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.label_message = new System.Windows.Forms.Label();
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.tabControl_query = new System.Windows.Forms.TabControl();
            this.tabPage_simple = new System.Windows.Forms.TabPage();
            this.tabPage_logic = new System.Windows.Forms.TabPage();
            this.dp2QueryControl1 = new DigitalPlatform.CommonControl.dp2QueryControl();
            this.listView_records = new DigitalPlatform.GUI.ListViewNF();
            this.columnHeader_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_biblioDb.SuspendLayout();
            this.tableLayoutPanel_query.SuspendLayout();
            this.toolStrip_search.SuspendLayout();
            this.tableLayoutPanel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            this.tabControl_query.SuspendLayout();
            this.tabPage_simple.SuspendLayout();
            this.tabPage_logic.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "����;��(&F):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_queryWord
            // 
            this.textBox_queryWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_queryWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_queryWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_queryWord.Location = new System.Drawing.Point(89, 4);
            this.textBox_queryWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_queryWord.Name = "textBox_queryWord";
            this.textBox_queryWord.Size = new System.Drawing.Size(137, 21);
            this.textBox_queryWord.TabIndex = 1;
            this.textBox_queryWord.TextChanged += new System.EventHandler(this.textBox_queryWord_TextChanged);
            this.textBox_queryWord.Enter += new System.EventHandler(this.textBox_queryWord_Enter);
            this.textBox_queryWord.Leave += new System.EventHandler(this.textBox_queryWord_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "������(&W):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip_biblioDb;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "��Ŀ��(&D):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip_biblioDb
            // 
            this.contextMenuStrip_biblioDb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_viewBiblioDbProperty});
            this.contextMenuStrip_biblioDb.Name = "contextMenuStrip_biblioDb";
            this.contextMenuStrip_biblioDb.Size = new System.Drawing.Size(185, 26);
            // 
            // MenuItem_viewBiblioDbProperty
            // 
            this.MenuItem_viewBiblioDbProperty.Name = "MenuItem_viewBiblioDbProperty";
            this.MenuItem_viewBiblioDbProperty.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_viewBiblioDbProperty.Text = "�۲���Ŀ������(&P)...";
            this.MenuItem_viewBiblioDbProperty.Click += new System.EventHandler(this.MenuItem_viewBiblioDbProperty_Click);
            // 
            // tableLayoutPanel_query
            // 
            this.tableLayoutPanel_query.ColumnCount = 3;
            this.tableLayoutPanel_query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_query.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel_query.Controls.Add(this.textBox_queryWord, 1, 0);
            this.tableLayoutPanel_query.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel_query.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_query.Controls.Add(this.comboBox_from, 1, 2);
            this.tableLayoutPanel_query.Controls.Add(this.label_matchStyle, 0, 3);
            this.tableLayoutPanel_query.Controls.Add(this.comboBox_matchStyle, 1, 3);
            this.tableLayoutPanel_query.Controls.Add(this.checkedComboBox_biblioDbNames, 1, 1);
            this.tableLayoutPanel_query.Controls.Add(this.toolStrip_search, 2, 0);
            this.tableLayoutPanel_query.Controls.Add(this.button_search, 2, 1);
            this.tableLayoutPanel_query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_query.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_query.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_query.MaximumSize = new System.Drawing.Size(350, 0);
            this.tableLayoutPanel_query.Name = "tableLayoutPanel_query";
            this.tableLayoutPanel_query.RowCount = 5;
            this.tableLayoutPanel_query.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_query.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_query.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_query.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_query.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_query.Size = new System.Drawing.Size(350, 127);
            this.tableLayoutPanel_query.TabIndex = 8;
            // 
            // comboBox_from
            // 
            this.comboBox_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_from.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_from.DropDownHeight = 350;
            this.comboBox_from.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_from.FormattingEnabled = true;
            this.comboBox_from.IntegralHeight = false;
            this.comboBox_from.Location = new System.Drawing.Point(89, 63);
            this.comboBox_from.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_from.Name = "comboBox_from";
            this.comboBox_from.Size = new System.Drawing.Size(137, 22);
            this.comboBox_from.TabIndex = 6;
            this.comboBox_from.SizeChanged += new System.EventHandler(this.comboBox_from_SizeChanged);
            // 
            // label_matchStyle
            // 
            this.label_matchStyle.AutoSize = true;
            this.label_matchStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_matchStyle.Location = new System.Drawing.Point(4, 89);
            this.label_matchStyle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_matchStyle.Name = "label_matchStyle";
            this.label_matchStyle.Size = new System.Drawing.Size(77, 28);
            this.label_matchStyle.TabIndex = 7;
            this.label_matchStyle.Text = "ƥ�䷽ʽ(&M):";
            this.label_matchStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_matchStyle
            // 
            this.comboBox_matchStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_matchStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_matchStyle.FormattingEnabled = true;
            this.comboBox_matchStyle.Items.AddRange(new object[] {
            "ǰ��һ��",
            "�м�һ��",
            "��һ��",
            "��ȷһ��",
            "��ֵ"});
            this.comboBox_matchStyle.Location = new System.Drawing.Point(89, 93);
            this.comboBox_matchStyle.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_matchStyle.Name = "comboBox_matchStyle";
            this.comboBox_matchStyle.Size = new System.Drawing.Size(137, 20);
            this.comboBox_matchStyle.TabIndex = 8;
            this.comboBox_matchStyle.Text = "ǰ��һ��";
            this.comboBox_matchStyle.SizeChanged += new System.EventHandler(this.comboBox_matchStyle_SizeChanged);
            this.comboBox_matchStyle.TextChanged += new System.EventHandler(this.comboBox_matchStyle_TextChanged);
            // 
            // checkedComboBox_biblioDbNames
            // 
            this.checkedComboBox_biblioDbNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedComboBox_biblioDbNames.BackColor = System.Drawing.SystemColors.Window;
            this.checkedComboBox_biblioDbNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkedComboBox_biblioDbNames.Location = new System.Drawing.Point(89, 33);
            this.checkedComboBox_biblioDbNames.Margin = new System.Windows.Forms.Padding(4);
            this.checkedComboBox_biblioDbNames.Name = "checkedComboBox_biblioDbNames";
            this.checkedComboBox_biblioDbNames.Padding = new System.Windows.Forms.Padding(4);
            this.checkedComboBox_biblioDbNames.Size = new System.Drawing.Size(137, 22);
            this.checkedComboBox_biblioDbNames.TabIndex = 9;
            this.checkedComboBox_biblioDbNames.DropDown += new System.EventHandler(this.checkedComboBox_biblioDbNames_DropDown);
            this.checkedComboBox_biblioDbNames.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.checkedComboBox_biblioDbNames_ItemChecked);
            // 
            // toolStrip_search
            // 
            this.toolStrip_search.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip_search.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_search.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_search,
            this.toolStripDropDownButton_searchKeys,
            this.toolStripSeparator3,
            this.toolStripDropDownButton_inputTimeString,
            this.toolStripSeparator1,
            this.toolStripButton_prevQuery,
            this.toolStripButton_nextQuery});
            this.toolStrip_search.Location = new System.Drawing.Point(230, 0);
            this.toolStrip_search.Name = "toolStrip_search";
            this.toolStrip_search.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_search.Size = new System.Drawing.Size(120, 25);
            this.toolStrip_search.TabIndex = 13;
            this.toolStrip_search.Text = "����";
            // 
            // toolStripButton_search
            // 
            this.toolStripButton_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_search.Image")));
            this.toolStripButton_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_search.Name = "toolStripButton_search";
            this.toolStripButton_search.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_search.Text = "����";
            this.toolStripButton_search.Click += new System.EventHandler(this.toolStripButton_search_Click);
            // 
            // toolStripDropDownButton_searchKeys
            // 
            this.toolStripDropDownButton_searchKeys.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripDropDownButton_searchKeys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_continueLoad,
            this.toolStripMenuItem_searchKeyID,
            this.toolStripMenuItem_searchKeys});
            this.toolStripDropDownButton_searchKeys.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_searchKeys.Image")));
            this.toolStripDropDownButton_searchKeys.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_searchKeys.Name = "toolStripDropDownButton_searchKeys";
            this.toolStripDropDownButton_searchKeys.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDownButton_searchKeys.Text = "��������...";
            // 
            // ToolStripMenuItem_continueLoad
            // 
            this.ToolStripMenuItem_continueLoad.Enabled = false;
            this.ToolStripMenuItem_continueLoad.Name = "ToolStripMenuItem_continueLoad";
            this.ToolStripMenuItem_continueLoad.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_continueLoad.Text = "����װ��";
            this.ToolStripMenuItem_continueLoad.ToolTipText = "����װ���ж�ʱ��δװ�����Щ�����";
            this.ToolStripMenuItem_continueLoad.Click += new System.EventHandler(this.ToolStripMenuItem_continueLoad_Click);
            // 
            // toolStripMenuItem_searchKeyID
            // 
            this.toolStripMenuItem_searchKeyID.Name = "toolStripMenuItem_searchKeyID";
            this.toolStripMenuItem_searchKeyID.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem_searchKeyID.Text = "��������ļ���";
            this.toolStripMenuItem_searchKeyID.Click += new System.EventHandler(this.toolStripMenuItem_searchKeyID_Click);
            // 
            // toolStripMenuItem_searchKeys
            // 
            this.toolStripMenuItem_searchKeys.Name = "toolStripMenuItem_searchKeys";
            this.toolStripMenuItem_searchKeys.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem_searchKeys.Text = "����ü�����";
            this.toolStripMenuItem_searchKeys.Click += new System.EventHandler(this.toolStripMenuItem_searchKeys_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton_inputTimeString
            // 
            this.toolStripDropDownButton_inputTimeString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton_inputTimeString.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_rfc1123Single,
            this.ToolStripMenuItem_uSingle,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_rfc1123Range,
            this.ToolStripMenuItem_uRange});
            this.toolStripDropDownButton_inputTimeString.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_inputTimeString.Image")));
            this.toolStripDropDownButton_inputTimeString.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_inputTimeString.Name = "toolStripDropDownButton_inputTimeString";
            this.toolStripDropDownButton_inputTimeString.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton_inputTimeString.Text = "��ʱ���йصĹ���";
            // 
            // ToolStripMenuItem_rfc1123Single
            // 
            this.ToolStripMenuItem_rfc1123Single.Name = "ToolStripMenuItem_rfc1123Single";
            this.ToolStripMenuItem_rfc1123Single.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_rfc1123Single.Text = "RFC1123ʱ��ֵ...";
            this.ToolStripMenuItem_rfc1123Single.Visible = false;
            this.ToolStripMenuItem_rfc1123Single.Click += new System.EventHandler(this.ToolStripMenuItem_rfc1123Single_Click);
            // 
            // ToolStripMenuItem_uSingle
            // 
            this.ToolStripMenuItem_uSingle.Name = "ToolStripMenuItem_uSingle";
            this.ToolStripMenuItem_uSingle.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_uSingle.Text = "uʱ��ֵ...";
            this.ToolStripMenuItem_uSingle.Click += new System.EventHandler(this.ToolStripMenuItem_uSingle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // ToolStripMenuItem_rfc1123Range
            // 
            this.ToolStripMenuItem_rfc1123Range.Name = "ToolStripMenuItem_rfc1123Range";
            this.ToolStripMenuItem_rfc1123Range.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_rfc1123Range.Text = "RFC1123ʱ��ֵ��Χ...";
            this.ToolStripMenuItem_rfc1123Range.Visible = false;
            this.ToolStripMenuItem_rfc1123Range.Click += new System.EventHandler(this.ToolStripMenuItem_rfc1123Range_Click);
            // 
            // ToolStripMenuItem_uRange
            // 
            this.ToolStripMenuItem_uRange.Name = "ToolStripMenuItem_uRange";
            this.ToolStripMenuItem_uRange.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_uRange.Text = "uʱ��ֵ��Χ...";
            this.ToolStripMenuItem_uRange.Click += new System.EventHandler(this.ToolStripMenuItem_uRange_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // toolStripButton_prevQuery
            // 
            this.toolStripButton_prevQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_prevQuery.Enabled = false;
            this.toolStripButton_prevQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_prevQuery.Image")));
            this.toolStripButton_prevQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_prevQuery.Name = "toolStripButton_prevQuery";
            this.toolStripButton_prevQuery.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_prevQuery.Text = "����";
            this.toolStripButton_prevQuery.Click += new System.EventHandler(this.toolStripButton_prevQuery_Click);
            // 
            // toolStripButton_nextQuery
            // 
            this.toolStripButton_nextQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_nextQuery.Enabled = false;
            this.toolStripButton_nextQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_nextQuery.Image")));
            this.toolStripButton_nextQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_nextQuery.Name = "toolStripButton_nextQuery";
            this.toolStripButton_nextQuery.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_nextQuery.Text = "ǰ��";
            this.toolStripButton_nextQuery.Click += new System.EventHandler(this.toolStripButton_nextQuery_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(233, 31);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(0, 0);
            this.button_search.TabIndex = 14;
            this.button_search.Text = "����(&S)";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 1;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Controls.Add(this.label_message, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.splitContainer_main, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.tableLayoutPanel_main.RowCount = 2;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(489, 405);
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // label_message
            // 
            this.label_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_message.Location = new System.Drawing.Point(0, 371);
            this.label_message.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(489, 22);
            this.label_message.TabIndex = 1;
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.Location = new System.Drawing.Point(3, 15);
            this.splitContainer_main.Name = "splitContainer_main";
            this.splitContainer_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.Controls.Add(this.tabControl_query);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.listView_records);
            this.splitContainer_main.Size = new System.Drawing.Size(483, 351);
            this.splitContainer_main.SplitterDistance = 159;
            this.splitContainer_main.SplitterWidth = 8;
            this.splitContainer_main.TabIndex = 2;
            // 
            // tabControl_query
            // 
            this.tabControl_query.Controls.Add(this.tabPage_simple);
            this.tabControl_query.Controls.Add(this.tabPage_logic);
            this.tabControl_query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_query.Location = new System.Drawing.Point(0, 0);
            this.tabControl_query.Name = "tabControl_query";
            this.tabControl_query.SelectedIndex = 0;
            this.tabControl_query.Size = new System.Drawing.Size(483, 159);
            this.tabControl_query.TabIndex = 1;
            // 
            // tabPage_simple
            // 
            this.tabPage_simple.AutoScroll = true;
            this.tabPage_simple.Controls.Add(this.tableLayoutPanel_query);
            this.tabPage_simple.Location = new System.Drawing.Point(4, 22);
            this.tabPage_simple.Name = "tabPage_simple";
            this.tabPage_simple.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_simple.Size = new System.Drawing.Size(475, 133);
            this.tabPage_simple.TabIndex = 0;
            this.tabPage_simple.Text = "��";
            this.tabPage_simple.UseVisualStyleBackColor = true;
            // 
            // tabPage_logic
            // 
            this.tabPage_logic.AutoScroll = true;
            this.tabPage_logic.Controls.Add(this.dp2QueryControl1);
            this.tabPage_logic.Location = new System.Drawing.Point(4, 22);
            this.tabPage_logic.Name = "tabPage_logic";
            this.tabPage_logic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_logic.Size = new System.Drawing.Size(475, 133);
            this.tabPage_logic.TabIndex = 1;
            this.tabPage_logic.Text = "�߼�";
            this.tabPage_logic.UseVisualStyleBackColor = true;
            // 
            // dp2QueryControl1
            // 
            this.dp2QueryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dp2QueryControl1.Location = new System.Drawing.Point(3, 3);
            this.dp2QueryControl1.Name = "dp2QueryControl1";
            this.dp2QueryControl1.PanelMode = DigitalPlatform.CommonControl.PanelMode.None;
            this.dp2QueryControl1.Size = new System.Drawing.Size(469, 127);
            this.dp2QueryControl1.TabIndex = 0;
            this.dp2QueryControl1.GetList += new DigitalPlatform.CommonControl.GetListEventHandler(this.dp2QueryControl1_GetList);
            this.dp2QueryControl1.ViewXml += new System.EventHandler(this.dp2QueryControl1_ViewXml);
            this.dp2QueryControl1.AppendMenu += new DigitalPlatform.ApendMenuEventHandler(this.dp2QueryControl1_AppendMenu);
            this.dp2QueryControl1.GetFromStyle += new DigitalPlatform.CommonControl.GetFromStyleHandler(this.dp2QueryControl1_GetFromStyle);
            // 
            // listView_records
            // 
            this.listView_records.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_path,
            this.columnHeader_1});
            this.listView_records.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_records.FullRowSelect = true;
            this.listView_records.HideSelection = false;
            this.listView_records.Location = new System.Drawing.Point(0, 0);
            this.listView_records.Margin = new System.Windows.Forms.Padding(0);
            this.listView_records.Name = "listView_records";
            this.listView_records.Size = new System.Drawing.Size(483, 184);
            this.listView_records.TabIndex = 0;
            this.listView_records.UseCompatibleStateImageBehavior = false;
            this.listView_records.View = System.Windows.Forms.View.Details;
            this.listView_records.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_records_ColumnClick);
            this.listView_records.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_records_ItemDrag);
            this.listView_records.SelectedIndexChanged += new System.EventHandler(this.listView_records_SelectedIndexChanged);
            this.listView_records.DoubleClick += new System.EventHandler(this.listView_records_DoubleClick);
            this.listView_records.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_records_MouseUp);
            // 
            // columnHeader_path
            // 
            this.columnHeader_path.Text = "·��";
            this.columnHeader_path.Width = 100;
            // 
            // columnHeader_1
            // 
            this.columnHeader_1.Text = "1";
            this.columnHeader_1.Width = 300;
            // 
            // BiblioSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 405);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BiblioSearchForm";
            this.ShowInTaskbar = false;
            this.Text = "��Ŀ��ѯ";
            this.Activated += new System.EventHandler(this.BiblioSearchForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BiblioSearchForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BiblioSearchForm_FormClosed);
            this.Load += new System.EventHandler(this.BiblioSearchForm_Load);
            this.contextMenuStrip_biblioDb.ResumeLayout(false);
            this.tableLayoutPanel_query.ResumeLayout(false);
            this.tableLayoutPanel_query.PerformLayout();
            this.toolStrip_search.ResumeLayout(false);
            this.toolStrip_search.PerformLayout();
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            this.tabControl_query.ResumeLayout(false);
            this.tabPage_simple.ResumeLayout(false);
            this.tabPage_logic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DigitalPlatform.GUI.ListViewNF listView_records;
        private System.Windows.Forms.ColumnHeader columnHeader_path;
        private System.Windows.Forms.ColumnHeader columnHeader_1;
        private DigitalPlatform.CommonControl.TabComboBox comboBox_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_queryWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_biblioDb;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_viewBiblioDbProperty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_query;
        private System.Windows.Forms.Label label_matchStyle;
        private System.Windows.Forms.ComboBox comboBox_matchStyle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.Label label_message;
        private DigitalPlatform.CommonControl.CheckedComboBox checkedComboBox_biblioDbNames;
        private System.Windows.Forms.ToolStrip toolStrip_search;
        private System.Windows.Forms.ToolStripButton toolStripButton_search;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_searchKeys;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_continueLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_searchKeyID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_prevQuery;
        private System.Windows.Forms.ToolStripButton toolStripButton_nextQuery;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TabControl tabControl_query;
        private System.Windows.Forms.TabPage tabPage_simple;
        private System.Windows.Forms.TabPage tabPage_logic;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private DigitalPlatform.CommonControl.dp2QueryControl dp2QueryControl1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_inputTimeString;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_rfc1123Single;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_uSingle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_rfc1123Range;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_uRange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_searchKeys;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}