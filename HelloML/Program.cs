using System;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace HelloML
{
    class Program
    {
        // STEP 1: Define your data structures
        // IrisData is used to provide training data, and as
        // input for prediction operations
        // - First 4 properties are inputs/features used to predict the label
        // - Label is what you are predicting, and is only set when training
        public class IrisData
        {
            [LoadColumn(0)]
            public float SepalLength;

            [LoadColumn(1)]
            public float SepalWidth;

            [LoadColumn(2)]
            public float PetalLength;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
