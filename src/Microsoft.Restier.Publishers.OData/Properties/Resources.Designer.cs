﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Restier.Publishers.OData {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Restier.Publishers.OData.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The argument with name {0} cannot be null..
        /// </summary>
        internal static string ArguementsCannotbeNull {
            get {
                return ResourceManager.GetString("ArguementsCannotbeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot write an object of type &apos;{1}&apos;..
        /// </summary>
        internal static string CannotWriteObjectType {
            get {
                return ResourceManager.GetString("CannotWriteObjectType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controller cannot have null path..
        /// </summary>
        internal static string ControllerRequiresPath {
            get {
                return ResourceManager.GetString("ControllerRequiresPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Currently only EntitySets can be deleted from..
        /// </summary>
        internal static string DeleteOnlySupportedOnEntitySet {
            get {
                return ResourceManager.GetString("DeleteOnlySupportedOnEntitySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a supported EDM type..
        /// </summary>
        internal static string EdmTypeNotSupported {
            get {
                return ResourceManager.GetString("EdmTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element type cannot be found for &apos;{0}&apos;..
        /// </summary>
        internal static string ElementTypeNotFound {
            get {
                return ResourceManager.GetString("ElementTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EntitySet is missing during serialization..
        /// </summary>
        internal static string EntitySetMissingForSerialization {
            get {
                return ResourceManager.GetString("EntitySetMissingForSerialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keys were not specified in the format of &apos;KeyName=KeyValue&apos;..
        /// </summary>
        internal static string IncorrectKeyFormat {
            get {
                return ResourceManager.GetString("IncorrectKeyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Currently only EntitySets can be inserted into..
        /// </summary>
        internal static string InsertOnlySupportedOnEntitySet {
            get {
                return ResourceManager.GetString("InsertOnlySupportedOnEntitySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid request - ODataPath is null..
        /// </summary>
        internal static string InvalidEmptyPathInRequest {
            get {
                return ResourceManager.GetString("InvalidEmptyPathInRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid request - No ODataProperties..
        /// </summary>
        internal static string InvalidODataInfoInRequest {
            get {
                return ResourceManager.GetString("InvalidODataInfoInRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid request - Expecting {0} path template..
        /// </summary>
        internal static string InvalidPathTemplateInRequest {
            get {
                return ResourceManager.GetString("InvalidPathTemplateInRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified key &apos;{0}&apos; is not a valid property of entity &apos;{1}&apos;..
        /// </summary>
        internal static string KeyNotValidForEntityType {
            get {
                return ResourceManager.GetString("KeyNotValidForEntityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one key was specified, when multiple were expected..
        /// </summary>
        internal static string MultiKeyValuesExpected {
            get {
                return ResourceManager.GetString("MultiKeyValuesExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported type: {0}..
        /// </summary>
        internal static string NotSupportedType {
            get {
                return ResourceManager.GetString("NotSupportedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested operation is not implemented in Api class..
        /// </summary>
        internal static string OperationNotImplemented {
            get {
                return ResourceManager.GetString("OperationNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user is not authorized to execute operation {0}..
        /// </summary>
        internal static string OperationUnAuthorizationExecution {
            get {
                return ResourceManager.GetString("OperationUnAuthorizationExecution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path segment not supported: {0}.
        /// </summary>
        internal static string PathSegmentNotSupported {
            get {
                return ResourceManager.GetString("PathSegmentNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Post to unbound action is not supported by `RestierController`..
        /// </summary>
        internal static string PostToUnboundActionNotSupported {
            get {
                return ResourceManager.GetString("PostToUnboundActionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request need to have If-Match or If-None-Match header..
        /// </summary>
        internal static string PreconditionRequired {
            get {
                return ResourceManager.GetString("PreconditionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource you requested is not found..
        /// </summary>
        internal static string ResourceNotFound {
            get {
                return ResourceManager.GetString("ResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Currently only EntitySets can be updated..
        /// </summary>
        internal static string UpdateOnlySupportedOnEntitySet {
            get {
                return ResourceManager.GetString("UpdateOnlySupportedOnEntitySet", resourceCulture);
            }
        }
    }
}
