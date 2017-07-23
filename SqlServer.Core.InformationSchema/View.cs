using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{

    /// <summary>
    /// 
    /// </summary>
	[Table("VIEWS", Schema="INFORMATION_SCHEMA")]
	public class View
    {

        /// <summary>
        /// View qualifier
        /// </summary>
        [Column("TABLE_CATALOG")]
		public string TableCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the view
        /// </summary>
        [Column("TABLE_SCHEMA")]
		public string TableSchema {get; set; }

        /// <summary>
        /// View name
        /// </summary>
        [Column("TABLE_NAME")]
		public string TableName {get; set; }

        /// <summary>
        /// If the length of definition is larger than nvarchar(4000), this column is NULL. Otherwise, this column is the view definition text
        /// </summary>
        [Column("VIEW_DEFINITION")]
		public string ViewDefinition {get; set; }

        /// <summary>
        /// Type of WITH CHECK OPTION. Is CASCADE if the original view was created by using the WITH CHECK OPTION. Otherwise, NONE is returned
        /// </summary>
        [Column("CHECK_OPTION")]
		public string CheckOption {get; set; }

        /// <summary>
        /// Specifies whether the view is updatable. Always returns NO
        /// </summary>
        [Column("IS_UPDATABLE")]
		public string IsUpdatable {get; set;}
	}
}
