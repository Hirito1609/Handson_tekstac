import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validator, Validators } from '@angular/forms';
import { Employee } from '../employee';
import { Skill } from '../skill';
import { Department } from '../department';
import { EmployeeService } from '../employee.service';
import { ActivatedRoute } from '@angular/router';



@Component({
  selector: 'app-edit-emp-reactive',
  templateUrl: './edit-emp-reactive.component.html',
  styleUrls: ['./edit-emp-reactive.component.css']
})
export class EditEmpReactiveComponent implements OnInit {

  empForm:FormGroup;

  public skilllist:Skill[]=[{SkillId:1,SkillName:"Html"},{SkillId:2,SkillName:"Css"},{SkillId:3,SkillName:"JavaScripts"}];
  emp:Employee = {id:1,name:'Hirito',salary:10000,permanent:false,DepartmentId:4,
    DepartmentName:'IT',dateOfBirth:new Date('12/31/2000'),skills:this.skilllist};
  departmentlist:Department[] = [
      { DepartmentId: 1, DepartmentName: "Payroll" },
      { DepartmentId: 2, DepartmentName: "Internal" },
      { DepartmentId: 3, DepartmentName: "HR" },
      { DepartmentId: 4, DepartmentName: "IT" }
    ];

  constructor(private route : ActivatedRoute, private employeeService : EmployeeService) { 
    this.empForm = new FormGroup({
      'name': new FormControl(this.emp.name, [
        Validators.required,
        Validators.minLength(4),
        Validators.maxLength(20)
      ]),
      'salary': new FormControl(this.emp.salary,[
        Validators.required
      ]),
      'permanent':new FormControl(this.emp.permanent,[
        Validators.required
      ]),
      'department': new FormControl(this.emp.DepartmentId,[
        Validators.required
      ])
    });
  }

  ngOnInit(): void {

    
  }

}
