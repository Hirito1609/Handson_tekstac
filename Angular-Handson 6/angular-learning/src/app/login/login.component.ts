import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  username:string="";
  password:string="";

  constructor( private authService: AuthService, 
    private router: Router, 
    private activatedRoute:ActivatedRoute) { 
   
  }

  ngOnInit(): void {

  }
  onFormSubmit(loginForm: { value: { username: string; password: string; }; })
  {
    if(loginForm.value.username == "admin" && loginForm.value.password =="password")
    {
      this.authService.login();
      this.router.navigate(['EditEmpReactive']);
    }
    else
    {
      console.log("invalid credentials");
    }
  }
}
