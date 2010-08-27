using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LQFBUI.API
{
    class LQFBAPI
    {
        private string apiurl;
        private string apikey;
        private Boolean hasData = false;
        private List<Area> areas = new List<Area>();
        private List<Initiative> initiatives = new List<Initiative>();

        public LQFBAPI(string apiurl, string apikey)
        {
            this.apiurl = apiurl; 
            this.apikey = apikey;
        }

        public void update()
        {
            updateAreas();
            updateInitiatives();
            hasData = true;
        }

        public void updateAreas() {
            areas.Clear();
            XmlReader reader = XmlReader.Create(apiurl + "area.html?key=" + apikey);
            XmlSerializer serializer = new XmlSerializer(typeof(area_list));
            area_list tmplist = (area_list)serializer.Deserialize(reader);
            areas.AddRange(tmplist.area);
        }

        public void updateInitiatives() {
            initiatives.Clear();
            XmlReader reader = XmlReader.Create(apiurl + "initiative.html?key=" + apikey);
            XmlSerializer serializer = new XmlSerializer(typeof(initiative_list));
            initiative_list tmplist = (initiative_list)serializer.Deserialize(reader);
            initiatives.AddRange(tmplist.initiative);
        }

        public List<Area> getAreas()
        {
            if (!hasData) update();
            return areas;
        }

        public List<Initiative> getInitiatives()
        {
            if (!hasData) update();
            return initiatives;
        }
    }

}
