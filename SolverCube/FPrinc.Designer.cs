namespace SolverCube
{
    partial class FPrinc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrinc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btInit = new System.Windows.Forms.Button();
            this.btEncerrar = new System.Windows.Forms.Button();
            this.btTakePicture = new System.Windows.Forms.Button();
            this.lbx = new System.Windows.Forms.Label();
            this.lby = new System.Windows.Forms.Label();
            this.lbMouseY = new System.Windows.Forms.Label();
            this.lbMouseX = new System.Windows.Forms.Label();
            this.ucWebCam1 = new WebCamForm.UCWebCam();
            this.lbred = new System.Windows.Forms.Label();
            this.lbgreen = new System.Windows.Forms.Label();
            this.lbblue = new System.Windows.Forms.Label();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensibilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 58);
            this.panel1.TabIndex = 0;
            // 
            // btFechar
            // 
            this.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFechar.Location = new System.Drawing.Point(1149, 19);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fecharToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.abrirToolStripMenuItem.Text = "Arquivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // btInit
            // 
            this.btInit.Location = new System.Drawing.Point(676, 86);
            this.btInit.Name = "btInit";
            this.btInit.Size = new System.Drawing.Size(141, 35);
            this.btInit.TabIndex = 4;
            this.btInit.Text = "Iniciar WebCam";
            this.btInit.UseVisualStyleBackColor = true;
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // btEncerrar
            // 
            this.btEncerrar.Location = new System.Drawing.Point(676, 138);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(141, 35);
            this.btEncerrar.TabIndex = 6;
            this.btEncerrar.Text = "Encerrar WebCam";
            this.btEncerrar.UseVisualStyleBackColor = true;
            this.btEncerrar.Click += new System.EventHandler(this.btEncerrar_Click);
            // 
            // btTakePicture
            // 
            this.btTakePicture.Location = new System.Drawing.Point(676, 241);
            this.btTakePicture.Name = "btTakePicture";
            this.btTakePicture.Size = new System.Drawing.Size(141, 35);
            this.btTakePicture.TabIndex = 8;
            this.btTakePicture.Text = "Tirar foto";
            this.btTakePicture.UseVisualStyleBackColor = true;
            this.btTakePicture.Click += new System.EventHandler(this.btTakePicture_Click);
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Location = new System.Drawing.Point(673, 494);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(17, 13);
            this.lbx.TabIndex = 10;
            this.lbx.Text = "X:";
            // 
            // lby
            // 
            this.lby.AutoSize = true;
            this.lby.Location = new System.Drawing.Point(673, 518);
            this.lby.Name = "lby";
            this.lby.Size = new System.Drawing.Size(17, 13);
            this.lby.TabIndex = 11;
            this.lby.Text = "Y:";
            // 
            // lbMouseY
            // 
            this.lbMouseY.AutoSize = true;
            this.lbMouseY.Location = new System.Drawing.Point(673, 449);
            this.lbMouseY.Name = "lbMouseY";
            this.lbMouseY.Size = new System.Drawing.Size(17, 13);
            this.lbMouseY.TabIndex = 13;
            this.lbMouseY.Text = "Y:";
            // 
            // lbMouseX
            // 
            this.lbMouseX.AutoSize = true;
            this.lbMouseX.Location = new System.Drawing.Point(673, 425);
            this.lbMouseX.Name = "lbMouseX";
            this.lbMouseX.Size = new System.Drawing.Size(17, 13);
            this.lbMouseX.TabIndex = 12;
            this.lbMouseX.Text = "X:";
            // 
            // ucWebCam1
            // 
            this.ucWebCam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucWebCam1.Location = new System.Drawing.Point(60, 40);
            this.ucWebCam1.Name = "ucWebCam1";
            this.ucWebCam1.Size = new System.Drawing.Size(500, 400);
            this.ucWebCam1.TabIndex = 7;
            // 
            // lbred
            // 
            this.lbred.AutoSize = true;
            this.lbred.Location = new System.Drawing.Point(800, 494);
            this.lbred.Name = "lbred";
            this.lbred.Size = new System.Drawing.Size(18, 13);
            this.lbred.TabIndex = 14;
            this.lbred.Text = "R:";
            // 
            // lbgreen
            // 
            this.lbgreen.AutoSize = true;
            this.lbgreen.Location = new System.Drawing.Point(800, 518);
            this.lbgreen.Name = "lbgreen";
            this.lbgreen.Size = new System.Drawing.Size(18, 13);
            this.lbgreen.TabIndex = 15;
            this.lbgreen.Text = "G:";
            // 
            // lbblue
            // 
            this.lbblue.AutoSize = true;
            this.lbblue.Location = new System.Drawing.Point(800, 543);
            this.lbblue.Name = "lbblue";
            this.lbblue.Size = new System.Drawing.Size(17, 13);
            this.lbblue.TabIndex = 16;
            this.lbblue.Text = "B:";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensibilitiesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // sensibilitiesToolStripMenuItem
            // 
            this.sensibilitiesToolStripMenuItem.Name = "sensibilitiesToolStripMenuItem";
            this.sensibilitiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sensibilitiesToolStripMenuItem.Text = "Sensibilities";
            this.sensibilitiesToolStripMenuItem.Click += new System.EventHandler(this.sensibilitiesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(676, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btFechar;
            this.ClientSize = new System.Drawing.Size(1284, 750);
            this.Controls.Add(this.lbblue);
            this.Controls.Add(this.lbgreen);
            this.Controls.Add(this.lbred);
            this.Controls.Add(this.lbMouseY);
            this.Controls.Add(this.lbMouseX);
            this.Controls.Add(this.lby);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btTakePicture);
            this.Controls.Add(this.ucWebCam1);
            this.Controls.Add(this.btEncerrar);
            this.Controls.Add(this.btInit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPrinc";
            this.Text = "SolverCube - Simulator";
            this.Load += new System.EventHandler(this.FPrinc_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FPrinc_MouseMove);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Button btInit;
        private System.Windows.Forms.Button btEncerrar;
        private WebCamForm.UCWebCam ucWebCam1;
        private System.Windows.Forms.Button btTakePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lby;
        private System.Windows.Forms.Label lbMouseY;
        private System.Windows.Forms.Label lbMouseX;
        private System.Windows.Forms.Label lbred;
        private System.Windows.Forms.Label lbgreen;
        private System.Windows.Forms.Label lbblue;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensibilitiesToolStripMenuItem;
    }
}

