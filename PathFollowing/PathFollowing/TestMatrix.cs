
namespace PathFollowing
{

	public class TestMatrix
	{

		public static char[,] Matrix = {
											{ '@', ' ', '+','-','+',' ' },
											{ '|', ' ', '|',' ','C',' ' },
											{ 'A', ' ', '|',' ','|',' ' },
											{ '+', '-', '-','-','+',' ' },
											{ ' ', ' ', '|',' ',' ',' ' },
											{ 'X', '-', '+',' ',' ',' ' }
									};


		public static char[,] Matrix2 = {
											{'@', ' ', ' ','-','+',' ' },
											{ '|', ' ', ' ',' ','|',' ' },
											{ '|', ' ', ' ',' ','|',' ' },
											{ '|', ' ', 'X',' ','+',' ' },
											{ '+', '-', '+',' ',' ',' ' },
											{ ' ', ' ', ' ',' ',' ',' ' }
										};

		public static char[,] Matrix3 = {
											{ '@', ' ', ' ',' ',' ',' ' },
											{ '|', ' ', '+','+',' ',' ' },
											{ '|', ' ', '|','|',' ',' ' },
											{ '|', ' ', 'B','C','-','X' },
											{ '+', '-', '+',' ',' ',' ' },
											{ ' ', ' ', ' ',' ',' ',' ' }
										};	

		public static char[,] Matrix4 = {
											{ '@', '+', 'X',' ',' ',' ' },
											{ '|', '|', ' ',' ',' ',' ' },
											{ '+', '-', '-','M',' ',' ' },
											{ ' ', '|', ' ','|',' ',' ' },
											{ ' ', '+', '-','+',' ',' ' },
											{ ' ', ' ', ' ',' ',' ',' ' }
										};
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