import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DepartamentosComponent } from './departamentos/departamentos.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NovoComponent } from './novo/novo.component';
import { EditComponent } from './edit/edit.component';
import { FuncionariosComponent } from './funcionarios/funcionarios.component';
import { NovoFuncionarioComponent } from './novo-funcionario/novo-funcionario.component';

const routes: Routes = [
  {path: '', redirectTo: 'dashboard', pathMatch: 'full'},
  {path: 'dashboard', component: DashboardComponent},
  {path: 'dashboard/departamentos', component: DepartamentosComponent},
  {path: 'dashboard/departamentos/novo', component: NovoComponent},
  {path: 'dashboard/departamentos/edit', component: EditComponent},
  {path: 'dashboard/departamentos/funcionarios', component: FuncionariosComponent},
  {path: 'dashboard/departamentos/funcionarios/novo', component: NovoFuncionarioComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
