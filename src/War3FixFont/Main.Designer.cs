using System.Windows.Forms;

namespace War3FixFont;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FixButton = new System.Windows.Forms.Button();
            this.EnableHotKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.BorderMaxWindowButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.EnableTimerFixCheckBox = new System.Windows.Forms.CheckBox();
            this.IntervalInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ManualButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.WindowModeSelect = new System.Windows.Forms.ComboBox();
            this.WindowModeLabel = new System.Windows.Forms.Label();
            this.AutoWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.LockCursorCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NetBox = new System.Windows.Forms.ComboBox();
            this.GameButton = new System.Windows.Forms.Button();
            this.ShowMeHotKeyInputBox = new War3FixFont.HotKeyInputBox();
            this.HotKeyInputBox = new War3FixFont.HotKeyInputBox();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).BeginInit();
            this.SuspendLayout();
            // 
            // FixButton
            // 
            this.FixButton.Location = new System.Drawing.Point(24, 24);
            this.FixButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.FixButton.Name = "FixButton";
            this.FixButton.Size = new System.Drawing.Size(150, 46);
            this.FixButton.TabIndex = 0;
            this.FixButton.Text = "修复一次";
            this.FixButton.UseVisualStyleBackColor = true;
            this.FixButton.Click += new System.EventHandler(this.FixButton_Click);
            // 
            // EnableHotKeyCheckBox
            // 
            this.EnableHotKeyCheckBox.AutoSize = true;
            this.EnableHotKeyCheckBox.Checked = true;
            this.EnableHotKeyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableHotKeyCheckBox.Location = new System.Drawing.Point(24, 216);
            this.EnableHotKeyCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.EnableHotKeyCheckBox.Name = "EnableHotKeyCheckBox";
            this.EnableHotKeyCheckBox.Size = new System.Drawing.Size(162, 28);
            this.EnableHotKeyCheckBox.TabIndex = 1;
            this.EnableHotKeyCheckBox.Text = "使用快捷键";
            this.EnableHotKeyCheckBox.UseVisualStyleBackColor = true;
            this.EnableHotKeyCheckBox.CheckedChanged += new System.EventHandler(this.EnableHotKeyCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 436);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "作者：Zonciu && shaoxi2010";
            // 
            // LinkLabel
            // 
            this.LinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(20, 476);
            this.LinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(502, 24);
            this.LinkLabel.TabIndex = 3;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "https://github.com/shaoxi2010/War3FixFont";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // BorderMaxWindowButton
            // 
            this.BorderMaxWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderMaxWindowButton.Location = new System.Drawing.Point(562, 78);
            this.BorderMaxWindowButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BorderMaxWindowButton.Name = "BorderMaxWindowButton";
            this.BorderMaxWindowButton.Size = new System.Drawing.Size(150, 46);
            this.BorderMaxWindowButton.TabIndex = 4;
            this.BorderMaxWindowButton.Text = "有边框全屏";
            this.BorderMaxWindowButton.UseVisualStyleBackColor = true;
            this.BorderMaxWindowButton.Click += new System.EventHandler(this.BorderMaxWindowButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenButton.Location = new System.Drawing.Point(562, 24);
            this.FullScreenButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(150, 46);
            this.FullScreenButton.TabIndex = 5;
            this.FullScreenButton.Text = "无边框全屏";
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.Location = new System.Drawing.Point(562, 476);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(150, 24);
            this.VersionLabel.TabIndex = 11;
            this.VersionLabel.Text = "vx.x";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnableTimerFixCheckBox
            // 
            this.EnableTimerFixCheckBox.AutoSize = true;
            this.EnableTimerFixCheckBox.Location = new System.Drawing.Point(24, 104);
            this.EnableTimerFixCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.EnableTimerFixCheckBox.Name = "EnableTimerFixCheckBox";
            this.EnableTimerFixCheckBox.Size = new System.Drawing.Size(138, 28);
            this.EnableTimerFixCheckBox.TabIndex = 15;
            this.EnableTimerFixCheckBox.Text = "定时修复";
            this.EnableTimerFixCheckBox.UseVisualStyleBackColor = true;
            this.EnableTimerFixCheckBox.CheckedChanged += new System.EventHandler(this.EnableTimerFixCheckBox_CheckedChanged);
            // 
            // IntervalInput
            // 
            this.IntervalInput.Location = new System.Drawing.Point(186, 100);
            this.IntervalInput.Margin = new System.Windows.Forms.Padding(0);
            this.IntervalInput.Name = "IntervalInput";
            this.IntervalInput.Size = new System.Drawing.Size(108, 35);
            this.IntervalInput.TabIndex = 16;
            this.IntervalInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.IntervalInput.ValueChanged += new System.EventHandler(this.IntervalInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "秒";
            // 
            // ManualButton
            // 
            this.ManualButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualButton.Location = new System.Drawing.Point(562, 414);
            this.ManualButton.Margin = new System.Windows.Forms.Padding(6);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(150, 46);
            this.ManualButton.TabIndex = 19;
            this.ManualButton.Text = "使用说明";
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "魔兽3叠字修复";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // WindowModeSelect
            // 
            this.WindowModeSelect.FormattingEnabled = true;
            this.WindowModeSelect.Location = new System.Drawing.Point(138, 156);
            this.WindowModeSelect.Margin = new System.Windows.Forms.Padding(6);
            this.WindowModeSelect.Name = "WindowModeSelect";
            this.WindowModeSelect.Size = new System.Drawing.Size(238, 32);
            this.WindowModeSelect.TabIndex = 20;
            this.WindowModeSelect.SelectionChangeCommitted += new System.EventHandler(this.WindowModeSelect_SelectionChangeCommitted);
            // 
            // WindowModeLabel
            // 
            this.WindowModeLabel.AutoSize = true;
            this.WindowModeLabel.Location = new System.Drawing.Point(24, 164);
            this.WindowModeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WindowModeLabel.Name = "WindowModeLabel";
            this.WindowModeLabel.Size = new System.Drawing.Size(106, 24);
            this.WindowModeLabel.TabIndex = 21;
            this.WindowModeLabel.Text = "窗口模式";
            // 
            // AutoWindowCheckBox
            // 
            this.AutoWindowCheckBox.AutoSize = true;
            this.AutoWindowCheckBox.Location = new System.Drawing.Point(392, 160);
            this.AutoWindowCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.AutoWindowCheckBox.Name = "AutoWindowCheckBox";
            this.AutoWindowCheckBox.Size = new System.Drawing.Size(186, 28);
            this.AutoWindowCheckBox.TabIndex = 22;
            this.AutoWindowCheckBox.Text = "自动设置窗口";
            this.AutoWindowCheckBox.UseVisualStyleBackColor = true;
            this.AutoWindowCheckBox.CheckedChanged += new System.EventHandler(this.AutoWindowCheckBox_CheckedChanged);
            // 
            // LockCursorCheckBox
            // 
            this.LockCursorCheckBox.AutoSize = true;
            this.LockCursorCheckBox.Location = new System.Drawing.Point(24, 276);
            this.LockCursorCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.LockCursorCheckBox.Name = "LockCursorCheckBox";
            this.LockCursorCheckBox.Size = new System.Drawing.Size(186, 28);
            this.LockCursorCheckBox.TabIndex = 23;
            this.LockCursorCheckBox.Text = "锁定鼠标范围";
            this.LockCursorCheckBox.UseVisualStyleBackColor = true;
            this.LockCursorCheckBox.CheckedChanged += new System.EventHandler(this.LockCursorCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "显示本窗口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "绑定网络：";
            // 
            // NetBox
            // 
            this.NetBox.FormattingEnabled = true;
            this.NetBox.Location = new System.Drawing.Point(522, 305);
            this.NetBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NetBox.Name = "NetBox";
            this.NetBox.Size = new System.Drawing.Size(190, 32);
            this.NetBox.TabIndex = 31;
            this.NetBox.DropDown += new System.EventHandler(this.NetBox_DropDown);
            // 
            // GameButton
            // 
            this.GameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GameButton.Location = new System.Drawing.Point(564, 353);
            this.GameButton.Margin = new System.Windows.Forms.Padding(6);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(150, 46);
            this.GameButton.TabIndex = 30;
            this.GameButton.Text = "启动游戏";
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // ShowMeHotKeyInputBox
            // 
            this.ShowMeHotKeyInputBox.Alt = false;
            this.ShowMeHotKeyInputBox.Control = false;
            this.ShowMeHotKeyInputBox.KeyCode = System.Windows.Forms.Keys.None;
            this.ShowMeHotKeyInputBox.Location = new System.Drawing.Point(166, 328);
            this.ShowMeHotKeyInputBox.Margin = new System.Windows.Forms.Padding(6);
            this.ShowMeHotKeyInputBox.Name = "ShowMeHotKeyInputBox";
            this.ShowMeHotKeyInputBox.Shift = false;
            this.ShowMeHotKeyInputBox.ShortcutsEnabled = false;
            this.ShowMeHotKeyInputBox.Size = new System.Drawing.Size(302, 35);
            this.ShowMeHotKeyInputBox.TabIndex = 24;
            this.ShowMeHotKeyInputBox.WordWrap = false;
            this.ShowMeHotKeyInputBox.HotKeyChanged += new System.EventHandler(this.ShowMeHotKeyInputBox_HotKeyChanged);
            // 
            // HotKeyInputBox
            // 
            this.HotKeyInputBox.Alt = false;
            this.HotKeyInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.HotKeyInputBox.Control = false;
            this.HotKeyInputBox.KeyCode = System.Windows.Forms.Keys.None;
            this.HotKeyInputBox.Location = new System.Drawing.Point(204, 212);
            this.HotKeyInputBox.Margin = new System.Windows.Forms.Padding(6);
            this.HotKeyInputBox.Name = "HotKeyInputBox";
            this.HotKeyInputBox.Shift = false;
            this.HotKeyInputBox.ShortcutsEnabled = false;
            this.HotKeyInputBox.Size = new System.Drawing.Size(302, 35);
            this.HotKeyInputBox.TabIndex = 12;
            this.HotKeyInputBox.WordWrap = false;
            this.HotKeyInputBox.HotKeyChanged += new System.EventHandler(this.HotKeyInputBox_HotKeyChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NetBox);
            this.Controls.Add(this.GameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowMeHotKeyInputBox);
            this.Controls.Add(this.LockCursorCheckBox);
            this.Controls.Add(this.AutoWindowCheckBox);
            this.Controls.Add(this.WindowModeLabel);
            this.Controls.Add(this.WindowModeSelect);
            this.Controls.Add(this.ManualButton);
            this.Controls.Add(this.EnableTimerFixCheckBox);
            this.Controls.Add(this.IntervalInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HotKeyInputBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.BorderMaxWindowButton);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnableHotKeyCheckBox);
            this.Controls.Add(this.FixButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "魔兽争霸3常用工具";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private War3FixFont.HotKeyInputBox HotKeyInputBox;
    private System.Windows.Forms.CheckBox EnableHotKeyCheckBox;

    #endregion

    private Button FixButton;
    private Label label1;
    private LinkLabel LinkLabel;
    private Button BorderMaxWindowButton;
    private Button FullScreenButton;
    private Label VersionLabel;
    private CheckBox EnableTimerFixCheckBox;
    private NumericUpDown IntervalInput;
    private Label label2;
    private Button ManualButton;
    private NotifyIcon NotifyIcon;
    private ComboBox WindowModeSelect;
    private Label WindowModeLabel;
    private CheckBox AutoWindowCheckBox;
    private CheckBox LockCursorCheckBox;
    private HotKeyInputBox ShowMeHotKeyInputBox;
    private Label label3;
    private Label label4;
    private ComboBox NetBox;
    private Button GameButton;
}