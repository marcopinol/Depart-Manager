import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Employe } from '../Models/Employe';
import { funcionarioService } from '../services/funcionario.service';

@Component({
  selector: 'app-funcionarios',
  templateUrl: './funcionarios.component.html',
  styleUrls: ['./funcionarios.component.css']
})
export class FuncionariosComponent {
  public funcionarios$ = new Observable<Employe[]>(); 
  departId!:number

  constructor(private funcionarioService: funcionarioService){}

  obterFuncionariosDepart(departamentoId: number){
    this.funcionarios$ = this.funcionarioService.GetEmployes(departamentoId);
  }

  deletarFuncionario(employeId: number){
    this.funcionarioService.DeleteEmploye(employeId).subscribe(_ => this.obterFuncionariosDepart)
  }
}
