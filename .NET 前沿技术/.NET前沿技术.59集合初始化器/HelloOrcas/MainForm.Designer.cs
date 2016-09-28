namespace HelloOrcas
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnObjectInitializerTest = new System.Windows.Forms.Button();
            this.btnCollectionInitializerTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(111, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnObjectInitializerTest
            // 
            this.btnObjectInitializerTest.Location = new System.Drawing.Point(65, 37);
            this.btnObjectInitializerTest.Name = "btnObjectInitializerTest";
            this.btnObjectInitializerTest.Size = new System.Drawing.Size(166, 23);
            this.btnObjectInitializerTest.TabIndex = 2;
            this.btnObjectInitializerTest.Text = "对象初始化器";
            this.btnObjectInitializerTest.UseVisualStyleBackColor = true;
            this.btnObjectInitializerTest.Click += new System.EventHandler(this.btnObjectInitializerTest_Click);
            // 
            // btnCollectionInitializerTest
            // 
            this.btnCollectionInitializerTest.Location = new System.Drawing.Point(65, 84);
            this.btnCollectionInitializerTest.Name = "btnCollectionInitializerTest";
            this.btnCollectionInitializerTest.Size = new System.Drawing.Size(166, 23);
            this.btnCollectionInitializerTest.TabIndex = 3;
            this.btnCollectionInitializerTest.Text = "集合初始化器";
            this.btnCollectionInitializerTest.UseVisualStyleBackColor = true;
            this.btnCollectionInitializerTest.Click += new System.EventHandler(this.btnCollectionInitializerTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 371);
            this.Controls.Add(this.btnCollectionInitializerTest);
            this.Controls.Add(this.btnObjectInitializerTest);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello Orcas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnObjectInitializerTest;
        private System.Windows.Forms.Button btnCollectionInitializerTest;
    }
}

