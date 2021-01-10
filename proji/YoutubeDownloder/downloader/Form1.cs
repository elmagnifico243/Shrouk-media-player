using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using System.IO;


namespace downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean type = true;


        private async void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog saving_file = new FolderBrowserDialog() { Description = "choose where to save" })
            {

                if (saving_file.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Download started", "loading .. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var yt = YouTube.Default;
                    var video = await yt.GetVideoAsync(link.Text);
                    File.WriteAllBytes(saving_file.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());
                    var infile = new MediaToolkit.Model.MediaFile { Filename = saving_file.SelectedPath + @"\" + video.FullName };
                    var outfile = new MediaToolkit.Model.MediaFile { Filename = $"{saving_file.SelectedPath + @"\" + video.FullName }.mp3" };

                    using (var enging = new Engine()) {

                        enging.GetMetadata(infile);
                        enging.Convert(infile, outfile);
                    }

                    if (type == true)
                    {
                        File.Delete(saving_file.SelectedPath + @"\" + video.FullName);
                    }
                    else {
                        File.Delete($"{saving_file.SelectedPath + @"\" + video.FullName}.mp3");
                    }
                    progressBar1.Value = 100;
                    MessageBox.Show("Download Finished" , "information" , MessageBoxButtons.OK  , MessageBoxIcon.Information);


                }

                else
                {
                    MessageBox.Show("Please select location" , "Error found" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            

            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = true; 

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
