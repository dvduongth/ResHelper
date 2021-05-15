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
            this.txtResMapPath = new System.Windows.Forms.TextBox();
            this.btnBrowseResMap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReadResMap = new System.Windows.Forms.Button();
            this.btnDoProcess = new System.Windows.Forms.Button();
            this.btnClearMapFiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPath = new System.Windows.Forms.TextBox();
            this.btnBrowseSearchPath = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbReadType = new System.Windows.Forms.ListBox();
            this.tbReadType = new System.Windows.Forms.TextBox();
            this.btnAddReadType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAddExcludeType = new System.Windows.Forms.TextBox();
            this.btnAddExcludeType = new System.Windows.Forms.Button();
            this.lsbExcludeType = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMapVar = new System.Windows.Forms.TextBox();
            this.btnAddMapVar = new System.Windows.Forms.Button();
            this.lsbMapVar = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddSearchPath = new System.Windows.Forms.TextBox();
            this.btnAddSearchPath = new System.Windows.Forms.Button();
            this.lsbSearchPath = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbLogFound = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lsbCopyType = new System.Windows.Forms.ListBox();
            this.tbCopyType = new System.Windows.Forms.TextBox();
            this.btnAddCopyType = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbText.Enabled = false;
            this.lbText.Location = new System.Drawing.Point(445, 155);
            this.lbText.Name = "lbText";
            this.lbText.ReadOnly = true;
            this.lbText.Size = new System.Drawing.Size(511, 96);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Output Processing Here! Read Only...";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(852, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Browse Dir";
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
            this.listView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(6, 24);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(547, 97);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPath.Location = new System.Drawing.Point(153, 17);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(693, 22);
            this.txtPath.TabIndex = 3;
            this.txtPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirCurPathDragDrop);
            this.txtPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directory Path:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Processing:";
            // 
            // txtResMapPath
            // 
            this.txtResMapPath.AllowDrop = true;
            this.txtResMapPath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResMapPath.Location = new System.Drawing.Point(214, 20);
            this.txtResMapPath.Name = "txtResMapPath";
            this.txtResMapPath.ReadOnly = true;
            this.txtResMapPath.Size = new System.Drawing.Size(632, 22);
            this.txtResMapPath.TabIndex = 7;
            this.txtResMapPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirResMapDragDrop);
            this.txtResMapPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseResMap
            // 
            this.btnBrowseResMap.Location = new System.Drawing.Point(852, 19);
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
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resource Maps Path:";
            // 
            // btnReadResMap
            // 
            this.btnReadResMap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReadResMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadResMap.Location = new System.Drawing.Point(559, 24);
            this.btnReadResMap.Name = "btnReadResMap";
            this.btnReadResMap.Size = new System.Drawing.Size(104, 66);
            this.btnReadResMap.TabIndex = 10;
            this.btnReadResMap.Text = "Start Process Res Map";
            this.btnReadResMap.UseVisualStyleBackColor = false;
            this.btnReadResMap.Click += new System.EventHandler(this.btnReadResMap_Click);
            // 
            // btnDoProcess
            // 
            this.btnDoProcess.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoProcess.BackgroundImage = global::ResHelper.Properties.Resources.icon_scan;
            this.btnDoProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoProcess.Location = new System.Drawing.Point(445, 43);
            this.btnDoProcess.Name = "btnDoProcess";
            this.btnDoProcess.Size = new System.Drawing.Size(110, 110);
            this.btnDoProcess.TabIndex = 11;
            this.btnDoProcess.UseVisualStyleBackColor = false;
            this.btnDoProcess.Click += new System.EventHandler(this.btnDoProcess_Click);
            // 
            // btnClearMapFiles
            // 
            this.btnClearMapFiles.Font = new System.Drawing.Font("Calibri Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMapFiles.Location = new System.Drawing.Point(559, 96);
            this.btnClearMapFiles.Name = "btnClearMapFiles";
            this.btnClearMapFiles.Size = new System.Drawing.Size(104, 25);
            this.btnClearMapFiles.TabIndex = 12;
            this.btnClearMapFiles.Text = "Clear Map Files";
            this.btnClearMapFiles.UseVisualStyleBackColor = true;
            this.btnClearMapFiles.Click += new System.EventHandler(this.btnClearMapFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Auto Search Path:";
            // 
            // txtSearchPath
            // 
            this.txtSearchPath.AllowDrop = true;
            this.txtSearchPath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearchPath.Location = new System.Drawing.Point(214, 15);
            this.txtSearchPath.Name = "txtSearchPath";
            this.txtSearchPath.ReadOnly = true;
            this.txtSearchPath.Size = new System.Drawing.Size(632, 22);
            this.txtSearchPath.TabIndex = 14;
            this.txtSearchPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirSearchDragDrop);
            this.txtSearchPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseSearchPath
            // 
            this.btnBrowseSearchPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseSearchPath.Location = new System.Drawing.Point(852, 14);
            this.btnBrowseSearchPath.Name = "btnBrowseSearchPath";
            this.btnBrowseSearchPath.Size = new System.Drawing.Size(110, 23);
            this.btnBrowseSearchPath.TabIndex = 15;
            this.btnBrowseSearchPath.Text = "Browse Dir";
            this.btnBrowseSearchPath.UseVisualStyleBackColor = true;
            this.btnBrowseSearchPath.Click += new System.EventHandler(this.btnBrowseSearchPath_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Marker", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output Path:";
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtOutput.Location = new System.Drawing.Point(153, 18);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(693, 22);
            this.txtOutput.TabIndex = 18;
            this.txtOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirOutputDragDrop);
            this.txtOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(852, 17);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(110, 23);
            this.btnBrowseOutput.TabIndex = 19;
            this.btnBrowseOutput.Text = "Browse Dir";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lsbReadType);
            this.groupBox1.Controls.Add(this.tbReadType);
            this.groupBox1.Controls.Add(this.btnAddReadType);
            this.groupBox1.Location = new System.Drawing.Point(147, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 158);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reading Type";
            // 
            // lsbReadType
            // 
            this.lsbReadType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsbReadType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbReadType.FormattingEnabled = true;
            this.lsbReadType.ItemHeight = 16;
            this.lsbReadType.Location = new System.Drawing.Point(6, 21);
            this.lsbReadType.Name = "lsbReadType";
            this.lsbReadType.Size = new System.Drawing.Size(120, 100);
            this.lsbReadType.TabIndex = 0;
            this.lsbReadType.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedIndexChangedReadType);
            // 
            // tbReadType
            // 
            this.tbReadType.Location = new System.Drawing.Point(6, 129);
            this.tbReadType.Name = "tbReadType";
            this.tbReadType.Size = new System.Drawing.Size(91, 22);
            this.tbReadType.TabIndex = 8;
            // 
            // btnAddReadType
            // 
            this.btnAddReadType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReadType.Location = new System.Drawing.Point(103, 127);
            this.btnAddReadType.Name = "btnAddReadType";
            this.btnAddReadType.Size = new System.Drawing.Size(31, 27);
            this.btnAddReadType.TabIndex = 7;
            this.btnAddReadType.Text = "+";
            this.btnAddReadType.UseVisualStyleBackColor = true;
            this.btnAddReadType.Click += new System.EventHandler(this.btnAddReadType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tbAddExcludeType);
            this.groupBox2.Controls.Add(this.btnAddExcludeType);
            this.groupBox2.Controls.Add(this.lsbExcludeType);
            this.groupBox2.Location = new System.Drawing.Point(6, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 158);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exclude Type";
            // 
            // tbAddExcludeType
            // 
            this.tbAddExcludeType.Location = new System.Drawing.Point(6, 130);
            this.tbAddExcludeType.Name = "tbAddExcludeType";
            this.tbAddExcludeType.Size = new System.Drawing.Size(91, 22);
            this.tbAddExcludeType.TabIndex = 5;
            // 
            // btnAddExcludeType
            // 
            this.btnAddExcludeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExcludeType.Location = new System.Drawing.Point(103, 128);
            this.btnAddExcludeType.Name = "btnAddExcludeType";
            this.btnAddExcludeType.Size = new System.Drawing.Size(31, 27);
            this.btnAddExcludeType.TabIndex = 4;
            this.btnAddExcludeType.Text = "+";
            this.btnAddExcludeType.UseVisualStyleBackColor = true;
            this.btnAddExcludeType.Click += new System.EventHandler(this.btnAddExcludeType_Click);
            // 
            // lsbExcludeType
            // 
            this.lsbExcludeType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsbExcludeType.FormattingEnabled = true;
            this.lsbExcludeType.ItemHeight = 16;
            this.lsbExcludeType.Location = new System.Drawing.Point(6, 21);
            this.lsbExcludeType.Name = "lsbExcludeType";
            this.lsbExcludeType.Size = new System.Drawing.Size(115, 100);
            this.lsbExcludeType.TabIndex = 0;
            this.lsbExcludeType.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedIndexChangedExcludeType);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMapVar);
            this.groupBox3.Controls.Add(this.btnAddMapVar);
            this.groupBox3.Controls.Add(this.lsbMapVar);
            this.groupBox3.Location = new System.Drawing.Point(12, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 134);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Res Map Variables";
            // 
            // tbMapVar
            // 
            this.tbMapVar.Location = new System.Drawing.Point(7, 106);
            this.tbMapVar.Name = "tbMapVar";
            this.tbMapVar.Size = new System.Drawing.Size(189, 22);
            this.tbMapVar.TabIndex = 3;
            // 
            // btnAddMapVar
            // 
            this.btnAddMapVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMapVar.Location = new System.Drawing.Point(202, 102);
            this.btnAddMapVar.Name = "btnAddMapVar";
            this.btnAddMapVar.Size = new System.Drawing.Size(53, 27);
            this.btnAddMapVar.TabIndex = 1;
            this.btnAddMapVar.Text = "+";
            this.btnAddMapVar.UseVisualStyleBackColor = true;
            this.btnAddMapVar.Click += new System.EventHandler(this.btnAddMapVar_Click);
            // 
            // lsbMapVar
            // 
            this.lsbMapVar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsbMapVar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbMapVar.FormattingEnabled = true;
            this.lsbMapVar.ItemHeight = 16;
            this.lsbMapVar.Location = new System.Drawing.Point(6, 18);
            this.lsbMapVar.Name = "lsbMapVar";
            this.lsbMapVar.Size = new System.Drawing.Size(249, 84);
            this.lsbMapVar.TabIndex = 0;
            this.lsbMapVar.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedIndexChangedMapVar);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtResMapPath);
            this.groupBox4.Controls.Add(this.btnBrowseResMap);
            this.groupBox4.Location = new System.Drawing.Point(48, 477);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(968, 184);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resource Variables SEARCH";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView);
            this.groupBox5.Controls.Add(this.btnClearMapFiles);
            this.groupBox5.Controls.Add(this.btnReadResMap);
            this.groupBox5.Location = new System.Drawing.Point(293, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(669, 134);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List Map Resource Files";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.tbAddSearchPath);
            this.groupBox6.Controls.Add(this.btnAddSearchPath);
            this.groupBox6.Controls.Add(this.lsbSearchPath);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtSearchPath);
            this.groupBox6.Controls.Add(this.btnBrowseSearchPath);
            this.groupBox6.Location = new System.Drawing.Point(48, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(968, 134);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SEARCH Path Dir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add more search path here:";
            // 
            // tbAddSearchPath
            // 
            this.tbAddSearchPath.Location = new System.Drawing.Point(214, 102);
            this.tbAddSearchPath.Name = "tbAddSearchPath";
            this.tbAddSearchPath.Size = new System.Drawing.Size(580, 22);
            this.tbAddSearchPath.TabIndex = 5;
            // 
            // btnAddSearchPath
            // 
            this.btnAddSearchPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSearchPath.Location = new System.Drawing.Point(800, 99);
            this.btnAddSearchPath.Name = "btnAddSearchPath";
            this.btnAddSearchPath.Size = new System.Drawing.Size(46, 27);
            this.btnAddSearchPath.TabIndex = 4;
            this.btnAddSearchPath.Text = "+";
            this.btnAddSearchPath.UseVisualStyleBackColor = true;
            this.btnAddSearchPath.Click += new System.EventHandler(this.btnAddSearchPath_Click);
            // 
            // lsbSearchPath
            // 
            this.lsbSearchPath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsbSearchPath.FormattingEnabled = true;
            this.lsbSearchPath.ItemHeight = 16;
            this.lsbSearchPath.Location = new System.Drawing.Point(18, 41);
            this.lsbSearchPath.Name = "lsbSearchPath";
            this.lsbSearchPath.Size = new System.Drawing.Size(828, 52);
            this.lsbSearchPath.TabIndex = 16;
            this.lsbSearchPath.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedIndexChangedSearchPath);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtOutput);
            this.groupBox7.Controls.Add(this.btnBrowseOutput);
            this.groupBox7.Location = new System.Drawing.Point(48, 270);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(968, 47);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "OUTPUT Dir";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbLogFound);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.lbText);
            this.groupBox8.Controls.Add(this.btnDoProcess);
            this.groupBox8.Controls.Add(this.btnOpen);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Controls.Add(this.txtPath);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(48, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(968, 260);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Processing and Copy Files";
            // 
            // cbLogFound
            // 
            this.cbLogFound.AutoSize = true;
            this.cbLogFound.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLogFound.Location = new System.Drawing.Point(590, 97);
            this.cbLogFound.Name = "cbLogFound";
            this.cbLogFound.Size = new System.Drawing.Size(187, 24);
            this.cbLogFound.TabIndex = 24;
            this.cbLogFound.Text = "Log Found Information";
            this.cbLogFound.UseVisualStyleBackColor = true;
            this.cbLogFound.CheckedChanged += new System.EventHandler(this.cbLogFound_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(586, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Drag - Drop File or Directory on Highlight Text Box!!!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Start Scan Now =>";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.lsbCopyType);
            this.groupBox9.Controls.Add(this.tbCopyType);
            this.groupBox9.Controls.Add(this.btnAddCopyType);
            this.groupBox9.Location = new System.Drawing.Point(293, 96);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(140, 158);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Copy File Type";
            // 
            // lsbCopyType
            // 
            this.lsbCopyType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsbCopyType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCopyType.FormattingEnabled = true;
            this.lsbCopyType.ItemHeight = 16;
            this.lsbCopyType.Location = new System.Drawing.Point(6, 21);
            this.lsbCopyType.Name = "lsbCopyType";
            this.lsbCopyType.Size = new System.Drawing.Size(120, 100);
            this.lsbCopyType.TabIndex = 0;
            this.lsbCopyType.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedIndexChangedCopyType);
            // 
            // tbCopyType
            // 
            this.tbCopyType.Location = new System.Drawing.Point(6, 126);
            this.tbCopyType.Name = "tbCopyType";
            this.tbCopyType.Size = new System.Drawing.Size(91, 22);
            this.tbCopyType.TabIndex = 11;
            // 
            // btnAddCopyType
            // 
            this.btnAddCopyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCopyType.Location = new System.Drawing.Point(103, 124);
            this.btnAddCopyType.Name = "btnAddCopyType";
            this.btnAddCopyType.Size = new System.Drawing.Size(31, 27);
            this.btnAddCopyType.TabIndex = 10;
            this.btnAddCopyType.Text = "+";
            this.btnAddCopyType.UseVisualStyleBackColor = true;
            this.btnAddCopyType.Click += new System.EventHandler(this.btnAddCopyType_Click);
            // 
            // MainHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "639299";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox lbText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResMapPath;
        private System.Windows.Forms.Button btnBrowseResMap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReadResMap;
        private System.Windows.Forms.Button btnDoProcess;
        private System.Windows.Forms.Button btnClearMapFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchPath;
        private System.Windows.Forms.Button btnBrowseSearchPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbReadType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbExcludeType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsbMapVar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox lsbSearchPath;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox lsbCopyType;
        private System.Windows.Forms.Button btnAddMapVar;
        private System.Windows.Forms.TextBox tbMapVar;
        private System.Windows.Forms.TextBox tbAddExcludeType;
        private System.Windows.Forms.Button btnAddExcludeType;
        private System.Windows.Forms.TextBox tbAddSearchPath;
        private System.Windows.Forms.Button btnAddSearchPath;
        private System.Windows.Forms.TextBox tbReadType;
        private System.Windows.Forms.Button btnAddReadType;
        private System.Windows.Forms.TextBox tbCopyType;
        private System.Windows.Forms.Button btnAddCopyType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbLogFound;

    }
}

