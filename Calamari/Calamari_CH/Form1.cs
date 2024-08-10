using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using static System.Net.Mime.MediaTypeNames;
using SynapseZAPI;
using System.Security.Cryptography;

namespace Calamari_CH
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
        public SynapseZAPI.SynapseZAPI synapseZAPI = new SynapseZAPI.SynapseZAPI();
        // Token: 0x0600000B RID: 11 RVA: 0x00002130 File Offset: 0x00000330
        public Form1()
		{
			this.InitializeComponent();
			this.timer1.Enabled = true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021EC File Offset: 0x000003E

		// Token: 0x0600000E RID: 14 RVA: 0x00002284 File Offset: 0x00000484
		private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.scriptToolStripMenuItem.Checked)
			{
				this.scintilla1.Size = new Size(394, 332);
				this.scintilla1.Location = new Point(4, 25);
				return;
			}
			this.scintilla1.Size = new Size(394, 129);
			this.scintilla1.Location = new Point(4, 228);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022FC File Offset: 0x000004FC
		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.scintilla1.Text = "-- New Script";
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002310 File Offset: 0x00000510
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.scintilla1.Text = File.ReadAllText(Functions.openfiledialog.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002370 File Offset: 0x00000570
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			object[] array = new string[0];
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Lua Script (*.lua)|*.lua|Text File (*.txt)|*.txt|All Files (*.*)|*.*";
				saveFileDialog.Title = "Calamari - Save File";
				saveFileDialog.ShowDialog();
				try
				{
					string fileName = saveFileDialog.FileName;
					string text = this.scintilla1.Text;
					string[] contents = new string[]
					{
						text.ToString(),
						""
					};
					File.WriteAllLines(saveFileDialog.FileName, contents);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000240C File Offset: 0x0000060C
		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.scintilla1.Undo();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002419 File Offset: 0x00000619
		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.scintilla1.Redo();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002426 File Offset: 0x00000626
		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.scintilla1.SelectAll();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002433 File Offset: 0x00000633
		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.scintilla1.Cut();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002440 File Offset: 0x00000640
		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.scintilla1.Copy();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000244D File Offset: 0x0000064D
		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.scintilla1.Paste();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000245A File Offset: 0x0000065A
		private void environmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("PP");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002468 File Offset: 0x00000668
		private void scriptLibraryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.scriptLibraryToolStripMenuItem.Checked)
			{
				this.Scripts.Items.Clear();
				Functions.PopulateListBox(this.Scripts, "./Scripts", "*.txt");
				Functions.PopulateListBox(this.Scripts, "./Scripts", "*.lua");
				Form.ActiveForm.Size = new Size(646, 428);
				return;
			}
			Form.ActiveForm.Size = new Size(419, 428);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000024EF File Offset: 0x000006EF
		private void explorerViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("I have aids");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000024FC File Offset: 0x000006FC
		private void saveScriptsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("no");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002509 File Offset: 0x00000709
		private void darkDexToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.lib.Execute("loadstring(game:HttpGet('https://raw.githubusercontent.com/Babyhamsta/RBLX_Scripts/main/Universal/BypassedDarkDexV3.lua', true))()");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000251A File Offset: 0x0000071A
		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("DM ProblematicLua#8146 for help", "Help");
		}

        public void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        // Token: 0x0600001E RID: 30 RVA: 0x0000252C File Offset: 0x0000072C
        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**
 * Return values:
 * 0 - Injection successful
 * 1 - MainPath is not a valid Directory
 * 2 - Launcher not found in MainPath
 * 3 - Couldn't start the launcher
