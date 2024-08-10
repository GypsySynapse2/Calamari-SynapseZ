namespace Calamari_CH
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002A4A File Offset: 0x00000C4A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002A6C File Offset: 0x00000C6C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calamariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.scriptLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.explorerViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.darkDexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.multiInstancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Scripts = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calamariToolStripMenuItem,
            this.toolStripSeparator9,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.injectorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(404, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calamariToolStripMenuItem
            // 
            this.calamariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.calamariToolStripMenuItem.Name = "calamariToolStripMenuItem";
            this.calamariToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.calamariToolStripMenuItem.Text = "Calamari";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.environmentDetailsToolStripMenuItem,
            this.toolStripSeparator4,
            this.scriptLibraryToolStripMenuItem,
            this.openSavesFolderToolStripMenuItem,
            this.toolStripSeparator5,
            this.explorerViewToolStripMenuItem,
            this.scriptToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // environmentDetailsToolStripMenuItem
            // 
            this.environmentDetailsToolStripMenuItem.Name = "environmentDetailsToolStripMenuItem";
            this.environmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.environmentDetailsToolStripMenuItem.Text = "Environment Details";
            this.environmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.environmentDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // scriptLibraryToolStripMenuItem
            // 
            this.scriptLibraryToolStripMenuItem.CheckOnClick = true;
            this.scriptLibraryToolStripMenuItem.Name = "scriptLibraryToolStripMenuItem";
            this.scriptLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scriptLibraryToolStripMenuItem.Text = "Script Library";
            this.scriptLibraryToolStripMenuItem.Click += new System.EventHandler(this.scriptLibraryToolStripMenuItem_Click);
            // 
            // openSavesFolderToolStripMenuItem
            // 
            this.openSavesFolderToolStripMenuItem.Name = "openSavesFolderToolStripMenuItem";
            this.openSavesFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSavesFolderToolStripMenuItem.Text = "Open Saves Folder";
            this.openSavesFolderToolStripMenuItem.Click += new System.EventHandler(this.openSavesFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // explorerViewToolStripMenuItem
            // 
            this.explorerViewToolStripMenuItem.Name = "explorerViewToolStripMenuItem";
            this.explorerViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.explorerViewToolStripMenuItem.Text = "Explorer View";
            this.explorerViewToolStripMenuItem.Click += new System.EventHandler(this.explorerViewToolStripMenuItem_Click);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.CheckOnClick = true;
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scriptToolStripMenuItem.Text = "Script-Editor View";
            this.scriptToolStripMenuItem.Click += new System.EventHandler(this.scriptToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveScriptsToolStripMenuItem,
            this.toolStripSeparator6,
            this.darkDexToolStripMenuItem,
            this.savePlaceToolStripMenuItem,
            this.toolStripSeparator7,
            this.multiInstancesToolStripMenuItem,
            this.killApplicationsToolStripMenuItem,
            this.toolStripSeparator8,
            this.topMostToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // saveScriptsToolStripMenuItem
            // 
            this.saveScriptsToolStripMenuItem.Name = "saveScriptsToolStripMenuItem";
            this.saveScriptsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveScriptsToolStripMenuItem.Text = "Save Scripts";
            this.saveScriptsToolStripMenuItem.Click += new System.EventHandler(this.saveScriptsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(164, 6);
            // 
            // darkDexToolStripMenuItem
            // 
            this.darkDexToolStripMenuItem.Name = "darkDexToolStripMenuItem";
            this.darkDexToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.darkDexToolStripMenuItem.Text = "Dark Dex";
            this.darkDexToolStripMenuItem.Click += new System.EventHandler(this.darkDexToolStripMenuItem_Click);
            // 
            // savePlaceToolStripMenuItem
            // 
            this.savePlaceToolStripMenuItem.Name = "savePlaceToolStripMenuItem";
            this.savePlaceToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.savePlaceToolStripMenuItem.Text = "Save Place";
            this.savePlaceToolStripMenuItem.Click += new System.EventHandler(this.savePlaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(164, 6);
            // 
            // multiInstancesToolStripMenuItem
            // 
            this.multiInstancesToolStripMenuItem.Name = "multiInstancesToolStripMenuItem";
            this.multiInstancesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            // 
            // killApplicationsToolStripMenuItem
            // 
            this.killApplicationsToolStripMenuItem.Name = "killApplicationsToolStripMenuItem";
            this.killApplicationsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.killApplicationsToolStripMenuItem.Text = "Kill Application(s)";
            this.killApplicationsToolStripMenuItem.Click += new System.EventHandler(this.killApplicationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(164, 6);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // injectorToolStripMenuItem
            // 
            this.injectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachToolStripMenuItem});
            this.injectorToolStripMenuItem.Name = "injectorToolStripMenuItem";
            this.injectorToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.injectorToolStripMenuItem.Text = "Inject";
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.attachToolStripMenuItem.Text = "Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.attachToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(4, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(394, 197);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Welcome to Calamari! To attach please go to Inject > Attach.";
            // 
            // Scripts
            // 
            this.Scripts.FormattingEnabled = true;
            this.Scripts.Location = new System.Drawing.Point(404, 26);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(221, 329);
            this.Scripts.TabIndex = 5;
            this.Scripts.SelectedIndexChanged += new System.EventHandler(this.Scripts_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "▶";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(367, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "❌";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scintilla1
            // 
            this.scintilla1.AllowDrop = true;
            this.scintilla1.AnnotationVisible = ScintillaNET.Annotation.Standard;
            this.scintilla1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scintilla1.CaretLineBackColor = System.Drawing.Color.PowderBlue;
            this.scintilla1.CaretLineVisible = true;
            this.scintilla1.CaretStyle = ScintillaNET.CaretStyle.Block;
            this.scintilla1.EdgeColor = System.Drawing.Color.Maroon;
            this.scintilla1.EdgeMode = ScintillaNET.EdgeMode.Line;
            this.scintilla1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scintilla1.IndentationGuides = ScintillaNET.IndentView.Real;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Lua;
            this.scintilla1.Location = new System.Drawing.Point(4, 228);
            this.scintilla1.MultipleSelection = true;
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(394, 129);
            this.scintilla1.TabIndex = 8;
            this.scintilla1.Text = "print\"Hi!\"";
            this.scintilla1.UseTabs = true;
            this.scintilla1.WrapMode = ScintillaNET.WrapMode.Whitespace;
            this.scintilla1.WrapVisualFlagLocation = ScintillaNET.WrapVisualFlagLocation.StartByText;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 389);
            this.Controls.Add(this.scintilla1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ToolStripMenuItem calamariToolStripMenuItem;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ToolStripMenuItem injectorToolStripMenuItem;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ListBox Scripts;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripMenuItem environmentDetailsToolStripMenuItem;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripMenuItem scriptLibraryToolStripMenuItem;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ToolStripMenuItem openSavesFolderToolStripMenuItem;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripMenuItem explorerViewToolStripMenuItem;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400002A RID: 42
		private global::ScintillaNET.Scintilla scintilla1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ToolStripMenuItem saveScriptsToolStripMenuItem;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.ToolStripMenuItem darkDexToolStripMenuItem;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ToolStripMenuItem savePlaceToolStripMenuItem;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripMenuItem multiInstancesToolStripMenuItem;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripMenuItem killApplicationsToolStripMenuItem;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
	}
}
