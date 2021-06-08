import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/shared/user/user.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: []
})
export class HomeComponent implements OnInit {
  role: string| null
  constructor(private router: Router, private service: UserService) { }

  ngOnInit() {
    this.role = localStorage.getItem("role")
  }
}
