namespace CS07_05_10
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メインToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.メイン１ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.乗用車ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.トラックToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.メイン２ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.サブ１ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オープンカーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.タクシーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.サブ２ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.スポーツカーToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ミニカーToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.メイン３ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.パトカーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消防車ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "いらっしゃいませ。";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メインToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メインToolStripMenuItem
            // 
            this.メインToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メイン１ToolStripMenuItem,
            this.メイン２ToolStripMenuItem,
            this.メイン３ToolStripMenuItem});
            this.メインToolStripMenuItem.Name = "メインToolStripMenuItem";
            this.メインToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.メインToolStripMenuItem.Text = "メニュー";
            // 
            // メイン１ToolStripMenuItem
            // 
            this.メイン１ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.乗用車ToolStripMenuItem,
            this.トラックToolStripMenuItem});
            this.メイン１ToolStripMenuItem.Name = "メイン１ToolStripMenuItem";
            this.メイン１ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.メイン１ToolStripMenuItem.Text = "メイン１";
            // 
            // 乗用車ToolStripMenuItem
            // 
            this.乗用車ToolStripMenuItem.Name = "乗用車ToolStripMenuItem";
            this.乗用車ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.乗用車ToolStripMenuItem.Text = "乗用車";
            this.乗用車ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // トラックToolStripMenuItem
            // 
            this.トラックToolStripMenuItem.Name = "トラックToolStripMenuItem";
            this.トラックToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.トラックToolStripMenuItem.Text = "トラック";
            this.トラックToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // メイン２ToolStripMenuItem
            // 
            this.メイン２ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.サブ１ToolStripMenuItem,
            this.toolStripSeparator1,
            this.サブ２ToolStripMenuItem1});
            this.メイン２ToolStripMenuItem.Name = "メイン２ToolStripMenuItem";
            this.メイン２ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.メイン２ToolStripMenuItem.Text = "メイン２";
            // 
            // サブ１ToolStripMenuItem
            // 
            this.サブ１ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オープンカーToolStripMenuItem,
            this.タクシーToolStripMenuItem});
            this.サブ１ToolStripMenuItem.Name = "サブ１ToolStripMenuItem";
            this.サブ１ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.サブ１ToolStripMenuItem.Text = "サブ１";
            // 
            // オープンカーToolStripMenuItem
            // 
            this.オープンカーToolStripMenuItem.Name = "オープンカーToolStripMenuItem";
            this.オープンカーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.オープンカーToolStripMenuItem.Text = "オープンカー";
            this.オープンカーToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // タクシーToolStripMenuItem
            // 
            this.タクシーToolStripMenuItem.Name = "タクシーToolStripMenuItem";
            this.タクシーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.タクシーToolStripMenuItem.Text = "タクシー";
            this.タクシーToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
            // 
            // サブ２ToolStripMenuItem1
            // 
            this.サブ２ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.スポーツカーToolStripMenuItem1,
            this.ミニカーToolStripMenuItem1});
            this.サブ２ToolStripMenuItem1.Name = "サブ２ToolStripMenuItem1";
            this.サブ２ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.サブ２ToolStripMenuItem1.Text = "サブ２";
            // 
            // スポーツカーToolStripMenuItem1
            // 
            this.スポーツカーToolStripMenuItem1.Name = "スポーツカーToolStripMenuItem1";
            this.スポーツカーToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.スポーツカーToolStripMenuItem1.Text = "スポーツカー";
            this.スポーツカーToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ミニカーToolStripMenuItem1
            // 
            this.ミニカーToolStripMenuItem1.Name = "ミニカーToolStripMenuItem1";
            this.ミニカーToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ミニカーToolStripMenuItem1.Text = "ミニカー";
            this.ミニカーToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // メイン３ToolStripMenuItem
            // 
            this.メイン３ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.パトカーToolStripMenuItem,
            this.消防車ToolStripMenuItem});
            this.メイン３ToolStripMenuItem.Name = "メイン３ToolStripMenuItem";
            this.メイン３ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.メイン３ToolStripMenuItem.Text = "メイン３";
            // 
            // パトカーToolStripMenuItem
            // 
            this.パトカーToolStripMenuItem.Name = "パトカーToolStripMenuItem";
            this.パトカーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.パトカーToolStripMenuItem.Text = "パトカー";
            this.パトカーToolStripMenuItem.Click += new System.EventHandler(this.itarixtuku_ToolStripMenuItem_Click);
            // 
            // 消防車ToolStripMenuItem
            // 
            this.消防車ToolStripMenuItem.Name = "消防車ToolStripMenuItem";
            this.消防車ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.消防車ToolStripMenuItem.Text = "消防車";
            this.消防車ToolStripMenuItem.Click += new System.EventHandler(this.itarixtuku_ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "サンプル";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メインToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メイン１ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 乗用車ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem トラックToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メイン２ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem サブ１ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オープンカーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem タクシーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メイン３ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem パトカーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消防車ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem サブ２ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem スポーツカーToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ミニカーToolStripMenuItem1;
    }
}

