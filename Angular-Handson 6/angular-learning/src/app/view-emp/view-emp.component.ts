import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { Skill } from '../skill';

@Component({
  selector: 'app-view-emp',
  templateUrl: './view-emp.component.html',
  styleUrls: ['./view-emp.component.css']
})
export class ViewEmpComponent implements OnInit {

  public skilllist:Skill[]=[{SkillId:1,SkillName:"Html"},{SkillId:2,SkillName:"Css"},{SkillId:3,SkillName:"JavaScripts"}];
  emp:Employee = {id:1,name:'Hirito',salary:10000,permanent:false,DepartmentId:1,
    DepartmentName:'IT',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist};

  constructor() { }

  ngOnInit(): void {
  }

}
