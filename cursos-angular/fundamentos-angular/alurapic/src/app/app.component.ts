import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  //Convertanto para array de object
  photos: Object[] = [];

  constructor(http: HttpClient) {
    //const observable = http.get('http://localhost:3000/flavio/photos'); //O observable é lazy, só vai buscar os dados se estiver alguém inscrito nele *subscribe
    //observable.subscribe(); //Assim que ele se inscreve ele busca os dados
    http.get<Object[]>("http://localhost:3000/flavio/photos").subscribe(
      (photos) => (this.photos = photos),
      (err) => console.log(err.message)
    ); //Tipando o retorno para <Object[]>
  }
}
