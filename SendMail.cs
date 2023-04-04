using System;
using System.Net;
using System.Net.Mail;

public class SendMail
{
     public void Mail()
        {
            try
            {
                
                string Folder = @"C:\Users\";//Buraya Dosya yolu girilmeli.
                var files = new DirectoryInfo(Folder).GetFiles("*.*");
                string latestfile = "";

                DateTime lastModified = DateTime.MinValue;

                foreach (FileInfo file in files)
                {
                    if (file.LastWriteTime > lastModified)
                    {
                        lastModified = file.LastWriteTime;
                        latestfile = @"C:\Users\"+ file.Name; //belirtilen dizindeki en son düzenlenen dosyaya erişir.
                    }
                }
                


                SmtpClient smtp = new SmtpClient();//client tanımladık.
                smtp.Host = "smtp.gmail.com";  
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("maili gönderen", "şifre");
                MailMessage eposta = new MailMessage();
                eposta.From = new MailAddress("maili gönderen");
                eposta.To.Add("maili alan");

                eposta.Subject = "Konu";
                eposta.Body = "Mail Gövdesi";
                Attachment data = new Attachment(latestfile, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(latestfile);

                disposition.ModificationDate = System.IO.File.GetLastWriteTime(latestfile);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(latestfile);
                eposta.Attachments.Add(data);


                try
                {
                    smtp.Send(eposta);
                }
                catch (Exception ex)
                {

                   throw new Exception(ex.Message);
                }

              
                 throw new Exception("Mail başarı ile gönderildi.");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
                
            }

        }
  }
