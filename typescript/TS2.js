var Employe = /** @class */ (function () {
    function Employe(Employe_name, Employe_number, Employe_dept) {
        this.Employe_name = Employe_name;
        this.Employe_number = Employe_number;
        this.Employe_Dept = Employe_dept;
    }
    Employe.prototype.diplay = function (Employe_Dept, Employe_name) {
        console.log("The Employee With name  " + Employe_name + " from the Department  " + Employe_Dept);
        console.log("..........Ended........");
    };
    return Employe;
}());
var obj = new Employe("Ramanna", 08192, "Chemical");
obj.diplay("Mathematics", "veeranna");
