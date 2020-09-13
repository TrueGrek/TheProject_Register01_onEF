using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace TheProject_Register01_onEF
{
    public partial class Forgot : System.Web.UI.Page
    {
        bool trip = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            Label3.Visible = false;
            Label2.Visible = false;
            Label1.Visible = false;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
        protected async void Button3_Click(object sender, EventArgs e)
        {
            if(TextBox2.Text == Session["Code"].ToString())
            {
                Label2.Visible = true;
                string s1 = "Ваш новый пароль";
                string NewPassword = Membership.GetUser(Session["User"].ToString()).ResetPassword();
                await SendEmailAsync(Membership.GetUser(Session["User"].ToString()).Email.ToString(), s1, NewPassword);
                Button2.Visible = true;
            }
            else
            {
                Label1.Visible = true;
            }
        }
        //Реализация Mailkit
        protected async void Button1_ClickAsync(object sender, EventArgs e)
        {

            Session["User"] = TextBox1.Text;
            string s1 = "Сообщение от администрации";
            var a = Membership.GetUser(Session["User"].ToString()).ToString();
            if (a != null)
            {
                Session["Code"] = RandomCode();
                await SendEmailAsync(Membership.GetUser(a).Email.ToString(), s1, Session["Code"].ToString());
            }
            else
            {
                LabelError.Visible = true;
            }

            if (trip)
            {
                Label3.Visible = true;
                PlaceHolder2.Visible = true;
            }
            
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "Тут написан твой email"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("Тут написан твой email", "пароль");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
            //метка
            trip = true;
        }

        public string RandomCode()
        {
            char[] randomWord = new char[5];
            Random random = new Random();
            string s = String.Empty;
            //A-Z (65-90) a-z(97-122) 0-9(48-57)
            for (int i = 0; i < 5; i++)
            {
                if ((i & 1) == 0)
                {
                    randomWord[i] = (char)random.Next(65, 91);
                    s += randomWord[i].ToString();
                }
                else
                {
                    randomWord[i] = (char)random.Next(48, 58);
                    s += randomWord[i].ToString();
                }
            }
            return s;
        }
    }
}