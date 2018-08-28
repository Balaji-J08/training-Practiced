class Employe
{
Employe_name:String;
Employe_number:number;
Employe_Dept:any;

constructor(Employe_name:string,Employe_number,Employe_dept)
{
    this.Employe_name=Employe_name;
    this.Employe_number=Employe_number;
    this.Employe_Dept=Employe_dept;

}


diplay(Employe_Dept:String,Employe_name:String):void
{
console.log("The Employee With name  "+Employe_name+" from the Department  "+Employe_Dept);
console.log("..........Ended........");



}





}


var obj=new Employe("Ramanna",08192,"Chemical");
obj.diplay("Mathematics","veeranna");
