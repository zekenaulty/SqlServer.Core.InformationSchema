using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{

    /// <summary>
    /// Returns one row for each column returned by the table-valued functions that can be accessed by the current user in the current database.
    /// </summary>
    [Table("ROUTINE_COLUMNS", Schema="INFORMATION_SCHEMA")]
	public class RoutineColumn
    {

        /// <summary>
        /// Catalog or database name of the table-valued function.
        /// </summary>
        [Column("TABLE_CATALOG")]
		public string TableCatalog {get; set; }

        /// <summary>
        /// Name of the schema that contains the table-valued function.
        /// </summary>
        [Column("TABLE_SCHEMA")]
		public string TableSchema {get; set; }

        /// <summary>
        /// Name of the table-valued function.
        /// </summary>
        [Column("TABLE_NAME")]
		public string TableName {get; set; }

        /// <summary>
        /// Column name
        /// </summary>
        [Column("COLUMN_NAME")]
		public string ColumnName {get; set; }

        /// <summary>
        /// Column identification number
        /// </summary>
        [Column("ORDINAL_POSITION")]
		public int? OrdinalPosition {get; set; }

        /// <summary>
        /// Default value of the column
        /// </summary>
        [Column("COLUMN_DEFAULT")]
		public string ColumnDefault {get; set; }

        /// <summary>
        /// If this column allows for NULL, returns YES. Otherwise, returns NO
        /// </summary>
        [Column("IS_NULLABLE")]
		public string IsNullable {get; set; }

        /// <summary>
        /// System-supplied data type
        /// </summary>
        [Column("DATA_TYPE")]
		public string DataType {get; set; }

        /// <summary>
        /// Maximum length, in characters, for binary data, character data, or text and image data
        /// </summary>
        [Column("CHARACTER_MAXIMUM_LENGTH")]
		public int? CharacterMaximumLength {get; set; }

        /// <summary>
        /// Maximum length, in bytes, for binary data, character data, or text and image data
        /// </summary>
        [Column("CHARACTER_OCTET_LENGTH")]
		public int? CharacterOctetLength {get; set; }

        /// <summary>
        /// Precision of approximate numeric data, exact numeric data, integer data, or monetary data. Otherwise, returns NULL.
        /// </summary>
        [Column("NUMERIC_PRECISION")]
		public byte? NumericPrecision {get; set; }

        /// <summary>
        /// Precision radix of approximate numeric data, exact numeric data, integer data, or monetary data. Otherwise, returns NULL
        /// </summary>
        [Column("NUMERIC_PRECISION_RADIX")]
		public short? NumericPrecisionRadix {get; set; }

        /// <summary>
        /// Scale of approximate numeric data, exact numeric data, integer data, or monetary data. Otherwise, returns NULL
        /// </summary>
        [Column("NUMERIC_SCALE")]
		public int? NumericScale {get; set; }

        /// <summary>
        /// Subtype code for datetime and ISOinteger data types. For other data types, returns NULL
        /// </summary>
        [Column("DATETIME_PRECISION")]
		public short? DatetimePrecision {get; set; }

        /// <summary>
        /// eturns master. This indicates the database in which the character set is located if the column is character data or text data type. Otherwise, returns NULL.
        /// </summary>
        [Column("CHARACTER_SET_CATALOG")]
		public string CharacterSetCatalog {get; set; }

        /// <summary>
        /// Always returns NULL
        /// </summary>
        [Column("CHARACTER_SET_SCHEMA")]
		public string CharacterSetSchema {get; set; }

        /// <summary>
        /// Returns the unique name for the character set if this column is character data or text data type. Otherwise, returns NULL
        /// </summary>
        [Column("CHARACTER_SET_NAME")]
		public string CharacterSetName {get; set; }

        /// <summary>
        /// Always returns NULL
        /// </summary>
        [Column("COLLATION_CATALOG")]
		public string CollationCatalog {get; set; }

        /// <summary>
        /// Always returns NULL
        /// </summary>
        [Column("COLLATION_SCHEMA")]
		public string CollationSchema {get; set; }

        /// <summary>
        /// Returns the unique name for the sort order if the column is character data or text data type. Otherwise, returns NULL
        /// </summary>
        [Column("COLLATION_NAME")]
		public string CollationName {get; set; }

        /// <summary>
        /// If the column is an alias data type, this column is the database name in which the user-defined data type was created. Otherwise, returns NULL
        /// </summary>
        [Column("DOMAIN_CATALOG")]
		public string DomainCatalog {get; set; }

        /// <summary>
        /// If the column is a user-defined data type, this column is the name of the schema that contains the user-defined data type. Otherwise, returns NULL
        /// </summary>
        [Column("DOMAIN_SCHEMA")]
		public string DomainSchema {get; set; }

        /// <summary>
        /// If the column is a user-defined data type, this column is the name of the user-defined data type. Otherwise, returns NULL
        /// </summary>
        [Column("DOMAIN_NAME")]
		public string DomainName {get; set;}
	}
}
