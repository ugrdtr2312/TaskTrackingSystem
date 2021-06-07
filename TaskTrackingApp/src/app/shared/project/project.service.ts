import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
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

  refreshList(){
    this.http.get('/api/projects/current-user').toPromise()
    .then(res => this.list = res as Project[]);
  }
}
