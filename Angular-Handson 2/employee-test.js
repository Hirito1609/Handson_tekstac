"use strict";
exports.__esModule = true;
var skilllist = [{ SkillId: 1, SkillName: "HTML" }, { SkillId: 2, SkillName: "CSS" }, { SkillId: 3, SkillName: "Javascript" }];
var user = { id: 1, name: "Hirito", salary: 10000, permanent: true, DepartmentId: 1, DepartmentName: "IT", skills: skilllist };
console.log(user);
var EmployeeTest = /** @class */ (function () {
    function EmployeeTest(id, name, salary, permanent, DepartmentId, DepartmentName, skilllist) {
        this.employee = {
            id: undefined,
            name: undefined,
            salary: undefined,
            permanent: undefined,
            DepartmentId: undefined,
            DepartmentName: undefined,
            skills: undefined
        };
        this.employee.id = id;
        this.employee.name = name;
        this.employee.salary = salary;
        this.employee.permanent = permanent;
        this.employee.DepartmentId = DepartmentId;
        this.employee.DepartmentName = DepartmentName;
        this.employee.skills = skilllist;
    }
    EmployeeTest.prototype.display = function (obj) {
        console.log(obj);
    };
    return EmployeeTest;
}());
var a = new EmployeeTest(1, "Hirito", 10000, true, 1, "IT", skilllist);
a.display(a);
