using System.Collections.Generic;

namespace PathFollowing
{
	public enum Chars
	{
		Start = '@',
		End = 'X',
		Horizontal = '-',
		Vertical = '|',
		Empty = ' '
	}

	public class PathFollow
	{
		#region Fields

		char[,] matrix;
		public string Letters = "";
		public string PathAsCharacters = "";

		List<Direction> Directions = new List<Direction>() {
																new Direction() { x = 0, y = -1, c = (char)Chars.Horizontal },
																new Direction() { x = 0, y = 1, c = (char)Chars.Horizontal  },
																new Direction() { x = -1, y = 0, c = (char)Chars.Vertical  },
																new Direction() { x = 1, y = 0, c = (char)Chars.Vertical  }
															};

		#endregion

		#region Constructor

		public PathFollow(char[,] matrix)
		{ 
			this.matrix = matrix;
		}

		#endregion

		#region Methods

		public void StartPathFollowing()
		{
			Node startPosition = findStartPosition();

			Node node = FindPath(startPosition);

			if (node.Character == (char)Chars.End)
				getCharacters(startPosition);

		}


		private void getCharacters(Node node)
		{
			Node currentNode = node;

			while (currentNode != null)
			{
				PathAsCharacters += currentNode.Character;

				if (((currentNode.Character >= 65 && currentNode.Character <= 90) || (currentNode.Character >= 97 && currentNode.Character <= 122)) && currentNode.Character != (char)Chars.End)
					Letters += currentNode.Character;

				currentNode = currentNode.ChildNode;
			} 
		}

		private Node FindPath(Node node)
		{
			if (node.Character == (char)Chars.End || node.Character == (char)Chars.Empty || node == null)
				return node;

			Node nextNode = null;

			foreach (Direction dir in Directions)
			{

				int x = node.x + dir.x;
				int y = node.y + dir.y;


				if (x < 0 || x >= matrix.GetLength(0) || y < 0 || y >= matrix.GetLength(1) || matrix[x, y] == ' ' || matrix[x, y] == (char)Chars.Start)
					continue;

				if ((matrix[x, y] == (char)Chars.Horizontal && dir.c == (char)Chars.Horizontal) || (matrix[x, y] == (char)Chars.Vertical && dir.c == (char)Chars.Vertical))
				{
					if (Direction.Compare(node.direction, dir))
						continue;

					nextNode = followPath(x, y, dir, node);
					break;
				}
				else
				{
					nextNode = new Node(x, y, matrix[x, y], dir);
					node.ChildNode = nextNode;

				}
			}
			return FindPath(nextNode);
		}

		private Node followPath(int x, int y, Direction dir, Node node)
		{
			if (matrix[x, y] != (char)Chars.Horizontal && matrix[x, y] != (char)Chars.Vertical)
			{
				Node no = new Node(x, y, matrix[x, y], dir);
				node.ChildNode = no;
				return no;
			}

			x += dir.x;
			y += dir.y;

			Node n = new Node(x, y, dir.c, dir);
			node.ChildNode = n;

			return followPath(x, y, dir, n);
		}

		private Node findStartPosition()
		{
			for (int x = 0; x < matrix.GetLength(0); x++)
				for (int y = 0; y < matrix.GetLength(1); y++)
				{
					if (matrix[x, y] == (char)Chars.Start)
						return new Node(x, y, matrix[x, y], null);
				}

			return null;
		}

		#endregion 
	}
}
