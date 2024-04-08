//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Windows.Forms;
//using LSExtensionExplorer;
//using Telerik.Charting;
//using Telerik.WinControls;
//using Telerik.WinControls.Tests;
//using Telerik.WinControls.UI;
//using System.Diagnostics;


//namespace SystemExt
//{




//    public partial class SystemExtcls : UserControl, ILSXplSystemControl
//    {
//        public const string avgYear = "ממוצע שנתי";
//        public const string avgMonth = "ממוצע חודשי";
//        public const string avgDay = "יום";
//        public const string Key = "Key";
//        public const string Value = "Value";
//        List<SingleBar> bars = new List<SingleBar>();

//        public SystemExtcls()
//        {
//            InitializeComponent();
//            //  InitData();
//        }

//        private void InitData()
//        {




//            radChartView1.ShowTitle = true;
//            this.radChartView1.ShowLegend = true;
//            this.radChartView1.Title = "Aliquot station";
//            //  this.radTextBoxControlTitle.Text = this.radChartView1.Title;
//            this.radChartView1.LegendTitle = "Legend";
//            this.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter;
//            //  this.radDropDownListTitlePosition.DataSource = Enum.GetValues(typeof (TitlePosition));
//            //    this.radDropDownListLegendPosition.DataSource = Enum.GetValues(typeof (LegendPosition));

//            DataSet set = new DataSet();

//            DataTable lab1 = new DataTable("lab1");
//            set.Tables.Add(lab1);
//            lab1.Columns.Add(Key);
//            lab1.Columns.Add(Value, typeof(double));
//            lab1.Rows.Add(avgYear, 31.4);
//            lab1.Rows.Add(avgMonth, 24.0);
//            lab1.Rows.Add(avgDay, 18.9);
//            BarSeries lab1Series = new BarSeries(Key, Value);
//            lab1Series.DataMember = "lab1";
//            lab1Series.LegendTitle = "lab1";



//            DataTable lab2 = new DataTable("lab2");
//            set.Tables.Add(lab2);
//            lab2.Columns.Add(Key);
//            lab2.Columns.Add(Value, typeof(double));
//            lab2.Rows.Add(avgYear, 31.4);
//            lab2.Rows.Add(avgMonth, 24.0);
//            lab2.Rows.Add(avgDay, 18.9);
//            BarSeries lab2Series = new BarSeries(Key, Value);
//            lab2Series.DataMember = "lab2";
//            lab2Series.LegendTitle = "lab2";



//            //DataTable lab3 = new DataTable("lab3");
//            //DataTable lab4 = new DataTable("lab4");

//            //DataTable lab5 = new DataTable("lab5");
//            //DataTable lab6 = new DataTable("lab6");
//            //DataTable lab7 = new DataTable("lab7");
//            //DataTable lab8 = new DataTable("lab8");


//            //set.Tables.Add(lab3);
//            //set.Tables.Add(lab4);
//            //set.Tables.Add(lab5);
//            //set.Tables.Add(lab6);
//            //set.Tables.Add(lab7);
//            //set.Tables.Add(lab8);

//            //foreach (DataTable table in set.Tables)
//            //{
//            //    table.Columns.Add("Month");
//            //    table.Columns.Add("Usage", typeof (double));
//            //}

//            //windowsXPTable.Rows.Add("January", 31.4);
//            //windowsXPTable.Rows.Add("February", 24.0);
//            //windowsXPTable.Rows.Add("March", 18.9);

//            //windows7Table.Rows.Add("January", 27.1);
//            //windows7Table.Rows.Add("February", 35.7);
//            //windows7Table.Rows.Add("March", 43.9);

//            //linuxTable.Rows.Add("January", 6.9);
//            //linuxTable.Rows.Add("February", 13.0);
//            //linuxTable.Rows.Add("March", 8.9);

//            //macTable.Rows.Add("January", 8.0);
//            //macTable.Rows.Add("February", 12.1);
//            //macTable.Rows.Add("March", 9.9);

//            this.radChartView1.DataSource = set;

//            //BarSeries windowsXPSeries = new BarSeries("Usage", "Month");
//            //windowsXPSeries.DataMember = "WindowsXP";
//            //windowsXPSeries.LegendTitle = "Windows XP";
//            //BarSeries windows7Series = new BarSeries("Usage", "Month");
//            //windows7Series.DataMember = "Windows7";
//            //windows7Series.LegendTitle = "Windows 7";
//            //BarSeries linuxSeries = new BarSeries("Usage", "Month");
//            //linuxSeries.DataMember = "Linux";
//            //linuxSeries.LegendTitle = "Linux";
//            //BarSeries macSeries = new BarSeries("Usage", "Month");
//            //macSeries.DataMember = "Mac";
//            //macSeries.LegendTitle = "Mac";
//            //BarSeries windowsXPSeries = new BarSeries("Usage", "Month");
//            //windowsXPSeries.DataMember = "WindowsXP";
//            //windowsXPSeries.LegendTitle = "Windows XP";
//            //BarSeries windows7Series = new BarSeries("Usage", "Month");
//            //windows7Series.DataMember = "Windows7";
//            //windows7Series.LegendTitle = "Windows 7";
//            //BarSeries linuxSeries = new BarSeries("Usage", "Month");
//            //linuxSeries.DataMember = "Linux";
//            //linuxSeries.LegendTitle = "Linux";
//            //BarSeries macSeries = new BarSeries("Usage", "Month");
//            //macSeries.DataMember = "Mac";
//            //macSeries.LegendTitle = "Mac";

