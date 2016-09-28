namespace LINQBasic
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.btnLinqStory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelegateTest = new System.Windows.Forms.Button();
            this.btnLINQDataOpDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLinqStory
            // 
            this.btnLinqStory.Location = new System.Drawing.Point(81, 54);
            this.btnLinqStory.Name = "btnLinqStory";
            this.btnLinqStory.Size = new System.Drawing.Size(135, 23);
            this.btnLinqStory.TabIndex = 0;
            this.btnLinqStory.Text = "LINQ 的故事";
            this.btnLinqStory.UseVisualStyleBackColor = true;
            this.btnLinqStory.Click += new System.EventHandler(this.btnLinqStory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(81, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelegateTest
            // 
            this.btnDelegateTest.Location = new System.Drawing.Point(53, 106);
            this.btnDelegateTest.Name = "btnDelegateTest";
            this.btnDelegateTest.Size = new System.Drawing.Size(183, 23);
            this.btnDelegateTest.TabIndex = 9;
            this.btnDelegateTest.Text = "委托、匿名方法和Lambda";
            this.btnDelegateTest.UseVisualStyleBackColor = true;
            this.btnDelegateTest.Click += new System.EventHandler(this.btnDelegateTest_Click);
            // 
            // btnLINQDataOpDemo
            // 
            this.btnLINQDataOpDemo.Location = new System.Drawing.Point(53, 153);
            this.btnLINQDataOpDemo.Name = "btnLINQDataOpDemo";
            this.btnLINQDataOpDemo.Size = new System.Drawing.Size(183, 23);
            this.btnLINQDataOpDemo.TabIndex = 10;
            this.btnLINQDataOpDemo.Text = "LINQ方式数据操作";
            this.btnLINQDataOpDemo.UseVisualStyleBackColor = true;
            this.btnLINQDataOpDemo.Click += new System.EventHandler(this.btnLINQDataOpDemo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 345);
            this.Controls.Add(this.btnLINQDataOpDemo);
            this.Controls.Add(this.btnDelegateTest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLinqStory);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ Basic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLinqStory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelegateTest;
        private System.Windows.Forms.Button btnLINQDataOpDemo;
    }
}

