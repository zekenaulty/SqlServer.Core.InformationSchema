using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{

    /// <summary>
    /// Returns one row for each table in the current database for which the current user has permissions.
    /// </summary>
	[Table("TABLES", Schema="INFORMATION_SCHEMA")]
	public class Table
    {

        /// <summary>
        /// Table qualifier.
        /// </summary>
        [Column("TABLE_CATALOG")]
		public string TableCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the table.
        /// </summary>
        [Column("TABLE_SCHEMA")]
		public string TableSchema {get; set; }

        /// <summary>
        /// Table name.
        /// </summary>
        [Column("TABLE_NAME")]
		public string TableName {get; set; }

        /// <summary>
        /// Type of table. Can be VIEW or BASE TABLE
        /// </summary>
        [Column("TABLE_TYPE")]
		public string TableType {get; set;}
	}
}
