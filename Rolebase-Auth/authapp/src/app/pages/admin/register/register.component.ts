import { Component, inject } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { MaterialModel } from 'src/app/material.model';
import { AppRoutingModule } from "src/app/app-routing.module";
import { Router, RouterLink } from '@angular/router';
import { UserService } from 'src/app/_services/user.service';
import { UserRegister } from 'src/app/_models/user.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ReactiveFormsModule, MaterialModel, RouterLink],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  userService = inject(UserService);
  toastr = inject(ToastrService);
  router = inject(Router);

  response: any;

  _regform = this.builder.group({
    userName: this.builder.control('', Validators.compose([Validators.required,
                                      Validators.minLength(5)])),
    password: this.builder.control('', Validators.required),
    confirmPassword: this.builder.control('', Validators.required),
    name: this.builder.control('', Validators.required),
    email: this.builder.control('', Validators.required),
    phone: this.builder.control('', Validators.required)
  })

    constructor(private builder: FormBuilder){

    }

    proceedRegister(){
      if(this._regform.valid){
        let userRegister: UserRegister = {
          userName: this._regform.value.userName as string,
          name: this._regform.value.name as string,
          phone: this._regform.value.phone as string,
          email: this._regform.value.email as string,
          password: this._regform.value.password as string
        }
        console.log(userRegister);
        // this.userService.userRegistration(userRegister).subscribe({
        //   next: result => this.response = result
        // });
        this.toastr.success("User added");
        this.router.navigateByUrl('/confirmotp');
      }
    }

}
