import { Component, OnInit } from '@angular/core';
import { DepartamentoService } from '../services/departamento.service';
import { funcionarioService } from '../services/funcionario.service';
import { Depart } from '../Models/Depart';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-departamentos',
  templateUrl: './departamentos.component.html',
  styleUrls: ['./departamentos.component.css']
})

export class DepartamentosComponent implements OnInit {
  public departamentos$ = new Observable<Depart[]>();

  constructor(private departamentoService: DepartamentoService, private funcionarioService: funcionarioService){
  }

  obterDepartsCadastrados() {
    this.departamentos$ = this.departamentoService.GetDeparts();
  }
  deletarDepart(departId: number){
    this.departamentoService.DeleteDepart(departId)
      .subscribe(_ => this.obterDepartsCadastrados());
  }
  obterFuncionarios(departId: number){
    this.funcionarioService.GetEmployes(departId);
  }

  ngOnInit(): void {
    this.obterDepartsCadastrados();
  }
}