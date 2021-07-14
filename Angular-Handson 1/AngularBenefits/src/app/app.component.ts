import { Component } from '@angular/core';
import { User } from './user';
import { UserService } from './user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  users!: User[];
  constructor(private userService: UserService) {
  }

  ngOnInit() {
    this.userService.getUsers().subscribe(users => {
      this.users = users.data;
    });
  }
}
