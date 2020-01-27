using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquation2ndVersion
{
    class Equation
    {
        public double[] Array { private set; get; }

        public Equation(string input)
        {
            this.Array = this.inputToArray(input);
        }

        public Equation(double[] input)
        {
            this.Array = input;
        }

        private double[] inputToArray(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ' && input[i] != '-' && !double.TryParse(input[i].ToString(), out double r))
                    throw new Exception("Wrong input");
            }

            while //(input.Contains("  ")) input = input.Replace("  ", " ");
            //if
             (input.StartsWith(" ")) input = input.Substring(1, input.Length - 1);
            if (input.EndsWith(" ")) input = input.Substring(0, input.Length - 1);

            string[] array = input.Split(' ');
            double[] res = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
                res[i] = Double.Parse(array[i]);

            return res;
        }

        private static string formatEquation(double[] array)
        {
            int ind = 1;
            string equation = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                    equation += $"{array[i]}*x{ind}";
                else if (i == array.Length - 1)
                    equation += " = " + array[i];
                else
                    equation += $" + {array[i]}*x{ind}";

                ind++;
            }

            return equation;
        }

        public override string ToString()
        {
            return formatEquation(this.Array);
        }
    }
}

