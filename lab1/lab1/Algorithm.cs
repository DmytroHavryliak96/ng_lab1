using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Algorithm
    {
        public double[] alternative1;
        public double[] alternative2;
        public double[] alternative3;

        public double[] choices;

        public double[] maxValues;
        public double[] minValues;

        public double[] allValues;

        public double min = 0;
        public double max = 0;

        public Algorithm()
        {
            this.alternative1 = new double[4];
            this.alternative2 = new double[4];
            this.alternative3 = new double[4];
            this.choices = new double[3];
            this.maxValues = new double[3];
            this.minValues = new double[3];
            this.allValues = new double[12];
        }

        public double Avarage(double[] values) 
        {
            double Sum;
            double result;
            /*foreach(double value in values)
            {
                Sum += value;
            }
            result = Sum / values.Length;*/
            Sum = values.Sum();
            result = Sum / values.Length;
            return result;
        }

        public double MinValue(double[] values)
        {
            return values.Min();
        }

        public double MaxValue(double[] values)
        {
            return values.Max();
        }

        public void Laplace()
        {
            choices[0] = Avarage(alternative1);
            choices[1] = Avarage(alternative2);
            choices[2] = Avarage(alternative3);

            max = MaxValue(choices);
        }

        public void Wald()
        {
            choices[0] = MinValue(alternative1);
            choices[1] = MinValue(alternative2);
            choices[2] = MinValue(alternative3);

            max = MaxValue(choices);
        }

        public void Savage()
        {
            maxValues[0] = MaxValue(alternative1);
            maxValues[1] = MaxValue(alternative2);
            maxValues[2] = MaxValue(alternative3);

            for (int i = 0; i < 4; i++)
            {
                alternative1[i] = Math.Abs(alternative1[i] - maxValues[0]);
                alternative2[i] = Math.Abs(alternative2[i] - maxValues[1]);
                alternative3[i] = Math.Abs(alternative3[i] - maxValues[2]);
            }

            choices[0] = MaxValue(alternative1);
            choices[1] = MaxValue(alternative2);
            choices[2] = MaxValue(alternative3);

            min = MinValue(choices);

        }

        public void Hurwits()
        {
            maxValues[0] = MaxValue(alternative1);
            maxValues[1] = MaxValue(alternative2);
            maxValues[2] = MaxValue(alternative3);

            minValues[0] = MinValue(alternative1);
            minValues[1] = MinValue(alternative2);
            minValues[2] = MinValue(alternative3);

            for (int i = 0; i < 3; i++)
            {
                choices[i] = (maxValues[i] + minValues[i]) / 2;
            }

            int a = 0;
            for(int i = 0; i < 4; i++)
            {
                allValues[a] = alternative1[i];
                a++;
            }

            for (int i = 0; i < 4; i++)
            {
                allValues[a] = alternative2[i];
                a++;
            }

            for (int i = 0; i < 4; i++)
            {
                allValues[a] = alternative3[i];
                a++;
            }

            min = MinValue(allValues);
            max = MaxValue(allValues);
         
        }

        public void Compromise()
        {
            maxValues[0] = MaxValue(alternative1);
            maxValues[1] = MaxValue(alternative2);
            maxValues[2] = MaxValue(alternative3);

            for(int i = 0; i < 4; i++)
            {
                alternative1[i] = Math.Abs(alternative1[i] - maxValues[0]);
                alternative2[i] = Math.Abs(alternative2[i] - maxValues[1]);
                alternative3[i] = Math.Abs(alternative3[i] - maxValues[2]);
            }

            choices[0] = MaxValue(alternative1) / 2;
            choices[1] = MaxValue(alternative2) / 2;
            choices[2] = MaxValue(alternative3) / 2;

            min = MinValue(choices);
        }
    }
}
