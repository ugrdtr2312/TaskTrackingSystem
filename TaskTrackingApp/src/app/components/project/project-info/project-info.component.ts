import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Project } from 'src/app/shared/project/project.model';
import { ProjectService } from 'src/app/shared/project/project.service';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styles: [
  ]
})
export class ProjectInfoComponent implements OnInit {

  constructor(public service: ProjectService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm){
    if(this.service.formData.id == 0)
      this.inserRecord(form);
    else 
      this.updateRecord(form);
  }

  inserRecord(form: NgForm){
    this.service.postProject().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Submitted succesfully', "Project added")
      },
      err => {
        this.toastr.error(err.error, "Project wasn't added")
      }
    );
  }

  updateRecord(form:NgForm){
    this.service.putProject().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated succesfully', "Project updated")
      },
      err => {
        console.log(err);
      }
    );
  }

  resetForm(form:NgForm){
    form.form.reset();
    this.service.formData = new Project();
  }
}
