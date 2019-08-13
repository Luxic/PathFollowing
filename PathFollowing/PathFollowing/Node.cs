namespace PathFollowing
{
	public class Node
	{

		public int x;
		public int y;

		public Direction direction;

		public Node ChildNode { get; set; }

		public char Character { get; set; }

		public Node()
		{}

		public Node(int x, int y, char c, Direction d)
		{
			this.Character = c;
			this.x = x;
			this.y = y;
			this.direction = d;
		}
	}
}
