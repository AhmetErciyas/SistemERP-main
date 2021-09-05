namespace ERP.Domain.ServiceClient.MAIL
{
    public class MailRequestModel
    {
        public string Subject { get; set; } //zorunlu
        public string To { get; set; }      //zorunlu
        public string ToName { get; set; }  //zorunlu
        public string Body { get; set; }    //zorunlu
        public string ToList { get; set; }  //opsiyonel, çoklu gönderim "test@gmail.com; deneme@gmail.com"
        public string ToCC { get; set; }    //opsiyonel, çoklu gönderim "test@gmail.com; deneme@gmail.com"
        public string BCC { get; set; }     //opsiyonel, çoklu gönderim "test@gmail.com; deneme@gmail.com"
    }
}
