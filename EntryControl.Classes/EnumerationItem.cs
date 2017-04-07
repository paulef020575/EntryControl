using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace EntryControl.Classes
{
    public class EnumerationItem
    {
        public int Id { get; private set; }

        public string Value { get; private set; }

        public EnumerationItem(DbDataReader reader)
        {
            Id = (int)reader["id"];
            Value = (string)reader["enumerationValue"];
        }

        public EnumerationItem(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is EnumerationItem)
                return ((EnumerationItem)obj).Id.Equals(Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
