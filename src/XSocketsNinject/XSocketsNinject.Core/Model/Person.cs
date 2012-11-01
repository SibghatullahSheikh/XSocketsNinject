using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace XSocketsNinject.Core.Model
{

    /// <summary>
    /// Dummy model for demo...
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Person : PersistentEntity
    {
        [DataMember]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [MaxLength(100)]
        public string Location { get; set; }
    }
}