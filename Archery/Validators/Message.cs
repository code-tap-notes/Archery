using Archery.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Archery.Validators
{
	public sealed class Message: BaseController
	{
		public MessageType MessageType { get; private set; } 
		public string Text { get; private set; }

		public Message(MessageType messageType, string text)
		{
			this.MessageType = messageType;
			Text = text;
		}

	}
	public enum MessageType
	{
		Success,Erreur
	}
}