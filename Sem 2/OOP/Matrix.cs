using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Matrix
    {
        public static Matrix Empty;
        double[,] values;
        public int lines { get { return values.GetLength(0); } }
        public int colums { get { return values.GetLength(1); } }
        public Matrix() { }
        public Matrix(int lin, int col)
        {
            values = new double[lin, col];
        }
        public Matrix(double[,] values) 
        {
            this.values = values;
        }
        public Matrix(string fileName) 
        {
            TextReader reader= new StreamReader(fileName);
            List<string> data = new List<string>();
            string buffer;
            while ((buffer = reader.ReadLine()) != null)
            {
                data.Add(buffer);
            }
            reader.Close();

            values  = new double[data.Count, data[0].Split(' ').Length];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                string[] temp = data[i].Split(' ');
                for(int j=0; j < values.GetLength(1); j++)
                {
                    values[i,j] = double.Parse(temp[j]);
                }
            }
        }
        public Matrix(Matrix toCopy)
        {
            this.values = new double[toCopy.values.GetLength(0), toCopy.values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    this.values[i, j] = toCopy.values[i, j];
                }
            }
        }

        public List<string> View()
        {
            List<string> toReturn = new List<string>();
            for (int i = 0; i < values.GetLength(0); i++)
            {
                string buffer = "";
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    buffer += values[i, j].ToString();
                }
                toReturn.Add(buffer);
            }
           
            return toReturn;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if(a.lines != b.lines || a.colums != b.colums)
            {
                return Matrix.Empty;
            }
            else
            {
                Matrix toReturn = new Matrix(a.lines, a.colums);
                for(int i=0; i < a.lines; i++)
                {
                    for(int j = 0; j < a.colums; j++)
                    {
                        toReturn.values[i,j] = a.values[i,j] + b.values[i,j];
                    }
                }
                return toReturn;
            }
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if(a.colums != b.lines)
            {
                return Matrix.Empty;
            }
            else
            {
                Matrix toReturn = new Matrix(a.lines, b.colums);
                for(int i = 0; i < a.lines; i++)
                {
                    for(int j = 0; j < b.colums; j++)
                    {
                        toReturn.values[i, j] = 0;
                        for(int k = 0; k < a.colums; k++)
                        {
                            toReturn.values[i, j] += a.values[i, k] * b.values[k, j];
                        }
                    }
                }
                return toReturn;
            }
        }
    }
}
