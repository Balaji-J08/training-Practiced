//rest parameters
var count = "";
function present() {
    var num = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        num[_i] = arguments[_i];
    }
    count++;
    console.log("The passed numbers are as folows: " + num + " : " + count);
}
present(1);
present(1, 2);
present(1, 2, 3, 4, 5, 6, 7, 8, 9);
