namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Spawn Rate");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Spawns", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Order Stronghold");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Knighthood Orders", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tweaks", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.selectDirectoryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.testTweaksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 58);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Spawn Rate";
            treeNode2.Name = "Node 1";
            treeNode2.Text = "Spawns";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Order Stronghold";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Knighthood Orders";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Tweaks";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(222, 335);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(305, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(427, 294);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(305, 359);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // selectDirectoryButton
            // 
            this.selectDirectoryButton.Location = new System.Drawing.Point(13, 12);
            this.selectDirectoryButton.Name = "selectDirectoryButton";
            this.selectDirectoryButton.Size = new System.Drawing.Size(117, 31);
            this.selectDirectoryButton.TabIndex = 3;
            this.selectDirectoryButton.Text = "Select Mod Directory";
            this.selectDirectoryButton.UseVisualStyleBackColor = true;
            this.selectDirectoryButton.Click += new System.EventHandler(this.selectDirectoryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Please select your Mod Directory";
            // 
            // testTweaksButton
            // 
            this.testTweaksButton.Location = new System.Drawing.Point(405, 5);
            this.testTweaksButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.testTweaksButton.Name = "testTweaksButton";
            this.testTweaksButton.Size = new System.Drawing.Size(178, 35);
            this.testTweaksButton.TabIndex = 5;
            this.testTweaksButton.Text = "test tweaks";
            this.testTweaksButton.UseVisualStyleBackColor = true;
            this.testTweaksButton.Click += new System.EventHandler(this.testTweaksButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 415);
            this.Controls.Add(this.testTweaksButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectDirectoryButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button selectDirectoryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button testTweaksButton;
    }
}

