using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{

    /// <summary>
    /// Returns one row for each schema in the current database. To retrieve information from these views, specify the fully qualified name of INFORMATION_SCHEMA.view_name. 
    /// To retrieve information about all databases in an instance of SQL Server, query the sys.databases (Transact-SQL) catalog view.
    /// </summary>
	[Table("SCHEMATA", Schema="INFORMATION_SCHEMA")]
	public class Schema
    {

        /// <summary>
        /// Name of current database
        /// </summary>
        [Column("CATALOG_NAME")]
		public string CatalogName {get; set; }

        /// <summary>
        /// Returns the name of the schema.
        /// </summary>
        [Column("SCHEMA_NAME")]
		public string SchemaName {get; set; }

        /// <summary>
        /// Schema owner name
        /// </summary>
        [Column("SCHEMA_OWNER")]
		public string SchemaOwner {get; set; }

        /// <summary>
        /// Always returns NULL.
        /// </summary>
        [Column("DEFAULT_CHARACTER_SET_CATALOG")]
		public string DefaultCharacterSetCatalog {get; set; }

        /// <summary>
        /// Always returns NULL.
        /// </summary>
        [Column("DEFAULT_CHARACTER_SET_SCHEMA")]
		public string DefaultCharacterSetSchema {get; set; }

        /// <summary>
        /// Returns the name of the default character set.
        /// </summary>
        [Column("DEFAULT_CHARACTER_SET_NAME")]
		public string DefaultCharacterSetName {get; set;}
	}
}
