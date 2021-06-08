import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Task } from './task.model';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private http: HttpClient) { }

  formData: Task = new Task();
  list:Task[];

  refreshList(projectId: number){
    this.http.get(`/api/tasks/${projectId}`).toPromise()
    .then(res => this.list = res as Task[]);
  }

  deleteTask(id:number){
    return this.http.delete(`/api/tasks/${id}`)
  }
}
