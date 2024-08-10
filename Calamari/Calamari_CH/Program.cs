using System;
using System.Windows.Forms;

namespace Calamari_CH
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00003D52 File Offset: 0x00001F52
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
