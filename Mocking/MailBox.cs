using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mocking
{
	public class MailBox : IMailModule
	{
		public int NumReceivedMessages;
		public List<Mail> Mails = new List<Mail>();
		public List<Mail> Draft = new List<Mail>();
		public List<Mail> SentMessages = new List<Mail>();
		public List<Mail> SentSpam = new List<Mail>();


		public MailBox()
		{

		}

		public void Add(Mail mail)
		{
			Mails.Add(mail);
			NumReceivedMessages++;
		}

		public string GetLatestMessageText()
		{
			return Mails[NumReceivedMessages-1].Content;
		}

		public void SendMail(Mail m, Employee e)
		{
			e.MailBox.Add(m);
		}

		public Mail GetEmailById(int id)
		{
			return Mails[id - 1];
		}

		public void AddToDraft(Mail m)
		{
			Draft.Add(m);
		}

		public void AddToSentMessages(Mail m)
		{
			SentMessages.Add(m);
		}

		public void AddToSentSpam(Mail m)
		{
			SentSpam.Add(m);
		}

		public List<Mail> GetAllMail()
		{
			return Mails;
		}

	}
}