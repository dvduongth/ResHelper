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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbExcludeType = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsbMapVar = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lsbSearchPath = new System.Windows.Forms.ListBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lsbCopyType = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lbText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbText.Enabled = false;
            this.lbText.Location = new System.Drawing.Point(445, 83);
            this.lbText.Name = "lbText";
            this.lbText.ReadOnly = true;
            this.lbText.Size = new System.Drawing.Size(373, 96);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Output Processing Here";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(852, 13);
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
            this.listView.Location = new System.Drawing.Point(6, 24);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(495, 97);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.Location = new System.Drawing.Point(445, 36);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(517, 22);
            this.txtPath.TabIndex = 3;
            this.txtPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirCurPathDragDrop);
            this.txtPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Processing:";
            // 
            // txtResMapPath
            // 
            this.txtResMapPath.AllowDrop = true;
            this.txtResMapPath.Location = new System.Drawing.Point(293, 11);
            this.txtResMapPath.Name = "txtResMapPath";
            this.txtResMapPath.ReadOnly = true;
            this.txtResMapPath.Size = new System.Drawing.Size(553, 22);
            this.txtResMapPath.TabIndex = 7;
            this.txtResMapPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirResMapDragDrop);
            this.txtResMapPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseResMap
            // 
            this.btnBrowseResMap.Location = new System.Drawing.Point(852, 10);
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
            this.label4.Location = new System.Drawing.Point(143, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resource Maps Path:";
            // 
            // btnReadResMap
            // 
            this.btnReadResMap.Location = new System.Drawing.Point(507, 24);
            this.btnReadResMap.Name = "btnReadResMap";
            this.btnReadResMap.Size = new System.Drawing.Size(156, 66);
            this.btnReadResMap.TabIndex = 10;
            this.btnReadResMap.Text = "Do Process Res Map";
            this.btnReadResMap.UseVisualStyleBackColor = true;
            this.btnReadResMap.Click += new System.EventHandler(this.btnReadResMap_Click);
            // 
            // btnDoProcess
            // 
            this.btnDoProcess.Location = new System.Drawing.Point(835, 101);
            this.btnDoProcess.Name = "btnDoProcess";
            this.btnDoProcess.Size = new System.Drawing.Size(127, 65);
            this.btnDoProcess.TabIndex = 11;
            this.btnDoProcess.Text = "Do Process Dir";
            this.btnDoProcess.UseVisualStyleBackColor = true;
            this.btnDoProcess.Click += new System.EventHandler(this.btnDoProcess_Click);
            // 
            // btnClearMapFiles
            // 
            this.btnClearMapFiles.Location = new System.Drawing.Point(507, 96);
            this.btnClearMapFiles.Name = "btnClearMapFiles";
            this.btnClearMapFiles.Size = new System.Drawing.Size(156, 25);
            this.btnClearMapFiles.TabIndex = 12;
            this.btnClearMapFiles.Text = "Clear Map Files";
            this.btnClearMapFiles.UseVisualStyleBackColor = true;
            this.btnClearMapFiles.Click += new System.EventHandler(this.btnClearMapFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Path:";
            // 
            // txtSearchPath
            // 
            this.txtSearchPath.AllowDrop = true;
            this.txtSearchPath.Location = new System.Drawing.Point(293, 17);
            this.txtSearchPath.Name = "txtSearchPath";
            this.txtSearchPath.ReadOnly = true;
            this.txtSearchPath.Size = new System.Drawing.Size(553, 22);
            this.txtSearchPath.TabIndex = 14;
            this.txtSearchPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirSearchDragDrop);
            this.txtSearchPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirPathDragEnter);
            // 
            // btnBrowseSearchPath
            // 
            this.btnBrowseSearchPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseSearchPath.Location = new System.Drawing.Point(852, 16);
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
            this.label7.Location = new System.Drawing.Point(143, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output Path:";
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.Location = new System.Drawing.Point(293, 18);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(553, 22);
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
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.lsbReadType);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(147, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 158);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reading Type";
            // 
            // lsbReadType
            // 
            this.lsbReadType.FormattingEnabled = true;
            this.lsbReadType.ItemHeight = 16;
            this.lsbReadType.Location = new System.Drawing.Point(6, 21);
            this.lsbReadType.Name = "lsbReadType";
            this.lsbReadType.Size = new System.Drawing.Size(120, 100);
            this.lsbReadType.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lsbExcludeType);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 158);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exclude Type";
            // 
            // lsbExcludeType
            // 
            this.lsbExcludeType.FormattingEnabled = true;
            this.lsbExcludeType.ItemHeight = 16;
            this.lsbExcludeType.Location = new System.Drawing.Point(6, 21);
            this.lsbExcludeType.Name = "lsbExcludeType";
            this.lsbExcludeType.Size = new System.Drawing.Size(115, 100);
            this.lsbExcludeType.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.lsbMapVar);
            this.groupBox3.Location = new System.Drawing.Point(12, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 147);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Res Map Variables";
            // 
            // lsbMapVar
            // 
            this.lsbMapVar.FormattingEnabled = true;
            this.lsbMapVar.ItemHeight = 16;
            this.lsbMapVar.Location = new System.Drawing.Point(6, 25);
            this.lsbMapVar.Name = "lsbMapVar";
            this.lsbMapVar.Size = new System.Drawing.Size(150, 84);
            this.lsbMapVar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtResMapPath);
            this.groupBox4.Controls.Add(this.btnBrowseResMap);
            this.groupBox4.Location = new System.Drawing.Point(12, 395);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(968, 184);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resource Variables";
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
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.lsbSearchPath);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtSearchPath);
            this.groupBox6.Controls.Add(this.btnBrowseSearchPath);
            this.groupBox6.Location = new System.Drawing.Point(12, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(968, 124);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Path Dir";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtOutput);
            this.groupBox7.Controls.Add(this.btnBrowseOutput);
            this.groupBox7.Location = new System.Drawing.Point(12, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(968, 47);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output Dir";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.lbText);
            this.groupBox8.Controls.Add(this.btnDoProcess);
            this.groupBox8.Controls.Add(this.btnOpen);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Controls.Add(this.txtPath);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(12, 62);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(968, 199);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Processing and Copy Files";
            // 
            // lsbSearchPath
            // 
            this.lsbSearchPath.FormattingEnabled = true;
            this.lsbSearchPath.ItemHeight = 16;
            this.lsbSearchPath.Location = new System.Drawing.Point(18, 49);
            this.lsbSearchPath.Name = "lsbSearchPath";
            this.lsbSearchPath.Size = new System.Drawing.Size(583, 68);
            this.lsbSearchPath.TabIndex = 16;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button7);
            this.groupBox9.Controls.Add(this.lsbCopyType);
            this.groupBox9.Controls.Add(this.textBox5);
            this.groupBox9.Controls.Add(this.button8);
            this.groupBox9.Location = new System.Drawing.Point(293, 24);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(140, 158);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Copy File Type";
            // 
            // lsbCopyType
            // 
            this.lsbCopyType.FormattingEnabled = true;
            this.lsbCopyType.ItemHeight = 16;
            this.lsbCopyType.Location = new System.Drawing.Point(6, 21);
            this.lsbCopyType.Name = "lsbCopyType";
            this.lsbCopyType.Size = new System.Drawing.Size(120, 100);
            this.lsbCopyType.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(162, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(162, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(53, 36);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(626, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(744, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(607, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(103, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(91, 22);
            this.textBox4.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(103, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 29);
            this.button7.TabIndex = 12;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(91, 22);
            this.textBox5.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(103, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 27);
            this.button8.TabIndex = 10;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add more search path here:";
            // 
            // MainHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 593);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Helper";
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;

    }
}

