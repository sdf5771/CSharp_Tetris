﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	class Game
	{
		Diagram now;
		internal Point NowPosition
		{
			get
			{
				if(now == null)
				{
					return new Point(0, 0);
				}
				return new Point(now.X, now.Y);
			}

		}
		internal static Game Singleton
		{
			get;
			private set;
		}
		static Game()
		{
			Singleton = new Game();
		}
		Game()
		{
			now = new Diagram();
		}

		internal bool MoveRIght()
		{
			if ((now.X+1) < GameRule.BX)
			{
				now.MoveRight();
				return true;
			}
			return false;
		}

		internal bool MoveLeft()
		{
			if(now.X>0)
			{
				now.MoveLeft();
				return true;
			}
			return false;
		}

		internal bool MoveDown()
		{
			if ((now.Y+1) < GameRule.BY)
			{
				now.MoveDown();
				return true;
			}
			return false;
		}

	}
}
