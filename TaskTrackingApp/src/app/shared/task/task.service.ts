import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserOfProject } from '../user/user-of-project.model';
import { Task } from './task.model';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private http: HttpClient) { }

  formData: Task = new Task();
  list:Task[];
  listOfProjectUsers:UserOfProject[];

  refreshList(projectId: number){
    this.http.get(`/api/tasks/${projectId}`).toPromise()
    .then(res => this.list = res as Task[]);
    this.http.get(`api/users/users-of-project/${projectId}`).toPromise()
    .then(res => this.listOfProjectUsers = res as UserOfProject[]);
  }

  deleteTask(id:number){
    return this.http.delete(`/api/tasks/${id}`)
  }
}
