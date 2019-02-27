namespace TAika
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridi = new System.Windows.Forms.DataGridView();
            this.pnl = new System.Windows.Forms.Panel();
            this.dialogi = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.txtTunnit = new System.Windows.Forms.TextBox();
            this.txtLoppuaika = new System.Windows.Forms.TextBox();
            this.txtAlkuaika = new System.Windows.Forms.TextBox();
            this.lblPaivays = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kk_taakse = new System.Windows.Forms.Button();
            this.kk_eteen = new System.Windows.Forms.Button();
            this.lblKk = new System.Windows.Forms.Label();
            this.lblViikko = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTAikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridi)).BeginInit();
            this.pnl.SuspendLayout();
            this.dialogi.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridi
            // 
            this.gridi.AllowUserToAddRows = false;
            this.gridi.AllowUserToDeleteRows = false;
            this.gridi.AllowUserToResizeRows = false;
            this.gridi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridi.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridi.Location = new System.Drawing.Point(12, 64);
            this.gridi.Name = "gridi";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridi.Size = new System.Drawing.Size(903, 484);
            this.gridi.TabIndex = 0;
            this.gridi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridi_CellClick);
            this.gridi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridi_doubleClick);
            this.gridi.SelectionChanged += new System.EventHandler(this.gridi_SelectionChanged);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.Control;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl.Controls.Add(this.dialogi);
            this.pnl.Location = new System.Drawing.Point(106, 54);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(659, 510);
            this.pnl.TabIndex = 6;
            this.pnl.Visible = false;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // dialogi
            // 
            this.dialogi.BackColor = System.Drawing.SystemColors.Control;
            this.dialogi.Controls.Add(this.lblID);
            this.dialogi.Controls.Add(this.button4);
            this.dialogi.Controls.Add(this.button3);
            this.dialogi.Controls.Add(this.label5);
            this.dialogi.Controls.Add(this.label4);
            this.dialogi.Controls.Add(this.label3);
            this.dialogi.Controls.Add(this.label2);
            this.dialogi.Controls.Add(this.label1);
            this.dialogi.Controls.Add(this.txtInfo);
            this.dialogi.Controls.Add(this.dtPicker);
            this.dialogi.Controls.Add(this.txtTunnit);
            this.dialogi.Controls.Add(this.txtLoppuaika);
            this.dialogi.Controls.Add(this.txtAlkuaika);
            this.dialogi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dialogi.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dialogi.Location = new System.Drawing.Point(24, 21);
            this.dialogi.Name = "dialogi";
            this.dialogi.Padding = new System.Windows.Forms.Padding(5);
            this.dialogi.Size = new System.Drawing.Size(598, 466);
            this.dialogi.TabIndex = 5;
            this.dialogi.TabStop = false;
            this.dialogi.Text = "Tiedon lisäys";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 248);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 22);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "-1";
            this.lblID.Visible = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(354, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Peruuta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(465, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Päiväys:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lisätietoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Työaika:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loppuaika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alkuaika:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(162, 174);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(408, 220);
            this.txtInfo.TabIndex = 4;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(162, 41);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(408, 29);
            this.dtPicker.TabIndex = 3;
            // 
            // txtTunnit
            // 
            this.txtTunnit.Enabled = false;
            this.txtTunnit.Location = new System.Drawing.Point(162, 158);
            this.txtTunnit.Name = "txtTunnit";
            this.txtTunnit.Size = new System.Drawing.Size(408, 29);
            this.txtTunnit.TabIndex = 2;
            this.txtTunnit.Visible = false;
            // 
            // txtLoppuaika
            // 
            this.txtLoppuaika.Location = new System.Drawing.Point(162, 123);
            this.txtLoppuaika.Name = "txtLoppuaika";
            this.txtLoppuaika.Size = new System.Drawing.Size(408, 29);
            this.txtLoppuaika.TabIndex = 1;
            // 
            // txtAlkuaika
            // 
            this.txtAlkuaika.Location = new System.Drawing.Point(162, 88);
            this.txtAlkuaika.Name = "txtAlkuaika";
            this.txtAlkuaika.Size = new System.Drawing.Size(408, 29);
            this.txtAlkuaika.TabIndex = 0;
            // 
            // lblPaivays
            // 
            this.lblPaivays.AutoSize = true;
            this.lblPaivays.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaivays.Location = new System.Drawing.Point(12, 26);
            this.lblPaivays.Name = "lblPaivays";
            this.lblPaivays.Size = new System.Drawing.Size(67, 26);
            this.lblPaivays.TabIndex = 1;
            this.lblPaivays.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(579, 565);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Lisää rivi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(688, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Poista rivi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(812, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lopeta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kk_taakse
            // 
            this.kk_taakse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kk_taakse.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kk_taakse.Location = new System.Drawing.Point(12, 565);
            this.kk_taakse.Name = "kk_taakse";
            this.kk_taakse.Size = new System.Drawing.Size(41, 37);
            this.kk_taakse.TabIndex = 7;
            this.kk_taakse.Text = "<";
            this.kk_taakse.UseVisualStyleBackColor = true;
            this.kk_taakse.Click += new System.EventHandler(this.kk_taakse_Click);
            // 
            // kk_eteen
            // 
            this.kk_eteen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kk_eteen.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kk_eteen.Location = new System.Drawing.Point(59, 565);
            this.kk_eteen.Name = "kk_eteen";
            this.kk_eteen.Size = new System.Drawing.Size(41, 37);
            this.kk_eteen.TabIndex = 8;
            this.kk_eteen.Text = ">";
            this.kk_eteen.UseVisualStyleBackColor = true;
            this.kk_eteen.Click += new System.EventHandler(this.kk_eteen_Click);
            // 
            // lblKk
            // 
            this.lblKk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKk.AutoSize = true;
            this.lblKk.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKk.Location = new System.Drawing.Point(135, 572);
            this.lblKk.Name = "lblKk";
            this.lblKk.Size = new System.Drawing.Size(55, 22);
            this.lblKk.TabIndex = 9;
            this.lblKk.Text = "label6";
            // 
            // lblViikko
            // 
            this.lblViikko.AutoSize = true;
            this.lblViikko.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViikko.Location = new System.Drawing.Point(473, 24);
            this.lblViikko.Name = "lblViikko";
            this.lblViikko.Size = new System.Drawing.Size(30, 26);
            this.lblViikko.TabIndex = 12;
            this.lblViikko.Text = "---";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(927, 24);
            this.menu.TabIndex = 13;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutTAikaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.fileToolStripMenuItem.Text = "Tiedosto";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Lopeta";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutTAikaToolStripMenuItem
            // 
            this.aboutTAikaToolStripMenuItem.Name = "aboutTAikaToolStripMenuItem";
            this.aboutTAikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutTAikaToolStripMenuItem.Text = "Tietoja ohjelmasta";
            this.aboutTAikaToolStripMenuItem.Click += new System.EventHandler(this.aboutTAikaToolStripMenuItem_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackgroundImage = global::TAika.Properties.Resources.print;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(759, 8);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(49, 46);
            this.btnReport.TabIndex = 10;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TAika.Properties.Resources.kello;
            this.pictureBox1.Location = new System.Drawing.Point(711, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 614);
            this.Controls.Add(this.lblViikko);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKk);
            this.Controls.Add(this.kk_eteen);
            this.Controls.Add(this.kk_taakse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPaivays);
            this.Controls.Add(this.gridi);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "TN - TAika";
            ((System.ComponentModel.ISupportInitialize)(this.gridi)).EndInit();
            this.pnl.ResumeLayout(false);
            this.dialogi.ResumeLayout(false);
            this.dialogi.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridi;
        private System.Windows.Forms.Label lblPaivays;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox dialogi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.TextBox txtTunnit;
        private System.Windows.Forms.TextBox txtLoppuaika;
        private System.Windows.Forms.TextBox txtAlkuaika;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button kk_taakse;
        private System.Windows.Forms.Button kk_eteen;
        private System.Windows.Forms.Label lblKk;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblViikko;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTAikaToolStripMenuItem;
    }
}

