using System;

class ArrCoef
{

// перемножение массивов
	static int[] multiply(int []A, int []B,
							int m, int n)
	{
		int[] res = new int[m + n - 1];

		for (int i = 0; i < m + n - 1; i++)
		{
			res[i] = 0;
		}

		for (int i = 0; i < m; i++)
		{
		
			for (int j = 0; j < n; j++)
			{
				res[i + j] += A[i] * B[j];
			}
		}

		return res;
	}

	// вывод полинома
	static void printPoly(int []poly, int n)
	{
		for (int i = 0; i < n; i++) {
			Console.Write(poly[i]);
			if (i != 0) {
				Console.Write("x^" + i);
			}
			if (i != n - 1) {
				Console.Write(" + ");
			}
		}
	}

// вывод результата перемножения полиномов в виде массива
	static void printArr(int []poly, int n)
	{
		for(int i = 0; i < n; i++){
			Console.WriteLine(poly[i]);
			if(i == 0){
				Console.WriteLine(" " + i);
			}
			if(i == n - 1){
				Console.WriteLine(" ");
			}
		}
	}
	

	
	public static void Main(String[] args)
	{
		// сам полином в виде массива
		int []A = {-1, 1};
        // второй полином в виде массива
		int []B = {2, 1};
		int m = A.Length;
		int n = B.Length;

		Console.WriteLine("Полином А");
		printPoly(A, m);
		Console.WriteLine("\nПолином В");
		printPoly(B, n);

		int[] res = multiply(A, B, m, n);

		Console.WriteLine("\nProduct polynomial is n");
		printPoly(res, m + n - 1);
		Console.WriteLine("\n массив : ");
		printArr(res, m+n-1);
		Console.WriteLine("\nТип :");
		Console.WriteLine(res.GetType());

	}
}

