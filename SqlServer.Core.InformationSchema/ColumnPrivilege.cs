using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each column that has a privilege that is either granted to or granted by the current user in the current database.
    /// </summary>
    [Table("COLUMN_PRIVILEGES", Schema="INFORMATION_SCHEMA")]
	public class ColumnPrivilege
	{

        /// <summary>
        /// Privilege grantor.
        /// </summary>
		[Column("GRANTOR")]
		public string Grantor {get; set;}

        /// <summary>
        /// Privilege grantee.
        /// </summary>
		[Column("GRANTEE")]
		public string Grantee {get; set;}

        /// <summary>
        /// Table qualifier.
        /// </summary>
		[Column("TABLE_CATALOG")]
		public string TableCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the table.
        /// ** Important*\* Do not use INFORMATION_SCHEMA views to determine the schema of an object. The only reliable way to find the schema of a object is to query the sys.objects catalog view.
        /// </summary>
        [Column("TABLE_SCHEMA")]
		public string TableSchema {get; set;}

        /// <summary>
        /// Table name.
        /// </summary>
		[Column("TABLE_NAME")]
		public string TableName {get; set;}

        /// <summary>
        /// Column name.
        /// </summary>
		[Column("COLUMN_NAME")]
		public string ColumnName {get; set;}

        /// <summary>
        /// Type of privilege.
        /// </summary>
		[Column("PRIVILEGE_TYPE")]
		public string PrivilegeType {get; set;}

        /// <summary>
        /// Specifies whether the grantee can grant permissions to others.
        /// </summary>
		[Column("IS_GRANTABLE")]
		public string IsGrantable {get; set;}
	}
}
