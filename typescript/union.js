var val;
val = 12;
console.log("numeric value of val " + val);
val = "This is a string";
console.log("string value of val " + val);
console.log();
//union type as fn parameter
function disp(name) {
    if (typeof name == "string") {
        console.log(name);
    }
    else {
        var i;
        for (i = 0; i < name.length; i++) {
            console.log(name[i]);
        }
    }
}
disp("mark");
console.log("Printing names array....");
disp(["Mark", "Tom", "Mary", "John"]);
//union type as array
var arr1;
var i;
arr1 = [1, 2, 4];
console.log("**numeric array**");
for (i = 0; i < arr1.length; i++) {
    console.log(arr1[i]);
}
arr1 = ["Mumbai", "Pune", "Delhi"];
console.log("**string array**");
for (i = 0; i < arr1.length; i++) {
    console.log(arr1[i]);
}
