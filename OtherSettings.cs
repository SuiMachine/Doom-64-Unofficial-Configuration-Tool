﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Doom64_Unofficial_Configuration_Tool
{
    public class OtherSettings
    {
        public bool g_showintromovie { get; set; }
        public string g_language { get; set; }
        public List<string> otherSettings { get; set; }

        public OtherSettings()
        {
            g_showintromovie = false;
            g_language = "en";
            otherSettings = new List<string>();
        }

        internal void ParseSetting(string line)
        {
            Regex regx = new Regex("seta( +)(.+?)( +)\"(.+?)\"", RegexOptions.IgnoreCase);

            if (regx.IsMatch(line))
            {
                //This might look a bit overcomplicated, but it's actually quite efficient in terms of actually writting it, since all
                //that's need is to get property name from a config file, compare it against the ones that we have definied
                //if we find one - we check type and use proper value parsing, if we haven't specified it - we just throw it as string to the list
                var matches = regx.Matches(line);

                var propertyName = matches[0].Groups[2].Value.ToLower();
                var value = matches[0].Groups[4].Value;
                if (value.Contains("\""))
                {
                    value.Trim(new char[] { '\"' });
                }


                Object target = this;
                Type _type = target.GetType();
                PropertyInfo[] properties = _type.GetProperties();

                var foundElement = properties.FirstOrDefault(x => x.Name.ToLower() == propertyName);
                if (foundElement != null)
                {
                    //This is because some cultures (like Polish) use comma as a decimal point etc.
                    var usCultureInfo = new CultureInfo("en-US");

                    if (foundElement.PropertyType == typeof(bool))
                    {
                        if (value == "0")
                            foundElement.SetValue(target, false, null);
                        else
                            foundElement.SetValue(target, true, null);
                    }
                    else if (foundElement.PropertyType == typeof(int))
                        foundElement.SetValue(target, int.Parse(value, usCultureInfo), null);
                    else if (foundElement.PropertyType == typeof(float))
                        foundElement.SetValue(target, float.Parse(value, usCultureInfo), null);
                    else if (foundElement.PropertyType == typeof(string))
                        foundElement.SetValue(target, value, null);
                }
                else
                    otherSettings.Add(line);
            }
            else
                otherSettings.Add(line);
        }

        internal string[] TranslateToConfig()
        {
            var usCultureInfo = new CultureInfo("en-US");

            string configFormat = "seta {0} \"{1}\"";

            List<string> lines = new List<string>();
            Object target = this;
            Type _type = target.GetType();
            PropertyInfo[] properties = _type.GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(target);

                if (value.GetType() == typeof(bool))
                {
                    if ((bool)value == true)
                        lines.Add(string.Format(configFormat, property.Name.ToLower(), "1"));
                    else
                        lines.Add(string.Format(configFormat, property.Name.ToLower(), "0"));
                }
                else if (value.GetType() == typeof(List<string>))
                {
                    var castValue = (List<string>)value;
                    lines.AddRange(castValue);
                }
                else if (value.GetType() == typeof(float))
                {
                    lines.Add(string.Format(configFormat, property.Name.ToLower(), ((float)value).ToString(usCultureInfo)));
                }
                else
                {
                    //Rest is pretty much irrelevant and can be converted usingbasic ToString()
                    lines.Add(string.Format(configFormat, property.Name.ToLower(), value.ToString()));
                }

            }

            return lines.ToArray();
        }
    }
}
