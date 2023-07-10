using System;
using AsPNetCoreMVCcharts.Models.Chart;
using AsPNetCoreMVCcharts.ViewComponents;
using Newtonsoft.Json;

namespace AsPNetCoreMVCcharts.Models
{
    public class ChartJsViewModel
    {
        public ChartJs Chart { get; set; }
        public string ChartJson { get; set; }
    }
}