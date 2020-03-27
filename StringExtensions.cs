using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool
{
    public static class StringExtensons
    {
        public static bool StartsWithExt(this string LookedThroughString, string Text)
        {
            if (LookedThroughString == "")
                return false;

            return LookedThroughString.Trim().StartsWith(Text, StringComparison.InvariantCultureIgnoreCase);
        }

        public static string StripChunk(this string LineToStrip)
        {
            if (LineToStrip.Contains(" "))
            {
                var strippedLine = LineToStrip.Split(new char[] { ' ' }, 2)[1];
                if(strippedLine != "")
                {
                    strippedLine = strippedLine.Trim();
                }
                return strippedLine;
            }
            else
                return "";
        }

        public static void AddFormatted(this List<string> listOfStrings, string formatString, string actionName, List<KeyMouseWrapper> keysToAdd)
        {
            foreach(var keyToAdd in keysToAdd)
            {
                string outputString = string.Format(formatString, keyToAdd.ToString().ToLower(), actionName);
                listOfStrings.Add(outputString);
            }
        }

        public static Dictionary<string, D64Keys> d64KeysToNetKeysDictionary = new Dictionary<string, D64Keys>()
        {
            //Upper number keys
            {"1", D64Keys.D1 },
            {"2", D64Keys.D2 },
            {"3", D64Keys.D3 },
            {"4", D64Keys.D4 },
            {"5", D64Keys.D5 },
            {"6", D64Keys.D6 },
            {"7", D64Keys.D7 },
            {"8", D64Keys.D8 },
            {"9", D64Keys.D9 },
            {"0", D64Keys.D0 }
        };


        public static string GetDescription(this Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }
    }
}
