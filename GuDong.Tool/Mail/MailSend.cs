using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Tool.Mail
{
    /// <summary>
    /// 发送邮箱组件
    /// </summary>
    public class MailSend
    {
        private string emailFrom = "service@goodjr.cn";
        private string emailTo;
        private string CC = "";
        private string BCC = "";
        private string userName = "service@goodjr.cn";
        private string password = "goodjrHR909";
        private string smtpServer = "smtp.exmail.qq.com";
        private string smtpPort = "25";
        private bool enableSSL = false;
        private bool IsHTML = true;
        /// <summary>
        /// Mail的构造函数
        /// </summary>
        /// <param name="_emailFrom">源邮箱地址</param>
        /// <param name="_emailTo">发往邮箱地址</param>
        /// <param name="_cc">获取包含此电子邮件的抄送 (CC) 收件人的地址集合</param>
        /// <param name="_Bcc">获取包含此电子邮件的密件抄送 (BCC) 收件人的地址集合</param>
        /// <param name="_username">源邮箱的用户名</param>
        /// <param name="_password">源邮箱的密码</param>
        /// <param name="_smtpServer">源邮箱的服务</param>
        /// <param name="_smtpPort">源邮箱服务的端口</param>
        /// <param name="_enableSSL">是否启动SSL</param>
        public MailSend(string _emailTo)
        {
            //emailFrom = _emailFrom;
            emailTo = _emailTo;
            //userName = _username;
            //password = _password;
            //smtpServer = _smtpServer;
            //smtpPort = _smtpPort;
            //enableSSL = _enableSSL;
        }
        /// <summary>
        /// 发送邮件(不带附件)
        /// </summary>
        /// <param name="emailFrom"></param>
        /// <param name="emailTo"></param>
        /// <param name="CC"></param>
        /// <param name="BCC"></param>
        /// <param name="subject">标题</param>
        /// <param name="body">网页内容</param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="SmtpServer"></param>
        public bool SendEmail(string subject, string body)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(this.emailFrom, this.emailTo);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                mailMessage.IsBodyHtml = IsHTML;
                if (this.CC != string.Empty)
                {
                    MailAddress CCcopy = new MailAddress(CC);
                    mailMessage.CC.Add(CCcopy);
                }

                if (this.BCC != string.Empty)
                {
                    MailAddress BCCcopy = new MailAddress(BCC);
                    mailMessage.Bcc.Add(BCCcopy);
                }
                SmtpClient b = new SmtpClient(this.smtpServer, int.Parse(this.smtpPort));
                //SmtpClient b = new SmtpClient();
                b.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
                //b.Host = this.smtpServer; //指定SMTP服务器
                b.EnableSsl = this.enableSSL;
                b.UseDefaultCredentials = false;
                b.Credentials = new System.Net.NetworkCredential(this.userName, this.password);
                b.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                //string wcfUrl =                
                //object[] objects = new object[] { 1, "邮件错误", ex.StackTrace+"|"+ex.Message };
                //Tool.WebServiceHelper.InvokeWebService("http://192.168.2.9:9999/LogService.asmx", "SaveLog", objects);
                return false;
            }
        }
        /// <summary>
        /// 发送邮件(带附件)
        /// </summary>
        /// <param name="emailFrom"></param>
        /// <param name="emailTo"></param>
        /// <param name="CC"></param>
        /// <param name="BCC"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="SmtpServer"></param>
        /// <param name="sAttrachment"></param>
        public bool SendEmail(string subject, string body, List<string> sAttrachment)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(emailFrom, emailTo);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                if (CC != string.Empty)
                {
                    MailAddress CCcopy = new MailAddress(CC);
                    mailMessage.CC.Add(CCcopy);
                }

                if (BCC != string.Empty)
                {
                    MailAddress BCCcopy = new MailAddress(BCC);
                    mailMessage.Bcc.Add(BCCcopy);
                }

                if (sAttrachment.Count > 0)
                {
                    foreach (string sSubstr in sAttrachment)
                    {
                        System.Net.Mail.Attachment MyAttachment = new Attachment(sSubstr);
                        mailMessage.Attachments.Add(MyAttachment);
                    }
                }


                SmtpClient b = new SmtpClient(smtpServer, int.Parse(smtpPort));
                //b.EnableSsl = enableSSL;
                b.Credentials = new System.Net.NetworkCredential(userName, password);
                b.Send(mailMessage);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
