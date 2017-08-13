using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FREQUENCIA
{
    class Frequencia
    {
        public DataGridViewRowCollection Rows { get; set; }
        public int ColumnCount { get; set; }

        public double NS
        {
            get { return calcNS(); } 
        }

        public double TS
        {
            get { return calcTS(); }
        }

        public double Lambda 
        {
            get
            {
                if (TS == 0)
                {
                    return 0;
                }
                return NS / TS;
            }
        }

        public System.Collections.Generic.HashSet<long> Intervalos
        {
            get { return countValores(); }
        }

        public Frequencia(DataGridViewRowCollection rows, int columnCount)
        {
            this.Rows = rows;
            this.ColumnCount = columnCount;
        }

        private double calcNS()
        {
            double soma = 0;
            foreach (DataGridViewRow row in Rows)
            {
                for (int i = 0; i < ColumnCount; i++)
                {
                    soma +=  Convert.ToDouble(row.Cells[i].Value); 
                }
            }
            return soma;
        }

        private double calcTS()
        {
            double count = 0;
            foreach (DataGridViewRow row in Rows)
            {
                for (int i = 0; i < ColumnCount; i++)
                {
                    count++; 
                }
            }
            return count;
        }

        public int contValores(double num)
        {
            int count = 0;
            foreach (DataGridViewRow row in Rows)
            {
                for (int i = 0; i < ColumnCount; i++)
                {
                    if (Convert.ToInt32(row.Cells[i].Value) == num) 
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private System.Collections.Generic.HashSet<long> countValores()
        {
            System.Collections.Generic.HashSet<long> nums = new HashSet<long>();
            foreach (DataGridViewRow row in Rows)
            {
                for (int i = 0; i < ColumnCount; i++)
                {
                    if (!nums.Contains(Convert.ToInt64(row.Cells[i].Value)))
                    {
                        nums.Add(Convert.ToInt64(row.Cells[i].Value));
                    }
                }
            }
            return nums;
        }

        public double calcPossion(long x)
        {
            return (Math.Pow(this.Lambda,x) * Math.Pow(Math.E,this.Lambda * -1)) / fatotial(x);
        }

        private double fatotial(long x)
        {
            if (x == 1 || x == 0) return 1;
            return fatotial(x - 1) * x;
        
        }
    }
}
