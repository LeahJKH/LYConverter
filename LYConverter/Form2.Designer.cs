namespace LYConverter
{
    partial class Converter
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
            this.fileAdder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileAdder
            // 
            this.fileAdder.Location = new System.Drawing.Point(80, 425);
            this.fileAdder.Name = "fileAdder";
            this.fileAdder.Size = new System.Drawing.Size(75, 23);
            this.fileAdder.TabIndex = 0;
            this.fileAdder.Text = "fileAdder";
            this.fileAdder.UseVisualStyleBackColor = true;
            this.fileAdder.Click += new System.EventHandler(this.fileAdder_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.fileAdder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileAdder;
    }
}