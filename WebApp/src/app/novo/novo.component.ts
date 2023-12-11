import { Component } from '@angular/core';
import { DepartamentoService } from '../services/departamento.service';
import { DepartamentosComponent } from '../departamentos/departamentos.component';

@Component({
  selector: 'app-novo',
  templateUrl: './novo.component.html',
  styleUrls: ['./novo.component.css']
})

export class NovoComponent {
  //Forms
  id!:number
  nome = ''
  sigla = ''
  departamentoId!:number

  constructor(private departService: DepartamentoService, private depart: DepartamentosComponent){
  }

  CadastrarDepart(){
    if(!this.sigla || !this.nome){
      return;
    }

    this.departService.PostDepart({id: this.id, nome: this.nome, sigla: this.sigla})
      .subscribe(_ => this.depart.obterDepartsCadastrados())
  }
}