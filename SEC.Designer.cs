namespace SEC
{
    partial class SEC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEC));
            this.txtUs = new System.Windows.Forms.TextBox();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.lblNm = new System.Windows.Forms.Label();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEm = new System.Windows.Forms.Label();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTm = new System.Windows.Forms.Label();
            this.tmR = new System.Windows.Forms.Timer(this.components);
            this.lblTt = new System.Windows.Forms.Label();
            this.picLg = new System.Windows.Forms.PictureBox();
            this.pnInf = new System.Windows.Forms.Panel();
            this.pnTt = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLg)).BeginInit();
            this.pnInf.SuspendLayout();
            this.pnTt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUs
            // 
            this.txtUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUs.Location = new System.Drawing.Point(79, 0);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(166, 20);
            this.txtUs.TabIndex = 1;
            this.txtUs.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Location = new System.Drawing.Point(-3, 0);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(46, 13);
            this.lblUs.TabIndex = 2;
            this.lblUs.Text = "Usuário:";
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Location = new System.Drawing.Point(-3, 26);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(41, 13);
            this.lblSn.TabIndex = 3;
            this.lblSn.Text = "Senha:";
            // 
            // txtSn
            // 
            this.txtSn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSn.Location = new System.Drawing.Point(79, 26);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(166, 20);
            this.txtSn.TabIndex = 2;
            this.txtSn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // lblNm
            // 
            this.lblNm.AutoSize = true;
            this.lblNm.Location = new System.Drawing.Point(-3, 52);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(38, 13);
            this.lblNm.TabIndex = 5;
            this.lblNm.Text = "Nome:";
            // 
            // txtNm
            // 
            this.txtNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNm.Location = new System.Drawing.Point(79, 52);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(166, 20);
            this.txtNm.TabIndex = 3;
            this.txtNm.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(-3, 78);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "Endereço:";
            // 
            // txtEnd
            // 
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.Location = new System.Drawing.Point(79, 78);
            this.txtEnd.Multiline = true;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(166, 51);
            this.txtEnd.TabIndex = 4;
            this.txtEnd.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // lblEm
            // 
            this.lblEm.AutoSize = true;
            this.lblEm.Location = new System.Drawing.Point(-3, 134);
            this.lblEm.Name = "lblEm";
            this.lblEm.Size = new System.Drawing.Size(38, 13);
            this.lblEm.TabIndex = 9;
            this.lblEm.Text = "E-mail:";
            // 
            // txtEm
            // 
            this.txtEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEm.Location = new System.Drawing.Point(79, 135);
            this.txtEm.Name = "txtEm";
            this.txtEm.Size = new System.Drawing.Size(166, 20);
            this.txtEm.TabIndex = 5;
            this.txtEm.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // cmdOk
            // 
            this.cmdOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOk.Location = new System.Drawing.Point(180, 224);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(65, 23);
            this.cmdOk.TabIndex = 7;
            this.cmdOk.Text = "&OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(79, 161);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(166, 20);
            this.txtTel.TabIndex = 6;
            this.txtTel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(-3, 160);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefone:";
            // 
            // lblTm
            // 
            this.lblTm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTm.Location = new System.Drawing.Point(3, 214);
            this.lblTm.Name = "lblTm";
            this.lblTm.Size = new System.Drawing.Size(171, 33);
            this.lblTm.TabIndex = 15;
            this.lblTm.Text = "Tempo restante . . .";
            // 
            // tmR
            // 
            this.tmR.Enabled = true;
            this.tmR.Interval = 1000;
            this.tmR.Tick += new System.EventHandler(this.tmR_Tick);
            // 
            // lblTt
            // 
            this.lblTt.AutoSize = true;
            this.lblTt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTt.Location = new System.Drawing.Point(69, 9);
            this.lblTt.Name = "lblTt";
            this.lblTt.Size = new System.Drawing.Size(585, 73);
            this.lblTt.TabIndex = 16;
            this.lblTt.Text = "SAK Security Login";
            // 
            // picLg
            // 
            this.picLg.Image = ((System.Drawing.Image)(resources.GetObject("picLg.Image")));
            this.picLg.Location = new System.Drawing.Point(7, 9);
            this.picLg.Name = "picLg";
            this.picLg.Size = new System.Drawing.Size(79, 73);
            this.picLg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLg.TabIndex = 17;
            this.picLg.TabStop = false;
            // 
            // pnInf
            // 
            this.pnInf.Controls.Add(this.txtUs);
            this.pnInf.Controls.Add(this.lblUs);
            this.pnInf.Controls.Add(this.lblSn);
            this.pnInf.Controls.Add(this.lblTm);
            this.pnInf.Controls.Add(this.txtSn);
            this.pnInf.Controls.Add(this.txtTel);
            this.pnInf.Controls.Add(this.lblNm);
            this.pnInf.Controls.Add(this.lblTel);
            this.pnInf.Controls.Add(this.txtNm);
            this.pnInf.Controls.Add(this.cmdOk);
            this.pnInf.Controls.Add(this.lblEnd);
            this.pnInf.Controls.Add(this.txtEm);
            this.pnInf.Controls.Add(this.txtEnd);
            this.pnInf.Controls.Add(this.lblEm);
            this.pnInf.Location = new System.Drawing.Point(199, 98);
            this.pnInf.Name = "pnInf";
            this.pnInf.Size = new System.Drawing.Size(250, 255);
            this.pnInf.TabIndex = 18;
            // 
            // pnTt
            // 
            this.pnTt.Controls.Add(this.picLg);
            this.pnTt.Controls.Add(this.lblTt);
            this.pnTt.Location = new System.Drawing.Point(12, 7);
            this.pnTt.Name = "pnTt";
            this.pnTt.Size = new System.Drawing.Size(648, 85);
            this.pnTt.TabIndex = 19;
            // 
            // SEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(672, 372);
            this.Controls.Add(this.pnTt);
            this.Controls.Add(this.pnInf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SEC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Segurança";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SEC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLg)).EndInit();
            this.pnInf.ResumeLayout(false);
            this.pnInf.PerformLayout();
            this.pnTt.ResumeLayout(false);
            this.pnTt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEm;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblTm;
        private System.Windows.Forms.Timer tmR;
        private System.Windows.Forms.Label lblTt;
        private System.Windows.Forms.PictureBox picLg;
        private System.Windows.Forms.Panel pnInf;
        private System.Windows.Forms.Panel pnTt;
    }
}

