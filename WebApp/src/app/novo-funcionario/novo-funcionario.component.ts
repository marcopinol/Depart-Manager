import { Component } from '@angular/core';
import { funcionarioService } from '../services/funcionario.service';
import { DepartamentoService } from '../services/departamento.service';
import { FuncionariosComponent } from '../funcionarios/funcionarios.component';

@Component({
  selector: 'app-novo-funcionario',
  templateUrl: './novo-funcionario.component.html',
  styleUrls: ['./novo-funcionario.component.css']
})
export class NovoFuncionarioComponent {
  //Forms
  id!:number
  nome:string = ''
  RG:string = ''
  departId!:number

  constructor(private funcionarioService: funcionarioService, private departamentoService: DepartamentoService, private employe: FuncionariosComponent){}

   CadastrarFuncionario(){
    
  if(!this.nome || !this.RG || !this.departId)
    window.alert('Algum campo está vazio. Por favor preencha todos')
    
  this.funcionarioService.PostEmploye({id: this.id, nome: this.nome, rg: this.RG, departamentoId: this.departId })
    .subscribe(_ => this.employe.obterFuncionariosDepart)    
  }
}