var msg = "hi guys";
console.log(msg);
var name1 = /** @class */ (function () {
    function name1() {
    }
    name1.prototype.print = function () {
        var num = 101;
        var name = "parle-g";
        var points = 12.36;
        var i = 0;
        while (i < 3) {
            console.log("name: " + name + " " + "number: " + "num" + " " + "points: " + points);
            i++;
        }
        console.log("ended Successfulley");
    };
    return name1;
}());
var n = new name1();
n.print();
