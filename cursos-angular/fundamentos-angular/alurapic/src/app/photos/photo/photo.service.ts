import { Photo } from './photo';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

const API = "http://localhost:3000";

//Quando o Angular criar a instância dessa classe será no projeto raiz (Todo o projeto terá acesso a essa mesma instância)
@Injectable({ providedIn: 'root' })
export class PhotoService {
  //public/private no construtor (entende que não somente recebe um valor, mas torna ele como uma propriedade da classe *poderá ser acessada)
  //private -> Ninguém fora de PhotoService (classe) poderá acessar essa propriedade

  constructor(private http: HttpClient) {}

  listFromUser(userName: string) {
    //subscribe só deve ser usada na hora de buscar os dados
    return this.http.get<Photo[]>(API + "/flavio/photos"); //Tipando o retorno para <Object[]>
  }
}

//string -> string y = 'flávio';
//String -> String y = new String('flávio);
