import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-emp-info',
  templateUrl: './emp-info.component.html',
  styleUrls: ['./emp-info.component.css']
})
export class EmpInfoComponent implements OnInit {

  empObj :any={};
  @Input() employee = [{id:1, name:"John", salary:5000, permanent:true, department:[{id:3, name:"Payroll"}],skills:[{ id: 1, name: "HTML"}] },
  { id: 2, name: "Smith", salary: 10000, permanent: true, department:[{ id: 6, name: "Internal"}],skills:[{ id: 2, name: "JAVA"}] },  
  { id: 3, name: "Mary", salary: 55000, permanent: true, department:[{ id: 2, name: "Lead"}],skills:[{ id: 1, name: "HTML"}] },
  { id: 4, name: "Sandy", salary: 15000, permanent: true, department:[{ id: 3, name: "Payroll"}],skills:[{ id: 3, name: "CSS"}] },
  { id: 5, name: "Martin", salary: 20000, permanent: true, department:[{ id: 2, name: "Lead"}],skills:[{ id: 1, name: "HTML"}] }        
]


  constructor(private route:ActivatedRoute) { 
    let eno = this.route.snapshot.params["id"];
    this.empObj = this.employee.find(item => item.id == eno);

  }

  ngOnInit(): void {
  }

}
