namespace NotePadeFarsi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCharCountValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWordCountName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWordCoundValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReplace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrint = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.فایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.چاپToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.واگردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPast = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.جستجوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جایگزینیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.انتخابهمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.درجتاریخToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قالببندیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.نماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنمایاستفادهازبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشخطاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 647);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statusBar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 623);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 24);
            this.panel4.TabIndex = 2;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCharCount,
            this.lblCharCountValue,
            this.lblWordCountName,
            this.lblWordCoundValue});
            this.statusBar.Location = new System.Drawing.Point(0, -5);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(768, 29);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblCharCount
            // 
            this.lblCharCount.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(81, 24);
            this.lblCharCount.Text = "تعداد کاراکتر:";
            // 
            // lblCharCountValue
            // 
            this.lblCharCountValue.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblCharCountValue.Name = "lblCharCountValue";
            this.lblCharCountValue.Size = new System.Drawing.Size(14, 24);
            this.lblCharCountValue.Text = "0";
            // 
            // lblWordCountName
            // 
            this.lblWordCountName.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.lblWordCountName.Name = "lblWordCountName";
            this.lblWordCountName.Size = new System.Drawing.Size(69, 24);
            this.lblWordCountName.Text = "تعداد کلمه:";
            // 
            // lblWordCoundValue
            // 
            this.lblWordCoundValue.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblWordCoundValue.Name = "lblWordCoundValue";
            this.lblWordCoundValue.Size = new System.Drawing.Size(14, 24);
            this.lblWordCoundValue.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 592);
            this.panel3.TabIndex = 1;
            // 
            // richText
            // 
            this.richText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText.Location = new System.Drawing.Point(0, 0);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(768, 592);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            this.richText.TextChanged += new System.EventHandler(this.TxtChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolBar);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 55);
            this.panel2.TabIndex = 0;
            // 
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripCut,
            this.toolStripExit,
            this.toolStripSeparator6,
            this.toolStripReplace,
            this.toolStripSearch,
            this.toolStripSeparator7,
            this.toolStripComboBox1,
            this.toolStripSeparator8,
            this.toolStripPrint});
            this.toolBar.Location = new System.Drawing.Point(0, 30);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(768, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Image = global::NotePadeFarsi.Properties.Resources.icons8_copy_file_64;
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopy.Text = "کپی";
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Image = global::NotePadeFarsi.Properties.Resources.icons8_paste_64;
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripPaste.Text = "چسباندن";
            // 
            // toolStripCut
            // 
            this.toolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCut.Image = global::NotePadeFarsi.Properties.Resources.icons8_cut_64;
            this.toolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCut.Name = "toolStripCut";
            this.toolStripCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripCut.Text = "برش";
            // 
            // toolStripExit
            // 
            this.toolStripExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripExit.Image = global::NotePadeFarsi.Properties.Resources.icons8_logout_16;
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripExit.Text = "خروج";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripReplace
            // 
            this.toolStripReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReplace.Image = global::NotePadeFarsi.Properties.Resources.icons8_replacement_48;
            this.toolStripReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReplace.Name = "toolStripReplace";
            this.toolStripReplace.Size = new System.Drawing.Size(23, 22);
            this.toolStripReplace.Text = "جایگذاری";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearch.Image = global::NotePadeFarsi.Properties.Resources.icons8_search_file_32;
            this.toolStripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripSearch.Text = "جستجو";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrint.Image = global::NotePadeFarsi.Properties.Resources.icons8_print_64;
            this.toolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripPrint.Text = "پرینت";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فایلToolStripMenuItem,
            this.ویرایشToolStripMenuItem,
            this.قالببندیToolStripMenuItem,
            this.نماToolStripMenuItem,
            this.راهنماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            this.فایلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewFile,
            this.mnuOpenFile,
            this.mnuOpenNewProject,
            this.toolStripSeparator1,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripSeparator2,
            this.چاپToolStripMenuItem,
            this.toolStripSeparator3,
            this.mnuExit});
            this.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            this.فایلToolStripMenuItem.Size = new System.Drawing.Size(40, 26);
            this.فایلToolStripMenuItem.Text = "فایل";
            // 
            // MenuItemNewFile
            // 
            this.MenuItemNewFile.Image = global::NotePadeFarsi.Properties.Resources.icons8_new_file_64;
            this.MenuItemNewFile.Name = "MenuItemNewFile";
            this.MenuItemNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemNewFile.Size = new System.Drawing.Size(242, 22);
            this.MenuItemNewFile.Text = "سند جدید";
            this.MenuItemNewFile.Click += new System.EventHandler(this.MenuItemNewFile_Click);
            // 
            // mnuOpenFile
            // 
            this.mnuOpenFile.Image = global::NotePadeFarsi.Properties.Resources.icons8_open_file_64;
            this.mnuOpenFile.Name = "mnuOpenFile";
            this.mnuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenFile.Size = new System.Drawing.Size(242, 22);
            this.mnuOpenFile.Text = "باز کردن سند";
            this.mnuOpenFile.Click += new System.EventHandler(this.mnuOpenFile_Click);
            // 
            // mnuOpenNewProject
            // 
            this.mnuOpenNewProject.Image = global::NotePadeFarsi.Properties.Resources.icons8_new_window_50;
            this.mnuOpenNewProject.Name = "mnuOpenNewProject";
            this.mnuOpenNewProject.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mnuOpenNewProject.Size = new System.Drawing.Size(242, 22);
            this.mnuOpenNewProject.Text = "باز کردن پنجره جدید";
            this.mnuOpenNewProject.Click += new System.EventHandler(this.mnuOpenNewProject_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::NotePadeFarsi.Properties.Resources.icons8_save_64;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(242, 22);
            this.mnuSave.Text = "ذخیره";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Image = global::NotePadeFarsi.Properties.Resources.icons8_save_as_100;
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuSaveAs.Size = new System.Drawing.Size(242, 22);
            this.mnuSaveAs.Text = "ذخیره در";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // چاپToolStripMenuItem
            // 
            this.چاپToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_print_64;
            this.چاپToolStripMenuItem.Name = "چاپToolStripMenuItem";
            this.چاپToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.چاپToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.چاپToolStripMenuItem.Text = "چاپ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::NotePadeFarsi.Properties.Resources.icons8_logout_16;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuExit.Size = new System.Drawing.Size(242, 22);
            this.mnuExit.Text = "خروج از برنامه";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.واگردToolStripMenuItem,
            this.mnuCopy,
            this.mnuPast,
            this.mnuCut,
            this.mnuDelete,
            this.toolStripSeparator4,
            this.جستجوToolStripMenuItem,
            this.جایگزینیToolStripMenuItem,
            this.toolStripSeparator5,
            this.انتخابهمهToolStripMenuItem,
            this.درجتاریخToolStripMenuItem});
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // واگردToolStripMenuItem
            // 
            this.واگردToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_back_48;
            this.واگردToolStripMenuItem.Name = "واگردToolStripMenuItem";
            this.واگردToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.واگردToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.واگردToolStripMenuItem.Text = "واگرد";
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = global::NotePadeFarsi.Properties.Resources.icons8_copy_file_64;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(192, 22);
            this.mnuCopy.Text = "رونوشت";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPast
            // 
            this.mnuPast.Image = global::NotePadeFarsi.Properties.Resources.icons8_paste_64;
            this.mnuPast.Name = "mnuPast";
            this.mnuPast.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPast.Size = new System.Drawing.Size(192, 22);
            this.mnuPast.Text = "چسباندن";
            this.mnuPast.Click += new System.EventHandler(this.mnuPast_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.Image = global::NotePadeFarsi.Properties.Resources.icons8_cut_64;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCut.Size = new System.Drawing.Size(192, 22);
            this.mnuCut.Text = "برش";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Image = global::NotePadeFarsi.Properties.Resources.icons8_delete_100;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDelete.Size = new System.Drawing.Size(192, 22);
            this.mnuDelete.Text = "حذف";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(189, 6);
            // 
            // جستجوToolStripMenuItem
            // 
            this.جستجوToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_search_file_32;
            this.جستجوToolStripMenuItem.Name = "جستجوToolStripMenuItem";
            this.جستجوToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.جستجوToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.جستجوToolStripMenuItem.Text = "جستجو";
            // 
            // جایگزینیToolStripMenuItem
            // 
            this.جایگزینیToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_replacement_48;
            this.جایگزینیToolStripMenuItem.Name = "جایگزینیToolStripMenuItem";
            this.جایگزینیToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.جایگزینیToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.جایگزینیToolStripMenuItem.Text = "جایگزینی";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(189, 6);
            // 
            // انتخابهمهToolStripMenuItem
            // 
            this.انتخابهمهToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_select_all_64;
            this.انتخابهمهToolStripMenuItem.Name = "انتخابهمهToolStripMenuItem";
            this.انتخابهمهToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.انتخابهمهToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.انتخابهمهToolStripMenuItem.Text = "انتخاب همه";
            // 
            // درجتاریخToolStripMenuItem
            // 
            this.درجتاریخToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_date_to_64;
            this.درجتاریخToolStripMenuItem.Name = "درجتاریخToolStripMenuItem";
            this.درجتاریخToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.درجتاریخToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.درجتاریخToolStripMenuItem.Text = "درج تاریخ";
            // 
            // قالببندیToolStripMenuItem
            // 
            this.قالببندیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont});
            this.قالببندیToolStripMenuItem.Name = "قالببندیToolStripMenuItem";
            this.قالببندیToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.قالببندیToolStripMenuItem.Text = "قالب بندی";
            // 
            // mnuFont
            // 
            this.mnuFont.Image = global::NotePadeFarsi.Properties.Resources.icons8_font_16;
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.mnuFont.Size = new System.Drawing.Size(173, 22);
            this.mnuFont.Text = "فونت";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // نماToolStripMenuItem
            // 
            this.نماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStatus,
            this.mnuTools});
            this.نماToolStripMenuItem.Name = "نماToolStripMenuItem";
            this.نماToolStripMenuItem.Size = new System.Drawing.Size(33, 26);
            this.نماToolStripMenuItem.Text = "نما";
            // 
            // mnuStatus
            // 
            this.mnuStatus.Checked = true;
            this.mnuStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuStatus.Name = "mnuStatus";
            this.mnuStatus.Size = new System.Drawing.Size(135, 22);
            this.mnuStatus.Text = "نوار وضعیت";
            this.mnuStatus.Click += new System.EventHandler(this.mnuStatus_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.Checked = true;
            this.mnuTools.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(135, 22);
            this.mnuTools.Text = "جعبه ابزار";
            this.mnuTools.Click += new System.EventHandler(this.mnuTools_Click);
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.راهنمایاستفادهازبرنامهToolStripMenuItem,
            this.گزارشخطاToolStripMenuItem,
            this.دربارهماToolStripMenuItem});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // راهنمایاستفادهازبرنامهToolStripMenuItem
            // 
            this.راهنمایاستفادهازبرنامهToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_help_64;
            this.راهنمایاستفادهازبرنامهToolStripMenuItem.Name = "راهنمایاستفادهازبرنامهToolStripMenuItem";
            this.راهنمایاستفادهازبرنامهToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.راهنمایاستفادهازبرنامهToolStripMenuItem.Text = "راهنمای استفاده از برنامه";
            // 
            // گزارشخطاToolStripMenuItem
            // 
            this.گزارشخطاToolStripMenuItem.Name = "گزارشخطاToolStripMenuItem";
            this.گزارشخطاToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.گزارشخطاToolStripMenuItem.Text = "گزارش خطا";
            // 
            // دربارهماToolStripMenuItem
            // 
            this.دربارهماToolStripMenuItem.Image = global::NotePadeFarsi.Properties.Resources.icons8_call_64;
            this.دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            this.دربارهماToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.دربارهماToolStripMenuItem.Text = "درباره ما";
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            this.saveDialog.Title = "ذخیره کردن سند";
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openDialog";
            this.openDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            this.openDialog.Title = "باز کردن سند";
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 647);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه یادداشت (فارسی)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblCharCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem فایلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenNewProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem چاپToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem واگردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPast;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem جستجوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جایگزینیToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem انتخابهمهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem درجتاریخToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قالببندیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem نماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنمایاستفادهازبرنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشخطاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهماToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblCharCountValue;
        private System.Windows.Forms.ToolStripStatusLabel lblWordCountName;
        private System.Windows.Forms.ToolStripStatusLabel lblWordCoundValue;
        private System.Windows.Forms.ToolStripButton toolStripCut;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripReplace;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripPrint;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}

