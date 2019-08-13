
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

	public class Helper
	{
		public static bool IsLetter(char chr)
		{
			if ((chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
				return true;

			return false;
		}

		public static bool IsInDirection(char temp, char direction)
		{
			if ((temp == (char)Chars.Horizontal && direction == (char)Chars.Horizontal) || (temp == (char)Chars.Vertical && direction == (char)Chars.Vertical))
				return true;

			return false;
		} 
	}
}
