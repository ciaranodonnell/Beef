/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Person entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Person : EntityBase, IGuidIdentifier, IUniqueKey, IPartitionKey, IETag, IChangeLog, IEquatable<Person>
    {
        #region Privates

        private Guid _id;
        private string? _firstName;
        private string? _lastName;
        private string? _uniqueCode;
        private string? _genderSid;
        private string? _genderText;
        private string? _eyeColorSid;
        private string? _eyeColorText;
        private DateTime _birthday;
        private Address? _address;
        private string? _etag;
        private ChangeLog? _changeLog;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="Person"/> identifier.
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        [Display(Name="Identifier")]
        public Guid Id
        {
            get => _id;
            set => SetValue(ref _id, value, false, false, nameof(Id));
        }

        /// <summary>
        /// Gets or sets the First Name.
        /// </summary>
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="First Name")]
        public string? FirstName
        {
            get => _firstName;
            set => SetValue(ref _firstName, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(FirstName));
        }

        /// <summary>
        /// Gets or sets the Last Name.
        /// </summary>
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Last Name")]
        public string? LastName
        {
            get => _lastName;
            set => SetValue(ref _lastName, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(LastName));
        }

        /// <summary>
        /// Gets or sets the Unique Code.
        /// </summary>
        [JsonProperty("uniqueCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Unique Code")]
        public string? UniqueCode
        {
            get => _uniqueCode;
            set => SetValue(ref _uniqueCode, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(UniqueCode));
        }

        /// <summary>
        /// Gets or sets the <see cref="Gender"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("gender", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Gender")]
        public string? GenderSid
        {
            get => _genderSid;
            set => SetValue(ref _genderSid, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(Gender));
        }

        /// <summary>
        /// Gets the corresponding {{Gender}} text (read-only where selected).
        /// </summary>
        [JsonProperty("genderText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? GenderText { get => _genderText ?? GetRefDataText(() => Gender); set => _genderText = value; }

        /// <summary>
        /// Gets or sets the Gender (see <see cref="RefDataNamespace.Gender"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Gender")]
        public RefDataNamespace.Gender? Gender
        {
            get => _genderSid;
            set => SetValue(ref _genderSid, value, false, false, nameof(Gender)); 
        }

        /// <summary>
        /// Gets or sets the <see cref="EyeColor"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("eyeColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Eye Color")]
        public string? EyeColorSid
        {
            get => _eyeColorSid;
            set => SetValue(ref _eyeColorSid, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(EyeColor));
        }

        /// <summary>
        /// Gets the corresponding {{EyeColor}} text (read-only where selected).
        /// </summary>
        [JsonProperty("eyeColorText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? EyeColorText { get => _eyeColorText ?? GetRefDataText(() => EyeColor); set => _eyeColorText = value; }

        /// <summary>
        /// Gets or sets the Eye Color (see <see cref="RefDataNamespace.EyeColor"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Eye Color")]
        public RefDataNamespace.EyeColor? EyeColor
        {
            get => _eyeColorSid;
            set => SetValue(ref _eyeColorSid, value, false, false, nameof(EyeColor)); 
        }

        /// <summary>
        /// Gets or sets the Birthday.
        /// </summary>
        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Birthday")]
        public DateTime Birthday
        {
            get => _birthday;
            set => SetValue(ref _birthday, value, false, DateTimeTransform.DateOnly, nameof(Birthday));
        }

        /// <summary>
        /// Gets or sets the Address (see <see cref="Common.Entities.Address"/>).
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Address")]
        public Address? Address
        {
            get => _address;
            set => SetValue(ref _address, value, false, true, nameof(Address));
        }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        [JsonProperty("etag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="ETag")]
        public string? ETag
        {
            get => _etag;
            set => SetValue(ref _etag, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(ETag));
        }

        /// <summary>
        /// Gets or sets the Change Log (see <see cref="Beef.Entities.ChangeLog"/>).
        /// </summary>
        [JsonProperty("changeLog", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Change Log")]
        public ChangeLog? ChangeLog
        {
            get => _changeLog;
            set => SetValue(ref _changeLog, value, false, true, nameof(ChangeLog));
        }

        #endregion

        #region IChangeTracking

        /// <summary>
        /// Resets the entity state to unchanged by accepting the changes (resets <see cref="EntityBase.ChangeTracking"/>).
        /// </summary>
        /// <remarks>Ends and commits the entity changes (see <see cref="EntityBase.EndEdit"/>).</remarks>
        public override void AcceptChanges()
        {
            Address?.AcceptChanges();
            ChangeLog?.AcceptChanges();
            base.AcceptChanges();
        }

        /// <summary>
        /// Determines that until <see cref="AcceptChanges"/> is invoked property changes are to be logged (see <see cref="EntityBase.ChangeTracking"/>).
        /// </summary>
        public override void TrackChanges()
        {
            Address?.TrackChanges();
            ChangeLog?.TrackChanges();
            base.TrackChanges();
        }

        #endregion

        #region IUniqueKey
        
        /// <summary>
        /// Gets the list of property names that represent the unique key.
        /// </summary>
        public string[] UniqueKeyProperties => new string[] { nameof(Id) };

        /// <summary>
        /// Creates the <see cref="UniqueKey"/>.
        /// </summary>
        /// <returns>The <see cref="Beef.Entities.UniqueKey"/>.</returns>
        /// <param name="id">The <see cref="Id"/>.</param>
        public static UniqueKey CreateUniqueKey(Guid id) => new UniqueKey(id);

        /// <summary>
        /// Gets the <see cref="UniqueKey"/> (consists of the following property(s): <see cref="Id"/>).
        /// </summary>
        public UniqueKey UniqueKey => CreateUniqueKey(Id);

        #endregion

        #region IPartitionKey
        
        /// <summary>
        /// Creates the <see cref="IPartitionKey.PartitionKey"/>.
        /// </summary>
        /// <returns>The Partition Key.</returns>
        /// <param name="eyeColor">The <see cref="EyeColor"/>.</param>
        public static string CreatePartitionKey(string? eyeColorSid) => PartitionKeyGenerator.Generate(eyeColorSid);

        /// <summary>
        /// Gets the Partition Key (consists of the following property(s): <see cref="EyeColor"/>).
        /// </summary>
        public string PartitionKey => CreatePartitionKey(EyeColorSid);

        #endregion

        #region IEquatable

        /// <summary>
        /// Determines whether the specified object is equal to the current object by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? obj) => obj is Person val && Equals(val);

        /// <summary>
        /// Determines whether the specified <see cref="Person"/> is equal to the current <see cref="Person"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> to compare with the current <see cref="Person"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="Person"/> is equal to the current <see cref="Person"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(Person? value)
        {
            if (value == null)
                return false;
            else if (ReferenceEquals(value, this))
                return true;

            return base.Equals((object)value)
                && Equals(Id, value.Id)
                && Equals(FirstName, value.FirstName)
                && Equals(LastName, value.LastName)
                && Equals(UniqueCode, value.UniqueCode)
                && Equals(GenderSid, value.GenderSid)
                && Equals(EyeColorSid, value.EyeColorSid)
                && Equals(Birthday, value.Birthday)
                && Equals(Address, value.Address)
                && Equals(ETag, value.ETag)
                && Equals(ChangeLog, value.ChangeLog);
        }

        /// <summary>
        /// Compares two <see cref="Person"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="Person"/> A.</param>
        /// <param name="b"><see cref="Person"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (Person? a, Person? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="Person"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="Person"/> A.</param>
        /// <param name="b"><see cref="Person"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (Person? a, Person? b) => !Equals(a, b);

        /// <summary>
        /// Returns the hash code for the <see cref="Person"/>.
        /// </summary>
        /// <returns>The hash code for the <see cref="Person"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Id);
            hash.Add(FirstName);
            hash.Add(LastName);
            hash.Add(UniqueCode);
            hash.Add(GenderSid);
            hash.Add(EyeColorSid);
            hash.Add(Birthday);
            hash.Add(Address);
            hash.Add(ETag);
            hash.Add(ChangeLog);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="Person"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Person"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<Person>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="Person"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Person"/> to copy from.</param>
        public void CopyFrom(Person from)
        {
            if (from == null)
                throw new ArgumentNullException(nameof(from));

            CopyFrom((EntityBase)from);
            Id = from.Id;
            FirstName = from.FirstName;
            LastName = from.LastName;
            UniqueCode = from.UniqueCode;
            GenderSid = from.GenderSid;
            EyeColorSid = from.EyeColorSid;
            Birthday = from.Birthday;
            Address = CopyOrClone(from.Address, Address);
            ETag = from.ETag;
            ChangeLog = CopyOrClone(from.ChangeLog, ChangeLog);

            OnAfterCopyFrom(from);
        }

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="Person"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="Person"/>.</returns>
        public override object Clone()
        {
            var clone = new Person();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="Person"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Id = Cleaner.Clean(Id);
            FirstName = Cleaner.Clean(FirstName, StringTrim.UseDefault, StringTransform.UseDefault);
            LastName = Cleaner.Clean(LastName, StringTrim.UseDefault, StringTransform.UseDefault);
            UniqueCode = Cleaner.Clean(UniqueCode, StringTrim.UseDefault, StringTransform.UseDefault);
            GenderSid = Cleaner.Clean(GenderSid);
            EyeColorSid = Cleaner.Clean(EyeColorSid);
            Birthday = Cleaner.Clean(Birthday, DateTimeTransform.DateOnly);
            Address = Cleaner.Clean(Address);
            ETag = Cleaner.Clean(ETag, StringTrim.UseDefault, StringTransform.UseDefault);
            ChangeLog = Cleaner.Clean(ChangeLog);

            OnAfterCleanUp();
        }

        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                return Cleaner.IsInitial(Id)
                    && Cleaner.IsInitial(FirstName)
                    && Cleaner.IsInitial(LastName)
                    && Cleaner.IsInitial(UniqueCode)
                    && Cleaner.IsInitial(GenderSid)
                    && Cleaner.IsInitial(EyeColorSid)
                    && Cleaner.IsInitial(Birthday)
                    && Cleaner.IsInitial(Address)
                    && Cleaner.IsInitial(ETag)
                    && Cleaner.IsInitial(ChangeLog);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(Person from);

        #endregion
    }

    #region Collection

    /// <summary>
    /// Represents the <see cref="Person"/> collection.
    /// </summary>
    public partial class PersonCollection : EntityBaseCollection<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollection"/> class.
        /// </summary>
        public PersonCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollection"/> class with an entities range.
        /// </summary>
        /// <param name="entities">The <see cref="Person"/> entities.</param>
        public PersonCollection(IEnumerable<Person> entities) => AddRange(entities);

        /// <summary>
        /// Creates a deep copy of the <see cref="PersonCollection"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="PersonCollection"/>.</returns>
        public override object Clone()
        {
            var clone = new PersonCollection();
            foreach (var item in this)
            {
                clone.Add((Person)item.Clone());
            }
                
            return clone;
        }

        /// <summary>
        /// An implicit cast from the <see cref="PersonCollectionResult"/> to a corresponding <see cref="PersonCollection"/>.
        /// </summary>
        /// <param name="result">The <see cref="PersonCollectionResult"/>.</param>
        /// <returns>The corresponding <see cref="PersonCollection"/>.</returns>
        public static implicit operator PersonCollection(PersonCollectionResult result) => result?.Result!;
    }

    #endregion  

    #region CollectionResult

    /// <summary>
    /// Represents the <see cref="Person"/> collection result.
    /// </summary>
    public class PersonCollectionResult : EntityCollectionResult<PersonCollection, Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class.
        /// </summary>
        public PersonCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class with <paramref name="paging"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public PersonCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public PersonCollectionResult(IEnumerable<Person> collection, PagingArgs? paging = null) : base(paging) => Result.AddRange(collection);
        
        /// <summary>
        /// Creates a deep copy of the <see cref="PersonCollectionResult"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="PersonCollectionResult"/>.</returns>
        public override object Clone()
        {
            var clone = new PersonCollectionResult();
            clone.CopyFrom(this);
            return clone;
        }
    }

    #endregion
}

#pragma warning restore
#nullable restore