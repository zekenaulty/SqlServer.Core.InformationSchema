using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each column in the current database that has a constraint defined on the column. This information schema view returns information about the objects to which the current user has permissions.
    /// </summary>
    [Table("CONSTRAINT_COLUMN_USAGE", Schema="INFORMATION_SCHEMA")]
	public class ConstraintColumnUsage
	{
        /// <summary>
        /// Table qualifier.
        /// </summary>
		[Column("TABLE_CATALOG")]
		public string TableCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the table owner.
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
        /// Constraint qualifier.
        /// </summary>
		[Column("CONSTRAINT_CATALOG")]
		public string ConstraintCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the constraint.
        /// ** Important*\* Do not use INFORMATION_SCHEMA views to determine the schema of an object. The only reliable way to find the schema of a object is to query the sys.objects catalog view.
        /// </summary>
        [Column("CONSTRAINT_SCHEMA")]
		public string ConstraintSchema {get; set;}

        /// <summary>
        /// Constraint name.
        /// </summary>
		[Column("CONSTRAINT_NAME")]
		public string ConstraintName {get; set;}

	}
}
