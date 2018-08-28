var person1 = {
    firstName: "Tom",
    lastName: "Hanks",
    sayHello: function () { } //Type template 
};
person1.sayHello = function () {
    console.log("hello " + person1.firstName);
};
person1.sayHello();
