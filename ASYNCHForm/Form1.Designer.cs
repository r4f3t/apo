namespace ASYNCHForm
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
            this.BTNNormal = new System.Windows.Forms.Button();
            this.LBNormal = new System.Windows.Forms.ListBox();
            this.BTNAsenkron = new System.Windows.Forms.Button();
            this.LBAsynchronous = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTNNormal
            // 
            this.BTNNormal.Location = new System.Drawing.Point(15, 6);
            this.BTNNormal.Name = "BTNNormal";
            this.BTNNormal.Size = new System.Drawing.Size(137, 35);
            this.BTNNormal.TabIndex = 0;
            this.BTNNormal.Text = "Normal Ekle";
            this.BTNNormal.UseVisualStyleBackColor = true;
            this.BTNNormal.Click += new System.EventHandler(this.BTNNormal_Click);
            // 
            // LBNormal
            // 
            this.LBNormal.FormattingEnabled = true;
            this.LBNormal.ItemHeight = 16;
            this.LBNormal.Location = new System.Drawing.Point(15, 55);
            this.LBNormal.Name = "LBNormal";
            this.LBNormal.Size = new System.Drawing.Size(307, 356);
            this.LBNormal.TabIndex = 1;
            // 
            // BTNAsenkron
            // 
            this.BTNAsenkron.Location = new System.Drawing.Point(481, 6);
            this.BTNAsenkron.Name = "BTNAsenkron";
            this.BTNAsenkron.Size = new System.Drawing.Size(137, 35);
            this.BTNAsenkron.TabIndex = 0;
            this.BTNAsenkron.Text = "Asenkron";
            this.BTNAsenkron.UseVisualStyleBackColor = true;
            this.BTNAsenkron.Click += new System.EventHandler(this.BTNAsenkron_Click);
            // 
            // LBAsynchronous
            // 
            this.LBAsynchronous.FormattingEnabled = true;
            this.LBAsynchronous.ItemHeight = 16;
            this.LBAsynchronous.Location = new System.Drawing.Point(481, 55);
            this.LBAsynchronous.Name = "LBAsynchronous";
            this.LBAsynchronous.Size = new System.Drawing.Size(307, 356);
            this.LBAsynchronous.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBAsynchronous);
            this.Controls.Add(this.BTNAsenkron);
            this.Controls.Add(this.LBNormal);
            this.Controls.Add(this.BTNNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNNormal;
        private System.Windows.Forms.ListBox LBNormal;
        private System.Windows.Forms.Button BTNAsenkron;
        private System.Windows.Forms.ListBox LBAsynchronous;
    }
}

