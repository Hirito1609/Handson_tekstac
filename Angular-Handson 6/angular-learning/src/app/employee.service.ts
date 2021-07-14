import { Injectable } from '@angular/core';
import { Employee } from './employee';
import { Skill } from './skill';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  employeelist:Employee[]=[];
  public skilllist:Skill[]=[{SkillId:1,SkillName:"Html"},{SkillId:2,SkillName:"Css"},{SkillId:3,SkillName:"JavaScripts"}];

  constructor() { 
    this.employeelist = [{id:1,name:'John',salary:5000,permanent:true,DepartmentId:3,
    DepartmentName:'Payroll',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist},
    {id:2,name:'Smith',salary:5000,permanent:true,DepartmentId:6,
    DepartmentName:'Internal',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist},
    {id:3,name:'Mary',salary:5000,permanent:true,DepartmentId:2,
    DepartmentName:'Lead',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist},
    {id:4,name:'Sandy',salary:5000,permanent:true,DepartmentId:3,
    DepartmentName:'Payroll',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist},
    {id:5,name:'Martin',salary:5000,permanent:true,DepartmentId:2,
    DepartmentName:'Lead',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist}];
  }

  getAllEmployees():Employee[]
  {
    return this.employeelist;
  }

  getEmployee(employeeId: number)
  {
    return this.employeelist.filter(e=>e.id===employeeId);
  }

}
