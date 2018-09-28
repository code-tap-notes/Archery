using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace Archery.Validators
{
	public class CrypterPasword : MD5

	{
		public override void Initialize()
		{
			throw new NotImplementedException();
		}

		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			throw new NotImplementedException();
		}

		protected override byte[] HashFinal()
		{
			throw new NotImplementedException();
		}
		public override string Create(string Password)
		{
			return this.Create();
		}
	}
}