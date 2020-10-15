using MathNet.Numerics.Distributions;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Threading;

namespace Numeric
{
    class Program
    {
        static void Main(string[] args)
        {
            var netCoreVer = System.Environment.Version; // 3.0.0
            var runtimeVer = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;

            double[] data = new double[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var mean = Statistics.Mean(data);
            var stddiv = Statistics.StandardDeviation(data);
            var pstddiv = Statistics.PopulationStandardDeviation(data);
            var variance = Statistics.Variance(data);
            var median = Statistics.Median(data);
            var lowerQuartile = Statistics.LowerQuartile(data);
            var upperQuartile = Statistics.UpperQuartile(data);
            var interQuartileRange = Statistics.InterquartileRange(data);
            var min = Statistics.Minimum(data);
            var max = Statistics.Maximum(data);

            var A = new DenseMatrix(2, 2) ;
            A[0, 0] = 1;
            A[0, 1] = 2;
            A[1, 0] = -1;
            A[1, 1] = 4;

            Console.WriteLine(A);
            Console.WriteLine(A.Evd().EigenValues);
            Console.WriteLine("evector  "+ A.Evd().EigenVectors);
            Console.WriteLine(A.Power(2));
            Console.WriteLine(A.Inverse());
            Console.WriteLine(A.QR().Q);
            Console.WriteLine(A.LU().L );
            Console.WriteLine(A.LU().U);
            Console.WriteLine(A.LU().L* A.LU().U);
            Console.WriteLine(A.QR().Q* A.QR().R);
            Console.WriteLine(A.LU().P);


            // var matrix4 = new DenseMatrix(2, 2,  3.0 ); 

            Console.ReadKey();
        }
    }
}
