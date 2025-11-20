import { Routes } from "@angular/router";
import { HomeComponent } from "./pages/home/home.component";
import { RegisterComponent } from "./pages/admin/register/register.component";
import { LoginComponent } from "./pages/admin/login/login.component";
import { ConfirmotpComponent } from "./pages/admin/confirmotp/confirmotp.component";

export const routes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'register', component: RegisterComponent},
  { path: 'login', component: LoginComponent},
  { path: 'confirmotp', component: ConfirmotpComponent}

];
