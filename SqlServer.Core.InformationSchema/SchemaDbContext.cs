using Microsoft.EntityFrameworkCore;

namespace SqlServer.Core.InformationSchema
{   //https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
    //https://msdn.microsoft.com/en-us/library/ff649690.aspx
    //https://softwareengineering.stackexchange.com/questions/180851/why-shouldnt-i-use-the-repository-pattern-with-entity-framework
    // ^ I agree with the answer that states don't do it, DbContext is your Repo why add another layer
    //   But, in order to support unit testing in your business layer you need your data layer to support testability or it needs to be completely decoupled

    /// <summary>
    /// An information schema view is one of several methods SQL Server provides for obtaining metadata. Information schema views provide an internal, system table-independent view of the SQL Server metadata. 
    /// Information schema views enable applications to work correctly although significant changes have been made to the underlying system tables. The information schema views included in SQL Server comply 
    /// with the ISO standard definition for the INFORMATION_SCHEMA.
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-information-schema-views/system-information-schema-views-transact-sql
    /// </summary>
    /// <remarks>
    /// It's important to note that I use a mix of fluent and attribute based descriptors.
    /// </remarks>
    public class SchemaDbContext : DbContext
    {
        #region Allow Connection to any SqlServer
        public SchemaDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        #endregion

        //fluent mapping of keys
        //these keys serve no purpose other than being required by EF
        //as we are working against read-only views
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //map InformationSchema.CheckConstraint Keys
            modelBuilder.Entity<CheckConstraint>().HasKey(constraint => new {
                constraint.ConstraintCatalog,
                constraint.ConstraintSchema,
                constraint.ConstraintName
            });

            //map InformationSchema.Column Keys
            modelBuilder.Entity<Column>().HasKey(column => new {
                column.TableCatalog,
                column.TableSchema,
                column.TableName,
                column.ColumnName
            });

            //map InformationSchema.ColumnDomainUsage Keys
            modelBuilder.Entity<ColumnDomainUsage>().HasKey(columnDomainUsage => new {
                columnDomainUsage.DomainCatalog,
                columnDomainUsage.DomainSchema,
                columnDomainUsage.DomainName,
                columnDomainUsage.TableCatalog,
                columnDomainUsage.TableSchema,
                columnDomainUsage.TableName,
                columnDomainUsage.ColumnName
            });

            //map InformationSchema.ColumnDomainUsage Keys
            //this is a strange little view, you can  (as I do) consider each row a key
            modelBuilder.Entity<ColumnPrivilege>().HasKey(columnPrivilege => new {
                columnPrivilege.Grantor,
                columnPrivilege.Grantee,
                columnPrivilege.PrivilegeType,
                columnPrivilege.TableCatalog,
                columnPrivilege.TableSchema,
                columnPrivilege.TableName,
                columnPrivilege.ColumnName
            });

            //map InformationSchema.ConstraintColumnUsage
            modelBuilder.Entity<ConstraintColumnUsage>().HasKey(constraintColumnUsage => new {
                constraintColumnUsage.TableCatalog,
                constraintColumnUsage.TableSchema,
                constraintColumnUsage.TableName,
                constraintColumnUsage.ColumnName,
                constraintColumnUsage.ConstraintSchema,
                constraintColumnUsage.ConstraintName
            });

            //map InformationSchema.ConstraintColumnUsage
            modelBuilder.Entity<ConstraintTableUsage>().HasKey(constraintTableUsage => new {
                constraintTableUsage.TableCatalog,
                constraintTableUsage.TableSchema,
                constraintTableUsage.TableName,
                constraintTableUsage.ConstraintSchema,
                constraintTableUsage.ConstraintName
            });

            //map InformationSchema.Domain
            modelBuilder.Entity<Domain>().HasKey(domain => new {
                domain.DomainCatalog,
                domain.DomainSchema,
                domain.DomainName
            });

