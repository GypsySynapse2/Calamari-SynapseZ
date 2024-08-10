using System;
using System.IO;
using System.Windows.Forms;
using sxlib.Specialized;

namespace Calamari_CH
{
	// Token: 0x02000004 RID: 4
	internal class Functions
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020B8 File Offset: 0x000002B8
		public static void PopulateListBox(ListBox List, string Folder, string FileType)
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Folder).GetFiles(FileType))
			{
				List.Items.Add(fileInfo.Name);
			}
		}

		// Token: 0x04000004 RID: 4
		public static SxLibWinForms lib;

		// Token: 0x04000005 RID: 5
		public static OpenFileDialog openfiledialog = new OpenFileDialog
		{
			Filter = "Lua Script Txt (*.txt)|*.txt|All files (*.*)|*.*",
			FilterIndex = 1,
			RestoreDirectory = true,
			Title = "Calamari - Load File"
		};
	}
}
