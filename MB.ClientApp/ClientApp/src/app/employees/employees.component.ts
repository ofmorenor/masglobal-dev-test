import { Component } from '@angular/core';
import { EmployeeService } from '../../Services/employee.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'employees',
  templateUrl: './employees.component.html',
})
export class EmployeesComponent {
  form: FormGroup;

  constructor(public employeeService: EmployeeService, formBuilder: FormBuilder) {
    this.form = formBuilder.group(
      { 'employeeId': ['', Validators.pattern(/^([1-9]\d*\s*$)/)]}
    );
  }

  onSubmit() {
    const id = this.form.get('employeeId').value.trim();
    if (id) {
      this.employeeService.getEmployeeById(id);
    }
    else {
      this.employeeService.getEmployees();
    }
  }

}
