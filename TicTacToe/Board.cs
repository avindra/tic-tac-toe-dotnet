using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
	class Board
	{
		private btnSquare[] btnArray;

		/// <summary>
		/// The current orientation of the game board.
		/// </summary>
		private uint orientation = 0;

		/// <summary>
		/// The following is a matrix of all the possible board orientations.
		///	The purpose is that we can check a single possibility, and automatically
		///	rotate through the other possibilities instead of typing out 
		///	each and every possibility, which would take forever and would lead to 
		///	unnecessarily complex code.
		/// </summary>
		private static uint[][] orientations = {
			new uint[] { // north (standard orientation)
				0, 1, 2,
				3, 4, 5,
				6, 7, 8
			},
			new uint[] { // north flip
				2, 1, 0,
				5, 4, 3,
				8, 7, 6
			},
			new uint[] { // east
				2, 5, 8,
				1, 4, 7,
				0, 3, 6
			},
			new uint[] { // east flip
				8, 5, 2,
				7, 4, 1,
				6, 3, 0
			},
			new uint[] { // west
				6, 3, 0,
				7, 4, 1,
				8, 5, 2
			},
			new uint[] { // west flip
				0, 3, 6,
				1, 4, 7,
				2, 5, 8
			},
			new uint[] { // south
				8, 7, 6,
				5, 4, 3,
				2, 1, 0
			},
			new uint[] { // south flip
				6, 7, 8,
				3, 4, 5,
				0, 1, 2 
			}
		};

		/// <summary>
		/// The constructor for the Board object.
		/// </summary>
		/// <param name="btnArrayIn">The array of squares with which the board will be initialized.</param>
		public Board(btnSquare[] btnArrayIn)
		{
			btnArray = btnArrayIn;
		}

		/// <summary>
		/// Gets the square with respect to the current orientation.
		/// Looks incredibly simple and useless, but compared with older
		/// revisions, it saves tons of code and heavily increases
		/// the performance of this app.
		/// </summary>
		/// <param name="index">The index of the board you wish to retrieve.</param>
		/// <returns></returns>
		public btnSquare get(uint index)
		{
			return btnArray[orientations[orientation][index]];
		}

		/// <summary>
		/// Changes the board to the next orientation.
		/// 
		/// Returns whether or not the board has been iterated through
		/// all of it's orientations.
		/// </summary>
		public bool rotate()
		{
			if (orientation == orientations.Length - 1)
			{
				orientation = 0;
				return true;
			}
			++orientation;
			return false;
		}
	}
}
