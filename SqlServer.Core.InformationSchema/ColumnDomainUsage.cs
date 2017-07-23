using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// 
    /// </summary>
	[Table("COLUMN_DOMAIN_USAGE", Schema="INFORMATION_SCHEMA")]
	public class ColumnDomainUsage
	{
        /// <summary>
        /// Database in which the alias data type exists.
        /// </summary>
		[Column("DOMAIN_CATALOG")]
		public string DomainCatalog {get; set;}

        /// <summary>
        /// Name of schema that contains the alias data type.
        /// ** Important *\* Do not use INFORMATION_SCHEMA views to determine the schema of a data type. The only reliable way to find the schema of a type is to use the TYPEPROPERTY function.
        /// </summary>
		[Column("DOMAIN_SCHEMA")]
		public string DomainSchema {get; set;}

        /// <summary>
        /// Alias data type.
        /// </summary>
		[Column("DOMAIN_NAME")]
		public string DomainName {get; set;}

        /// <summary>
        /// Table qualifier.
        /// </summary>
		[Column("TABLE_CATALOG")]
		public string TableCatalog {get; set;}

        /// <summary>
        /// Table owner.
        /// ** Important *\* Do not use INFORMATION_SCHEMA views to determine the schema of an object. The only reliable way to find the schema of a object is to query the sys.objects catalog view.
        /// </summary>
		[Column("TABLE_SCHEMA")]
		public string TableSchema {get; set;}

        /// <summary>
        /// Table in which the alias data type is used.
        /// </summary>
		[Column("TABLE_NAME")]
		public string TableName {get; set;}

        /// <summary>
        /// Column using the alias data type.
        /// </summary>
		[Column("COLUMN_NAME")]
		public string ColumnName {get; set;}
	}
}
