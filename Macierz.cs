using System;
namespace Macierze
{
    public class Macierz{
        private int rows;
        private int cols;
        private int[, ] matrix;
        public Macierz()
        {
            rows = 0;
            cols = 0;
            matrix = null;
        }
        public Macierz(int r, int c){
            this.rows = r;
            this.cols = c;
            matrix = new int[rows, cols];

            for(int i = 0 ; i < matrix.GetLength(0); i++)
            {
                for(int j = 0 ; j < matrix.GetLength(1); j++){
                    matrix[i, j] = 0;
                }
            }
        }
        public int getRows(){
            return rows;
        }
        public int getCols(){
            return cols;
        }
        public void losowanieMacierzy()
        {
            Random rand = new Random();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++){
                    matrix[i, j] = rand.Next(-30, 140);
                }
            }
        }
        public void wyswietlenieMacierzy()
        {
            Console.WriteLine("Macierz: ");
            for(int i = 0 ; i < rows; i++)
            {
                for(int j = 0 ; j < cols; j++){
                    Console.Write("{0,5}", matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public int wyznacznikMacierzy()
        {
            int wyznacznik;
            if(rows != cols || rows > 3 || cols >3){
                Console.WriteLine("Nie można policzyć wyznacznika macierzy, ta aplikacja działa tylko do macierzy 3x3");
            }
            else if(rows == 1 && cols == 1)
            {
                wyznacznik = matrix[0, 0];
                Console.WriteLine("Wyznacznik wynosi: "+ wyznacznik);
                return wyznacznik;
            }
            else if(rows == 2 && cols == 2)
            {
                wyznacznik = (matrix[0,0] * matrix[1,1]) - (matrix[0,1]*matrix[1,0]);
                Console.WriteLine("Wyznacznik wynosi: "+ wyznacznik);
                return wyznacznik;
            }
            else if(rows == 3 && cols == 3){
                int dodatnie = (matrix[0, 0] * matrix[1,1] * matrix[2,2]) + ( matrix[0,1]*matrix[1,2]*matrix[2,0])+ (matrix[0,2]*matrix[1,0]*matrix[2,1]);
                int ujemne = (matrix[2,0] * matrix[1,1] * matrix[0,2]) + (matrix[2,1]*matrix[1,2]*matrix[0,0]) + (matrix[2,2]*matrix[1,0]*matrix[0,1]);
                wyznacznik = dodatnie - ujemne;
                Console.WriteLine("Wyznacznik wynosi: "+ wyznacznik);
                return wyznacznik;
            }
            return 0;
        }
        public void odwracanieMacierzy()
        {
            Console.WriteLine("Odwrócona macierz: ");
            if( rows <= 3 && cols < 3){
                for(int i = 0 ; i < cols; i++)
                {
                    for(int j = 0; j < rows; j++)
                    {
                        Console.Write("{0,5}",matrix[j, i] + " "); //{0,5} zachowuje równe odstępy
                    }
                    Console.WriteLine();
                }
            }
            else{
                Console.WriteLine("Niestety nie umiem tego obliczyć");
            }
        }
    }   
}
