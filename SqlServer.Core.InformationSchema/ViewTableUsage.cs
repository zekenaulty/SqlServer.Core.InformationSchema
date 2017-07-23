using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{

    /// <summary>
    /// Returns one row for each table in the current database that is used in a view. This information schema view returns information about the objects to which the current user has permissions.
    /// </summary>
    [Table("VIEW_TABLE_USAGE", Schema = "INFORMATION_SCHEMA")]
    public class ViewTableUsage
    {

        /// <summary>
        /// View qualifier.
        /// </summary>
		[Column("VIEW_CATALOG")]
        public string ViewCatalog { get; set; }

        /// <summary>
        /// Name of schema that contains the view
        /// </summary>
		[Column("VIEW_SCHEMA")]
        public string ViewSchema { get; set; }

        /// <summary>
        /// View name
        /// </summary>
		[Column("VIEW_NAME")]
        public string ViewName { get; set; }

        /// <summary>
        /// Table qualifier.
        /// </summary>
		[Column("TABLE_CATALOG")]
        public string TableCatalog { get; set; }

        /// <summary>
        /// Name of schema that contains the table.
        /// </summary>
		[Column("TABLE_SCHEMA")]
        public string TableSchema { get; set; }

        /// <summary>
        /// Base table.
        /// </summary>
		[Column("TABLE_NAME")]
        public string TableName { get; set; }
    }
}
