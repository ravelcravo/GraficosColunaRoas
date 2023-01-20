using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace graficos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GeraGraficos();
        }

        

        public void GeraGraficos()
        {
            CH_AnaliseConversao();
            CH_ValorInvestido();
            CH_TotalLeads();
            CH_CustoPorLead();
        }
        private void CH_AnaliseConversao()
        {
            ch_AnaliseConversao.Series.Clear();
            ch_AnaliseConversao.Legends.Clear();
            ch_AnaliseConversao.Titles.Clear();


            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Text = "Análise de Conversão";
            ch_AnaliseConversao.Titles.Add(title);


            //inserir legenda
            Legend legend = new Legend();
            ch_AnaliseConversao.Legends.Add(legend);
            ch_AnaliseConversao.Legends[0].Title = "Legenda";
            ch_AnaliseConversao.Legends[0].BackColor = Color.Black;
            ch_AnaliseConversao.Legends[0].ForeColor = Color.White;


            ch_AnaliseConversao.Legends[0].Alignment = StringAlignment.Near;



            //titulos dos eixos x e y
            ch_AnaliseConversao.ChartAreas[0].AxisX.Title = "Ano de 2020";
            ch_AnaliseConversao.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            ch_AnaliseConversao.ChartAreas[0].AxisY.Title = "Milhares de R$";
            ch_AnaliseConversao.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //remover grades verticais
            ch_AnaliseConversao.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            ch_AnaliseConversao.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            //cor de fundo
            ch_AnaliseConversao.BackColor = Color.Black;
            ch_AnaliseConversao.ChartAreas[0].BackColor = Color.Black;


            //vendas reais
            ch_AnaliseConversao.Series.Add("conversao");
            ch_AnaliseConversao.Series["conversao"].LegendText = "Conversão";
            ch_AnaliseConversao.Series["conversao"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


            ch_AnaliseConversao.Series["conversao"].Points.AddXY("Janeiro", 140);
            ch_AnaliseConversao.Series["conversao"].Points.AddXY("Fevereiro", 110);
            ch_AnaliseConversao.Series["conversao"].Points.AddXY("Março", 90);
            ch_AnaliseConversao.Series["conversao"].Points.AddXY("Abril", 115);
            ch_AnaliseConversao.Series["conversao"].Points.AddXY("Maio", 130);
            ch_AnaliseConversao.Series["conversao"].Points.AddXY("Junho", 150);

            ch_AnaliseConversao.Series["conversao"].Color = Color.Goldenrod;
            ch_AnaliseConversao.Series["conversao"].BackSecondaryColor = Color.Red;
            ch_AnaliseConversao.Series["conversao"].LabelForeColor = Color.White;
            ch_AnaliseConversao.Series["conversao"].BackGradientStyle = GradientStyle.TopBottom;
            ch_AnaliseConversao.Series["conversao"].IsValueShownAsLabel = true;

        }
        private void CH_ValorInvestido()
        {
            ch_investido.Series.Clear();
            ch_investido.Legends.Clear();
            ch_investido.Titles.Clear();


            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Text = "Valor Investido";
            ch_investido.Titles.Add(title);

            //inserir legenda
            Legend legend = new Legend();
            ch_investido.Legends.Add(legend);
            ch_investido.Legends[0].Title = "Legenda";
            ch_investido.Legends[0].BackColor = Color.Black;
            ch_investido.Legends[0].ForeColor = Color.White;


            ch_investido.Legends[0].Alignment = StringAlignment.Near;



            //titulos dos eixos x e y
            ch_investido.ChartAreas[0].AxisX.Title = "Ano de 2020";
            ch_investido.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            ch_investido.ChartAreas[0].AxisY.Title = "Milhares de R$";
            ch_investido.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //remover grades verticais
            ch_investido.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            ch_investido.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            //cor de fundo
            ch_investido.BackColor = Color.Black;
            ch_investido.ChartAreas[0].BackColor = Color.Black;


            //vendas reais
            ch_investido.Series.Add("investido");
            ch_investido.Series["investido"].LegendText = "Valor Investido";
            ch_investido.Series["investido"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;

            ch_investido.Series["investido"].Color = Color.Green;
            ch_investido.Series["investido"].BackSecondaryColor = Color.LightSeaGreen;
            ch_investido.Series["investido"].LabelForeColor = Color.White;
            ch_investido.Series["investido"].BackGradientStyle = GradientStyle.TopBottom;

            ch_investido.Series["investido"].Points.AddXY("Janeiro", 140);
            ch_investido.Series["investido"].Points.AddXY("Fevereiro", 110);
            ch_investido.Series["investido"].Points.AddXY("Março", 90);
            ch_investido.Series["investido"].Points.AddXY("Abril", 115);
            ch_investido.Series["investido"].Points.AddXY("Maio", 130);
            ch_investido.Series["investido"].Points.AddXY("Junho", 150);


            ch_investido.Series["investido"].IsValueShownAsLabel = true;

        }
        private void CH_TotalLeads()
        {
            ch_TotaldeLeads.Series.Clear();
            ch_TotaldeLeads.Legends.Clear();
            ch_TotaldeLeads.Titles.Clear();


            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Text = "Total de Leads";
            ch_TotaldeLeads.Titles.Add(title);

            //inserir legenda
            Legend legend = new Legend();
            ch_TotaldeLeads.Legends.Add(legend);
            ch_TotaldeLeads.Legends[0].Title = "Legenda";
            ch_TotaldeLeads.Legends[0].BackColor = Color.Black;
            ch_TotaldeLeads.Legends[0].ForeColor = Color.White;


            ch_TotaldeLeads.Legends[0].Alignment = StringAlignment.Near;



            //titulos dos eixos x e y
            ch_TotaldeLeads.ChartAreas[0].AxisX.Title = "Ano de 2020";
            ch_TotaldeLeads.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            ch_TotaldeLeads.ChartAreas[0].AxisY.Title = "Milhares de R$";
            ch_TotaldeLeads.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //remover grades verticais
            ch_TotaldeLeads.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            ch_TotaldeLeads.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            //cor de fundo
            ch_TotaldeLeads.BackColor = Color.Black;
            ch_TotaldeLeads.ChartAreas[0].BackColor = Color.Black;


            //vendas reais
            ch_TotaldeLeads.Series.Add("ttleads");
            ch_TotaldeLeads.Series["ttleads"].LegendText = "Total de Leads";
            ch_TotaldeLeads.Series["ttleads"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;


            ch_TotaldeLeads.Series["ttleads"].Points.AddXY("Janeiro", 140);
            ch_TotaldeLeads.Series["ttleads"].Points.AddXY("Fevereiro", 110);
            ch_TotaldeLeads.Series["ttleads"].Points.AddXY("Março", 90);
            ch_TotaldeLeads.Series["ttleads"].Points.AddXY("Abril", 115);
            ch_TotaldeLeads.Series["ttleads"].Points.AddXY("Maio", 130);
            ch_TotaldeLeads.Series["ttleads"].Points.AddXY("Junho", 150);

            ch_TotaldeLeads.Series["ttleads"].Color = Color.Orchid;
            ch_TotaldeLeads.Series["ttleads"].BackSecondaryColor = Color.OrangeRed;
            ch_TotaldeLeads.Series["ttleads"].LabelForeColor = Color.White;
            ch_TotaldeLeads.Series["ttleads"].BackGradientStyle = GradientStyle.TopBottom;
            ch_TotaldeLeads.Series["ttleads"].IsValueShownAsLabel = true;

        }
        private void CH_CustoPorLead()
        {
            ch_CustoLead.Series.Clear();
            ch_CustoLead.Legends.Clear();
            ch_CustoLead.Titles.Clear();


            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Text = "Custo por Lead";
            ch_CustoLead.Titles.Add(title);

            //inserir legenda
            Legend legend = new Legend();
            ch_CustoLead.Legends.Add(legend);
            ch_CustoLead.Legends[0].Title = "Legenda";
            ch_CustoLead.Legends[0].BackColor = Color.Black;
            ch_CustoLead.Legends[0].ForeColor = Color.White;

            ch_CustoLead.Legends[0].Alignment = StringAlignment.Near;



            //titulos dos eixos x e y
            ch_CustoLead.ChartAreas[0].AxisX.Title = "Ano de 2020";
            ch_CustoLead.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            ch_CustoLead.ChartAreas[0].AxisY.Title = "Milhares de R$";
            ch_CustoLead.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //remover grades verticais
            ch_CustoLead.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            ch_CustoLead.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            //cor de fundo
            ch_CustoLead.BackColor = Color.Black;
            ch_CustoLead.ChartAreas[0].BackColor = Color.Black;


            //vendas reais
            ch_CustoLead.Series.Add("custo");
            ch_CustoLead.Series["custo"].LegendText = "Custo por Lead";
            ch_CustoLead.Series["custo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;


            ch_CustoLead.Series["custo"].Points.AddXY("Janeiro", 140);
            ch_CustoLead.Series["custo"].Points.AddXY("Fevereiro", 110);
            ch_CustoLead.Series["custo"].Points.AddXY("Março", 90);
            ch_CustoLead.Series["custo"].Points.AddXY("Abril", 115);
            ch_CustoLead.Series["custo"].Points.AddXY("Maio", 130);
            ch_CustoLead.Series["custo"].Points.AddXY("Junho", 150);

            ch_CustoLead.Series["custo"].Color = Color.IndianRed;
            ch_CustoLead.Series["custo"].BackSecondaryColor = Color.Red;
            ch_CustoLead.Series["custo"].LabelForeColor = Color.White;
            ch_CustoLead.Series["custo"].BackGradientStyle = GradientStyle.TopBottom;
            ch_CustoLead.Series["custo"].IsValueShownAsLabel = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GeraGraficos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
