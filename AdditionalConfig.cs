using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Doom64_Unofficial_Configuration_Tool
{
    [Serializable]
    public class AdditionalConfig
    {
        [XmlElement]
        public bool ShownedLegal { get; set; }
        [XmlElement]
        public string LastUsedCMD { get; set; }

        public AdditionalConfig()
        {
            ShownedLegal = false;
            LastUsedCMD = "";
        }

        public static AdditionalConfig Load(string path)
        {
            if(File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AdditionalConfig));
                FileStream fs = new FileStream(path, FileMode.Open);
                AdditionalConfig obj = (AdditionalConfig)serializer.Deserialize(fs);
                return obj;
            }
            return new AdditionalConfig();
        }

        internal void Save(string path)
        {
            string DirectoryPath = Directory.GetDirectoryRoot(path);
            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);

            XmlSerializer serializer = new XmlSerializer(typeof(AdditionalConfig));
            StreamWriter fw = new StreamWriter(path);
            serializer.Serialize(fw, this);
            fw.Close();
        }
    }
}
