import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { Skill } from '../skill';
import { Department } from '../department';

@Component({
  selector: 'app-edit-emp-template-driven',
  templateUrl: './edit-emp-template-driven.component.html',
  styleUrls: ['./edit-emp-template-driven.component.css']
})
export class EditEmpTemplateDrivenComponent implements OnInit {

  public skilllist:Skill[]=[{SkillId:1,SkillName:"Html"},{SkillId:2,SkillName:"Css"},{SkillId:3,SkillName:"JavaScripts"}];
  emp:Employee = {id:1,name:'Hirito',salary:10000,permanent:false,DepartmentId:4,
    DepartmentName:'IT',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist};
  departmentlist:Department[] = [
      { DepartmentId: 1, DepartmentName: "Payroll" },
      { DepartmentId: 2, DepartmentName: "Internal" },
      { DepartmentId: 3, DepartmentName: "HR" },
      { DepartmentId: 4, DepartmentName: "IT" }
    ];
  
  onSubmit()
  {
    console.log();
  }
  
  constructor() { }

  ngOnInit(): void {
  }

}
