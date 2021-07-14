import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewEmpComponent } from './view-emp/view-emp.component';
import { EditEmpComponent } from './edit-emp/edit-emp.component';
import { QuantityIncrementComponent } from './quantity-increment/quantity-increment.component';
import { EditEmpTemplateDrivenComponent } from './edit-emp-template-driven/edit-emp-template-driven.component';
import { EditEmpReactiveComponent } from './edit-emp-reactive/edit-emp-reactive.component';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { LoginComponent } from './login/login.component';
import { AuthService } from './auth.service';
import { AuthGuard } from './auth/auth.guard';

const routes: Routes = [{ path: "" , component: ViewEmpComponent},
{ path: "EditEmployees" , component: EditEmpComponent},{ path: "QuantityIncrement",component: QuantityIncrementComponent},
{ path: "EditEmpTemplate",component: EditEmpTemplateDrivenComponent},
{ path: "EditEmpReactive",component: EditEmpReactiveComponent, canActivate:[AuthGuard]},
{ path: "EmployeeList",component: EmployeeListComponent},
{ path: "Login",component: LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
