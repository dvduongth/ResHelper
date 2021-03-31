using System;
using System.Collections.Generic;

public class FoundInfo : IEquatable<FoundInfo>
{
    public string path { get; set; }
    public List<string> value { get; set; }
    public string getValueString()
    {
        return String.Join("&", value.ToArray());
    }
    public override string ToString()
    {
        return "path: " + path + "   value: " + getValueString();
    }

    public bool Equals(FoundInfo other)
    {
        if (other == null)
            return false;

        if (this.ToString() == other.ToString())
            return true;
        else
            return false;
    }

    public override bool Equals(Object obj)
    {
        if (obj == null)
            return false;

        FoundInfo p = obj as FoundInfo;
        if (p == null)
            return false;
        else
            return Equals(p);
    }

    public override int GetHashCode()
    {
        return this.value.GetHashCode();
    }
    public static bool operator ==(FoundInfo person1, FoundInfo person2)
    {
        if (((object)person1) == null || ((object)person2) == null)
            return Object.Equals(person1, person2);

        return person1.Equals(person2);
    }

    public static bool operator !=(FoundInfo person1, FoundInfo person2)
    {
        if (((object)person1) == null || ((object)person2) == null)
            return !Object.Equals(person1, person2);

        return !(person1.Equals(person2));
    }
}
