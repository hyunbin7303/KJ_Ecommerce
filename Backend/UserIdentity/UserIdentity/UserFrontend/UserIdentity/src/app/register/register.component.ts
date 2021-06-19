import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registerForm: FormGroup; 
  constructor(private fb: FormBuilder) { 
    this.registerForm = this.fb.group({
      'username': [''],
      'email'   : [''],
      'password': [''],
    })
  }

  ngOnInit(): void {
  }
  register() {
    console.log(this.registerForm.value)
  }
}
