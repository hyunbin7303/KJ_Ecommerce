import { __decorate } from "tslib";
import { Component } from '@angular/core';
let RegisterComponent = class RegisterComponent {
    constructor(fb) {
        this.fb = fb;
        this.registerForm = this.fb.group({
            'username': [''],
            'email': [''],
            'password': [''],
        });
    }
    ngOnInit() {
    }
    register() {
        console.log(this.registerForm.value);
    }
};
RegisterComponent = __decorate([
    Component({
        selector: 'app-register',
        templateUrl: './register.component.html',
        styleUrls: ['./register.component.css']
    })
], RegisterComponent);
export { RegisterComponent };
//# sourceMappingURL=register.component.js.map