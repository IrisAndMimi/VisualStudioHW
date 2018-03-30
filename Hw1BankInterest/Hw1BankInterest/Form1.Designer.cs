namespace Hw1BankInterest
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.interest = new System.Windows.Forms.TextBox();
            this.endBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "本金 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "年利率 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "利息 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "%";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(237, 82);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(179, 36);
            this.money.TabIndex = 4;
            this.money.Text = "10000";
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(237, 177);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(179, 36);
            this.rate.TabIndex = 5;
            this.rate.Text = "3";
            this.rate.TextChanged += new System.EventHandler(this.rate_TextChanged);
            // 
            // interest
            // 
            this.interest.Location = new System.Drawing.Point(237, 271);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(179, 36);
            this.interest.TabIndex = 6;
            this.interest.Text = "300";
            this.interest.TextChanged += new System.EventHandler(this.interest_TextChanged);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(549, 274);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(128, 43);
            this.endBtn.TabIndex = 7;
            this.endBtn.Text = "結束";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "405290254";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox interest;
        private System.Windows.Forms.Button endBtn;
    }
}

