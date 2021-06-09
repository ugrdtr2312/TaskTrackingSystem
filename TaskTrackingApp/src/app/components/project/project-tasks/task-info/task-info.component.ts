import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { TaskService } from 'src/app/shared/task/task.service';

@Component({
  selector: 'app-task-info',
  templateUrl: './task-info.component.html',
  styles: [
  ]
})
export class TaskInfoComponent implements OnInit {

  currentDate : Date
  constructor(public service: TaskService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.currentDate = new Date();
  }

  onSubmit(form: NgForm){
    console.log('aaa')
  }

}
