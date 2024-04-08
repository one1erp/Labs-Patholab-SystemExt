using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LSExtensionExplorer;
using LSExtensionWindowLib;
using LSSERVICEPROVIDERLib;

using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;
using System.Diagnostics;


namespace SystemExt
{




    public partial class SystemExtcls : UserControl, ILSXplSystemControl
    {
      // private IQueryable<U_STATISTICS_USER> statistics;
        public const string avgYear = "ממוצע שנתי";
        public const string avgMonth = "ממוצע חודשי";
        public const string avgDay = "יום";
        public const string Key = "Key";
        public const string Value = "Value";
        private INautilusUser _ntlsUser;
        private IExtensionWindowSite2 _ntlsSite;
        private INautilusServiceProvider sp;
        private INautilusDBConnection _ntlsCon;
        #region Implement interface
        public void PreDisplay()
        {



        }

        public void SetServiceProvider(object serviceProvider)
        {

            ExceptionThrown += SystemExtcls_ExceptionThrown;
            sp = serviceProvider as NautilusServiceProvider;
       //     _ntlsCon = Utils.GetNtlsCon(sp);

        }

        void SystemExtcls_ExceptionThrown(object sender, Exception e)
        {
            MessageBox.Show(e.Message);
        }

        public event ExceptionThrownEventHandler ExceptionThrown;
        #endregion

        public SystemExtcls()
        {
            // Debugger.Launch();
            InitializeComponent();

        //    InitCheckList();
            radChartView1.Title = "Statistics";
            radChartView1.ShowLegend = true;
            radChartView1.ShowGrid = true;
            radChartView1.ShowTitle = true;
         //   radChartView1.ShowPanZoom = true;
          //  radChartView1.ShowTrackBall = true;
        //    radChartView1.ShowDrillNavigation = true;
        //    radChartView1.ShowSmartLabels = true;
            var minDt = new DateTime(2012, 6, 01);
            var maxDt = new DateTime(2012, 7, 01);
            dateTimePicker1.Value = minDt;
            dateTimePicker2.Value = maxDt;

        }



        private void button1_Click(object sender, EventArgs e)
        {

            //var minDt = dateTimePicker1.Value;
            //var maxDt = dateTimePicker2.Value;

            //var l_minDt = long.Parse(minDt.ToString("yyyyMMdd"));
            //var l_maxDt = long.Parse(maxDt.ToString("yyyyMMdd"));


            //var dal = new DataLayer();
            //dal.Connect(_ntlsCon);
            //statistics = dal.FindBy<U_STATISTICS_USER>(item => item.U_DATE.Value > l_minDt && item.U_DATE.Value < l_maxDt).OrderBy(x => x.U_DATE);



            //radChartView1.Series.Clear();

            //var checkedItems = checkedListBox1.CheckedItems;
            //foreach (string selectedCol in checkedItems)
            //{
            //    var field = title2FieldsDic[selectedCol];
            //    var items = GetColumn(statistics.ToList(), "U_DATE", field);
            //    GenerateLineSeries(selectedCol, items);

            //}
            //dal.Close();

        }


        //private void GenerateLineSeries(string selectedCol, List<ItemData> items)
        //{


        //    var lineSeries = new LineSeries();
        // //   lineSeries.ShowLabels = true;
        //    lineSeries.LegendTitle = selectedCol;
        //    foreach (ItemData itemData in items)
        //    {

        //        lineSeries.DataPoints.Add(new CategoricalDataPoint((double)itemData.sumPerDay, itemData.date.ToString("dd/MM")));
        //    }
        //    radChartView1.ShowSmartLabels = true;
        //    this.radChartView1.Series.Add(lineSeries);
        //}
        //public List<ItemData> GetColumn(List<U_STATISTICS_USER> items, string dateColumn, string sumcolumn)
        //{


        //    var values = items.Select(x => new ItemData
        //    {
        //        date = DateTime.ParseExact(x.GetType().GetProperty(dateColumn).GetValue(x, null).ToString(), "yyyyMMdd",
        //                                            CultureInfo.InvariantCulture,
        //                                            DateTimeStyles.None)
        //        ,
        //        sumPerDay = (decimal)x.GetType().GetProperty(sumcolumn).GetValue(x, null)
        //    });
        //    return values.ToList();
        //}


        private Dictionary<string, string> title2FieldsDic;
        //private void InitCheckList()
        //{

        //    title2FieldsDic = new Dictionary<string, string>();

        //    //Debugger.Launch();



        //    title2FieldsDic.Add("ביופסיות במעבדה","U_B_IN_LAB");
        //    title2FieldsDic.Add("ציטולוגיות במעבדה", "U_C_IN_LAB");
        //    title2FieldsDic.Add("פאפים במעבדה", "U_P_IN_LAB");
        //    title2FieldsDic.Add("בדיקות ביופסיה חדשות","U_NEW_B");
        //    title2FieldsDic.Add("בדיקות ציטולוגיה חדשות","U_NEW_C");
        //    title2FieldsDic.Add("בדיקות פאפים חדשות", "U_NEW_P");
        //    title2FieldsDic.Add("ביופסיות שאושרו", "U_AUTHORIZED_B");
        //    title2FieldsDic.Add("ציטולוגיות שאושרו", "U_AUTHORIZED_C");
        //    title2FieldsDic.Add("פאפים שאושרו", "U_AUTHORIZED_P");
        //    title2FieldsDic.Add("בדיקות פאפ שנשלחו להתייעצות", "U_NBR_OF_CONSULT");
        //    title2FieldsDic.Add("בדיקות פאפ חיוביות", "U_NBR_OF_PAP_POS");
        //    title2FieldsDic.Add("בדיקות חיוביות(שני רופאים )", "U_NBR_2_DOCTORS");
        //    title2FieldsDic.Add("מספר צנצנות ביופסיות", "U_NBR_B_SAMPLE");
        //    title2FieldsDic.Add("מספר צנצנות ציטולוגיות ", "U_NBR_C_SAMPLE");
        //    title2FieldsDic.Add("מספר בלוקים", "U_NBR_BLOCKS");
        //    title2FieldsDic.Add("סליידים שהוכנו", "U_NBR_SLIDES_CUT");
        //    title2FieldsDic.Add("סליידים רזרבה", "U_RESERVE_SLIDES");
        //    title2FieldsDic.Add("סליידים שנצבעו ", "U_NBR_STEIN");
        //    title2FieldsDic.Add("רוויזיות", "U_NBR_REV");
        //    title2FieldsDic.Add("צביעות HE","U_HE_SLIDES");
        //    title2FieldsDic.Add("צביעות אימונו","U_IMMUNO_SLIDES");
        //    title2FieldsDic.Add("צביעות מיוחדות","U_SPECIAL_SLIDES");
        //    title2FieldsDic.Add("צביעות מולקולריות","U_MOLECULAR_SLIDES");


        //    foreach (var title2Field in title2FieldsDic)
        //    {
                
        //        checkedListBox1.Items.Add(title2Field.Key);
        //    }

        //}


    }


}