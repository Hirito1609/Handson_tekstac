import { Employee } from "./employee";
import { Skill } from "./skill";

var skilllist:Skill[] = [{SkillId:1,SkillName:"HTML"},{SkillId:2,SkillName:"CSS"},{SkillId:3,SkillName:"Javascript"}];

var user:Employee = {id:1,name:"Hirito",salary:10000,permanent:true,DepartmentId:1,DepartmentName:"IT",skills:skilllist};

console.log(user);
class EmployeeTest
{
    employee:Employee = {
        id:undefined,
        name:undefined,
        salary:undefined,
        permanent:undefined,
        DepartmentId:undefined,
        DepartmentName:undefined,
        skills:undefined
    };

    constructor(id:number, name:string, salary:number, permanent:boolean, DepartmentId:number, DepartmentName:string,skilllist:Skill[]) {
        this.employee.id = id;
        this.employee.name = name;
        this.employee.salary = salary;
        this.employee.permanent = permanent;
        this.employee.DepartmentId = DepartmentId;
        this.employee.DepartmentName = DepartmentName;
        this.employee.skills = skilllist;   

    }
    display(obj:EmployeeTest) 
    {
        console.log(obj);    
    }
}


const a = new EmployeeTest(1,"Hirito",10000,true,1,"IT",skilllist);
a.display(a);
