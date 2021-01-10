using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace proji
{
    public partial class Form1 : Form
    {
        public delegate void UpdateControlsDelegate();
        public Form1()
        {
            InitializeComponent();
            this.vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.bunifuProgressBar1_progressChanged);
            vlcControl1.BringToFront();
            comboBox1.Visible = false;
           
        }
        public int a = 0;
        public int c = 0;
        public int y;
        public int m;
        string[] paths, files;
        bool psd;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(vlcControl1.GetCurrentMedia());
            bunifuTrackbar1.Value = 50;
            vlcControl1.Audio.Volume = bunifuTrackbar1.Value;
            label1.Text = bunifuTrackbar1.Value.ToString();
            methodL();
                if (psd)
                {
                    if (vlcControl1.IsPlaying)
                    {
                        vlcControl1.Play(new Uri(Convert.ToString(comboBox1.SelectedItem)));
                  
                    }
                    else
                    {
                        vlcControl1.Play();

                    }

                }
                else
                {
                    string test = Convert.ToString(comboBox1.SelectedItem);
                    vlcControl1.Play(new Uri(test));
                    timer1.Start();
                  
            }


        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {

            }
        }

        public void methodL()
        {
            long x = vlcControl1.Length / 1000;
            string q = Convert.ToString(TimeSpan.FromSeconds(x));
            label3.Text = q;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Process.Start(System.IO.Directory.GetCurrentDirectory() + "  /../../../YoutubeDownloder/downloader/bin/Debug/downloader.exe");
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            psd = true;
            vlcControl1.SetPause(psd);
          

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                files = opf.SafeFileNames;
                paths = opf.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    comboBox1.Items.Insert(x, opf.FileName);
                    listBox2.Items.Insert(0, files[x]);
                    listBox2.SelectedIndex = x;
                    listBox2.SelectedItem = listBox2.SelectedIndex;
                    

                }

            }
            if (comboBox1.SelectedItem == null)
            {
                int z = 0;
                comboBox1.SelectedIndex = z;
                comboBox1.SelectedItem = comboBox1.SelectedIndex;
            }
            else
            {

                int z = 0;
                comboBox1.SelectedIndex = z;
                comboBox1.SelectedItem = comboBox1.SelectedIndex;
            }
        }


        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
          
        }


        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            int h = listBox2.SelectedIndex;
            int z = comboBox1.SelectedIndex;
            
 
            if (listBox2.SelectedItem == null)
            {
                m = h - 1;
                listBox2.SelectedIndex = m;
            }
            else if (m == Convert.ToInt32(listBox2.Items.Count))
            {
                listBox2.SelectedIndex = 0;
            }
            else
            {
                listBox2.SelectedIndex = m;
            }
            if (comboBox1.SelectedItem == null)
            {
                y = z - 1;
                comboBox1.SelectedIndex = y;
                comboBox1.SelectedItem = comboBox1.SelectedIndex;
            }
            else if (y == Convert.ToInt32(comboBox1.Items.Count))
            {

                comboBox1.SelectedIndex = 0;

            }
            else
            {
                
                comboBox1.SelectedIndex = y;
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuImageButton9_Click_1(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
            ? FormWindowState.Normal
            : FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start(System.IO.Directory.GetCurrentDirectory() + "  /../../../YoutubeDownloder/downloader/bin/Debug/downloader.exe");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel8.BringToFront();
            panel8.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            vlcControl1.BringToFront();
            panel8.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            int j = listBox2.SelectedIndex;
            int k = j + 1; 
            int z = comboBox1.SelectedIndex;
            int y = z + 1;
            if (y == Convert.ToInt32(comboBox1.Items.Count))
            {
                y = 0;
                comboBox1.SelectedIndex = y;
                k = 0;
                listBox2.SelectedIndex = k;
            }
            else
            {
                comboBox1.SelectedIndex = y;
                listBox2.SelectedIndex = k;
            }
            
        }

        private void panelLIST_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel8.BringToFront();
            panel8.Visible = true;
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            vlcControl1.BringToFront();
            panel8.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:-\nHussein Mohamed Hussein Mohamed sec4 \nMohamed Ahmed Ibrahim Abdel-Salam sec6 \nMostafa Essam Abdullah Ahmed sec7\nAhmed Mohamed Yassin Ahmed sec8\nEslam Ahmed Sayed Labeb sec4", "Shrouk Media Player");
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panelPLAYER_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuImageButton7_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        

        private void bunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = bunifuTrackbar1.Value;
            label1.Text = bunifuTrackbar1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bunifuTrackbar1.Value = int.Parse(bunifuTrackbar1.Text);

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
                long x = vlcControl1.Length/1000;



        }

    /*    private void bunifuTrackbar2_ValueChanged(object sender, EventArgs e)
        {
            vlcControl1.VlcMediaPlayer.Time = bunifuTrackbar2.Value * 1000;
            int b = (int)vlcControl1.VlcMediaPlayer.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
            label4.Text = d + ":" + b + "/" + c + ":" + a;
            bunifuTrackbar2.Value = b;
        }*/

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
             
                
            


           



          

         
        }

        private void bunifuTrackbar2_ValueChanged(object sender, EventArgs e)
        {
            vlcControl1.VlcMediaPlayer.Time = bunifuTrackbar2.Value * 1000;
            int b = (int)vlcControl1.VlcMediaPlayer.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
            label4.Text = d + ":" + b;
            bunifuTrackbar2.Value = b;
            methodL();
            bunifuTrackbar2.Value = b - timer1.Interval;

        }

        private void label3_Click(object sender, EventArgs e)
        {
 
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        
    }
}
