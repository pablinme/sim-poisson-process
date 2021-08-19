using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulation_Lab17
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBoxNumSim.Text);
            double[] lambdas = new double[3];
            lambdas[0] = double.Parse(textBoxInten1.Text);
            lambdas[1] = double.Parse(textBoxInten2.Text);

            lambdas[2] = lambdas[0] + lambdas[1];
            textBoxInten3.Text = lambdas[2].ToString();

            int temp1, temp2, temp3;
            double sumPoisson1 = 0;
            double sumPoisson2 = 0;
            double sumPoisson3 = 0;
            double sumPoissonSquared1 = 0;
            double sumPoissonSquared2 = 0;
            double sumPoissonSquared3 = 0;

            for (int i = 0; i < n; i++)
            {
                temp1 = generateSinglePoissonVariable(lambdas[0]);
                temp2 = generateSinglePoissonVariable(lambdas[1]);
                temp3 = generateSinglePoissonVariable(lambdas[2]);

                sumPoisson1 += temp1;
                sumPoisson2 += temp2;
                sumPoisson3 += temp3;

                sumPoissonSquared1 += (temp1 * temp1);
                sumPoissonSquared2 += (temp2 * temp2);
                sumPoissonSquared3 += (temp3 * temp3);
            }

            double meanL1 = sumPoisson1 / ((double) n);
            double meanL2 = sumPoisson2 / ((double) n);
            double meanL3 = sumPoisson3 / ((double) n);
            double varianceL1 = sumPoissonSquared1 / ((double) n) - (meanL1 * meanL1);
            double varianceL2 = sumPoissonSquared2 / ((double) n) - (meanL2 * meanL2);
            double varianceL3 = sumPoissonSquared3 / ((double) n) - (meanL3 * meanL3);

            double averageError = Math.Abs(meanL3 - (meanL1 + meanL2)) / Math.Abs((meanL1 + meanL2));
            double varianceError = Math.Abs(varianceL3 - (varianceL1 + varianceL2)) / Math.Abs((varianceL1 + varianceL2));

            textBoxL1Mean.Text = "Average: " + meanL1.ToString("0.0000");
            textBoxL2Mean.Text = "Average: " + meanL2.ToString("0.0000");
            textBoxL3Mean.Text = "Average: " + meanL3.ToString("0.0000") + " (error = " + Math.Round((averageError * 100)).ToString() + "%)";
            textBoxL1Variance.Text = "Variance: " + varianceL1.ToString("0.0000");
            textBoxL2Variance.Text = "Variance: " + varianceL2.ToString("0.0000");
            textBoxL3Variance.Text = "Variance: " + varianceL3.ToString("0.0000") + " (error = " + Math.Round((varianceError * 100)).ToString() + "%)";
        }

        public int generateSinglePoissonVariable(double lambda)
        {
            int poissonVariable;
            double randomVariable;
            double randomVariableProduct;
            double precision = Math.Exp(-lambda);
            
            poissonVariable = -1;
            randomVariableProduct = 1;

            do
            {
                randomVariable = random.NextDouble();
                randomVariableProduct *= randomVariable;
                poissonVariable++;

            } while (randomVariableProduct > precision);

            return poissonVariable;
        }
    }
}
