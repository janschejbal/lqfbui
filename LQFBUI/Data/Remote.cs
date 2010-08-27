using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQFBUI.Data
{
    /// <summary>
    ///     Stores a pair of local and remote values
    /// </summary>
    /// <typeparam name="X">The value type to store, for example ulong or string. DO NOT USE WITH COMPLEX OBJECTS!
    ///     If you set remote to an object, and some member of the object changes, it may affect local,
    ///     as local is initialized to the value of remote in the beginning!
    /// </typeparam>
    public class Remote<X>
    {
        /// <summary>
        ///     Initially true after first setting the remote value, indicates wheter the remote value changed.
        ///     Set to false to confirm change ("mark as read").
        /// </summary>
        public bool remoteChanged = false;

        /// <summary>
        ///     Indicates that the local value has changed, i.e. local/remote are expected to be out of sync.
        ///     Set to false once synchronized successfully. If this is false and hasSync is false too,
        ///     the remote value changed. If that happens with things like own voting results,
        ///     either the user changed them outside this program or the admins are stealing the vote ;-)
        ///     (or, which is more probable, there is a bug somewhere)
        /// </summary>
        public bool localChanged = false;

        private X _local;
        public X local
        {
            get { return _local; }
            set
            {
                if (!value.Equals(_local))
                {
                    localChanged = true;
                }
                _local = value;
            }
        }

        private X _remote;
        public X remote
        {
            get { return _remote; }
            set
            {
                if (!value.Equals(_remote))
                {
                    remoteChanged = true;
                }
                _remote = value;
                if (_local == null)
                {
                    _local = _remote;
                }
            }
        }

        /// <summary>
        ///    readonly, tells if remote and local values are equal, i.e. in sync.
        ///    If they are not, use remoteChanged and localChanged to find out why.
        /// </summary>
        public bool hasSync
        {
            get
            {
                if (_remote == null || _local == null) return false;
                return _local.Equals(_remote);
            }
        }

    }
}
