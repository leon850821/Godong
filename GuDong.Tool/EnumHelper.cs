using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Tool
{
   public class EnumHelper
    {
        #region 从枚举类型和它的特性读出并返回一个键值对 GetNVCFromEnumValue

        /// <summary>
        /// 从枚举类型和它的特性读出并返回一个键值对
        /// </summary>
        /// <param name="enumType">Type,该参数的格式为typeof(需要读的枚举类型)</param>
        /// <returns>键值对</returns>
        public static NameValueCollection GetNVCFromEnumValue(Type enumType)
        {
            NameValueCollection nvc = new NameValueCollection();
            Type typeDescription = typeof(DescriptionAttribute);
            System.Reflection.FieldInfo[] fields = enumType.GetFields();
            string strText = string.Empty;
            string strValue = string.Empty;
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType.IsEnum)
                {
                    strValue = ((int)enumType.InvokeMember(field.Name, BindingFlags.GetField, null, null, null)).ToString();
                    object[] arr = field.GetCustomAttributes(typeDescription, true);
                    if (arr.Length > 0)
                    {
                        DescriptionAttribute aa = (DescriptionAttribute)arr[0];
                        strText = aa.Description;
                    }
                    else
                    {
                        strText = field.Name;
                    }
                    nvc.Add(strText, strValue);
                }
            }
            return nvc;
        }

        #endregion

       #region  枚举转换成List<KeyValuePair<string, string>>
       public static List<KeyValuePair<string, string>> GetList(Type enumType)
       {
           List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
           NameValueCollection nvc = EnumHelper.GetNVCFromEnumValue(enumType);
           for (int i = 0; i < nvc.Count; i++)
           {
               list.Add(new KeyValuePair<string, string>(nvc.Keys[i], nvc[i]));
           }
           return list;
       }
       #endregion



       /// <summary>
       /// 获取枚举描述
       /// </summary>
       /// <param name="o">枚举值</param>
       /// <returns></returns>
       public static string GetDescriptionFromEnumValue(object o)
       {
           try
           {

               Type enumType = o.GetType();
               string name = o.ToString();
               DescriptionAttribute[] customAttributes = (DescriptionAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
               if ((customAttributes != null) && (customAttributes.Length == 1))
               {
                   return customAttributes[0].Description;
               }
               return name;
           }
           catch
           {
               return "未知";
           }
       }
    }
}
