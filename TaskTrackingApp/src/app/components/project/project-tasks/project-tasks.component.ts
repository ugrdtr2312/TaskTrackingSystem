import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { switchMap } from 'rxjs/operators';
import { Task } from 'src/app/shared/task/task.model';
import { TaskService } from 'src/app/shared/task/task.service';

@Component({
  selector: 'app-project-tasks',
  templateUrl: './project-tasks.component.html',
  styles: [
  ]
})
export class ProjectTasksComponent implements OnInit {
  
  serach:string;
  id: number;
  constructor(private route: ActivatedRoute, public service:TaskService, private toastr:ToastrService) { }

  ngOnInit(): void {
    this.route.paramMap.pipe(switchMap(params => params.getAll('id')))
        .subscribe(data=> this.id = +data);
    this.service.refreshList(this.id);
    this.serach ='';
  }

  onDelete(task: Task){
    if (confirm('Are you sure to delete this record?'))
    {
      this.service.deleteTask(task.id)
      .subscribe(
       res=>{
         this.service.refreshList(this.id);
         this.service.formData = new Task();
         this.toastr.error("Deleted successfully", `Task '${task.name}' deleted`)
       },
       err => {
        this.toastr.error(err.error, "Task wasn't deleted")
        }
      )
    }
  }
}