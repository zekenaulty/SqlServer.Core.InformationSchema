using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each alias data type that can be accessed by the current user in the current database.
    /// </summary>
    /// <remarks>My code generator will not attempt to map your crazy custom types.</remarks>
    [Table("DOMAINS", Schema="INFORMATION_SCHEMA")]
	public class Domain
	{
        /// <summary>
        /// Database in which the alias data type exists.
        /// </summary>
		[Column("DOMAIN_CATALOG")]
		public string DomainCatalog {get; set; }

        /// <summary>
        /// Name of the schema that contains the alias data type.
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
        /// System-supplied data type.
        /// </summary>
		[Column("DATA_TYPE")]
		public string DataType {get; set;}

        /// <summary>
        /// Maximum length, in characters, for binary data, character data, or text and image data.
        /// </summary>
		[Column("CHARACTER_MAXIMUM_LENGTH")]
		public int? CharacterMaximumLength {get; set;}

        /// <summary>
        /// Maximum length, in bytes, for binary data, character data, or text and image data.
        /// </summary>
		[Column("CHARACTER_OCTET_LENGTH")]
		public int? CharacterOctetLength {get; set;}

        /// <summary>
        /// Always returns NULL.
        /// </summary>
		[Column("COLLATION_CATALOG")]
		public string CollationCatalog {get; set;}

        /// <summary>
        /// Always returns NULL.
        /// </summary>
		[Column("COLLATION_SCHEMA")]
		public string CollationSchema {get; set;}

        /// <summary>
        /// Returns the unique name for the sort order if the column is character data or text data type. Otherwise, NULL is returned.
        /// </summary>
		[Column("COLLATION_NAME")]
		public string CollationName {get; set;}

        /// <summary>
        /// Returns master. This indicates the database in which the character set is located, if the column is character data or text data type. Otherwise, NULL is returned.
        /// </summary>
		[Column("CHARACTER_SET_CATALOG")]
		public string CharacterSetCatalog {get; set;}

        /// <summary>
        /// Always returns NULL.
        /// </summary>
		[Column("CHARACTER_SET_SCHEMA")]
		public string CharacterSetSchema {get; set;}

        /// <summary>
        /// Returns the unique name for the character set if this column is character data or text data type. Otherwise, NULL is returned.
        /// </summary>
		[Column("CHARACTER_SET_NAME")]
		public string CharacterSetName {get; set;}

        /// <summary>
        /// Precision of approximate numeric data, exact numeric data, integer data, or monetary data. Otherwise, NULL is returned.
        /// </summary>
		[Column("NUMERIC_PRECISION")]
		public byte? NumericPrecision {get; set;}

        /// <summary>
        /// Precision radix of approximate numeric data, exact numeric data, integer data, or monetary data. Otherwise, NULL is returned.
        /// </summary>
		[Column("NUMERIC_PRECISION_RADIX")]
		public short? NumericPrecisionRadix {get; set;}

        /// <summary>
        /// Scale of approximate numeric data, exact numeric data, integer data, or monetary data. Otherwise, NULL is returned.
        /// </summary>
		[Column("NUMERIC_SCALE")]
		public int? NumericScale {get; set;}

        /// <summary>
        /// Subtype code for datetime and ISO interval data type. For other data types, this column returns a NULL.
        /// </summary>
		[Column("DATETIME_PRECISION")]
		public short? DatetimePrecision {get; set;}

        /// <summary>
        /// Actual text of the definition Transact-SQL statement.
        /// </summary>
		[Column("DOMAIN_DEFAULT")]
		public string DomainDefault {get; set;}

	}
}
