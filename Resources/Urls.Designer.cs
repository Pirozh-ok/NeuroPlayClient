﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NeuroPlayClient.Resources {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Urls {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Urls() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NeuroPlayClient.Resources.Urls", typeof(Urls).Assembly);
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
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336/AddEDFAnnotation?text={text}.
        /// </summary>
        public static string AddMarker {
            get {
                return ResourceManager.GetString("AddMarker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336/continueRecord.
        /// </summary>
        public static string ContinueRecord {
            get {
                return ResourceManager.GetString("ContinueRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336.
        /// </summary>
        public static string DefaultUrl {
            get {
                return ResourceManager.GetString("DefaultUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336/deviceCount.
        /// </summary>
        public static string GetCountDevices {
            get {
                return ResourceManager.GetString("GetCountDevices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336/currentDeviceInfo.
        /// </summary>
        public static string GetCurrentDevice {
            get {
                return ResourceManager.GetString("GetCurrentDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336/pauseRecord.
        /// </summary>
        public static string PauseRecord {
            get {
                return ResourceManager.GetString("PauseRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336/startRecord.
        /// </summary>
        public static string StartRecord {
            get {
                return ResourceManager.GetString("StartRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://127.0.0.1:2336/stopRecord.
        /// </summary>
        public static string StopRecord {
            get {
                return ResourceManager.GetString("StopRecord", resourceCulture);
            }
        }
    }
}