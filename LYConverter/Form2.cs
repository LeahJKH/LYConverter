using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LYConverter
{
    public partial class Converter : Form
    {

        public Converter()
        {
            InitializeComponent();
        }



        private void fileAdder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower().TrimStart('.'); 

                    switch (extension)
                    {
                        case "txt":
                            RichTextBox richTextBox = new RichTextBox
                            {
                                Multiline = true,
                                ReadOnly = true,
                                Dock = DockStyle.Fill,
                                Text = File.ReadAllText(filePath),
                                Font = new Font("Consolas", 10)
                            };
                            this.Controls.Add(richTextBox);
                            break;
                        case "html":
                            MessageBox.Show("HTML file selected.");
                            break;
                        case "jpeg":
                            MessageBox.Show("Jpeg file selected.");
                            break;
                        case "png":
                            MessageBox.Show("Png file selected.");
                            break;
                        case "gif":
                            MessageBox.Show("Gif file selected.");
                            break;
                        case "pdf":
                            MessageBox.Show("PDF file selected.");
                            break;
                        case "docx":
                            MessageBox.Show("Word document selected.");
                            break;
                        default:
                            MessageBox.Show("Unsupported or unknown file type: " + extension);
                            break;
                    }
                }
            }
        }
    }
}
