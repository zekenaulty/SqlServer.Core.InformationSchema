using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each alias data type in the current database that has a rule bound to it and that can be accessed by current user.
    /// </summary>
    [Table("DOMAIN_CONSTRAINTS", Schema="INFORMATION_SCHEMA")]
	public class DomainConstraint
	{

        /// <summary>
        /// Database in which the rule exists.
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
        /// Rule name.
        /// </summary>
		[Column("CONSTRAINT_NAME")]
		public string ConstraintName {get; set;}

        /// <summary>
        /// Database in which the alias data type exists.
        /// </summary>
		[Column("DOMAIN_CATALOG")]
		public string DomainCatalog {get; set; }

        /// <summary>
        /// Name of schema that contains the alias data type.
        /// ** Important*\* Do not use INFORMATION_SCHEMA views to determine the schema of a data type.The only reliable way to find the schema of a type is to use the TYPEPROPERTY function.
        /// </summary>
        [Column("DOMAIN_SCHEMA")]
		public string DomainSchema {get; set;}

        /// <summary>
        /// Alias data type.
        /// </summary>
		[Column("DOMAIN_NAME")]
		public string DomainName {get; set;}

        /// <summary>
        /// Specifies whether constraint checking is deferrable. Always returns NO.
        /// </summary>
		[Column("IS_DEFERRABLE")]
		public string IsDeferrable {get; set;}

        /// <summary>
        /// Specifies whether constraint checking is at first deferred. Always returns NO.
        /// </summary>
		[Column("INITIALLY_DEFERRED")]
		public string InitiallyDeferred {get; set;}
	}
}
