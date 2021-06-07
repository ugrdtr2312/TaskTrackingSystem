import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/shared/user/user.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})

export class NavComponent implements OnInit {
  isLogged : boolean | undefined
  isAdmin: boolean | undefined
  isManager: boolean | undefined
  isUser: boolean | undefined

  constructor(private router: Router, private service: UserService) {
  }
  
  ngOnInit() {
  
  }

  intializeData(){
    this.isLogged = localStorage.getItem('token') !== null;
    if (this.isLogged) {
      this.isAdmin = this.service.roleMatch(['Admin']);
      this.isManager = this.service.roleMatch(['Manager']);
      this.isUser = this.service.roleMatch(['User']);
    }
  }

  onLogout() {
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
}