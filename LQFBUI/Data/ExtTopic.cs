using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQFBUI.Data.List;
using System.Runtime.Serialization;

namespace LQFBUI.Data
{
    [DataContract]
    public class ExtTopic : IObjectWithID<ulong>
    {

        [DataMember] public readonly ulong id;
        public ulong ID { get { return id; } } // for IObjectWithID
        [DataMember] public readonly ExtArea parent;

        [DataMember] public readonly UlongMap<ExtInitiative> initiatives = new UlongMap<ExtInitiative>();

        [DataMember] public readonly Remote<bool> member = new Remote<bool>();
        [DataMember] public readonly Remote<bool> autoreject = new Remote<bool>();
        [DataMember] public readonly Remote<bool> votelater = new Remote<bool>();

        [DataMember] public string name; // topic has no server-side name!
        [DataMember] public bool open;
        [DataMember] public bool ignored;

        /// <summary>
        ///     DO NOT USE. Only for XML serialization!
        /// </summary>
        // public ExtTopic() { } // only for XML serialization


        private ExtTopic(ExtArea parent, ulong id)
        {
            this.id = id;
            this.name = "(" + id + ")";
            this.parent = parent;
            parent.addTopic(this);
            Storage.topics.Add(this);
        }

        // TODO API: Add some way to update once topic info exists (own selections like member, autoreject etc.)

        public static void addInitiative(ExtInitiative ini)
        {
            ExtArea targetarea = Storage.areas.get(ini.initiative.area_id);
            if (targetarea == null) throw new Exception("Attempted to add initiative without corresponding area");

            ExtTopic targettopic = targetarea.topics.get(ini.initiative.issue_id);
            if (targettopic == null)
            {
                targettopic = new ExtTopic(targetarea, ini.initiative.issue_id);
            } 
            targettopic.initiatives.Add(ini);
        }
    }
}
