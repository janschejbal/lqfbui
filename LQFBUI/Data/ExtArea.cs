using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LQFBUI.Data.List;
using System.Runtime.Serialization;

namespace LQFBUI.Data
{
    [DataContract]
    public class ExtArea : IObjectWithID<ulong>
    {
        [DataMember] public readonly ulong id;
        public ulong ID { get { return id; } } // for IObjectWithID

        [DataMember] public readonly UlongMap<ExtTopic> topics = new UlongMap<ExtTopic>();

        [DataMember] public bool open;
        [DataMember] public bool ignored;

        [DataMember] public readonly Remote<bool> autoreject = new Remote<bool>();

        [DataMember] public readonly Remote<bool> member = new Remote<bool>();
        [DataMember] public readonly Remote<bool> active = new Remote<bool>();
        [DataMember] public readonly Remote<ulong> autoreject_weight = new Remote<ulong>();
        [DataMember] public readonly Remote<string> description = new Remote<string>();
        [DataMember] public readonly Remote<ulong> direct_member_count = new Remote<ulong>();
        [DataMember] public readonly Remote<ulong> member_weight = new Remote<ulong>();
        [DataMember] public readonly Remote<string> name = new Remote<string>();

        /// <summary>
        ///     DO NOT USE. Only for XML serialization!
        /// </summary>
        // public ExtArea() { } // DO NOT USE. Only for XML serialization!

        private ExtArea(Area area)
        {
            this.id = area.id;

            Storage.areas.Add(this);
            this.update(area);
        }

        public static ExtArea get(Area area)
        {
            ExtArea result = Storage.areas.get(area.id);
            if (result == null)
            {
                result = new ExtArea(area);
            }
            else
            {
                result.update(area);
            }
            return result;
        }

        public void update(Area area)
        {
            this.member.remote = false; // TODO API: once the API supports this, fix it.
            this.active.remote = area.active;
            this.autoreject_weight.remote = area.autoreject_weight;
            this.description.remote = area.description;
            this.direct_member_count.remote = area.direct_member_count;
            this.member_weight.remote = area.member_weight;
            this.name.remote = area.name;
        }

        public void addTopic(ExtTopic topic)
        {
            topics.Add(topic);
        }

    }
}
