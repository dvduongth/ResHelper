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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHelper));
            this.lbText = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResMapPath = new System.Windows.Forms.TextBox();
            this.btnBrowseResMap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReadResMap = new System.Windows.Forms.Button();
            this.btnDoProcess = new System.Windows.Forms.Button();
            this.btnClearMapFiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPath = new System.Windows.Forms.TextBox();
            this.btnBrowseSearchPath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Enabled = false;
            this.lbText.Location = new System.Drawing.Point(12, 341);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(968, 96);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(848, 458);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Browse File";
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
            this.listView.Location = new System.Drawing.Point(12, 29);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(968, 97);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.Location = new System.Drawing.Point(185, 461);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(633, 22);
            this.txtPath.TabIndex = 3;
            this.txtPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirCurPathDragDrop);
            this.txtPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Processing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "List Map Resource Files";
            // 
            // txtResMapPath
            // 
            this.txtResMapPath.AllowDrop = true;
            this.txtResMapPath.Location = new System.Drawing.Point(185, 163);
            this.txtResMapPath.Name = "txtResMapPath";
            this.txtResMapPath.ReadOnly = true;
            this.txtResMapPath.Size = new System.Drawing.Size(633, 22);
            this.txtResMapPath.TabIndex = 7;
            this.txtResMapPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirResMapDragDrop);
            this.txtResMapPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseResMap
            // 
            this.btnBrowseResMap.Location = new System.Drawing.Point(848, 160);
            this.btnBrowseResMap.Name = "btnBrowseResMap";
            this.btnBrowseResMap.Size = new System.Drawing.Size(110, 23);
            this.btnBrowseResMap.TabIndex = 8;
            this.btnBrowseResMap.Text = "Browse Dir";
            this.btnBrowseResMap.UseVisualStyleBackColor = true;
            this.btnBrowseResMap.Click += new System.EventHandler(this.btnBrowseResMap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resource Maps Path:";
            // 
            // btnReadResMap
            // 
            this.btnReadResMap.Location = new System.Drawing.Point(395, 191);
            this.btnReadResMap.Name = "btnReadResMap";
            this.btnReadResMap.Size = new System.Drawing.Size(156, 23);
            this.btnReadResMap.TabIndex = 10;
            this.btnReadResMap.Text = "Read Res Map";
            this.btnReadResMap.UseVisualStyleBackColor = true;
            this.btnReadResMap.Click += new System.EventHandler(this.btnReadResMap_Click);
            // 
            // btnDoProcess
            // 
            this.btnDoProcess.Location = new System.Drawing.Point(395, 490);
            this.btnDoProcess.Name = "btnDoProcess";
            this.btnDoProcess.Size = new System.Drawing.Size(156, 23);
            this.btnDoProcess.TabIndex = 11;
            this.btnDoProcess.Text = "Do Process Dir";
            this.btnDoProcess.UseVisualStyleBackColor = true;
            this.btnDoProcess.Click += new System.EventHandler(this.btnDoProcess_Click);
            // 
            // btnClearMapFiles
            // 
            this.btnClearMapFiles.Location = new System.Drawing.Point(395, 133);
            this.btnClearMapFiles.Name = "btnClearMapFiles";
            this.btnClearMapFiles.Size = new System.Drawing.Size(156, 23);
            this.btnClearMapFiles.TabIndex = 12;
            this.btnClearMapFiles.Text = "Clear Map Files";
            this.btnClearMapFiles.UseVisualStyleBackColor = true;
            this.btnClearMapFiles.Click += new System.EventHandler(this.btnClearMapFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Path:";
            // 
            // txtSearchPath
            // 
            this.txtSearchPath.AllowDrop = true;
            this.txtSearchPath.Location = new System.Drawing.Point(185, 251);
            this.txtSearchPath.Name = "txtSearchPath";
            this.txtSearchPath.ReadOnly = true;
            this.txtSearchPath.Size = new System.Drawing.Size(633, 22);
            this.txtSearchPath.TabIndex = 14;
            this.txtSearchPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirSearchDragDrop);
            this.txtSearchPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseSearchPath
            // 
            this.btnBrowseSearchPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseSearchPath.Location = new System.Drawing.Point(848, 249);
            this.btnBrowseSearchPath.Name = "btnBrowseSearchPath";
            this.btnBrowseSearchPath.Size = new System.Drawing.Size(110, 23);
            this.btnBrowseSearchPath.TabIndex = 15;
            this.btnBrowseSearchPath.Text = "Browse Dir";
            this.btnBrowseSearchPath.UseVisualStyleBackColor = true;
            this.btnBrowseSearchPath.Click += new System.EventHandler(this.btnBrowseSearchPath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Add Search Path Here";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output Path:";
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.Location = new System.Drawing.Point(185, 288);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(633, 22);
            this.txtOutput.TabIndex = 18;
            this.txtOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirOutputDragDrop);
            this.txtOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(848, 286);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(110, 23);
            this.btnBrowseOutput.TabIndex = 19;
            this.btnBrowseOutput.Text = "Browse Dir";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // MainHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 516);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBrowseSearchPath);
            this.Controls.Add(this.txtSearchPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearMapFiles);
            this.Controls.Add(this.btnDoProcess);
            this.Controls.Add(this.btnReadResMap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseResMap);
            this.Controls.Add(this.txtResMapPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResMapPath;
        private System.Windows.Forms.Button btnBrowseResMap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReadResMap;
        private System.Windows.Forms.Button btnDoProcess;
        private System.Windows.Forms.Button btnClearMapFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchPath;
        private System.Windows.Forms.Button btnBrowseSearchPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrowseOutput;

    }
}

