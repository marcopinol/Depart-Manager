import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core"; 
import { Observable } from "rxjs";
import { Depart } from "../Models/Depart";

@Injectable({
    providedIn: 'root'
})

export class DepartamentoService{

    private urlApi = 'http://localhost:5221/api/Departamentos'

    constructor(private httpClient: HttpClient) { }

    GetDeparts(){   
        return this.httpClient.get<Depart[]>(this.urlApi)
    }

    PostDepart(departamento: Depart){
        return this.httpClient.post<Depart>(this.urlApi, departamento);
    }

    DeleteDepart(departId: number){
        return this.httpClient.delete<void>(`${this.urlApi}/${departId}`);
    }
}