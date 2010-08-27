using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LQFBUI.Data
{
    [DataContract] 
    public class ExtInitiative : IObjectWithID<ulong>
    {

        [DataMember] public Initiative initiative; // TODO replace by single fields
        public ulong id { get { return initiative.id;  } }
        public ulong ID { get { return id; } } // for IObjectWithID

        /// <summary>
        ///     DO NOT USE. Only for XML serialization!
        /// </summary>
        // public ExtInitiative() { } // DO NOT USE. Only for XML serialization!

        private ExtInitiative(Initiative initiative)
        {
            this.initiative = initiative;
            ExtTopic.addInitiative(this);
        }

        public static ExtInitiative get(Initiative initiative)
        {
            ExtInitiative result = Storage.initiatives.get(initiative.id);
            if (result == null)
            {
                result = new ExtInitiative(initiative);
            }
            else
            {
                result.update(initiative);
            }
            return result;
        }

        public void update(Initiative initiative)
        {
            // TODO fields
            if (this.id != initiative.id) throw new Exception("update supplied initiative with wrong ID");
            this.initiative = initiative;
        }

        public ExtTopic parent
        {
            get {
                ExtTopic result = Storage.topics.get(this.initiative.issue_id);
                return result;
            }
        }
    }
}
