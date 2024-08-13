using MySql.Data.MySqlClient;

using System;
using System.Linq;

namespace ScientificCalculator
{
    public class Calculator
    {

        public double Sin(double value) => Math.Sin(value);
        public double Cos(double value) => Math.Cos(value);
        public double Tan(double value) => Math.Tan(value);


        public double Log(double value) => Math.Log10(value);
        public double Ln(double value) => Math.Log(value);


        public double Exp(double value) => Math.Exp(value);
        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);


        public double Mean(double[] values) => values.Average();
        public double Median(double[] values)
        {
            Array.Sort(values);
            int n = values.Length;
            return n % 2 == 0 ? (values[n / 2 - 1] + values[n / 2]) / 2.0 : values[n / 2];
        }
        public double StandardDeviation(double[] values)
        {
            double mean = Mean(values);
            double variance = values.Average(v => Math.Pow(v - mean, 2));
            return Math.Sqrt(variance);
        }


        public void LogCalculation(string calculation, string connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO CalculationHistory (Calculation, Timestamp) VALUES (@calculation, @timestamp)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@calculation", calculation);
                    command.Parameters.AddWithValue("@timestamp", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}