namespace StrategyPattern
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "單價:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "數量:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(50, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 22);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "1000";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(50, 48);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(155, 22);
            this.txtCount.TabIndex = 3;
            this.txtCount.Text = "2";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(231, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(231, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(14, 139);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(292, 190);
            this.txtList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "總計:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("新細明體", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblResult.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblResult.Location = new System.Drawing.Point(80, 365);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(153, 54);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "25000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "計算方式:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "正常收費",
            "滿300返100",
            "打8折"});
            this.cbxType.Location = new System.Drawing.Point(84, 91);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 20);
            this.cbxType.TabIndex = 10;
            this.cbxType.Text = "正常收費";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "商場收銀模式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxType;
    }
}

