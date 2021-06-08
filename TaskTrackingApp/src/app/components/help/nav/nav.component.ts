import { Component, OnChanges, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/shared/user/user.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})

export class NavComponent implements OnInit {
  isLogged : boolean | undefined
  role: string | null;

  constructor(private router: Router, private service: UserService) {
  }
  
  ngOnInit() {
  }

  aaaa(){
    this.isLogged = localStorage.getItem('token') !== null;
    this.role = localStorage.getItem("role")
  }

  onLogout() {
    localStorage.removeItem('token');
    localStorage.removeItem('role');
    this.router.navigate(['/user/login']);
  }
}