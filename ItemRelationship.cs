//Engage: Publish - http://www.engagesoftware.com
//Copyright (c) 2004-2009
//by Engage Software ( http://www.engagesoftware.com )

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
//TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
//THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
//CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
//DEALINGS IN THE SOFTWARE.


namespace Engage.Dnn.Publish
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Globalization;
    using System.Web.UI.WebControls;
    using System.Xml.Serialization;
    using Data;
    using Portability;
    using Util;
    using TreeNode = System.Windows.Forms.TreeNode;
    using TreeView = System.Windows.Forms.TreeView;
    using DotNetNuke.Common.Utilities;

	/// <summary>
	/// Summary description for ItemRelationship.
	/// </summary>
    /// <remarks>This class should remain public, it is used by the Publish TreeView module</remarks>
    [XmlRootAttribute(ElementName = "relationship", IsNullable = false)]
	public class ItemRelationship : TransportableElement
	{
        public ItemRelationship()
        {
            this.startDate = DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }
	    
        #region Public Properties

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int itemRelationshipId = -1;
        [XmlElement(Order = 1)]
        public int ItemRelationshipId
        {
            [DebuggerStepThrough]
            get { return this.itemRelationshipId; }
            [DebuggerStepThrough]
            set { this.itemRelationshipId = value; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int childItemId = -1;
        [XmlElement(Order = 2)]
        public int ChildItemId
        {
            [DebuggerStepThrough]
            get { return this.childItemId; }
            [DebuggerStepThrough]
            set { this.childItemId = value; }
        }

        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Guid childItemIdentifier;
        [XmlElement(Order = 3)]
        public Guid ChildItemIdentifier
        {
            [DebuggerStepThrough]
            get { return this.childItemIdentifier; }
            [DebuggerStepThrough]
            set { this.childItemIdentifier = value; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int childItemVersionId = -1;
        [XmlElement(Order = 4)]
		public int ChildItemVersionId 
		{
            [DebuggerStepThrough]
            get { return this.childItemVersionId; }
            [DebuggerStepThrough]
            set { this.childItemVersionId = value; }
		}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Guid childItemVersionIdentifier;
        [XmlElement(Order = 5)]
        public Guid ChildItemVersionIdentifier
        {
            [DebuggerStepThrough]
            get { return this.childItemVersionIdentifier; }
            [DebuggerStepThrough]
            set { this.childItemVersionIdentifier = value; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int parentItemId = -1;
        [XmlElement(Order = 6)]
        public int ParentItemId
        {
            [DebuggerStepThrough]
            get { return this.parentItemId; }
            [DebuggerStepThrough]
            set { this.parentItemId = value; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Guid parentItemIdentifier;
        [XmlElement(Order = 7)]
        public Guid ParentItemIdentifier
        {
            [DebuggerStepThrough]
            get { return this.parentItemIdentifier; }
            [DebuggerStepThrough]
            set { this.parentItemIdentifier = value; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int relationshipTypeId = -1;
        [XmlElement(Order = 8)]
        public int RelationshipTypeId
        {
            [DebuggerStepThrough]
            get { return this.relationshipTypeId; }
            [DebuggerStepThrough]
            set { this.relationshipTypeId = value; }
        }


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string relationshipTypeName;
        [XmlElement(Order = 9)]
        public string RelationshipTypeName
        {
            [DebuggerStepThrough]
            get { return this.relationshipTypeName; }
            [DebuggerStepThrough]
            set { this.relationshipTypeName = value; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int itemTypeId = -1;
        [XmlIgnore]
		public int ItemTypeId 
		{
            [DebuggerStepThrough]
            get { return this.itemTypeId; }
            [DebuggerStepThrough]
            set { this.itemTypeId = value; }
		}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string startDate;
        [XmlElement(Order = 10)]
        public string StartDate 
		{
            [DebuggerStepThrough]
			get {return this.startDate;}
            [DebuggerStepThrough]
			set
            {
                this.startDate = Utility.HasValue(value) ? value : null;
            }
		}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string endDate;
        [XmlElement(Order = 11)]
        public string EndDate
        {
            [DebuggerStepThrough]
			get {return this.endDate;}
            [DebuggerStepThrough]
            set
            {
                this.endDate = Utility.HasValue(value) ? value : null;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int? sortOrder;
        [XmlElement(Order = 12)]
		public int SortOrder
		{
            [DebuggerStepThrough]
            get { return this.sortOrder ?? 0; }
            [DebuggerStepThrough]
            set { this.sortOrder = value; }
		}
	    [XmlIgnore]
	    public bool HasSortOrderBeenSet
	    {
	        get
	        {
	            return this.sortOrder.HasValue;
	        }
	    }

		#endregion

        #region Static Methods

        [Obsolete("There is a public constructor that initializes data and CBO.FillCollection uses reflection to create an instance of this class you must provide a public constructor. Just use new ItemRelationship().", false)]
        public static ItemRelationship Create()
        {
            return new ItemRelationship();
        }

        public static List<ItemRelationship> GetItemRelationships(int childItemId, int childItemVersionId, bool isActive)
        {
            return CBO.FillCollection<ItemRelationship>(DataProvider.Instance().GetItemRelationships(childItemId, childItemVersionId, isActive));
        }

        public static ArrayList GetItemRelationships(int childItemId, int childItemVersionId, int relationshipTypeId, bool isActive)
        {
            return CBO.FillCollection(DataProvider.Instance().GetItemRelationships(childItemId, childItemVersionId, relationshipTypeId, isActive), typeof (ItemRelationship));
        }

        public static ArrayList GetItemRelationships(int childItemId, int childItemVersionId, int relationshipTypeId, bool isActive, int portalId)
        {
            string cacheKey = Utility.CacheKeyPublishItemRelationships + childItemId.ToString(CultureInfo.InvariantCulture) + "_" + childItemVersionId.ToString(CultureInfo.InvariantCulture) + "_" + relationshipTypeId.ToString(CultureInfo.InvariantCulture);
            ArrayList al;

            if (ModuleBase.UseCachePortal(portalId))
            {
                object o = DataCache.GetCache(cacheKey);
                if (o != null)
                {
                    al = (ArrayList)o;
                }
                else
                {
                    al = CBO.FillCollection(DataProvider.Instance().GetItemRelationships(childItemId, childItemVersionId, relationshipTypeId, isActive), typeof(ItemRelationship));
                    DataCache.SetCache(cacheKey, al, DateTime.Now.AddMinutes(ModuleBase.CacheTimePortal(portalId)));
                    Utility.AddCacheKey(cacheKey, portalId);
                }
            }
            else
            {
                al = CBO.FillCollection(DataProvider.Instance().GetItemRelationships(childItemId, childItemVersionId, relationshipTypeId, isActive), typeof(ItemRelationship));
            }
            return al;
        }

	    public static ArrayList GetItemChildRelationships(int parentItemId , int relationshipTypeId)
		{
            return CBO.FillCollection(DataProvider.Instance().GetItemChildRelationships(parentItemId, relationshipTypeId), typeof (ItemRelationship));
		}

        public static ArrayList GetItemChildRelationships(int parentItemId, int relationshipTypeId, int portalId)
        {
            string cacheKey = Utility.CacheKeyPublishChildItemRelationships + parentItemId.ToString(CultureInfo.InvariantCulture) + "_" + relationshipTypeId.ToString(CultureInfo.InvariantCulture);
            ArrayList al;

            if (ModuleBase.UseCachePortal(portalId))
            {
                object o = DataCache.GetCache(cacheKey);
                if (o != null)
                {
                    al = (ArrayList)o;
                }
                else
                {
                    al = CBO.FillCollection(DataProvider.Instance().GetItemChildRelationships(parentItemId, relationshipTypeId), typeof(ItemRelationship));
                    DataCache.SetCache(cacheKey, al, DateTime.Now.AddMinutes(ModuleBase.CacheTimePortal(portalId)));
                    Utility.AddCacheKey(cacheKey, portalId);
                }
            }
            else
            {
                al = CBO.FillCollection(DataProvider.Instance().GetItemChildRelationships(parentItemId, relationshipTypeId), typeof(ItemRelationship));
            }
            return al;
        }


	    public static List<ItemRelationship> GetAllRelationships(int moduleId)
        {
            return CBO.FillCollection<ItemRelationship>(DataProvider.Instance().GetAllRelationships(moduleId));
        }

        public static List<ItemRelationship> GetAllRelationshipsByPortalId(int portalId)
        {
            return CBO.FillCollection<ItemRelationship>(DataProvider.Instance().GetAllRelationshipsByPortalId(portalId));
        }

        public static DataSet GetItemRelationshipByItemRelationshipId(int itemRelationshipId)
        {
            return DataProvider.Instance().GetItemRelationshipByItemRelationshipId(itemRelationshipId);
        }

		public static DataSet GetAllChildren(int parentId, int relationshipTypeId, int portalId)
		{
			return DataProvider.Instance().GetAllChildren(parentId, relationshipTypeId, portalId);
        }

	    /// <summary>
	    /// Inserts a collection of <see cref="ListItem"/> into a <see cref="System.Web.UI.WebControls.ListControl"/>.  
	    /// Each item has a value of the name of the category plus ticks to indicate hierarchy between categories.  
	    /// Each item has a value of the category's itemId.
        /// If you have problems showing all Categories, you can try using <see cref="DisplayChildren(ListControl, int, int?)"/> on an instantiated ItemRelationship (see <see cref="Controls.ItemRelationships.UpdateAvailableItems"/> for an example).
	    /// </summary>
	    /// <param name="lc">The <see cref="System.Web.UI.WebControls.ListControl"/> into which the category options will be added.</param>
	    /// <param name="categoryId">The id of the parent category from which the hierarchy will start, or -1 if all categories.</param>
	    /// <param name="portalId">The id of the portal in which these categories reside.</param>
	    /// <param name="includeParentCategory">if set to <c>true</c> includes the parent category in the list, otherwise only shows the parent's children.  This is ignored if the TopLevelCategory is selected.</param>
	    public static void DisplayCategoryHierarchy(ListControl lc, int categoryId, int portalId, bool includeParentCategory)
	    {
	        DisplayCategoryHierarchy(lc, categoryId, portalId, includeParentCategory, -1);
	    }

        /// <summary>
        /// Inserts a collection of <see cref="ListItem"/> into a <see cref="System.Web.UI.WebControls.ListControl"/>.
        /// Each item has a value of the name of the category plus ticks to indicate hierarchy between categories.
        /// Each item has a value of the category's itemId.
        /// If you have problems showing all Categories, you can try using <see cref="DisplayChildren(ListControl, int, int?)"/> on an instantiated ItemRelationship (see <see cref="Controls.ItemRelationships.UpdateAvailableItems"/> for an example).
        /// </summary>
        /// <param name="lc">The <see cref="System.Web.UI.WebControls.ListControl"/> into which the category options will be added.</param>
        /// <param name="categoryId">The id of the parent category from which the hierarchy will start, or -1 if all categories.</param>
        /// <param name="portalId">The id of the portal in which these categories reside.</param>
        /// <param name="includeParentCategory">if set to <c>true</c> includes the parent category in the list, otherwise only shows the parent's children.  This is ignored if the TopLevelCategory is selected.</param>
        /// <param name="itemToExclude">An item which you want to exclude from the list (including its children).  This is typically used to keep circular relationships from being possibe options.</param>
        public static void DisplayCategoryHierarchy(ListControl lc, int categoryId, int portalId, bool includeParentCategory, int itemToExclude)
        {
            DataTable dt;

            if (categoryId < 1)
            {
                dt = Category.GetCategoriesHierarchy(portalId);
                //we ignore includeParentCategory if it is the TopLevelCategory
            }
            else
            {
                dt = Item.GetAllChildren(ItemType.Category.GetId(), categoryId, RelationshipType.ItemToParentCategory.GetId(), portalId).Tables[0];

                if (includeParentCategory)
                {
                    Category parentCategory = Category.GetCategory(categoryId, portalId);
                    if (parentCategory != null)
                    {
                        DataRow parentRow = dt.NewRow();
                        parentRow["ParentItemId"] = "-1";
                        parentRow["ItemId"] = categoryId;
                        parentRow["Name"] = parentCategory.Name;
                        dt.Rows.InsertAt(parentRow, 0);
                    }
                }
            }

            TreeNode root = BuildHierarchy(dt);
            FillListControl(root, lc, itemToExclude);
        }

        public static TreeNode GetAllChildrenNLevels(int parentCategoryId, int nLevels, int mItems, int portalId)
        {
            DataTable dt = DataProvider.Instance().GetAllChildrenNLevels(parentCategoryId, nLevels, mItems, portalId);

            return (BuildHierarchy(dt));
        }

	    public static DataTable GetAllChildrenNLevelsInDataTable(int parentCategoryId, int nLevels, int mItems, int portalId)
        {
            return DataProvider.Instance().GetAllChildrenNLevels(parentCategoryId, nLevels, mItems, portalId);
        }

	    private static void FillListControl(TreeNode root, ListControl lc, int? itemToExclude)
        {
            for (int i = 0; i < root.Nodes.Count; i++)
            {
                TreeNode child = root.Nodes[i];
                if (child.Text.Length > 0)
                {
                    //int level = child.FullPath.Split('\\').Length;
                    int level = child.FullPath.Split('\\').Length;
                    //ListItem li = new ListItem(pad + pad + child.Text, child.Tag.ToString());
                    int itemId = Convert.ToInt32(child.Tag, CultureInfo.InvariantCulture);

                    if (itemToExclude.HasValue && itemId == itemToExclude.Value) //skip this item and its children
                    {
                        continue;
                    }
                    int paddingWidth = (level - 3) * 2;
                    var padding = new string('-', paddingWidth);
                    var li = new ListItem(padding + child.Text, itemId.ToString(CultureInfo.InvariantCulture));
                    lc.Items.Add(li);
                }

                FillListControl(child, lc, itemToExclude);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "TreeNode.#ctor(System.String)", Justification = "Literal 'Root' is only used internally")]
        public static TreeNode BuildHierarchy(DataTable dt)
        {
            if (dt != null)
            {
                IDictionary nodes = new Hashtable();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow r = dt.Rows[i];

                    object parentId = r["ParentItemId"];
                    object childId = r["ItemId"];
                    string text = r["Name"].ToString();

                    TreeNode parent;
                    if (nodes.Contains(parentId))
                    {
                        parent = (TreeNode)nodes[parentId];
                    }
                    else
                    {
                        parent = new TreeNode {Tag = parentId};
                        //parent.Tag = parentId;
                        nodes.Add(parentId, parent);
                    }

                    TreeNode child;
                    if (nodes.Contains(childId))
                    {
                        child = (TreeNode)nodes[childId];
                        child.Text = text;
                    }
                    else
                    {
                        child = new TreeNode(text) {Tag = childId};
                        //child.Tag = childId;
                        nodes.Add(childId, child);
                    }

                    parent.Nodes.Add(child);
                }

                var root = new TreeNode("Root");

                IEnumerator ie = nodes.Keys.GetEnumerator();
                while (ie.MoveNext())
                {
                    var n = (TreeNode)nodes[ie.Current];
                    if (n.Parent == null)
                    {
                        root.Nodes.Add(n);
                    }
                    else if (String.IsNullOrEmpty(n.Parent.Text) && n.Parent.Tag == null)
                    {
                        root.Nodes.Add(n);
                    }
                }

                using (var tv = new TreeView())
                {
                    //tv.Sorted = true;
                    tv.Nodes.Add(root);
                }

                return root;
            }
            return null;
        }

	    public static void AddItemRelationship(int childItemId, int childItemVersionId, int parentItemId, int relationshipTypeId, string startDate, string endDate, int sortOrder)
        {
            DataProvider.Instance().AddItemRelationship(childItemId, childItemVersionId, parentItemId, relationshipTypeId, startDate, endDate, sortOrder);
        }

	    public static void AddItemRelationshipWithOriginalSortOrder(IDbTransaction trans, int childItemId, int childItemVersionId, int parentItemId, int relationshipTypeId, string startDate, string endDate, int originalItemVersionId)
        {
            DataProvider.Instance().AddItemRelationshipWithOriginalSortOrder(trans, childItemId, childItemVersionId, parentItemId, relationshipTypeId, startDate, endDate, originalItemVersionId);
        }

	    public static void AddItemRelationship(IDbTransaction trans, int childItemId, int childItemVersionId, int parentItemId, int relationshipTypeId, string startDate, string endDate, int sortOrder)
        {
            DataProvider.Instance().AddItemRelationship(trans, childItemId, childItemVersionId, parentItemId, relationshipTypeId, startDate, endDate, sortOrder);
        }

        public static void UpdateItemRelationship(int itemRelationshipId, int sortOrder)
        {
            DataProvider.Instance().UpdateItemRelationship(itemRelationshipId, sortOrder);
        }
        
        #endregion

	    public void DisplayChildren(ListControl lc, int portalId)
	    {
	        DisplayChildren(lc, portalId, null);
	    }

	    public void DisplayChildren(ListControl lc, int portalId, int? itemToExclude)
	    {
			DataTable dt;
			DataSet ds;
			if (this.parentItemId < 1)
			{
				dt = Category.GetCategoriesHierarchy(portalId);
			}
			else
			{
				ds = Item.GetAllChildren(this.parentItemId, this.relationshipTypeId, portalId);
				dt = ds.Tables[0];
			}

            TreeNode root = BuildHierarchy(dt);
            FillListControl(root, lc, itemToExclude);
		}
                
//		public DataTable GetChildren(int childTypeId, int maxItems, int portalId)
//		{
//			StringBuilder sql = new StringBuilder();
//
//			sql.Append("engageams_spItemListing ");
//			sql.Append(childTypeId);
//			sql.Append(", ");
//			sql.Append(portalId);
//
//			DataTable dt = DataProvider.Instance().GetDataTable(sql.ToString(), portalId);
//
//			SecurityFilter sf = SecurityFilter.Instance;
//			sf.FilterCategories(dt);
//
//			//remove rows over the limit
//			if (maxItems != -1)
//			{
//				ArrayList al = new ArrayList();
//				for (int i = maxItems; i < dt.Rows.Count; i++)
//				{
//					al.Add(dt.Rows[i]);
//				}
//
//				foreach (DataRow r in al)
//				{
//					data.Rows.Remove(r);
//				}
//			}
//
//			return dt;
        //		}

        public void CorrectDates()
        {
            if (!string.IsNullOrEmpty(this.StartDate)) this.StartDate = Convert.ToDateTime(this.StartDate, CultureInfo.CurrentCulture).ToString(CultureInfo.InvariantCulture);
            if (!string.IsNullOrEmpty(this.EndDate)) this.EndDate = Convert.ToDateTime(this.EndDate, CultureInfo.CurrentCulture).ToString(CultureInfo.InvariantCulture);
        }

	    #region TransportableElement Methods

        /// <summary>
        /// This method is invoked by the Import mechanism and has to take this instance of a ItemRelationship and resolve
        /// all the id's using the names supplied in the export. hk
        /// </summary>
        public override void Import(int currentModuleId, int portalId)
        {

            try
            {
                RelationshipType type = RelationshipType.GetFromName(RelationshipTypeName, typeof(RelationshipType));
                this.relationshipTypeId = type.GetId();

                //Does this exist in my db?
                using (IDataReader dr = DataProvider.Instance().GetItemRelationshipByIdentifiers(ParentItemIdentifier, ChildItemVersionIdentifier, portalId))
                {

                    if (dr.Read())
                    {
                        //this version does not exist.
                        if (dr["ParentItemId"] is DBNull || dr["ChildItemId"] is DBNull)
                        {
                            //no matching parent or child doesn't exist. Could throw error and stop
                            //but for now we will handle gracefully.
                        }
                        else
                        {
                            this.childItemId = (int)dr["ChildItemId"];
                            this.childItemVersionId = (int)dr["ChildItemVersionId"];
                            this.parentItemId = (int)dr["ParentItemId"];
                            AddItemRelationship(ChildItemId, ChildItemVersionId, ParentItemId, RelationshipTypeId, StartDate, EndDate, SortOrder);
                        }
                    }
                    else
                    {
                        DotNetNuke.Services.Exceptions.Exceptions.LogException(new Exception("No matching Parent or Child could be found to create relationship."));
                    }
                }
            }
            catch (Exception e)
            {
                DotNetNuke.Services.Exceptions.Exceptions.LogException(e);
                throw;
            }
        }

        #endregion
    }
}

