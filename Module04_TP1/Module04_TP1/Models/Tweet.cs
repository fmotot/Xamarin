using System;
using System.Collections.Generic;
using System.Text;

namespace Module04_TP1.Models
{
    public class Tweet
    {
		private int id;
		private String login;
		private String pseudo;
		private String text;
		private DateTime creationDate;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public String Login
		{
			get { return login; }
			set { login = value; }
		}


		public String Pseudo
		{
			get { return pseudo; }
			set { pseudo = value; }
		}


		public DateTime CreationDate
		{
			get { return creationDate; }
			set { creationDate = value; }
		}


		public String Text
		{
			get { return text; }
			set { text = value; }
		}

	}
}
