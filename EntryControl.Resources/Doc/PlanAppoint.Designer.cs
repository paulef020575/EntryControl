﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryControl.Resources.Doc {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PlanAppoint {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PlanAppoint() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EntryControl.Resources.Doc.PlanAppoint", typeof(PlanAppoint).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на delete from docPlanAppoint where id = @id.
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на gen_docPlanAppoint_id.
        /// </summary>
        public static string GeneratorName {
            get {
                return ResourceManager.GetString("GeneratorName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select comment from docPlanAppoint where id = @id.
        /// </summary>
        public static string GetComment {
            get {
                return ResourceManager.GetString("GetComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select count(id) FROM DocPlanAppoint where coalesce(permit, 0) &lt; 1 and vehicle &gt; 0 and vehicle is not null AND dateTo &gt;= @dateStart.
        /// </summary>
        public static string GetCountWoPermit {
            get {
                return ResourceManager.GetString("GetCountWoPermit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select first 1 driverName, contact from docPlanAppoint where vehicle = @vehicle.
        /// </summary>
        public static string GetDriverInfo {
            get {
                return ResourceManager.GetString("GetDriverInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select max(date1) from (select max(dateModified) as date1 from docPlanAppoint union select max(dateDeleted) as date1 from docDeleted where documentType = &apos;planAppoint&apos; union select max(dateModified) as date1 from docPermit).
        /// </summary>
        public static string GetLastDateModified {
            get {
                return ResourceManager.GetString("GetLastDateModified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на insert into docPlanAppoint (id, creator, createDate, cargo, vehicle, driverName, contact, whereTo, dateFrom, dateTo, comment) values (@id, @creator, @createDate, @cargo, @vehicle, @driverName, @contact, @whereTo, @dateFrom, @dateTo, @comment).
        /// </summary>
        public static string Insert {
            get {
                return ResourceManager.GetString("Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select pl.id, pl.creator, u.lastname as creatorName, pl.createDate, pl.cargo, crg.name as cargoName, pl.vehicle, mrk.name || &apos; &apos; || v.licensePlate as vehicleName, pl.driverName, pl.contact, pl.whereTo, pl.dateFrom, pl.dateTo, pl.dateModified, null as dateSeen, coalesce(permit, 0) as permit, pl.comment from docPlanAppoint pl, secUsers u, refCargos crg, refVehicle v, refVehicleMark mrk where u.id = pl.creator and crg.id = pl.cargo and v.id = pl.vehicle and ((coalesce(v.vehicleMark, 0) = 0 and mrk.id = -100) o [остаток строки не уместился]&quot;;.
        /// </summary>
        public static string Load {
            get {
                return ResourceManager.GetString("Load", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select * from docPlanAppointLoadList(@creator, @dateStart).
        /// </summary>
        public static string LoadList {
            get {
                return ResourceManager.GetString("LoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на select * from docPlanAppointWoPermit1(@dateStart, @page).
        /// </summary>
        public static string LoadWoPermit {
            get {
                return ResourceManager.GetString("LoadWoPermit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update docPlanAppoint set permit = @permit where id = @planAppoint.
        /// </summary>
        public static string SetPermit {
            get {
                return ResourceManager.GetString("SetPermit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update docPlanAppoint set permit = -1 where id = @planAppoint.
        /// </summary>
        public static string SetPermitLocked {
            get {
                return ResourceManager.GetString("SetPermitLocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update or insert
        ///         into docUserSeen (
        ///              documentType,
        ///              documentId,
        ///              userId,
        ///              dateSeen)
        ///         values (
        ///              &apos;planAppoint&apos;,
        ///              @id,
        ///              @userId,
        ///              @dateSeen)
        ///         matching (
        ///              documentType,
        ///              documentId,
        ///              userId).
        /// </summary>
        public static string SetSeen {
            get {
                return ResourceManager.GetString("SetSeen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на execute procedure docPlanAppointUpdate(@id, @cargo, @vehicle, @driverName, @contact, @whereTo, @dateFrom, @dateTo, @userId, @comment).
        /// </summary>
        public static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
    }
}
