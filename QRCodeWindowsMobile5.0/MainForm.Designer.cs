namespace QRCodeWindowsMobile5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cboCorrectionLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboVersion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEncoding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncodeData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picEncode = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtDecodedData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picDecode = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "E&xit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.cboCorrectionLevel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboVersion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboEncoding);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtEncodeData);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.picEncode);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 245);
            this.tabPage1.Text = "Encode";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 27);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(7, 215);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(94, 27);
            this.btnEncode.TabIndex = 18;
            this.btnEncode.Text = "Encode";
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // cboCorrectionLevel
            // 
            this.cboCorrectionLevel.Items.Add("L");
            this.cboCorrectionLevel.Items.Add("M");
            this.cboCorrectionLevel.Items.Add("Q");
            this.cboCorrectionLevel.Items.Add("H");
            this.cboCorrectionLevel.Location = new System.Drawing.Point(122, 182);
            this.cboCorrectionLevel.Name = "cboCorrectionLevel";
            this.cboCorrectionLevel.Size = new System.Drawing.Size(84, 22);
            this.cboCorrectionLevel.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.Text = "Correction Level";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(67, 162);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(49, 21);
            this.txtSize.TabIndex = 13;
            this.txtSize.Text = "4";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.Text = "Size";
            // 
            // cboVersion
            // 
            this.cboVersion.Items.Add("1");
            this.cboVersion.Items.Add("2");
            this.cboVersion.Items.Add("3");
            this.cboVersion.Items.Add("4");
            this.cboVersion.Items.Add("5");
            this.cboVersion.Items.Add("6");
            this.cboVersion.Items.Add("7");
            this.cboVersion.Items.Add("8");
            this.cboVersion.Items.Add("9");
            this.cboVersion.Items.Add("10");
            this.cboVersion.Items.Add("11");
            this.cboVersion.Items.Add("12");
            this.cboVersion.Items.Add("13");
            this.cboVersion.Items.Add("14");
            this.cboVersion.Items.Add("15");
            this.cboVersion.Items.Add("16");
            this.cboVersion.Items.Add("17");
            this.cboVersion.Items.Add("18");
            this.cboVersion.Items.Add("19");
            this.cboVersion.Items.Add("20");
            this.cboVersion.Items.Add("21");
            this.cboVersion.Items.Add("22");
            this.cboVersion.Items.Add("23");
            this.cboVersion.Items.Add("40");
            this.cboVersion.Items.Add("25");
            this.cboVersion.Items.Add("26");
            this.cboVersion.Items.Add("27");
            this.cboVersion.Items.Add("28");
            this.cboVersion.Items.Add("29");
            this.cboVersion.Items.Add("30");
            this.cboVersion.Items.Add("31");
            this.cboVersion.Items.Add("32");
            this.cboVersion.Items.Add("33");
            this.cboVersion.Items.Add("34");
            this.cboVersion.Items.Add("35");
            this.cboVersion.Items.Add("36");
            this.cboVersion.Items.Add("37");
            this.cboVersion.Items.Add("38");
            this.cboVersion.Items.Add("39");
            this.cboVersion.Items.Add("40");
            this.cboVersion.Location = new System.Drawing.Point(67, 136);
            this.cboVersion.Name = "cboVersion";
            this.cboVersion.Size = new System.Drawing.Size(157, 22);
            this.cboVersion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.Text = "Version";
            // 
            // cboEncoding
            // 
            this.cboEncoding.Items.Add("AlphaNumeric");
            this.cboEncoding.Items.Add("Numeric");
            this.cboEncoding.Items.Add("Byte");
            this.cboEncoding.Location = new System.Drawing.Point(67, 106);
            this.cboEncoding.Name = "cboEncoding";
            this.cboEncoding.Size = new System.Drawing.Size(157, 22);
            this.cboEncoding.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.Text = "Encoding";
            // 
            // txtEncodeData
            // 
            this.txtEncodeData.Location = new System.Drawing.Point(43, 79);
            this.txtEncodeData.Name = "txtEncodeData";
            this.txtEncodeData.Size = new System.Drawing.Size(190, 21);
            this.txtEncodeData.TabIndex = 4;
            this.txtEncodeData.Text = "ThoughtWorks ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.Text = "Data";
            // 
            // picEncode
            // 
            this.picEncode.Location = new System.Drawing.Point(0, 0);
            this.picEncode.Name = "picEncode";
            this.picEncode.Size = new System.Drawing.Size(240, 73);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOpen);
            this.tabPage2.Controls.Add(this.btnDecode);
            this.tabPage2.Controls.Add(this.txtDecodedData);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.picDecode);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 245);
            this.tabPage2.Text = "Decode";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 164);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 27);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(131, 164);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(94, 27);
            this.btnDecode.TabIndex = 10;
            this.btnDecode.Text = "Decode";
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtDecodedData
            // 
            this.txtDecodedData.Location = new System.Drawing.Point(48, 112);
            this.txtDecodedData.Name = "txtDecodedData";
            this.txtDecodedData.Size = new System.Drawing.Size(185, 21);
            this.txtDecodedData.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.Text = "Data";
            // 
            // picDecode
            // 
            this.picDecode.Location = new System.Drawing.Point(0, 0);
            this.picDecode.Name = "picDecode";
            this.picDecode.Size = new System.Drawing.Size(240, 106);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "QRCode.NET Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picEncode;
        private System.Windows.Forms.TextBox txtEncodeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEncoding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCorrectionLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.PictureBox picDecode;
        private System.Windows.Forms.TextBox txtDecodedData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}