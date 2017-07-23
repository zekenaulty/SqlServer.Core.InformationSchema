using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServer.Core.InformationSchema
{
    /// <summary>
    /// Returns one row for each stored procedure and function that can be accessed by the current user in the current database. The columns that describe the return value apply only to functions. For stored procedures, these columns will be NULL.
    /// </summary>
    /// <remarks>
    /// The ROUTINE_DEFINITION column contains the source statements that created the function or stored procedure. 
    /// These source statements are likely to contain embedded carriage returns. If you are returning this column to 
    /// an application that displays the results in a text format, the embedded carriage returns in the ROUTINE_DEFINITION 
    /// results may affect the formatting of the overall result set. 
    /// 
    /// If you select the ROUTINE_DEFINITION column, you must adjust for the embedded carriage returns; 
    /// for example, by returning the result set into a grid or returning ROUTINE_DEFINITION into its own text box.
    /// </remarks>
	[Table("ROUTINES", Schema="INFORMATION_SCHEMA")]
	public class Routine
	{

        /// <summary>
        /// Specific name of the catalog. This name is the same as ROUTINE_CATALOG
        /// </summary>
		[Column("SPECIFIC_CATALOG")]
		public string SpecificCatalog {get; set; }

        /// <summary>
        /// Specific name of the schema.
        /// </summary>
		[Column("SPECIFIC_SCHEMA")]
		public string SpecificSchema {get; set; }

        /// <summary>
        /// Specific name of the catalog. This name is the same as ROUTINE_NAME
        /// </summary>
		[Column("SPECIFIC_NAME")]
		public string SpecificName {get; set; }

        /// <summary>
        /// Catalog name of the function
        /// </summary>
		[Column("ROUTINE_CATALOG")]
		public string RoutineCatalog {get; set; }

        /// <summary>
        /// Name of the schema that contains this function
        /// </summary>
		[Column("ROUTINE_SCHEMA")]
		public string RoutineSchema {get; set; }

        /// <summary>
        /// Name of the function
        /// </summary>
		[Column("ROUTINE_NAME")]
		public string RoutineName {get; set; }

        /// <summary>
        /// Returns PROCEDURE for stored procedures, and FUNCTION for functions
        /// </summary>
		[Column("ROUTINE_TYPE")]
		public string RoutineType {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("MODULE_CATALOG")]
		public string ModuleCatalog {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("MODULE_SCHEMA")]
		public string ModuleSchema {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("MODULE_NAME")]
		public string ModuleName {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("UDT_CATALOG")]
		public string UdtCatalog {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("UDT_SCHEMA")]
		public string UdtSchema {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("UDT_NAME")]
		public string UdtName {get; set; }

        /// <summary>
        /// Data type of the return value of the function. Returns table if a table-valued function.
        /// </summary>
		[Column("DATA_TYPE")]
		public string DataType {get; set; }

        /// <summary>
        /// Maximum length in characters, if the return type is a character type.
        /// </summary>
		[Column("CHARACTER_MAXIMUM_LENGTH")]
		public int? CharacterMaximumLength {get; set; }

        /// <summary>
        /// Maximum length in bytes, if the return type is a character type
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
        /// Collation name of the return value. For noncharacter types, returns NULL.
        /// </summary>
		[Column("COLLATION_NAME")]
		public string CollationName {get; set; }

        /// <summary>
        /// Always returns NULL
        /// </summary>
		[Column("CHARACTER_SET_CATALOG")]
		public string CharacterSetCatalog {get; set; }

        /// <summary>
        /// Always returns NULL
        /// </summary>
		[Column("CHARACTER_SET_SCHEMA")]
		public string CharacterSetSchema {get; set; }

        /// <summary>
        /// Name of the character set of the return value. For noncharacter types, returns NULL.
        /// </summary>
		[Column("CHARACTER_SET_NAME")]
		public string CharacterSetName {get; set; }

        /// <summary>
        /// Numeric precision of the return value. For the nonnumeric types, returns NULL.
        /// </summary>
		[Column("NUMERIC_PRECISION")]
		public byte? NumericPrecision {get; set; }

        /// <summary>
        /// Numeric precision of the return raidx. For the nonnumeric types, returns NULL.
        /// </summary>
		[Column("NUMERIC_PRECISION_RADIX")]
		public short? NumericPrecisionRadix {get; set; }

        /// <summary>
        /// Scale of the return value. For nonnumeric types, returns NULL
        /// </summary>
		[Column("NUMERIC_SCALE")]
		public int? NumericScale {get; set; }

        /// <summary>
        /// Fractional precision of a second if the return value is of type datetime. Otherwise, returns NULL.
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
		[Column("TYPE_UDT_CATALOG")]
		public string TypeUdtCatalog {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("TYPE_UDT_SCHEMA")]
		public string TypeUdtSchema {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("TYPE_UDT_NAME")]
		public string TypeUdtName {get; set; }

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
		public string ScopeName {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("MAXIMUM_CARDINALITY")]
		public long? MaximumCardinality {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("DTD_IDENTIFIER")]
		public string DtdIdentifier {get; set; }

        /// <summary>
        /// Returns SQL for a Transact-SQL function and EXTERNAL for an externally written function.
        /// </summary>
		[Column("ROUTINE_BODY")]
		public string RoutineBody {get; set; }

        /// <summary>
        /// Returns the first 4000 characters of the definition text of the function or stored procedure if the function or stored procedure is not encrypted. Otherwise, returns NULL.
        /// To ensure that you obtain the complete definition, query the OBJECT_DEFINITION function or the definition column in the sys.sql_modules catalog view.
        /// </summary>
        [Column("ROUTINE_DEFINITION")]
		public string RoutineDefinition {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("EXTERNAL_NAME")]
		public string ExternalName {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("EXTERNAL_LANGUAGE")]
		public string ExternalLanguage {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("PARAMETER_STYLE")]
		public string ParameterStyle {get; set; }

        /// <summary>
        /// Returns YES if the routine is deterministic.
        /// Returns NO if the routine is nondeterministic.
        /// Always returns NO for stored procedures.
        /// </summary>
        [Column("IS_DETERMINISTIC")]
		public string IsDeterministic {get; set; }

        /// <summary>
        /// Returns one of the following values:
        /// NONE = Function does not contain SQL.
        /// CONTAINS = Function possibly contains SQL.
        /// READS = Function possibly reads SQL data.
        /// MODIFIES = Function possibly modifies SQL data.
        /// Returns READS for all functions, and MODIFIES for all stored procedures.
        /// </summary>
        [Column("SQL_DATA_ACCESS")]
		public string SqlDataAccess {get; set; }

        /// <summary>
        /// Indicates whether the routine will be called if any one of its arguments is NULL
        /// </summary>
		[Column("IS_NULL_CALL")]
		public string IsNullCall {get; set; }

        /// <summary>
        /// NULL. Reserved for future use
        /// </summary>
		[Column("SQL_PATH")]
		public string SqlPath {get; set; }

        /// <summary>
        /// Returns YES if schema-level function, or NO if not a schema-level function.
        /// Always returns YES.
        /// </summary>
        [Column("SCHEMA_LEVEL_ROUTINE")]
		public string SchemaLevelRoutine {get; set; }

        /// <summary>
        /// Maximum number of dynamic result sets returned by routine. Returns 0 if functions.
        /// </summary>
        [Column("MAX_DYNAMIC_RESULT_SETS")]
		public short MaxDynamicResultSets {get; set; }

        /// <summary>
        /// Returns YES if user-defined cast function, and NO if not a user-defined cast function.
        /// Always returns NO.
        /// </summary>
        [Column("IS_USER_DEFINED_CAST")]
		public string IsUserDefinedCast {get; set; }

        /// <summary>
        /// Returns YES if the routine can be implicitly invoked, and NO if function cannot be implicitly invoked.
        /// Always returns NO
        /// </summary>
        [Column("IS_IMPLICITLY_INVOCABLE")]
		public string IsImplicitlyInvocable {get; set; }

        /// <summary>
        /// Time when the routine was created.
        /// </summary>
		[Column("CREATED")]
		public DateTime Created {get; set; }

        /// <summary>
        /// The last time the function was modified.
        /// </summary>
		[Column("LAST_ALTERED")]
		public DateTime? LastAltered {get; set;}
	}
}
