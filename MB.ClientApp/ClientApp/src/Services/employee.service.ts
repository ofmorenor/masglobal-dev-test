import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../Model/Employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private readonly http: HttpClient;
  private readonly baseUrl: string;

  public error: any;
  public loading: boolean = false;
  public employees: Employee[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  getEmployees = () => {
    this.startRequest();
    this.http.get<Employee[]>(this.baseUrl + 'employee')
    .subscribe(result => {
      this.loading = false;
      this.employees = result;
    }, error => this.handleError(error));
  }
  
  getEmployeeById = (id: number) => {
    this.startRequest();
    this.http.get<Employee>(this.baseUrl + `employee/${id}`)
    .subscribe(result => {
      this.loading = false;
      this.employees = [result];
    }, error => this.handleError(error));
  }

  startRequest = () => {
    this.error = null;
    this.employees = [];
    this.loading = true;
  }

  handleError = (err) => {
    this.error = err;
    this.loading = false;
    console.error(err);
  }

}
