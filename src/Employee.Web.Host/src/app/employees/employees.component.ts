import { Component, Injector, OnInit } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { DOCUMENT } from '@angular/common';
// Dialog Imports
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
// Create Employee Dialog Imports
import { CreateEmployeeDialogComponent } from './create-employee-dialog/create-employee-dialog.component'
// Edit Employee Dialog Imports
import { EditEmployeeDialogComponent } from './edit-employee-dialog/edit-employee-dialog.component';
import { EmployeeDto, EmployeeServiceProxy } from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs';



@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  animations: [appModuleAnimation()],
  // changeDetection: ChangeDetectionStrategy.OnPush
})
export class EmployeesComponent implements OnInit {

  _create = 'Create New Employee'
  employees: EmployeeDto[] = []

  constructor(
    injection: Injector,
    private _modalService: BsModalService,
    private _employeeService: EmployeeServiceProxy
  )
  {

  }

  // NgOnInit
ngOnInit(): void {
  this.getAllData()
}  


// Opern Edit Employee Dialog
  editEmployeeDialog(employee: EmployeeDto): void {
    let editModal: BsModalRef
    let employeeId: number = employee.id
    editModal: this._modalService.show(
      EditEmployeeDialogComponent,
      {
        class:'model-lg',
        initialState: {
          id: employeeId,
        }
      }
    )
  }



  //refresh Function
  getAllData(){
    this._employeeService.getAll()
    .subscribe({
      next: (data): void => {
        this.employees = data
      }
    })
  } 

  // Delete Function(s)
  deleteEmployee(employee: EmployeeDto): void {
    // Confirmation Warning
    
      abp.message.confirm(
        `Are you sure you want to delete ${employee.fName} ${employee.lName}?`,
        undefined,
        (result: boolean) => {
          if (result) {
            this._employeeService.delete(employee.id)
            .pipe(
              finalize(()=> abp.notify.success("Successfuly Deleted"))
              ).subscribe(()=>{this.getAllData()})}
        }
      )
  }
  

  // Open Create Employee Dialog
  openCreateDialog(): void {
    let createModal: BsModalRef
    createModal: this._modalService.show(
      CreateEmployeeDialogComponent,
      {
        class:'model-lg'
      }
    )
    createModal.content.onCreate.subscribe(()=>{this.getAllData()})
  }

}
