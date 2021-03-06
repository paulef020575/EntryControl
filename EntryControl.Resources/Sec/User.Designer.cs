﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryControl.Resources.Sec {
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
    public class User {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal User() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EntryControl.Resources.Sec.User", typeof(User).Assembly);
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
        ///   Looks up a localized string similar to delete from secUserCargo where userId = @userId and cargoId = @cargoId.
        /// </summary>
        public static string CargoDelete {
            get {
                return ResourceManager.GetString("CargoDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id, name, count(userId) as cnt from refCargos left join secUserCargo on (cargoId = id and userId = @userId) group by id, name order by name.
        /// </summary>
        public static string CargoLoadList {
            get {
                return ResourceManager.GetString("CargoLoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update or insert into secUserCargo (userId, cargoId) values (@userId, @cargoId) matching (userId, cargoId).
        /// </summary>
        public static string CargoSave {
            get {
                return ResourceManager.GetString("CargoSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id from secUsers where id = @id and accessPassword = @password.
        /// </summary>
        public static string CheckPassword {
            get {
                return ResourceManager.GetString("CheckPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select userId from secUserRole where userId = @id and userRole = @role.
        /// </summary>
        public static string CheckRole {
            get {
                return ResourceManager.GetString("CheckRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from secDomainUser where userId = @id.
        /// </summary>
        public static string ClearDomainUser {
            get {
                return ResourceManager.GetString("ClearDomainUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from secUsers where id = @id.
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to gen_secUsers_id.
        /// </summary>
        public static string GeneratorName {
            get {
                return ResourceManager.GetString("GeneratorName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from secDomainUser where userId = @id.
        /// </summary>
        public static string GetDomainUser {
            get {
                return ResourceManager.GetString("GetDomainUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from secUsers where id = (select userId from secDomainUser where domainName like @domainName and userName like @userName) and isLocked = 0.
        /// </summary>
        public static string GetUserId {
            get {
                return ResourceManager.GetString("GetUserId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into secUsers (id, lastname, firstname, secondname, isLocked) values (@id, @lastname, @firstname, @secondname, @isLocked).
        /// </summary>
        public static string Insert {
            get {
                return ResourceManager.GetString("Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from secUsers where id = @id.
        /// </summary>
        public static string Load {
            get {
                return ResourceManager.GetString("Load", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from secUsers order by lastname, firstname, secondname.
        /// </summary>
        public static string LoadList {
            get {
                return ResourceManager.GetString("LoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from secUserRole where userId = @userId and userRole = @userRole.
        /// </summary>
        public static string RoleDelete {
            get {
                return ResourceManager.GetString("RoleDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id, count(userId) AS cnt from systemEnumerations left join secUserRole on (userRole = id and userId = @userId) where enumerationName = &apos;userRole&apos; group by id.
        /// </summary>
        public static string RoleLoadList {
            get {
                return ResourceManager.GetString("RoleLoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update or insert into secUserRole (userId, userRole) values (@userId, @userRole) matching (userId, userRole).
        /// </summary>
        public static string RoleSave {
            get {
                return ResourceManager.GetString("RoleSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update or insert into secDomainUser (userId, domainName, userName) values (@id, @domainName, @userName) matching (userId).
        /// </summary>
        public static string SetDomainUser {
            get {
                return ResourceManager.GetString("SetDomainUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update secUsers set accesspassword = @password where id = @id.
        /// </summary>
        public static string SetPassword {
            get {
                return ResourceManager.GetString("SetPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update secUsers set lastname = @lastname, firstname = @firstname, secondname = @secondname, isLocked = @isLocked where id = @id.
        /// </summary>
        public static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
    }
}
