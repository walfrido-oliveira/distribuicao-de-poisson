using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FREQUENCIA
{
    public partial class frmFrequencia : Form
    {
        private Frequencia frequencia;

        public frmFrequencia()
        {
            InitializeComponent();
            adicionaColunaGrid1();
            this.dgv.Rows.Add();
            this.frequencia = new Frequencia(dgv.Rows, dgv.ColumnCount);
            configuraChart();
        }

        private void btnColumn_Click(object sender, EventArgs e)
        {
            adicionaColunaGrid1();
            frequencia.Rows = this.dgv.Rows;
            frequencia.ColumnCount = this.dgv.ColumnCount;
            adicionaLinhaGrid2();
            setLabels();
            alimentaChart();
        }

        private void btnRow_Click(object sender, EventArgs e)
        {
            if (this.dgv.ColumnCount > 0)
            {
                adicionaRowGrid1();
            }
        }

        private void adicionaRowGrid1()
        {
            this.dgv.Rows.Add();
            frequencia.Rows = this.dgv.Rows;
            frequencia.ColumnCount = this.dgv.ColumnCount;
            adicionaLinhaGrid2();
            setLabels();
            alimentaChart();
        }
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setLabels();
            adicionaLinhaGrid2();
            alimentaChart();
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0.0;      
            e.Cancel = false;
        }

        private void setLabels()
        {
            this.lblNS.Text = String.Format("{0:N3}", frequencia.NS);
            this.lblTS.Text = String.Format("{0:N0}", frequencia.TS);
            this.lblLambida.Text = String.Format("{0:N3}", frequencia.Lambda);
        }

        private void adicionaColunaGrid1()
        {
            DataGridViewTextBoxColumn txt = new DataGridViewTextBoxColumn();
            txt.Name = this.dgv.ColumnCount.ToString();
            txt.HeaderText = "";
            txt.ValueType = typeof(long);
            this.dgv.Columns.Add(txt);
        }

        private void adicionaLinhaGrid2()
        {
            this.dgv2.Rows.Clear();
            double ts = frequencia.TS;
            foreach (long d in frequencia.Intervalos)
            {
                int countV = frequencia.contValores(d);
                this.dgv2.Rows.Add(d, countV, Math.Round(countV / ts,3), Math.Round(frequencia.calcPossion(d),3));
            }
            this.dgv2.Sort(this.dgv2.Columns[0], ListSortDirection.Ascending);
        }

        private void configuraChart()
        {
            this.chart.ChartAreas[0].AxisY.Title = "POSSION X FREQUENCIA RELATIVA";
            this.chart.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            this.chart.Series[0].BorderWidth = 5;
            this.chart.Series[1].BorderWidth = 5;
            this.chart.Series[0].IsVisibleInLegend = true;
        }

        private void alimentaChart()
        {
            System.Collections.Generic.List<double> lista = new List<double>();
            System.Collections.Generic.List<int> lista2 = new List<int>();
            System.Collections.Generic.List<double> lista3 = new List<double>();
            foreach(DataGridViewRow row in this.dgv2.Rows)
            {
                lista.Add(Convert.ToDouble(row.Cells[3].Value));
                lista2.Add(Convert.ToInt32(row.Cells[0].Value));
                lista3.Add(Convert.ToDouble(row.Cells[2].Value));
            }
            
            this.chart.Series[0].Points.DataBindXY(lista2,lista);
            this.chart.Series[1].Points.DataBindXY(lista2,lista3);
            this.chart.Series[0].IsValueShownAsLabel = true;
            this.chart.Series[1].IsValueShownAsLabel = true;
        }

        private void btnDelColumn_Click(object sender, EventArgs e)
        {
            if (this.dgv.CurrentCell != null)
            {
                this.dgv.Columns.RemoveAt(this.dgv.CurrentCell.ColumnIndex);
                frequencia.Rows = this.dgv.Rows;
                frequencia.ColumnCount = this.dgv.ColumnCount;
                adicionaLinhaGrid2();
                setLabels();
                alimentaChart();
            }
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (this.dgv.CurrentRow != null)
            {
                this.dgv.Rows.RemoveAt(this.dgv.CurrentRow.Index);
                frequencia.Rows = this.dgv.Rows;
                frequencia.ColumnCount = this.dgv.ColumnCount;
                adicionaLinhaGrid2();
                setLabels();
                alimentaChart();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Xml.XmlTextWriter xml = new System.Xml.XmlTextWriter(this.saveFileDialog1.FileName, null);
                xml.WriteStartDocument();
                xml.WriteStartElement("datagridview");
                foreach (DataGridViewRow row in this.dgv.Rows)
                {
                    xml.WriteStartElement("row");
                    for (int i = 0; i < this.dgv.ColumnCount; i++)
                    {
                        xml.WriteStartElement("column");
                        xml.WriteElementString("value", row.Cells[i].Value.ToString());
                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
                xml.Close();
            } 
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.dgv.Columns.Clear();
                int countRow = 0;
                int countCell = 0;
                int countColumn = 0;
                List<int> lista = new List<int>();
                System.Xml.XmlTextReader xml = new System.Xml.XmlTextReader(this.openFileDialog1.FileName);
                while (xml.Read())
                {
                    switch (xml.NodeType )
                    {
                        case System.Xml.XmlNodeType.Element:
                            switch (xml.Name)
                            {
                                case "row":
                                    countRow++;
                                    break;
                                case "column":
                                    countCell++;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case System.Xml.XmlNodeType.Text:
                            lista.Add(Convert.ToInt32(xml.Value));
                            break;
                        default:
                            break;
                    }
                }
                countColumn = countCell / countRow;
                for (int i = 0; i < countColumn; i++)
                {
                    adicionaColunaGrid1();
                }
                for (int i = 0; i < countRow; i++)
                {
                    adicionaRowGrid1();
                }
                int index = 0;
                foreach (DataGridViewRow row in this.dgv.Rows)
                {
                    for (int i = 0; i < this.dgv.ColumnCount; i++)
                    {
                        row.Cells[i].Value = lista[index];
                        index++;
                    }
                }
        
                frequencia.Rows = this.dgv.Rows;
                frequencia.ColumnCount = this.dgv.ColumnCount;
                adicionaLinhaGrid2();
                setLabels();
                alimentaChart();
            }
        }
    }
}
