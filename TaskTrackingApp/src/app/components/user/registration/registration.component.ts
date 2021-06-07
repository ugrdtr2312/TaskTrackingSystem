import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['../auth/auth.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(public service: UserService, private toastr: ToastrService) { }

  ngOnInit() {
    this.service.formModel.reset();
  }

  onSubmit() {
    this.service.register().subscribe(
      (res: any) => {
          this.service.formModel.reset();
         
          this.toastr.success('New user created! Now you can try to log in', 'Registration successful.');
      },
      err => {
        if (err.status == 400){
          this.toastr.error(err.error, 'Authentication failed.');
        }
        else
          console.log(err);
      });
  }
}