namespace Teste_PortaSerialxServoMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txStatusSerial = new System.Windows.Forms.ToolStripStatusLabel();
            this.btConnection = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pnCursor = new System.Windows.Forms.Panel();
            this.sbCursor = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ltMessage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pnCursor.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txStatusSerial});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txStatusSerial
            // 
            this.txStatusSerial.AutoSize = false;
            this.txStatusSerial.Name = "txStatusSerial";
            this.txStatusSerial.Size = new System.Drawing.Size(180, 17);
            // 
            // btConnection
            // 
            this.btConnection.Location = new System.Drawing.Point(24, 23);
            this.btConnection.Name = "btConnection";
            this.btConnection.Size = new System.Drawing.Size(117, 23);
            this.btConnection.TabIndex = 1;
            this.btConnection.Text = "Conectar Serial";
            this.btConnection.UseVisualStyleBackColor = true;
            this.btConnection.Click += new System.EventHandler(this.btConnection_Click);
            // 
            // pnCursor
            // 
            this.pnCursor.Controls.Add(this.sbCursor);
            this.pnCursor.Controls.Add(this.label1);
            this.pnCursor.Location = new System.Drawing.Point(0, 172);
            this.pnCursor.Name = "pnCursor";
            this.pnCursor.Size = new System.Drawing.Size(470, 75);
            this.pnCursor.TabIndex = 5;
            // 
            // sbCursor
            // 
            this.sbCursor.Location = new System.Drawing.Point(42, 36);
            this.sbCursor.Maximum = 127;
            this.sbCursor.Name = "sbCursor";
            this.sbCursor.Size = new System.Drawing.Size(374, 24);
            this.sbCursor.TabIndex = 7;
            this.sbCursor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbCursor_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "0     |     |     |    45     |     |     |      90    |     |     |    135    | " +
                "    |     |    180";
            // 
            // ltMessage
            // 
            this.ltMessage.FormattingEnabled = true;
            this.ltMessage.Location = new System.Drawing.Point(489, 23);
            this.ltMessage.Name = "ltMessage";
            this.ltMessage.Size = new System.Drawing.Size(385, 290);
            this.ltMessage.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "120 graus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "10 graus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(799, 319);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 9;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 374);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ltMessage);
            this.Controls.Add(this.pnCursor);
            this.Controls.Add(this.btConnection);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Comunicação PortaSerial & ServoMotor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnCursor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txStatusSerial;
        private System.Windows.Forms.Button btConnection;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel pnCursor;
        private System.Windows.Forms.HScrollBar sbCursor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btAtualizar;
    }
}

