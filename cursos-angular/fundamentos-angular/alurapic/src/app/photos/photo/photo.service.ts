import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Photo } from './photo';

const API = 'http://localhost:3000';

// Quando o Angular criar a instância dessa classe será no projeto raiz (Todo o projeto terá acesso a essa mesma instância)
@Injectable({ providedIn: 'root' })
export class PhotoService {
  // public/private no construtor (entende que não somente recebe um valor, mas torna ele como uma propriedade da classe)
  // private -> Ninguém fora de PhotoService (classe) poderá acessar essa propriedade

  constructor(private http: HttpClient) {}

  listFromUser(userName: string) {
    // Subscribe só deve ser usada na hora de buscar os dados
    return this.http.get<Photo[]>(API + '/' + userName + '/photos'); // Tipando o retorno para <Object[]>
  }

  listFromUserPaginated(userName: string, page: number) {
    const params = new HttpParams().append('page', page.toString());

    return this.http.get<Photo[]>(API + '/' + userName + '/photos', { params });
}

  // string -> string y = 'flávio';
  // String -> String y = new String('flávio);

}
