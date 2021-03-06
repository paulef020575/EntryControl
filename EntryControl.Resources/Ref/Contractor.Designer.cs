﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryControl.Resources.Ref {
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
    public class Contractor {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Contractor() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EntryControl.Resources.Ref.Contractor", typeof(Contractor).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from refContractorContact where contractor = @contractor and contactType = @contactType.
        /// </summary>
        public static string ContactDelete {
            get {
                return ResourceManager.GetString("ContactDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update or insert into refContractorContact (contractor, contactType, contactValue) values (@contractor, @contactType, @contactValue) matching (contractor, contactType).
        /// </summary>
        public static string ContactInsert {
            get {
                return ResourceManager.GetString("ContactInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id, contactValue from systemEnumerations left join refContractorContact on (contactType = id and contractor = @contractor) where enumerationName = &apos;contactType&apos;.
        /// </summary>
        public static string ContactLoadList {
            get {
                return ResourceManager.GetString("ContactLoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from refContractor where id = @id.
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to gen_refContractor_id.
        /// </summary>
        public static string GeneratorName {
            get {
                return ResourceManager.GetString("GeneratorName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from refContractorGroup where contractor = @contractor and contractorGroup = @contractorGroup.
        /// </summary>
        public static string GroupDelete {
            get {
                return ResourceManager.GetString("GroupDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update or insert into refContractorGroup (contractor, contractorGroup) values (@contractor, @contractorGroup) matching (contractor, contractorGroup).
        /// </summary>
        public static string GroupInsert {
            get {
                return ResourceManager.GetString("GroupInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id, count(contractor) as cnt from systemEnumerations left join refContractorGroup on (id = contractorGroup and contractor = @contractor) where enumerationName = &apos;contractorGroup&apos; group by id.
        /// </summary>
        public static string GroupLoadList {
            get {
                return ResourceManager.GetString("GroupLoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into refContractor (id, name, shortName) values (@id, @name, @shortName).
        /// </summary>
        public static string Insert {
            get {
                return ResourceManager.GetString("Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from refContractor where id = @id.
        /// </summary>
        public static string Load {
            get {
                return ResourceManager.GetString("Load", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from refContractorLoadList(@contractorGroup).
        /// </summary>
        public static string LoadList {
            get {
                return ResourceManager.GetString("LoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update refContractor set name = @name, shortName = @shortName where id = @id.
        /// </summary>
        public static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
    }
}
