

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// TreeNode
    /// </summary>
    [DataContract(Name = "TreeNode")]
    public partial class TreeNode : IEquatable<TreeNode>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TreeNodeType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode" /> class.
        /// </summary>
        /// <param name="webApplicationId">webApplicationId.</param>
        /// <param name="webApplicationUri">webApplicationUri.</param>
        /// <param name="siteCollectionId">siteCollectionId.</param>
        /// <param name="siteCollectionUrl">siteCollectionUrl.</param>
        /// <param name="siteId">siteId.</param>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="startIndex">startIndex.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageIndex">pageIndex.</param>
        /// <param name="fullCount">fullCount.</param>
        /// <param name="name">name.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="managedPath">managedPath.</param>
        /// <param name="agentID">agentID.</param>
        /// <param name="fullPath">fullPath.</param>
        /// <param name="farmName">farmName.</param>
        /// <param name="hasNextPage">hasNextPage.</param>
        /// <param name="farmID">farmID.</param>
        /// <param name="parentID">parentID.</param>
        /// <param name="extension">extension.</param>
        /// <param name="parent">parent.</param>
        /// <param name="type">type.</param>
        /// <param name="spObjectID">spObjectID.</param>
        /// <param name="networkId">networkId.</param>
        /// <param name="parentSPObjectID">parentSPObjectID.</param>
        /// <param name="id">id.</param>
        /// <param name="loadManagedPath">loadManagedPath.</param>
        /// <param name="loadChildrenFromDB">loadChildrenFromDB.</param>
        /// <param name="loadedPageCount">loadedPageCount.</param>
        /// <param name="children">children.</param>
        /// <param name="selectedChildren">selectedChildren.</param>
        /// <param name="filterUrls">filterUrls.</param>
        /// <param name="filterType">filterType.</param>
        /// <param name="checkNumber">checkNumber.</param>
        /// <param name="selectedWebAppIdSubSiteProvServ">selectedWebAppIdSubSiteProvServ.</param>
        /// <param name="selectedSiteCollIdsSubSiteProvServ">selectedSiteCollIdsSubSiteProvServ.</param>
        /// <param name="childrenType">childrenType.</param>
        /// <param name="listId">listId.</param>
        /// <param name="serverRelativeUrl">serverRelativeUrl.</param>
        /// <param name="userName">userName.</param>
        public TreeNode(string webApplicationId = default(string), string webApplicationUri = default(string), string siteCollectionId = default(string), string siteCollectionUrl = default(string), string siteId = default(string), string nodeId = default(string), int startIndex = default(int), int pageSize = default(int), int pageIndex = default(int), int fullCount = default(int), string name = default(string), string title = default(string), string description = default(string), string displayName = default(string), string managedPath = default(string), string agentID = default(string), string fullPath = default(string), string farmName = default(string), bool hasNextPage = default(bool), Guid farmID = default(Guid), Guid parentID = default(Guid), TreeNodeExtension extension = default(TreeNodeExtension), TreeNode parent = default(TreeNode), TreeNodeType? type = default(TreeNodeType?), Guid spObjectID = default(Guid), string networkId = default(string), Guid parentSPObjectID = default(Guid), Guid id = default(Guid), bool loadManagedPath = default(bool), bool loadChildrenFromDB = default(bool), int loadedPageCount = default(int), List<TreeNode> children = default(List<TreeNode>), List<TreeNode> selectedChildren = default(List<TreeNode>), string filterUrls = default(string), int filterType = default(int), int checkNumber = default(int), Guid selectedWebAppIdSubSiteProvServ = default(Guid), string selectedSiteCollIdsSubSiteProvServ = default(string), int childrenType = default(int), Guid listId = default(Guid), string serverRelativeUrl = default(string), string userName = default(string))
        {
            this.WebApplicationId = webApplicationId;
            this.WebApplicationUri = webApplicationUri;
            this.SiteCollectionId = siteCollectionId;
            this.SiteCollectionUrl = siteCollectionUrl;
            this.SiteId = siteId;
            this.NodeId = nodeId;
            this.StartIndex = startIndex;
            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.FullCount = fullCount;
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.DisplayName = displayName;
            this.ManagedPath = managedPath;
            this.AgentID = agentID;
            this.FullPath = fullPath;
            this.FarmName = farmName;
            this.HasNextPage = hasNextPage;
            this.FarmID = farmID;
            this.ParentID = parentID;
            this.Extension = extension;
            this.Parent = parent;
            this.Type = type;
            this.SpObjectID = spObjectID;
            this.NetworkId = networkId;
            this.ParentSPObjectID = parentSPObjectID;
            this.Id = id;
            this.LoadManagedPath = loadManagedPath;
            this.LoadChildrenFromDB = loadChildrenFromDB;
            this.LoadedPageCount = loadedPageCount;
            this.Children = children;
            this.SelectedChildren = selectedChildren;
            this.FilterUrls = filterUrls;
            this.FilterType = filterType;
            this.CheckNumber = checkNumber;
            this.SelectedWebAppIdSubSiteProvServ = selectedWebAppIdSubSiteProvServ;
            this.SelectedSiteCollIdsSubSiteProvServ = selectedSiteCollIdsSubSiteProvServ;
            this.ChildrenType = childrenType;
            this.ListId = listId;
            this.ServerRelativeUrl = serverRelativeUrl;
            this.UserName = userName;
        }

        /// <summary>
        /// Gets or Sets WebApplicationId
        /// </summary>
        [DataMember(Name = "webApplicationId", EmitDefaultValue = true)]
        public string WebApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets WebApplicationUri
        /// </summary>
        [DataMember(Name = "webApplicationUri", EmitDefaultValue = true)]
        public string WebApplicationUri { get; set; }

        /// <summary>
        /// Gets or Sets SiteCollectionId
        /// </summary>
        [DataMember(Name = "siteCollectionId", EmitDefaultValue = true)]
        public string SiteCollectionId { get; set; }

        /// <summary>
        /// Gets or Sets SiteCollectionUrl
        /// </summary>
        [DataMember(Name = "siteCollectionUrl", EmitDefaultValue = true)]
        public string SiteCollectionUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = true)]
        public string SiteId { get; set; }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "nodeId", EmitDefaultValue = true)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets StartIndex
        /// </summary>
        [DataMember(Name = "startIndex", EmitDefaultValue = false)]
        public int StartIndex { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageIndex
        /// </summary>
        [DataMember(Name = "pageIndex", EmitDefaultValue = false)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or Sets FullCount
        /// </summary>
        [DataMember(Name = "fullCount", EmitDefaultValue = false)]
        public int FullCount { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ManagedPath
        /// </summary>
        [DataMember(Name = "managedPath", EmitDefaultValue = true)]
        public string ManagedPath { get; set; }

        /// <summary>
        /// Gets or Sets AgentID
        /// </summary>
        [DataMember(Name = "agentID", EmitDefaultValue = true)]
        public string AgentID { get; set; }

        /// <summary>
        /// Gets or Sets FullPath
        /// </summary>
        [DataMember(Name = "fullPath", EmitDefaultValue = true)]
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or Sets FarmName
        /// </summary>
        [DataMember(Name = "farmName", EmitDefaultValue = true)]
        public string FarmName { get; set; }

        /// <summary>
        /// Gets or Sets HasNextPage
        /// </summary>
        [DataMember(Name = "hasNextPage", EmitDefaultValue = false)]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// Gets or Sets FarmID
        /// </summary>
        [DataMember(Name = "farmID", EmitDefaultValue = false)]
        public Guid FarmID { get; set; }

        /// <summary>
        /// Gets or Sets ParentID
        /// </summary>
        [DataMember(Name = "parentID", EmitDefaultValue = false)]
        public Guid ParentID { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        public TreeNodeExtension Extension { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public TreeNode Parent { get; set; }

        /// <summary>
        /// Gets or Sets SpObjectID
        /// </summary>
        [DataMember(Name = "spObjectID", EmitDefaultValue = false)]
        public Guid SpObjectID { get; set; }

        /// <summary>
        /// Gets or Sets NetworkId
        /// </summary>
        [DataMember(Name = "networkId", EmitDefaultValue = true)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Gets or Sets ParentSPObjectID
        /// </summary>
        [DataMember(Name = "parentSPObjectID", EmitDefaultValue = false)]
        public Guid ParentSPObjectID { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets LoadManagedPath
        /// </summary>
        [DataMember(Name = "loadManagedPath", EmitDefaultValue = false)]
        public bool LoadManagedPath { get; set; }

        /// <summary>
        /// Gets or Sets LoadChildrenFromDB
        /// </summary>
        [DataMember(Name = "loadChildrenFromDB", EmitDefaultValue = false)]
        public bool LoadChildrenFromDB { get; set; }

        /// <summary>
        /// Gets or Sets LoadedPageCount
        /// </summary>
        [DataMember(Name = "loadedPageCount", EmitDefaultValue = false)]
        public int LoadedPageCount { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = true)]
        public List<TreeNode> Children { get; set; }

        /// <summary>
        /// Gets or Sets SelectedChildren
        /// </summary>
        [DataMember(Name = "selectedChildren", EmitDefaultValue = true)]
        public List<TreeNode> SelectedChildren { get; set; }

        /// <summary>
        /// Gets or Sets FilterUrls
        /// </summary>
        [DataMember(Name = "filterUrls", EmitDefaultValue = true)]
        public string FilterUrls { get; set; }

        /// <summary>
        /// Gets or Sets FilterType
        /// </summary>
        [DataMember(Name = "filterType", EmitDefaultValue = false)]
        public int FilterType { get; set; }

        /// <summary>
        /// Gets or Sets CheckNumber
        /// </summary>
        [DataMember(Name = "checkNumber", EmitDefaultValue = false)]
        public int CheckNumber { get; set; }

        /// <summary>
        /// Gets or Sets SelectedWebAppIdSubSiteProvServ
        /// </summary>
        [DataMember(Name = "selectedWebAppId_SubSiteProvServ", EmitDefaultValue = false)]
        public Guid SelectedWebAppIdSubSiteProvServ { get; set; }

        /// <summary>
        /// Gets or Sets SelectedSiteCollIdsSubSiteProvServ
        /// </summary>
        [DataMember(Name = "selectedSiteCollIds_SubSiteProvServ", EmitDefaultValue = true)]
        public string SelectedSiteCollIdsSubSiteProvServ { get; set; }

        /// <summary>
        /// Gets or Sets ChildrenType
        /// </summary>
        [DataMember(Name = "childrenType", EmitDefaultValue = false)]
        public int ChildrenType { get; set; }

        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name = "listId", EmitDefaultValue = false)]
        public Guid ListId { get; set; }

        /// <summary>
        /// Gets or Sets ServerRelativeUrl
        /// </summary>
        [DataMember(Name = "serverRelativeUrl", EmitDefaultValue = true)]
        public string ServerRelativeUrl { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TreeNode {\n");
            sb.Append("  WebApplicationId: ").Append(WebApplicationId).Append("\n");
            sb.Append("  WebApplicationUri: ").Append(WebApplicationUri).Append("\n");
            sb.Append("  SiteCollectionId: ").Append(SiteCollectionId).Append("\n");
            sb.Append("  SiteCollectionUrl: ").Append(SiteCollectionUrl).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  FullCount: ").Append(FullCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ManagedPath: ").Append(ManagedPath).Append("\n");
            sb.Append("  AgentID: ").Append(AgentID).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
            sb.Append("  FarmName: ").Append(FarmName).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  FarmID: ").Append(FarmID).Append("\n");
            sb.Append("  ParentID: ").Append(ParentID).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SpObjectID: ").Append(SpObjectID).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  ParentSPObjectID: ").Append(ParentSPObjectID).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoadManagedPath: ").Append(LoadManagedPath).Append("\n");
            sb.Append("  LoadChildrenFromDB: ").Append(LoadChildrenFromDB).Append("\n");
            sb.Append("  LoadedPageCount: ").Append(LoadedPageCount).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  SelectedChildren: ").Append(SelectedChildren).Append("\n");
            sb.Append("  FilterUrls: ").Append(FilterUrls).Append("\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  SelectedWebAppIdSubSiteProvServ: ").Append(SelectedWebAppIdSubSiteProvServ).Append("\n");
            sb.Append("  SelectedSiteCollIdsSubSiteProvServ: ").Append(SelectedSiteCollIdsSubSiteProvServ).Append("\n");
            sb.Append("  ChildrenType: ").Append(ChildrenType).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  ServerRelativeUrl: ").Append(ServerRelativeUrl).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TreeNode);
        }

        /// <summary>
        /// Returns true if TreeNode instances are equal
        /// </summary>
        /// <param name="input">Instance of TreeNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TreeNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebApplicationId == input.WebApplicationId ||
                    (this.WebApplicationId != null &&
                    this.WebApplicationId.Equals(input.WebApplicationId))
                ) && 
                (
                    this.WebApplicationUri == input.WebApplicationUri ||
                    (this.WebApplicationUri != null &&
                    this.WebApplicationUri.Equals(input.WebApplicationUri))
                ) && 
                (
                    this.SiteCollectionId == input.SiteCollectionId ||
                    (this.SiteCollectionId != null &&
                    this.SiteCollectionId.Equals(input.SiteCollectionId))
                ) && 
                (
                    this.SiteCollectionUrl == input.SiteCollectionUrl ||
                    (this.SiteCollectionUrl != null &&
                    this.SiteCollectionUrl.Equals(input.SiteCollectionUrl))
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.StartIndex == input.StartIndex ||
                    this.StartIndex.Equals(input.StartIndex)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.PageIndex == input.PageIndex ||
                    this.PageIndex.Equals(input.PageIndex)
                ) && 
                (
                    this.FullCount == input.FullCount ||
                    this.FullCount.Equals(input.FullCount)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ManagedPath == input.ManagedPath ||
                    (this.ManagedPath != null &&
                    this.ManagedPath.Equals(input.ManagedPath))
                ) && 
                (
                    this.AgentID == input.AgentID ||
                    (this.AgentID != null &&
                    this.AgentID.Equals(input.AgentID))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
                ) && 
                (
                    this.FarmName == input.FarmName ||
                    (this.FarmName != null &&
                    this.FarmName.Equals(input.FarmName))
                ) && 
                (
                    this.HasNextPage == input.HasNextPage ||
                    this.HasNextPage.Equals(input.HasNextPage)
                ) && 
                (
                    this.FarmID == input.FarmID ||
                    (this.FarmID != null &&
                    this.FarmID.Equals(input.FarmID))
                ) && 
                (
                    this.ParentID == input.ParentID ||
                    (this.ParentID != null &&
                    this.ParentID.Equals(input.ParentID))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SpObjectID == input.SpObjectID ||
                    (this.SpObjectID != null &&
                    this.SpObjectID.Equals(input.SpObjectID))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.ParentSPObjectID == input.ParentSPObjectID ||
                    (this.ParentSPObjectID != null &&
                    this.ParentSPObjectID.Equals(input.ParentSPObjectID))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LoadManagedPath == input.LoadManagedPath ||
                    this.LoadManagedPath.Equals(input.LoadManagedPath)
                ) && 
                (
                    this.LoadChildrenFromDB == input.LoadChildrenFromDB ||
                    this.LoadChildrenFromDB.Equals(input.LoadChildrenFromDB)
                ) && 
                (
                    this.LoadedPageCount == input.LoadedPageCount ||
                    this.LoadedPageCount.Equals(input.LoadedPageCount)
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.SelectedChildren == input.SelectedChildren ||
                    this.SelectedChildren != null &&
                    input.SelectedChildren != null &&
                    this.SelectedChildren.SequenceEqual(input.SelectedChildren)
                ) && 
                (
                    this.FilterUrls == input.FilterUrls ||
                    (this.FilterUrls != null &&
                    this.FilterUrls.Equals(input.FilterUrls))
                ) && 
                (
                    this.FilterType == input.FilterType ||
                    this.FilterType.Equals(input.FilterType)
                ) && 
                (
                    this.CheckNumber == input.CheckNumber ||
                    this.CheckNumber.Equals(input.CheckNumber)
                ) && 
                (
                    this.SelectedWebAppIdSubSiteProvServ == input.SelectedWebAppIdSubSiteProvServ ||
                    (this.SelectedWebAppIdSubSiteProvServ != null &&
                    this.SelectedWebAppIdSubSiteProvServ.Equals(input.SelectedWebAppIdSubSiteProvServ))
                ) && 
                (
                    this.SelectedSiteCollIdsSubSiteProvServ == input.SelectedSiteCollIdsSubSiteProvServ ||
                    (this.SelectedSiteCollIdsSubSiteProvServ != null &&
                    this.SelectedSiteCollIdsSubSiteProvServ.Equals(input.SelectedSiteCollIdsSubSiteProvServ))
                ) && 
                (
                    this.ChildrenType == input.ChildrenType ||
                    this.ChildrenType.Equals(input.ChildrenType)
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.ServerRelativeUrl == input.ServerRelativeUrl ||
                    (this.ServerRelativeUrl != null &&
                    this.ServerRelativeUrl.Equals(input.ServerRelativeUrl))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.WebApplicationId != null)
                    hashCode = hashCode * 59 + this.WebApplicationId.GetHashCode();
                if (this.WebApplicationUri != null)
                    hashCode = hashCode * 59 + this.WebApplicationUri.GetHashCode();
                if (this.SiteCollectionId != null)
                    hashCode = hashCode * 59 + this.SiteCollectionId.GetHashCode();
                if (this.SiteCollectionUrl != null)
                    hashCode = hashCode * 59 + this.SiteCollectionUrl.GetHashCode();
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                hashCode = hashCode * 59 + this.FullCount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ManagedPath != null)
                    hashCode = hashCode * 59 + this.ManagedPath.GetHashCode();
                if (this.AgentID != null)
                    hashCode = hashCode * 59 + this.AgentID.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.FarmName != null)
                    hashCode = hashCode * 59 + this.FarmName.GetHashCode();
                hashCode = hashCode * 59 + this.HasNextPage.GetHashCode();
                if (this.FarmID != null)
                    hashCode = hashCode * 59 + this.FarmID.GetHashCode();
                if (this.ParentID != null)
                    hashCode = hashCode * 59 + this.ParentID.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SpObjectID != null)
                    hashCode = hashCode * 59 + this.SpObjectID.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.ParentSPObjectID != null)
                    hashCode = hashCode * 59 + this.ParentSPObjectID.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.LoadManagedPath.GetHashCode();
                hashCode = hashCode * 59 + this.LoadChildrenFromDB.GetHashCode();
                hashCode = hashCode * 59 + this.LoadedPageCount.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.SelectedChildren != null)
                    hashCode = hashCode * 59 + this.SelectedChildren.GetHashCode();
                if (this.FilterUrls != null)
                    hashCode = hashCode * 59 + this.FilterUrls.GetHashCode();
                hashCode = hashCode * 59 + this.FilterType.GetHashCode();
                hashCode = hashCode * 59 + this.CheckNumber.GetHashCode();
                if (this.SelectedWebAppIdSubSiteProvServ != null)
                    hashCode = hashCode * 59 + this.SelectedWebAppIdSubSiteProvServ.GetHashCode();
                if (this.SelectedSiteCollIdsSubSiteProvServ != null)
                    hashCode = hashCode * 59 + this.SelectedSiteCollIdsSubSiteProvServ.GetHashCode();
                hashCode = hashCode * 59 + this.ChildrenType.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.ServerRelativeUrl != null)
                    hashCode = hashCode * 59 + this.ServerRelativeUrl.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
