import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registerForm: FormGroup; 
  constructor(private fb: FormBuilder, private authService: AuthService) { 
    this.registerForm = this.fb.group({
      'username': ['', Validators.required],
      'email'   : ['',Validators.required],
      'password': ['',Validators.required],
    })
  }

  ngOnInit(): void {
  }
  register() {
    this.authService.register(this.registerForm.value).subscribe(data => {
      console.log(data)
    })
  }
  get username() {
    return this.registerForm.get('username');
  }
  get email(){
    return this.registerForm.get('email');
  }
  get password(){
    return this.registerForm.get('password');
  }
}
//https://www.youtube.com/watch?v=snGElYBh7eg