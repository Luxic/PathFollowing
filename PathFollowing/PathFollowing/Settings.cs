using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFollowing
{

 

	public class Settings
	{

		char[,] map = { { '@', ' ', '+','-','+',' ' },
						{ '|', ' ', '|',' ','|',' ' },
						{ 'A', ' ', '|',' ','|',' ' },
						{ '+', '-', '-','-','+',' ' },
						{ ' ', ' ', '|',' ',' ',' ' },
						{ 'X', '-', '+',' ',' ',' ' }
					};


		char[,] map2 = { { '@', ' ', ' ','-','+',' ' },
						{ '|', ' ', ' ',' ','|',' ' },
						{ '|', ' ', ' ',' ','|',' ' },
						{ '|', ' ', 'X',' ','+',' ' },
						{ '+', '-', '+',' ',' ',' ' },
						{ ' ', ' ', ' ',' ',' ',' ' }
					};

		char[,] map3 = { { '@', ' ', ' ','-',' ',' ' },
						{ '|', ' ', '+','+',' ',' ' },
						{ '|', ' ', '|','|',' ',' ' },
						{ '|', ' ', 'B','C','-','X' },
						{ '+', '-', '+',' ',' ',' ' },
						{ ' ', ' ', ' ',' ',' ',' ' }
					};

		char[,] map4 = { { '@', '+', 'X',' ',' ',' ' },
						{ '|', '|', ' ',' ',' ',' ' },
						{ '+', '-', '-','M',' ',' ' },
						{ ' ', '|', ' ','|',' ',' ' },
						{ ' ', '+', '-','+',' ',' ' },
						{ ' ', ' ', ' ',' ',' ',' ' }
					};

		public static int NodeSize = 40;
	}
}







//int x;
//int y;
//char c = node.Character;
//// bool followDirection =  node.Character == '-' || node.Character == '|' ? true : false;

//if (c == '-')
//{
//	return null;
//}
//else if (c == '|')
//{
//	return null;
//}
//else
//{
//	if (isValidPoint(matrix, node.x - 1, node.y))
//	{
//		x = node.x - 1;
//		y = node.y;
//	}
//	else if (isValidPoint(matrix, node.x + 1, node.y))
//	{
//		x = node.x + 1;
//		y = node.y;
//	}

//	else if (isValidPoint(matrix, node.x, node.y - 1))
//	{
//		x = node.x;
//		y = node.y - 1;
//	}

//	else if (isValidPoint(matrix, node.x, node.y + 1))
//	{
//		x = node.x;
//		y = node.y + 1;
//	}
//	else
//		return null;

//	Node nextNode = new Node(x, y, matrix[x, y]);
//	node.ChildNode = nextNode;

//	return nextNode;
//}