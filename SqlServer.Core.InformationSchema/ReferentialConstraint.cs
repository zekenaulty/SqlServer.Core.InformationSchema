using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each FOREIGN KEY constraint in the current database. This information schema view returns information about the objects to which the current user has permissions
    /// </summary>
	[Table("REFERENTIAL_CONSTRAINTS", Schema="INFORMATION_SCHEMA")]
	public class ReferentialConstraint
	{
        /// <summary>
        /// Constraint qualifier.
        /// </summary>
		[Column("CONSTRAINT_CATALOG")]
		public string ConstraintCatalog {get; set;}

        /// <summary>
        /// Name of schema that contains the constraint
        /// </summary>
		[Column("CONSTRAINT_SCHEMA")]
		public string ConstraintSchema {get; set; }

        /// <summary>
        /// Constraint name.
        /// </summary>
		[Column("CONSTRAINT_NAME")]
		public string ConstraintName {get; set; }

        /// <summary>
        /// UNIQUE constraint qualifier.
        /// </summary>
		[Column("UNIQUE_CONSTRAINT_CATALOG")]
		public string UniqueConstraintCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the UNIQUE constraint
        /// </summary>
		[Column("UNIQUE_CONSTRAINT_SCHEMA")]
		public string UniqueConstraintSchema {get; set; }

        /// <summary>
        /// UNIQUE constraint
        /// </summary>
		[Column("UNIQUE_CONSTRAINT_NAME")]
		public string UniqueConstraintName {get; set; }

        /// <summary>
        /// Referential constraint-matching conditions. Always returns SIMPLE. This means that no match is defined. The condition is considered a match when one of the following is true:
        /// At least one value in the foreign key column is NULL.
        /// All values in the foreign key column are not NULL, and there is a row in the primary key table that has the same key.
        /// </summary>
        [Column("MATCH_OPTION")]
		public string MatchOption {get; set; }

        /// <summary>
        /// Action taken when a Transact-SQL statement violates the referential integrity that is defined by this constraint. Returns one of the following: 
        /// NO ACTION
        /// CASCADE
        /// SET NULL
        /// SET DEFAULT
        /// If NO ACTION is specified on ON UPDATE for this constraint, the update of the primary key that is referenced in the constraint will not be propagated to the foreign key.If such an update of a primary key will cause a referential integrity violation because at least one foreign key contains the same value, SQL Server will not make any change to the parent and referring tables.SQL Server also will raise an error.
        /// If CASCADE is specified on ON UPDATE for this constraint, any change to the primary key value is automatically propagated to the foreign key value.
        /// </summary>
		[Column("UPDATE_RULE")]
		public string UpdateRule {get; set; }

        /// <summary>
        /// Action taken when a Transact-SQL statement violates referential integrity defined by this constraint. Returns one of the following: 
        /// NO ACTION
        /// CASCADE
        /// SET NULL
        /// SET DEFAULT
        /// If NO ACTION is specified on ON DELETE for this constraint, the delete on the primary key that is referenced in the constraint will not be propagated to the foreign key.If such a delete of a primary key will cause a referential integrity violation because at least one foreign key contains the same value, SQL Server will not make any change to the parent and referring tables.SQL Server also will raise an error.
        /// If CASCADE is specified on ON DELETE on this constraint, any change to the primary key value is automatically propagated to the foreign key value.
        /// </summary>
		[Column("DELETE_RULE")]
		public string DeleteRule {get; set;}
	}
}
