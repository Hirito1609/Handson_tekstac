import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { Department } from '../department';
import { Skill } from '../skill';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  public skilllist:Skill[]=[{SkillId:1,SkillName:"Html"},{SkillId:2,SkillName:"Css"},{SkillId:3,SkillName:"JavaScripts"}];

  employeelist:Employee[]=[];

  constructor() { }

  ngOnInit(): void {
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
  public searchKey:string = "";

  Search()
  {
    if (this.searchKey != "")
    {
        this.employeelist = this.employeelist.filter(res => {
            return res.name.toLocaleLowerCase().match(this.searchKey.toLocaleLowerCase());
        });
    }
    else if (this.searchKey == "")
    {
        this.ngOnInit();
    }
  }


}
