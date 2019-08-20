using System;

namespace PathFollowing
{
	class Program
	{
		
		static void Main(string[] args)
		{

			char[,] matrix = TestMatrix.Matrix;

			PathFollow f = new PathFollow(matrix);
			f.StartPathFollowing();

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j]);
				}
			Console.Write(Environment.NewLine);
			}

			Console.WriteLine("Path as characters: " + f.PathAsCharacters);
			Console.WriteLine("Letters: " + f.Letters);

			Console.ReadLine();
		}
	}
}
