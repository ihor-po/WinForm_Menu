namespace TextEditor
{
    partial class te_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(te_form));
            this.te_menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.te_menu_closeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.te_menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.te_menu_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.te_menu_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_font = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_fontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu_backgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.te_statusBar = new System.Windows.Forms.StatusStrip();
            this.te_sb_quantity = new System.Windows.Forms.ToolStripStatusLabel();
            this.te_sb_path = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.te_tsb_newFile = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_open = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.te_tsb_undo = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_redo = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_copy = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_cut = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_insert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.te_tsb_font = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_fontColor = new System.Windows.Forms.ToolStripButton();
            this.te_tsb_backColor = new System.Windows.Forms.ToolStripButton();
            this.te_rtb_editor = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.te_cm_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.te_cm_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.te_cm_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.te_cm_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.te_cm_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.te_menu.SuspendLayout();
            this.te_statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // te_menu
            // 
            this.te_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.te_menu.Location = new System.Drawing.Point(0, 0);
            this.te_menu.Name = "te_menu";
            this.te_menu.Size = new System.Drawing.Size(988, 24);
            this.te_menu.TabIndex = 0;
            this.te_menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.te_menu_newFile,
            this.te_menu_openFile,
            this.te_menu_saveFile,
            this.te_menu_saveAs,
            this.toolStripMenuItem1,
            this.te_menu_closeFile,
            this.toolStripMenuItem2,
            this.te_menu_exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // te_menu_newFile
            // 
            this.te_menu_newFile.Name = "te_menu_newFile";
            this.te_menu_newFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.te_menu_newFile.Size = new System.Drawing.Size(237, 22);
            this.te_menu_newFile.Text = "&Новый файл";
            // 
            // te_menu_openFile
            // 
            this.te_menu_openFile.Name = "te_menu_openFile";
            this.te_menu_openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.te_menu_openFile.Size = new System.Drawing.Size(237, 22);
            this.te_menu_openFile.Text = "&Открыть файл";
            // 
            // te_menu_saveFile
            // 
            this.te_menu_saveFile.Enabled = false;
            this.te_menu_saveFile.Name = "te_menu_saveFile";
            this.te_menu_saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.te_menu_saveFile.Size = new System.Drawing.Size(237, 22);
            this.te_menu_saveFile.Text = "&Сохранить файл";
            // 
            // te_menu_saveAs
            // 
            this.te_menu_saveAs.Name = "te_menu_saveAs";
            this.te_menu_saveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.te_menu_saveAs.Size = new System.Drawing.Size(237, 22);
            this.te_menu_saveAs.Text = "Сохранить &как ...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(234, 6);
            // 
            // te_menu_closeFile
            // 
            this.te_menu_closeFile.Enabled = false;
            this.te_menu_closeFile.Name = "te_menu_closeFile";
            this.te_menu_closeFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.te_menu_closeFile.Size = new System.Drawing.Size(237, 22);
            this.te_menu_closeFile.Text = "&Закрыть файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(234, 6);
            // 
            // te_menu_exit
            // 
            this.te_menu_exit.Name = "te_menu_exit";
            this.te_menu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.te_menu_exit.Size = new System.Drawing.Size(237, 22);
            this.te_menu_exit.Text = "&Выход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.te_menu_undo,
            this.te_menu_redo,
            this.toolStripMenuItem3,
            this.te_menu_copy,
            this.te_menu_cut,
            this.te_menu_insert,
            this.toolStripMenuItem4,
            this.te_menu_selectAll});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // te_menu_undo
            // 
            this.te_menu_undo.Enabled = false;
            this.te_menu_undo.Name = "te_menu_undo";
            this.te_menu_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.te_menu_undo.Size = new System.Drawing.Size(184, 22);
            this.te_menu_undo.Text = "Отменить";
            // 
            // te_menu_redo
            // 
            this.te_menu_redo.Enabled = false;
            this.te_menu_redo.Name = "te_menu_redo";
            this.te_menu_redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.te_menu_redo.Size = new System.Drawing.Size(184, 22);
            this.te_menu_redo.Text = "Вернуть";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
            // 
            // te_menu_copy
            // 
            this.te_menu_copy.Enabled = false;
            this.te_menu_copy.Name = "te_menu_copy";
            this.te_menu_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.te_menu_copy.Size = new System.Drawing.Size(184, 22);
            this.te_menu_copy.Text = "Копировать";
            // 
            // te_menu_cut
            // 
            this.te_menu_cut.Enabled = false;
            this.te_menu_cut.Name = "te_menu_cut";
            this.te_menu_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.te_menu_cut.Size = new System.Drawing.Size(184, 22);
            this.te_menu_cut.Text = "Вырезать";
            // 
            // te_menu_insert
            // 
            this.te_menu_insert.Enabled = false;
            this.te_menu_insert.Name = "te_menu_insert";
            this.te_menu_insert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.te_menu_insert.Size = new System.Drawing.Size(184, 22);
            this.te_menu_insert.Text = "Вставить";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
            // 
            // te_menu_selectAll
            // 
            this.te_menu_selectAll.Enabled = false;
            this.te_menu_selectAll.Name = "te_menu_selectAll";
            this.te_menu_selectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.te_menu_selectAll.Size = new System.Drawing.Size(184, 22);
            this.te_menu_selectAll.Text = "Выбрать все";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.te_menu_font,
            this.te_menu_fontColor,
            this.te_menu_backgroundColor});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // te_menu_font
            // 
            this.te_menu_font.Name = "te_menu_font";
            this.te_menu_font.Size = new System.Drawing.Size(148, 22);
            this.te_menu_font.Text = "Шриф";
            // 
            // te_menu_fontColor
            // 
            this.te_menu_fontColor.Name = "te_menu_fontColor";
            this.te_menu_fontColor.Size = new System.Drawing.Size(148, 22);
            this.te_menu_fontColor.Text = "Цвет шрифта";
            // 
            // te_menu_backgroundColor
            // 
            this.te_menu_backgroundColor.Name = "te_menu_backgroundColor";
            this.te_menu_backgroundColor.Size = new System.Drawing.Size(148, 22);
            this.te_menu_backgroundColor.Text = "Цвет фона";
            // 
            // te_statusBar
            // 
            this.te_statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.te_sb_quantity,
            this.te_sb_path});
            this.te_statusBar.Location = new System.Drawing.Point(0, 738);
            this.te_statusBar.Name = "te_statusBar";
            this.te_statusBar.Size = new System.Drawing.Size(988, 22);
            this.te_statusBar.SizingGrip = false;
            this.te_statusBar.TabIndex = 1;
            this.te_statusBar.Text = "statusStrip1";
            // 
            // te_sb_quantity
            // 
            this.te_sb_quantity.Name = "te_sb_quantity";
            this.te_sb_quantity.Size = new System.Drawing.Size(64, 17);
            this.te_sb_quantity.Text = "Символов";
            // 
            // te_sb_path
            // 
            this.te_sb_path.Name = "te_sb_path";
            this.te_sb_path.Size = new System.Drawing.Size(33, 17);
            this.te_sb_path.Text = "Путь";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.te_tsb_newFile,
            this.te_tsb_open,
            this.te_tsb_save,
            this.toolStripSeparator1,
            this.te_tsb_undo,
            this.te_tsb_redo,
            this.te_tsb_copy,
            this.te_tsb_cut,
            this.te_tsb_insert,
            this.toolStripSeparator2,
            this.te_tsb_font,
            this.te_tsb_fontColor,
            this.te_tsb_backColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // te_tsb_newFile
            // 
            this.te_tsb_newFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_newFile.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_newFile.Image")));
            this.te_tsb_newFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_newFile.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.te_tsb_newFile.Name = "te_tsb_newFile";
            this.te_tsb_newFile.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_newFile.Tag = "Новый файл";
            this.te_tsb_newFile.Text = "Новый файл";
            // 
            // te_tsb_open
            // 
            this.te_tsb_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_open.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_open.Image")));
            this.te_tsb_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_open.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.te_tsb_open.Name = "te_tsb_open";
            this.te_tsb_open.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_open.Tag = "Открыть файл";
            this.te_tsb_open.Text = "Открыть файл";
            this.te_tsb_open.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // te_tsb_save
            // 
            this.te_tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_save.Enabled = false;
            this.te_tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_save.Image")));
            this.te_tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_save.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.te_tsb_save.Name = "te_tsb_save";
            this.te_tsb_save.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_save.Tag = "Сохранить файл";
            this.te_tsb_save.Text = "Сохранить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // te_tsb_undo
            // 
            this.te_tsb_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_undo.Enabled = false;
            this.te_tsb_undo.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_undo.Image")));
            this.te_tsb_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_undo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_undo.Name = "te_tsb_undo";
            this.te_tsb_undo.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_undo.Text = "toolStripButton1";
            this.te_tsb_undo.ToolTipText = "Отменить";
            // 
            // te_tsb_redo
            // 
            this.te_tsb_redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_redo.Enabled = false;
            this.te_tsb_redo.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_redo.Image")));
            this.te_tsb_redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_redo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_redo.Name = "te_tsb_redo";
            this.te_tsb_redo.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_redo.Text = "Вернуть";
            // 
            // te_tsb_copy
            // 
            this.te_tsb_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_copy.Enabled = false;
            this.te_tsb_copy.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_copy.Image")));
            this.te_tsb_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_copy.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_copy.Name = "te_tsb_copy";
            this.te_tsb_copy.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_copy.Text = "Копировать";
            // 
            // te_tsb_cut
            // 
            this.te_tsb_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_cut.Enabled = false;
            this.te_tsb_cut.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_cut.Image")));
            this.te_tsb_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_cut.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_cut.Name = "te_tsb_cut";
            this.te_tsb_cut.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_cut.Text = "Вырезать";
            // 
            // te_tsb_insert
            // 
            this.te_tsb_insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_insert.Enabled = false;
            this.te_tsb_insert.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_insert.Image")));
            this.te_tsb_insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_insert.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_insert.Name = "te_tsb_insert";
            this.te_tsb_insert.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_insert.Text = "Вставить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // te_tsb_font
            // 
            this.te_tsb_font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_font.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_font.Image")));
            this.te_tsb_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_font.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_font.Name = "te_tsb_font";
            this.te_tsb_font.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_font.Text = "Шрифт";
            // 
            // te_tsb_fontColor
            // 
            this.te_tsb_fontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_fontColor.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_fontColor.Image")));
            this.te_tsb_fontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_fontColor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_fontColor.Name = "te_tsb_fontColor";
            this.te_tsb_fontColor.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_fontColor.Text = "Цвет шрифта";
            // 
            // te_tsb_backColor
            // 
            this.te_tsb_backColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.te_tsb_backColor.Image = ((System.Drawing.Image)(resources.GetObject("te_tsb_backColor.Image")));
            this.te_tsb_backColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.te_tsb_backColor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.te_tsb_backColor.Name = "te_tsb_backColor";
            this.te_tsb_backColor.Size = new System.Drawing.Size(28, 28);
            this.te_tsb_backColor.Text = "Цвет фона";
            // 
            // te_rtb_editor
            // 
            this.te_rtb_editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.te_rtb_editor.ContextMenuStrip = this.contextMenuStrip1;
            this.te_rtb_editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.te_rtb_editor.Enabled = false;
            this.te_rtb_editor.Location = new System.Drawing.Point(0, 55);
            this.te_rtb_editor.Name = "te_rtb_editor";
            this.te_rtb_editor.Size = new System.Drawing.Size(988, 683);
            this.te_rtb_editor.TabIndex = 3;
            this.te_rtb_editor.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.te_cm_undo,
            this.te_cm_redo,
            this.toolStripMenuItem5,
            this.te_cm_copy,
            this.te_cm_cut,
            this.te_cm_insert});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 120);
            // 
            // te_cm_undo
            // 
            this.te_cm_undo.Enabled = false;
            this.te_cm_undo.Name = "te_cm_undo";
            this.te_cm_undo.Size = new System.Drawing.Size(139, 22);
            this.te_cm_undo.Text = "Отменить";
            // 
            // te_cm_redo
            // 
            this.te_cm_redo.Enabled = false;
            this.te_cm_redo.Name = "te_cm_redo";
            this.te_cm_redo.Size = new System.Drawing.Size(139, 22);
            this.te_cm_redo.Text = "Вернуть";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(136, 6);
            // 
            // te_cm_copy
            // 
            this.te_cm_copy.Enabled = false;
            this.te_cm_copy.Name = "te_cm_copy";
            this.te_cm_copy.Size = new System.Drawing.Size(139, 22);
            this.te_cm_copy.Text = "Копировать";
            // 
            // te_cm_cut
            // 
            this.te_cm_cut.Enabled = false;
            this.te_cm_cut.Name = "te_cm_cut";
            this.te_cm_cut.Size = new System.Drawing.Size(139, 22);
            this.te_cm_cut.Text = "Вырезать";
            // 
            // te_cm_insert
            // 
            this.te_cm_insert.Enabled = false;
            this.te_cm_insert.Name = "te_cm_insert";
            this.te_cm_insert.Size = new System.Drawing.Size(139, 22);
            this.te_cm_insert.Text = "Вставить";
            // 
            // te_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 760);
            this.Controls.Add(this.te_rtb_editor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.te_statusBar);
            this.Controls.Add(this.te_menu);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.te_menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "te_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.te_menu.ResumeLayout(false);
            this.te_menu.PerformLayout();
            this.te_statusBar.ResumeLayout(false);
            this.te_statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip te_menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.StatusStrip te_statusBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton te_tsb_newFile;
        private System.Windows.Forms.ToolStripButton te_tsb_open;
        private System.Windows.Forms.ToolStripButton te_tsb_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox te_rtb_editor;
        private System.Windows.Forms.ToolStripMenuItem te_menu_newFile;
        private System.Windows.Forms.ToolStripMenuItem te_menu_openFile;
        private System.Windows.Forms.ToolStripMenuItem te_menu_saveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem te_menu_exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem te_cm_undo;
        private System.Windows.Forms.ToolStripStatusLabel te_sb_quantity;
        private System.Windows.Forms.ToolStripStatusLabel te_sb_path;
        private System.Windows.Forms.ToolStripMenuItem te_menu_closeFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem te_menu_saveAs;
        private System.Windows.Forms.ToolStripMenuItem te_menu_undo;
        private System.Windows.Forms.ToolStripMenuItem te_menu_redo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem te_menu_copy;
        private System.Windows.Forms.ToolStripMenuItem te_menu_cut;
        private System.Windows.Forms.ToolStripMenuItem te_menu_insert;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem te_menu_selectAll;
        private System.Windows.Forms.ToolStripButton te_tsb_undo;
        private System.Windows.Forms.ToolStripButton te_tsb_redo;
        private System.Windows.Forms.ToolStripButton te_tsb_copy;
        private System.Windows.Forms.ToolStripButton te_tsb_cut;
        private System.Windows.Forms.ToolStripButton te_tsb_insert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton te_tsb_font;
        private System.Windows.Forms.ToolStripButton te_tsb_fontColor;
        private System.Windows.Forms.ToolStripButton te_tsb_backColor;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem te_menu_font;
        private System.Windows.Forms.ToolStripMenuItem te_menu_fontColor;
        private System.Windows.Forms.ToolStripMenuItem te_menu_backgroundColor;
        private System.Windows.Forms.ToolStripMenuItem te_cm_redo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem te_cm_copy;
        private System.Windows.Forms.ToolStripMenuItem te_cm_cut;
        private System.Windows.Forms.ToolStripMenuItem te_cm_insert;
    }
}

