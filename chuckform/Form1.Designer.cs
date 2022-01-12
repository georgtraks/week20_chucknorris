namespace chuckform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getjokebtn = new System.Windows.Forms.Button();
            this.jokebox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getjokebtn
            // 
            this.getjokebtn.Location = new System.Drawing.Point(12, 2);
            this.getjokebtn.Name = "getjokebtn";
            this.getjokebtn.Size = new System.Drawing.Size(75, 23);
            this.getjokebtn.TabIndex = 0;
            this.getjokebtn.Text = "get joke";
            this.getjokebtn.UseVisualStyleBackColor = true;
            this.getjokebtn.Click += new System.EventHandler(this.getjokebtn_Click);
            // 
            // jokebox
            // 
            this.jokebox.Location = new System.Drawing.Point(13, 51);
            this.jokebox.Name = "jokebox";
            this.jokebox.Size = new System.Drawing.Size(168, 128);
            this.jokebox.TabIndex = 1;
            this.jokebox.Text = "get a joke, i dare you!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 414);
            this.Controls.Add(this.jokebox);
            this.Controls.Add(this.getjokebtn);
            this.Name = "Form1";
            this.Text = "Formchuck norris jokes generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getjokebtn;
        private System.Windows.Forms.RichTextBox jokebox;
    }
}

