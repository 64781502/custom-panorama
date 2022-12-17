using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace custom_panorama
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CheckForFfmpeg()
        {
            bool e = false;

            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C ffmpeg -h",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var process = new Process
            {
                StartInfo = startInfo
            };

            process.Start();

            if (process.StandardOutput.ReadToEnd() == "")
            {
                e = true;
            }

            process.WaitForExit();

            if (e)
            {
                MessageBox.Show("Ffmpeg not installed / found!", "CS:GO Custom Panorama", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetPath paths = new GetPath();
            CheckForFfmpeg();

            if (Directory.Exists(paths.panorama_path))
            {
                MessageBox.Show("true");
            }

            foreach (string i in paths.full)
            {
                PathBox.Items.Add(i.Split('\\')[i.Split('\\').Length - 1].Remove(i.Split('\\')[i.Split('\\').Length - 1].Length - 5));
            }
        }

        public void GenerateThumbnail(string path)
        {
            string pathed = '"' + path + '"';
            string shorted = path.Split('\\')[path.Split('\\').Length - 1].Remove(path.Split('\\')[path.Split('\\').Length - 1].Length - 5) + ".png";
            string path_temp = '"' + Path.GetTempPath() + "pano_cache_" + shorted + '"';
            string cmd = "ffmpeg -itsoffset -1 -i " + pathed + " -vcodec mjpeg -vframes 1 -an -f rawvideo -s 320x180 " + path_temp;

            if (!File.Exists(Path.GetTempPath() + "pano_cache_" + shorted))
            {
                var startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C " + cmd
                };

                var process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();
                process.WaitForExit();
            }

            ThumbBox.Image = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(Path.GetTempPath() + "pano_cache_" + shorted)));
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog IMG = new OpenFileDialog
            {
                Filter = "Images (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png",
                FilterIndex = 0,
                RestoreDirectory = true
            };

            if (IMG.ShowDialog() == DialogResult.OK)
            {
                string p = '"' + IMG.FileName + '"';
                string temp = '"' + Path.GetTempPath() + "pano_cache_" + IMG.ToString().Split('\\')[IMG.ToString().Split('\\').Length - 1] + '"';
                string cmd = "ffmpeg -i " + p + " -vf scale=320:180 " + temp;

                if (!File.Exists(Path.GetTempPath() + "pano_cache_" + IMG.ToString().Split('\\')[IMG.ToString().Split('\\').Length - 1]))
                {
                    var startInfo = new ProcessStartInfo
                    {
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = "cmd.exe",
                        Arguments = "/C " + cmd
                    };

                    var process = new Process
                    {
                        StartInfo = startInfo
                    };

                    process.Start();
                    process.WaitForExit();
                }

                OutputImgBox.Image = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(Path.GetTempPath() + "pano_cache_" + IMG.ToString().Split('\\')[IMG.ToString().Split('\\').Length - 1])));
                ToPanorama.Text = IMG.FileName.ToString();
                OpenFileButton.Text = "Picked";
            }
        }

        private void PathBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPath paths = new GetPath();

            FromPanorama.Text = paths.full[PathBox.SelectedIndex];
            GenerateThumbnail(paths.full[PathBox.SelectedIndex]);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            MainFfmpeg ff = new MainFfmpeg();

            this.Text = "CS:GO Custom Panorama | Converting...";
            ff.FfmpegConvert(FromPanorama.Text, ToPanorama.Text);
            this.Text = "CS:GO Custom Panorama";
        }

        private void ClearCacheButton_Click(object sender, EventArgs e)
        {
            foreach (string f in Directory.GetFiles(Path.GetTempPath(), @"*pano_cache_*"))
            {
                File.Delete(f);
            }
        }

        private Point lastPoint;

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
    }
}
