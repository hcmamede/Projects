namespace Rock_Paper_Scissors
{
    partial class frm_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.picRock_M = new System.Windows.Forms.PictureBox();
            this.picPaper_M = new System.Windows.Forms.PictureBox();
            this.picScissors_M = new System.Windows.Forms.PictureBox();
            this.txtradom = new System.Windows.Forms.TextBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.picNoCheck = new System.Windows.Forms.PictureBox();
            this.picNo = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtPlay1 = new System.Windows.Forms.TextBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblPlay1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNo)).BeginInit();
            this.SuspendLayout();
            // 
            // picRock
            // 
            this.picRock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRock.Image = ((System.Drawing.Image)(resources.GetObject("picRock.Image")));
            this.picRock.Location = new System.Drawing.Point(438, 266);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(125, 167);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.picRock_Click);
            // 
            // picPaper
            // 
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.Location = new System.Drawing.Point(239, 266);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(102, 167);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaper.TabIndex = 1;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
            // 
            // picScissors
            // 
            this.picScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picScissors.Image = ((System.Drawing.Image)(resources.GetObject("picScissors.Image")));
            this.picScissors.Location = new System.Drawing.Point(640, 266);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(102, 167);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScissors.TabIndex = 2;
            this.picScissors.TabStop = false;
            this.picScissors.Click += new System.EventHandler(this.picScissors_Click);
            // 
            // picRock_M
            // 
            this.picRock_M.Image = ((System.Drawing.Image)(resources.GetObject("picRock_M.Image")));
            this.picRock_M.Location = new System.Drawing.Point(439, -1);
            this.picRock_M.Name = "picRock_M";
            this.picRock_M.Size = new System.Drawing.Size(122, 216);
            this.picRock_M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRock_M.TabIndex = 3;
            this.picRock_M.TabStop = false;
            // 
            // picPaper_M
            // 
            this.picPaper_M.Image = ((System.Drawing.Image)(resources.GetObject("picPaper_M.Image")));
            this.picPaper_M.Location = new System.Drawing.Point(439, -1);
            this.picPaper_M.Name = "picPaper_M";
            this.picPaper_M.Size = new System.Drawing.Size(122, 214);
            this.picPaper_M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaper_M.TabIndex = 4;
            this.picPaper_M.TabStop = false;
            // 
            // picScissors_M
            // 
            this.picScissors_M.Image = ((System.Drawing.Image)(resources.GetObject("picScissors_M.Image")));
            this.picScissors_M.Location = new System.Drawing.Point(439, -1);
            this.picScissors_M.Name = "picScissors_M";
            this.picScissors_M.Size = new System.Drawing.Size(122, 216);
            this.picScissors_M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScissors_M.TabIndex = 5;
            this.picScissors_M.TabStop = false;
            this.picScissors_M.Click += new System.EventHandler(this.PicScissors_M_Click);
            // 
            // txtradom
            // 
            this.txtradom.Location = new System.Drawing.Point(22, 38);
            this.txtradom.Name = "txtradom";
            this.txtradom.Size = new System.Drawing.Size(100, 20);
            this.txtradom.TabIndex = 6;
            this.txtradom.Text = "0";
            this.txtradom.Visible = false;
            // 
            // picCheck
            // 
            this.picCheck.Image = ((System.Drawing.Image)(resources.GetObject("picCheck.Image")));
            this.picCheck.Location = new System.Drawing.Point(567, 139);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(112, 111);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck.TabIndex = 7;
            this.picCheck.TabStop = false;
            this.picCheck.Visible = false;
            // 
            // picNoCheck
            // 
            this.picNoCheck.Image = ((System.Drawing.Image)(resources.GetObject("picNoCheck.Image")));
            this.picNoCheck.Location = new System.Drawing.Point(567, 139);
            this.picNoCheck.Name = "picNoCheck";
            this.picNoCheck.Size = new System.Drawing.Size(112, 111);
            this.picNoCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNoCheck.TabIndex = 8;
            this.picNoCheck.TabStop = false;
            this.picNoCheck.Visible = false;
            // 
            // picNo
            // 
            this.picNo.Image = ((System.Drawing.Image)(resources.GetObject("picNo.Image")));
            this.picNo.Location = new System.Drawing.Point(567, 139);
            this.picNo.Name = "picNo";
            this.picNo.Size = new System.Drawing.Size(112, 111);
            this.picNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNo.TabIndex = 9;
            this.picNo.TabStop = false;
            this.picNo.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(62, 176);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 37);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "0/10";
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(128, 12);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(100, 20);
            this.txtMachine.TabIndex = 11;
            this.txtMachine.Text = "0";
            this.txtMachine.Visible = false;
            // 
            // txtPlay1
            // 
            this.txtPlay1.Location = new System.Drawing.Point(22, 12);
            this.txtPlay1.Name = "txtPlay1";
            this.txtPlay1.Size = new System.Drawing.Size(100, 20);
            this.txtPlay1.TabIndex = 12;
            this.txtPlay1.Text = "0";
            this.txtPlay1.Visible = false;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.ForeColor = System.Drawing.Color.Red;
            this.lblMachine.Location = new System.Drawing.Point(12, 61);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(0, 37);
            this.lblMachine.TabIndex = 13;
            // 
            // lblPlay1
            // 
            this.lblPlay1.AutoSize = true;
            this.lblPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay1.ForeColor = System.Drawing.Color.Red;
            this.lblPlay1.Location = new System.Drawing.Point(15, 392);
            this.lblPlay1.Name = "lblPlay1";
            this.lblPlay1.Size = new System.Drawing.Size(213, 37);
            this.lblPlay1.TabIndex = 14;
            this.lblPlay1.Text = "Choose!!>>>";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 438);
            this.Controls.Add(this.lblPlay1);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.txtPlay1);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtradom);
            this.Controls.Add(this.picScissors_M);
            this.Controls.Add(this.picPaper_M);
            this.Controls.Add(this.picRock_M);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.picNoCheck);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.picNo);
            this.Name = "frm_Main";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.PictureBox picRock_M;
        private System.Windows.Forms.PictureBox picPaper_M;
        private System.Windows.Forms.PictureBox picScissors_M;
        private System.Windows.Forms.TextBox txtradom;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.PictureBox picNoCheck;
        private System.Windows.Forms.PictureBox picNo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtPlay1;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblPlay1;
    }
}

