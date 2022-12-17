using System;
using System.Collections;
using System.IO;

namespace custom_panorama
{
    class GetPath
    {
        public string[] full = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\panorama\videos", "*.webm");
        public string panorama_path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\panorama\videos";
    }
}
