import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  public user:any=[];
  constructor(private userService:UserService) { }

  ngOnInit(): void {
  }

  retrieveAllUser() {
    this.userService.getAll()
      .subscribe(
        data => {
          this.user= data;
          console.log(data);
          console.log(this.user);
        },
        error => {
          console.log(error);
        });
  }

}
