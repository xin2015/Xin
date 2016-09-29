// 大气监测，各常量定义内容
function PollutantConst() {
    this.colorArray = ["#333333", "#00E400", "#FFFF00", "#FF7E00", "#FF0000", "#99004C", "#7E0023"];
    this.levelArray = ["无数据", "一级", "二级", "三级", "四级", "五级", "六级"];
    this.typeArray = ["无数据", "优", "良", "轻度污染", "中度污染", "重度污染", "严重污染"];
    this.width = 3;
    this.valueArrayDic = {
        hour: {
            AQI: [0, 50, 100, 150, 200, 300],
            SO2: [0, 150, 500, 650, 800],
            NO2: [0, 100, 200, 700, 1200, 2340],
            CO: [0, 5, 10, 35, 60, 90],
            O3: [0, 160, 200, 300, 400, 800],
            PM10: [0, 50, 150, 250, 350, 420],
            PM25: [0, 35, 75, 115, 150, 250]
        },
        day: {
            AQI: [0, 50, 100, 150, 200, 300],
            SO2: [0, 50, 150, 475, 800, 1600],
            NO2: [0, 40, 80, 180, 280, 565],
            CO: [0, 2, 4, 14, 24, 36],
            O38H: [0, 100, 160, 215, 265, 800],
            PM10: [0, 50, 150, 250, 350, 420],
            PM25: [0, 35, 75, 115, 150, 250]
        }
    };
    this.GetPlotLines = function (type, pollutant) {
        var valueArray = this.valueArrayDic[type][pollutant];
        var plotLines = [];
        for (var i = 1; i < valueArray.length; i++) {
            plotLines.push({
                color: this.colorArray[i],
                width: this.width,
                value: valueArray[i],
                label: {
                    text: this.levelArray[i] + "标准限值：" + valueArray[i],
                    align: 'left'
                }
            });
        }
        return plotLines;
    }

    this.GetPieces = function (type, pollutant, filter) {
        var valueArray = this.valueArrayDic[type][pollutant];
        var pieces = [];
        if (filter) {
            pieces.push({
                lt: valueArray[0],
                label: this.typeArray[0]
            });
        }
        pieces.push({
            gte: valueArray[0],
            lte: valueArray[1],
            label: this.typeArray[1]
        });
        for (var i = 2; i < valueArray.length; i++) {
            pieces.push({
                gt: valueArray[i - 1],
                lte: valueArray[i],
                label: this.typeArray[i]
            });
        }
        pieces.push({
            gt: valueArray[valueArray.length - 1],
            label: this.typeArray[valueArray.length]
        });
        return pieces;
    }
}