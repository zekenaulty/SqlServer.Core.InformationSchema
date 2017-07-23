using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{

    /// <summary>
    /// eturns one row for each table privilege that is granted to or granted by the current user in the current database
    /// </summary>
	[Table("TABLE_PRIVILEGES", Schema="INFORMATION_SCHEMA")]
	public class TablePrivilege
    {

        /// <summary>
        /// Privilege grantor
        /// </summary>
        [Column("GRANTOR")]
		public string Grantor {get; set; }

        /// <summary>
        /// Privilege grantee
        /// </summary>
        [Column("GRANTEE")]
		public string Grantee {get; set; }

        /// <summary>
        /// Table qualifier
        /// </summary>
        [Column("TABLE_CATALOG")]
		public string TableCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the table
        /// </summary>
        [Column("TABLE_SCHEMA")]
		public string TableSchema {get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [Column("TABLE_NAME")]
		public string TableName {get; set; }

        /// <summary>
        /// Type of privilege.
        /// </summary>
        [Column("PRIVILEGE_TYPE")]
		public string PrivilegeType {get; set; }

        /// <summary>
        /// Specifies whether the grantee can grant permissions to others
        /// </summary>
        [Column("IS_GRANTABLE")]
		public string IsGrantable {get; set;}
	}
}