*/
            synapseZAPI.Inject(Directory.GetCurrentDirectory() /*<- MainPath*/);
        }


        // Token: 0x0600001F RID: 31 RVA: 0x00002539 File Offset: 0x00000739
        private void savePlaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
            string celeryPath = Path.Combine(Path.GetTempPath(), "celery");
            File.WriteAllText(Path.Combine(celeryPath, "myfile.txt"), "saveinstance()");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000254A File Offset: 0x0000074A

		// Token: 0x06000021 RID: 33 RVA: 0x0000258C File Offset: 0x0000078C
		private void killApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			int num = 0;
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
				num++;
			}
			MessageBox.Show(string.Format("Terminated {0} Process", num));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025D6 File Offset: 0x000007D6
		private void button1_Click(object sender, EventArgs e)
		{
			/**
             * Return values:
             * 0 - Execution successful
             * 1 - MainPath is not a valid Directory
             * 2 - Bin Folder not found
             * 3 - Scheduler Folder not found
             * 4 - No access to write file
*/

			synapseZAPI.Execute(Directory.GetCurrentDirectory() /*<- MainPath*/, scintilla1.Text);
        }

    // Token: 0x06000023 RID: 35 RVA: 0x000025ED File Offset: 0x000007ED
    private void button2_Click(object sender, EventArgs e)
		{
			this.scintilla1.Text = "";
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000025FF File Offset: 0x000007FF
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002608 File Offset: 0x00000808
		private void Form1_Load(object sender, EventArgs e)
		{
			this.textBox1.ForeColor = Color.Black;
			this.textBox1.BackColor = Color.White;
			this.textBox1.Text = "Welcome to Calamari! To attach please go to Inject > Attach.";
			string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string str2 = "0123456789";
			string str3 = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";
			this.scintilla1.StyleResetDefault();
			this.scintilla1.Styles[32].Font = "Consolas";
			this.scintilla1.Styles[32].Size = 10;
			this.scintilla1.StyleClearAll();
			this.scintilla1.Styles[0].ForeColor = Color.Silver;
			this.scintilla1.Styles[1].ForeColor = Color.Green;
			this.scintilla1.Styles[2].ForeColor = Color.Green;
			this.scintilla1.Styles[4].ForeColor = Color.Olive;
			this.scintilla1.Styles[5].ForeColor = Color.Blue;
			this.scintilla1.Styles[13].ForeColor = Color.BlueViolet;
			this.scintilla1.Styles[14].ForeColor = Color.DarkSlateBlue;
			this.scintilla1.Styles[15].ForeColor = Color.DarkSlateBlue;
			this.scintilla1.Styles[6].ForeColor = Color.Red;
			this.scintilla1.Styles[7].ForeColor = Color.Red;
			this.scintilla1.Styles[8].ForeColor = Color.Red;
			this.scintilla1.Styles[12].BackColor = Color.Pink;
			this.scintilla1.Styles[10].ForeColor = Color.Purple;
			this.scintilla1.Styles[9].ForeColor = Color.Maroon;
			this.scintilla1.WordChars = str + str2 + str3;
			this.scintilla1.SetKeywords(0, "and break do else elseif end for function if in local nil not or repeat return then until while false true goto");
			this.scintilla1.SetKeywords(1, "assert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV");
			this.scintilla1.SetKeywords(2, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset");
			this.scintilla1.SetKeywords(3, "coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath require package.cpath package.loaded package.loadlib package.path package.preload");
			this.scintilla1.SetProperty("fold", "1");
			this.scintilla1.SetProperty("fold.compact", "1");
			this.scintilla1.Margins[2].Type = 0;
			this.scintilla1.Margins[2].Mask = 4261412864U;
			this.scintilla1.Margins[2].Sensitive = true;
			for (int i = 25; i <= 31; i++)
			{
				this.scintilla1.Markers[i].SetForeColor(SystemColors.ControlLightLight);
				this.scintilla1.Markers[i].SetBackColor(SystemColors.ControlDark);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000029F8 File Offset: 0x00000BF8
		private void Scripts_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.scintilla1.Text = File.ReadAllText("scripts\\" + this.Scripts.SelectedItem.ToString());
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A24 File Offset: 0x00000C24
		private void openSavesFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("workspace\\");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A31 File Offset: 0x00000C31
		private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.TopMost = this.topMostToolStripMenuItem.Checked;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002A44 File Offset: 0x00000C44
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002A46 File Offset: 0x00000C46
		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002A48 File Offset: 0x00000C48
		private void toolStripSeparator1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000006 RID: 6
		public bool Attached;

		// Token: 0x04000007 RID: 7
		public bool Loaded;

		// Token: 0x04000008 RID: 8
		public static string Direct = Directory.GetCurrentDirectory();

		// Token: 0x04000009 RID: 9
		private bool exists;
	}
}
