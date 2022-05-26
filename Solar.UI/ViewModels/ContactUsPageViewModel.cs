using Solar.BLL.DTO;
using Solar.BLL.Services;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using Solar.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Solar.UI.ViewModels
{
    public class ContactUsPageViewModel:BaseNotifyPropertyChanged
    {
        public ImageSiteService imageSiteService { get; set; } = new ImageSiteService(new ImageSiteRepository(new SiteContext()));
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
        public BitmapImage smallLogo;
        public BitmapImage SmallLogo
        {
            get => smallLogo;
            set
            {
                smallLogo = value;
                NotifyOfPopertyChanged();
            }
        }
        public ContactUsPageViewModel()
        {
            SmallLogo = new BitmapImage();
            Thread t = new Thread(()=>
            SmallLogo.Dispatcher.InvokeAsync(new Action(() =>
            {
                ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.SmallLogo);
                BitmapImage i = new BitmapImage();
                i.BeginInit();
                i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                i.EndInit();
                SmallLogo = i;

            })));
            t.Start();
            CommandSend = new RelayCommand((x) => 
            {
                Thread t4 = new Thread(()=> {
                    SmtpClient smtpClient = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        UseDefaultCredentials = true,
                        EnableSsl = true,
                        Credentials = new NetworkCredential("solarguitarsua@gmail.com", "01012021")
                    };
                    var mailMessage = new MailMessage();
                    mailMessage.Subject = "From: "+Name + " Address: " +Mail;
                    mailMessage.From = new MailAddress("solarguitarsua@gmail.com");
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = Message;
                    mailMessage.To.Add(new MailAddress("solarguitarsua@gmail.com"));
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Send(mailMessage);
                    mailMessage.Dispose();
                    smtpClient.Dispose();
                });
                t4.Start();
            });
        }
        public ICommand CommandSend { get; set; }
    }
}
