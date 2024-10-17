using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.DtoLayer.Dtos.MailDtos
{
    public class MailRequestDto
    {
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string RecieverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
