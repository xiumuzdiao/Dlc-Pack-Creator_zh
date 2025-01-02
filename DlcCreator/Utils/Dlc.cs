using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CodeWalker.GameFiles;

namespace DlcCreator.Utils
{
	// Token: 0x02000006 RID: 6
	internal class Dlc
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000272C File Offset: 0x0000092C
		public static void Create(string Type, string dlcName, string savePath)
		{
			try
			{
				Directory.CreateDirectory(savePath);
				RpfFile rpfFile = RpfFile.CreateNew(savePath, "dlc.rpf", RpfEncryption.OPEN);
				RpfDirectoryEntry rpfDirectoryEntry = RpfFile.CreateDirectory(rpfFile.Root, "x64");
				RpfFile.CreateFile(rpfFile.Root, "content.xml", Dlc.CreateContent(Type, dlcName), true);
				RpfFile.CreateFile(rpfFile.Root, "setup2.xml", Dlc.CreateSetup(Type, dlcName), true);
				bool flag = Type == "地图";
				if (flag)
				{
					RpfDirectoryEntry rpfDirectoryEntry2 = RpfFile.CreateDirectory(rpfDirectoryEntry, "levels");
					RpfDirectoryEntry rpfDirectoryEntry3 = RpfFile.CreateDirectory(rpfDirectoryEntry2, "gta5");
					RpfFile rpfFile2 = RpfFile.CreateNew(rpfDirectoryEntry3, dlcName + ".rpf", RpfEncryption.OPEN);
					RpfFile rpfFile3 = RpfFile.CreateNew(rpfDirectoryEntry3, dlcName + "_metadata.rpf", RpfEncryption.OPEN);
				}
				bool flag2 = Type == "载具";
				if (flag2)
				{
					RpfDirectoryEntry rpfDirectoryEntry4 = RpfFile.CreateDirectory(rpfFile.Root, "data");
					RpfDirectoryEntry rpfDirectoryEntry5 = RpfFile.CreateDirectory(rpfDirectoryEntry, "data");
					string[] array = new string[]
					{
						"american", "chinese", "french", "italian", "japanese", "korean", "mexican", "polish", "portuguese", "russion",
						"spanish"
					};
					for (int i = 0; i < array.Length; i++)
					{
						RpfFile rpfFile4 = RpfFile.CreateNew(rpfDirectoryEntry5, array[i] + "dlc.rpf", RpfEncryption.OPEN);
						RpfFile.CreateFile(rpfFile4.Root, "global.gxt2", Encoding.ASCII.GetBytes("TODO"), true);
					}
					RpfFile rpfFile5 = RpfFile.CreateNew(rpfDirectoryEntry, "vehicles.rpf", RpfEncryption.OPEN);
				}
				MessageBox.Show("已成功创建 dlc 包于： " + savePath);
			}
			catch (Exception ex)
			{
				MessageBox.Show("错误 dlc 包已存在于: " + savePath);
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000294C File Offset: 0x00000B4C
		private static byte[] CreateContent(string Type, string dlcName)
		{
			string text = GenerateMetaData.GenerateContentXML(dlcName, Type);
			return Encoding.ASCII.GetBytes(text);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002978 File Offset: 0x00000B78
		private static byte[] CreateSetup(string Type, string dlcName)
		{
			string text = GenerateMetaData.GenerateSetup2XML(dlcName, Type);
			return Encoding.ASCII.GetBytes(text);
		}
	}
}
