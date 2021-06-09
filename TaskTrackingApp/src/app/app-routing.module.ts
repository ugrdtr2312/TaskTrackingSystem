import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ForbiddenComponent } from './components/help/forbidden/forbidden.component';
import { HomeComponent } from './components/home/home.component';
import { ProjectTasksComponent } from './components/project/project-tasks/project-tasks.component';
import { ProjectUsersComponent } from './components/project/project-users/project-users.component';
import { AuthComponent } from './components/user/auth/auth.component';
import { LoginComponent } from './components/user/login/login.component';
import { ProfileComponent } from './components/user/profile/profile.component';
import { RegistrationComponent } from './components/user/registration/registration.component';
import { StatisticComponent } from './components/user/statistic/statistic.component';
import { AuthGuard } from './helpers/auth/auth.guard';

const routes: Routes = [
  {path:'',redirectTo:'/user/login',pathMatch:'full'},
  {
    path: 'user', component: AuthComponent,
    children: [
      { path: 'registration', component: RegistrationComponent },
      { path: 'login', component: LoginComponent }
    ]
  },
  {path:'home',component:HomeComponent,canActivate:[AuthGuard]},
  {path:'profile',component:ProfileComponent,canActivate:[AuthGuard]},
  {path:'statistic',component:StatisticComponent,canActivate:[AuthGuard],data :{permittedRoles:['User']}},
  {path: 'project/:id/users', component: ProjectUsersComponent,canActivate:[AuthGuard],data :{permittedRoles:['Manager']}},
  {path: 'project/:id/tasks', component: ProjectTasksComponent,canActivate:[AuthGuard],data :{permittedRoles:['User','Manager']}},
  {path:'forbidden',component:ForbiddenComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
