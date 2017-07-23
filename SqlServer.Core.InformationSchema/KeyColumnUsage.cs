using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each column that is constrained as a key in the current database. This information schema view returns information about the objects to which the current user has permissions.
    /// </summary>
	[Table("KEY_COLUMN_USAGE", Schema="INFORMATION_SCHEMA")]
	public class KeyColumnUsage
	{
        /// <summary>
        /// Constraint qualifier.
        /// </summary>
		[Column("CONSTRAINT_CATALOG")]
		public string ConstraintCatalog {get; set;}

        /// <summary>
        /// Name of schema that contains the constraint.
        /// </summary>
		[Column("CONSTRAINT_SCHEMA")]
		public string ConstraintSchema {get; set;}

        /// <summary>
        /// Constraint name.
        /// </summary>
		[Column("CONSTRAINT_NAME")]
		public string ConstraintName {get; set;}

        /// <summary>
        /// Table qualifier.
        /// </summary>
		[Column("TABLE_CATALOG")]
		public string TableCatalog {get; set;}

        /// <summary>
        /// Name of schema that contains the table.
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
        /// Column ordinal position.
        /// </summary>
		[Column("ORDINAL_POSITION")]
		public int? OrdinalPosition {get; set;}

	}
}