//            this.radChartView1.Series.AddRange(lab1Series, lab2Series);//, linuxSeries, macSeries);

//            //   this.customShape = new CustomShape();
//            //  this.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60));

//            RadListDataItem item = new RadListDataItem("CustomShape");
//            item.Value = typeof(CustomShape);
//            //    this.radDropDownListShapes.Items.Add(item);
//            item = new RadListDataItem("RectangleShape");
//            item.Value = typeof(RoundRectShape);
//            //   this.radDropDownListShapes.Items.Add(item);
//            item = new RadListDataItem("RoundRectShape");
//            item.Value = typeof(RoundRectShape);
//            //    this.radDropDownListShapes.Items.Add(item);
//            item = new RadListDataItem("EllipseShape");
//            item.Value = typeof(EllipseShape);
//            //    this.radDropDownListShapes.Items.Add(item);
//            item = new RadListDataItem("DonutShape");
//            item.Value = typeof(DonutShape);
//            //     this.radDropDownListShapes.Items.Add(item);
//            //     this.radDropDownListShapes.SelectedIndex = 1;

//            this.radChartView1.Controllers.Add(new LassoZoomController());
//            //this.radChartView1.Controllers.Add(new ChartSelectionController());
//        }

//        public void PreDisplay()
//        {
//            radChartView1.ShowTitle = true;
//            this.radChartView1.ShowLegend = true;
//            this.radChartView1.Title = "Aliquot station";
//            // this.radTextBoxControlTitle.Text = this.radChartView1.Title;
//            //this.radChartView1.LegendTitle = "Legend";
//            //this.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter;
//            //SingleBar s = new SingleBar();
//            //int z = 1;
//            //Item item = new Item() { Key = avgYear, Value = z * 9 };
//            //z++;
//            //s.items.Add(item);
//            //item = new Item() { Key = avgMonth, Value = z * 9 };
//            //z++;
//            //s.items.Add(item);

//            //item = new Item() { Key = avgDay, Value = z * 9 };
//            //s.items.Add(item);
//            //bars.Add(s);

//            //s = new SingleBar();
//            //z++;
//            //item = new Item() { Key = avgYear, Value = z * 9 };
//            //z++;
//            //s.items.Add(item);
//            //item = new Item() { Key = avgMonth, Value = z * 9 };
//            //z++;
//            //s.items.Add(item);

//            //item = new Item() { Key = avgDay, Value = z * 9 };
//            //s.items.Add(item);
//            //bars.Add(s);

//            //this.radChartView1.AreaType = ChartAreaType.Cartesian;

//            //foreach (SingleBar singleBar in bars)
//            //{
//            ////    Debugger.Launch();
//            //   BarSeries series = new BarSeries(Key, Value);


//            //    int w = 0;
//            //    var p2 = new CategoricalDataPoint(singleBar.items[w].Value, singleBar.items[w].Key);
//            //    w++;
//            //    var p1 = new CategoricalDataPoint(singleBar.items[w].Value, singleBar.items[w].Key);
//            //    w++;
//            //    var p3 = new CategoricalDataPoint(singleBar.items[w].Value, singleBar.items[w].Key);

//            //    series.DataPoints.Add(p2);
//            //    series.DataPoints.Add(p3);
//            //    series.DataPoints.Add(p1);

//            //    this.radChartView1.Series.Add(series);
//            //}
//            ////    foreach (IGrouping<string, Sdg> grouping in group)
//            ////      {
//            var p = new PieDataPoint(22, "hello");
//            var p2 = new CategoricalDataPoint(3, "lab1");
//            var p3 = new CategoricalDataPoint(33, "lab2");
//            var p1 = new CategoricalDataPoint(55, "lab3");
//            BarSeries series = new BarSeries(Key, Value);
//            series.DataPoints.Add(p2);
//            series.DataPoints.Add(p3);
//            series.DataPoints.Add(p1);
//            this.radChartView1.Series.Add(series);


//            //  }

//        }

//        public void SetServiceProvider(object serviceProvider)
//        {

//        }

//        public event ExceptionThrownEventHandler ExceptionThrown;
//    }

//    class Item
//    {
//        public string Key { get; set; }
//        public int Value { get; set; }
//    }

//    class SingleBar
//    {
//        public List<Item> items { get; set; }

//        public SingleBar()
//        {
//            items = new List<Item>(3);
//        }
//    }

//}