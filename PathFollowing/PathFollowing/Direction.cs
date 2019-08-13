namespace PathFollowing
{
	public class Direction
	{
		public int x;
		public int y;
		public char c;

		public static bool Compare(Direction direction1, Direction direction2)
		{
			bool ret = false;

			switch (direction1?.c)
			{
				case (char)Chars.Vertical:
					if (direction1.x != direction2.x && direction1.y == direction2.y)
						ret = true;
					break;
				case (char)Chars.Horizontal:
					if (direction1.y != direction2.y && direction1.x == direction2.x)
						ret = true;
					break;
				default:
					break;
			}

			return ret;
		}
	}
}
