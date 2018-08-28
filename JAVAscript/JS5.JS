var abc={
Fname : "Balu",
Lname : "J",
age : 24,
Display : function()
{
return this.Fname + " "+ this.Lname;

}

};
document.getElementById("demo").innerHTML = abc.Display();
document.getElementById("demo1").innerHTML = abc.Display;
