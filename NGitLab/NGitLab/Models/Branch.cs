﻿using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class Branch
    {
        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "commit")]
        public CommitInfo Commit;

        [DataMember(Name = "protected")]
        public bool Protected;
    }
}