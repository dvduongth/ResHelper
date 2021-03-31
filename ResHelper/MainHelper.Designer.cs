namespace ResHelper
{
    partial class MainHelper
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
            this.components = new System.ComponentModel.Container();
            this.lbText = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Enabled = false;
            this.lbText.Location = new System.Drawing.Point(12, 12);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(968, 96);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(460, 353);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(12, 127);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(968, 97);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(120, 259);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(860, 22);
            this.txtPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            // 
            // MainHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lbText);
            this.Name = "MainHelper";
            this.Text = "Main Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox lbText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;

    }
}

