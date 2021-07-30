import { PhotoService } from './photos/photo/photo.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  photos: any[] = [];

  // Construtor = somente injeção de dependências
  constructor(private photoService: PhotoService) { }

  // OnInit ocorre depois da instanciação de AppComponent, e depois do componente receber as inbound properties
  // OnInit = códigos de inicialização de configuração
  ngOnInit(): void {
      this.photoService.listFromUser('flavio').subscribe((photos) => {
      console.log(photos[0].description);
      this.photos = photos;
    });
  }

}
