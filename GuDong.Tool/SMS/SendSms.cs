using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Tool.SMS
{
    public class SendSms
    {
        public string ErrorMsg="";
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="telNo">手机号</param>
        /// <param name="code">短信模版号</param>
        /// <param name="Minute">有效的分钟数</param>>
        public bool Send(string telNo, string code, string Minute)
        {
            string[] result = { "" };
            Random random = new Random();
            string ran = random.Next(100000, 1000000).ToString();
            CCPRestSDK api = new CCPRestSDK();
            bool isInit = api.init("sandboxapp.cloopen.com", "8883");
            api.setAccount("8a48b5514ae16942014ae6ff251903ca", "9eba3e71cd8f4655a801af9d9a9696c6");
            api.setAppId("8a48b5514ae16942014ae7008f9203d3");
            try
            {
                if (isInit)
                {
                    string[] data_content = { ran, Minute };
                    string IsSendSms = ConfigurationManager.AppSettings["IsSendSms"].ToString();
                    string status = "";
                    if (IsSendSms == "1")
                    {
                        Dictionary<string, object> retData = api.SendTemplateSMS(telNo, code, data_content);
                        result = getDictionaryData(retData).Split(';');
                        status = result[0].Split('=')[1];
                    }
                    else
                        status = "000000";

                    if (status == "000000")
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMsg = result[1].Split('=')[1];
                        return false ;
                    }
                }
                else
                {
                    ErrorMsg = "发送出现异常";
                    return false;
                }
            }
            catch
            {
                ErrorMsg = "发送出现异常";
                return false;
            }
        }

        private string getDictionaryData(Dictionary<string, object> data)
        {
            string ret = null;
            foreach (KeyValuePair<string, object> item in data)
            {
                if (item.Value != null && item.Value.GetType() == typeof(Dictionary<string, object>))
                {
                    ret += item.Key.ToString() + "={";
                    ret += getDictionaryData((Dictionary<string, object>)item.Value);
                    ret += "};";
                }
                else
                {
                    ret += item.Key.ToString() + "=" + (item.Value == null ? "null" : item.Value.ToString()) + ";";
                }
            }
            return ret;
        }
    }
}
