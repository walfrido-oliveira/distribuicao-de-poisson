using System.Drawing;
namespace FREQUENCIA
{
    partial class frmFrequencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrequencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblLambida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColumn = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.btnRow = new System.Windows.Forms.Button();
            this.btnDelColumn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PossionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.dgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart);
            this.splitContainer1.Panel2.Controls.Add(this.dgv2);
            this.splitContainer1.Size = new System.Drawing.Size(1092, 616);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNS);
            this.panel2.Controls.Add(this.lblLambida);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 67);
            this.panel2.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Image = global::FREQUENCIA.Properties.Resources.immSave;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(262, 8);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(106, 35);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Image = global::FREQUENCIA.Properties.Resources.immImport;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(374, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(96, 35);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "IMPORTAR";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "λ (NS=λ .TS)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "NS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTS
            // 
            this.lblTS.AutoSize = true;
            this.lblTS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTS.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTS.Location = new System.Drawing.Point(103, 43);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(17, 19);
            this.lblTS.TabIndex = 22;
            this.lblTS.Text = "0";
            this.lblTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "TS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNS.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNS.Location = new System.Drawing.Point(103, 24);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(17, 19);
            this.lblNS.TabIndex = 21;
            this.lblNS.Text = "0";
            this.lblNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLambida
            // 
            this.lblLambida.AutoSize = true;
            this.lblLambida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLambida.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblLambida.Location = new System.Drawing.Point(103, 5);
            this.lblLambida.Name = "lblLambida";
            this.lblLambida.Size = new System.Drawing.Size(17, 19);
            this.lblLambida.TabIndex = 20;
            this.lblLambida.Text = "0";
            this.lblLambida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnColumn);
            this.panel1.Controls.Add(this.btnDelRow);
            this.panel1.Controls.Add(this.btnRow);
            this.panel1.Controls.Add(this.btnDelColumn);
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnColumn
            // 
            this.btnColumn.BackColor = System.Drawing.Color.Transparent;
            this.btnColumn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnColumn.FlatAppearance.BorderSize = 0;
            this.btnColumn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColumn.Image = global::FREQUENCIA.Properties.Resources.immAdd;
            this.btnColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColumn.Location = new System.Drawing.Point(3, 3);
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.Size = new System.Drawing.Size(94, 34);
            this.btnColumn.TabIndex = 1;
            this.btnColumn.Text = "COLUNA";
            this.btnColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColumn.UseVisualStyleBackColor = false;
            this.btnColumn.Click += new System.EventHandler(this.btnColumn_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelRow.FlatAppearance.BorderSize = 0;
            this.btnDelRow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDelRow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDelRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelRow.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRow.Image")));
            this.btnDelRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelRow.Location = new System.Drawing.Point(288, 3);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(79, 34);
            this.btnDelRow.TabIndex = 24;
            this.btnDelRow.Text = "LINHA";
            this.btnDelRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // btnRow
            // 
            this.btnRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRow.FlatAppearance.BorderSize = 0;
            this.btnRow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRow.Image = global::FREQUENCIA.Properties.Resources.immAdd;
            this.btnRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRow.Location = new System.Drawing.Point(103, 3);
            this.btnRow.Name = "btnRow";
            this.btnRow.Size = new System.Drawing.Size(79, 34);
            this.btnRow.TabIndex = 2;
            this.btnRow.Text = "LINHA";
            this.btnRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRow.UseVisualStyleBackColor = true;
            this.btnRow.Click += new System.EventHandler(this.btnRow_Click);
            // 
            // btnDelColumn
            // 
            this.btnDelColumn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelColumn.FlatAppearance.BorderSize = 0;
            this.btnDelColumn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDelColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDelColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelColumn.Image = ((System.Drawing.Image)(resources.GetObject("btnDelColumn.Image")));
            this.btnDelColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelColumn.Location = new System.Drawing.Point(188, 3);
            this.btnDelColumn.Name = "btnDelColumn";
            this.btnDelColumn.Size = new System.Drawing.Size(94, 34);
            this.btnDelColumn.TabIndex = 23;
            this.btnDelColumn.Text = " COLUNA";
            this.btnDelColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelColumn.UseVisualStyleBackColor = true;
            this.btnDelColumn.Click += new System.EventHandler(this.btnDelColumn_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(3, 121);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(473, 490);
            this.dgv.TabIndex = 19;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineColor = System.Drawing.Color.Gray;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Beige;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90.55851F;
            chartArea1.InnerPlotPosition.Width = 88.27039F;
            chartArea1.InnerPlotPosition.X = 9.65586F;
            chartArea1.InnerPlotPosition.Y = 2.23404F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 75.94983F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea1.ShadowColor = System.Drawing.Color.White;
            chartArea1.ShadowOffset = 3;
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 7.645875F;
            legend1.Position.Width = 15.05017F;
            legend1.Position.X = 81.94983F;
            legend1.Position.Y = 3F;
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 105);
            this.chart.Name = "chart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "FR";
            series1.ShadowOffset = 5;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Possion";
            series2.ShadowOffset = 5;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(599, 498);
            this.chart.TabIndex = 7;
            this.chart.Text = "chtAnaliseLicitacao";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToOrderColumns = true;
            this.dgv2.AllowUserToResizeColumns = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xColumn,
            this.FAColumn,
            this.FRColumn,
            this.PossionColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv2.Location = new System.Drawing.Point(0, -1);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.ShowCellErrors = false;
            this.dgv2.ShowCellToolTips = false;
            this.dgv2.ShowEditingIcon = false;
            this.dgv2.ShowRowErrors = false;
            this.dgv2.Size = new System.Drawing.Size(602, 100);
            this.dgv2.TabIndex = 1;
            // 
            // xColumn
            // 
            this.xColumn.HeaderText = "X";
            this.xColumn.Name = "xColumn";
            // 
            // FAColumn
            // 
            this.FAColumn.HeaderText = "FA";
            this.FAColumn.Name = "FAColumn";
            // 
            // FRColumn
            // 
            this.FRColumn.HeaderText = "FR";
            this.FRColumn.Name = "FRColumn";
            // 
            // PossionColumn
            // 
            this.PossionColumn.HeaderText = "POSSION";
            this.PossionColumn.Name = "PossionColumn";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML (*.xml)|*.xml";
            // 
            // frmFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 616);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmFrequencia";
            this.ShowIcon = false;
            this.Text = "Cálculo de Frequência";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnColumn;
        private System.Windows.Forms.Button btnRow;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblTS;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.Label lblLambida;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PossionColumn;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.Button btnDelColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

