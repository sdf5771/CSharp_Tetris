﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	class Diagram
	{
		internal int X
		{
			get;
			private set;
		}

		internal int Y
		{
			get;
			private set;
		}
		internal Diagram()
		{
			Reset();
		}
		internal void Reset()
		{
			X = GameRule.SX;
			Y = GameRule.SY;
		}
		internal void MoveLeft()
		{
			X--;
		}
		internal void MoveRight()
		{
			X++;
		}
		internal void MoveDown()
		{
			Y++;
		}
	}
}
