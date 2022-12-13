import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { Validators } from '@angular/forms';
let LoginComponent = class LoginComponent {
    constructor(fb) {
        this.fb = fb;
        this.loginForm = this.fb.group({
            'username': ['', [Validators.required]],
            'password': ['', [Validators.required]]
        });
    }
    ngOnInit() {
    }
    login() {
        console.log(this.loginForm.value);
    }
};
LoginComponent = __decorate([
    Component({
        selector: 'app-login',
        templateUrl: './login.component.html',
        styleUrls: ['./login.component.css']
    })
], LoginComponent);
export { LoginComponent };
//# sourceMappingURL=login.component.js.map