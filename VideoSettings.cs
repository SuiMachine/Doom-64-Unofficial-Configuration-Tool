using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Doom64_Unofficial_Configuration_Tool
{
    public class VideoSettings
    {
        public uint v_width { get; set; }
        public uint v_height { get; set; }
        public bool v_windowed { get; set; }
        public bool v_borderless { get; set; }
        public uint v_refresh { get; set; }
        public bool v_vsync { get; set; }
        public bool cl_interpolation { get; set; }

        public RenderFamily r_rhirenderfamily { get; set; }

        /// <summary>
        /// Dev definied min. 74, max 140 - hor+ scaling
        /// </summary>
        public float r_fov { get; set; }

        public bool d3d11_compileShaders { get; set; }

        public bool developer { get; set; }

        public VideoSettings()
        {
            v_width = 1280;
            v_height = 720;
            v_windowed = true;
            v_borderless = false;
            v_refresh = 60;
            v_vsync = true;
            r_rhirenderfamily = RenderFamily.Vulkan;
            r_fov = 74;
            d3d11_compileShaders = true;
            developer = false;
            cl_interpolation = true;
        }

        internal bool ParseSetting(string line)
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
                    else if(foundElement.PropertyType == typeof(RenderFamily))
                    {
                        foundElement.SetValue(target, Enum.Parse(typeof(RenderFamily), value, true), null);
                    }
                    else if (foundElement.PropertyType == typeof(int))
                        foundElement.SetValue(target, int.Parse(value, usCultureInfo), null);
                    else if (foundElement.PropertyType == typeof(uint))
                        foundElement.SetValue(target, uint.Parse(value, usCultureInfo), null);
                    else if (foundElement.PropertyType == typeof(float))
                        foundElement.SetValue(target, float.Parse(value, usCultureInfo), null);
                    else if (foundElement.PropertyType == typeof(string))
                        foundElement.SetValue(target, value, null);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
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
                    lines.Add(string.Format(configFormat, property.Name.ToLower(), value.ToString().ToLower()));
                }

            }

            return lines.ToArray();
        }
    }
}
