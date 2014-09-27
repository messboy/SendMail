using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void sendmail_Click(object sender, EventArgs e)
    {
        // use config file
        SmtpClient smtp = new SmtpClient();

        //啟用ssl
        smtp.EnableSsl = true;

        // 寄件者
        MailAddress fromAddress = new MailAddress(ConfigurationManager.AppSettings["customer.service.receive.mail"]);

        //收件者
        string toMail = "xxx@gmail.com";
        string title = "測試信標題";
        string body = "內文";

        MailAddress toAddress = new MailAddress(toMail);
        MailMessage mail = new MailMessage(fromAddress, toAddress);
        mail.Subject = title;
        mail.Body = body;
        mail.IsBodyHtml = false;
        smtp.Send(mail);

    }
}