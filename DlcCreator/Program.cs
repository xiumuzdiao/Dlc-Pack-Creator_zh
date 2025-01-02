using System;
using System.Windows.Forms;

namespace DlcCreator
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002665 File Offset: 0x00000865
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
