namespace DlcCreator
{
	// Token: 0x02000002 RID: 2
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000021B8 File Offset: 0x000003B8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021F0 File Offset: 0x000003F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DlcCreator.Main));
			this.CreateDlcPackButton = new global::System.Windows.Forms.Button();
			this.DlcTypeComboBox = new global::System.Windows.Forms.ComboBox();
			this.DlcNameTextBox = new global::System.Windows.Forms.TextBox();
			this.DlcNameLabel = new global::System.Windows.Forms.Label();
			this.TypeLabel = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.DlcListItemTextBox = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.CreateDlcPackButton.Location = new global::System.Drawing.Point(284, 67);
			this.CreateDlcPackButton.Name = "CreateDlcPackButton";
			this.CreateDlcPackButton.Size = new global::System.Drawing.Size(75, 23);
			this.CreateDlcPackButton.TabIndex = 0;
			this.CreateDlcPackButton.Text = "创建 DLC";
			this.CreateDlcPackButton.UseVisualStyleBackColor = true;
			this.CreateDlcPackButton.Click += new global::System.EventHandler(this.CreateDlcPackButton_Click);
			this.DlcTypeComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DlcTypeComboBox.FormattingEnabled = true;
			this.DlcTypeComboBox.Items.AddRange(new object[] { "地图", "载具" });
			this.DlcTypeComboBox.Location = new global::System.Drawing.Point(91, 41);
			this.DlcTypeComboBox.Name = "DlcTypeComboBox";
			this.DlcTypeComboBox.Size = new global::System.Drawing.Size(268, 21);
			this.DlcTypeComboBox.TabIndex = 1;
			this.DlcNameTextBox.Location = new global::System.Drawing.Point(91, 15);
			this.DlcNameTextBox.Name = "DlcNameTextBox";
			this.DlcNameTextBox.Size = new global::System.Drawing.Size(268, 20);
			this.DlcNameTextBox.TabIndex = 2;
			this.DlcNameLabel.AutoSize = true;
			this.DlcNameLabel.Location = new global::System.Drawing.Point(12, 18);
			this.DlcNameLabel.Name = "DlcNameLabel";
			this.DlcNameLabel.Size = new global::System.Drawing.Size(65, 15);
			this.DlcNameLabel.TabIndex = 3;
			this.DlcNameLabel.Text = "DLC 名称:";
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Location = new global::System.Drawing.Point(12, 44);
			this.TypeLabel.Name = "TypeLabel";
			this.TypeLabel.Size = new global::System.Drawing.Size(36, 15);
			this.TypeLabel.TabIndex = 4;
			this.TypeLabel.Text = "类型:";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 73);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(74, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Dlc 列表项:";
			this.DlcListItemTextBox.Location = new global::System.Drawing.Point(91, 70);
			this.DlcListItemTextBox.Name = "DlcListItemTextBox";
			this.DlcListItemTextBox.ReadOnly = true;
			this.DlcListItemTextBox.Size = new global::System.Drawing.Size(187, 20);
			this.DlcListItemTextBox.TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(388, 102);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.DlcListItemTextBox);
			base.Controls.Add(this.TypeLabel);
			base.Controls.Add(this.DlcNameLabel);
			base.Controls.Add(this.DlcNameTextBox);
			base.Controls.Add(this.DlcTypeComboBox);
			base.Controls.Add(this.CreateDlcPackButton);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(404, 141);
			this.MinimumSize = new global::System.Drawing.Size(404, 141);
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DLC包创建工具（Dlc Pack Creator）汉化版v1.1.0 by xiumuzdiao";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button CreateDlcPackButton;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.ComboBox DlcTypeComboBox;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.TextBox DlcNameTextBox;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label DlcNameLabel;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label TypeLabel;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TextBox DlcListItemTextBox;
	}
}
