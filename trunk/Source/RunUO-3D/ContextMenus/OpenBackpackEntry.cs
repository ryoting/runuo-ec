/***************************************************************************
 *                            OpenBackpackEntry.cs
 *                            -------------------
 *   begin                : Marc 9, 2014
 *   copyright            : (C) The RunUO EC Software Team
 *   email                : mutila@gmail.com
 *
 *   $Id: OpenBackpackEntry.cs 4 2006-06-15 04:28:39Z mark $
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
using Server.Items;

namespace Server.ContextMenus
{
	public class OpenBackpackEntry : ContextMenuEntry
	{
		private Mobile m_Mobile;

		public OpenBackpackEntry( Mobile m ) : base( 6145 )
		{
			m_Mobile = m;
		}

		public override void OnClick()
		{
			m_Mobile.Use( m_Mobile.Backpack );
		}
	}
}