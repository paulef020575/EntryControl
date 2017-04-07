using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace EntryControl
{
    [Serializable]
    public class NotifySettings
    {
        public bool NotifyAlways { get; set; }

        public DateTime WorkdayStart { get; set; }

        public DateTime WorkdayFinish { get; set; }

        public List<DateTime> NotifyDays { get; set; }

        public bool ShowNotifyWindow { get; set; }

        public string NotifySoundFile { get; set; }

        public NotifySettings()
        {
            NotifyAlways = false;
            WorkdayStart = new DateTime(2016, 01, 01, 8, 0, 0);
            WorkdayFinish = new DateTime(2016, 01, 01, 17, 0, 0);
            NotifyDays = new List<DateTime>();
            ShowNotifyWindow = true;
            NotifySoundFile = string.Empty;
        }

        public void SaveSettings()
        {
            XmlSerializer serializer = new XmlSerializer(GetType());

            using (FileStream fs = new FileStream("notifySettings.xml", FileMode.Create))
            {
                serializer.Serialize(fs, this);
            }
        }

        public static NotifySettings ReadSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(NotifySettings));
            using (FileStream fs = new FileStream("notifySettings.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    NotifySettings settings = (NotifySettings)serializer.Deserialize(fs);

                    if (settings != null)
                        return settings;
                    else
                        return new NotifySettings();
                }
                catch (InvalidOperationException)
                {
                    return new EntryControl.NotifySettings();
                }
            }
        }

    }
}
