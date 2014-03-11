/***************************************************************************
 *                                IAccount.cs
 *                            -------------------
 *   begin                : Marc 9, 2014
 *   copyright            : (C) The RunUO EC Software Team
 *   email                : mutila@gmail.com
 *
 *   $Id: IAccount.cs 856 2012-03-21 22:25:44Z eos $
 *
 ***************************************************************************/

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/

using System;

namespace Server.Accounting
{
	public interface IAccount : IComparable<IAccount>
	{
		string Username { get; set; }
		AccessLevel AccessLevel { get; set; }

		int Length { get; }
		int Limit { get; }
		int Count { get; }
		Mobile this[int index] { get; set; }

		void Delete();
		void SetPassword( string password );
		bool CheckPassword( string password );
	}
}
