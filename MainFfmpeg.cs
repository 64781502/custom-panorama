using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace custom_panorama
{
    class MainFfmpeg
    {
        public void FfmpegConvert(string csgo_original_path, string new_path)
        {
            if (csgo_original_path == "")
            {
                MessageBox.Show("Missing panorama image", "CS:GO Custom Panorama", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (new_path == "")
            {
                MessageBox.Show("Missing output image", "CS:GO Custom Panorama", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string input = '"' + new_path + '"';
                string output = '"' + csgo_original_path + '"';
                string cmd = "ffmpeg -y -loop 1 -i " + input + " -c:v libvpx-vp9 -lossless 1 -pix_fmt yuv420p -t 5 -r 30 -vf scale=1920:1080 " + output;

                File.Delete(csgo_original_path);

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

                MessageBox.Show("Converted!", "CS:GO Custom Panorama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
