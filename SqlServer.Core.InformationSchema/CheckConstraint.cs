using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// The CHECK constraint is used to limit the value range that can be placed in a column.
    /// If you define a CHECK constraint on a single column it allows only certain values for this column.
    /// If you define a CHECK constraint on a table it can limit the values in certain columns based on values in other columns in the row.
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-information-schema-views/check-constraints-transact-sql
    /// https://www.w3schools.com/sql/sql_check.asp
    /// </summary>
    [Table("CHECK_CONSTRAINTS", Schema="INFORMATION_SCHEMA")]
	public class CheckConstraint
	{
        /// <summary>
        /// Constraint qualifier.
        /// </summary>
		[Column("CONSTRAINT_CATALOG")]
		public string ConstraintCatalog {get; set; }

        /// <summary>
        /// Name of the schema to which the constraint belongs.
        /// ** Important*\* Do not use INFORMATION_SCHEMA views to determine the schema of an object. 
        /// The only reliable way to find the schema of a object is to query the sys.objects catalog view.
        /// </summary>
        [Column("CONSTRAINT_SCHEMA")]
		public string ConstraintSchema {get; set;}

        /// <summary>
        /// Constraint name.
        /// </summary>
		[Column("CONSTRAINT_NAME")]
		public string ConstraintName {get; set;}

        /// <summary>
        /// Actual text of the Transact-SQL definition statement.
        /// </summary>
		[Column("CHECK_CLAUSE")]
		public string CheckClause {get; set;}
	}
}
