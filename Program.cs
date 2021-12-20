using System;
using System.Net.Mail;

namespace SimpleEmailApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("(insert SMTP server here)");

                mail.From = new MailAddress("(Insert email of sender here)");
                mail.To.Add("(Insert email of who you want to send to here)");
                mail.Subject = "Test message";
                mail.Body = "This is a test message launched from my C# app";

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("(Insert email of sender here)", "(Insert password of sender here)");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
