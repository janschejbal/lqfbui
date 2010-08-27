using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using LQFBUI.Data.List;
using System.Runtime.Serialization;

namespace LQFBUI.Data
{
    public class Storage
    {
        public static string profileName { get; private set; }
        public static string profilePath { get; private set; }

        private static APILoginData apidata;
        private static ContentData content;

        public static UlongMap<ExtArea> areas
        {
            get { return content.areas; }
        }

        public static UlongMap<ExtTopic> topics
        {
            get { return content.topics; }
        }

        public static UlongMap<ExtInitiative> initiatives
        {
            get { return content.initiatives; }
        }


        [DataContract]
        public class ContentData
        {
            [DataMember] public readonly UlongMap<ExtArea> areas = new UlongMap<ExtArea>();
            [DataMember] public readonly UlongMap<ExtTopic> topics = new UlongMap<ExtTopic>();
            [DataMember] public readonly UlongMap<ExtInitiative> initiatives = new UlongMap<ExtInitiative>();
        }



        private static DataContractSerializer ser = new DataContractSerializer(
                typeof(ContentData),
                /*new Type[]
                {
                    typeof(ExtArea), typeof(ExtTopic), typeof(ExtInitiative),
                    typeof(ulong), typeof(string), 
                },*/
                null,
                System.Int32.MaxValue,
                false,
                true,
                null
            );

        public static void init(String profileName)
        {
            if (Storage.profileName != null) throw new Exception("tried to initialize Storage multiple times");
            Storage.profileName = profileName;
            profilePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "LQFBUI",
                    profileName
                );
            Directory.CreateDirectory(profilePath);

            if (File.Exists(Path.Combine(profilePath, "apidata.xml")))
            {
                XmlSerializer ser = new XmlSerializer(typeof(APILoginData));
                StreamReader source = new StreamReader(Path.Combine(profilePath, "apidata.xml"));
                apidata = (APILoginData)ser.Deserialize(source);
                source.Close();
            }
            else
            {
                apidata = new APILoginData();
                apidata.url = "https://lqfb.piratenpartei.de/pp/api/";
                apidata.key = "";
            }


            try 
            {  // if file does not exist, fine, throw an exception, thats what the catch block is for.
                FileStream source = new FileStream(Path.Combine(profilePath, "contentdata.xml"), FileMode.Open);
                try
                {
                    content = (ContentData)ser.ReadObject(source);
                }
                finally
                {
                    source.Close();
                }
            }
            catch
            {
                if (File.Exists(Path.Combine(profilePath, "contentdata.xml")))
                {
                    string timestamp = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HHmmssff");
                    File.Move(Path.Combine(profilePath, "contentdata.xml"),
                        Path.Combine(profilePath, "contentdata-" + timestamp + ".broken.xml"));
                }
                content = new ContentData();
            }


        }


        public static void saveContent()
        {
            if (File.Exists(Path.Combine(profilePath, "contentdata.xml")))
            {
                string timestamp = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HHmmssff");
                try {
                    File.Move(Path.Combine(profilePath, "contentdata.xml"),
                        Path.Combine(profilePath, "contentdata-"+timestamp+".bak.xml"));
                } catch ( Exception e ) {
                    Debug.Write("Could not move old contentdata.xml - " + e.ToString());
                }
            }
            FileStream target = new FileStream(Path.Combine(profilePath, "contentdata.xml"), FileMode.Create);
            ser.WriteObject(target, content);
            target.Close();
        }

        public static string apiurl
        {
            get { return apidata.url; }
            set { apidata.url = value; storeApidata(); }
        }

        public static string apikey
        {
            get { return apidata.key; }
            set { apidata.key = value; storeApidata(); }
        }

        private static void storeApidata()
        {
            StreamWriter target = new StreamWriter(Path.Combine(profilePath, "apidata.xml"));
            new XmlSerializer(typeof(APILoginData)).Serialize(target, apidata);
            target.Close();
        }

        public class APILoginData
        {
            public string url;
            public string key;
        }
    }
}
