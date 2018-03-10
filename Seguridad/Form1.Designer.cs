namespace Seguridad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.receiveTextBox = new System.Windows.Forms.TextBox();
            this.connectIPTextBox = new System.Windows.Forms.TextBox();
            this.connectPortTextBox = new System.Windows.Forms.TextBox();
            this.serverIPTextBox = new System.Windows.Forms.TextBox();
            this.serverPortTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(12, 295);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(394, 37);
            this.sendTextBox.TabIndex = 1;
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(13, 187);
            this.receiveTextBox.Multiline = true;
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.Size = new System.Drawing.Size(491, 102);
            this.receiveTextBox.TabIndex = 2;
            // 
            // connectIPTextBox
            // 
            this.connectIPTextBox.Location = new System.Drawing.Point(108, 128);
            this.connectIPTextBox.Name = "connectIPTextBox";
            this.connectIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.connectIPTextBox.TabIndex = 3;
            // 
            // connectPortTextBox
            // 
            this.connectPortTextBox.Location = new System.Drawing.Point(306, 128);
            this.connectPortTextBox.Name = "connectPortTextBox";
            this.connectPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.connectPortTextBox.TabIndex = 4;
            // 
            // serverIPTextBox
            // 
            this.serverIPTextBox.Location = new System.Drawing.Point(108, 46);
            this.serverIPTextBox.Name = "serverIPTextBox";
            this.serverIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.serverIPTextBox.TabIndex = 5;
            // 
            // serverPortTextBox
            // 
            this.serverPortTextBox.Location = new System.Drawing.Point(306, 46);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.serverPortTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(492, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start Server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(491, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Client";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.serverPortTextBox);
            this.Controls.Add(this.serverIPTextBox);
            this.Controls.Add(this.connectPortTextBox);
            this.Controls.Add(this.connectIPTextBox);
            this.Controls.Add(this.receiveTextBox);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.TextBox receiveTextBox;
        private System.Windows.Forms.TextBox connectIPTextBox;
        private System.Windows.Forms.TextBox connectPortTextBox;
        private System.Windows.Forms.TextBox serverIPTextBox;
        private System.Windows.Forms.TextBox serverPortTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

