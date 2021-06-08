import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserToProject } from '../user/user-to-project.model';
import { Project } from './project.model';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor(private http: HttpClient) { }

  formData: Project = new Project();
  list:Project[];

  postProject() {
    return this.http.post('/api/projects', this.formData);
  }

  putProject(){
    return this.http.put('/api/projects', this.formData)
  }

  deleteProject(id:number){
    return this.http.delete(`/api/projects/${id}`)
  }

  deleteUserFromProject(userToProject:UserToProject){
    return this.http.post('/api/projects/remove-user-from-project', userToProject)
  }

  addUserToProject(userToProject:UserToProject){
    return this.http.post('/api/projects/add-user-to-project', userToProject)
  }

  refreshList(){
    this.http.get('/api/projects/current-user').toPromise()
    .then(res => this.list = res as Project[]);
  }
}
