﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryControl.Migrations.Scripts {
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
    internal class M2017112501 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal M2017112501() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EntryControl.Migrations.Scripts.M2017112501", typeof(M2017112501).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на alter table docPermitPoint
        ///add constraint FK_PP_Permit
        ///foreign key (permit)
        ///references docPermit(ID)
        ///on delete CASCADE
        ///on update CASCADE.
        /// </summary>
        internal static string CreatePermitFk {
            get {
                return ResourceManager.GetString("CreatePermitFk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на alter table docPermitPoint
        ///add constraint FK_PP_Point
        ///foreign key (point)
        ///references refEntryPoint(ID)
        ///on delete CASCADE
        ///on update CASCADE.
        /// </summary>
        internal static string CreatePointFK {
            get {
                return ResourceManager.GetString("CreatePointFK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на create table docPermitPoint(permit integer, point integer).
        /// </summary>
        internal static string CreateTable {
            get {
                return ResourceManager.GetString("CreateTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на insert into docPermitPoint
        ///(permit, point)
        ///select prm.id, pnt.id
        ///from docPermit prm, refentrypoint pnt
        ///where (pnt.id = prm.entrypoint or prm.entrypoint = 0).
        /// </summary>
        internal static string FillTable {
            get {
                return ResourceManager.GetString("FillTable", resourceCulture);
            }
        }
    }
}
