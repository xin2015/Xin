//日期格式化字符串
Date.prototype.ToString = function (fmt) {
    var o = {
        "M+": this.getMonth() + 1, //月份 
        "d+": this.getDate(), //日 
        "H+": this.getHours(), //小时 
        "m+": this.getMinutes(), //分 
        "s+": this.getSeconds(), //秒 
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度 
        "S": this.getMilliseconds() //毫秒 
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(new String(o[k]).length)));
    return fmt;
}

//json格式的日期
function GetTimeFromJsonString(jsonTime) {
    var re = /-?\d+/;
    var m = re.exec(jsonTime);
    var d = new Date(parseInt(m[0]));
    return d;
}

Array.prototype.sum = function () {
    var sum = this[0];
    for (var i = 1; i < this.length; i++) {
        sum += this[i];
    }
    return sum;
}

Array.prototype.max = function () {
    var max = this[0];
    for (var i = 1; i < this.length; i++) {
        if (this[i] > max) {
            max = this[i];
        }
    }
    return max;
}

Array.prototype.min = function () {
    var min = this[0];
    for (var i = 1; i < this.length; i++) {
        if (this[i] < min) {
            min = this[i];
        }
    }
    return min;
}

Array.prototype.avg = function () {
    if (this.length === 0) return undefined;
    else return this.sum() / this.length;
}

function CorrelationCoefficient(arrayA, arrayB) {
    var avgA = arrayA.avg();
    var avgB = arrayB.avg();
    var cov = 0;
    var varA = 0;
    var varB = 0;
    for (var i = 0; i < arrayA.length; i++) {
        cov += (arrayA[i] - avgA) * (arrayB[i] - avgB);
        varA += Math.pow((arrayA[i] - avgA), 2);
        varB += Math.pow((arrayB[i] - avgB), 2);
    }
    return cov / Math.sqrt(varA * varB);
}

function CorrelationCoefficientAssessment(correlationCoefficient) {
    var result;
    correlationCoefficient = Math.abs(correlationCoefficient);
    if (correlationCoefficient === 0) result = "不存在线性相关";
    else if (correlationCoefficient < 0.3) result = "为极弱线性相关";
    else if (correlationCoefficient < 0.5) result = "为低度线性相关";
    else if (correlationCoefficient < 0.8) result = "为中度线性相关";
    else if (correlationCoefficient < 1) result = "为高度线性相关";
    else result = "为完全线性相关";
    return result;
}