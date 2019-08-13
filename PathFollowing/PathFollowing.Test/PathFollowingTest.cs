using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PathFollowing.Test
{
	[TestClass]
	public class PathFollowingTest
	{


		static char[,] map = { { '@', '+', 'X',' ',' ',' ' },
						{ '|', '|', ' ',' ',' ',' ' },
						{ '+', '-', '-','M',' ',' ' },
						{ ' ', '|', ' ','|',' ',' ' },
						{ ' ', '+', '-','+',' ',' ' },
						{ ' ', ' ', ' ',' ',' ',' ' }
					};

		[TestMethod]
		public void TestMethod1()
		{
			PathFollow p = new PathFollow(map);
			p.StartPathFollowing();
			
		}
	}
}
