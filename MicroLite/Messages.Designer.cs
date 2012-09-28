﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroLite {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MicroLite.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object cannot be inserted as it does not have an identifier value set and the identifier strategy specifies that it should be assigned before being inserted..
        /// </summary>
        internal static string AssignedListener_IdentifierNotSetForInsert {
            get {
                return ResourceManager.GetString("AssignedListener_IdentifierNotSetForInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property [{0}].[{1}] will not be mapped by MicroLite as it has no ColumnAttribute.
        /// </summary>
        internal static string AttributeMappingConvention_IgnoringProperty {
            get {
                return ResourceManager.GetString("AttributeMappingConvention_IgnoringProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type [{0}] cannot be used by MicroLite as is not decorated with a TableAttribute.
        /// </summary>
        internal static string AttributeMappingConvention_NoTableAttribute {
            get {
                return ResourceManager.GetString("AttributeMappingConvention_NoTableAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using logger [{0}].
        /// </summary>
        internal static string ConfigureExtensions_UsingLogger {
            get {
                return ResourceManager.GetString("ConfigureExtensions_UsingLogger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using mapping convention [{0}].
        /// </summary>
        internal static string ConfigureExtensions_UsingMappingConvention {
            get {
                return ResourceManager.GetString("ConfigureExtensions_UsingMappingConvention", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of parameters in the SQL statement and the number of specified parameter arguments should match. However [{0}] parameters used in the SQL statement and [{1}] parameter arguments were specified..
        /// </summary>
        internal static string ConnectionManager_ArgumentsCountMismatch {
            get {
                return ResourceManager.GetString("ConnectionManager_ArgumentsCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection was found in the app.config with the name [{0}].
        /// </summary>
        internal static string FluentConfiguration_ConnectionNotFound {
            get {
                return ResourceManager.GetString("FluentConfiguration_ConnectionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a session factory for connection named [{0}].
        /// </summary>
        internal static string FluentConfiguration_CreatingSessionFactory {
            get {
                return ResourceManager.GetString("FluentConfiguration_CreatingSessionFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading connection named [{0}] from app.config.
        /// </summary>
        internal static string FluentConfiguration_ReadingConnection {
            get {
                return ResourceManager.GetString("FluentConfiguration_ReadingConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object does not have an identifier value set so it cannot be updated.
        /// </summary>
        internal static string IListener_IdentifierNotSetForUpdate {
            get {
                return ResourceManager.GetString("IListener_IdentifierNotSetForUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object already has an identifier value so it cannot be inserted.
        /// </summary>
        internal static string IListener_IdentifierSetForInsert {
            get {
                return ResourceManager.GetString("IListener_IdentifierSetForInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting the identifier value for an instance of the type [{0}] to [{1}].
        /// </summary>
        internal static string IListener_SettingIdentifierValue {
            get {
                return ResourceManager.GetString("IListener_SettingIdentifierValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scalar query should return a single row with a single column.
        /// </summary>
        internal static string IncludeScalar_MultipleColumns {
            get {
                return ResourceManager.GetString("IncludeScalar_MultipleColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are multiple records returned in the results list, the single query should return a single row only.
        /// </summary>
        internal static string IncludeSingle_SingleResultExpected {
            get {
                return ResourceManager.GetString("IncludeSingle_SingleResultExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new instance of [{0}].
        /// </summary>
        internal static string ObjectBuilder_CreatingInstance {
            get {
                return ResourceManager.GetString("ObjectBuilder_CreatingInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting the property value of [{0}].[{1}].
        /// </summary>
        internal static string ObjectBuilder_SettingPropertyValue {
            get {
                return ResourceManager.GetString("ObjectBuilder_SettingPropertyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The results contain a column with the name [{1}], however the type [{0}] does not have a mapped property with the column name [{1}].
        /// </summary>
        internal static string ObjectBuilder_UnknownProperty {
            get {
                return ResourceManager.GetString("ObjectBuilder_UnknownProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating the ObjectInfo for the type [{0}].
        /// </summary>
        internal static string ObjectInfo_CreatingObjectInfo {
            get {
                return ResourceManager.GetString("ObjectInfo_CreatingObjectInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping the property [{0}].[{1}] to the column [{2}].
        /// </summary>
        internal static string ObjectInfo_MappingColumnToProperty {
            get {
                return ResourceManager.GetString("ObjectInfo_MappingColumnToProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping the type [{0}] to the table [{1}].[{2}].
        /// </summary>
        internal static string ObjectInfo_MappingTypeToTable {
            get {
                return ResourceManager.GetString("ObjectInfo_MappingTypeToTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving the ObjectInfo for [{0}].
        /// </summary>
        internal static string ObjectInfo_RetrievingObjectInfo {
            get {
                return ResourceManager.GetString("ObjectInfo_RetrievingObjectInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type [{0}] is not a class and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustBeClass {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustBeClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type [{0}] has no default (parameterless) constructor and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustHaveDefaultConstructor {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustHaveDefaultConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type [{0}] is abstract and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustNotBeAbstract {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustNotBeAbstract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session closing database connection.
        /// </summary>
        internal static string Session_ClosingConnection {
            get {
                return ResourceManager.GetString("Session_ClosingConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session created.
        /// </summary>
        internal static string Session_Created {
            get {
                return ResourceManager.GetString("Session_Created", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session disposed.
        /// </summary>
        internal static string Session_Disposed {
            get {
                return ResourceManager.GetString("Session_Disposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There must be at least 1 result per page.
        /// </summary>
        internal static string Session_MustHaveAtLeast1Result {
            get {
                return ResourceManager.GetString("Session_MustHaveAtLeast1Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session opening database connection.
        /// </summary>
        internal static string Session_OpeningConnection {
            get {
                return ResourceManager.GetString("Session_OpeningConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first page which can be requested is page 1.
        /// </summary>
        internal static string Session_PagesStartAtOne {
            get {
                return ResourceManager.GetString("Session_PagesStartAtOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new session for connection [{0}].
        /// </summary>
        internal static string SessionFactory_CreatingSession {
            get {
                return ResourceManager.GetString("SessionFactory_CreatingSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sql dialect [{0}] is currently not supported by the MicroLite ORM framework.
        /// </summary>
        internal static string SqlDialectFactory_DialectNotSupported {
            get {
                return ResourceManager.GetString("SqlDialectFactory_DialectNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The column [{0}] has been mapped multiple times, this usually occurs if multiple properties have the same column name specified in the column attribute.
        /// </summary>
        internal static string TableInfo_ColumnMappedMultipleTimes {
            get {
                return ResourceManager.GetString("TableInfo_ColumnMappedMultipleTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No column has been mapped as the identifier for the table [{0}].[{1}].
        /// </summary>
        internal static string TableInfo_NoIdentifierColumn {
            get {
                return ResourceManager.GetString("TableInfo_NoIdentifierColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction committed changes.
        /// </summary>
        internal static string Transaction_Committed {
            get {
                return ResourceManager.GetString("Transaction_Committed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction committing changes.
        /// </summary>
        internal static string Transaction_Committing {
            get {
                return ResourceManager.GetString("Transaction_Committing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction has been completed.
        /// </summary>
        internal static string Transaction_Completed {
            get {
                return ResourceManager.GetString("Transaction_Completed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction created.
        /// </summary>
        internal static string Transaction_Created {
            get {
                return ResourceManager.GetString("Transaction_Created", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction disposed.
        /// </summary>
        internal static string Transaction_Disposed {
            get {
                return ResourceManager.GetString("Transaction_Disposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction is being disposed with uncommitted changes.
        /// </summary>
        internal static string Transaction_DisposedUncommitted {
            get {
                return ResourceManager.GetString("Transaction_DisposedUncommitted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command enlisted in transaction.
        /// </summary>
        internal static string Transaction_EnlistingCommand {
            get {
                return ResourceManager.GetString("Transaction_EnlistingCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction rolled back changes.
        /// </summary>
        internal static string Transaction_RolledBack {
            get {
                return ResourceManager.GetString("Transaction_RolledBack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction rolling back changes.
        /// </summary>
        internal static string Transaction_RollingBack {
            get {
                return ResourceManager.GetString("Transaction_RollingBack", resourceCulture);
            }
        }
    }
}
