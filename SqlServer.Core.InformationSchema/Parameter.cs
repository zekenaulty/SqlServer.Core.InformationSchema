using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each parameter of a user-defined function or stored procedure that can be accessed by the current user in the current database. For functions, this view also returns one row with return value information.
    /// </summary>
	[Table("PARAMETERS", Schema="INFORMATION_SCHEMA")]
	public class Parameter
	{
        /// <summary>
        /// Catalog name of the routine for which this is a parameter.
        /// </summary>
		[Column("SPECIFIC_CATALOG")]
		public string SpecificCatalog {get; set;}

        /// <summary>
        /// Name of the schema of the routine for which this is a parameter.
        /// </summary>
		[Column("SPECIFIC_SCHEMA")]
		public string SpecificSchema {get; set; }

        /// <summary>
        /// Name of the routine for which this is a parameter.
        /// </summary>
		[Column("SPECIFIC_NAME")]
		public string SpecificName {get; set; }

        /// <summary>
        /// Ordinal position of the parameter starting at 1. For the return value of a function, this is a 0.
        /// </summary>
		[Column("ORDINAL_POSITION")]
		public int? OrdinalPosition {get; set; }

        /// <summary>
        /// Returns IN if an input parameter, OUT if an output parameter, and INOUT if an input/output parameter.
        /// </summary>
		[Column("PARAMETER_MODE")]
		public string ParameterMode {get; set; }

        /// <summary>
        /// Returns YES if indicates result of the routine that is a function. Otherwise, returns NO.
        /// </summary>
		[Column("IS_RESULT")]
		public string IsResult {get; set; }

        /// <summary>
        /// Returns YES if declared as locator. Otherwise, returns NO.
        /// </summary>
		[Column("AS_LOCATOR")]
		public string AsLocator {get; set; }

        /// <summary>
        /// Name of the parameter. NULL if this corresponds to the return value of a function.
        /// </summary>
		[Column("PARAMETER_NAME")]
		public string ParameterName {get; set; }

        /// <summary>
        /// System-supplied data type.
        /// </summary>
		[Column("DATA_TYPE")]
		public string DataType {get; set; }

        /// <summary>
        /// Maximum length in characters for binary or character data types.
        /// </summary>
		[Column("CHARACTER_MAXIMUM_LENGTH")]
		public int? CharacterMaximumLength {get; set; }

        /// <summary>
        /// Maximum length, in bytes, for binary or character data types.
        /// </summary>
		[Column("CHARACTER_OCTET_LENGTH")]
		public int? CharacterOctetLength {get; set; }

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
        /// Name of the collation of the parameter. If not one of the character types, returns NULL
        /// </summary>
		[Column("COLLATION_NAME")]
		public string CollationName {get; set; }

        /// <summary>
        /// Catalog name of the character set of the parameter. If not one of the character types, returns NULL
        /// </summary>
		[Column("CHARACTER_SET_CATALOG")]
		public string CharacterSetCatalog {get; set; }

        /// <summary>
        /// Always returns NULL
        /// </summary>
		[Column("CHARACTER_SET_SCHEMA")]
		public string CharacterSetSchema {get; set; }

        /// <summary>
        /// Name of the character set of the parameter. If not one of the character types, returns NULL
        /// </summary>
		[Column("CHARACTER_SET_NAME")]
		public string CharacterSetName {get; set; }

        /// <summary>
        /// Precision of approximate numeric data, exact numeric data, integer data, or monetary data. Otherwise, returns NULL
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
        /// Precision in fractional seconds if the parameter type is datetime or smalldatetime. Otherwise, returns NULL
        /// </summary>
		[Column("DATETIME_PRECISION")]
		public short? DatetimePrecision {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("INTERVAL_TYPE")]
		public string IntervalType {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("INTERVAL_PRECISION")]
		public short? IntervalPrecision {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("USER_DEFINED_TYPE_CATALOG")]
		public string UserDefinedTypeCatalog {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("USER_DEFINED_TYPE_SCHEMA")]
		public string UserDefinedTypeSchema {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("USER_DEFINED_TYPE_NAME")]
		public string UserDefinedTypeName {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("SCOPE_CATALOG")]
		public string ScopeCatalog {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("SCOPE_SCHEMA")]
		public string ScopeSchema {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("SCOPE_NAME")]
		public string ScopeName {get; set;}
	}
}
