/*
var str1 = new String( "This is string one" );
var str2 = new String( "This is string two" );
var str3 = str1.concat(str2);
console.log("str1 + str2 : "+str3)
*/
var str1 = new String("This is beautiful string");
var index = str1.localeCompare("This is beautiful string");
console.log("localeCompare first :" + index);
console.log();
var re = /(\w+)\s(\w+)/;
var str = "zara ali";
var newstr = str.replace(re, "$2, $1");
console.log(newstr);
console.log();
var re = /apples/gi;
var str2 = "Apples are round, and apples are juicy.";
if (str2.search(re) == -1) {
    console.log("Does not contain Apples");
}
else {
    console.log("Contains Apples");
}
console.log();
var sliced = str2.slice(3, -2);
console.log(sliced);
console.log();
var splitted = str2.split(" ", 3);
console.log(splitted);
console.log();
console.log("(1,2): " + str2.substr(1, 2));
console.log("(-2,2): " + str2.substr(-2, 2));
console.log("(1): " + str2.substr(1));
console.log("(-20, 2): " + str2.substr(-20, 2));
console.log("(20, 2): " + str2.substr(20, 2));
console.log();
console.log("(1,2): " + str2.substring(1, 2));
console.log("(0,10): " + str2.substring(0, 10));
console.log("(5): " + str2.substring(5));
console.log();
console.log(str.toLocaleLowerCase());
