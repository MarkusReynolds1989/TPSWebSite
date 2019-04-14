using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TPS.App_Code
{
    public class clsBusinessLayer
    {
        //send a message to the manager when a staff request is sent
        public static bool SendEmail(string Sender, string Recipient, string bcc, string cc, string subject, string body)
        {
            try
            {
                //create an object of MailMessage class
                MailMessage MyMailMessage = new MailMessage();
                //create mailaddress object
                MyMailMessage.From = new MailAddress(Sender);
                //create mailaddress recipient value
                MyMailMessage.To.Add(new MailAddress(Recipient));
                //handle bcc
                if (bcc != null && bcc != string.Empty)
                {
                    //add the bcc address
                    MyMailMessage.Bcc.Add(new MailAddress(bcc));
                }
                // handle cc
                if (cc != null && cc != string.Empty)
                {
                    MyMailMessage.CC.Add(new MailAddress(cc));
                }
                //create the subject
                MyMailMessage.Subject = subject;
                //create the body
                MyMailMessage.Body = body;
                //set the html to true
                MyMailMessage.IsBodyHtml = true;
                //set the mail priority
                MyMailMessage.Priority = MailPriority.Normal;
                SmtpClient MySmtpClient = new SmtpClient("localhost");
                //SMTP port = 25;
                //generic ip host = "127.0.0.1";
                //Put in the mail message
                MySmtpClient.Send(MyMailMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public clsBusinessLayer()
        {

        }
    }
}