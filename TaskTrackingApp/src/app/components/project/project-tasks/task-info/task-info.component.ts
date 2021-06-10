import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { switchMap } from 'rxjs/operators';
import { Task } from 'src/app/shared/task/task.model';
import { TaskService } from 'src/app/shared/task/task.service';

@Component({
  selector: 'app-task-info',
  templateUrl: './task-info.component.html',
  styles: [
  ]
})
export class TaskInfoComponent implements OnInit {

  id: number;
  constructor(private route: ActivatedRoute, public service: TaskService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.route.paramMap.pipe(switchMap(params => params.getAll('id')))
        .subscribe(data=> this.id = +data);
    this.service.formData.projectId = this.id;
  }

  onSubmit(form: NgForm){
    console.log(this.service.formData)
    if(this.service.formData.id == 0)
      this.inserRecord(form);
  }

  inserRecord(form: NgForm){
    this.service.postTask().subscribe(
      res => {
        this.toastr.info('Submitted succesfully', `Task '${form.value.name}' added`);
        this.resetForm(form);
        this.service.refreshList(this.id);
      },
      err => {
        this.toastr.error(err.error, "Task wasn't added")
      }
    );
  }

  resetForm(form:NgForm){
    let prId = this.service.formData.projectId;
    this.service.formData = new Task();
    this.service.formData.projectId = prId;
    //form.setValue( this.service.formData);
  }

}
