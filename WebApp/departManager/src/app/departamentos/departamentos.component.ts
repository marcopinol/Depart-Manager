import { Component } from '@angular/core';
import { DepartamentoService } from '../services/departamento.service';
import { Depart } from '../Models/Depart';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-departamentos',
  templateUrl: './departamentos.component.html',
  styleUrls: ['./departamentos.component.css']
})

export class DepartamentosComponent{
  public departamentos$ = new Observable<Depart[]>();

  constructor(private departamentoService: DepartamentoService){
  }
  
  obterDepartsCadastrados() {
    this.departamentos$ = this.departamentoService.GetDeparts();
  }
  deletarDepart(departId: number){
    this.departamentoService.DeleteDepart(departId)
      .subscribe(_ => this.obterDepartsCadastrados());
  }

  public funcionarios = [
    {id: 1, nome: 'Laura Ferreira', RG: '2163547126', departId: 1},
    {id: 2, nome: 'Lucas da Rocha', RG: '2763578612', departId: 3},
    {id: 5, nome: 'Pedro Alves', RG: '4582367123', departId: 2},
  ]
}