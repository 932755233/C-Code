namespace MoveFile
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwDirectories = new System.Windows.Forms.TreeView();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msInput = new System.Windows.Forms.ToolStripMenuItem();
            this.msOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.msSaveSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(12, 29);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(428, 21);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(446, 29);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(135, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "选择输入文件夹";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(446, 56);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(135, 23);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "选择输出文件夹";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(12, 56);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(428, 21);
            this.tbxOutput.TabIndex = 2;
            this.tbxOutput.TextChanged += new System.EventHandler(this.tbxOutput_TextChanged);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(12, 304);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(569, 491);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 4;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.DoubleClick += new System.EventHandler(this.pbxPhoto_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 801);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(414, 801);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(168, 23);
            this.btnMove.TabIndex = 6;
            this.btnMove.Text = "移动";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // fbdDirectory
            // 
            this.fbdDirectory.HelpRequest += new System.EventHandler(this.fbdDirectory_HelpRequest);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 85);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvwDirectories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwFiles);
            this.splitContainer1.Size = new System.Drawing.Size(569, 213);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 7;
            // 
            // tvwDirectories
            // 
            this.tvwDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDirectories.Location = new System.Drawing.Point(0, 0);
            this.tvwDirectories.Name = "tvwDirectories";
            this.tvwDirectories.Size = new System.Drawing.Size(125, 213);
            this.tvwDirectories.TabIndex = 0;
            this.tvwDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDirectories_AfterSelect);
            // 
            // lvwFiles
            // 
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.Location = new System.Drawing.Point(0, 0);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(440, 213);
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.SelectedIndexChanged += new System.EventHandler(this.lvwFiles_SelectedIndexChanged);
            this.lvwFiles.Click += new System.EventHandler(this.lvwFiles_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInput,
            this.msOutput,
            this.msSaveSetting,
            this.msExit});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // msInput
            // 
            this.msInput.Name = "msInput";
            this.msInput.Size = new System.Drawing.Size(160, 22);
            this.msInput.Text = "选择输入文件夹";
            this.msInput.Click += new System.EventHandler(this.msInput_Click);
            // 
            // msOutput
            // 
            this.msOutput.Name = "msOutput";
            this.msOutput.Size = new System.Drawing.Size(160, 22);
            this.msOutput.Text = "选择输出文件夹";
            this.msOutput.Click += new System.EventHandler(this.msOutput_Click);
            // 
            // msSaveSetting
            // 
            this.msSaveSetting.Name = "msSaveSetting";
            this.msSaveSetting.Size = new System.Drawing.Size(160, 22);
            this.msSaveSetting.Text = "保存配置";
            this.msSaveSetting.Click += new System.EventHandler(this.msSaveSetting_Click);
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(160, 22);
            this.msExit.Text = "退出";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 887);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msInput;
        private System.Windows.Forms.ToolStripMenuItem msOutput;
        private System.Windows.Forms.ToolStripMenuItem msSaveSetting;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.TreeView tvwDirectories;
        private System.Windows.Forms.ListView lvwFiles;
    }
}