            //map InformationSchema.DomainConstraint
            modelBuilder.Entity<DomainConstraint>().HasKey(domainConstraint => new {
                domainConstraint.ConstraintCatalog,
                domainConstraint.ConstraintSchema,
                domainConstraint.ConstraintName,
                domainConstraint.DomainCatalog,
                domainConstraint.DomainSchema,
                domainConstraint.DomainName
            });

            //map InformationSchema.KeyColumnUsage
            modelBuilder.Entity<KeyColumnUsage>().HasKey(keyColumnUsage => new {
                keyColumnUsage.ConstraintCatalog,
                keyColumnUsage.ConstraintSchema,
                keyColumnUsage.ConstraintName,
                keyColumnUsage.TableCatalog,
                keyColumnUsage.TableSchema,
                keyColumnUsage.TableName
            });

            //map InformationSchema.Parameter
            modelBuilder.Entity<Parameter>().HasKey(parameter => new {
                parameter.SpecificCatalog,
                parameter.SpecificSchema,
                parameter.SpecificName,
                parameter.OrdinalPosition,
                parameter.ParameterName
            });

            //map InformationSchema.ReferentialConstraint
            modelBuilder.Entity<ReferentialConstraint>().HasKey(referentialConstraint => new {
                referentialConstraint.ConstraintCatalog,
                referentialConstraint.ConstraintSchema,
                referentialConstraint.ConstraintName,
                referentialConstraint.UniqueConstraintCatalog,
                referentialConstraint.UniqueConstraintSchema,
                referentialConstraint.UniqueConstraintName
            });

            //map InformationSchema.Routine
            modelBuilder.Entity<Routine>().HasKey(routine => new {
                routine.SpecificCatalog,
                routine.SpecificSchema,
                routine.SpecificName,
                routine.RoutineCatalog,
                routine.RoutineSchema,
                routine.RoutineName
            });

            //map InformationSchema.RoutineColumn
            modelBuilder.Entity<RoutineColumn>().HasKey(routineColumn => new {
                routineColumn.TableCatalog,
                routineColumn.TableSchema,
                routineColumn.TableName,
                routineColumn.ColumnName,
                routineColumn.OrdinalPosition
            });

            //map InformationSchema.Schema
            modelBuilder.Entity<Schema>().HasKey(schema => new {
                schema.CatalogName,
                schema.SchemaName,
                schema.SchemaOwner
            });

            //map InformationSchema.Table Keys
            modelBuilder.Entity<Table>().HasKey(table => new {
                table.TableCatalog,
                table.TableSchema,
                table.TableName
            });

            //map InformationSchema.TableConstraint Keys
            modelBuilder.Entity<TableConstraint>().HasKey(tableConstraint => new {
                tableConstraint.ConstraintCatalog,
                tableConstraint.ConstraintSchema,
                tableConstraint.ConstraintName,
                tableConstraint.TableCatalog,
                tableConstraint.TableSchema,
                tableConstraint.TableName
            });

            //map InformationSchema.TablePrivilege Keys
            modelBuilder.Entity<TablePrivilege>().HasKey(tablePrivilege => new {
                tablePrivilege.Grantor,
                tablePrivilege.Grantee,
                tablePrivilege.TableCatalog,
                tablePrivilege.TableSchema,
                tablePrivilege.TableName,
                tablePrivilege.PrivilegeType
            });

            //map InformationSchema.View Keys
            modelBuilder.Entity<View>().HasKey(view => new {
                view.TableCatalog,
                view.TableSchema,
                view.TableName
            });

            //map InformationSchema.ViewColumnUsage Keys
            modelBuilder.Entity<ViewColumnUsage>().HasKey(viewColumnUsage => new {
                viewColumnUsage.ViewCatalog,
                viewColumnUsage.ViewSchema,
                viewColumnUsage.ViewName,
                viewColumnUsage.TableCatalog,
                viewColumnUsage.TableSchema,
                viewColumnUsage.TableName,
                viewColumnUsage.ColumnName
            });

