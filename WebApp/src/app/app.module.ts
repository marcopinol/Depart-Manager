import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DepartamentosComponent } from './departamentos/departamentos.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NovoComponent } from './novo/novo.component';
import { FormsModule } from '@angular/forms';
import { DepartamentoService } from './services/departamento.service';
import { EditComponent } from './edit/edit.component';
import { FuncionariosComponent } from './funcionarios/funcionarios.component';
import { funcionarioService } from './services/funcionario.service';
import { NovoFuncionarioComponent } from './novo-funcionario/novo-funcionario.component';

@NgModule({
  declarations: [
    AppComponent,
    DepartamentosComponent,
    DashboardComponent,
    NovoComponent,
    EditComponent,
    FuncionariosComponent,
    NovoFuncionarioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [DepartamentoService, DepartamentosComponent, funcionarioService, FuncionariosComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
