/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using Beef.Data.Database.Cdc;
using Beef.Entities;
using Beef.Mapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Beef.Demo.CdcPublisher.Entities
{
    /// <summary>
    /// Represents the CDC model for the root (parent) database table 'Legacy.Posts'.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PostsCdc : ITableKey, IETag
    {
        /// <summary>
        /// Gets or sets the 'Posts Id' (Legacy.Posts.PostsId) column value.
        /// </summary>
        [JsonProperty("postsId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PostsId { get; set; }

        /// <summary>
        /// Gets or sets the 'Text' (Legacy.Posts.Text) column value.
        /// </summary>
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the 'Date' (Legacy.Posts.Date) column value.
        /// </summary>
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the related (one-to-many) <see cref="PostsCdc.CommentsCollection"/> (database table 'Legacy.Comments').
        /// </summary>
        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [MapperIgnore()]
        public PostsCdc.CommentsCdcCollection? Comments { get; set; }

        /// <summary>
        /// Gets or sets the related (one-to-many) <see cref="PostsCdc.PostsTagsCollection"/> (database table 'Legacy.Tags').
        /// </summary>
        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [MapperIgnore()]
        public PostsCdc.PostsTagsCdcCollection? Tags { get; set; }

        /// <summary>
        /// Gets or sets the entity tag (calculated as a JSON serialized hash value).
        /// </summary>
        [JsonProperty("etag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [MapperIgnore()]
        public string? ETag { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MapperIgnore()]
        public UniqueKey UniqueKey => new UniqueKey(PostsId);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MapperIgnore()]
        public string[] UniqueKeyProperties => new string[] { nameof(PostsId) };

        /// <summary>
        /// Gets or sets the 'Posts Id' <i>primary key</i> (Legacy.Posts.PostsId) column value (from the actual database table primary key; not from the change-data-capture source).
        /// </summary>
        /// <remarks>Will have a <c>default</c> value when the record no longer exists within the database (i.e. has been physically deleted).</remarks>
        public int TableKey_PostsId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <remarks><inheritdoc/></remarks>
        public UniqueKey TableKey => new UniqueKey(TableKey_PostsId);

        #region CommentsCdc

        /// <summary>
        /// Represents the CDC model for the related (child) database table 'Legacy.Comments' (known uniquely as 'Comments').
        /// </summary>
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public partial class CommentsCdc : IUniqueKey
        {
            /// <summary>
            /// Gets or sets the 'Comments Id' (Legacy.Comments.CommentsId) column value.
            /// </summary>
            [JsonProperty("commentsId", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int CommentsId { get; set; }

            /// <summary>
            /// Gets or sets the 'Posts Id' (Legacy.Comments.PostsId) column value.
            /// </summary>
            [JsonProperty("postsId", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int PostsId { get; set; }

            /// <summary>
            /// Gets or sets the 'Text' (Legacy.Comments.Text) column value.
            /// </summary>
            [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string? Text { get; set; }

            /// <summary>
            /// Gets or sets the 'Date' (Legacy.Comments.Date) column value.
            /// </summary>
            [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public DateTime? Date { get; set; }

            /// <summary>
            /// Gets or sets the related (one-to-many) <see cref="PostsCdc.CommentsTagsCollection"/> (database table 'Legacy.Tags').
            /// </summary>
            [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
            [MapperIgnore()]
            public PostsCdc.CommentsTagsCdcCollection? Tags { get; set; }

            /// <summary>
            /// <inheritdoc/>
            /// </summary>
            [MapperIgnore()]
            public UniqueKey UniqueKey => new UniqueKey(CommentsId);

            /// <summary>
            /// <inheritdoc/>
            /// </summary>
            [MapperIgnore()]
            public string[] UniqueKeyProperties => new string[] { nameof(CommentsId) };
        }

        /// <summary>
        /// Represents the CDC model for the related (child) database table collection 'Legacy.Comments'.
        /// </summary>
        public partial class CommentsCdcCollection : List<CommentsCdc> { }

        #endregion

        #region CommentsTagsCdc

        /// <summary>
        /// Represents the CDC model for the related (child) database table 'Legacy.Tags' (known uniquely as 'CommentsTags').
        /// </summary>
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public partial class CommentsTagsCdc : IUniqueKey
        {
            /// <summary>
            /// Gets or sets the 'Tags Id' (Legacy.CommentsTags.TagsId) column value.
            /// </summary>
            [JsonProperty("tagsId", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int TagsId { get; set; }

            /// <summary>
            /// Gets or sets the 'Comments Id' (Legacy.CommentsTags.ParentId) column value.
            /// </summary>
            [JsonProperty("commentsId", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int CommentsId { get; set; }

            /// <summary>
            /// Gets or sets the 'Text' (Legacy.CommentsTags.Text) column value.
            /// </summary>
            [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string? Text { get; set; }

            /// <summary>
            /// <inheritdoc/>
            /// </summary>
            [MapperIgnore()]
            public UniqueKey UniqueKey => new UniqueKey(TagsId);

            /// <summary>
            /// <inheritdoc/>
            /// </summary>
            [MapperIgnore()]
            public string[] UniqueKeyProperties => new string[] { nameof(TagsId) };

            /// <summary>
            /// Gets or sets the 'Posts_PostsId' additional joining column (informational); for internal join use only (not serialized).
            /// </summary>
            public int Posts_PostsId { get; set; }
        }

        /// <summary>
        /// Represents the CDC model for the related (child) database table collection 'Legacy.CommentsTags'.
        /// </summary>
        public partial class CommentsTagsCdcCollection : List<CommentsTagsCdc> { }

        #endregion

        #region PostsTagsCdc

        /// <summary>
        /// Represents the CDC model for the related (child) database table 'Legacy.Tags' (known uniquely as 'PostsTags').
        /// </summary>
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public partial class PostsTagsCdc : IUniqueKey
        {
            /// <summary>
            /// Gets or sets the 'Tags Id' (Legacy.PostsTags.TagsId) column value.
            /// </summary>
            [JsonProperty("tagsId", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int TagsId { get; set; }

            /// <summary>
            /// Gets or sets the 'Posts Id' (Legacy.PostsTags.ParentId) column value.
            /// </summary>
            [JsonProperty("postsId", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int PostsId { get; set; }

            /// <summary>
            /// Gets or sets the 'Text' (Legacy.PostsTags.Text) column value.
            /// </summary>
            [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string? Text { get; set; }

            /// <summary>
            /// <inheritdoc/>
            /// </summary>
            [MapperIgnore()]
            public UniqueKey UniqueKey => new UniqueKey(TagsId);

            /// <summary>
            /// <inheritdoc/>
            /// </summary>
            [MapperIgnore()]
            public string[] UniqueKeyProperties => new string[] { nameof(TagsId) };
        }

        /// <summary>
        /// Represents the CDC model for the related (child) database table collection 'Legacy.PostsTags'.
        /// </summary>
        public partial class PostsTagsCdcCollection : List<PostsTagsCdc> { }

        #endregion
    }
}

#pragma warning restore
#nullable restore