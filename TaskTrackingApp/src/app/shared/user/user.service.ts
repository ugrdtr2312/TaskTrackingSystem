import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient } from "@angular/common/http";
import { UserInProject } from './user-in-project.model';
import { UserRole } from './user-role.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  
  role: string | undefined
  listOfUsersInProject: UserInProject[];
  listOfUsersAndManagers: UserRole[];
  userRoleFormData: UserRole = new UserRole();

  constructor(private fb: FormBuilder, private http: HttpClient) { }
  

  formModel = this.fb.group({
    UserName: ['', Validators.required],
    Email: ['', Validators.email],
    FirstName: ['', Validators.required],
    Surname: ['', Validators.required],
    Passwords: this.fb.group ({
      Password: ['', [Validators.required, Validators.minLength(4)]],
      ConfirmPassword: ['', Validators.required]
    }, { validator: this.comparePasswords })

  });

  comparePasswords(fb: FormGroup) {
    let confirmPswrdCtrl = fb.get('ConfirmPassword');
    if (confirmPswrdCtrl?.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors) {
      if (fb.get('Password')?.value != confirmPswrdCtrl?.value)
        confirmPswrdCtrl?.setErrors({ passwordMismatch: true });
      else
        confirmPswrdCtrl?.setErrors(null);
    }
  }

  register() {
    var body = {
      UserName: this.formModel.value.UserName,
      FirstName: this.formModel.value.FirstName,
      Surname: this.formModel.value.Surname,
      Email: this.formModel.value.Email,
      Password: this.formModel.value.Passwords.Password
    };
    return this.http.post('/api/Authentication/registration', body);
  }

  login(formData: any) {
    return this.http.post('/api/Authentication/login', formData);
  }

  changeUserRole() {
    return this.http.post('/api/Users/set-user-role', this.userRoleFormData);
  }

  usersInProject(projectId: number){
    return this.http.get(`api/Users/users-for-project/${projectId}`).toPromise()
    .then(res => this.listOfUsersInProject = res as UserInProject[]);
  }

  usersAndManagers(){
    return this.http.get('api/Users/users-and-managers').toPromise()
    .then(res => this.listOfUsersAndManagers = res as UserRole[]);
  }

  removeUser(userId: number) {
    return this.http.delete(`/api/Users/${userId}`);
  }

  defineRole(){
    localStorage.getItem('token') !== null;
    if (localStorage.getItem('token') !== null) {
      if(this.roleMatch(['Admin'])) this.role = 'Admin'
      if(this.roleMatch(['Manager'])) this.role = 'Manager'
      if(this.roleMatch(['User'])) this.role = 'User'
    }
    console.log(this.role)
  }

  roleMatch(allowedRoles: any[]): boolean {
    var isMatch = false;
    var payLoad = JSON.parse(window.atob(localStorage.getItem('token')?.split('.')[1] || ''));
    var userRole = payLoad["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
    allowedRoles.forEach(element => {
      if (userRole == element) {
        isMatch = true;
        return false;
      }
    });
    return isMatch;
  }
}