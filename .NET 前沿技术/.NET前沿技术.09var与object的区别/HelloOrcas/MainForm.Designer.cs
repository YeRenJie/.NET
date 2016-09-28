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
            this.btnExtensionMethodTest = new System.Windows.Forms.Button();
            this.btnExtensionMethodTestv1 = new System.Windows.Forms.Button();
            this.btmVarAndObject = new System.Windows.Forms.Button();
            this.btnVarTest = new System.Windows.Forms.Button();
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
            this.btnObjectInitializerTest.Location = new System.Drawing.Point(65, 31);
            this.btnObjectInitializerTest.Name = "btnObjectInitializerTest";
            this.btnObjectInitializerTest.Size = new System.Drawing.Size(166, 23);
            this.btnObjectInitializerTest.TabIndex = 2;
            this.btnObjectInitializerTest.Text = "对象初始化器";
            this.btnObjectInitializerTest.UseVisualStyleBackColor = true;
            this.btnObjectInitializerTest.Click += new System.EventHandler(this.btnObjectInitializerTest_Click);
            // 
            // btnCollectionInitializerTest
            // 
            this.btnCollectionInitializerTest.Location = new System.Drawing.Point(65, 76);
            this.btnCollectionInitializerTest.Name = "btnCollectionInitializerTest";
            this.btnCollectionInitializerTest.Size = new System.Drawing.Size(166, 23);
            this.btnCollectionInitializerTest.TabIndex = 3;
            this.btnCollectionInitializerTest.Text = "集合初始化器";
            this.btnCollectionInitializerTest.UseVisualStyleBackColor = true;
            this.btnCollectionInitializerTest.Click += new System.EventHandler(this.btnCollectionInitializerTest_Click);
            // 
            // btnExtensionMethodTest
            // 
            this.btnExtensionMethodTest.Location = new System.Drawing.Point(65, 121);
            this.btnExtensionMethodTest.Name = "btnExtensionMethodTest";
            this.btnExtensionMethodTest.Size = new System.Drawing.Size(166, 23);
            this.btnExtensionMethodTest.TabIndex = 4;
            this.btnExtensionMethodTest.Text = "简单的扩展方法";
            this.btnExtensionMethodTest.UseVisualStyleBackColor = true;
            this.btnExtensionMethodTest.Click += new System.EventHandler(this.btnExtensionMethodTest_Click);
            // 
            // btnExtensionMethodTestv1
            // 
            this.btnExtensionMethodTestv1.Location = new System.Drawing.Point(65, 166);
            this.btnExtensionMethodTestv1.Name = "btnExtensionMethodTestv1";
            this.btnExtensionMethodTestv1.Size = new System.Drawing.Size(166, 23);
            this.btnExtensionMethodTestv1.TabIndex = 4;
            this.btnExtensionMethodTestv1.Text = "带参数的扩展方法";
            this.btnExtensionMethodTestv1.UseVisualStyleBackColor = true;
            this.btnExtensionMethodTestv1.Click += new System.EventHandler(this.btnExtensionMethodTestv1_Click);
            // 
            // btmVarAndObject
            // 
            this.btmVarAndObject.Location = new System.Drawing.Point(64, 256);
            this.btmVarAndObject.Name = "btmVarAndObject";
            this.btmVarAndObject.Size = new System.Drawing.Size(166, 23);
            this.btmVarAndObject.TabIndex = 8;
            this.btmVarAndObject.Text = "var 和 Object";
            this.btmVarAndObject.UseVisualStyleBackColor = true;
            this.btmVarAndObject.Click += new System.EventHandler(this.btmVarAndObject_Click);
            // 
            // btnVarTest
            // 
            this.btnVarTest.Location = new System.Drawing.Point(64, 211);
            this.btnVarTest.Name = "btnVarTest";
            this.btnVarTest.Size = new System.Drawing.Size(166, 23);
            this.btnVarTest.TabIndex = 7;
            this.btnVarTest.Text = "var 关键字";
            this.btnVarTest.UseVisualStyleBackColor = true;
            this.btnVarTest.Click += new System.EventHandler(this.btnVarTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 371);
            this.Controls.Add(this.btmVarAndObject);
            this.Controls.Add(this.btnVarTest);
            this.Controls.Add(this.btnExtensionMethodTestv1);
            this.Controls.Add(this.btnExtensionMethodTest);
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
        private System.Windows.Forms.Button btnExtensionMethodTest;
        private System.Windows.Forms.Button btnExtensionMethodTestv1;
        private System.Windows.Forms.Button btmVarAndObject;
        private System.Windows.Forms.Button btnVarTest;
    }
}

