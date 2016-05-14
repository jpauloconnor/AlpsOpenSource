using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COllections_Multidimensional_RectangularArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangular arrays allow columns and rows.
            //Number of commas denote number of dimensions
  
            int[,] numbers = new int[,]
            {
                {0,1,2},
                {1,2,0},
                {2,0,1}
            };


            //Three dimensional!!!
            var cuboid = new int[,,]
            {
                {
                    { 1, 2, 3, 4, 5 },
                    { 2, 3, 4, 5, 6 },
                    { 3, 4, 5, 6, 7 }
                },
                {
                    { 2, 3, 4, 5, 6 },
                    { 3, 4, 5, 6, 7 },
                    { 4, 5, 6, 7, 8 }
                },
            };
        }
    }
}
