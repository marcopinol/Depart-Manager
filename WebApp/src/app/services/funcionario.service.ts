import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core"; 
import { Employe } from "../Models/Employe";
import { Depart } from "../Models/Depart";

@Injectable({
    providedIn: 'root'
})

export class funcionarioService{

    private urlApi = 'http://localhost:5221/api/Funcionarios'
    
    constructor(private httpClient: HttpClient){}

    GetEmployes(departId: number){
        return this.httpClient.get<Employe[]>(`${this.urlApi}/${departId}`);
    }

    /* GetEmployeDepart(departId: number){
        return this.httpClient.get<Depart>(`http://localhost:5221/api/Departamentos/${departId}`)
    } */

    PostEmploye(employe: Employe){
        return this.httpClient.post<Employe>(this.urlApi, employe);
    } 

    DeleteEmploye(employeId: number){
        return this.httpClient.delete<void>(`${this.urlApi}/${employeId}`);
    }
}