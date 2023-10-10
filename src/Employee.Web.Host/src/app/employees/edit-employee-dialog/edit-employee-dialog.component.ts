import { Component, Injector, EventEmitter, OnInit } from '@angular/core';
import { EmployeeDto, EmployeeServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import * as internal from 'stream';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
  selector: 'app-edit-employee-dialog',
  templateUrl: './edit-employee-dialog.component.html',
})
export class EditEmployeeDialogComponent extends AppComponentBase
implements OnInit {
  _edit = "Edit Employee"
  employee = new EmployeeDto()
  onSave = new EventEmitter()
  id: number = 0

  constructor(
    injector: Injector,
    public bsModalRef: BsModalRef,
    private _employeeService: EmployeeServiceProxy
  )
  {
    super(injector)
  }

  // OnInit Function
  ngOnInit(): void {
    this._employeeService.getEmployeeById(this.id).subscribe({next: (data): EmployeeDto => this.employee = data})
  }
  // save to database
  save(){ 
      const employee = new EmployeeDto
      employee.init(this.employee)
      this._employeeService.update(employee).subscribe(()=>{
      this.notify.info("Updated Employee!!!");
      this.bsModalRef.hide();
      this.onSave.emit();
    }
    )
  }
}