using System.IO;
using Microsoft.Win32;

namespace custom_panorama
{
    class GetPath
    {
        public string[] full = Directory.GetFiles(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", -1).ToString() + @"\steamapps\common\Counter-Strike Global Offensive\csgo\panorama\videos", "*.webm");
        public string panorama_path = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", -1).ToString() + @"\steamapps\common\Counter-Strike Global Offensive\csgo\panorama\videos";
    }
}
