using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DlcCreator.Utils;

namespace DlcCreator
{
	// Token: 0x02000002 RID: 2
	public partial class Main : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Main()
		{
			this.InitializeComponent();
			this.DlcTypeComboBox.SelectedIndex = 0;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00000278
		private void CreateDlcPackButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "选择保存 DLC 包的位置！";
			this.dlcType = this.DlcTypeComboBox.Text;
			this.dlcName = this.DlcNameTextBox.Text.ToLower();
			this.dlcListItem = "<Item>dlcpacks:\\" + this.dlcName + "\\</Item>";
			bool flag = this.dlcName == "" || this.dlcName.Contains(" ");
			if (flag)
			{
				MessageBox.Show("请输入 dlc 名称或删除名称中的空格！", "Error");
			}
			else
			{
				bool flag2 = folderBrowserDialog.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
					string text = Path.Combine(new string[] { folderBrowserDialog.SelectedPath + "\\" + this.dlcName });
					bool flag3 = this.dlcType == "地图";
					if (flag3)
					{
						this.CreateDlcPack(text);
					}
					bool flag4 = this.dlcType == "载具";
					if (flag4)
					{
						this.CreateDlcPack(text);
					}
					this.DlcListItemTextBox.Text = this.dlcListItem;
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000219F File Offset: 0x0000039F
		private void CreateDlcPack(string savePath)
		{
			Dlc.Create(this.dlcType, this.dlcName, savePath);
		}

		// Token: 0x04000001 RID: 1
		private string dlcType;

		// Token: 0x04000002 RID: 2
		private string dlcName;

		// Token: 0x04000003 RID: 3
		private string dlcListItem;
	}
}
