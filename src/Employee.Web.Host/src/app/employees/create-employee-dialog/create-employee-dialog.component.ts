import { Component, Injector, EventEmitter } from '@angular/core';
import { EmployeeDto, EmployeeServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import * as internal from 'stream';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
  selector: 'app-create-employee-dialog',
  templateUrl: './create-employee-dialog.component.html',
})
export class CreateEmployeeDialogComponent extends AppComponentBase {
  _create = "Create New Employee"
  employee = new EmployeeDto()
  onCreate = new EventEmitter()

  constructor(
    injector: Injector,
    public bsModalRef: BsModalRef,
    private _employeeService: EmployeeServiceProxy
  )
  {
    super(injector)
  }

  // save to database
  save(){ 
      const employee = new EmployeeDto
      employee.init(this.employee)
      this._employeeService.create(employee).subscribe(()=>{
      this.notify.info("Added Employee!!!");
      this.bsModalRef.hide();
      this.onCreate.emit();
    }
    )

  }
}
