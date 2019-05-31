using System.Windows.Forms;

namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.utilpanel = new System.Windows.Forms.Panel();
            this.TargetBox = new System.Windows.Forms.GroupBox();
            this.target = new System.Windows.Forms.RichTextBox();
            this.SourceBox = new System.Windows.Forms.GroupBox();
            this.source = new System.Windows.Forms.RichTextBox();
            this.baseToHex = new System.Windows.Forms.Button();
            this.hexToBase = new System.Windows.Forms.Button();
            this.hextodec = new System.Windows.Forms.Button();
            this.dectohex = new System.Windows.Forms.Button();
            this.delblank = new System.Windows.Forms.Button();
            this.characternum = new System.Windows.Forms.Button();
            this.crcCheck = new System.Windows.Forms.Button();
            this.utilpanel.SuspendLayout();
            this.TargetBox.SuspendLayout();
            this.SourceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // utilpanel
            // 
            this.utilpanel.Controls.Add(this.TargetBox);
            this.utilpanel.Controls.Add(this.SourceBox);
            this.utilpanel.Location = new System.Drawing.Point(12, 12);
            this.utilpanel.Name = "utilpanel";
            this.utilpanel.Size = new System.Drawing.Size(605, 397);
            this.utilpanel.TabIndex = 0;
            // 
            // TargetBox
            // 
            this.TargetBox.Controls.Add(this.target);
            this.TargetBox.Location = new System.Drawing.Point(12, 206);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(580, 165);
            this.TargetBox.TabIndex = 1;
            this.TargetBox.TabStop = false;
            this.TargetBox.Text = "目标数据";
            // 
            // target
            // 
            this.target.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.target.Font = new System.Drawing.Font("宋体", 12F);
            this.target.Location = new System.Drawing.Point(11, 20);
            this.target.Name = "target";
            this.target.ReadOnly = true;
            this.target.Size = new System.Drawing.Size(558, 139);
            this.target.TabIndex = 1;
            this.target.Text = "";
            // 
            // SourceBox
            // 
            this.SourceBox.Controls.Add(this.source);
            this.SourceBox.Location = new System.Drawing.Point(12, 12);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(580, 165);
            this.SourceBox.TabIndex = 0;
            this.SourceBox.TabStop = false;
            this.SourceBox.Text = "源数据";
            // 
            // source
            // 
            this.source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.source.Font = new System.Drawing.Font("宋体", 12F);
            this.source.Location = new System.Drawing.Point(11, 20);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(558, 139);
            this.source.TabIndex = 0;
            this.source.Text = "";
            //this.source.TextChanged += new MouseEventHandler(this.source_TextChanged);
            // 
            // baseToHex
            // 
            this.baseToHex.Font = new System.Drawing.Font("宋体", 10F);
            this.baseToHex.Location = new System.Drawing.Point(640, 22);
            this.baseToHex.Name = "baseToHex";
            this.baseToHex.Size = new System.Drawing.Size(116, 46);
            this.baseToHex.TabIndex = 1;
            this.baseToHex.Text = "base64转16进制";
            this.baseToHex.UseVisualStyleBackColor = true;
            this.baseToHex.Click += new System.EventHandler(this.baseToHex_Click);
            // 
            // hexToBase
            // 
            this.hexToBase.Font = new System.Drawing.Font("宋体", 10F);
            this.hexToBase.Location = new System.Drawing.Point(640, 74);
            this.hexToBase.Name = "hexToBase";
            this.hexToBase.Size = new System.Drawing.Size(116, 46);
            this.hexToBase.TabIndex = 2;
            this.hexToBase.Text = "16进制转base64";
            this.hexToBase.UseVisualStyleBackColor = true;
            this.hexToBase.Click += new System.EventHandler(this.hexToBase_Click);
            // 
            // hextodec
            // 
            this.hextodec.Font = new System.Drawing.Font("宋体", 10F);
            this.hextodec.Location = new System.Drawing.Point(640, 126);
            this.hextodec.Name = "hextodec";
            this.hextodec.Size = new System.Drawing.Size(116, 46);
            this.hextodec.TabIndex = 3;
            this.hextodec.Text = "16进制转10进制";
            this.hextodec.UseVisualStyleBackColor = true;
            this.hextodec.Click += new System.EventHandler(this.hextodec_Click);
            // 
            // dectohex
            // 
            this.dectohex.Font = new System.Drawing.Font("宋体", 10F);
            this.dectohex.Location = new System.Drawing.Point(640, 178);
            this.dectohex.Name = "dectohex";
            this.dectohex.Size = new System.Drawing.Size(116, 46);
            this.dectohex.TabIndex = 4;
            this.dectohex.Text = "10进制转16进制";
            this.dectohex.UseVisualStyleBackColor = true;
            this.dectohex.Click += new System.EventHandler(this.dectohex_Click);
            // 
            // delblank
            // 
            this.delblank.Font = new System.Drawing.Font("宋体", 10F);
            this.delblank.Location = new System.Drawing.Point(640, 230);
            this.delblank.Name = "delblank";
            this.delblank.Size = new System.Drawing.Size(116, 46);
            this.delblank.TabIndex = 5;
            this.delblank.Text = "格式化字符串";
            this.delblank.UseVisualStyleBackColor = true;
            this.delblank.Click += new System.EventHandler(this.delblank_Click);
            // 
            // characternum
            // 
            this.characternum.Font = new System.Drawing.Font("宋体", 10F);
            this.characternum.Location = new System.Drawing.Point(640, 282);
            this.characternum.Name = "characternum";
            this.characternum.Size = new System.Drawing.Size(116, 46);
            this.characternum.TabIndex = 7;
            this.characternum.Text = "字数统计";
            this.characternum.UseVisualStyleBackColor = true;
            this.characternum.Click += new System.EventHandler(this.characternum_Click);
            // 
            // crcCheck
            // 
            this.crcCheck.Font = new System.Drawing.Font("宋体", 11F);
            this.crcCheck.Location = new System.Drawing.Point(640, 334);
            this.crcCheck.Name = "crcCheck";
            this.crcCheck.Size = new System.Drawing.Size(116, 46);
            this.crcCheck.TabIndex = 8;
            this.crcCheck.Text = "校验和";
            this.crcCheck.UseVisualStyleBackColor = true;
            this.crcCheck.Click += new System.EventHandler(this.crcCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 433);
            this.Controls.Add(this.crcCheck);
            this.Controls.Add(this.characternum);
            this.Controls.Add(this.delblank);
            this.Controls.Add(this.dectohex);
            this.Controls.Add(this.hextodec);
            this.Controls.Add(this.hexToBase);
            this.Controls.Add(this.baseToHex);
            this.Controls.Add(this.utilpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "转换小工具";
            this.utilpanel.ResumeLayout(false);
            this.TargetBox.ResumeLayout(false);
            this.SourceBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel utilpanel;
        private System.Windows.Forms.GroupBox TargetBox;
        private System.Windows.Forms.GroupBox SourceBox;
        private System.Windows.Forms.Button baseToHex;
        private System.Windows.Forms.Button hexToBase;
        private System.Windows.Forms.Button hextodec;
        private System.Windows.Forms.Button dectohex;
        private System.Windows.Forms.Button delblank;
        private RichTextBox target;
        private RichTextBox source;
        private Button characternum;
        private Button crcCheck;





    }
}

