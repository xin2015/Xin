function LineHighcharts(container) {
    this.container = container;
    this.chartType = 'spline';
    this.exportingFileName = "chart";
    this.legendUseHTML = false;
    this.series = [];
    this.subtitleText = null;
    this.titleText = null;
    this.tooltipFormatter = null;
    this.tooltipUseHTML = false;
    this.tooltipValueSuffix = null;
    this.xAxisCategories = [];
    this.xAxisTickInterval = null;
    this.yAxisPlotLines = [];
    this.yAxisTitle = null;

    this.DrawChart = function () {
        this.container.highcharts({
            lang: {
                contextButtonTitle: '导出图片',
                loading: '加载中',
                noData: '没有数据'
            },
            chart: {
                type: this.chartType
            },
            credits: {
                enabled: false
            },
            exporting: {
                buttons: {
                    contextButton: {
                        menuItems: null,
                        onclick: function () {
                            this.exportChartLocal();
                        }
                    }
                },
                filename: this.exportingFileName,
                sourceHeight: this.container.height(),
                sourceWidth: this.container.width()
            },
            legend: {
                align: 'center',   //right,left,center
                layout: 'horizontal',   //vertical,horizontal
                useHTML: this.legendUseHTML
            },
            series: this.series,
            subtitle: {
                text: this.subtitleText,
                useHTML: true
            },
            title: {
                text: this.titleText,
                useHTML: false
            },
            tooltip: {
                enabled: true,
                formatter: this.tooltipFormatter,
                shared: true,
                useHTML: this.tooltipUseHTML,
                valueDecimals: null,   //保留小数位
                valuePrefix: null,   //前缀
                valueSuffix: this.tooltipValueSuffix   //后缀
            },
            xAxis: {
                categories: this.xAxisCategories,
                tickInterval: this.xAxisTickInterval
            },
            yAxis: {
                min: 0,
                plotLines: this.yAxisPlotLines,
                title: {
                    text: this.yAxisTitle
                }
            }
        });
    };
}