            //map InformationSchema.ViewTableUsage Keys
            modelBuilder.Entity<ViewTableUsage>().HasKey(viewTableUsage => new {
                viewTableUsage.ViewCatalog,
                viewTableUsage.ViewSchema,
                viewTableUsage.ViewName,
                viewTableUsage.TableCatalog,
                viewTableUsage.TableSchema,
                viewTableUsage.TableName
            });

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Returns one row for each CHECK constraint in the current database. This information schema view returns information about the objects to which the current user has permissions
        /// </summary>
        public DbSet<CheckConstraint> CheckContraints { get; set; }

        /// <summary>
        /// Returns one row for each column in the current database that has an alias data type. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<ColumnDomainUsage> ColumnDomainUsages { get; set; }

        /// <summary>
        /// Returns one row for each column that has a privilege that is either granted to or granted by the current user in the current databas
        /// </summary>
        public DbSet<ColumnPrivilege> ColumnPrivileges { get; set; }

        /// <summary>
        /// Returns one row for each column that can be accessed by the current user in the current database.
        /// </summary>
        public DbSet<Column> Columns { get; set; }

        /// <summary>
        /// Returns one row for each column in the current database that has a constraint defined on the column. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<ConstraintColumnUsage> ConstraintColumnUsages { get; set; }

        /// <summary>
        /// Returns one row for each table in the current database that has a constraint defined on the table. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<ConstraintTableUsage> ConstraintTableUsages { get; set; }

        /// <summary>
        /// Returns one row for each alias data type in the current database that has a rule bound to it and that can be accessed by current user.
        /// </summary>
        public DbSet<DomainConstraint> DomainConstraints { get; set; }

        /// <summary>
        /// Returns one row for each alias data type that can be accessed by the current user in the current database.
        /// </summary>
        public DbSet<Domain> Domains { get; set; }

        /// <summary>
        /// Returns one row for each column that is constrained as a key in the current database. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<KeyColumnUsage> KeyColumnUsages { get; set; }

        /// <summary>
        /// Returns one row for each parameter of a user-defined function or stored procedure that can be accessed by the current user in the current database. For functions, this view also returns one row with return value information.
        /// </summary>
        public DbSet<Parameter> Parameters { get; set; }

        /// <summary>
        /// Returns one row for each FOREIGN KEY constraint in the current database. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<ReferentialConstraint> ReferentialConstraints { get; set; }

        /// <summary>
        /// Returns one row for each stored procedure and function that can be accessed by the current user in the current database. The columns that describe the return value apply only to functions. For stored procedures, these columns will be NULL.
        /// </summary>
        public DbSet<Routine> Routines { get; set; }

        /// <summary>
        /// Returns one row for each column returned by the table-valued functions that can be accessed by the current user in the current database
        /// </summary>
        public DbSet<RoutineColumn> RoutineColumns { get; set; }

        /// <summary>
        /// Returns one row for each schema in the current database. To retrieve information from these views, specify the fully qualified name of INFORMATION_SCHEMA.view_name. To retrieve information about all databases in an instance of SQL Server, query the sys.databases (Transact-SQL) catalog view.
        /// </summary>
        public DbSet<Schema> Schemata { get; set; }

        /// <summary>
        /// Returns one row for each table constraint in the current database. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<TableConstraint> TableConstraints { get; set; }

        /// <summary>
        /// Returns one row for each table privilege that is granted to or granted by the current user in the current database.
        /// </summary>
        public DbSet<TablePrivilege> TablePrivileges { get; set; }

        /// <summary>
        /// Returns one row for each table in the current database for which the current user has permissions.
        /// </summary>
        public DbSet<Table> Tables { get; set; }

        /// <summary>
        /// Returns one row for each column in the current database that is used in a view definition. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<ViewColumnUsage> ViewColumnUsages { get; set; }

        /// <summary>
        /// Returns one row for each table in the current database that is used in a view. This information schema view returns information about the objects to which the current user has permissions.
        /// </summary>
        public DbSet<ViewTableUsage> ViewTableUsages { get; set; }

        /// <summary>
        /// Returns one row for views that can be accessed by the current user in the current database.
        /// </summary>
        public DbSet<View> Views { get; set; }

        /// <summary>
        /// Disabled.
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges() { return 0; }

    }
}
