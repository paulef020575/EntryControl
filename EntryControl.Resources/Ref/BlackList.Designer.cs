﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryControl.Resources.Ref {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class BlackList {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BlackList() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EntryControl.Resources.Ref.BlackList", typeof(BlackList).Assembly);
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
        ///   Ищет локализованную строку, похожую на SELECT IsInList FROM IsInBlackList(@text).
        /// </summary>
        public static string CheckText {
            get {
                return ResourceManager.GetString("CheckText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на DELETE FROM refBlackList WHERE Id = @Id.
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на GEN_REFBLACKLIST_ID.
        /// </summary>
        public static string GeneratorName {
            get {
                return ResourceManager.GetString("GeneratorName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на INSERT INTO refBlackList (Id, Text) VALUES (@Id, @Text).
        /// </summary>
        public static string Insert {
            get {
                return ResourceManager.GetString("Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT * FROM refBlackList WHERE Id = @Id.
        /// </summary>
        public static string Load {
            get {
                return ResourceManager.GetString("Load", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT * FROM refBlackList ORDER BY Text.
        /// </summary>
        public static string LoadList {
            get {
                return ResourceManager.GetString("LoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UPDATE refBlackList SET Text = @Text WHERE Id = @Id.
        /// </summary>
        public static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
    }
}