namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VentanaPicker1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FormName = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.VentanaPicker1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(40, 62);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(305, 27);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(40, 96);
            this.hScrollBar2.Maximum = 255;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(305, 27);
            this.hScrollBar2.TabIndex = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(40, 134);
            this.hScrollBar3.Maximum = 255;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(305, 29);
            this.hScrollBar3.TabIndex = 2;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.Location = new System.Drawing.Point(40, 172);
            this.hScrollBar4.Maximum = 255;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(305, 27);
            this.hScrollBar4.TabIndex = 3;
            this.hScrollBar4.Value = 255;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "G";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(21, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "B";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(421, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "None ..";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "PAWN Color Picker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-6, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 23);
            this.panel1.TabIndex = 11;
            // 
            // VentanaPicker1
            // 
            this.VentanaPicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.VentanaPicker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VentanaPicker1.Controls.Add(this.panel2);
            this.VentanaPicker1.Controls.Add(this.FormName);
            this.VentanaPicker1.Controls.Add(this.ControlPanel);
            this.VentanaPicker1.Controls.Add(this.panel3);
            this.VentanaPicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.VentanaPicker1.Location = new System.Drawing.Point(0, 0);
            this.VentanaPicker1.Name = "VentanaPicker1";
            this.VentanaPicker1.Size = new System.Drawing.Size(588, 29);
            this.VentanaPicker1.TabIndex = 17;
            this.VentanaPicker1.Paint += new System.Windows.Forms.PaintEventHandler(this.VentanaPicker1_Paint);
            this.VentanaPicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VentanaPicker1_MouseDown);
            this.VentanaPicker1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaPicker1_MouseMove);
            this.VentanaPicker1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VentanaPicker1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 17);
            this.panel2.TabIndex = 16;
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormName.Location = new System.Drawing.Point(29, 5);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(109, 15);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "PAWN Color Picker";
            this.FormName.Click += new System.EventHandler(this.FormName_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.MaximizeButton);
            this.ControlPanel.Controls.Add(this.CloseButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(478, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(110, 27);
            this.ControlPanel.TabIndex = 20;
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackgroundImage = global::PAWNColor.Properties.Resources.Arrow_4_16;
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Location = new System.Drawing.Point(32, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(20, 18);
            this.MaximizeButton.TabIndex = 17;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(93)))), ((int)(((byte)(77)))));
            this.CloseButton.BackgroundImage = global::PAWNColor.Properties.Resources.Delete_16;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(62, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 19);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 2);
            this.panel3.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(22, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 118);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(421, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 26);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "None ..";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(21, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "PAWN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "HEX";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 339);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(588, 19);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 15);
            this.toolStripLabel1.Text = "PAWN Color by _Zume";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 358);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VentanaPicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VentanaPicker1.ResumeLayout(false);
            this.VentanaPicker1.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel VentanaPicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

