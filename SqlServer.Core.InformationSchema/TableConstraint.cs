using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{

    /// <summary>
    /// Returns one row for each table constraint in the current database. This information schema view returns information about the objects to which the current user has permissions
    /// </summary>
	[Table("TABLE_CONSTRAINTS", Schema="INFORMATION_SCHEMA")]
	public class TableConstraint
    {

        /// <summary>
        /// Constraint qualifier
        /// </summary>
        [Column("CONSTRAINT_CATALOG")]
		public string ConstraintCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the constraint.
        /// </summary>
        [Column("CONSTRAINT_SCHEMA")]
		public string ConstraintSchema {get; set; }

        /// <summary>
        /// Constraint name
        /// </summary>
        [Column("CONSTRAINT_NAME")]
		public string ConstraintName {get; set; }

        /// <summary>
        /// Table qualifier
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
        /// Type of constraint:
        /// <CHECK
        /// <UNIQUE
        /// <PRIMARY KEY
        /// <FOREIGN KEY
        /// </summary>
        [Column("CONSTRAINT_TYPE")]
		public string ConstraintType {get; set; }

        /// <summary>
        /// Specifies whether constraint checking is deferrable. Always returns NO
        /// </summary>
        [Column("IS_DEFERRABLE")]
		public string IsDeferrable {get; set; }

        /// <summary>
        /// Specifies whether constraint checking is at first deferred. Always returns NO
        /// </summary>
        [Column("INITIALLY_DEFERRED")]
		public string InitiallyDeferred {get; set;}
	}
}
