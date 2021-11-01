
namespace Drinks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRefill = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.textInfo = new System.Windows.Forms.RichTextBox();
            this.textOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonRefill
            // 
            this.buttonRefill.Location = new System.Drawing.Point(52, 26);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(103, 23);
            this.buttonRefill.TabIndex = 0;
            this.buttonRefill.Text = "Перезаполнить";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(183, 26);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(103, 23);
            this.buttonGet.TabIndex = 1;
            this.buttonGet.Text = "Взять";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(52, 55);
            this.textInfo.Name = "textInfo";
            this.textInfo.ReadOnly = true;
            this.textInfo.Size = new System.Drawing.Size(234, 51);
            this.textInfo.TabIndex = 2;
            this.textInfo.Text = "";
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(52, 112);
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(234, 96);
            this.textOut.TabIndex = 3;
            this.textOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 233);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.buttonRefill);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомат напитков";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.RichTextBox textInfo;
        private System.Windows.Forms.RichTextBox textOut;
    }
}

